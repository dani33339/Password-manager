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
using MongoDB.Libmongocrypt;
using System.Security.Cryptography;

namespace passwordmamanger
{
    public partial class Registration : Form
    {
        Crypto Crip = new Crypto();
        Db DataBase = new Db();

        public Registration()
        {
            InitializeComponent();       
        }

        public bool CheckUserExist(String user)
        {
            var filter = Builders<UserInfo>.Filter;

            var userfilter = filter.Eq(x => x.UserName, user);

            var backcall = DataBase.getcollectionUser().Find<UserInfo>(userfilter).FirstOrDefault();

            if (backcall != null)
                return true;

            return false;

        }

        

        public bool CheckPassword(string password)
        {
            if (password.Length != 8)
                return false;
            string digits = new String(password.Where(Char.IsDigit).ToArray());
            string letters = new String(password.Where(Char.IsLetter).ToArray());
            password.Where(c => !char.IsLetterOrDigit(c));
            if (digits.Length == 0 || letters.Length == 0 || password.Length - digits.Length - letters.Length == 0)
                return false;
            return true;
        }
        public void Clear()
        {
            username_textbox.Clear();
            nameBox.Clear();
            passwordbox.Clear();
            RePasswordBox.Clear();
            EmailBox.Clear();
        }


        private void Registration_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void passwordbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void EmailBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void nametextbox(object sender, EventArgs e)
        {

        }
        public bool CheckUser(string user)
        {
            if (user.Length < 6 || user.Length > 8)
                return false;
            string digits = new String(user.Where(Char.IsDigit).ToArray());
            if (digits.Length > 2)
                return false;
            string letters = new String(user.Where(Char.IsLetter).ToArray());
            if (letters.Length + digits.Length != user.Length)
                return false;
            return true;
        }

        private void Registration_btn_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(username_textbox.Text) || String.IsNullOrEmpty(nameBox.Text) || String.IsNullOrEmpty(EmailBox.Text))
            {
                MessageBox.Show("הכנס את כל הפרטים");
                return;
            }
            if (passwordbox.Text != RePasswordBox.Text)
            {
                MessageBox.Show("הסיסמאות לא תואמות", "אזהרה", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!CheckUser(username_textbox.Text))
            {
                MessageBox.Show("שם המשתמש לא תקין\n שם משתמש - מכיל בין 6 ל 8 תווים. מתוך התווים, לכל היותר 2 ספרות וכל השאר אותיות ", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!CheckPassword(passwordbox.Text))
            {
                MessageBox.Show("The password not strong(password length must be 8 letter,at least include one capital letter,one small letter, and one special simbol)", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (CheckUserExist(username_textbox.Text))
            {
                MessageBox.Show("השם משתמש קיים במערכת", "אזהרה", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }


            UserInfo NewUser = new UserInfo();
            NewUser.UserName = username_textbox.Text;         
            NewUser.FirstName = nameBox.Text;
            NewUser.Password = Crip.Encrypt(passwordbox.Text);
            NewUser.Email = EmailBox.Text;
            NewUser.sites = new List<MongoDB.Bson.ObjectId>();

            DataBase.getcollectionUser().InsertOne(NewUser);

            MessageBox.Show("User has been successfully saved.");
            Clear();
            GoToLogin();
        }
        public void GoToLogin()
        {
            Login newForm = new Login();
            this.Hide();
            newForm.ShowDialog();
            this.Close();

        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            GoToLogin();
        }
    }
}
