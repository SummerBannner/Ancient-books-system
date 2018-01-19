namespace 古籍管理系统
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.古籍管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.古籍添加ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.古籍信息管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.古籍借还ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.借书ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.还书ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.用户管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.用户信息添加ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.用户信息管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.信息查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.借阅历史查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.借阅信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.修改密码ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.系统ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.注销ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.古籍管理ToolStripMenuItem,
            this.古籍借还ToolStripMenuItem,
            this.用户管理ToolStripMenuItem,
            this.信息查询ToolStripMenuItem,
            this.修改密码ToolStripMenuItem,
            this.系统ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1071, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 古籍管理ToolStripMenuItem
            // 
            this.古籍管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.古籍添加ToolStripMenuItem,
            this.古籍信息管理ToolStripMenuItem});
            this.古籍管理ToolStripMenuItem.Name = "古籍管理ToolStripMenuItem";
            this.古籍管理ToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.古籍管理ToolStripMenuItem.Text = "古籍管理";
            // 
            // 古籍添加ToolStripMenuItem
            // 
            this.古籍添加ToolStripMenuItem.Name = "古籍添加ToolStripMenuItem";
            this.古籍添加ToolStripMenuItem.Size = new System.Drawing.Size(174, 26);
            this.古籍添加ToolStripMenuItem.Text = "古籍添加";
            this.古籍添加ToolStripMenuItem.Click += new System.EventHandler(this.古籍添加ToolStripMenuItem_Click);
            // 
            // 古籍信息管理ToolStripMenuItem
            // 
            this.古籍信息管理ToolStripMenuItem.Name = "古籍信息管理ToolStripMenuItem";
            this.古籍信息管理ToolStripMenuItem.Size = new System.Drawing.Size(174, 26);
            this.古籍信息管理ToolStripMenuItem.Text = "古籍信息管理";
            this.古籍信息管理ToolStripMenuItem.Click += new System.EventHandler(this.古籍信息管理ToolStripMenuItem_Click);
            // 
            // 古籍借还ToolStripMenuItem
            // 
            this.古籍借还ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.借书ToolStripMenuItem,
            this.还书ToolStripMenuItem});
            this.古籍借还ToolStripMenuItem.Name = "古籍借还ToolStripMenuItem";
            this.古籍借还ToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.古籍借还ToolStripMenuItem.Text = "古籍借还";
            // 
            // 借书ToolStripMenuItem
            // 
            this.借书ToolStripMenuItem.Name = "借书ToolStripMenuItem";
            this.借书ToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.借书ToolStripMenuItem.Text = "借书";
            this.借书ToolStripMenuItem.Click += new System.EventHandler(this.借书ToolStripMenuItem_Click);
            // 
            // 还书ToolStripMenuItem
            // 
            this.还书ToolStripMenuItem.Name = "还书ToolStripMenuItem";
            this.还书ToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.还书ToolStripMenuItem.Text = "还书";
            this.还书ToolStripMenuItem.Click += new System.EventHandler(this.还书ToolStripMenuItem_Click_1);
            // 
            // 用户管理ToolStripMenuItem
            // 
            this.用户管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.用户信息添加ToolStripMenuItem,
            this.用户信息管理ToolStripMenuItem});
            this.用户管理ToolStripMenuItem.Name = "用户管理ToolStripMenuItem";
            this.用户管理ToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.用户管理ToolStripMenuItem.Text = "读者管理";
            // 
            // 用户信息添加ToolStripMenuItem
            // 
            this.用户信息添加ToolStripMenuItem.Name = "用户信息添加ToolStripMenuItem";
            this.用户信息添加ToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.用户信息添加ToolStripMenuItem.Text = "添加读者";
            this.用户信息添加ToolStripMenuItem.Click += new System.EventHandler(this.用户信息添加ToolStripMenuItem_Click);
            // 
            // 用户信息管理ToolStripMenuItem
            // 
            this.用户信息管理ToolStripMenuItem.Name = "用户信息管理ToolStripMenuItem";
            this.用户信息管理ToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.用户信息管理ToolStripMenuItem.Text = "信息编辑";
            this.用户信息管理ToolStripMenuItem.Click += new System.EventHandler(this.用户信息管理ToolStripMenuItem_Click);
            // 
            // 信息查询ToolStripMenuItem
            // 
            this.信息查询ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.借阅历史查询ToolStripMenuItem,
            this.借阅信息ToolStripMenuItem});
            this.信息查询ToolStripMenuItem.Name = "信息查询ToolStripMenuItem";
            this.信息查询ToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.信息查询ToolStripMenuItem.Text = "信息查询";
            // 
            // 借阅历史查询ToolStripMenuItem
            // 
            this.借阅历史查询ToolStripMenuItem.Name = "借阅历史查询ToolStripMenuItem";
            this.借阅历史查询ToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.借阅历史查询ToolStripMenuItem.Text = "古籍查询";
            this.借阅历史查询ToolStripMenuItem.Click += new System.EventHandler(this.借阅历史查询ToolStripMenuItem_Click);
            // 
            // 借阅信息ToolStripMenuItem
            // 
            this.借阅信息ToolStripMenuItem.Name = "借阅信息ToolStripMenuItem";
            this.借阅信息ToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.借阅信息ToolStripMenuItem.Text = "借阅信息";
            this.借阅信息ToolStripMenuItem.Click += new System.EventHandler(this.借阅信息ToolStripMenuItem_Click_1);
            // 
            // 修改密码ToolStripMenuItem
            // 
            this.修改密码ToolStripMenuItem.Name = "修改密码ToolStripMenuItem";
            this.修改密码ToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.修改密码ToolStripMenuItem.Text = "修改密码";
            this.修改密码ToolStripMenuItem.Click += new System.EventHandler(this.修改密码ToolStripMenuItem_Click);
            // 
            // 系统ToolStripMenuItem
            // 
            this.系统ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.注销ToolStripMenuItem,
            this.退出ToolStripMenuItem});
            this.系统ToolStripMenuItem.Name = "系统ToolStripMenuItem";
            this.系统ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.系统ToolStripMenuItem.Text = "系统";
            this.系统ToolStripMenuItem.Click += new System.EventHandler(this.系统ToolStripMenuItem_Click_1);
            // 
            // 注销ToolStripMenuItem
            // 
            this.注销ToolStripMenuItem.Name = "注销ToolStripMenuItem";
            this.注销ToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.注销ToolStripMenuItem.Text = "注销";
            this.注销ToolStripMenuItem.Click += new System.EventHandler(this.注销ToolStripMenuItem_Click);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1071, 535);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "古籍管理系统";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 系统ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 古籍管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 用户管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 信息查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 古籍添加ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 古籍信息管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 用户信息添加ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 用户信息管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 借阅历史查询ToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem 注销ToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 古籍借还ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 借书ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 还书ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 修改密码ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 借阅信息ToolStripMenuItem;
    }
}