namespace 古籍管理系统
{
    partial class LoginForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnDengLu = new System.Windows.Forms.Button();
            this.btnESC = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.useracctxt = new System.Windows.Forms.TextBox();
            this.pswtxt = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDengLu
            // 
            this.btnDengLu.Location = new System.Drawing.Point(59, 171);
            this.btnDengLu.Name = "btnDengLu";
            this.btnDengLu.Size = new System.Drawing.Size(75, 23);
            this.btnDengLu.TabIndex = 5;
            this.btnDengLu.Text = "登陆";
            this.btnDengLu.UseVisualStyleBackColor = true;
            this.btnDengLu.Click += new System.EventHandler(this.btnDengLu_Click);
            // 
            // btnESC
            // 
            this.btnESC.Location = new System.Drawing.Point(191, 172);
            this.btnESC.Name = "btnESC";
            this.btnESC.Size = new System.Drawing.Size(75, 23);
            this.btnESC.TabIndex = 6;
            this.btnESC.Text = "退出";
            this.btnESC.UseVisualStyleBackColor = true;
            this.btnESC.Click += new System.EventHandler(this.btnESC_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(29, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "用户账号：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(29, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "密    码：";
            // 
            // useracctxt
            // 
            this.useracctxt.Location = new System.Drawing.Point(100, 37);
            this.useracctxt.Name = "useracctxt";
            this.useracctxt.Size = new System.Drawing.Size(166, 21);
            this.useracctxt.TabIndex = 2;
            // 
            // pswtxt
            // 
            this.pswtxt.Location = new System.Drawing.Point(100, 83);
            this.pswtxt.Name = "pswtxt";
            this.pswtxt.PasswordChar = '*';
            this.pswtxt.Size = new System.Drawing.Size(166, 21);
            this.pswtxt.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pswtxt);
            this.groupBox1.Controls.Add(this.useracctxt);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.ForeColor = System.Drawing.Color.Blue;
            this.groupBox1.Location = new System.Drawing.Point(12, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(298, 135);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "登陆";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 206);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnESC);
            this.Controls.Add(this.btnDengLu);
            this.Name = "LoginForm";
            this.Text = "登陆界面";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LoginForm_Closing);
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDengLu;
        private System.Windows.Forms.Button btnESC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox useracctxt;
        private System.Windows.Forms.TextBox pswtxt;
        private System.Windows.Forms.GroupBox groupBox1;

    }
}

