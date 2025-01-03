﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Driver;
using MongoDB.Bson;
using System.Net.Mail;
namespace passwordmamanger
{
    public partial class AddSite : Form
    {
        Random_password random_Password = new Random_password();
        Db DataBase = new Db();

        Crypto Crip = new Crypto();
        UserInfo user;

        Boolean clicked = false;

        public AddSite(UserInfo User)
        {
            InitializeComponent();
            user = User;
            Sitename_label.Visible = false;
            NameBox.Visible = false;
            TLD_comboBox.Visible = false;
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (clicked == false)
            {
                MessageBox.Show("You have to chose add by name or add by address");
                return;
            }
            if (String.IsNullOrEmpty(UserNameBox.Text) || String.IsNullOrEmpty(NameBox.Text) || String.IsNullOrEmpty(EmailBox.Text) || String.IsNullOrEmpty(PasswordBox.Text) || String.IsNullOrEmpty(TLD_comboBox.Text))
            {
                MessageBox.Show("Fill all the filds");
                return;
            }
            if (!CheckPassword(PasswordBox.Text))
            {
                MessageBox.Show("The password not strong(password length must be 8 letter,at least include one capital letter,one small letter, and one special simbol)", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!validMail(EmailBox.Text))
            {
                MessageBox.Show("The email is not valid");
                return;
            }

            Sites pass = new Sites();
            pass.Name = NameBox.Text;
            pass.Password = Crip.Encrypt(PasswordBox.Text);
            pass.Email = EmailBox.Text;
            pass.UserName = UserNameBox.Text;
            pass.TLD = TLD_comboBox.Text;
            if (Sitename_label.Text != "Enter site url")
                pass.website = "www" + "." + NameBox.Text + "." + TLD_comboBox.Text; //if user didn't enter the url
            else
                pass.website = NameBox.Text;
            pass.User = user.Id;
            DataBase.getcollectionSties().InsertOne(pass);

            user.sites.Add(pass.Id);
            UpdateDefinition<UserInfo> Sitesupdate = Builders<UserInfo>.Update.Set(x => x.sites, user.sites);
            var filter = Builders<UserInfo>.Filter;
            var userfilter = filter.Eq(x => x.Id, user.Id);
            DataBase.getcollectionUser().UpdateOne(userfilter, Sitesupdate);

            MessageBox.Show("password has been successfully saved.");
            Clear();
            GoMain();
        }
        public void Clear()
        {
            NameBox.Clear();
            PasswordBox.Clear();
            EmailBox.Clear();
            UserNameBox.Clear();
        }
        private bool validMail(string address)
        {
            try
            {
                var mail = new MailAddress(address);

                return mail.Host.Contains(".");
            }
            catch
            {
                return false;
            }
        }
        public void GoMain()
        {
            MainForm newForm = new MainForm(user);
            this.Hide();
            newForm.ShowDialog();
            this.Close();

        }
        public bool CheckPassword(string password)
        {
            if (password.Length != 8)
                return false;
            if (password.Contains(" "))
                return false;
            if (!password.Any(char.IsLower))
                return false;
            if (!password.Any(char.IsUpper))
                return false;
            string specialCh = "!@#$%^&*)(=-+?<>[]}{\\//|~";
            char[] specialChArray = specialCh.ToCharArray();
            foreach (char ch in specialChArray)
            {
                if (password.Contains(ch))
                    return true;
            }
            return false;
        }
        private void generateBtn_Click(object sender, EventArgs e)
        {
            PasswordBox.Text = random_Password.GenerateRandomStrongPassword();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            GoMain();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            GoMain();
        }

        private void Byname_btn_Click(object sender, EventArgs e)
        {
            Byname_btn.Visible = false;
            Byaddress_btn.Visible = false;
            Sitename_label.Visible = true;
            NameBox.Visible = true;
            TLD_comboBox.Visible = true;
            clicked = true;
        }

        private void Byaddress_btn_Click(object sender, EventArgs e)
        {
            Byaddress_btn.Visible = false;
            Byname_btn.Visible = false;
            Sitename_label.Text = "Enter site url";
            Sitename_label.Visible = true;
            NameBox.Visible = true;
            TLD_comboBox.Visible = true;
            clicked = true;
        }
    }
}
