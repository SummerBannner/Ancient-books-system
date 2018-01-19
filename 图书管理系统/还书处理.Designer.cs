namespace 古籍管理系统
{
    partial class BookReturn
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
            this.txtcheck = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.boxstate = new System.Windows.Forms.ComboBox();
            this.boxcheck = new System.Windows.Forms.ComboBox();
            this.btncheck = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnquxiao = new System.Windows.Forms.Button();
            this.btnhuanshu = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtlost = new System.Windows.Forms.TextBox();
            this.txtouttime = new System.Windows.Forms.TextBox();
            this.txtnoret = new System.Windows.Forms.TextBox();
            this.txturight = new System.Windows.Forms.TextBox();
            this.txtupart = new System.Windows.Forms.TextBox();
            this.txtusex = new System.Windows.Forms.TextBox();
            this.txtuname = new System.Windows.Forms.TextBox();
            this.txtuacc = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtbstate = new System.Windows.Forms.TextBox();
            this.txtbpub = new System.Windows.Forms.TextBox();
            this.txtbauthor = new System.Windows.Forms.TextBox();
            this.txtbcost = new System.Windows.Forms.TextBox();
            this.txtbisbn = new System.Windows.Forms.TextBox();
            this.txtbclass = new System.Windows.Forms.TextBox();
            this.txtbname = new System.Windows.Forms.TextBox();
            this.txtbno = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtpcost = new System.Windows.Forms.TextBox();
            this.txtoutcost = new System.Windows.Forms.TextBox();
            this.txtoutday = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtcheck);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.boxstate);
            this.groupBox1.Controls.Add(this.boxcheck);
            this.groupBox1.Controls.Add(this.btncheck);
            this.groupBox1.ForeColor = System.Drawing.Color.Blue;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(294, 91);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "查询";
            // 
            // txtcheck
            // 
            this.txtcheck.Location = new System.Drawing.Point(101, 20);
            this.txtcheck.Name = "txtcheck";
            this.txtcheck.Size = new System.Drawing.Size(129, 21);
            this.txtcheck.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(21, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "古籍状态：";
            // 
            // boxstate
            // 
            this.boxstate.FormattingEnabled = true;
            this.boxstate.Items.AddRange(new object[] {
            "未还古籍信息",
            "已还古籍信息",
            "挂失古籍信息",
            "丢失古籍信息"});
            this.boxstate.Location = new System.Drawing.Point(101, 56);
            this.boxstate.Name = "boxstate";
            this.boxstate.Size = new System.Drawing.Size(187, 20);
            this.boxstate.TabIndex = 2;
            // 
            // boxcheck
            // 
            this.boxcheck.FormattingEnabled = true;
            this.boxcheck.Items.AddRange(new object[] {
            "用户账号",
            "用户姓名",
            "古籍编号",
            "古籍名称"});
            this.boxcheck.Location = new System.Drawing.Point(6, 20);
            this.boxcheck.Name = "boxcheck";
            this.boxcheck.Size = new System.Drawing.Size(76, 20);
            this.boxcheck.TabIndex = 1;
            // 
            // btncheck
            // 
            this.btncheck.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btncheck.Location = new System.Drawing.Point(236, 18);
            this.btncheck.Name = "btncheck";
            this.btncheck.Size = new System.Drawing.Size(52, 23);
            this.btncheck.TabIndex = 0;
            this.btncheck.Text = "查询";
            this.btncheck.UseVisualStyleBackColor = true;
            this.btncheck.Click += new System.EventHandler(this.btncheck_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnquxiao);
            this.groupBox2.Controls.Add(this.btnhuanshu);
            this.groupBox2.ForeColor = System.Drawing.Color.Blue;
            this.groupBox2.Location = new System.Drawing.Point(12, 109);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(294, 61);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "操作";
            // 
            // btnquxiao
            // 
            this.btnquxiao.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnquxiao.Location = new System.Drawing.Point(185, 28);
            this.btnquxiao.Name = "btnquxiao";
            this.btnquxiao.Size = new System.Drawing.Size(75, 23);
            this.btnquxiao.TabIndex = 1;
            this.btnquxiao.Text = "取消";
            this.btnquxiao.UseVisualStyleBackColor = true;
            this.btnquxiao.Click += new System.EventHandler(this.btnquxiao_Click);
            // 
            // btnhuanshu
            // 
            this.btnhuanshu.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnhuanshu.Location = new System.Drawing.Point(79, 28);
            this.btnhuanshu.Name = "btnhuanshu";
            this.btnhuanshu.Size = new System.Drawing.Size(75, 23);
            this.btnhuanshu.TabIndex = 0;
            this.btnhuanshu.Text = "还书";
            this.btnhuanshu.UseVisualStyleBackColor = true;
            this.btnhuanshu.Click += new System.EventHandler(this.btnhuanshu_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtlost);
            this.groupBox3.Controls.Add(this.txtouttime);
            this.groupBox3.Controls.Add(this.txtnoret);
            this.groupBox3.Controls.Add(this.txturight);
            this.groupBox3.Controls.Add(this.txtupart);
            this.groupBox3.Controls.Add(this.txtusex);
            this.groupBox3.Controls.Add(this.txtuname);
            this.groupBox3.Controls.Add(this.txtuacc);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.ForeColor = System.Drawing.Color.Blue;
            this.groupBox3.Location = new System.Drawing.Point(312, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(456, 157);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "用户信息";
            // 
            // txtlost
            // 
            this.txtlost.Location = new System.Drawing.Point(295, 126);
            this.txtlost.Name = "txtlost";
            this.txtlost.Size = new System.Drawing.Size(145, 21);
            this.txtlost.TabIndex = 15;
            // 
            // txtouttime
            // 
            this.txtouttime.Location = new System.Drawing.Point(295, 93);
            this.txtouttime.Name = "txtouttime";
            this.txtouttime.Size = new System.Drawing.Size(145, 21);
            this.txtouttime.TabIndex = 14;
            // 
            // txtnoret
            // 
            this.txtnoret.Location = new System.Drawing.Point(295, 60);
            this.txtnoret.Name = "txtnoret";
            this.txtnoret.Size = new System.Drawing.Size(145, 21);
            this.txtnoret.TabIndex = 13;
            // 
            // txturight
            // 
            this.txturight.Location = new System.Drawing.Point(295, 24);
            this.txturight.Name = "txturight";
            this.txturight.Size = new System.Drawing.Size(145, 21);
            this.txturight.TabIndex = 12;
            // 
            // txtupart
            // 
            this.txtupart.Location = new System.Drawing.Point(85, 126);
            this.txtupart.Name = "txtupart";
            this.txtupart.Size = new System.Drawing.Size(141, 21);
            this.txtupart.TabIndex = 11;
            // 
            // txtusex
            // 
            this.txtusex.Location = new System.Drawing.Point(85, 93);
            this.txtusex.Name = "txtusex";
            this.txtusex.Size = new System.Drawing.Size(142, 21);
            this.txtusex.TabIndex = 10;
            // 
            // txtuname
            // 
            this.txtuname.Location = new System.Drawing.Point(85, 55);
            this.txtuname.Name = "txtuname";
            this.txtuname.Size = new System.Drawing.Size(141, 21);
            this.txtuname.TabIndex = 9;
            // 
            // txtuacc
            // 
            this.txtuacc.Location = new System.Drawing.Point(84, 24);
            this.txtuacc.Name = "txtuacc";
            this.txtuacc.Size = new System.Drawing.Size(142, 21);
            this.txtuacc.TabIndex = 8;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label12.Location = new System.Drawing.Point(233, 129);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 12);
            this.label12.TabIndex = 7;
            this.label12.Text = "遗失古籍：";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label11.Location = new System.Drawing.Point(233, 96);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 12);
            this.label11.TabIndex = 6;
            this.label11.Text = "到期古籍：";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(232, 63);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 12);
            this.label10.TabIndex = 5;
            this.label10.Text = "未还古籍：";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(232, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 12);
            this.label9.TabIndex = 4;
            this.label9.Text = "借阅权限：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(18, 129);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 12);
            this.label8.TabIndex = 3;
            this.label8.Text = "部    门：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(18, 96);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 2;
            this.label7.Text = "性    别：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(18, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 1;
            this.label6.Text = "姓    名：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(18, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "账    号：";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtbstate);
            this.groupBox4.Controls.Add(this.txtbpub);
            this.groupBox4.Controls.Add(this.txtbauthor);
            this.groupBox4.Controls.Add(this.txtbcost);
            this.groupBox4.Controls.Add(this.txtbisbn);
            this.groupBox4.Controls.Add(this.txtbclass);
            this.groupBox4.Controls.Add(this.txtbname);
            this.groupBox4.Controls.Add(this.txtbno);
            this.groupBox4.Controls.Add(this.label20);
            this.groupBox4.Controls.Add(this.label19);
            this.groupBox4.Controls.Add(this.label18);
            this.groupBox4.Controls.Add(this.label17);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.ForeColor = System.Drawing.Color.Blue;
            this.groupBox4.Location = new System.Drawing.Point(312, 176);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(455, 163);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "古籍信息";
            // 
            // txtbstate
            // 
            this.txtbstate.Location = new System.Drawing.Point(295, 129);
            this.txtbstate.Name = "txtbstate";
            this.txtbstate.Size = new System.Drawing.Size(145, 21);
            this.txtbstate.TabIndex = 15;
            // 
            // txtbpub
            // 
            this.txtbpub.Location = new System.Drawing.Point(295, 92);
            this.txtbpub.Name = "txtbpub";
            this.txtbpub.Size = new System.Drawing.Size(145, 21);
            this.txtbpub.TabIndex = 14;
            // 
            // txtbauthor
            // 
            this.txtbauthor.Location = new System.Drawing.Point(295, 58);
            this.txtbauthor.Name = "txtbauthor";
            this.txtbauthor.Size = new System.Drawing.Size(145, 21);
            this.txtbauthor.TabIndex = 13;
            // 
            // txtbcost
            // 
            this.txtbcost.Location = new System.Drawing.Point(295, 29);
            this.txtbcost.Name = "txtbcost";
            this.txtbcost.Size = new System.Drawing.Size(145, 21);
            this.txtbcost.TabIndex = 12;
            // 
            // txtbisbn
            // 
            this.txtbisbn.Location = new System.Drawing.Point(85, 129);
            this.txtbisbn.Name = "txtbisbn";
            this.txtbisbn.Size = new System.Drawing.Size(140, 21);
            this.txtbisbn.TabIndex = 11;
            // 
            // txtbclass
            // 
            this.txtbclass.Location = new System.Drawing.Point(85, 92);
            this.txtbclass.Name = "txtbclass";
            this.txtbclass.Size = new System.Drawing.Size(141, 21);
            this.txtbclass.TabIndex = 10;
            // 
            // txtbname
            // 
            this.txtbname.Location = new System.Drawing.Point(84, 58);
            this.txtbname.Name = "txtbname";
            this.txtbname.Size = new System.Drawing.Size(142, 21);
            this.txtbname.TabIndex = 9;
            // 
            // txtbno
            // 
            this.txtbno.Location = new System.Drawing.Point(84, 29);
            this.txtbno.Name = "txtbno";
            this.txtbno.Size = new System.Drawing.Size(141, 21);
            this.txtbno.TabIndex = 8;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label20.Location = new System.Drawing.Point(232, 132);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(65, 12);
            this.label20.TabIndex = 7;
            this.label20.Text = "状    态：";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label19.Location = new System.Drawing.Point(232, 95);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(65, 12);
            this.label19.TabIndex = 6;
            this.label19.Text = "出 版 社：";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label18.Location = new System.Drawing.Point(232, 61);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(65, 12);
            this.label18.TabIndex = 5;
            this.label18.Text = "作    者：";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label17.Location = new System.Drawing.Point(233, 32);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(65, 12);
            this.label17.TabIndex = 4;
            this.label17.Text = "价    格：";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label16.Location = new System.Drawing.Point(18, 132);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(65, 12);
            this.label16.TabIndex = 3;
            this.label16.Text = "I S B N ：";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label15.Location = new System.Drawing.Point(18, 95);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(65, 12);
            this.label15.TabIndex = 2;
            this.label15.Text = "类    别：";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label14.Location = new System.Drawing.Point(18, 61);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(65, 12);
            this.label14.TabIndex = 1;
            this.label14.Text = "名    称：";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label13.Location = new System.Drawing.Point(18, 32);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 12);
            this.label13.TabIndex = 0;
            this.label13.Text = "编    号：";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtpcost);
            this.groupBox5.Controls.Add(this.txtoutcost);
            this.groupBox5.Controls.Add(this.txtoutday);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.ForeColor = System.Drawing.Color.Blue;
            this.groupBox5.Location = new System.Drawing.Point(12, 176);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(294, 163);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "超期信息";
            // 
            // txtpcost
            // 
            this.txtpcost.Location = new System.Drawing.Point(88, 123);
            this.txtpcost.Name = "txtpcost";
            this.txtpcost.Size = new System.Drawing.Size(172, 21);
            this.txtpcost.TabIndex = 5;
            // 
            // txtoutcost
            // 
            this.txtoutcost.Location = new System.Drawing.Point(88, 77);
            this.txtoutcost.Name = "txtoutcost";
            this.txtoutcost.Size = new System.Drawing.Size(172, 21);
            this.txtoutcost.TabIndex = 4;
            // 
            // txtoutday
            // 
            this.txtoutday.Location = new System.Drawing.Point(88, 32);
            this.txtoutday.Name = "txtoutday";
            this.txtoutday.Size = new System.Drawing.Size(172, 21);
            this.txtoutday.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(21, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 2;
            this.label4.Text = "应缴费用：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(21, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "超期罚款：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(21, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "超期天数：";
            // 
            // groupBox6
            // 
            this.groupBox6.Location = new System.Drawing.Point(123, 407);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(8, 8);
            this.groupBox6.TabIndex = 5;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "groupBox6";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.dataGridView1);
            this.groupBox7.ForeColor = System.Drawing.Color.Blue;
            this.groupBox7.Location = new System.Drawing.Point(12, 345);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(756, 160);
            this.groupBox7.TabIndex = 6;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "借阅信息表";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 20);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(744, 134);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cell_click);
            // 
            // BookReturn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 508);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "BookReturn";
            this.Text = "还书处理";
            this.Load += new System.EventHandler(this.BookReturn_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtcheck;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox boxstate;
        private System.Windows.Forms.ComboBox boxcheck;
        private System.Windows.Forms.Button btncheck;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnquxiao;
        private System.Windows.Forms.Button btnhuanshu;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txtpcost;
        private System.Windows.Forms.TextBox txtoutcost;
        private System.Windows.Forms.TextBox txtoutday;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.TextBox txtlost;
        private System.Windows.Forms.TextBox txtouttime;
        private System.Windows.Forms.TextBox txtnoret;
        private System.Windows.Forms.TextBox txturight;
        private System.Windows.Forms.TextBox txtupart;
        private System.Windows.Forms.TextBox txtusex;
        private System.Windows.Forms.TextBox txtuname;
        private System.Windows.Forms.TextBox txtuacc;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtbstate;
        private System.Windows.Forms.TextBox txtbpub;
        private System.Windows.Forms.TextBox txtbauthor;
        private System.Windows.Forms.TextBox txtbcost;
        private System.Windows.Forms.TextBox txtbisbn;
        private System.Windows.Forms.TextBox txtbclass;
        private System.Windows.Forms.TextBox txtbname;
        private System.Windows.Forms.TextBox txtbno;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}