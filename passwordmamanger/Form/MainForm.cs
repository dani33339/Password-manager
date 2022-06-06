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
using System.Reflection;
using OpenQA.Selenium.Chrome;
using Microsoft.Win32;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Safari;
using OpenQA.Selenium.IE;

namespace passwordmamanger
{
    public partial class MainForm : Form
    {
        UserInfo user;
        Crypto Crip = new Crypto();
        Db DataBase = new Db();
        IMongoCollection<Sites> collectionsites;
        IMongoCollection<UserInfo> collectionsuer;
        private IWebDriver driver;

        public MainForm(UserInfo enteruser)
        {
            InitializeComponent();
            user = enteruser;
            List<Sites> SitesList = new List<Sites>();
            collectionsites = DataBase.getcollectionSties();
            collectionsuer = DataBase.getcollectionUser();
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
            if (listView.SelectedItems.Count == 0)
                return;

            var firstSelectedItem = listView.SelectedItems[0];

            var filter = Builders<Sites>.Filter;

            var nameweb = filter.Eq(x => x.Name, firstSelectedItem.SubItems[0].Text);


            var site = DataBase.getcollectionSties().Find<Sites>(nameweb).FirstOrDefault();

            //set the driver to the default broswer of the use
            SetDriver();

            //facebook
            if (site.Name == "facebook" || site.Name == "www.facebook" || site.website == "www.facebook.com")
            {
                try
                {
                    driver.Navigate().GoToUrl("https://" + site.website);
                    Actions actions = new Actions(driver);
                    actions.Click(driver.FindElement(By.Id("email"))).
                        SendKeys(site.Email + Keys.Tab)
                        .SendKeys(Crip.decrypt(site.Password) + Keys.Enter)
                        .Build().Perform();
                    System.Threading.Thread.Sleep(6000);
                    if (driver.FindElement(By.XPath("/html/body/div[1]/div/div[1]/div/div[3]/div/div/div[1]/div[1]/div/div[2]/div/div/div[1]/span")).Text.Contains("ברוך הבא לפייסבוק"))
                    {
                        MessageBox.Show("You have successfully signed in");
                        return;
                    }
                    else
                    {
                        throw new Exception();
                    }
                }
                catch
                {
                    MessageBox.Show("Somthing went wrong check the email and password");
                    return;
                }
            }

            //amazon
            if (site.Name == "amazon" || site.Name == "www.amazon" || site.website == "www.amazon.com")
            {
                try
                {
                    driver.Navigate().GoToUrl("https://" + "www.amazon.com/ap/signin?openid.pape.max_auth_age=0&openid.return_to=https%3A%2F%2Fwww.amazon.com%2F%3Fref_%3Dnav_custrec_signin&openid.identity=http%3A%2F%2Fspecs.openid.net%2Fauth%2F2.0%2Fidentifier_select&openid.assoc_handle=usflex&openid.mode=checkid_setup&openid.claimed_id=http%3A%2F%2Fspecs.openid.net%2Fauth%2F2.0%2Fidentifier_select&openid.ns=http%3A%2F%2Fspecs.openid.net%2Fauth%2F2.0&");
                    Actions actions = new Actions(driver);
                    actions.Click(driver.FindElement(By.Id("ap_email"))).
                        SendKeys(site.Email + Keys.Enter).Build().Perform();
                    System.Threading.Thread.Sleep(1000);
                    actions.Click(driver.FindElement(By.Id("ap_password")))
                        .SendKeys(Crip.decrypt(site.Password) + Keys.Enter)
                        .Build().Perform();

                    System.Threading.Thread.Sleep(1000);
                    if (driver.FindElement(By.XPath("/html/body/div[1]/div[1]/div[2]/div/div[1]/div/div/div/h4")).Text == "There was a problem")
                        throw new Exception();
                    else
                    {
                        MessageBox.Show("You have successfully signed in");
                        return;
                    }
                }
                catch
                {
                    MessageBox.Show("Somthing went wrong check the email and password");
                    return;
                }
            }

            //ebay
            if (site.Name == "ebay" || site.Name == "www.ebay" || site.website == "www.ebay.com")
            {
                try
                {
                    driver.Navigate().GoToUrl("https://signin.ebay.com/ws/eBayISAPI.dll?SignIn&ru=https%3A%2F%2Fwww.ebay.com%2F");
                    Actions actions = new Actions(driver);
                    actions.Click(driver.FindElement(By.Id("userid"))).
                        SendKeys(site.Email + Keys.Enter).Build().Perform();
                    System.Threading.Thread.Sleep(1000);
                    actions.Click(driver.FindElement(By.Id("pass")))
                        .SendKeys(Crip.decrypt(site.Password))
                        .Build().Perform();

                    System.Threading.Thread.Sleep(1000);
                    if (driver.FindElement(By.XPath("//*[@id=' +'errormsg']")).Text == "There was a problem")
                        throw new Exception();
                }
                catch
                {
                    MessageBox.Show("Somthing went wrong check the email and password");
                    return;
                }
            }

            //sce moodle
            if (site.Name == "sce" || site.Name == "www.moodle.sce" || site.website == "moodle.sce.ac.il")
            {
                try
                {
                    driver.Navigate().GoToUrl("https://moodle.sce.ac.il/");
                    Actions actions = new Actions(driver);
                    actions.Click(driver.FindElement(By.Id("username"))).
                        SendKeys(site.UserName + Keys.Tab)
                        .SendKeys(Crip.decrypt(site.Password) + Keys.Enter)
                        .Build().Perform();
                    System.Threading.Thread.Sleep(1000);

                    if (driver.FindElement(By.XPath("//*[@id='wrong_']")).Text == "שם משתמש/סיסמה לא נכונים, אנא נסה/י שוב")
                        throw new Exception();
                    else
                    {
                        MessageBox.Show("You have successfully signed in");
                        return;
                    }
                }
                catch
                {
                    MessageBox.Show("Somthing went wrong check the email and password");
                    return;
                }
            }

            //netflix
            if (site.Name == "netflix" || site.Name == "www.netflix" || site.website == "netflix.com")
            {
                try
                {
                    driver.Navigate().GoToUrl("https://www.netflix.com/il-en/login");
                    Actions actions = new Actions(driver);
                    actions.Click(driver.FindElement(By.Id("id_userLoginId"))).
                        SendKeys(site.Email + Keys.Tab)
                        .SendKeys(Crip.decrypt(site.Password) + Keys.Enter)
                        .Build().Perform();
                    System.Threading.Thread.Sleep(1000);

                    if (driver.FindElement(By.XPath("/html/body/div[1]/div/div[3]/div/div/div[1]/div/div[2]")).Text == "Incorrect password. Please try again or you can reset your password.")
                        throw new Exception();
                    else
                    {
                        MessageBox.Show("You have successfully signed in");
                        return;
                    }
                }
                catch
                {
                    MessageBox.Show("Somthing went wrong check the email and password");
                    return;
                }
            }
            //fxp
            if (site.Name == "fxp" || site.Name == "www.fxp" || site.website == "fxp.co.il")
            {
                try
                {
                    driver.Navigate().GoToUrl("https://www.fxp.co.il/loginpage.php");
                    Actions actions = new Actions(driver);
                    actions.Click(driver.FindElement(By.Id("navbar_username"))).
                        SendKeys(site.Email + Keys.Tab)
                        .SendKeys(Crip.decrypt(site.Password) + Keys.Enter)
                        .Build().Perform();
                    System.Threading.Thread.Sleep(1000);
                    if (driver.FindElement(By.XPath("/html/body/div[4]/div[4]/h2")).Text == "הודעת מערכת")
                        throw new Exception();
                    else
                    {
                        MessageBox.Show("You have successfully signed in");
                        return;
                    }
                }
                catch
                {
                    MessageBox.Show("Somthing went wrong check the email and password");
                    return;
                }
            }

            //Gmail
            if (site.Name == "gmail" || site.Name == "www.gmail" || site.website == "gmail.com")
            {
                try
                {
                    driver.Navigate().GoToUrl("https://accounts.google.com/signin/v2/identifier?flowName=GlifWebSignIn&flowEntry=ServiceLogin");
                    Actions actions = new Actions(driver);
                    actions.Click(driver.FindElement(By.Id("identifierId"))).
                        SendKeys(site.Email + Keys.Enter).Build().Perform();
                    System.Threading.Thread.Sleep(1000);
                    actions.Click(driver.FindElement(By.Name("password")))
                        .SendKeys(Crip.decrypt(site.Password) + Keys.Enter)
                        .Build().Perform();
                    System.Threading.Thread.Sleep(5000);
                    if (driver.FindElement(By.XPath("/html/body/c-wiz/div/div[2]/div/c-wiz/c-wiz/div/div[3]/div/div/header/div[2]")).Text == "תוכל לנהל את המידע ואת הגדרות הפרטיות והאבטחה שלך כדי להתאים את Google לצרכיך. למידע נוסף")
                    {
                        MessageBox.Show("You have successfully signed in");
                        return;
                    }
                    else
                    {
                        throw new Exception();
                    }

                }
                catch
                {
                    MessageBox.Show("Somthing went wrong check the email and password");
                    return;
                }
            }

            //youtube
            if (site.Name == "youtube" || site.Name == "www.youtube" || site.website == "youtube.com")
            {
                try
                {
                    driver.Navigate().GoToUrl("https://accounts.google.com/signin/v2/identifier?service=youtube&uilel=3&passive=true&continue=https%3A%2F%2Fwww.youtube.com%2Fsignin%3Faction_handle_signin%3Dtrue%26app%3Ddesktop%26hl%3Den%26next%3Dhttps%253A%252F%252Fwww.youtube.com%252F&hl=en&ec=65620&flowName=GlifWebSignIn&flowEntry=ServiceLogin");
                    Actions actions = new Actions(driver);
                    actions.Click(driver.FindElement(By.Id("identifierId"))).
                        SendKeys(site.Email + Keys.Enter).Build().Perform();
                    System.Threading.Thread.Sleep(1000);
                    actions.Click(driver.FindElement(By.Name("password")))
                        .SendKeys(Crip.decrypt(site.Password) + Keys.Enter)
                        .Build().Perform();
                    System.Threading.Thread.Sleep(6000);
                    if (driver.FindElement(By.Id("logo-icon")).Displayed)
                    {
                        MessageBox.Show("You have successfully signed in");
                        return;
                    }
                    else
                    {
                        throw new Exception();
                    }
                }
                catch
                {
                    MessageBox.Show("Somthing went wrong check the email and password");
                    return;
                }
            }

            //spotify
            if (site.Name == "spotify" || site.Name == "www.spotify" || site.website == "spotify.com")
            {
                try
                {
                    driver.Navigate().GoToUrl("https://accounts.spotify.com/he-IL/login/?continue=https%3A//open.spotify.com/__noul__%3Fl2l%3D1%26nd%3D1&_locale=he-IL");
                    Actions actions = new Actions(driver);
                    actions.Click(driver.FindElement(By.Id("login-username"))).
                        SendKeys(site.Email + Keys.Tab)
                        .SendKeys(Crip.decrypt(site.Password) + Keys.Enter)
                        .Build().Perform();
                    System.Threading.Thread.Sleep(1000);
                    if (driver.FindElement(By.XPath("/html/body/div[1]/div/div[2]/div/div/div[1]/span")).Text == "שם המשתמש או הסיסמה שגויים.")
                        throw new Exception();
                    else
                    {
                        MessageBox.Show("You have successfully signed in");
                        return;
                    }
                }
                catch
                {
                    MessageBox.Show("Somthing went wrong check the email and password");
                    return;
                }
            }

            //stackoverflow
            if (site.Name == "stackoverflow" || site.Name == "www.stackoverflow" || site.website == "stackoverflow.com")
            {
                try
                {
                    driver.Navigate().GoToUrl("https://stackoverflow.com/users/login?ssrc=head&returnurl=https%3a%2f%2fstackoverflow.com%2f");
                    Actions actions = new Actions(driver);
                    actions.Click(driver.FindElement(By.Id("email"))).
                        SendKeys(site.Email + Keys.Tab)
                        .SendKeys(Crip.decrypt(site.Password) + Keys.Enter)
                        .Build().Perform();
                    System.Threading.Thread.Sleep(1000);
                    if (driver.FindElement(By.XPath("/html/body/div[3]/div[2]/div/div[3]/form/div[1]/p")).Text.Contains("The email or password is incorrect."))
                        throw new Exception();
                    else
                    {
                        MessageBox.Show("You have successfully signed in");
                        return;
                    }
                }
                catch
                {
                    MessageBox.Show("Somthing went wrong check the email and password");
                    return;
                }
            }
            else
            {
                driver.Navigate().GoToUrl("https://" + site.website);
            }

        }

        private void EditPassBtn_Click(object sender, EventArgs e)
        {
            EditPass newForm = new EditPass(user);
            this.Hide();
            newForm.ShowDialog();
            this.Close();

        }

        /*set the driver to the default broswer of the use*/
        private void SetDriver()
        {
            using (RegistryKey userChoiceKey = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\Shell\Associations\UrlAssociations\http\UserChoice"))
            {
                if (userChoiceKey != null)
                {
                    object progIdValue = userChoiceKey.GetValue("Progid");
                    if (progIdValue != null)
                    {
                        if (progIdValue.ToString().ToLower().Contains("chrome"))
                        {
                            var driverService = ChromeDriverService.CreateDefaultService();
                            driverService.HideCommandPromptWindow = true;
                            driver = new ChromeDriver(driverService, new ChromeOptions());
                        }
                        else if (progIdValue.ToString().ToLower().Contains("firefox"))
                        {
                            var driverService = FirefoxDriverService.CreateDefaultService();
                            driverService.HideCommandPromptWindow = true;
                            driver = new FirefoxDriver(driverService, new FirefoxOptions());
                        }
                        else if (progIdValue.ToString().ToLower().Contains("edge"))
                        {
                            var driverService = EdgeDriverService.CreateDefaultService();
                            driverService.HideCommandPromptWindow = true;
                            driver = new EdgeDriver(driverService, new EdgeOptions());
                        }
                        else //Explorer is the default 
                        {
                            var driverService = InternetExplorerDriverService.CreateDefaultService();
                            driverService.HideCommandPromptWindow = true;
                            driver = new InternetExplorerDriver(driverService, new InternetExplorerOptions());
                        }
                    }
                }
            }
        }
    }
}
