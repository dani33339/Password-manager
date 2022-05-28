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
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Interactions;
using Keys = OpenQA.Selenium.Keys;
using System.Threading;

namespace passwordmamanger
{
    public partial class MainForm : Form
    {
        UserInfo user;
        Crypto Crip = new Crypto();
        Db DataBase = new Db();
        public MainForm(UserInfo enteruser)
        {
            InitializeComponent();
            user = enteruser;
            List<Sites> SitesList = new List<Sites>();

            foreach (Sites site in user.sites)
            {
                if (site!= null)
                    SitesList.Add(site);
            }

            foreach (Sites site in SitesList)
            {
                String[] rowa = { site.Name.ToString(), site.Email.ToString(), site.UserName.ToString(), Crip.decrypt(site.Password).ToString() };
                ListViewItem item = new ListViewItem(rowa);            
                listView.Items.Add(item);
            }

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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SerchPassBtn_Click(object sender, EventArgs e)
        {
            var list = listView.Items.Cast<ListViewItem>().Where(x => x.SubItems.Cast<ListViewItem.ListViewSubItem>()
           .Any(y => y.Text.Contains(serchBox.Text))).ToArray();
            listView.Items.Clear();
            listView.Items.AddRange(list);
        }

        private void CancelLBtnSth_Click(object sender, EventArgs e)
        {
            MainForm newForm = new MainForm(user);
            this.Hide();
            newForm.ShowDialog();
            this.Close();
        }

        private void listView_SelectedIndexChanged(object sender, EventArgs e)
        {
            var firstSelectedItem = listView.SelectedItems[0];

            var filter = Builders<Sites>.Filter;

            var nameweb = filter.Eq(x => x.Name, firstSelectedItem.Text);

            var site = DataBase.getcollectionSties().Find<Sites>(nameweb).FirstOrDefault();

            System.Diagnostics.Process.Start(site.website);

            //IWebDriver driver = new FirefoxDriver();
            //driver.Url = site.website;
            //Actions actions = new Actions(driver);
            //actions.Click(driver.FindElement(By.Id("Email"))).
            //    SendKeys(site.Email + Keys.Tab)
            //    .SendKeys(Crip.decrypt(site.Password))
            //    .Build().Perform();
            //Thread.Sleep(2000);
            //driver.Quit();
        }
    }
}
