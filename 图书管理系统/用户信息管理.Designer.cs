namespace 古籍管理系统
{
    partial class UserList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checktxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.checkbtn = new System.Windows.Forms.Button();
            this.classbox = new System.Windows.Forms.ComboBox();
            this.partbox = new System.Windows.Forms.ComboBox();
            this.checkbox = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnquxiao = new System.Windows.Forms.Button();
            this.btnshanchu = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txtbookout = new System.Windows.Forms.TextBox();
            this.txtbooknum = new System.Windows.Forms.TextBox();
            this.txtright = new System.Windows.Forms.TextBox();
            this.txtdate = new System.Windows.Forms.TextBox();
            this.txtphone = new System.Windows.Forms.TextBox();
            this.txttel = new System.Windows.Forms.TextBox();
            this.txtmaxdate = new System.Windows.Forms.TextBox();
            this.txtmaxbook = new System.Windows.Forms.TextBox();
            this.txtpart = new System.Windows.Forms.TextBox();
            this.txtsex = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtuacc = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checktxt);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.checkbtn);
            this.groupBox1.Controls.Add(this.classbox);
            this.groupBox1.Controls.Add(this.partbox);
            this.groupBox1.Controls.Add(this.checkbox);
            this.groupBox1.ForeColor = System.Drawing.Color.Blue;
            this.groupBox1.Location = new System.Drawing.Point(14, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(266, 124);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "简单查询";
            // 
            // checktxt
            // 
            this.checktxt.Location = new System.Drawing.Point(84, 20);
            this.checktxt.Name = "checktxt";
            this.checktxt.Size = new System.Drawing.Size(119, 21);
            this.checktxt.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(25, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "用户类型:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(25, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "用户部门:";
            // 
            // checkbtn
            // 
            this.checkbtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.checkbtn.Location = new System.Drawing.Point(209, 22);
            this.checkbtn.Name = "checkbtn";
            this.checkbtn.Size = new System.Drawing.Size(51, 23);
            this.checkbtn.TabIndex = 3;
            this.checkbtn.Text = "查询";
            this.checkbtn.UseVisualStyleBackColor = true;
            this.checkbtn.Click += new System.EventHandler(this.checkbtn_Click);
            // 
            // classbox
            // 
            this.classbox.FormattingEnabled = true;
            this.classbox.Items.AddRange(new object[] {
            "超级管理员",
            "管理员",
            "用户"});
            this.classbox.Location = new System.Drawing.Point(84, 92);
            this.classbox.Name = "classbox";
            this.classbox.Size = new System.Drawing.Size(176, 20);
            this.classbox.TabIndex = 2;
            // 
            // partbox
            // 
            this.partbox.FormattingEnabled = true;
            this.partbox.Items.AddRange(new object[] {
            "茗园",
            "蕙园"});
            this.partbox.Location = new System.Drawing.Point(83, 57);
            this.partbox.Name = "partbox";
            this.partbox.Size = new System.Drawing.Size(177, 20);
            this.partbox.TabIndex = 1;
            // 
            // checkbox
            // 
            this.checkbox.FormattingEnabled = true;
            this.checkbox.Items.AddRange(new object[] {
            "用户账号",
            "用户姓名"});
            this.checkbox.Location = new System.Drawing.Point(12, 22);
            this.checkbox.Name = "checkbox";
            this.checkbox.Size = new System.Drawing.Size(60, 20);
            this.checkbox.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnquxiao);
            this.groupBox2.Controls.Add(this.btnshanchu);
            this.groupBox2.ForeColor = System.Drawing.Color.Blue;
            this.groupBox2.Location = new System.Drawing.Point(14, 148);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(266, 69);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "操作";
            // 
            // btnquxiao
            // 
            this.btnquxiao.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnquxiao.Location = new System.Drawing.Point(185, 29);
            this.btnquxiao.Name = "btnquxiao";
            this.btnquxiao.Size = new System.Drawing.Size(75, 23);
            this.btnquxiao.TabIndex = 1;
            this.btnquxiao.Text = "取消";
            this.btnquxiao.UseVisualStyleBackColor = true;
            this.btnquxiao.Click += new System.EventHandler(this.btnquxiao_Click);
            // 
            // btnshanchu
            // 
            this.btnshanchu.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnshanchu.Location = new System.Drawing.Point(83, 29);
            this.btnshanchu.Name = "btnshanchu";
            this.btnshanchu.Size = new System.Drawing.Size(75, 23);
            this.btnshanchu.TabIndex = 0;
            this.btnshanchu.Text = "删除";
            this.btnshanchu.UseVisualStyleBackColor = true;
            this.btnshanchu.Click += new System.EventHandler(this.btnshanchu_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.txtbookout);
            this.groupBox3.Controls.Add(this.txtbooknum);
            this.groupBox3.Controls.Add(this.txtright);
            this.groupBox3.Controls.Add(this.txtdate);
            this.groupBox3.Controls.Add(this.txtphone);
            this.groupBox3.Controls.Add(this.txttel);
            this.groupBox3.Controls.Add(this.txtmaxdate);
            this.groupBox3.Controls.Add(this.txtmaxbook);
            this.groupBox3.Controls.Add(this.txtpart);
            this.groupBox3.Controls.Add(this.txtsex);
            this.groupBox3.Controls.Add(this.txtname);
            this.groupBox3.Controls.Add(this.txtuacc);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.ForeColor = System.Drawing.Color.Blue;
            this.groupBox3.Location = new System.Drawing.Point(286, 18);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(457, 199);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "用户信息";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label18.Location = new System.Drawing.Point(420, 173);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(17, 12);
            this.label18.TabIndex = 27;
            this.label18.Text = "本";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label17.Location = new System.Drawing.Point(420, 145);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(17, 12);
            this.label17.TabIndex = 26;
            this.label17.Text = "本";
            // 
            // txtbookout
            // 
            this.txtbookout.Location = new System.Drawing.Point(314, 170);
            this.txtbookout.Name = "txtbookout";
            this.txtbookout.Size = new System.Drawing.Size(100, 21);
            this.txtbookout.TabIndex = 25;
            // 
            // txtbooknum
            // 
            this.txtbooknum.Location = new System.Drawing.Point(314, 142);
            this.txtbooknum.Name = "txtbooknum";
            this.txtbooknum.Size = new System.Drawing.Size(100, 21);
            this.txtbooknum.TabIndex = 24;
            // 
            // txtright
            // 
            this.txtright.Location = new System.Drawing.Point(314, 109);
            this.txtright.Name = "txtright";
            this.txtright.Size = new System.Drawing.Size(123, 21);
            this.txtright.TabIndex = 23;
            // 
            // txtdate
            // 
            this.txtdate.Location = new System.Drawing.Point(314, 84);
            this.txtdate.Name = "txtdate";
            this.txtdate.Size = new System.Drawing.Size(123, 21);
            this.txtdate.TabIndex = 22;
            // 
            // txtphone
            // 
            this.txtphone.Location = new System.Drawing.Point(313, 52);
            this.txtphone.Name = "txtphone";
            this.txtphone.Size = new System.Drawing.Size(124, 21);
            this.txtphone.TabIndex = 21;
            // 
            // txttel
            // 
            this.txttel.Location = new System.Drawing.Point(314, 24);
            this.txttel.Name = "txttel";
            this.txttel.Size = new System.Drawing.Size(123, 21);
            this.txttel.TabIndex = 20;
            // 
            // txtmaxdate
            // 
            this.txtmaxdate.Location = new System.Drawing.Point(78, 167);
            this.txtmaxdate.Name = "txtmaxdate";
            this.txtmaxdate.Size = new System.Drawing.Size(110, 21);
            this.txtmaxdate.TabIndex = 19;
            // 
            // txtmaxbook
            // 
            this.txtmaxbook.Location = new System.Drawing.Point(78, 142);
            this.txtmaxbook.Name = "txtmaxbook";
            this.txtmaxbook.Size = new System.Drawing.Size(110, 21);
            this.txtmaxbook.TabIndex = 18;
            // 
            // txtpart
            // 
            this.txtpart.Location = new System.Drawing.Point(78, 109);
            this.txtpart.Name = "txtpart";
            this.txtpart.Size = new System.Drawing.Size(133, 21);
            this.txtpart.TabIndex = 17;
            // 
            // txtsex
            // 
            this.txtsex.Location = new System.Drawing.Point(78, 84);
            this.txtsex.Name = "txtsex";
            this.txtsex.Size = new System.Drawing.Size(133, 21);
            this.txtsex.TabIndex = 16;
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(78, 52);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(133, 21);
            this.txtname.TabIndex = 15;
            // 
            // txtuacc
            // 
            this.txtuacc.Location = new System.Drawing.Point(78, 27);
            this.txtuacc.Name = "txtuacc";
            this.txtuacc.Size = new System.Drawing.Size(133, 21);
            this.txtuacc.TabIndex = 14;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label16.Location = new System.Drawing.Point(243, 173);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(65, 12);
            this.label16.TabIndex = 13;
            this.label16.Text = "逾期古籍：";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label15.Location = new System.Drawing.Point(243, 145);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(65, 12);
            this.label15.TabIndex = 12;
            this.label15.Text = "已借古籍：";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label14.Location = new System.Drawing.Point(243, 118);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(71, 12);
            this.label14.TabIndex = 11;
            this.label14.Text = "用户权限： ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label13.Location = new System.Drawing.Point(243, 87);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 12);
            this.label13.TabIndex = 10;
            this.label13.Text = "注册日期：";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label12.Location = new System.Drawing.Point(243, 59);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 12);
            this.label12.TabIndex = 9;
            this.label12.Text = "固定电话：";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label11.Location = new System.Drawing.Point(243, 30);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 12);
            this.label11.TabIndex = 8;
            this.label11.Text = "移动电话：";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(194, 173);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(17, 12);
            this.label10.TabIndex = 7;
            this.label10.Text = "天";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(194, 145);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(17, 12);
            this.label9.TabIndex = 6;
            this.label9.Text = "本";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(18, 173);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 12);
            this.label8.TabIndex = 5;
            this.label8.Text = "借阅时限：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(18, 145);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 4;
            this.label7.Text = "最多可借：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(18, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 3;
            this.label6.Text = "部    门：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(17, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 2;
            this.label5.Text = "性    别：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(18, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "姓    名：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(17, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "账    号：";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridView1);
            this.groupBox4.ForeColor = System.Drawing.Color.Blue;
            this.groupBox4.Location = new System.Drawing.Point(14, 223);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(729, 154);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "用户列表";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 17);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(717, 131);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cell_Click);
            // 
            // UserList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 389);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "UserList";
            this.Text = "用户信息管理";
            this.Load += new System.EventHandler(this.UserList_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button checkbtn;
        private System.Windows.Forms.ComboBox classbox;
        private System.Windows.Forms.ComboBox partbox;
        private System.Windows.Forms.ComboBox checkbox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnquxiao;
        private System.Windows.Forms.Button btnshanchu;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox checktxt;
        private System.Windows.Forms.TextBox txtbookout;
        private System.Windows.Forms.TextBox txtbooknum;
        private System.Windows.Forms.TextBox txtright;
        private System.Windows.Forms.TextBox txtdate;
        private System.Windows.Forms.TextBox txtphone;
        private System.Windows.Forms.TextBox txttel;
        private System.Windows.Forms.TextBox txtmaxdate;
        private System.Windows.Forms.TextBox txtmaxbook;
        private System.Windows.Forms.TextBox txtpart;
        private System.Windows.Forms.TextBox txtsex;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtuacc;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}