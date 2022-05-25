using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MongoDB.Driver;
using MongoDB.Bson;
using System.Security.Cryptography;

namespace passwordmamanger
{

    public partial class Login : Form
    {
        Crypto Crip = new Crypto();
        Db DataBase = new Db();
        public Login()
        {
            InitializeComponent();
           
        }



        private void password_TextChanged(object sender, EventArgs e)
        {

        }

        private void username_textbox_TextChanged(object sender, EventArgs e)
        {

        }
       

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void login_btn_Click_1(object sender, EventArgs e)
        {
            try
            {
                String User = username_textbox.Text;
                String Password = Crip.Encrypt(passwordTextBox.Text);

                var filter = Builders<UserInfo>.Filter;

                var userfilter = filter.Eq(x => x.UserName, User);

                var Passwordfilter = filter.Eq(x => x.Password, Password);

                var finalfilter = filter.And(userfilter, Passwordfilter);

                var enteruser = DataBase.getcollection().Find<UserInfo>(finalfilter).FirstOrDefault();



                if (enteruser != null)
                {
                    MessageBox.Show("שלום  " + enteruser.FirstName + "  ", "ניתנה גישה", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    MainForm newForm = new MainForm(enteruser);
                    this.Hide();
                    newForm.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("סיסמא או שם משתמש לא נכונים", "גישה נדחתה", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


        private void Signup_btn(object sender, EventArgs e)
        {
            Registration newForm = new Registration();
            this.Hide();
            newForm.ShowDialog();
            this.Close();

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
