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
            themecolor_Data();
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



        private void themecolor_Data()
        {
            if (Properties.Settings.Default.themecolor == "Blue (Default)")
            {
                var faviconbackcolor = ColorTranslator.FromHtml("#0071BC");
                favicon.BackColor = (faviconbackcolor);

                var headerbackcolor = ColorTranslator.FromHtml("#3393DF");
                header.BackColor = (headerbackcolor);

                var footerbackcolor = ColorTranslator.FromHtml("#3393DF");
                footer.BackColor = (footerbackcolor);

                var remembermebackcolor = ColorTranslator.FromHtml("#3393DF");
                rememberme.ToggleStateOn.BackColor = (remembermebackcolor);

                var remembermebordercolor = ColorTranslator.FromHtml("#3393DF");
                rememberme.ToggleStateOn.BorderColor = (remembermebordercolor);

                var autologinbackcolor = ColorTranslator.FromHtml("#3393DF");
                autologin.ToggleStateOn.BackColor = (autologinbackcolor);

                var autologinbordercolor = ColorTranslator.FromHtml("#3393DF");
                autologin.ToggleStateOn.BorderColor = (autologinbordercolor);

                var loginbuttonİdleFillcolor = ColorTranslator.FromHtml("#3393DF");
                loginbutton.IdleFillColor = (loginbuttonİdleFillcolor);

                var loginbuttonOnIdleStateFillColor = ColorTranslator.FromHtml("#3393DF");
                loginbutton.OnIdleState.FillColor = (loginbuttonOnIdleStateFillColor);

                var loginbuttonOnPressedStateFillColor = ColorTranslator.FromHtml("Transparent");
                loginbutton.OnPressedState.FillColor = (loginbuttonOnPressedStateFillColor);

            }

            if (Properties.Settings.Default.themecolor == "Brown")
            {
                var faviconbackcolor = ColorTranslator.FromHtml("#775E41");
                favicon.BackColor = (faviconbackcolor);

                var headerbackcolor = ColorTranslator.FromHtml("#9B7B56");
                header.BackColor = (headerbackcolor);

                var footerbackcolor = ColorTranslator.FromHtml("#9B7B56");
                footer.BackColor = (footerbackcolor);

                var remembermebackcolor = ColorTranslator.FromHtml("#9B7B56");
                rememberme.ToggleStateOn.BackColor = (remembermebackcolor);

                var remembermebordercolor = ColorTranslator.FromHtml("#9B7B56");
                rememberme.ToggleStateOn.BorderColor = (remembermebordercolor);

                var autologinbackcolor = ColorTranslator.FromHtml("#9B7B56");
                autologin.ToggleStateOn.BackColor = (autologinbackcolor);

                var autologinbordercolor = ColorTranslator.FromHtml("#9B7B56");
                autologin.ToggleStateOn.BorderColor = (autologinbordercolor);

                var loginbuttonİdleFillcolor = ColorTranslator.FromHtml("#9B7B56");
                loginbutton.IdleFillColor = (loginbuttonİdleFillcolor);

                var loginbuttonOnIdleStateFillColor = ColorTranslator.FromHtml("#9B7B56");
                loginbutton.OnIdleState.FillColor = (loginbuttonOnIdleStateFillColor);

                var loginbuttonOnPressedStateFillColor = ColorTranslator.FromHtml("Transparent");
                loginbutton.OnPressedState.FillColor = (loginbuttonOnPressedStateFillColor);

            }

            if (Properties.Settings.Default.themecolor == "Cobalt")
            {
                var faviconbackcolor = ColorTranslator.FromHtml("#0071BC");
                favicon.BackColor = (faviconbackcolor);

                var headerbackcolor = ColorTranslator.FromHtml("#3373F2");
                header.BackColor = (headerbackcolor);

                var footerbackcolor = ColorTranslator.FromHtml("#3373F2");
                footer.BackColor = (footerbackcolor);

                var remembermebackcolor = ColorTranslator.FromHtml("#3373F2");
                rememberme.ToggleStateOn.BackColor = (remembermebackcolor);

                var remembermebordercolor = ColorTranslator.FromHtml("#3373F2");
                rememberme.ToggleStateOn.BorderColor = (remembermebordercolor);

                var autologinbackcolor = ColorTranslator.FromHtml("#3373F2");
                autologin.ToggleStateOn.BackColor = (autologinbackcolor);

                var autologinbordercolor = ColorTranslator.FromHtml("#3373F2");
                autologin.ToggleStateOn.BorderColor = (autologinbordercolor);

                var loginbuttonİdleFillcolor = ColorTranslator.FromHtml("#3373F2");
                loginbutton.IdleFillColor = (loginbuttonİdleFillcolor);

                var loginbuttonOnIdleStateFillColor = ColorTranslator.FromHtml("#3373F2");
                loginbutton.OnIdleState.FillColor = (loginbuttonOnIdleStateFillColor);

                var loginbuttonOnPressedStateFillColor = ColorTranslator.FromHtml("Transparent");
                loginbutton.OnPressedState.FillColor = (loginbuttonOnPressedStateFillColor);

            }

            if (Properties.Settings.Default.themecolor == "Crimson")
            {
                var faviconbackcolor = ColorTranslator.FromHtml("#902941");
                favicon.BackColor = (faviconbackcolor);

                var headerbackcolor = ColorTranslator.FromHtml("#B53351");
                header.BackColor = (headerbackcolor);

                var footerbackcolor = ColorTranslator.FromHtml("#B53351");
                footer.BackColor = (footerbackcolor);

                var remembermebackcolor = ColorTranslator.FromHtml("#B53351");
                rememberme.ToggleStateOn.BackColor = (remembermebackcolor);

                var remembermebordercolor = ColorTranslator.FromHtml("#B53351");
                rememberme.ToggleStateOn.BorderColor = (remembermebordercolor);

                var autologinbackcolor = ColorTranslator.FromHtml("#B53351");
                autologin.ToggleStateOn.BackColor = (autologinbackcolor);

                var autologinbordercolor = ColorTranslator.FromHtml("#B53351");
                autologin.ToggleStateOn.BorderColor = (autologinbordercolor);

                var loginbuttonİdleFillcolor = ColorTranslator.FromHtml("#B53351");
                loginbutton.IdleFillColor = (loginbuttonİdleFillcolor);

                var loginbuttonOnIdleStateFillColor = ColorTranslator.FromHtml("#B53351");
                loginbutton.OnIdleState.FillColor = (loginbuttonOnIdleStateFillColor);

                var loginbuttonOnPressedStateFillColor = ColorTranslator.FromHtml("Transparent");
                loginbutton.OnPressedState.FillColor = (loginbuttonOnPressedStateFillColor);

            }

            if (Properties.Settings.Default.themecolor == "Cyan")
            {
                var faviconbackcolor = ColorTranslator.FromHtml("#3A91BC");
                favicon.BackColor = (faviconbackcolor);

                var headerbackcolor = ColorTranslator.FromHtml("#49B4E8");
                header.BackColor = (headerbackcolor);

                var footerbackcolor = ColorTranslator.FromHtml("#49B4E8");
                footer.BackColor = (footerbackcolor);

                var remembermebackcolor = ColorTranslator.FromHtml("#49B4E8");
                rememberme.ToggleStateOn.BackColor = (remembermebackcolor);

                var remembermebordercolor = ColorTranslator.FromHtml("#49B4E8");
                rememberme.ToggleStateOn.BorderColor = (remembermebordercolor);

                var autologinbackcolor = ColorTranslator.FromHtml("#49B4E8");
                autologin.ToggleStateOn.BackColor = (autologinbackcolor);

                var autologinbordercolor = ColorTranslator.FromHtml("#49B4E8");
                autologin.ToggleStateOn.BorderColor = (autologinbordercolor);

                var loginbuttonİdleFillcolor = ColorTranslator.FromHtml("#49B4E8");
                loginbutton.IdleFillColor = (loginbuttonİdleFillcolor);

                var loginbuttonOnIdleStateFillColor = ColorTranslator.FromHtml("#49B4E8");
                loginbutton.OnIdleState.FillColor = (loginbuttonOnIdleStateFillColor);

                var loginbuttonOnPressedStateFillColor = ColorTranslator.FromHtml("Transparent");
                loginbutton.OnPressedState.FillColor = (loginbuttonOnPressedStateFillColor);

            }

            if (Properties.Settings.Default.themecolor == "Dark Gold")
            {
                var faviconbackcolor = ColorTranslator.FromHtml("#A67C00");
                favicon.BackColor = (faviconbackcolor);

                var headerbackcolor = ColorTranslator.FromHtml("#BF9B30");
                header.BackColor = (headerbackcolor);

                var footerbackcolor = ColorTranslator.FromHtml("#BF9B30");
                footer.BackColor = (footerbackcolor);

                var remembermebackcolor = ColorTranslator.FromHtml("#BF9B30");
                rememberme.ToggleStateOn.BackColor = (remembermebackcolor);

                var remembermebordercolor = ColorTranslator.FromHtml("#BF9B30");
                rememberme.ToggleStateOn.BorderColor = (remembermebordercolor);

                var autologinbackcolor = ColorTranslator.FromHtml("#BF9B30");
                autologin.ToggleStateOn.BackColor = (autologinbackcolor);

                var autologinbordercolor = ColorTranslator.FromHtml("#BF9B30");
                autologin.ToggleStateOn.BorderColor = (autologinbordercolor);

                var loginbuttonİdleFillcolor = ColorTranslator.FromHtml("#BF9B30");
                loginbutton.IdleFillColor = (loginbuttonİdleFillcolor);

                var loginbuttonOnIdleStateFillColor = ColorTranslator.FromHtml("#BF9B30");
                loginbutton.OnIdleState.FillColor = (loginbuttonOnIdleStateFillColor);

                var loginbuttonOnPressedStateFillColor = ColorTranslator.FromHtml("Transparent");
                loginbutton.OnPressedState.FillColor = (loginbuttonOnPressedStateFillColor);

            }

            if (Properties.Settings.Default.themecolor == "Dark Red")
            {
                var faviconbackcolor = ColorTranslator.FromHtml("#920D00");
                favicon.BackColor = (faviconbackcolor);

                var headerbackcolor = ColorTranslator.FromHtml("#AF1001");
                header.BackColor = (headerbackcolor);

                var footerbackcolor = ColorTranslator.FromHtml("#AF1001");
                footer.BackColor = (footerbackcolor);

                var remembermebackcolor = ColorTranslator.FromHtml("#AF1001");
                rememberme.ToggleStateOn.BackColor = (remembermebackcolor);

                var remembermebordercolor = ColorTranslator.FromHtml("#AF1001");
                rememberme.ToggleStateOn.BorderColor = (remembermebordercolor);

                var autologinbackcolor = ColorTranslator.FromHtml("#AF1001");
                autologin.ToggleStateOn.BackColor = (autologinbackcolor);

                var autologinbordercolor = ColorTranslator.FromHtml("#AF1001");
                autologin.ToggleStateOn.BorderColor = (autologinbordercolor);

                var loginbuttonİdleFillcolor = ColorTranslator.FromHtml("#AF1001");
                loginbutton.IdleFillColor = (loginbuttonİdleFillcolor);

                var loginbuttonOnIdleStateFillColor = ColorTranslator.FromHtml("#AF1001");
                loginbutton.OnIdleState.FillColor = (loginbuttonOnIdleStateFillColor);

                var loginbuttonOnPressedStateFillColor = ColorTranslator.FromHtml("Transparent");
                loginbutton.OnPressedState.FillColor = (loginbuttonOnPressedStateFillColor);

            }

            if (Properties.Settings.Default.themecolor == "Emerald")
            {
                var faviconbackcolor = ColorTranslator.FromHtml("#267826");
                favicon.BackColor = (faviconbackcolor);

                var headerbackcolor = ColorTranslator.FromHtml("#33A133");
                header.BackColor = (headerbackcolor);

                var footerbackcolor = ColorTranslator.FromHtml("#33A133");
                footer.BackColor = (footerbackcolor);

                var remembermebackcolor = ColorTranslator.FromHtml("#33A133");
                rememberme.ToggleStateOn.BackColor = (remembermebackcolor);

                var remembermebordercolor = ColorTranslator.FromHtml("#33A133");
                rememberme.ToggleStateOn.BorderColor = (remembermebordercolor);

                var autologinbackcolor = ColorTranslator.FromHtml("#33A133");
                autologin.ToggleStateOn.BackColor = (autologinbackcolor);

                var autologinbordercolor = ColorTranslator.FromHtml("#33A133");
                autologin.ToggleStateOn.BorderColor = (autologinbordercolor);

                var loginbuttonİdleFillcolor = ColorTranslator.FromHtml("#33A133");
                loginbutton.IdleFillColor = (loginbuttonİdleFillcolor);

                var loginbuttonOnIdleStateFillColor = ColorTranslator.FromHtml("#33A133");
                loginbutton.OnIdleState.FillColor = (loginbuttonOnIdleStateFillColor);

                var loginbuttonOnPressedStateFillColor = ColorTranslator.FromHtml("Transparent");
                loginbutton.OnPressedState.FillColor = (loginbuttonOnPressedStateFillColor);

            }

            if (Properties.Settings.Default.themecolor == "Green")
            {
                var faviconbackcolor = ColorTranslator.FromHtml("#608C33");
                favicon.BackColor = (faviconbackcolor);

                var headerbackcolor = ColorTranslator.FromHtml("#80BA45");
                header.BackColor = (headerbackcolor);

                var footerbackcolor = ColorTranslator.FromHtml("#80BA45");
                footer.BackColor = (footerbackcolor);

                var remembermebackcolor = ColorTranslator.FromHtml("#80BA45");
                rememberme.ToggleStateOn.BackColor = (remembermebackcolor);

                var remembermebordercolor = ColorTranslator.FromHtml("#80BA45");
                rememberme.ToggleStateOn.BorderColor = (remembermebordercolor);

                var autologinbackcolor = ColorTranslator.FromHtml("#80BA45");
                autologin.ToggleStateOn.BackColor = (autologinbackcolor);

                var autologinbordercolor = ColorTranslator.FromHtml("#80BA45");
                autologin.ToggleStateOn.BorderColor = (autologinbordercolor);

                var loginbuttonİdleFillcolor = ColorTranslator.FromHtml("#80BA45");
                loginbutton.IdleFillColor = (loginbuttonİdleFillcolor);

                var loginbuttonOnIdleStateFillColor = ColorTranslator.FromHtml("#80BA45");
                loginbutton.OnIdleState.FillColor = (loginbuttonOnIdleStateFillColor);

                var loginbuttonOnPressedStateFillColor = ColorTranslator.FromHtml("Transparent");
                loginbutton.OnPressedState.FillColor = (loginbuttonOnPressedStateFillColor);

            }

            if (Properties.Settings.Default.themecolor == "Indigo")
            {
                var faviconbackcolor = ColorTranslator.FromHtml("#6926C6");
                favicon.BackColor = (faviconbackcolor);

                var headerbackcolor = ColorTranslator.FromHtml("#8833FF");
                header.BackColor = (headerbackcolor);

                var footerbackcolor = ColorTranslator.FromHtml("#8833FF");
                footer.BackColor = (footerbackcolor);

                var remembermebackcolor = ColorTranslator.FromHtml("#8833FF");
                rememberme.ToggleStateOn.BackColor = (remembermebackcolor);

                var remembermebordercolor = ColorTranslator.FromHtml("#8833FF");
                rememberme.ToggleStateOn.BorderColor = (remembermebordercolor);

                var autologinbackcolor = ColorTranslator.FromHtml("#8833FF");
                autologin.ToggleStateOn.BackColor = (autologinbackcolor);

                var autologinbordercolor = ColorTranslator.FromHtml("#8833FF");
                autologin.ToggleStateOn.BorderColor = (autologinbordercolor);

                var loginbuttonİdleFillcolor = ColorTranslator.FromHtml("#8833FF");
                loginbutton.IdleFillColor = (loginbuttonİdleFillcolor);

                var loginbuttonOnIdleStateFillColor = ColorTranslator.FromHtml("#8833FF");
                loginbutton.OnIdleState.FillColor = (loginbuttonOnIdleStateFillColor);

                var loginbuttonOnPressedStateFillColor = ColorTranslator.FromHtml("Transparent");
                loginbutton.OnPressedState.FillColor = (loginbuttonOnPressedStateFillColor);

            }

            if (Properties.Settings.Default.themecolor == "Magenta")
            {
                var faviconbackcolor = ColorTranslator.FromHtml("#AF276F");
                favicon.BackColor = (faviconbackcolor);

                var headerbackcolor = ColorTranslator.FromHtml("#E0338F");
                header.BackColor = (headerbackcolor);

                var footerbackcolor = ColorTranslator.FromHtml("#E0338F");
                footer.BackColor = (footerbackcolor);

                var remembermebackcolor = ColorTranslator.FromHtml("#E0338F");
                rememberme.ToggleStateOn.BackColor = (remembermebackcolor);

                var remembermebordercolor = ColorTranslator.FromHtml("#E0338F");
                rememberme.ToggleStateOn.BorderColor = (remembermebordercolor);

                var autologinbackcolor = ColorTranslator.FromHtml("#E0338F");
                autologin.ToggleStateOn.BackColor = (autologinbackcolor);

                var autologinbordercolor = ColorTranslator.FromHtml("#E0338F");
                autologin.ToggleStateOn.BorderColor = (autologinbordercolor);

                var loginbuttonİdleFillcolor = ColorTranslator.FromHtml("#E0338F");
                loginbutton.IdleFillColor = (loginbuttonİdleFillcolor);

                var loginbuttonOnIdleStateFillColor = ColorTranslator.FromHtml("#E0338F");
                loginbutton.OnIdleState.FillColor = (loginbuttonOnIdleStateFillColor);

                var loginbuttonOnPressedStateFillColor = ColorTranslator.FromHtml("Transparent");
                loginbutton.OnPressedState.FillColor = (loginbuttonOnPressedStateFillColor);

            }

            if (Properties.Settings.Default.themecolor == "Mauve")
            {
                var faviconbackcolor = ColorTranslator.FromHtml("#6B5E77");
                favicon.BackColor = (faviconbackcolor);

                var headerbackcolor = ColorTranslator.FromHtml("#9180A1");
                header.BackColor = (headerbackcolor);

                var footerbackcolor = ColorTranslator.FromHtml("#9180A1");
                footer.BackColor = (footerbackcolor);

                var remembermebackcolor = ColorTranslator.FromHtml("#9180A1");
                rememberme.ToggleStateOn.BackColor = (remembermebackcolor);

                var remembermebordercolor = ColorTranslator.FromHtml("#9180A1");
                rememberme.ToggleStateOn.BorderColor = (remembermebordercolor);

                var autologinbackcolor = ColorTranslator.FromHtml("#9180A1");
                autologin.ToggleStateOn.BackColor = (autologinbackcolor);

                var autologinbordercolor = ColorTranslator.FromHtml("#9180A1");
                autologin.ToggleStateOn.BorderColor = (autologinbordercolor);

                var loginbuttonİdleFillcolor = ColorTranslator.FromHtml("#9180A1");
                loginbutton.IdleFillColor = (loginbuttonİdleFillcolor);

                var loginbuttonOnIdleStateFillColor = ColorTranslator.FromHtml("#9180A1");
                loginbutton.OnIdleState.FillColor = (loginbuttonOnIdleStateFillColor);

                var loginbuttonOnPressedStateFillColor = ColorTranslator.FromHtml("Transparent");
                loginbutton.OnPressedState.FillColor = (loginbuttonOnPressedStateFillColor);

            }

            if (Properties.Settings.Default.themecolor == "Orange")
            {
                var faviconbackcolor = ColorTranslator.FromHtml("#C46826");
                favicon.BackColor = (faviconbackcolor);

                var headerbackcolor = ColorTranslator.FromHtml("#FB8633");
                header.BackColor = (headerbackcolor);

                var footerbackcolor = ColorTranslator.FromHtml("#FB8633");
                footer.BackColor = (footerbackcolor);

                var remembermebackcolor = ColorTranslator.FromHtml("#FB8633");
                rememberme.ToggleStateOn.BackColor = (remembermebackcolor);

                var remembermebordercolor = ColorTranslator.FromHtml("#FB8633");
                rememberme.ToggleStateOn.BorderColor = (remembermebordercolor);

                var autologinbackcolor = ColorTranslator.FromHtml("#FB8633");
                autologin.ToggleStateOn.BackColor = (autologinbackcolor);

                var autologinbordercolor = ColorTranslator.FromHtml("#FB8633");
                autologin.ToggleStateOn.BorderColor = (autologinbordercolor);

                var loginbuttonİdleFillcolor = ColorTranslator.FromHtml("#FB8633");
                loginbutton.IdleFillColor = (loginbuttonİdleFillcolor);

                var loginbuttonOnIdleStateFillColor = ColorTranslator.FromHtml("#FB8633");
                loginbutton.OnIdleState.FillColor = (loginbuttonOnIdleStateFillColor);

                var loginbuttonOnPressedStateFillColor = ColorTranslator.FromHtml("Transparent");
                loginbutton.OnPressedState.FillColor = (loginbuttonOnPressedStateFillColor);

            }

            if (Properties.Settings.Default.themecolor == "Pink")
            {
                var faviconbackcolor = ColorTranslator.FromHtml("#C671AE");
                favicon.BackColor = (faviconbackcolor);

                var headerbackcolor = ColorTranslator.FromHtml("#F68ED9");
                header.BackColor = (headerbackcolor);

                var footerbackcolor = ColorTranslator.FromHtml("#F68ED9");
                footer.BackColor = (footerbackcolor);

                var remembermebackcolor = ColorTranslator.FromHtml("#F68ED9");
                rememberme.ToggleStateOn.BackColor = (remembermebackcolor);

                var remembermebordercolor = ColorTranslator.FromHtml("#F68ED9");
                rememberme.ToggleStateOn.BorderColor = (remembermebordercolor);

                var autologinbackcolor = ColorTranslator.FromHtml("#F68ED9");
                autologin.ToggleStateOn.BackColor = (autologinbackcolor);

                var autologinbordercolor = ColorTranslator.FromHtml("#F68ED9");
                autologin.ToggleStateOn.BorderColor = (autologinbordercolor);

                var loginbuttonİdleFillcolor = ColorTranslator.FromHtml("#F68ED9");
                loginbutton.IdleFillColor = (loginbuttonİdleFillcolor);

                var loginbuttonOnIdleStateFillColor = ColorTranslator.FromHtml("#F68ED9");
                loginbutton.OnIdleState.FillColor = (loginbuttonOnIdleStateFillColor);

                var loginbuttonOnPressedStateFillColor = ColorTranslator.FromHtml("Transparent");
                loginbutton.OnPressedState.FillColor = (loginbuttonOnPressedStateFillColor);

            }

            if (Properties.Settings.Default.themecolor == "Purple")
            {
                var faviconbackcolor = ColorTranslator.FromHtml("#665FB4");
                favicon.BackColor = (faviconbackcolor);

                var headerbackcolor = ColorTranslator.FromHtml("#837AE5");
                header.BackColor = (headerbackcolor);

                var footerbackcolor = ColorTranslator.FromHtml("#837AE5");
                footer.BackColor = (footerbackcolor);

                var remembermebackcolor = ColorTranslator.FromHtml("#837AE5");
                rememberme.ToggleStateOn.BackColor = (remembermebackcolor);

                var remembermebordercolor = ColorTranslator.FromHtml("#837AE5");
                rememberme.ToggleStateOn.BorderColor = (remembermebordercolor);

                var autologinbackcolor = ColorTranslator.FromHtml("#837AE5");
                autologin.ToggleStateOn.BackColor = (autologinbackcolor);

                var autologinbordercolor = ColorTranslator.FromHtml("#837AE5");
                autologin.ToggleStateOn.BorderColor = (autologinbordercolor);

                var loginbuttonİdleFillcolor = ColorTranslator.FromHtml("#837AE5");
                loginbutton.IdleFillColor = (loginbuttonİdleFillcolor);

                var loginbuttonOnIdleStateFillColor = ColorTranslator.FromHtml("#837AE5");
                loginbutton.OnIdleState.FillColor = (loginbuttonOnIdleStateFillColor);

                var loginbuttonOnPressedStateFillColor = ColorTranslator.FromHtml("Transparent");
                loginbutton.OnPressedState.FillColor = (loginbuttonOnPressedStateFillColor);

            }

            if (Properties.Settings.Default.themecolor == "Red")
            {
                var faviconbackcolor = ColorTranslator.FromHtml("#BF3528");
                favicon.BackColor = (faviconbackcolor);

                var headerbackcolor = ColorTranslator.FromHtml("#EA4333");
                header.BackColor = (headerbackcolor);

                var footerbackcolor = ColorTranslator.FromHtml("#EA4333");
                footer.BackColor = (footerbackcolor);

                var remembermebackcolor = ColorTranslator.FromHtml("#EA4333");
                rememberme.ToggleStateOn.BackColor = (remembermebackcolor);

                var remembermebordercolor = ColorTranslator.FromHtml("#EA4333");
                rememberme.ToggleStateOn.BorderColor = (remembermebordercolor);

                var autologinbackcolor = ColorTranslator.FromHtml("#EA4333");
                autologin.ToggleStateOn.BackColor = (autologinbackcolor);

                var autologinbordercolor = ColorTranslator.FromHtml("#EA4333");
                autologin.ToggleStateOn.BorderColor = (autologinbordercolor);

                var loginbuttonİdleFillcolor = ColorTranslator.FromHtml("#EA4333");
                loginbutton.IdleFillColor = (loginbuttonİdleFillcolor);

                var loginbuttonOnIdleStateFillColor = ColorTranslator.FromHtml("#EA4333");
                loginbutton.OnIdleState.FillColor = (loginbuttonOnIdleStateFillColor);

                var loginbuttonOnPressedStateFillColor = ColorTranslator.FromHtml("Transparent");
                loginbutton.OnPressedState.FillColor = (loginbuttonOnPressedStateFillColor);

            }

            if (Properties.Settings.Default.themecolor == "Sienna")
            {
                var faviconbackcolor = ColorTranslator.FromHtml("#865740");
                favicon.BackColor = (faviconbackcolor);

                var headerbackcolor = ColorTranslator.FromHtml("#B37557");
                header.BackColor = (headerbackcolor);

                var footerbackcolor = ColorTranslator.FromHtml("#B37557");
                footer.BackColor = (footerbackcolor);

                var remembermebackcolor = ColorTranslator.FromHtml("#B37557");
                rememberme.ToggleStateOn.BackColor = (remembermebackcolor);

                var remembermebordercolor = ColorTranslator.FromHtml("#B37557");
                rememberme.ToggleStateOn.BorderColor = (remembermebordercolor);

                var autologinbackcolor = ColorTranslator.FromHtml("#B37557");
                autologin.ToggleStateOn.BackColor = (autologinbackcolor);

                var autologinbordercolor = ColorTranslator.FromHtml("#B37557");
                autologin.ToggleStateOn.BorderColor = (autologinbordercolor);

                var loginbuttonİdleFillcolor = ColorTranslator.FromHtml("#B37557");
                loginbutton.IdleFillColor = (loginbuttonİdleFillcolor);

                var loginbuttonOnIdleStateFillColor = ColorTranslator.FromHtml("#B37557");
                loginbutton.OnIdleState.FillColor = (loginbuttonOnIdleStateFillColor);

                var loginbuttonOnPressedStateFillColor = ColorTranslator.FromHtml("Transparent");
                loginbutton.OnPressedState.FillColor = (loginbuttonOnPressedStateFillColor);

            }

            if (Properties.Settings.Default.themecolor == "Steel")
            {
                var faviconbackcolor = ColorTranslator.FromHtml("#5A646E");
                favicon.BackColor = (faviconbackcolor);

                var headerbackcolor = ColorTranslator.FromHtml("#83919F");
                header.BackColor = (headerbackcolor);

                var footerbackcolor = ColorTranslator.FromHtml("#83919F");
                footer.BackColor = (footerbackcolor);

                var remembermebackcolor = ColorTranslator.FromHtml("#83919F");
                rememberme.ToggleStateOn.BackColor = (remembermebackcolor);

                var remembermebordercolor = ColorTranslator.FromHtml("#83919F");
                rememberme.ToggleStateOn.BorderColor = (remembermebordercolor);

                var autologinbackcolor = ColorTranslator.FromHtml("#83919F");
                autologin.ToggleStateOn.BackColor = (autologinbackcolor);

                var autologinbordercolor = ColorTranslator.FromHtml("#83919F");
                autologin.ToggleStateOn.BorderColor = (autologinbordercolor);

                var loginbuttonİdleFillcolor = ColorTranslator.FromHtml("#83919F");
                loginbutton.IdleFillColor = (loginbuttonİdleFillcolor);

                var loginbuttonOnIdleStateFillColor = ColorTranslator.FromHtml("#83919F");
                loginbutton.OnIdleState.FillColor = (loginbuttonOnIdleStateFillColor);

                var loginbuttonOnPressedStateFillColor = ColorTranslator.FromHtml("Transparent");
                loginbutton.OnPressedState.FillColor = (loginbuttonOnPressedStateFillColor);

            }

            if (Properties.Settings.Default.themecolor == "Taupe")
            {
                var faviconbackcolor = ColorTranslator.FromHtml("#6B644C");
                favicon.BackColor = (faviconbackcolor);

                var headerbackcolor = ColorTranslator.FromHtml("#9F9471");
                header.BackColor = (headerbackcolor);

                var footerbackcolor = ColorTranslator.FromHtml("#9F9471");
                footer.BackColor = (footerbackcolor);

                var remembermebackcolor = ColorTranslator.FromHtml("#9F9471");
                rememberme.ToggleStateOn.BackColor = (remembermebackcolor);

                var remembermebordercolor = ColorTranslator.FromHtml("#9F9471");
                rememberme.ToggleStateOn.BorderColor = (remembermebordercolor);

                var autologinbackcolor = ColorTranslator.FromHtml("#9F9471");
                autologin.ToggleStateOn.BackColor = (autologinbackcolor);

                var autologinbordercolor = ColorTranslator.FromHtml("#9F9471");
                autologin.ToggleStateOn.BorderColor = (autologinbordercolor);

                var loginbuttonİdleFillcolor = ColorTranslator.FromHtml("#9F9471");
                loginbutton.IdleFillColor = (loginbuttonİdleFillcolor);

                var loginbuttonOnIdleStateFillColor = ColorTranslator.FromHtml("#9F9471");
                loginbutton.OnIdleState.FillColor = (loginbuttonOnIdleStateFillColor);

                var loginbuttonOnPressedStateFillColor = ColorTranslator.FromHtml("Transparent");
                loginbutton.OnPressedState.FillColor = (loginbuttonOnPressedStateFillColor);

            }

            if (Properties.Settings.Default.themecolor == "Teal")
            {
                var faviconbackcolor = ColorTranslator.FromHtml("#248988");
                favicon.BackColor = (faviconbackcolor);

                var headerbackcolor = ColorTranslator.FromHtml("#33BCBA");
                header.BackColor = (headerbackcolor);

                var footerbackcolor = ColorTranslator.FromHtml("#33BCBA");
                footer.BackColor = (footerbackcolor);

                var remembermebackcolor = ColorTranslator.FromHtml("#33BCBA");
                rememberme.ToggleStateOn.BackColor = (remembermebackcolor);

                var remembermebordercolor = ColorTranslator.FromHtml("#33BCBA");
                rememberme.ToggleStateOn.BorderColor = (remembermebordercolor);

                var autologinbackcolor = ColorTranslator.FromHtml("#33BCBA");
                autologin.ToggleStateOn.BackColor = (autologinbackcolor);

                var autologinbordercolor = ColorTranslator.FromHtml("#33BCBA");
                autologin.ToggleStateOn.BorderColor = (autologinbordercolor);

                var loginbuttonİdleFillcolor = ColorTranslator.FromHtml("#33BCBA");
                loginbutton.IdleFillColor = (loginbuttonİdleFillcolor);

                var loginbuttonOnIdleStateFillColor = ColorTranslator.FromHtml("#33BCBA");
                loginbutton.OnIdleState.FillColor = (loginbuttonOnIdleStateFillColor);

                var loginbuttonOnPressedStateFillColor = ColorTranslator.FromHtml("Transparent");
                loginbutton.OnPressedState.FillColor = (loginbuttonOnPressedStateFillColor);

            }

        }


        private void Login_Load(object sender, EventArgs e)
        {
            themecolor_Data();
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
            Hide();
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
