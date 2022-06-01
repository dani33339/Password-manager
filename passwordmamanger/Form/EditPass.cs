using System;
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
    public partial class EditPass : Form
    {
        Crypto Crip = new Crypto();
        Db DataBase = new Db();
        UserInfo user; 
        Random_password random_Password = new Random_password();
        IMongoCollection<Sites> collectionsites;
        IMongoCollection<UserInfo> collectionsuer;
        Sites Ssite;
        public EditPass(UserInfo enteruser, string Name = "Name", string Email = "Email", string UserName = "UserName", string Password = "Password", Sites SelectedSite =null)
        {
            InitializeComponent();
            collectionsites = DataBase.getcollectionSties();
            collectionsuer = DataBase.getcollectionUser();
            user = enteruser;
            Ssite = SelectedSite;
            NameBox.Text = Name;
            EmailBox.Text = Email;
            UserNameBox.Text = UserName;
            PasswordBox.Text = Password;

            List<Sites> SitesList = new List<Sites>();

            foreach (MongoDB.Bson.ObjectId Id in user.sites)
            {
                if (siteFinder(Id) != null)
                    SitesList.Add(siteFinder(Id));
            }

            foreach (Sites site in SitesList)
            {
                String[] rowa = { site.Name.ToString(), site.Email.ToString(), site.UserName.ToString(), Crip.decrypt(site.Password).ToString() };
                ListViewItem item = new ListViewItem(rowa);
                listView.Items.Add(item);
            }
        }
        public Sites siteFinder(MongoDB.Bson.ObjectId Id)
        {
            var filter = Builders<Sites>.Filter;
            var idfilter = filter.Eq(x => x.Id, Id);
            var site = collectionsites.Find<Sites>(idfilter).FirstOrDefault();
            return site;
        }

        private void MyPassBtn_Click(object sender, EventArgs e)
        {
            MainForm newForm = new MainForm(user);
            this.Hide();
            newForm.ShowDialog();
            this.Close();

        }

        private void NewPassword_btn_Click(object sender, EventArgs e)
        {
            AddSite newForm = new AddSite(user);
            this.Hide();
            newForm.ShowDialog();
            this.Close();
        }

        private void EditAccount_Click(object sender, EventArgs e)
        {
            EditAccount newForm = new EditAccount(user);
            this.Hide();
            newForm.ShowDialog();
            this.Close();

        }

        private void EditPassBtn_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(UserNameBox.Text) || String.IsNullOrEmpty(NameBox.Text) || String.IsNullOrEmpty(EmailBox.Text) || String.IsNullOrEmpty(PasswordBox.Text))
            {
                MessageBox.Show("Fill all the filds");
                return;
            }
            
            if (!validMail(EmailBox.Text))
            {
                MessageBox.Show("The email is not valid");
                return;
            }           
            if (!CheckPassword(PasswordBox.Text))
            {
                MessageBox.Show("The password not strong(password length must be 8 letter,at least include one capital letter,one small letter, and one special simbol)", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var filtersite = Builders<Sites>.Filter.Eq("Name", Ssite.Name);
            UpdateDefinition<Sites> Emailupdate = Builders<Sites>.Update.Set(x => x.Email, EmailBox.Text);
            UpdateDefinition<Sites> Nameupdate = Builders<Sites>.Update.Set(x => x.Name, NameBox.Text);
            UpdateDefinition<Sites> UserNameupdate = Builders<Sites>.Update.Set(x => x.UserName, UserNameBox.Text);
            UpdateDefinition<Sites> Passwordupdate = Builders<Sites>.Update.Set(x => x.Password, Crip.Encrypt(PasswordBox.Text));
            collectionsites.UpdateOneAsync(filtersite, Passwordupdate);
            collectionsites.UpdateOneAsync(filtersite, UserNameupdate);
            collectionsites.UpdateOneAsync(filtersite, Nameupdate);
            collectionsites.UpdateOneAsync(filtersite, Emailupdate);
            
            UpdateDefinition<UserInfo> Sitesupdate = Builders<UserInfo>.Update.Set(x => x.sites, user.sites);
            var filteruser = Builders<UserInfo>.Filter;
            var userfilter = filteruser.Eq(x => x.Id, user.Id);
            DataBase.getcollectionUser().UpdateOne(userfilter, Sitesupdate);

            MessageBox.Show("The password is successfully Update ", "password Update", MessageBoxButtons.OK, MessageBoxIcon.Information);

            EditPass newForm = new EditPass(user);
            this.Hide();
            newForm.ShowDialog();
            this.Close();
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
        private void listView_SelectedIndexChanged(object sender, EventArgs e)
        {
            var firstSelectedItem = listView.SelectedItems[0];

            var filter = Builders<Sites>.Filter;

            var nameweb = filter.Eq(x => x.Name, firstSelectedItem.SubItems[0].Text);


            var site = DataBase.getcollectionSties().Find<Sites>(nameweb).FirstOrDefault();
           
            EditPass newForm = new EditPass(user, site.Name, site.Email, site.UserName, Crip.decrypt(site.Password), site);
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

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GeneratePassBtn_Click(object sender, EventArgs e)
        {
            PasswordBox.Text = random_Password.GenerateRandomStrongPassword();
        }
        public void DeleteSiteInUser(MongoDB.Bson.ObjectId id)
        {
            var list = user.sites;
            int index = list.IndexOf(id);
            list.RemoveAt(index);
            UpdateDefinition<UserInfo> Sitesupdate = Builders<UserInfo>.Update.Set(x => x.sites, list);
            var filter = Builders<UserInfo>.Filter;
            var userfilter = filter.Eq(x => x.Id, user.Id);
            DataBase.getcollectionUser().UpdateOne(userfilter, Sitesupdate);

        }
        private void DeleteSiteBtn_Click(object sender, EventArgs e)
        {
            var Filter = Builders<Sites>.Filter.Eq("UserName", UserNameBox.Text);

            Sites site = collectionsites.Find<Sites>(Filter).First();
            DeleteSiteInUser(site.Id);
            collectionsites.DeleteOne(Filter);
            EditPass newForm = new EditPass(user);
            this.Hide();
            newForm.ShowDialog();
            this.Close();         
        }
    }
}
