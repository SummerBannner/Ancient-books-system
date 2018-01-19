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
    public partial class NewBook : Form
    {
        public NewBook()
        {
            InitializeComponent();
        }




        private void Clears()
        {
            this.booknametxt.Clear();
            //this.isbntxt.Clear();
            this.bookcosttxt.Clear();
            this.bookwritertxt.Clear();
            this.bookpubtxt.Clear();
            this.notetxt.Clear();
            this.numtxt.Clear();
        }

        private void NewBook_Load(object sender, EventArgs e)
        {
            /*
            string sql;
            sql = "select bno from tb_book order by bno asc";
            DataTable dt = DBHelp.ExeOleCommand(sql);

            for (int i = 0, k = 10000001; i < 1; i++, k++)
            {
                for (int j = 0; j < dt.Rows.Count; j++)
                {
                    if (dt.Rows[j][0].ToString().Trim().Equals(k.ToString()))
                        k++;
                }
                this.booknotxt.Items.Add(k.ToString());
            }

            this.booknotxt.SelectedIndex = 0;
            this.classtxt.SelectedIndex = 0;
            */

            string sql;
            sql = "select top 1 bno from tb_book order by bno desc";
            DataTable dt = DBHelp.ExeOleCommand(sql);

            int k;
            for (int i = 0; i < 1; i++)
            {
                if (dt.Rows[0][0].ToString() == "")
                {
                    k = 10000001;
                }
                else
                {
                    k = Convert.ToInt32(dt.Rows[0][0].ToString());
                    k++;
                }
                this.booknotxt.Items.Add(k.ToString());
            }

            this.booknotxt.SelectedIndex = 0;
            this.classtxt.SelectedIndex = 0;
        }

        private void findbtn_Click(object sender, EventArgs e)
        {
            if (this.isbntxt.Text == "")
            {
                MessageBox.Show("请输入古籍的ISBN号！", "提示！");
                return;
            }

            string sql;
            sql = "select * from tb_book where bisbn='" + this.isbntxt.Text + "'";
            SqlDataReader dr = DBHelp.OleReader(sql);
            dr.Read();

            if (dr.HasRows)
            {
                this.booknametxt.Text = dr["bname"].ToString().Trim();
                this.classtxt.Text = dr["bclass"].ToString().Trim();
                this.bookcosttxt.Text = dr["bcost"].ToString().Trim();
                this.bookwritertxt.Text = dr["bauthor"].ToString().Trim();
                this.bookpubtxt.Text = dr["bpub"].ToString().Trim();
                this.notetxt.Text = dr["bnote"].ToString().Trim();

                MessageBox.Show("找到匹配古籍信息，自动填充基本信息，请填充余下信息！", "提示！");
                this.numtxt.Enabled = true;
            }
            else
            {
                Clears();
                MessageBox.Show("未找到匹配古籍信息！", "提示！");
                this.booknotxt.Enabled = true;
                this.booknametxt.Enabled = true;
                this.classtxt.Enabled = true;
                this.bookcosttxt.Enabled = true;
                this.bookwritertxt.Enabled = true;
                this.bookpubtxt.Enabled = true;
                this.numtxt.Enabled = true;
                this.notetxt.Enabled = true;
            }

        }

        private void btnfanhui_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnbaocun_Click(object sender, EventArgs e)
        {
            if (this.booknotxt.Text == "")
            {
                MessageBox.Show("请输入古籍的信息！", "提示！");
                return;
            }
            if (this.booknametxt.Text == "")
            {
                MessageBox.Show("请输入古籍的信息！", "提示！");
                return;
            }
            if (this.classtxt.Text == "")
            {
                MessageBox.Show("请输入古籍的信息！", "提示！");
                return;
            }
            if (this.isbntxt.Text == "")
            {
                MessageBox.Show("请输入古籍的信息！", "提示！");
                return;
            }
            if (this.bookcosttxt.Text == "")
            {
                MessageBox.Show("请输入古籍的信息！", "提示！");
                return;
            }
            if (this.bookwritertxt.Text == "")
            {
                MessageBox.Show("请输入古籍的信息！", "提示！");
                return;
            }
            if (this.bookpubtxt.Text == "")
            {
                MessageBox.Show("请输入古籍的信息！", "提示！");
                return;
            }
            if (this.numtxt.Text == "")
            {
                MessageBox.Show("请输入古籍的信息！", "提示！");
                return;
            }
            if (this.notetxt.Text == "")
            {
                MessageBox.Show("请输入古籍的信息！", "提示！");
                return;
            }

            //string pat3 = @"^[\u4e00-\u9fa5]+$";//全为汉字
            //string pat4 = @"^([\u4e00-\u9fa5]+|[A-Za-z]+)$";//汉字或字母
            //string pat5 = @"^[\u4e00-\u9fa5]{2,4}$";//两到四位汉字

            string pat1 = @"^(\d[-]*){9}[\dxX]$";//古籍的ISBN号格式X-XXXX-XXXX-X或X-XXX-XXXXX-X（X为数字，以古籍实际ISBN号为准）
            string pat2 = @"^\+?[1-9][0-9]*$";//正整数
            string pat3 = @"^(0|[1-9][0-9]*)(.[0-9]{2})?$";//双精度浮点数


            bool m1 = Program.match(this.isbntxt.Text, pat1);
            bool m2 = Program.match(this.numtxt.Text, pat2);
            bool m3 = Program.match(this.bookcosttxt.Text, pat3);

            if (!m1)
            {
                MessageBox.Show("古籍的ISBN号格式为X-XXXX-XXXX-X或X-XXX-XXXXX-X（X为数字，以古籍实际ISBN号为准）！", "提示！");
                this.isbntxt.Text = "";
                return;
            }
            if (!m2)
            {
                MessageBox.Show("古籍购买数量应为大于0的整数！", "提示！");
                this.numtxt.Text = "";
                return;
            }
            if (!m3)
            {
                MessageBox.Show("古籍价格应为XX.XX元！", "提示！");
                this.bookcosttxt.Text = "";
                return;
            }

            int num;
            num = Convert.ToInt32(this.numtxt.Text);
            for (int i = 1, k = Convert.ToInt32(this.booknotxt.Text); i <= num; i++, k++)
            {
                string sql;
                sql = "insert into tb_book(bno,bname,bclass,bisbn,bcost,adder,adddate,bauthor,bpub,bstate,bnote)"
                    + "values('" + k.ToString() + "','" + this.booknametxt.Text + "','" + this.classtxt.Text + "','" + this.isbntxt.Text + "','" + this.bookcosttxt.Text + "','" + LoginForm.uname + "','" + DateTime.Now.ToString() + "','" + this.bookwritertxt.Text + "','" + this.bookpubtxt.Text + "','在库','" + this.notetxt.Text + "')";
                DataTable dt = DBHelp.ExeOleCommand(sql);
            }

            MessageBox.Show("注册成功！", "恭喜！");
            this.Hide();
        }

        private void btnchongzhi_Click(object sender, EventArgs e)
        {
            this.isbntxt.Clear();
            Clears();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

     
        
    

