namespace passwordmamanger
{
    partial class Registration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registration));
            this.username_textbox = new System.Windows.Forms.TextBox();
            this.PasswordBox = new System.Windows.Forms.TextBox();
            this.RePasswordBox = new System.Windows.Forms.TextBox();
            this.EmailBox = new System.Windows.Forms.TextBox();
            this.Registration_btn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.backBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.exitBtn = new System.Windows.Forms.Button();
            this.generateBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.SuspendLayout();
            // 
            // username_textbox
            // 
            this.username_textbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.username_textbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.username_textbox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_textbox.ForeColor = System.Drawing.SystemColors.InfoText;
            this.username_textbox.Location = new System.Drawing.Point(72, 161);
            this.username_textbox.Name = "username_textbox";
            this.username_textbox.Size = new System.Drawing.Size(225, 27);
            this.username_textbox.TabIndex = 5;
            this.username_textbox.Text = "username";
            // 
            // PasswordBox
            // 
            this.PasswordBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.PasswordBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PasswordBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordBox.ForeColor = System.Drawing.SystemColors.InfoText;
            this.PasswordBox.Location = new System.Drawing.Point(72, 213);
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.Size = new System.Drawing.Size(225, 27);
            this.PasswordBox.TabIndex = 6;
            this.PasswordBox.Text = "password";
            this.PasswordBox.TextChanged += new System.EventHandler(this.passwordbox_TextChanged);
            // 
            // RePasswordBox
            // 
            this.RePasswordBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.RePasswordBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RePasswordBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RePasswordBox.ForeColor = System.Drawing.SystemColors.InfoText;
            this.RePasswordBox.Location = new System.Drawing.Point(72, 261);
            this.RePasswordBox.Name = "RePasswordBox";
            this.RePasswordBox.Size = new System.Drawing.Size(225, 27);
            this.RePasswordBox.TabIndex = 7;
            this.RePasswordBox.Text = "Renter Password";
            this.RePasswordBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // EmailBox
            // 
            this.EmailBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.EmailBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EmailBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailBox.ForeColor = System.Drawing.SystemColors.InfoText;
            this.EmailBox.Location = new System.Drawing.Point(72, 309);
            this.EmailBox.Name = "EmailBox";
            this.EmailBox.Size = new System.Drawing.Size(225, 27);
            this.EmailBox.TabIndex = 8;
            this.EmailBox.Text = "email";
            this.EmailBox.TextChanged += new System.EventHandler(this.EmailBox_TextChanged);
            // 
            // Registration_btn
            // 
            this.Registration_btn.ActiveBorderThickness = 1;
            this.Registration_btn.ActiveCornerRadius = 20;
            this.Registration_btn.ActiveFillColor = System.Drawing.Color.SlateGray;
            this.Registration_btn.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(65)))), ((int)(((byte)(118)))));
            this.Registration_btn.ActiveLineColor = System.Drawing.Color.DarkSlateGray;
            this.Registration_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(35)))), ((int)(((byte)(60)))));
            this.Registration_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Registration_btn.BackgroundImage")));
            this.Registration_btn.ButtonText = "Registration";
            this.Registration_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Registration_btn.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Registration_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Registration_btn.IdleBorderThickness = 1;
            this.Registration_btn.IdleCornerRadius = 20;
            this.Registration_btn.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(65)))), ((int)(((byte)(118)))));
            this.Registration_btn.IdleForecolor = System.Drawing.Color.Transparent;
            this.Registration_btn.IdleLineColor = System.Drawing.Color.LightSlateGray;
            this.Registration_btn.Location = new System.Drawing.Point(94, 403);
            this.Registration_btn.Margin = new System.Windows.Forms.Padding(6);
            this.Registration_btn.Name = "Registration_btn";
            this.Registration_btn.Size = new System.Drawing.Size(180, 47);
            this.Registration_btn.TabIndex = 19;
            this.Registration_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Registration_btn.Click += new System.EventHandler(this.Registration_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Ivory;
            this.label1.Location = new System.Drawing.Point(39, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 36);
            this.label1.TabIndex = 20;
            this.label1.Text = "Password Manager";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Webdings", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(138, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 65);
            this.label2.TabIndex = 21;
            this.label2.Text = "~";
            // 
            // nameBox
            // 
            this.nameBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.nameBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nameBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameBox.ForeColor = System.Drawing.SystemColors.InfoText;
            this.nameBox.Location = new System.Drawing.Point(72, 111);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(225, 27);
            this.nameBox.TabIndex = 22;
            this.nameBox.Text = "name";
            this.nameBox.TextChanged += new System.EventHandler(this.nametextbox);
            // 
            // backBtn
            // 
            this.backBtn.ActiveBorderThickness = 1;
            this.backBtn.ActiveCornerRadius = 20;
            this.backBtn.ActiveFillColor = System.Drawing.Color.SlateGray;
            this.backBtn.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(65)))), ((int)(((byte)(118)))));
            this.backBtn.ActiveLineColor = System.Drawing.Color.DarkSlateGray;
            this.backBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(35)))), ((int)(((byte)(60)))));
            this.backBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("backBtn.BackgroundImage")));
            this.backBtn.ButtonText = "Back";
            this.backBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backBtn.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.backBtn.IdleBorderThickness = 1;
            this.backBtn.IdleCornerRadius = 20;
            this.backBtn.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(65)))), ((int)(((byte)(118)))));
            this.backBtn.IdleForecolor = System.Drawing.Color.Transparent;
            this.backBtn.IdleLineColor = System.Drawing.Color.LightSlateGray;
            this.backBtn.Location = new System.Drawing.Point(145, 462);
            this.backBtn.Margin = new System.Windows.Forms.Padding(6);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(85, 42);
            this.backBtn.TabIndex = 23;
            this.backBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.AllowDrop = true;
            this.exitBtn.AutoEllipsis = true;
            this.exitBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.exitBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(35)))), ((int)(((byte)(60)))));
            this.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(35)))), ((int)(((byte)(60)))));
            this.exitBtn.Image = ((System.Drawing.Image)(resources.GetObject("exitBtn.Image")));
            this.exitBtn.Location = new System.Drawing.Point(330, 0);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(43, 41);
            this.exitBtn.TabIndex = 30;
            this.exitBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.exitBtn.UseCompatibleTextRendering = true;
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // generateBtn
            // 
            this.generateBtn.ActiveBorderThickness = 1;
            this.generateBtn.ActiveCornerRadius = 20;
            this.generateBtn.ActiveFillColor = System.Drawing.Color.SlateGray;
            this.generateBtn.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(65)))), ((int)(((byte)(118)))));
            this.generateBtn.ActiveLineColor = System.Drawing.Color.DarkSlateGray;
            this.generateBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(35)))), ((int)(((byte)(60)))));
            this.generateBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("generateBtn.BackgroundImage")));
            this.generateBtn.ButtonText = "Generate Password";
            this.generateBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.generateBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generateBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.generateBtn.IdleBorderThickness = 1;
            this.generateBtn.IdleCornerRadius = 20;
            this.generateBtn.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(65)))), ((int)(((byte)(118)))));
            this.generateBtn.IdleForecolor = System.Drawing.Color.Transparent;
            this.generateBtn.IdleLineColor = System.Drawing.Color.LightSlateGray;
            this.generateBtn.Location = new System.Drawing.Point(101, 356);
            this.generateBtn.Name = "generateBtn";
            this.generateBtn.Size = new System.Drawing.Size(169, 38);
            this.generateBtn.TabIndex = 31;
            this.generateBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.generateBtn.Click += new System.EventHandler(this.generateBtn_Click);
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(35)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(376, 529);
            this.Controls.Add(this.generateBtn);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Registration_btn);
            this.Controls.Add(this.EmailBox);
            this.Controls.Add(this.RePasswordBox);
            this.Controls.Add(this.PasswordBox);
            this.Controls.Add(this.username_textbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Registration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registration";
            this.Load += new System.EventHandler(this.Registration_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox username_textbox;
        private System.Windows.Forms.TextBox PasswordBox;
        private System.Windows.Forms.TextBox RePasswordBox;
        private System.Windows.Forms.TextBox EmailBox;
        private Bunifu.Framework.UI.BunifuThinButton2 Registration_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nameBox;
        private Bunifu.Framework.UI.BunifuThinButton2 backBtn;
        public System.Windows.Forms.Button exitBtn;
        private Bunifu.Framework.UI.BunifuThinButton2 generateBtn;
    }
}