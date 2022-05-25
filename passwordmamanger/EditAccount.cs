using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Driver;
using MongoDB.Bson;

namespace passwordmamanger
{
    public partial class EditAccount : Form
    {
        Crypto Crip = new Crypto();
        Db DataBase = new Db();
        IMongoCollection<UserInfo> collectionUser;
        UserInfo user;
        public EditAccount(UserInfo User)
        {
            InitializeComponent();
            user = User;
            username_textbox.Text = user.UserName;
            PasswordBox.Text = Crip.decrypt(user.Password);
            NameBox.Text = user.FirstName;
            EmailBox.Text = user.Email;
            collectionUser = DataBase.getcollection();
        }

      
        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void EditAccount_Load(object sender, EventArgs e)
        {

        }

        private void username_textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void PasswordBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void DeleteAccBtn_Click(object sender, EventArgs e)
        {
            var deleteFilter = Builders<UserInfo>.Filter.Eq("UserName", user.UserName);
            collectionUser.DeleteOne(deleteFilter);
            Login newForm = new Login();
            this.Hide();
            newForm.ShowDialog();
            this.Close();
        }
    }
}
