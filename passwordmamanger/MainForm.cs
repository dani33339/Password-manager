using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace passwordmamanger
{
    public partial class MainForm : Form
    {
        UserInfo user;
        public MainForm(UserInfo enteruser)
        {
            InitializeComponent();
            user = enteruser;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void NewPassword_btn_Click(object sender, EventArgs e)
        {

        }

        private void EditAccount_Click(object sender, EventArgs e)
        {
            EditAccount newForm = new EditAccount(user);
            this.Hide();
            newForm.ShowDialog();
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
