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
    public partial class MainForm : Form
    {
         public MainForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBoxButtons mbb = MessageBoxButtons.OKCancel;
            DialogResult dr = MessageBox.Show("确定要退出该系统吗？", "退出系统", mbb);
            if (dr == DialogResult.OK)
            {
                this.Close();
                Application.Exit();
            }
        }

        private void 注销ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form f in Application.OpenForms)
            {
                if ((f is LoginForm) && (!f.Visible)) //如果窗体是 Load 并且 是隐藏的。
                {
                    f.Visible = true; //那么窗体就显示！
                }
            }
            this.Close();
        }

        private void 古籍添加ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem tsml = (ToolStripMenuItem)sender;
            NewBook gt = new NewBook();
            String tag = tsml.Text;
            gt.Show();
            this.Enabled = true;
        }

        private void 古籍信息管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem tsml = (ToolStripMenuItem)sender;
            BookManaga gt = new BookManaga();
            String tag = tsml.Text;
            gt.Show();
            this.Enabled = true;
        }

        private void 还书管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem tsml = (ToolStripMenuItem)sender;
            BookReturn gt = new BookReturn();
            String tag = tsml.Text;
            gt.Show();
            this.Enabled = true;
        }

       

        private void 借阅历史查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 权限设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem tsml = (ToolStripMenuItem)sender;
            RightSet gt = new RightSet();
            String tag = tsml.Text;
            gt.Show();
            this.Enabled = true;
        }

        private void 用户权限修改ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem tsml = (ToolStripMenuItem)sender;
            UserRight gt = new UserRight();
            String tag = tsml.Text;
            gt.Show();
            this.Enabled = true;
        }

        //private void 个人借阅历史ToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    ToolStripMenuItem tsml = (ToolStripMenuItem)sender;
        //    Person gt = new Person();
        //    String tag = tsml.Text;
        //    gt.Show();
        //    this.Enabled = false;
        //}

        private void 古籍挂失ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem tsml = (ToolStripMenuItem)sender;
            BookLost gt = new BookLost();
            String tag = tsml.Text;
            gt.Show();
            this.Enabled = true;
        }

        private void 挂失处理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem tsml = (ToolStripMenuItem)sender;
            LostPro gt = new LostPro();
            String tag = tsml.Text;
            gt.Show();
            this.Enabled = true;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ToolStripMenuItem tsml = (ToolStripMenuItem)sender;
            RegisterForm gt = new RegisterForm();
            String tag = tsml.Text;
            gt.Show();
            this.Enabled = true;
        }

        private void 用户信息添加ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem tsml = (ToolStripMenuItem)sender;
            RegisterForm gt = new RegisterForm();
            String tag = tsml.Text;
            gt.Show();
            this.Enabled = true;
        }

        private void 用户信息管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem tsml = (ToolStripMenuItem)sender;
            UserList gt = new UserList();
            String tag = tsml.Text;
            gt.Show();
            this.Enabled = true;
        }

        private void 修改密码ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 借书ToolStripMenuItem_Click(object sender, EventArgs e)  
        {
            ToolStripMenuItem tsml = (ToolStripMenuItem)sender;
            BookBorrow gt = new BookBorrow();
            String tag = tsml.Text;
            gt.Show();
            this.Enabled = true;
        }

        private void 还书ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 借阅信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 系统ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 还书ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            ToolStripMenuItem tsml = (ToolStripMenuItem)sender;
            BookReturn gt = new BookReturn();
            String tag = tsml.Text;
            gt.Show();
            this.Enabled = true;
        }

        private void 借阅信息ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            ToolStripMenuItem tsml = (ToolStripMenuItem)sender;
            BorrowFrame gt = new BorrowFrame();
            String tag = tsml.Text;
            gt.Show();
            this.Enabled = true;
        }

        private void 系统ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }
    }
}
