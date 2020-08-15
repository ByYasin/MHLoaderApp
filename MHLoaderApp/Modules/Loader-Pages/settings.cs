using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MHLoaderApp.Modules.Loader_Pages
{
    public partial class settings : UserControl
    {
        public settings()
        {
            InitializeComponent();
            Init_Data();
            AutoInıt_Data();
        }

        private void Init_Data()
        {
            if (Properties.Settings.Default.remember == true)
            {
                {
                    rememberme.Checked = true;
                }
            }
            else
            {

            }

        }

        private void Save_Data()
        {
            if (rememberme.Checked)
            {
                Properties.Settings.Default.remember = true;
                Properties.Settings.Default.Save();
            }
            else
            {
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

        private void Auto_Save_Data()
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

        public void SaveSettings()
        {
            Properties.Settings.Default.Save();
            Properties.Settings.Default.Reload();
        }


        private void settings_Load(object sender, EventArgs e)
        {

        }

        private void rememberme_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs e)
        {
            Save_Data();
        }

        private void autologin_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs e)
        {
            Auto_Save_Data();
        }

        private void bluecolor_Click(object sender, EventArgs e)
        {

            if (comboBox1.SelectedItem == "Blue")
            {
                Properties.Settings.Default.Theme = "Blue";
            }

            if (comboBox1.SelectedItem == "Brown")
            {
                Properties.Settings.Default.Theme = "Brown";
            }
            SaveSettings();
            //GetSettings();
        }

        private void timer1_Tick(object sender, EventArgs e) // Timer Loader formunu bozuyor başka yöntem bul !
        {
            if (Properties.Settings.Default.Theme == "Blue")
            {
                Login loginfrm = new Login();
                var faviconbackcolor = ColorTranslator.FromHtml("#0071BC");
                loginfrm.favicon.BackColor = (faviconbackcolor);
                var headerbackcolor = ColorTranslator.FromHtml("#3393DF");
                loginfrm.header.BackColor = (headerbackcolor);
                var footerbackcolor = ColorTranslator.FromHtml("#3393DF");
                loginfrm.footer.BackColor = (footerbackcolor);
                var remembermebackcolor = ColorTranslator.FromHtml("#3393DF");
                loginfrm.rememberme.ToggleStateOn.BackColor = (remembermebackcolor);
                var remembermebordercolor = ColorTranslator.FromHtml("#3393DF");
                loginfrm.rememberme.ToggleStateOn.BorderColor = (remembermebordercolor);
                var autologinbackcolor = ColorTranslator.FromHtml("#3393DF");
                loginfrm.autologin.ToggleStateOn.BackColor = (autologinbackcolor);
                var autologinbordercolor = ColorTranslator.FromHtml("#3393DF");
                loginfrm.autologin.ToggleStateOn.BackColor = (autologinbordercolor);
                var loginbuttonİdleFillcolor = ColorTranslator.FromHtml("#3393DF");
                loginfrm.loginbutton.IdleFillColor = (loginbuttonİdleFillcolor);

            }

            if (Properties.Settings.Default.Theme == "Brown")
            {
                Login loginfrm = new Login();
                var faviconbackcolor = ColorTranslator.FromHtml("#775E41");
                loginfrm.favicon.BackColor = (faviconbackcolor);

                var headerbackcolor = ColorTranslator.FromHtml("#9B7B56");
                loginfrm.header.BackColor = (headerbackcolor);

                var footerbackcolor = ColorTranslator.FromHtml("#9B7B56");
                loginfrm.footer.BackColor = (footerbackcolor);

                var remembermebackcolor = ColorTranslator.FromHtml("#9B7B56");
                loginfrm.rememberme.ToggleStateOn.BackColor = (remembermebackcolor);

                var remembermebordercolor = ColorTranslator.FromHtml("#9B7B56");
                loginfrm.rememberme.ToggleStateOn.BorderColor = (remembermebordercolor);

                var autologinbackcolor = ColorTranslator.FromHtml("#9B7B56");
                loginfrm.autologin.ToggleStateOn.BackColor = (autologinbackcolor);

                var autologinbordercolor = ColorTranslator.FromHtml("#9B7B56");
                loginfrm.autologin.ToggleStateOn.BorderColor = (autologinbordercolor);

                var loginbuttonİdleFillcolor = ColorTranslator.FromHtml("#9B7B56");
                loginfrm.loginbutton.IdleFillColor = (loginbuttonİdleFillcolor);

                var loginbuttonOnPressedStateFillColor = ColorTranslator.FromHtml("#9B7B56");
                loginfrm.loginbutton.OnPressedState.FillColor = (loginbuttonOnPressedStateFillColor);

            }
        }
    }


}
