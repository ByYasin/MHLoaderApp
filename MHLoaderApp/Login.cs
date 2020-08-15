using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MHLoaderApp
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            Init_Data();
            AutoInıt_Data();
        }

        private void Init_Data()
        {
            if (Properties.Settings.Default.username != string.Empty)
            {
                if (Properties.Settings.Default.password != string.Empty)
                {
                    if (Properties.Settings.Default.remember == true)
                    {
                        {
                            usernametext.Text = Properties.Settings.Default.username;
                            passwordtext.Text = Properties.Settings.Default.password;
                            rememberme.Checked = true;
                        }
                    }
                    else
                    {
                        usernametext.Text = Properties.Settings.Default.username;
                        passwordtext.Text = Properties.Settings.Default.password;
                    }
                }
            }

        }

        private void Save_Data()
        {
            if (rememberme.Checked)
            {
                Properties.Settings.Default.username = usernametext.Text.Trim();
                Properties.Settings.Default.password = passwordtext.Text.Trim();
                Properties.Settings.Default.remember = true;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.username = "";
                Properties.Settings.Default.password = "";
                Properties.Settings.Default.remember = false;
                Properties.Settings.Default.Save();
            }

        }

        private void AutoInıt_Data()
        {
            if (Properties.Settings.Default.autologinsave == true)
            {
                autologin.Checked = true;
            }
            else
            {

            }
        }

        private void  Auto_Save_Data()
        {
            if (autologin.Checked)
            {
                Properties.Settings.Default.autologinsave = true;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.autologinsave = false;
                Properties.Settings.Default.Save();
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

            if (Properties.Settings.Default.autologinsave == true)
            {
                loginbutton.PerformClick();
            }
            else
            {
                
            }

        }

        private void loginbutton_Click(object sender, EventArgs e)
        {
            Save_Data();
            Auto_Save_Data();

            if (usernametext.Text == "" | passwordtext.Text == "")
            {
                MessageBox.Show("Please enter your username and password!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                status.Text = "Please enter your license information!";
            }
            else
            {
                status.Text = "License approved, login successful!";
            }
            if (status.Text == "License approved, login successful!")
            {
                loginbutton.Enabled = false;
                rememberme.Enabled = false;
                autologin.Enabled = false;
                logintimer.Enabled = true;
            }

        }

        private void logintimer_Tick(object sender, EventArgs e)
        {
            //Hide();
            Loader.Loader loaderform = new Loader.Loader();
            loaderform.usertext.Text = usernametext.Text;
            loaderform.Show();
            logintimer.Stop();
            loaderform.status.Text = "HWID has been approved, your subscription is active, your license has been loaded!";
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

    }


}
