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
    public partial class BookLost : Form
    {
        public BookLost()
        {
            InitializeComponent();
        }
        private void FillBook()
        {
            string s = string.Empty;
            s += "select * from tb_book";
            s += " where bno='" + this.notxt.Text + "'";

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
            }
            else
            {
                MessageBox.Show("未找到该书！", "提示！");

                Clears();
            }
        }

        private void Clears()
        {
            this.notxt.Text = "";
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
        }

        private void checknookbtn_Click(object sender, EventArgs e)
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

        private void btnguashi_Click(object sender, EventArgs e)
        {
            if (this.nametxt.Text == "")
            {
                MessageBox.Show("请点击放大镜获取古籍信息！", "提示！");
                return;
            }

            if (this.bstatetxt.Text == "在库")
            {
                MessageBox.Show("本次挂失失败，该书并未借出！", "提示！");
                Clears();
            }
            else if (this.bstatetxt.Text == "借出")
            {
                string sql1 = string.Empty;
                sql1 += "update tb_book set bstate='挂失'";
                sql1 += " where bno='" + this.notxt.Text + "'";

                DataTable dt1 = DBHelp.ExeOleCommand(sql1);

                string sql2 = string.Empty;
                sql2 += "update tb_borrow set borstate='挂失'";
                sql2 += " where bno='" + this.notxt.Text + "' and borstate='未还'";

                DataTable dt2 = DBHelp.ExeOleCommand(sql2);

                FillBook();
                MessageBox.Show("挂失操作成功", "提示！");
            }
            else if (this.bstatetxt.Text == "挂失")
            {
                MessageBox.Show("本次挂失失败，挂失处理已经被执行过了！", "提示！");
                Clears();
            }
            else if (this.bstatetxt.Text == "丢失")
            {
                MessageBox.Show("本次挂失失败，该书已经确认丢失！", "提示！");
                Clears();
            }
        }

        private void BookLost_Load(object sender, EventArgs e)
        {

        }

       
    }
}
