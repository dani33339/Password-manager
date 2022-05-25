namespace passwordmamanger
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.MyPassBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.EditPassBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.label2 = new System.Windows.Forms.Label();
            this.EditAccount = new Bunifu.Framework.UI.BunifuThinButton2();
            this.SerchPassBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.NewPassword_btn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panel2 = new System.Windows.Forms.Panel();
            this.exitBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listView = new System.Windows.Forms.ListView();
            this.Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Email = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.UserName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Password = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.GhostWhite;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.MyPassBtn);
            this.panel1.Controls.Add(this.EditPassBtn);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.EditAccount);
            this.panel1.Controls.Add(this.SerchPassBtn);
            this.panel1.Controls.Add(this.NewPassword_btn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(180, 503);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // MyPassBtn
            // 
            this.MyPassBtn.ActiveBorderThickness = 1;
            this.MyPassBtn.ActiveCornerRadius = 20;
            this.MyPassBtn.ActiveFillColor = System.Drawing.Color.SlateGray;
            this.MyPassBtn.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(65)))), ((int)(((byte)(118)))));
            this.MyPassBtn.ActiveLineColor = System.Drawing.Color.DarkSlateGray;
            this.MyPassBtn.BackColor = System.Drawing.Color.GhostWhite;
            this.MyPassBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MyPassBtn.BackgroundImage")));
            this.MyPassBtn.ButtonText = "My Passwords";
            this.MyPassBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MyPassBtn.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MyPassBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.MyPassBtn.IdleBorderThickness = 1;
            this.MyPassBtn.IdleCornerRadius = 20;
            this.MyPassBtn.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(65)))), ((int)(((byte)(118)))));
            this.MyPassBtn.IdleForecolor = System.Drawing.Color.WhiteSmoke;
            this.MyPassBtn.IdleLineColor = System.Drawing.Color.LightSlateGray;
            this.MyPassBtn.Location = new System.Drawing.Point(7, 72);
            this.MyPassBtn.Margin = new System.Windows.Forms.Padding(6);
            this.MyPassBtn.Name = "MyPassBtn";
            this.MyPassBtn.Size = new System.Drawing.Size(166, 50);
            this.MyPassBtn.TabIndex = 49;
            this.MyPassBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EditPassBtn
            // 
            this.EditPassBtn.ActiveBorderThickness = 1;
            this.EditPassBtn.ActiveCornerRadius = 20;
            this.EditPassBtn.ActiveFillColor = System.Drawing.Color.SlateGray;
            this.EditPassBtn.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(65)))), ((int)(((byte)(118)))));
            this.EditPassBtn.ActiveLineColor = System.Drawing.Color.DarkSlateGray;
            this.EditPassBtn.BackColor = System.Drawing.Color.GhostWhite;
            this.EditPassBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("EditPassBtn.BackgroundImage")));
            this.EditPassBtn.ButtonText = "Edit Passwords";
            this.EditPassBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EditPassBtn.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditPassBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.EditPassBtn.IdleBorderThickness = 1;
            this.EditPassBtn.IdleCornerRadius = 20;
            this.EditPassBtn.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(65)))), ((int)(((byte)(118)))));
            this.EditPassBtn.IdleForecolor = System.Drawing.Color.WhiteSmoke;
            this.EditPassBtn.IdleLineColor = System.Drawing.Color.LightSlateGray;
            this.EditPassBtn.Location = new System.Drawing.Point(6, 306);
            this.EditPassBtn.Margin = new System.Windows.Forms.Padding(6);
            this.EditPassBtn.Name = "EditPassBtn";
            this.EditPassBtn.Size = new System.Drawing.Size(166, 50);
            this.EditPassBtn.TabIndex = 48;
            this.EditPassBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(37, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 36);
            this.label2.TabIndex = 48;
            this.label2.Text = "Menu";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // EditAccount
            // 
            this.EditAccount.ActiveBorderThickness = 1;
            this.EditAccount.ActiveCornerRadius = 20;
            this.EditAccount.ActiveFillColor = System.Drawing.Color.SlateGray;
            this.EditAccount.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(65)))), ((int)(((byte)(118)))));
            this.EditAccount.ActiveLineColor = System.Drawing.Color.DarkSlateGray;
            this.EditAccount.BackColor = System.Drawing.Color.GhostWhite;
            this.EditAccount.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("EditAccount.BackgroundImage")));
            this.EditAccount.ButtonText = "Edit Account";
            this.EditAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EditAccount.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditAccount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.EditAccount.IdleBorderThickness = 1;
            this.EditAccount.IdleCornerRadius = 20;
            this.EditAccount.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(65)))), ((int)(((byte)(118)))));
            this.EditAccount.IdleForecolor = System.Drawing.Color.Transparent;
            this.EditAccount.IdleLineColor = System.Drawing.Color.LightSlateGray;
            this.EditAccount.Location = new System.Drawing.Point(6, 246);
            this.EditAccount.Margin = new System.Windows.Forms.Padding(6);
            this.EditAccount.Name = "EditAccount";
            this.EditAccount.Size = new System.Drawing.Size(167, 50);
            this.EditAccount.TabIndex = 33;
            this.EditAccount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.EditAccount.Click += new System.EventHandler(this.EditAccount_Click);
            // 
            // SerchPassBtn
            // 
            this.SerchPassBtn.ActiveBorderThickness = 1;
            this.SerchPassBtn.ActiveCornerRadius = 20;
            this.SerchPassBtn.ActiveFillColor = System.Drawing.Color.SlateGray;
            this.SerchPassBtn.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(65)))), ((int)(((byte)(118)))));
            this.SerchPassBtn.ActiveLineColor = System.Drawing.Color.DarkSlateGray;
            this.SerchPassBtn.BackColor = System.Drawing.Color.GhostWhite;
            this.SerchPassBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SerchPassBtn.BackgroundImage")));
            this.SerchPassBtn.ButtonText = "Serch Password";
            this.SerchPassBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SerchPassBtn.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SerchPassBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.SerchPassBtn.IdleBorderThickness = 1;
            this.SerchPassBtn.IdleCornerRadius = 20;
            this.SerchPassBtn.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(65)))), ((int)(((byte)(118)))));
            this.SerchPassBtn.IdleForecolor = System.Drawing.Color.Transparent;
            this.SerchPassBtn.IdleLineColor = System.Drawing.Color.LightSlateGray;
            this.SerchPassBtn.Location = new System.Drawing.Point(6, 187);
            this.SerchPassBtn.Margin = new System.Windows.Forms.Padding(6);
            this.SerchPassBtn.Name = "SerchPassBtn";
            this.SerchPassBtn.Size = new System.Drawing.Size(167, 50);
            this.SerchPassBtn.TabIndex = 32;
            this.SerchPassBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NewPassword_btn
            // 
            this.NewPassword_btn.ActiveBorderThickness = 1;
            this.NewPassword_btn.ActiveCornerRadius = 20;
            this.NewPassword_btn.ActiveFillColor = System.Drawing.Color.SlateGray;
            this.NewPassword_btn.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(65)))), ((int)(((byte)(118)))));
            this.NewPassword_btn.ActiveLineColor = System.Drawing.Color.DarkSlateGray;
            this.NewPassword_btn.BackColor = System.Drawing.Color.GhostWhite;
            this.NewPassword_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("NewPassword_btn.BackgroundImage")));
            this.NewPassword_btn.ButtonText = "New Password";
            this.NewPassword_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NewPassword_btn.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewPassword_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.NewPassword_btn.IdleBorderThickness = 1;
            this.NewPassword_btn.IdleCornerRadius = 20;
            this.NewPassword_btn.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(65)))), ((int)(((byte)(118)))));
            this.NewPassword_btn.IdleForecolor = System.Drawing.Color.Transparent;
            this.NewPassword_btn.IdleLineColor = System.Drawing.Color.LightSlateGray;
            this.NewPassword_btn.Location = new System.Drawing.Point(5, 129);
            this.NewPassword_btn.Margin = new System.Windows.Forms.Padding(6);
            this.NewPassword_btn.Name = "NewPassword_btn";
            this.NewPassword_btn.Size = new System.Drawing.Size(167, 50);
            this.NewPassword_btn.TabIndex = 31;
            this.NewPassword_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.NewPassword_btn.Click += new System.EventHandler(this.NewPassword_btn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.GhostWhite;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.exitBtn);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(180, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(750, 48);
            this.panel2.TabIndex = 1;
            // 
            // exitBtn
            // 
            this.exitBtn.AllowDrop = true;
            this.exitBtn.AutoEllipsis = true;
            this.exitBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.exitBtn.BackColor = System.Drawing.Color.GhostWhite;
            this.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitBtn.ForeColor = System.Drawing.Color.GhostWhite;
            this.exitBtn.Image = ((System.Drawing.Image)(resources.GetObject("exitBtn.Image")));
            this.exitBtn.Location = new System.Drawing.Point(702, 2);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(43, 41);
            this.exitBtn.TabIndex = 31;
            this.exitBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.exitBtn.UseCompatibleTextRendering = true;
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(3, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 36);
            this.label1.TabIndex = 7;
            this.label1.Text = "Password Manager";
            // 
            // listView
            // 
            this.listView.BackColor = System.Drawing.Color.Silver;
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Name,
            this.Email,
            this.UserName,
            this.Password});
            this.listView.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView.ForeColor = System.Drawing.SystemColors.ControlText;
            this.listView.FullRowSelect = true;
            this.listView.GridLines = true;
            this.listView.HideSelection = false;
            this.listView.Location = new System.Drawing.Point(201, 58);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(705, 434);
            this.listView.TabIndex = 47;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            // 
            // Name
            // 
            this.Name.Text = "Name";
            this.Name.Width = 123;
            // 
            // Email
            // 
            this.Email.Text = "Email";
            this.Email.Width = 195;
            // 
            // UserName
            // 
            this.UserName.Text = "UserName";
            this.UserName.Width = 146;
            // 
            // Password
            // 
            this.Password.Text = "Password";
            this.Password.Width = 257;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(35)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(930, 503);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ColumnHeader Name;
        private System.Windows.Forms.ColumnHeader UserName;
        private System.Windows.Forms.ColumnHeader Password;
        public System.Windows.Forms.Button exitBtn;
        private Bunifu.Framework.UI.BunifuThinButton2 EditAccount;
        private Bunifu.Framework.UI.BunifuThinButton2 SerchPassBtn;
        private Bunifu.Framework.UI.BunifuThinButton2 NewPassword_btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ColumnHeader Email;
        private Bunifu.Framework.UI.BunifuThinButton2 MyPassBtn;
        private Bunifu.Framework.UI.BunifuThinButton2 EditPassBtn;
    }
}