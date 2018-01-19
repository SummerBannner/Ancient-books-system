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
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void btntianjia_Click(object sender, EventArgs e)
        {
            if (this.usernametxt.Text == string.Empty)
            {
                MessageBox.Show("请输入用户姓名！", "提示！");
                return;
            }	

            if(this.sextxt.Text== string.Empty)
            {
                MessageBox.Show("请输入用户性别！", "提示！");
                return;
            }

            if (this.partcob.Text == string.Empty)
            {
                MessageBox.Show("请输入用户所在部门！", "提示！");
                return;
            }

            if (this.telphonetxt.Text == string.Empty)
            {
                MessageBox.Show("请输入用户移动电话！", "提示！");
                return;
            }

            if (this.phonetxt.Text == string.Empty)
            {
                MessageBox.Show("请输入用户固定电话！", "提示！");
                return;
            }

            string pat1 = @"^[0-9]{8,11}$";

            bool m1 = Program.match(this.telphonetxt.Text, pat1);
            bool m2 = Program.match(this.phonetxt.Text, pat1);

            if (!m1)
            {
                MessageBox.Show("电话号码为8到11位的正整数！","提示！");
                return;
            }

            if (!m2)
            {
                MessageBox.Show("电话号码为8到11位的正整数！", "提示！");
                return;
            }

            string sq = string.Empty;
            sq += "select * from tb_user";
            sq += " where uname='"+this.usernametxt.Text+"' and upart='"+this.partcob.Text+"' and utelphone='"+this.telphonetxt.Text+"'";
            DataTable d = DBHelp.ExeOleCommand(sq);

            bool b = false;
            while (d.Rows.Count == 0)
            {
                b = true;
                break;
            }

            if (b)
            {
                string sql = string.Empty;
                sql += "insert into tb_user(uacc,upsw,uname,usex,upart,utelphone,uphone,udate,uright)";
                sql += " values('" + this.useracctxt.Text + "','" + this.pswtxt.Text + "','" + this.usernametxt.Text + "','" + this.sextxt.Text + "','" + this.partcob.Text + "','" + this.telphonetxt.Text + "','" + this.phonetxt.Text + "','" + DateTime.Now.ToString() + "','" + this.rightbox.Text + "')";
                DataTable dt = DBHelp.ExeOleCommand(sql);

                MessageBox.Show("新用户添加成功！", "恭喜！");
                this.Hide();
            }
            else
            {
                MessageBox.Show("该用户已存在！","提示！");
                this.usernametxt.Text = "";
                this.telphonetxt.Text = "";
                this.phonetxt.Text = "";

            }
          
        }

        private void btnquxiao_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            string sql;
            sql = "select top 1 uacc from tb_user order by uacc desc";
            DataTable dt = DBHelp.ExeOleCommand(sql);

            int k;

            for (int i = 0; i < 1; i++)
            {
                if (dt.Rows[0][0].ToString() == "")
                {
                    k = 60000001;
                }
                else
                {
                    k = Convert.ToInt32(dt.Rows[0][0].ToString());
                    k++;
                }
                this.useracctxt.Items.Add(k.ToString());
            }
            this.useracctxt.SelectedIndex = 0;
            this.sextxt.SelectedIndex = 0;
            this.partcob.SelectedIndex = 0;
            this.pswtxt.Text = "123456";

        }

       


    }
}
