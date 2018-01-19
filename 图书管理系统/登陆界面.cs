using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Configuration;

namespace 古籍管理系统
{
    public partial class LoginForm : Form
    {
        public static string uacc;
        public static string upsw;
        public static string uname;
        public static string usex;
        public static string upart;
        public static string uright;

        public LoginForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        
        private void btnDengLu_Click(object sender, EventArgs e)
        {
            if (this.useracctxt.Text.Trim() == "" && this.pswtxt.Text == "")
            {
                MessageBox.Show("请输入您的用户名和密码！", "提示！");
                return;
            }
            try
            {
                string sql;
                sql = "select * from tb_user where uacc='" + this.useracctxt.Text + "' and upsw='" + this.pswtxt.Text + "'";
                SqlDataReader dr = DBHelp.OleReader(sql);
                dr.Read();

                if (dr.HasRows)
                {
                    uacc = this.useracctxt.Text;
                    upsw = this.pswtxt.Text;
                    uname = dr["uname"].ToString();
                    usex = dr["usex"].ToString();
                    upart = dr["upart"].ToString();
                    uright = dr["uright"].ToString();

                    MainForm af = new MainForm();
                    af.Show();
                    //this.Hide();
                    this.Visible = false;//登陆窗体隐藏
                    this.useracctxt.Clear();
                    this.pswtxt.Clear();

                }
                else
                {
                    MessageBox.Show("账号或密码错误！", "提示！");
                    this.useracctxt.Clear();
                    this.pswtxt.Clear();
                    this.useracctxt.Focus();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("数据库无法连接！", "警告！");
            }
        }



        private void btnESC_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void LoginForm_Closing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}






        



     
