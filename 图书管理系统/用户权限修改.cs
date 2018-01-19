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
    public partial class UserRight : Form
    {
        public UserRight()
        {
            InitializeComponent();
        }

        private void btnquxiao_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UserRight_Load(object sender, EventArgs e)
        {
            this.checkbox.SelectedIndex = 0;
            this.partbox.SelectedIndex = 0;

        }
        private void Fill()
        {
            if (this.checktxt.Text == "")
            {
                MessageBox.Show("请选择要使用的查询字段！", "提示！");
                return;
            }

            if (this.partbox.Text == "")
            {
                MessageBox.Show("请选择用户所在的部门！", "提示！");
                return;
            }

            string sql = string.Empty;
            sql += "select uid as ID号,uacc as 帐号,uname as 姓名,usex as 性别,upart as 部门,utelphone as 移动电话,uphone as 固定电话,udate as 注册日期,uright as 权限 from tb_user";

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

                if (this.partbox.SelectedIndex.ToString() != "0")
                {
                    sql += " and upart='" + this.partbox.Text + "'";
                }
            }
            else
            {
                if (this.partbox.SelectedIndex.ToString() != "0")
                {
                    sql += " where upart='" + this.partbox.Text + "'";
                }
            }

            sql += " order by uacc asc";

            DataTable dt = DBHelp.ExeOleCommand(sql);
            this.dataGridView1.DataSource = dt;
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            Fill();
        }

        private void btnCorrect_Click(object sender, EventArgs e)
        {
             if (this.txtuacc.Text == "")
            {
                MessageBox.Show("执行操作前，请先在下表选择要修改的用户！", "提示！");
                return;
            }

            DialogResult res;
            res=MessageBox.Show("您确定要修改该用户吗？", "提示！", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                string sql = string.Empty;
                sql += "update tb_user set uright='"+this.txtright.Text+"'";
                sql += " where uacc='"+this.txtuacc.Text+"'";

                DataTable dt = DBHelp.ExeOleCommand(sql);
                MessageBox.Show("修改成功！","恭喜！");

                Fill();
            }
        }

         private void cell_click(object sender, DataGridViewCellEventArgs e)
        {
            this.txtuacc.Text = this.dataGridView1[1, this.dataGridView1.CurrentCell.RowIndex].Value.ToString().Trim();
            this.txtname.Text = this.dataGridView1[2, this.dataGridView1.CurrentCell.RowIndex].Value.ToString().Trim();
            this.txtsex.Text = this.dataGridView1[3, this.dataGridView1.CurrentCell.RowIndex].Value.ToString().Trim();
            this.txtpart.Text = this.dataGridView1[4, this.dataGridView1.CurrentCell.RowIndex].Value.ToString().Trim();
            this.txttel.Text = this.dataGridView1[5, this.dataGridView1.CurrentCell.RowIndex].Value.ToString().Trim();
            this.txtphone.Text = this.dataGridView1[6, this.dataGridView1.CurrentCell.RowIndex].Value.ToString().Trim();
            this.txtdate.Text = this.dataGridView1[7, this.dataGridView1.CurrentCell.RowIndex].Value.ToString().Trim();
            this.txtright.Text = this.dataGridView1[8, this.dataGridView1.CurrentCell.RowIndex].Value.ToString().Trim();

            this.txtright.Enabled = true;
        }

        }


    }

