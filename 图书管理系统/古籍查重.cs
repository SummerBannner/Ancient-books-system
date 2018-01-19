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
    public partial class BookManaga : Form
    {
        public BookManaga()
        {
            InitializeComponent();
        }
        string bookisbn;

        private void BookManaga_Load(object sender, EventArgs e)
        {
            this.checkbox.SelectedIndex = 0;
            this.classbox.SelectedIndex = 0;

        }

        private void checkbtn_Click(object sender, EventArgs e)
        {
            FillGrid();
        }
        private void cell_click(object sender, DataGridViewCellEventArgs e)
        {
            FillInfo();
        }

        private void btnquxiao_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnxiugai_Click(object sender, EventArgs e)
        {
            if (this.nametxt.Text == string.Empty)
            {
                MessageBox.Show("执行操作前，请先选择古籍！", "提示！");
                return;
            }

            //修改同ISBN古籍信息
            string sql2 = string.Empty;
            sql2 += "update tb_book set bisbn='" + this.isbntxt.Text + "',bname='" + this.nametxt.Text + "',bclass='" + this.classtxt.Text + "',bcost=" + this.costtxt.Text + ",bauthor='" + this.writertxt.Text + "',bpub='" + this.pubtxt.Text + "',adder='" + this.addertxt.Text + "',bnote='" + this.notetxt.Text + "'";
            sql2 += " where bisbn='" + this.bookisbn + "'";

            DataTable dt2 = DBHelp.ExeOleCommand(sql2);

            string sql5 = string.Empty;
            sql5 += "update tb_borrow set bname='" + this.nametxt.Text + "',bisbn ='" + this.isbntxt.Text + "'";
            sql5 += " where bisbn='" + this.bookisbn + "'";

            DataTable dt5 = DBHelp.ExeOleCommand(sql5);
            MessageBox.Show("该类古籍信息修改成功！", "提示！");

            this.checktxt.Text = "";
            FillGrid();
            FillInfo();

        }
        private void FillGrid()
        {
            if (this.checkbox.Text == string.Empty)
            {
                MessageBox.Show("请输入你要使用的检索条件！", "提示！");
                return;
            }

            if (this.classbox.Text == string.Empty)
            {
                MessageBox.Show("请输入你要查找的古籍类型！", "提示！");
                return;
            }

            string sql = string.Empty;
            sql += "select bid as ID号, bno as 古籍编号, bname as 古籍名称,bauthor as 作者, bclass as 类别, bisbn as ISBN号, bcost as 价格,bpub as 出版社, adder as 记录员, adddate as 入库日期,bnote as 内容简介,bstate as 状态 from tb_book";

            if (this.checktxt.Text != "")
            {
                string c = this.checkbox.SelectedIndex.ToString();

                switch (c)
                {
                    case "0"://古籍名称
                        if (this.checktxt.Text != string.Empty)
                        {
                            sql += " where bname like '%" + this.checktxt.Text + "%'";
                        }
                        break;
                    case "1"://古籍编号
                        if (this.checktxt.Text != string.Empty)
                        {
                            sql += " where bno like '%" + this.checktxt.Text + "%'";
                        }
                        break;
                    case "2"://作者
                        if (this.checktxt.Text != string.Empty)
                        {
                            sql += " where bauthor like '%" + this.checktxt.Text + "%'";
                        }
                        break;
                    case "3"://isbn号
                        if (this.checktxt.Text != string.Empty)
                        {
                            sql += " where bisbn like '%" + this.checktxt.Text + "%'";
                        }
                        break;
                    case "4"://出版社
                        if (this.checktxt.Text != string.Empty)
                        {
                            sql += " where bpub like '%" + this.checktxt.Text + "%'";
                        }
                        break;
                    default:
                        break;
                }

                if (this.classbox.SelectedIndex.ToString() != "0")
                {
                    sql += " and bclass='" + this.classbox.Text + "'";
                }
            }
            else
            {
                if (this.classbox.SelectedIndex.ToString() != "0")
                {
                    sql += " where bclass='" + this.classbox.Text + "'";
                }
            }

            sql += " order by bno asc";

            DataTable dt = DBHelp.ExeOleCommand(sql);
            this.dataGridView1.DataSource = dt;
        }

        private void FillInfo()
        {
            this.lblShow.Text = this.dataGridView1[1, this.dataGridView1.CurrentCell.RowIndex].Value.ToString().Trim();

            this.isbntxt.Text = this.dataGridView1[5, this.dataGridView1.CurrentCell.RowIndex].Value.ToString().Trim();
            this.nametxt.Text = this.dataGridView1[2, this.dataGridView1.CurrentCell.RowIndex].Value.ToString().Trim();
            this.classtxt.Text = this.dataGridView1[4, this.dataGridView1.CurrentCell.RowIndex].Value.ToString().Trim();
            this.costtxt.Text = this.dataGridView1[6, this.dataGridView1.CurrentCell.RowIndex].Value.ToString().Trim();
            this.writertxt.Text = this.dataGridView1[3, this.dataGridView1.CurrentCell.RowIndex].Value.ToString().Trim();
            this.pubtxt.Text = this.dataGridView1[7, this.dataGridView1.CurrentCell.RowIndex].Value.ToString().Trim();
            this.addertxt.Text = this.dataGridView1[8, this.dataGridView1.CurrentCell.RowIndex].Value.ToString().Trim();
            this.notetxt.Text = this.dataGridView1[10, this.dataGridView1.CurrentCell.RowIndex].Value.ToString().Trim();

            this.isbntxt.Enabled = true;
            this.nametxt.Enabled = true;
            this.classtxt.Enabled = true;
            this.costtxt.Enabled = true;
            this.writertxt.Enabled = true;
            this.pubtxt.Enabled = true;
            this.notetxt.Enabled = true;

            this.bookisbn = this.isbntxt.Text;
        }


    }
}
