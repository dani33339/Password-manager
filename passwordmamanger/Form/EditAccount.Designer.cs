namespace passwordmamanger
{
    partial class EditAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditAccount));
            this.label1 = new System.Windows.Forms.Label();
            this.DeleteAccBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.EditAccBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.PasswordBox = new System.Windows.Forms.TextBox();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.EmailBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Ivory;
            this.label1.Location = new System.Drawing.Point(60, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 36);
            this.label1.TabIndex = 7;
            this.label1.Text = "My Account";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // DeleteAccBtn
            // 
            this.DeleteAccBtn.ActiveBorderThickness = 1;
            this.DeleteAccBtn.ActiveCornerRadius = 20;
            this.DeleteAccBtn.ActiveFillColor = System.Drawing.Color.SlateGray;
            this.DeleteAccBtn.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(65)))), ((int)(((byte)(118)))));
            this.DeleteAccBtn.ActiveLineColor = System.Drawing.Color.DarkSlateGray;
            this.DeleteAccBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(35)))), ((int)(((byte)(60)))));
            this.DeleteAccBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DeleteAccBtn.BackgroundImage")));
            this.DeleteAccBtn.ButtonText = "Delete Account";
            this.DeleteAccBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteAccBtn.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteAccBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.DeleteAccBtn.IdleBorderThickness = 1;
            this.DeleteAccBtn.IdleCornerRadius = 20;
            this.DeleteAccBtn.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(65)))), ((int)(((byte)(118)))));
            this.DeleteAccBtn.IdleForecolor = System.Drawing.Color.WhiteSmoke;
            this.DeleteAccBtn.IdleLineColor = System.Drawing.Color.LightSlateGray;
            this.DeleteAccBtn.Location = new System.Drawing.Point(66, 355);
            this.DeleteAccBtn.Margin = new System.Windows.Forms.Padding(6);
            this.DeleteAccBtn.Name = "DeleteAccBtn";
            this.DeleteAccBtn.Size = new System.Drawing.Size(166, 50);
            this.DeleteAccBtn.TabIndex = 50;
            this.DeleteAccBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.DeleteAccBtn.Click += new System.EventHandler(this.DeleteAccBtn_Click);
            // 
            // EditAccBtn
            // 
            this.EditAccBtn.ActiveBorderThickness = 1;
            this.EditAccBtn.ActiveCornerRadius = 20;
            this.EditAccBtn.ActiveFillColor = System.Drawing.Color.SlateGray;
            this.EditAccBtn.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(65)))), ((int)(((byte)(118)))));
            this.EditAccBtn.ActiveLineColor = System.Drawing.Color.DarkSlateGray;
            this.EditAccBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(35)))), ((int)(((byte)(60)))));
            this.EditAccBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("EditAccBtn.BackgroundImage")));
            this.EditAccBtn.ButtonText = "Edit";
            this.EditAccBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EditAccBtn.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditAccBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.EditAccBtn.IdleBorderThickness = 1;
            this.EditAccBtn.IdleCornerRadius = 20;
            this.EditAccBtn.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(65)))), ((int)(((byte)(118)))));
            this.EditAccBtn.IdleForecolor = System.Drawing.Color.WhiteSmoke;
            this.EditAccBtn.IdleLineColor = System.Drawing.Color.LightSlateGray;
            this.EditAccBtn.Location = new System.Drawing.Point(112, 295);
            this.EditAccBtn.Margin = new System.Windows.Forms.Padding(6);
            this.EditAccBtn.Name = "EditAccBtn";
            this.EditAccBtn.Size = new System.Drawing.Size(77, 48);
            this.EditAccBtn.TabIndex = 51;
            this.EditAccBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.EditAccBtn.Click += new System.EventHandler(this.EditAccBtn_Click);
            // 
            // PasswordBox
            // 
            this.PasswordBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.PasswordBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PasswordBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordBox.ForeColor = System.Drawing.SystemColors.InfoText;
            this.PasswordBox.Location = new System.Drawing.Point(40, 110);
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.Size = new System.Drawing.Size(225, 27);
            this.PasswordBox.TabIndex = 53;
            this.PasswordBox.Text = "Password";
            this.PasswordBox.TextChanged += new System.EventHandler(this.PasswordBox_TextChanged);
            // 
            // NameBox
            // 
            this.NameBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.NameBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NameBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameBox.ForeColor = System.Drawing.SystemColors.InfoText;
            this.NameBox.Location = new System.Drawing.Point(40, 174);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(225, 27);
            this.NameBox.TabIndex = 54;
            this.NameBox.Text = "Name";
            // 
            // EmailBox
            // 
            this.EmailBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.EmailBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EmailBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailBox.ForeColor = System.Drawing.SystemColors.InfoText;
            this.EmailBox.Location = new System.Drawing.Point(40, 235);
            this.EmailBox.Name = "EmailBox";
            this.EmailBox.Size = new System.Drawing.Size(225, 27);
            this.EmailBox.TabIndex = 55;
            this.EmailBox.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gold;
            this.label3.Location = new System.Drawing.Point(36, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 24);
            this.label3.TabIndex = 57;
            this.label3.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gold;
            this.label4.Location = new System.Drawing.Point(36, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 24);
            this.label4.TabIndex = 58;
            this.label4.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gold;
            this.label5.Location = new System.Drawing.Point(36, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 24);
            this.label5.TabIndex = 59;
            this.label5.Text = "Name";
            // 
            // EditAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(35)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(305, 424);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.EmailBox);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.PasswordBox);
            this.Controls.Add(this.EditAccBtn);
            this.Controls.Add(this.DeleteAccBtn);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditAccount";
            this.Load += new System.EventHandler(this.EditAccount_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuThinButton2 DeleteAccBtn;
        private Bunifu.Framework.UI.BunifuThinButton2 EditAccBtn;
        private System.Windows.Forms.TextBox PasswordBox;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.TextBox EmailBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}