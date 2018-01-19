using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace 古籍管理系统
{
    public partial class BookReturn : Form
    {
        public BookReturn()
        {
            InitializeComponent();
        }

        private void BookReturn_Load(object sender, EventArgs e)
        {
            this.boxcheck.SelectedIndex = 0;
            this.boxstate.SelectedIndex = 0;

        }

        private void btncheck_Click(object sender, EventArgs e)
        {
            Fill();
        }
        private void cell_click(object sender, DataGridViewCellEventArgs e)
        {
            //用户信息
            this.txtuacc.Text = this.dataGridView1[1, this.dataGridView1.CurrentCell.RowIndex].Value.ToString().Trim();
            this.txtuname.Text = this.dataGridView1[2, this.dataGridView1.CurrentCell.RowIndex].Value.ToString().Trim();

            string sql1 = string.Empty;
            sql1 += "select usex,upart,uright from tb_user";
            sql1 += " where uacc='" + this.txtuacc.Text + "'";
            SqlDataReader dr1 = DBHelp.OleReader(sql1);
            dr1.Read();
            if (dr1.HasRows)
            {
                this.txtusex.Text = dr1["usex"].ToString().Trim();
                this.txtupart.Text = dr1["upart"].ToString().Trim();
                this.txturight.Text = dr1["uright"].ToString().Trim();
            }

            string sql2 = string.Empty;//未还古籍
            sql2 += "select count(*) as bornum from tb_borrow";
            sql2 += " where uacc='" + this.txtuacc.Text + "'";
            sql2 += " and borstate <> '已还' and borstate <> '丢失'";
            SqlDataReader dr2 = DBHelp.OleReader(sql2);
            dr2.Read();
            if (dr2.HasRows)
            {
                this.txtnoret.Text = dr2["bornum"].ToString().Trim();
            }

            string sql3 = string.Empty;//遗失古籍
            sql3 += "select count(*) as bornum from tb_borrow";
            sql3 += " where uacc='" + this.txtuacc.Text + "'";
            sql3 += " and borstate='丢失'";
            SqlDataReader dr3 = DBHelp.OleReader(sql3);
            dr3.Read();
            if (dr3.HasRows)
            {
                this.txtlost.Text = dr3["bornum"].ToString().Trim();
            }

            string maxdate;//最大权限
            string sql4 = string.Empty;
            sql4 += "select maxdate from tb_right";
            sql4 += " where uright='" + this.txturight.Text + "'";
            SqlDataReader dr4 = DBHelp.OleReader(sql4);
            dr4.Read();
            //if (dr4.HasRows)
            //{
            maxdate = dr4["maxdate"].ToString().Trim();
            //return maxdate;
            //}

            int max = Convert.ToInt32(maxdate);
            string sql5 = string.Empty;//到期古籍
            sql5 = sql2;
            string year = DateTime.Now.AddDays(-max).Year.ToString();
            string month = DateTime.Now.AddDays(-max).Month.ToString();
            string day = DateTime.Now.AddDays(-max).Day.ToString();
            sql5 += " and bordate<" + year + "-" + month + "-" + day;
            SqlDataReader dr5 = DBHelp.OleReader(sql5);
            dr5.Read();
            if (dr5.HasRows)
            {
                this.txtouttime.Text = dr5["bornum"].ToString().Trim();
            }

            //古籍信息
            this.txtbno.Text = this.dataGridView1[3, this.dataGridView1.CurrentCell.RowIndex].Value.ToString().Trim();
            this.txtbname.Text = this.dataGridView1[4, this.dataGridView1.CurrentCell.RowIndex].Value.ToString().Trim();

            string sql6 = string.Empty;//古籍信息
            sql6 += "select bclass,bisbn,bcost,bauthor,bpub from tb_book";
            sql6 += " where bno='" + this.txtbno.Text + "'";
            SqlDataReader dr6 = DBHelp.OleReader(sql6);
            dr6.Read();
            if (dr6.HasRows)
            {
                this.txtbclass.Text = dr6["bclass"].ToString().Trim();
                this.txtbisbn.Text = dr6["bisbn"].ToString().Trim();
                this.txtbcost.Text = dr6["bcost"].ToString().Trim();
                this.txtbauthor.Text = dr6["bauthor"].ToString().Trim();
                this.txtbpub.Text = dr6["bpub"].ToString().Trim();
                //this.txtbstate.Text=dr6["bstate"].ToString().Trim();
            }

            string sql7 = string.Empty;//古籍状态
            sql7 += "select borstate from tb_borrow";
            sql7 += " where bno='" + this.txtbno.Text + "'";
            SqlDataReader dr7 = DBHelp.OleReader(sql7);
            dr7.Read();
            if (dr7.HasRows)
            {
                this.txtbstate.Text = dr7["borstate"].ToString().Trim();
            }
        }

        private void btnhuanshu_Click(object sender, EventArgs e)
        {
            if (this.txtuacc.Text == string.Empty)
            {
                MessageBox.Show("请选择用户！", "提示！");
                return;
            }

            if (this.txtbno.Text == string.Empty)
            {
                MessageBox.Show("请选择古籍！", "提示！");
                return;
            }

            DialogResult result;
            result = MessageBox.Show("确认归还本书？", "还书提示！", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                string sql = string.Empty;
                sql += "select * from tb_borrow";
                sql += " where bno='" + this.txtbno.Text + "' and borstate='已还'";
                DataTable dt = DBHelp.ExeOleCommand(sql);

                bool b = false;
                while (dt.Rows.Count == 0)
                {
                    b = true;
                    break;
                }
                if (b)
                {
                    string str1 = string.Empty;//验证是否逾期
                    str1 += "select maxdate,rfine from tb_right";
                    str1 += " where uright='" + this.txturight.Text + "'";
                    SqlDataReader dr1 = DBHelp.OleReader(str1);
                    dr1.Read();
                    string max = dr1["maxdate"].ToString().Trim();
                    int m = Convert.ToInt32(max);//最大借阅期限

                    string str2 = string.Empty;
                    str2 += "select bordate from tb_borrow";
                    str2 += " where bno='" + this.txtbno.Text + "' and borstate <> '已还'";
                    SqlDataReader dr2 = DBHelp.OleReader(str2);
                    dr2.Read();
                    string date = dr2["bordate"].ToString().Trim();
                    DateTime n = Convert.ToDateTime(date);//借书日期

                    if (DateTime.Now.AddDays(-m) > n)
                    {
                        DateTime d1 = new DateTime();
                        d1 = DateTime.Now;
                        DateTime d2 = n;
                        TimeSpan ts = new TimeSpan(d1.Ticks - d2.Ticks);
                        string day = Convert.ToString(ts.Days);//逾期天数

                        this.txtoutday.Text = day;
                        this.txtoutcost.Text = dr1["rfine"].ToString().Trim();

                        double x = Convert.ToDouble(this.txtoutday.Text);
                        double y = Convert.ToDouble(this.txtoutcost.Text);
                        double z = x * y;

                        this.txtpcost.Text = Convert.ToString(z);

                        MessageBox.Show("该书已超期,请按超期信息缴费！", "提示！");

                        ReturnBook();
                    }
                    else
                    {
                        ReturnBook();
                    }
                }
                else
                {
                    MessageBox.Show("还书失败，该书在库中！", "提示！");
                }
            }

        }
        private void ReturnBook()
        {
            string str = string.Empty;
            str += "select brcost from tb_borrow";
            str += " where bno='" + this.txtbno.Text + "' and borstate <> '已还'";
            SqlDataReader dr = DBHelp.OleReader(str);
            dr.Read();

            string xx = dr["brcost"].ToString().Trim();

            string sql1 = string.Empty;
            sql1 += "update tb_borrow set retdate='" + DateTime.Now.ToString() + "',borstate='已还'";
            sql1 += " where bno='" + this.txtbno.Text + "' and uacc='" + this.txtuacc.Text + "'";

            string sql2 = string.Empty;
            sql2 += "update tb_book set bstate='在库'";
            sql2 += " where bno='" + this.txtbno.Text + "'";

            DataTable dt1 = DBHelp.ExeOleCommand(sql1);
            DataTable dt2 = DBHelp.ExeOleCommand(sql2);

            MessageBox.Show("还书成功！归还您的押金" + xx + "元", "恭喜！");

            Fill();

            string sql3 = string.Empty;//未还古籍
            sql3 += "select count(*) as bornum from tb_borrow";
            sql3 += " where uacc='" + this.txtuacc.Text + "'";
            sql3 += " and borstate <> '已还'";
            SqlDataReader dr3 = DBHelp.OleReader(sql3);
            dr3.Read();
            if (dr3.HasRows)
            {
                this.txtnoret.Text = dr3["bornum"].ToString().Trim();
            }

            string sql7 = string.Empty;//古籍状态
            sql7 += "select borstate from tb_borrow";
            sql7 += " where bno='" + this.txtbno.Text + "'";
            SqlDataReader dr7 = DBHelp.OleReader(sql7);
            dr7.Read();
            if (dr7.HasRows)
            {
                this.txtbstate.Text = dr7["borstate"].ToString().Trim();
            }
        }

        private void Fill()
        {
            string sql = string.Empty;
            sql += "select borid as ID号,uacc as 用户帐号,uname as 用户姓名,bno as 古籍编号,bname as 古籍名称,bisbn as ISBN号,brcost as 押金,bordate as 借书日期,retdate as 还书日期,borstate as 状态,brecorder as 借阅记录员 from tb_borrow";

            string m = this.boxcheck.SelectedIndex.ToString();
            string n = this.boxstate.SelectedIndex.ToString();

            if (this.txtcheck.Text.Trim() == "")
            {
                switch (n)
                {
                    //case "0"://全部借阅信息
                    case "1"://未还古籍信息
                        sql += " where borstate <> '已还'";
                        break;
                    case "2"://已还古籍信息
                        sql += " where borstate='已还'";
                        break;
                    case "3"://挂失古籍信息
                        sql += " where borstate='挂失'";
                        break;
                    case "4"://丢失古籍信息
                        sql += " where borstate='丢失'";
                        break;
                    default:
                        break;
                }
            }
            else
            {
                switch (m)
                {
                    case "0"://用户帐号
                        sql += " where uacc like '%" + this.txtcheck.Text + "%'";
                        break;
                    case "1"://用户姓名
                        sql += " where uname like '%" + this.txtcheck.Text + "%'";
                        break;
                    case "2"://古籍编号
                        sql += " where bno like '%" + this.txtcheck.Text + "%'";
                        break;
                    case "3"://古籍名称
                        sql += " where bname like '%" + this.txtcheck.Text + "%'";
                        break;
                    default:
                        break;
                }

                switch (n)
                {
                    case "1"://未还古籍信息
                        sql += " and borstate <> '已还'";
                        break;
                    case "2"://已还古籍信息
                        sql += " and borstate='已还'";
                        break;
                    case "3"://挂失古籍信息
                        sql += " and borstate='挂失'";
                        break;
                    case "4"://丢失古籍信息
                        sql += " and borstate='丢失'";
                        break;
                    default:
                        break;
                }
            }

            DataTable dt = DBHelp.ExeOleCommand(sql);
            this.dataGridView1.DataSource = dt;
        }

        private void btnquxiao_Click(object sender, EventArgs e)
        {
            this.boxcheck.SelectedIndex = 0;
            this.boxstate.SelectedIndex = 0;
            this.txtcheck.Text = "";
            //this.Close();
            //MainForm mf = new MainForm();
            //mf.Show();
        }


    }
}
