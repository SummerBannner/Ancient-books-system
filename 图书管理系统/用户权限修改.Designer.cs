namespace 古籍管理系统
{
    partial class UserRight
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
            this.partbox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checktxt = new System.Windows.Forms.TextBox();
            this.btnCheck = new System.Windows.Forms.Button();
            this.checkbox = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnquxiao = new System.Windows.Forms.Button();
            this.btnCorrect = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtright = new System.Windows.Forms.ComboBox();
            this.txtdate = new System.Windows.Forms.TextBox();
            this.txtphone = new System.Windows.Forms.TextBox();
            this.txttel = new System.Windows.Forms.TextBox();
            this.txtpart = new System.Windows.Forms.TextBox();
            this.txtsex = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtuacc = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
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
            this.groupBox1.Controls.Add(this.partbox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.checktxt);
            this.groupBox1.Controls.Add(this.btnCheck);
            this.groupBox1.Controls.Add(this.checkbox);
            this.groupBox1.ForeColor = System.Drawing.Color.Blue;
            this.groupBox1.Location = new System.Drawing.Point(8, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(278, 87);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "简单查询";
            // 
            // partbox
            // 
            this.partbox.FormattingEnabled = true;
            this.partbox.Items.AddRange(new object[] {
            "茗园",
            "蕙园"});
            this.partbox.Location = new System.Drawing.Point(97, 53);
            this.partbox.Name = "partbox";
            this.partbox.Size = new System.Drawing.Size(175, 20);
            this.partbox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(14, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "用户部门：";
            // 
            // checktxt
            // 
            this.checktxt.Location = new System.Drawing.Point(97, 21);
            this.checktxt.Name = "checktxt";
            this.checktxt.Size = new System.Drawing.Size(115, 21);
            this.checktxt.TabIndex = 2;
            // 
            // btnCheck
            // 
            this.btnCheck.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCheck.Location = new System.Drawing.Point(222, 21);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(50, 23);
            this.btnCheck.TabIndex = 1;
            this.btnCheck.Text = "查询";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // checkbox
            // 
            this.checkbox.FormattingEnabled = true;
            this.checkbox.Items.AddRange(new object[] {
            "用户账号",
            "用户姓名"});
            this.checkbox.Location = new System.Drawing.Point(6, 23);
            this.checkbox.Name = "checkbox";
            this.checkbox.Size = new System.Drawing.Size(73, 20);
            this.checkbox.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnquxiao);
            this.groupBox2.Controls.Add(this.btnCorrect);
            this.groupBox2.ForeColor = System.Drawing.Color.Blue;
            this.groupBox2.Location = new System.Drawing.Point(8, 101);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(278, 74);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "操作";
            // 
            // btnquxiao
            // 
            this.btnquxiao.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnquxiao.Location = new System.Drawing.Point(194, 32);
            this.btnquxiao.Name = "btnquxiao";
            this.btnquxiao.Size = new System.Drawing.Size(75, 23);
            this.btnquxiao.TabIndex = 1;
            this.btnquxiao.Text = "取消";
            this.btnquxiao.UseVisualStyleBackColor = true;
            this.btnquxiao.Click += new System.EventHandler(this.btnquxiao_Click);
            // 
            // btnCorrect
            // 
            this.btnCorrect.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCorrect.Location = new System.Drawing.Point(94, 32);
            this.btnCorrect.Name = "btnCorrect";
            this.btnCorrect.Size = new System.Drawing.Size(75, 23);
            this.btnCorrect.TabIndex = 0;
            this.btnCorrect.Text = "修改";
            this.btnCorrect.UseVisualStyleBackColor = true;
            this.btnCorrect.Click += new System.EventHandler(this.btnCorrect_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtright);
            this.groupBox3.Controls.Add(this.txtdate);
            this.groupBox3.Controls.Add(this.txtphone);
            this.groupBox3.Controls.Add(this.txttel);
            this.groupBox3.Controls.Add(this.txtpart);
            this.groupBox3.Controls.Add(this.txtsex);
            this.groupBox3.Controls.Add(this.txtname);
            this.groupBox3.Controls.Add(this.txtuacc);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.ForeColor = System.Drawing.Color.Blue;
            this.groupBox3.Location = new System.Drawing.Point(292, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(397, 163);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "用户信息";
            // 
            // txtright
            // 
            this.txtright.FormattingEnabled = true;
            this.txtright.Items.AddRange(new object[] {
            "超级管理员",
            "管理员",
            "用户"});
            this.txtright.Location = new System.Drawing.Point(268, 129);
            this.txtright.Name = "txtright";
            this.txtright.Size = new System.Drawing.Size(100, 20);
            this.txtright.TabIndex = 15;
            // 
            // txtdate
            // 
            this.txtdate.Location = new System.Drawing.Point(268, 92);
            this.txtdate.Name = "txtdate";
            this.txtdate.Size = new System.Drawing.Size(100, 21);
            this.txtdate.TabIndex = 14;
            // 
            // txtphone
            // 
            this.txtphone.Location = new System.Drawing.Point(268, 54);
            this.txtphone.Name = "txtphone";
            this.txtphone.Size = new System.Drawing.Size(100, 21);
            this.txtphone.TabIndex = 13;
            // 
            // txttel
            // 
            this.txttel.Location = new System.Drawing.Point(268, 23);
            this.txttel.Name = "txttel";
            this.txttel.Size = new System.Drawing.Size(100, 21);
            this.txttel.TabIndex = 12;
            // 
            // txtpart
            // 
            this.txtpart.Location = new System.Drawing.Point(64, 129);
            this.txtpart.Name = "txtpart";
            this.txtpart.Size = new System.Drawing.Size(100, 21);
            this.txtpart.TabIndex = 11;
            // 
            // txtsex
            // 
            this.txtsex.Location = new System.Drawing.Point(64, 92);
            this.txtsex.Name = "txtsex";
            this.txtsex.Size = new System.Drawing.Size(100, 21);
            this.txtsex.TabIndex = 10;
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(64, 54);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(100, 21);
            this.txtname.TabIndex = 9;
            // 
            // txtuacc
            // 
            this.txtuacc.Location = new System.Drawing.Point(64, 23);
            this.txtuacc.Name = "txtuacc";
            this.txtuacc.Size = new System.Drawing.Size(100, 21);
            this.txtuacc.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(197, 132);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 12);
            this.label9.TabIndex = 7;
            this.label9.Text = "用户权限：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(197, 95);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 12);
            this.label8.TabIndex = 6;
            this.label8.Text = "注册日期：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(197, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 5;
            this.label7.Text = "固定电话：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(197, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 4;
            this.label6.Text = "移动电话：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(17, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 3;
            this.label5.Text = "部门：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(15, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 2;
            this.label4.Text = "性别：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(17, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "姓名：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(15, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "账号：";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridView1);
            this.groupBox4.ForeColor = System.Drawing.Color.Blue;
            this.groupBox4.Location = new System.Drawing.Point(8, 181);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(681, 190);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "用户列表";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 20);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(669, 164);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cell_click);
            // 
            // UserRight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 383);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "UserRight";
            this.Text = "用户权限修改";
            this.Load += new System.EventHandler(this.UserRight_Load);
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
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox partbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox checktxt;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.ComboBox checkbox;
        private System.Windows.Forms.Button btnquxiao;
        private System.Windows.Forms.Button btnCorrect;
        private System.Windows.Forms.ComboBox txtright;
        private System.Windows.Forms.TextBox txtdate;
        private System.Windows.Forms.TextBox txtphone;
        private System.Windows.Forms.TextBox txttel;
        private System.Windows.Forms.TextBox txtpart;
        private System.Windows.Forms.TextBox txtsex;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtuacc;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}