using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace 古籍管理系统
{
    public partial class RightSet : Form
    {
        public RightSet()
        {
            InitializeComponent();
        }

        private void RightSet_Load(object sender, EventArgs e)
        {
            this.rightbox.SelectedIndex = 0;
            Fill();

        }

        private void button1_Click(object sender, EventArgs e)
        {
          if (this.txtnum.Text == string.Empty)
            {
                MessageBox.Show("请输入最大借阅古籍数量！", "提示！");
                return;
            }
            if (this.txtday.Text == string.Empty)
            {
                MessageBox.Show("请输入最大借阅古籍时间！", "提示！");
                return;
            }
            if (this.txtcost.Text == string.Empty)
            {
                MessageBox.Show("请输入借书押金金额！", "提示！");
                return;
            }
            if (this.txtfine.Text == string.Empty)
            {
                MessageBox.Show("请输入超期罚款金额！", "提示！");
                return;
            }
            if (this.txttim.Text == string.Empty)
            {
                MessageBox.Show("请输入古籍遗失罚款倍数！", "提示！");
                return;
            }

            ArrayList arr = new ArrayList();
            foreach (TreeNode nodes in this.treeright.Nodes)
            {
               if (nodes.Checked)
                {
                   arr.Add("1");
                }
                else
                {
                    arr.Add("0");
                }
                foreach(TreeNode node in nodes.Nodes)
                {
                    if (node.Checked)
                    {
                        arr.Add("1");
                    }
                    else
                    {
                        arr.Add("0");
                    }
                }
            }

            string[] a=new string[11];
            for (int i = 0; i < arr.Count; i++)
            {
                if (arr[i].ToString().Trim() == "1")
                {
                    a[i] = "yes";
                }
                else
                {
                    a[i] = "no";
                }
            }

            string sql = string.Empty;
            sql += "select * from tb_right where uright='" + this.rightbox.Text + "'";
            DataTable dt = DBHelp.ExeOleCommand(sql);

            bool b = false;

            while (dt.Rows.Count != 0)
            {
                b = true;
                break;
            }

            string sql1;

            if (b)
            {
                sql1 = "update tb_right set ";
                sql1 += "maxbook='" + this.txtnum.Text + "',";
                sql1 += "maxdate='" + this.txtday.Text + "',";
                sql1 += "rcost='" + this.txtcost.Text + "',";
                sql1 += "rfine='" + this.txtfine.Text + "',";
                sql1 += "rtim='" + this.txttim.Text + "',";
                sql1 += "rbm='" + a[0] + "',";
                sql1 += "rum='" + a[1] + "',";
                sql1 += "rrm='" + a[2] + "',";
                sql1 += "rborm='" + a[3] + "',";
                sql1 += "ris='" + a[4] + "',";
                sql1 += "rbis='" + a[5] + "',";
                sql1 += "ruis='" + a[6] + "',";
                sql1 += "rboris='" + a[7] + "',";
                sql1 += "rblp='" + a[8] + "',";
                sql1 += "rbl='" + a[9] + "',";
                sql1 += "rlp='" + a[10] + "' ";
                sql1 += "where uright='" + this.rightbox.Text + "'";
            }
            else
            {
                sql1 = "insert into tb_right(uright,maxbook,maxdate,rcost,rfine,rtim,rbm,rum,rrm,rborm,ris,rbis,ruis,rboris,rblp,rbl,rlp)";
                sql1 += " values('" + this.rightbox.Text + "','" + this.txtnum.Text + "','" + this.txtday.Text + "','" + this.txtcost.Text + "','" + this.txtfine.Text + "','" + this.txttim.Text + "','" + a[0] + "','" + a[1] + "','" + a[2] + "','" + a[3] + "','" + a[4] + "','" + a[5] + "','" + a[6] + "','" + a[7] + "','" + a[8] + "','" + a[9] + "','" + a[10] + "')";
            }

            DataTable dt1 = DBHelp.ExeOleCommand(sql1);

            Fill();
        }

        private void Fill()
        {
            string sql;
            sql = "select rid as ID号,uright as 用户身份, maxbook as 最大借书数量,maxdate as 最大借阅时间,rcost as 押金,rfine as 超期罚率,rtim as 遗失赔率,rbm as 古籍管理,rum as 用户管理,rrm as 权限管理,rborm as 借阅管理,ris as 信息查询,rbis as 古籍信息查询,ruis as 用户信息查询,rboris as 借阅历史查询,rblp as 古籍挂失处理,rbl as 古籍挂失,rlp as 挂失处理 from tb_right";

            DataTable dt = DBHelp.ExeOleCommand(sql);
            this.dataGridView1.DataSource = dt;
        }


        }

}
    

