using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace Operators
{
    public partial class Operator_Login : Form
    {
        public Operator_Login()
        {
            InitializeComponent();
        }

        private void OperatorUserNameTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void OperatorPasswordTextbox_TextChanged(object sender, EventArgs e)
        {
            OperatorPasswordTextbox.PasswordChar = '\u25CF';
        }

        private void backgroundWorker1_DoWork2a(object sender, RunWorkerCompletedEventArgs e)
        {
            //MessageBox.Show("Completed2");
            this.Hide();
            TabMain tab = new TabMain();
            tab.ShowDialog();
        }

        private void backgroundWorker1_DoWork1a(object sender, DoWorkEventArgs e)
        {
            //localhost.Service1 cservice = new localhost.Service1();
            //MessageBox.Show("Processing");
        }

        private void Operator_Login_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.MinimizeBox = false;
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            if (Properties.Settings.Default.RememberPass)
            {
                OperatorUserNameTextbox.Text = Properties.Settings.Default.UserName;
                OperatorPasswordTextbox.Text = Properties.Settings.Default.Password;
                Remember.Checked = true;
            }
            if (Properties.Settings.Default.AutoLogin)
            {
                OperatorUserNameTextbox.Text = Properties.Settings.Default.UserName;
                OperatorPasswordTextbox.Text = Properties.Settings.Default.Password;
                AutoLogin.Checked = true;
                OperatorLogin.PerformClick();
            }
            this.FormClosing += Form1_FormClosing;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            string user = OperatorUserNameTextbox.Text;
            string pass1 = OperatorPasswordTextbox.Text;
            if (Remember.Checked && !string.IsNullOrWhiteSpace(user) && !string.IsNullOrWhiteSpace(pass1))
            {
                Properties.Settings.Default.RememberPass = true;
                Properties.Settings.Default.UserName = OperatorUserNameTextbox.Text;
                Properties.Settings.Default.Password = OperatorPasswordTextbox.Text;
                Properties.Settings.Default.Save();
            }

            if (AutoLogin.Checked && !string.IsNullOrWhiteSpace(user) && !string.IsNullOrWhiteSpace(pass1))
            {
                Properties.Settings.Default.AutoLogin = true;
                Properties.Settings.Default.UserName = OperatorUserNameTextbox.Text;
                Properties.Settings.Default.Password = OperatorPasswordTextbox.Text;
                Properties.Settings.Default.Save();
            }
        }

        private void OperatorLogin_Click_1(object sender, EventArgs e)
        {
            string user = OperatorUserNameTextbox.Text;
            string pass1 = OperatorPasswordTextbox.Text;
            MD5 md5 = new MD5();
            string pass = md5.CalculateMD5Hash(pass1);
            if (string.IsNullOrWhiteSpace(user))
            {
                MessageBox.Show("UserName is empty");
            }
            else if (string.IsNullOrWhiteSpace(pass1))
            {
                MessageBox.Show("Password is empty");
            }
            else
            {
                try
                {
                    localhost.Service1 service = new localhost.Service1();
                    //FormProperties formprop = new FormProperties();
                    string operatorName = service.OperatorLogin(user, pass);
                    string[] tempArray = service.GetDomains();
                    string[] tempClients = service.GetClientsPerGroup(1);
                    FormProperties.OperatorName = operatorName;
                    FormProperties.GroupCount = tempArray.Length;
                    FormProperties.InitialDomain = tempArray;
                    FormProperties.InitialUsers = tempClients;
                    if (operatorName != "")
                    {
                        BackgroundWorker bwrk = new BackgroundWorker();
                        bwrk.DoWork += backgroundWorker1_DoWork1a;
                        bwrk.RunWorkerCompleted += backgroundWorker1_DoWork2a;
                        bwrk.RunWorkerAsync();

                    }
                    else
                    {
                        MessageBox.Show("Error in Connecting Database");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error in Connecting Database");
                }
            }
        }
    }
}
