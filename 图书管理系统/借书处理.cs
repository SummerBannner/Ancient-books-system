using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace 古籍管理系统
{
    public partial class BookBorrow : Form
    {
        public BookBorrow()
        {
            InitializeComponent();
        }
        private void FillUser()
        {
            string sql = string.Empty;
            sql += "select * from tb_user where uacc='" + this.useracctxt.Text + "'";
            SqlDataReader dr = DBHelp.OleReader(sql);
            //DataTable dr = DBHelp.ExeOleCommand(sql);
            dr.Read();

            if (dr.HasRows)
            {
               
                this.sextxt.Text = dr["usex"].ToString().Trim();
                this.parttxt.Text = dr["upart"].ToString().Trim();
                this.telphonetxt.Text = dr["utelphone"].ToString().Trim();
                this.phonetxt.Text = dr["uphone"].ToString().Trim();
                this.txtright.Text = dr["uright"].ToString().Trim();
                this.usernametxt.Text = dr["uname"].ToString().Trim();
                string sql1 = string.Empty;//已借古籍数量
                sql1 += "select count(*) as bornum from tb_borrow";
                sql1 += " where uacc='" + this.useracctxt.Text + "'";
                sql1 += " and borstate <> '已还' and borstate <> '丢失'";
                SqlDataReader dr1 = DBHelp.OleReader(sql1);
                dr1.Read();

                this.havnumtxt.Text = dr1["bornum"].ToString().Trim();

                string sql2 = string.Empty;//最大借阅权限
                sql2 += "select maxbook,maxdate,rcost from tb_right";
                sql2 += " where uright='" + this.txtright.Text + "'";

                SqlDataReader dr2 = DBHelp.OleReader(sql2);
                dr2.Read();

                if (dr2.HasRows)
                {
                    this.txtmaxbook.Text = dr2["maxbook"].ToString().Trim();
                    this.txtmaxdate.Text = dr2["maxdate"].ToString().Trim();
                    this.labcost.Text = dr2["rcost"].ToString().Trim();
                }

                //string sql3 = string.Empty;//到期古籍数量
                //DateTime.Now.AddDays(-30)>//当前日期减去借书期限大于借书日期，即为逾期
                int a = Convert.ToInt32(this.txtmaxdate.Text);
                string sql3 = string.Empty;//到期古籍数量
                string year = DateTime.Now.AddDays(-a).Year.ToString();
                string month = DateTime.Now.AddDays(-a).Month.ToString();
                string day = DateTime.Now.AddDays(-a).Day.ToString();
                sql3 = sql1;
                sql3 += " and bordate<"+year+"-"+month+"-"+day ;
                SqlDataReader dr3 = DBHelp.OleReader(sql3);
                dr3.Read();

                this.canrettxt.Text = dr3["bornum"].ToString().Trim();
            }
            else
            {
                MessageBox.Show("未找到该用户或帐号错误！", "提示！");

                this.usernametxt.Text = "";
                this.sextxt.Text = "";
                this.parttxt.Text = "";
                this.telphonetxt.Text = "";
                this.phonetxt.Text = "";
                this.txtright.Text = "";
                this.havnumtxt.Text = "";
                this.txtmaxbook.Text = "";
                this.txtmaxdate.Text = "";
                this.canrettxt.Text = "";
            }
        }

        private void FillBook()
        {
            string sql = string.Empty;
            sql += "select bid as ID号, bno as 古籍编号, bname as 古籍名称,bauthor as 作者, bclass as 类别, bisbn as ISBN号, bcost as 价格,bpub as 出版社, adder as 记录员, adddate as 入库日期,bnote as 内容简介,bstate as 状态 from tb_book";
            sql += " where bno='" + this.notxt.Text + "'";
            sql += " and bstate='在库'";

            DataTable dt = DBHelp.ExeOleCommand(sql);
            this.dataGridView1.DataSource = dt;

            string s = string.Empty;
            s += "select * from tb_book";
            s += " where bno='" + this.notxt.Text + "'";
            s += " and bstate='在库'";

            SqlDataReader dr = DBHelp.OleReader(s);
            dr.Read();

            if (dr.HasRows)
            {
                this.nametxt.Text = dr["bname"].ToString().Trim();
                this.classtxt.Text = dr["bclass"].ToString().Trim();
                this.isbntxt.Text = dr["bisbn"].ToString().Trim();
                this.costtxt.Text = dr["bcost"].ToString().Trim();
                this.writertxt.Text = dr["bauthor"].ToString().Trim();
                this.pubtxt.Text = dr["bpub"].ToString().Trim();
                this.addertxt.Text = dr["adder"].ToString().Trim();
                this.adddatetxt.Text = dr["adddate"].ToString().Trim();
                this.bstatetxt.Text = dr["bstate"].ToString().Trim();
                this.notetxt.Text = dr["bnote"].ToString().Trim();

                string sql1 = string.Empty;//库存总数
                sql1 += "select count(*) as bnum from tb_book";
                sql1 += " where bisbn='" + this.isbntxt.Text + "'";
                sql1 += " and bstate <> '丢失'";
                SqlDataReader dr1 = DBHelp.OleReader(sql1);
                dr1.Read();

                string sql2 = string.Empty;//可借数目
                sql2 += "select count(*) as bnum from tb_book";
                sql2 += " where bisbn='" + this.isbntxt.Text + "'";
                sql2 += " and bstate='在库'";
                SqlDataReader dr2 = DBHelp.OleReader(sql2);
                dr2.Read();

                this.numtxt.Text = dr1["bnum"].ToString().Trim();
                this.cannumtxt.Text = dr2["bnum"].ToString().Trim();
            }
            else
            {
                MessageBox.Show("未找到该书或该书已借出！", "提示！");

                this.nametxt.Text = "";
                this.classtxt.Text = "";
                this.isbntxt.Text = "";
                this.costtxt.Text = "";
                this.writertxt.Text = "";
                this.pubtxt.Text = "";
                this.addertxt.Text = "";
                this.adddatetxt.Text = "";
                this.bstatetxt.Text = "";
                this.notetxt.Text = "";
                this.numtxt.Text = "";
                this.cannumtxt.Text = "";
            }
        }


        private void checkbtn_Click(object sender, EventArgs e)
        {
            if (this.useracctxt.Text == string.Empty)
            {
                MessageBox.Show("请输入用户的帐号！", "提示！");
                return;
            }

            FillUser();

        }

        private void checkbookbtn_Click(object sender, EventArgs e)
        {
            if (this.notxt.Text == string.Empty)
            {
                MessageBox.Show("请输入古籍的编号！", "提示！");
                return;
            }

            FillBook();

        }

        private void btnquxiao_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnjieshu_Click(object sender, EventArgs e)
        {
            if (this.usernametxt.Text == string.Empty || this.nametxt.Text == string.Empty)
            {
                MessageBox.Show("请选择用户或古籍！", "提示！");
                return;
            }

            DialogResult result;
            result = MessageBox.Show("确认借阅本书？", "借书提示！", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                //验证用户的借阅权限
                int a = Convert.ToInt32(this.havnumtxt.Text);
                int b = Convert.ToInt32(this.txtmaxbook.Text);
                int c = Convert.ToInt32(this.canrettxt.Text);

                if (a >= b)
                {
                    MessageBox.Show("对不起！该用户最多可借" + this.txtmaxbook.Text + "本书！", "提示！");
                    return;
                }

                if (c > 0)
                {
                    MessageBox.Show("对不起！该用户有" + this.canrettxt.Text + "本书超期未还！", "提示！");
                    return;
                }

                string strx = string.Empty;
                strx += "select count(*) as num from tb_borrow";
                strx += " where uacc='" + this.useracctxt.Text + "' and borstate='挂失'";
                SqlDataReader dx = DBHelp.OleReader(strx);
                dx.Read();

                string nx = dx["num"].ToString().Trim();
                int xx = Convert.ToInt32(nx);

                if (xx > 0)
                {
                    MessageBox.Show("对不起！该用户有" + nx + "本书挂失未还！", "提示！");
                    return;
                }
                //

                string sql = string.Empty;
                sql += "select * from tb_book where bno='" + this.notxt.Text + "' and bstate='在库'";
                DataTable dt = DBHelp.ExeOleCommand(sql);

                bool x = false;
                while (dt.Rows.Count != 0)
                {
                    x = true;
                    break;
                }

                if (x)
                {
                    string sql1 = string.Empty;
                    sql1 += "update tb_book set bstate='借出' where bno='" + this.notxt.Text + "' and bname='" + this.nametxt.Text + "'";

                    string sql2 = string.Empty;
                    sql2 += "insert into tb_borrow(uacc,uname,bno,bname,bisbn,brcost,bordate,retdate,borstate,brecorder)";
                    sql2 += " values('" + this.useracctxt.Text + "','" + this.usernametxt.Text + "','" + this.notxt.Text + "','" + this.nametxt.Text + "','" + this.isbntxt.Text + "','" + this.labcost.Text + "','" + DateTime.Now.ToString() + "',null,'未还','" + LoginForm.uname + "')";

                    DataTable dt1 = DBHelp.ExeOleCommand(sql1);
                    DataTable dt2 = DBHelp.ExeOleCommand(sql2);

                    MessageBox.Show("借书成功！请付押金" + this.labcost.Text + "元", "恭喜！");

                    FillUser();
                    //FillBook();
                    this.nametxt.Text = "";
                    this.classtxt.Text = "";
                    this.isbntxt.Text = "";
                    this.costtxt.Text = "";
                    this.writertxt.Text = "";
                    this.pubtxt.Text = "";
                    this.addertxt.Text = "";
                    this.adddatetxt.Text = "";
                    this.bstatetxt.Text = "";
                    this.notetxt.Text = "";
                    this.numtxt.Text = "";
                    this.cannumtxt.Text = "";
                }
                else
                {
                    MessageBox.Show("未找到该书或该书已借出！", "提示！");
                    this.nametxt.Text = "";
                    this.classtxt.Text = "";
                    this.isbntxt.Text = "";
                    this.costtxt.Text = "";
                    this.writertxt.Text = "";
                    this.pubtxt.Text = "";
                    this.addertxt.Text = "";
                    this.adddatetxt.Text = "";
                    this.bstatetxt.Text = "";
                    this.notetxt.Text = "";
                    this.numtxt.Text = "";
                    this.cannumtxt.Text = "";
                }
            }

        }

        private void btndqxx_Click(object sender, EventArgs e)
        {
            string sql = string.Empty;
            sql += "select borid as 借阅编号,uacc as 用户帐号,uname as 用户姓名,bno as 古籍编号,bname as 古籍名称,bisbn as ISBN号,brcost as 押金,bordate as 借书日期,borstate as 状态,brecorder as 记录员 from tb_borrow";
            sql += " where borstate <> '已还'";


            DataTable dt = DBHelp.ExeOleCommand(sql);
            this.dataGridView1.DataSource = dt;

        }
        private void Fill() 
        {
            //string sql = string.Empty;
            //sql += "select borid as 借阅编号,uacc as 用户帐号,uname as 用户姓名,bno as 古籍编号,bname as 古籍名称,bisbn as ISBN号,brcost as 押金,bordate as 借书日期,borstate as 状态,brecorder as 记录员 from tb_borrow";
            //sql += " where borstate <> '已还'";


            //DataTable dt = DBHelp.ExeOleCommand(sql);
            //this.dataGridView1.DataSource = dt;
            
            

            string connString = @"Data Source=SUNHAO-PC;Initial Catalog=古籍管理系统;Integrated Security=True;Pooling=False";
            SqlConnection cn = new SqlConnection(connString);
            cn.Open();
            string sql = "select borid as 借阅编号,uacc as 用户帐号,uname as 用户姓名,bno as 古籍编号,bname as 古籍名称,bisbn as ISBN号,brcost as 押金,bordate as 借书日期,borstate as 状态,brecorder as 记录员 from tb_borrow where borstate <> '已还'";
            SqlDataAdapter adp = new SqlDataAdapter(sql, cn);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            this.dataGridView1.DataSource = ds.Tables[0].DefaultView;

        }

        private void BookBorrow_Load(object sender, EventArgs e)
        {
            Fill();
        }




    }
}
