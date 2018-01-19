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
    public partial class UserList : Form
    {
        public UserList()
        {
            InitializeComponent();
        }

        private void UserList_Load(object sender, EventArgs e)
        {
            this.checkbox.SelectedIndex = 0;
            this.partbox.SelectedIndex = 0;
            this.classbox.SelectedIndex = 0;	

        }
        private void Fill()
        {
            if (this.checkbox.Text == "")
            {
                MessageBox.Show("请选择要使用的查询字段！", "提示！");
                return;
            }

            if (this.partbox.Text == "")
            {
                MessageBox.Show("请选择用户所在的部门！", "提示！");
                return;
            }

            if (this.classbox.Text == "")
            {
                MessageBox.Show("请选择用户的类型！", "提示！");
                return;
            }

            string sql = string.Empty;
            sql += "select uid as ID号,uacc as 帐号,uname as 姓名,usex as 性别,upart as 部门,utelphone as 移动电话,uphone as 固定电话,udate as 注册日期,uright as 权限 from tb_user";

            //if (this.classbox.SelectedIndex.ToString() != "0")
            //{
            //    sql += " where uright='" + this.classbox.Text + "'";
            //}

            if (this.checktxt.Text != "")
            {
                string c = this.checkbox.SelectedIndex.ToString();

                switch (c)
                {
                    case "0"://用户帐号
                        if (this.checktxt.Text != string.Empty)
                        {
                            sql += " where uacc like '%" + this.checktxt.Text + "%'";
                        }
                        break;
                    case "1"://用户姓名
                        if (this.checktxt.Text != string.Empty)
                        {
                            sql += " where uname like '%" + this.checktxt.Text + "%'";
                        }
                        break;
                    default:
                        break;
                }

                if (this.classbox.SelectedIndex.ToString() != "0")
                {
                    sql += " and uright='" + this.classbox.Text + "'";
                }

                if (this.partbox.SelectedIndex.ToString() != "0")
                {
                    sql += " and upart='" + this.partbox.Text + "'";
                }
            }
            else
            {
                //sql += " where upart='" + this.partbox.Text + "'";
                if (this.classbox.SelectedIndex.ToString() != "0" && this.partbox.SelectedIndex.ToString() != "0")
                {
                    sql += " where uright='" + this.classbox.Text + "'";
                    sql += " and upart='" + this.partbox.Text + "'";
                }
                else if (this.classbox.SelectedIndex.ToString() == "0" && this.partbox.SelectedIndex.ToString() != "0")
                {
                    sql += " where upart='" + this.partbox.Text + "'";
                }
                else if (this.classbox.SelectedIndex.ToString() != "0" && this.partbox.SelectedIndex.ToString() == "0")
                {
                    sql += " where uright='" + this.classbox.Text + "'";
                }

            }

            sql += " order by uacc asc";

            DataTable dt = DBHelp.ExeOleCommand(sql);
            this.dataGridView1.DataSource = dt;
        }

        private void checkbtn_Click(object sender, EventArgs e)
        {
            Fill();
        }
        private void cell_Click(object sender, DataGridViewCellEventArgs e)
        {
            this.txtuacc.Text = this.dataGridView1[1, this.dataGridView1.CurrentCell.RowIndex].Value.ToString().Trim();
            this.txtname.Text = this.dataGridView1[2, this.dataGridView1.CurrentCell.RowIndex].Value.ToString().Trim();
            this.txtsex.Text = this.dataGridView1[3, this.dataGridView1.CurrentCell.RowIndex].Value.ToString().Trim();
            this.txtpart.Text = this.dataGridView1[4, this.dataGridView1.CurrentCell.RowIndex].Value.ToString().Trim();
            this.txttel.Text = this.dataGridView1[5, this.dataGridView1.CurrentCell.RowIndex].Value.ToString().Trim();
            this.txtphone.Text = this.dataGridView1[6, this.dataGridView1.CurrentCell.RowIndex].Value.ToString().Trim();
            this.txtdate.Text = this.dataGridView1[7, this.dataGridView1.CurrentCell.RowIndex].Value.ToString().Trim();
            this.txtright.Text = this.dataGridView1[8, this.dataGridView1.CurrentCell.RowIndex].Value.ToString().Trim();

            string sql1 = "select maxbook,maxdate from tb_right where uright='" + this.txtright.Text + "'";
            SqlDataReader dr1 = DBHelp.OleReader(sql1);
            dr1.Read();

            this.txtmaxbook.Text = dr1["maxbook"].ToString().Trim();
            this.txtmaxdate.Text = dr1["maxdate"].ToString().Trim();

            string sql2 = string.Empty;//已借古籍数量
            sql2 += "select count(*) as bornum from tb_borrow";
            sql2 += " where uacc='" + this.txtuacc.Text + "'";
            sql2 += " and borstate <> '已还' and borstate <> '丢失'";
            SqlDataReader dr2 = DBHelp.OleReader(sql2);
            dr2.Read();

            this.txtbooknum.Text = dr2["bornum"].ToString().Trim();

            int a = Convert.ToInt32(this.txtmaxdate.Text);
            string sql3 = string.Empty;//到期古籍数量
            sql3 += "select count(*) as bornum from tb_borrow";
            sql3 += " where uacc='" + this.txtuacc.Text + "'";
            sql3 += " and borstate <> '已还'";
            sql3 += " and bordate<#" + DateTime.Now.AddDays(-a) + "#";
            SqlDataReader dr3 = DBHelp.OleReader(sql3);
            dr3.Read();

            this.txtbookout.Text = dr3["bornum"].ToString().Trim();
        }

        private void btnquxiao_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnshanchu_Click(object sender, EventArgs e)
        {
             if (this.txtuacc.Text == "")
            {
                MessageBox.Show("执行操作前，请先在下表选择要删除的用户！", "提示！");
                return;
            }

            DialogResult res;
            res=MessageBox.Show("您确定要删除该用户吗？", "提示！", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                string sql = string.Empty;
                sql += "select * from tb_borrow";
                sql += " where uacc='"+this.txtuacc.Text+"'";
                sql += " and borstate <> '已还'";
                SqlDataReader dr = DBHelp.OleReader(sql);
                dr.Read();

                if (dr.HasRows)
                {
                    MessageBox.Show("该用户尚有古籍未还，无法删除！", "提示！");
                }
                else
                {
                    if (this.txtuacc.Text == LoginForm.uacc)
                    {
                        MessageBox.Show("对不起，自己无法删除自己！", "提示！");
                    }
                    else
                    {
                        string sql2 = string.Empty;
                        sql2 += "select uright from tb_user";
                        sql2 += " where uacc='" + this.txtuacc.Text + "'";

                        DataTable dt2 = DBHelp.ExeOleCommand(sql2);

                        string xxx = dt2.Rows[0][0].ToString();
                        if (xxx == "超级管理员")
                        {
                            MessageBox.Show("该用户为超级管理员，无法删除！", "提示！");
                        }
                        else
                        {
                            string str = string.Empty;
                            str += "delete from tb_user where uacc='" + this.txtuacc.Text + "'";

                            DataTable dt = DBHelp.ExeOleCommand(str);

                            MessageBox.Show("该用户已删除！", "提示！");
                            Fill();
                        }
                    }
                }
            }
        }


 
    }
}
