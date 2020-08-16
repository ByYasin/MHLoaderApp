using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MHLoaderApp.Loader
{
    public partial class Loader : Form
    {
        public Loader()
        {
            InitializeComponent();
            themecolor_Data();
        }

        private void Loader_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
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

                var leftcolor1backcolor = ColorTranslator.FromHtml("#3393DF");
                leftcolor1.BackColor = (leftcolor1backcolor);

                var leftcolor2backcolor = ColorTranslator.FromHtml("#3393DF");
                leftcolor2.BackColor = (leftcolor2backcolor);

                var leftcolor3backcolor = ColorTranslator.FromHtml("#3393DF");
                leftcolor3.BackColor = (leftcolor3backcolor);

                var leftcolor4backcolor = ColorTranslator.FromHtml("#3393DF");
                leftcolor4.BackColor = (leftcolor4backcolor);

                var leftcolor5backcolor = ColorTranslator.FromHtml("#3393DF");
                leftcolor5.BackColor = (leftcolor5backcolor);

                var buyrenewbackcolor = ColorTranslator.FromHtml("#3393DF");
                buyrenew.BackColor = (buyrenewbackcolor);

                var licencebuyrenewcolorbackcolor = ColorTranslator.FromHtml("#3393DF");
                licencebuyrenewcolor.BackColor = (licencebuyrenewcolorbackcolor);

                var mylicencecolorbackcolor = ColorTranslator.FromHtml("#3393DF");
                mylicencecolor.BackColor = (mylicencecolorbackcolor);

                var avatarbackcolor = ColorTranslator.FromHtml("#3393DF");
                avatar.BackColor = (avatarbackcolor);
            }

            if (Properties.Settings.Default.themecolor == "Brown")
            {
                var faviconbackcolor = ColorTranslator.FromHtml("#775E41");
                favicon.BackColor = (faviconbackcolor);

                var headerbackcolor = ColorTranslator.FromHtml("#9B7B56");
                header.BackColor = (headerbackcolor);

                var footerbackcolor = ColorTranslator.FromHtml("#9B7B56");
                footer.BackColor = (footerbackcolor);

                var leftcolor1backcolor = ColorTranslator.FromHtml("#9B7B56");
                leftcolor1.BackColor = (leftcolor1backcolor);

                var leftcolor2backcolor = ColorTranslator.FromHtml("#9B7B56");
                leftcolor2.BackColor = (leftcolor2backcolor);

                var leftcolor3backcolor = ColorTranslator.FromHtml("#9B7B56");
                leftcolor3.BackColor = (leftcolor3backcolor);

                var leftcolor4backcolor = ColorTranslator.FromHtml("#9B7B56");
                leftcolor4.BackColor = (leftcolor4backcolor);

                var leftcolor5backcolor = ColorTranslator.FromHtml("#9B7B56");
                leftcolor5.BackColor = (leftcolor5backcolor);

                var buyrenewbackcolor = ColorTranslator.FromHtml("#9B7B56");
                buyrenew.BackColor = (buyrenewbackcolor);

                var licencebuyrenewcolorbackcolor = ColorTranslator.FromHtml("#9B7B56");
                licencebuyrenewcolor.BackColor = (licencebuyrenewcolorbackcolor);

                var mylicencecolorbackcolor = ColorTranslator.FromHtml("#9B7B56");
                mylicencecolor.BackColor = (mylicencecolorbackcolor);

                var avatarbackcolor = ColorTranslator.FromHtml("#9B7B56");
                avatar.BackColor = (avatarbackcolor);
            }

            if (Properties.Settings.Default.themecolor == "Cobalt")
            {
                var faviconbackcolor = ColorTranslator.FromHtml("#0071BC");
                favicon.BackColor = (faviconbackcolor);

                var headerbackcolor = ColorTranslator.FromHtml("#3373F2");
                header.BackColor = (headerbackcolor);

                var footerbackcolor = ColorTranslator.FromHtml("#3373F2");
                footer.BackColor = (footerbackcolor);

                var leftcolor1backcolor = ColorTranslator.FromHtml("#3373F2");
                leftcolor1.BackColor = (leftcolor1backcolor);

                var leftcolor2backcolor = ColorTranslator.FromHtml("#3373F2");
                leftcolor2.BackColor = (leftcolor2backcolor);

                var leftcolor3backcolor = ColorTranslator.FromHtml("#3373F2");
                leftcolor3.BackColor = (leftcolor3backcolor);

                var leftcolor4backcolor = ColorTranslator.FromHtml("#3373F2");
                leftcolor4.BackColor = (leftcolor4backcolor);

                var leftcolor5backcolor = ColorTranslator.FromHtml("#3373F2");
                leftcolor5.BackColor = (leftcolor5backcolor);

                var buyrenewbackcolor = ColorTranslator.FromHtml("#3373F2");
                buyrenew.BackColor = (buyrenewbackcolor);

                var licencebuyrenewcolorbackcolor = ColorTranslator.FromHtml("#3373F2");
                licencebuyrenewcolor.BackColor = (licencebuyrenewcolorbackcolor);

                var mylicencecolorbackcolor = ColorTranslator.FromHtml("#3373F2");
                mylicencecolor.BackColor = (mylicencecolorbackcolor);

                var avatarbackcolor = ColorTranslator.FromHtml("#3373F2");
                avatar.BackColor = (avatarbackcolor);
            }

            if (Properties.Settings.Default.themecolor == "Crimson")
            {
                var faviconbackcolor = ColorTranslator.FromHtml("#902941");
                favicon.BackColor = (faviconbackcolor);

                var headerbackcolor = ColorTranslator.FromHtml("#B53351");
                header.BackColor = (headerbackcolor);

                var footerbackcolor = ColorTranslator.FromHtml("#B53351");
                footer.BackColor = (footerbackcolor);

                var leftcolor1backcolor = ColorTranslator.FromHtml("#B53351");
                leftcolor1.BackColor = (leftcolor1backcolor);

                var leftcolor2backcolor = ColorTranslator.FromHtml("#B53351");
                leftcolor2.BackColor = (leftcolor2backcolor);

                var leftcolor3backcolor = ColorTranslator.FromHtml("#B53351");
                leftcolor3.BackColor = (leftcolor3backcolor);

                var leftcolor4backcolor = ColorTranslator.FromHtml("#B53351");
                leftcolor4.BackColor = (leftcolor4backcolor);

                var leftcolor5backcolor = ColorTranslator.FromHtml("#B53351");
                leftcolor5.BackColor = (leftcolor5backcolor);

                var buyrenewbackcolor = ColorTranslator.FromHtml("#B53351");
                buyrenew.BackColor = (buyrenewbackcolor);

                var licencebuyrenewcolorbackcolor = ColorTranslator.FromHtml("#B53351");
                licencebuyrenewcolor.BackColor = (licencebuyrenewcolorbackcolor);

                var mylicencecolorbackcolor = ColorTranslator.FromHtml("#B53351");
                mylicencecolor.BackColor = (mylicencecolorbackcolor);

                var avatarbackcolor = ColorTranslator.FromHtml("#B53351");
                avatar.BackColor = (avatarbackcolor);
            }

            if (Properties.Settings.Default.themecolor == "Cyan")
            {
                var faviconbackcolor = ColorTranslator.FromHtml("#3A91BC");
                favicon.BackColor = (faviconbackcolor);

                var headerbackcolor = ColorTranslator.FromHtml("#49B4E8");
                header.BackColor = (headerbackcolor);

                var footerbackcolor = ColorTranslator.FromHtml("#49B4E8");
                footer.BackColor = (footerbackcolor);

                var leftcolor1backcolor = ColorTranslator.FromHtml("#49B4E8");
                leftcolor1.BackColor = (leftcolor1backcolor);

                var leftcolor2backcolor = ColorTranslator.FromHtml("#49B4E8");
                leftcolor2.BackColor = (leftcolor2backcolor);

                var leftcolor3backcolor = ColorTranslator.FromHtml("#49B4E8");
                leftcolor3.BackColor = (leftcolor3backcolor);

                var leftcolor4backcolor = ColorTranslator.FromHtml("#49B4E8");
                leftcolor4.BackColor = (leftcolor4backcolor);

                var leftcolor5backcolor = ColorTranslator.FromHtml("#49B4E8");
                leftcolor5.BackColor = (leftcolor5backcolor);

                var buyrenewbackcolor = ColorTranslator.FromHtml("#49B4E8");
                buyrenew.BackColor = (buyrenewbackcolor);

                var licencebuyrenewcolorbackcolor = ColorTranslator.FromHtml("#49B4E8");
                licencebuyrenewcolor.BackColor = (licencebuyrenewcolorbackcolor);

                var mylicencecolorbackcolor = ColorTranslator.FromHtml("#49B4E8");
                mylicencecolor.BackColor = (mylicencecolorbackcolor);

                var avatarbackcolor = ColorTranslator.FromHtml("#49B4E8");
                avatar.BackColor = (avatarbackcolor);
            }

            if (Properties.Settings.Default.themecolor == "Dark Gold")
            {
                var faviconbackcolor = ColorTranslator.FromHtml("#A67C00");
                favicon.BackColor = (faviconbackcolor);

                var headerbackcolor = ColorTranslator.FromHtml("#BF9B30");
                header.BackColor = (headerbackcolor);

                var footerbackcolor = ColorTranslator.FromHtml("#BF9B30");
                footer.BackColor = (footerbackcolor);

                var leftcolor1backcolor = ColorTranslator.FromHtml("#BF9B30");
                leftcolor1.BackColor = (leftcolor1backcolor);

                var leftcolor2backcolor = ColorTranslator.FromHtml("#BF9B30");
                leftcolor2.BackColor = (leftcolor2backcolor);

                var leftcolor3backcolor = ColorTranslator.FromHtml("#BF9B30");
                leftcolor3.BackColor = (leftcolor3backcolor);

                var leftcolor4backcolor = ColorTranslator.FromHtml("#BF9B30");
                leftcolor4.BackColor = (leftcolor4backcolor);

                var leftcolor5backcolor = ColorTranslator.FromHtml("#BF9B30");
                leftcolor5.BackColor = (leftcolor5backcolor);

                var buyrenewbackcolor = ColorTranslator.FromHtml("#BF9B30");
                buyrenew.BackColor = (buyrenewbackcolor);

                var licencebuyrenewcolorbackcolor = ColorTranslator.FromHtml("#BF9B30");
                licencebuyrenewcolor.BackColor = (licencebuyrenewcolorbackcolor);

                var mylicencecolorbackcolor = ColorTranslator.FromHtml("#BF9B30");
                mylicencecolor.BackColor = (mylicencecolorbackcolor);

                var avatarbackcolor = ColorTranslator.FromHtml("#BF9B30");
                avatar.BackColor = (avatarbackcolor);
            }

            if (Properties.Settings.Default.themecolor == "Dark Red")
            {
                var faviconbackcolor = ColorTranslator.FromHtml("#920D00");
                favicon.BackColor = (faviconbackcolor);

                var headerbackcolor = ColorTranslator.FromHtml("#AF1001");
                header.BackColor = (headerbackcolor);

                var footerbackcolor = ColorTranslator.FromHtml("#AF1001");
                footer.BackColor = (footerbackcolor);

                var leftcolor1backcolor = ColorTranslator.FromHtml("#AF1001");
                leftcolor1.BackColor = (leftcolor1backcolor);

                var leftcolor2backcolor = ColorTranslator.FromHtml("#AF1001");
                leftcolor2.BackColor = (leftcolor2backcolor);

                var leftcolor3backcolor = ColorTranslator.FromHtml("#AF1001");
                leftcolor3.BackColor = (leftcolor3backcolor);

                var leftcolor4backcolor = ColorTranslator.FromHtml("#AF1001");
                leftcolor4.BackColor = (leftcolor4backcolor);

                var leftcolor5backcolor = ColorTranslator.FromHtml("#AF1001");
                leftcolor5.BackColor = (leftcolor5backcolor);

                var buyrenewbackcolor = ColorTranslator.FromHtml("#AF1001");
                buyrenew.BackColor = (buyrenewbackcolor);

                var licencebuyrenewcolorbackcolor = ColorTranslator.FromHtml("#AF1001");
                licencebuyrenewcolor.BackColor = (licencebuyrenewcolorbackcolor);

                var mylicencecolorbackcolor = ColorTranslator.FromHtml("#AF1001");
                mylicencecolor.BackColor = (mylicencecolorbackcolor);

                var avatarbackcolor = ColorTranslator.FromHtml("#AF1001");
                avatar.BackColor = (avatarbackcolor);
            }

            if (Properties.Settings.Default.themecolor == "Emerald")
            {
                var faviconbackcolor = ColorTranslator.FromHtml("#267826");
                favicon.BackColor = (faviconbackcolor);

                var headerbackcolor = ColorTranslator.FromHtml("#33A133");
                header.BackColor = (headerbackcolor);

                var footerbackcolor = ColorTranslator.FromHtml("#33A133");
                footer.BackColor = (footerbackcolor);

                var leftcolor1backcolor = ColorTranslator.FromHtml("#33A133");
                leftcolor1.BackColor = (leftcolor1backcolor);

                var leftcolor2backcolor = ColorTranslator.FromHtml("#33A133");
                leftcolor2.BackColor = (leftcolor2backcolor);

                var leftcolor3backcolor = ColorTranslator.FromHtml("#33A133");
                leftcolor3.BackColor = (leftcolor3backcolor);

                var leftcolor4backcolor = ColorTranslator.FromHtml("#33A133");
                leftcolor4.BackColor = (leftcolor4backcolor);

                var leftcolor5backcolor = ColorTranslator.FromHtml("#33A133");
                leftcolor5.BackColor = (leftcolor5backcolor);

                var buyrenewbackcolor = ColorTranslator.FromHtml("#33A133");
                buyrenew.BackColor = (buyrenewbackcolor);

                var licencebuyrenewcolorbackcolor = ColorTranslator.FromHtml("#33A133");
                licencebuyrenewcolor.BackColor = (licencebuyrenewcolorbackcolor);

                var mylicencecolorbackcolor = ColorTranslator.FromHtml("#33A133");
                mylicencecolor.BackColor = (mylicencecolorbackcolor);

                var avatarbackcolor = ColorTranslator.FromHtml("#33A133");
                avatar.BackColor = (avatarbackcolor);
            }

            if (Properties.Settings.Default.themecolor == "Green")
            {
                var faviconbackcolor = ColorTranslator.FromHtml("#608C33");
                favicon.BackColor = (faviconbackcolor);

                var headerbackcolor = ColorTranslator.FromHtml("#80BA45");
                header.BackColor = (headerbackcolor);

                var footerbackcolor = ColorTranslator.FromHtml("#80BA45");
                footer.BackColor = (footerbackcolor);

                var leftcolor1backcolor = ColorTranslator.FromHtml("#80BA45");
                leftcolor1.BackColor = (leftcolor1backcolor);

                var leftcolor2backcolor = ColorTranslator.FromHtml("#80BA45");
                leftcolor2.BackColor = (leftcolor2backcolor);

                var leftcolor3backcolor = ColorTranslator.FromHtml("#80BA45");
                leftcolor3.BackColor = (leftcolor3backcolor);

                var leftcolor4backcolor = ColorTranslator.FromHtml("#80BA45");
                leftcolor4.BackColor = (leftcolor4backcolor);

                var leftcolor5backcolor = ColorTranslator.FromHtml("#80BA45");
                leftcolor5.BackColor = (leftcolor5backcolor);

                var buyrenewbackcolor = ColorTranslator.FromHtml("#80BA45");
                buyrenew.BackColor = (buyrenewbackcolor);

                var licencebuyrenewcolorbackcolor = ColorTranslator.FromHtml("#80BA45");
                licencebuyrenewcolor.BackColor = (licencebuyrenewcolorbackcolor);

                var mylicencecolorbackcolor = ColorTranslator.FromHtml("#80BA45");
                mylicencecolor.BackColor = (mylicencecolorbackcolor);

                var avatarbackcolor = ColorTranslator.FromHtml("#80BA45");
                avatar.BackColor = (avatarbackcolor);
            }

            if (Properties.Settings.Default.themecolor == "Indigo")
            {
                var faviconbackcolor = ColorTranslator.FromHtml("#6926C6");
                favicon.BackColor = (faviconbackcolor);

                var headerbackcolor = ColorTranslator.FromHtml("#8833FF");
                header.BackColor = (headerbackcolor);

                var footerbackcolor = ColorTranslator.FromHtml("#8833FF");
                footer.BackColor = (footerbackcolor);

                var leftcolor1backcolor = ColorTranslator.FromHtml("#8833FF");
                leftcolor1.BackColor = (leftcolor1backcolor);

                var leftcolor2backcolor = ColorTranslator.FromHtml("#8833FF");
                leftcolor2.BackColor = (leftcolor2backcolor);

                var leftcolor3backcolor = ColorTranslator.FromHtml("#8833FF");
                leftcolor3.BackColor = (leftcolor3backcolor);

                var leftcolor4backcolor = ColorTranslator.FromHtml("#8833FF");
                leftcolor4.BackColor = (leftcolor4backcolor);

                var leftcolor5backcolor = ColorTranslator.FromHtml("#8833FF");
                leftcolor5.BackColor = (leftcolor5backcolor);

                var buyrenewbackcolor = ColorTranslator.FromHtml("#8833FF");
                buyrenew.BackColor = (buyrenewbackcolor);

                var licencebuyrenewcolorbackcolor = ColorTranslator.FromHtml("#8833FF");
                licencebuyrenewcolor.BackColor = (licencebuyrenewcolorbackcolor);

                var mylicencecolorbackcolor = ColorTranslator.FromHtml("#8833FF");
                mylicencecolor.BackColor = (mylicencecolorbackcolor);

                var avatarbackcolor = ColorTranslator.FromHtml("#8833FF");
                avatar.BackColor = (avatarbackcolor);
            }

            if (Properties.Settings.Default.themecolor == "Magenta")
            {
                var faviconbackcolor = ColorTranslator.FromHtml("#AF276F");
                favicon.BackColor = (faviconbackcolor);

                var headerbackcolor = ColorTranslator.FromHtml("#E0338F");
                header.BackColor = (headerbackcolor);

                var footerbackcolor = ColorTranslator.FromHtml("#E0338F");
                footer.BackColor = (footerbackcolor);

                var leftcolor1backcolor = ColorTranslator.FromHtml("#E0338F");
                leftcolor1.BackColor = (leftcolor1backcolor);

                var leftcolor2backcolor = ColorTranslator.FromHtml("#E0338F");
                leftcolor2.BackColor = (leftcolor2backcolor);

                var leftcolor3backcolor = ColorTranslator.FromHtml("#E0338F");
                leftcolor3.BackColor = (leftcolor3backcolor);

                var leftcolor4backcolor = ColorTranslator.FromHtml("#E0338F");
                leftcolor4.BackColor = (leftcolor4backcolor);

                var leftcolor5backcolor = ColorTranslator.FromHtml("#E0338F");
                leftcolor5.BackColor = (leftcolor5backcolor);

                var buyrenewbackcolor = ColorTranslator.FromHtml("#E0338F");
                buyrenew.BackColor = (buyrenewbackcolor);

                var licencebuyrenewcolorbackcolor = ColorTranslator.FromHtml("#E0338F");
                licencebuyrenewcolor.BackColor = (licencebuyrenewcolorbackcolor);

                var mylicencecolorbackcolor = ColorTranslator.FromHtml("#E0338F");
                mylicencecolor.BackColor = (mylicencecolorbackcolor);

                var avatarbackcolor = ColorTranslator.FromHtml("#E0338F");
                avatar.BackColor = (avatarbackcolor);
            }

            if (Properties.Settings.Default.themecolor == "Mauve")
            {
                var faviconbackcolor = ColorTranslator.FromHtml("#6B5E77");
                favicon.BackColor = (faviconbackcolor);

                var headerbackcolor = ColorTranslator.FromHtml("#9180A1");
                header.BackColor = (headerbackcolor);

                var footerbackcolor = ColorTranslator.FromHtml("#9180A1");
                footer.BackColor = (footerbackcolor);

                var leftcolor1backcolor = ColorTranslator.FromHtml("#9180A1");
                leftcolor1.BackColor = (leftcolor1backcolor);

                var leftcolor2backcolor = ColorTranslator.FromHtml("#9180A1");
                leftcolor2.BackColor = (leftcolor2backcolor);

                var leftcolor3backcolor = ColorTranslator.FromHtml("#9180A1");
                leftcolor3.BackColor = (leftcolor3backcolor);

                var leftcolor4backcolor = ColorTranslator.FromHtml("#9180A1");
                leftcolor4.BackColor = (leftcolor4backcolor);

                var leftcolor5backcolor = ColorTranslator.FromHtml("#9180A1");
                leftcolor5.BackColor = (leftcolor5backcolor);

                var buyrenewbackcolor = ColorTranslator.FromHtml("#9180A1");
                buyrenew.BackColor = (buyrenewbackcolor);

                var licencebuyrenewcolorbackcolor = ColorTranslator.FromHtml("#9180A1");
                licencebuyrenewcolor.BackColor = (licencebuyrenewcolorbackcolor);

                var mylicencecolorbackcolor = ColorTranslator.FromHtml("#9180A1");
                mylicencecolor.BackColor = (mylicencecolorbackcolor);

                var avatarbackcolor = ColorTranslator.FromHtml("#9180A1");
                avatar.BackColor = (avatarbackcolor);
            }

            if (Properties.Settings.Default.themecolor == "Orange")
            {
                var faviconbackcolor = ColorTranslator.FromHtml("#C46826");
                favicon.BackColor = (faviconbackcolor);

                var headerbackcolor = ColorTranslator.FromHtml("#FB8633");
                header.BackColor = (headerbackcolor);

                var footerbackcolor = ColorTranslator.FromHtml("#FB8633");
                footer.BackColor = (footerbackcolor);

                var leftcolor1backcolor = ColorTranslator.FromHtml("#FB8633");
                leftcolor1.BackColor = (leftcolor1backcolor);

                var leftcolor2backcolor = ColorTranslator.FromHtml("#FB8633");
                leftcolor2.BackColor = (leftcolor2backcolor);

                var leftcolor3backcolor = ColorTranslator.FromHtml("#FB8633");
                leftcolor3.BackColor = (leftcolor3backcolor);

                var leftcolor4backcolor = ColorTranslator.FromHtml("#FB8633");
                leftcolor4.BackColor = (leftcolor4backcolor);

                var leftcolor5backcolor = ColorTranslator.FromHtml("#FB8633");
                leftcolor5.BackColor = (leftcolor5backcolor);

                var buyrenewbackcolor = ColorTranslator.FromHtml("#FB8633");
                buyrenew.BackColor = (buyrenewbackcolor);

                var licencebuyrenewcolorbackcolor = ColorTranslator.FromHtml("#FB8633");
                licencebuyrenewcolor.BackColor = (licencebuyrenewcolorbackcolor);

                var mylicencecolorbackcolor = ColorTranslator.FromHtml("#FB8633");
                mylicencecolor.BackColor = (mylicencecolorbackcolor);

                var avatarbackcolor = ColorTranslator.FromHtml("#FB8633");
                avatar.BackColor = (avatarbackcolor);
            }

            if (Properties.Settings.Default.themecolor == "Pink")
            {
                var faviconbackcolor = ColorTranslator.FromHtml("#C671AE");
                favicon.BackColor = (faviconbackcolor);

                var headerbackcolor = ColorTranslator.FromHtml("#F68ED9");
                header.BackColor = (headerbackcolor);

                var footerbackcolor = ColorTranslator.FromHtml("#F68ED9");
                footer.BackColor = (footerbackcolor);

                var leftcolor1backcolor = ColorTranslator.FromHtml("#F68ED9");
                leftcolor1.BackColor = (leftcolor1backcolor);

                var leftcolor2backcolor = ColorTranslator.FromHtml("#F68ED9");
                leftcolor2.BackColor = (leftcolor2backcolor);

                var leftcolor3backcolor = ColorTranslator.FromHtml("#F68ED9");
                leftcolor3.BackColor = (leftcolor3backcolor);

                var leftcolor4backcolor = ColorTranslator.FromHtml("#F68ED9");
                leftcolor4.BackColor = (leftcolor4backcolor);

                var leftcolor5backcolor = ColorTranslator.FromHtml("#F68ED9");
                leftcolor5.BackColor = (leftcolor5backcolor);

                var buyrenewbackcolor = ColorTranslator.FromHtml("#F68ED9");
                buyrenew.BackColor = (buyrenewbackcolor);

                var licencebuyrenewcolorbackcolor = ColorTranslator.FromHtml("#F68ED9");
                licencebuyrenewcolor.BackColor = (licencebuyrenewcolorbackcolor);

                var mylicencecolorbackcolor = ColorTranslator.FromHtml("#F68ED9");
                mylicencecolor.BackColor = (mylicencecolorbackcolor);

                var avatarbackcolor = ColorTranslator.FromHtml("#F68ED9");
                avatar.BackColor = (avatarbackcolor);
            }

            if (Properties.Settings.Default.themecolor == "Purple")
            {
                var faviconbackcolor = ColorTranslator.FromHtml("#665FB4");
                favicon.BackColor = (faviconbackcolor);

                var headerbackcolor = ColorTranslator.FromHtml("#837AE5");
                header.BackColor = (headerbackcolor);

                var footerbackcolor = ColorTranslator.FromHtml("#837AE5");
                footer.BackColor = (footerbackcolor);

                var leftcolor1backcolor = ColorTranslator.FromHtml("#837AE5");
                leftcolor1.BackColor = (leftcolor1backcolor);

                var leftcolor2backcolor = ColorTranslator.FromHtml("#837AE5");
                leftcolor2.BackColor = (leftcolor2backcolor);

                var leftcolor3backcolor = ColorTranslator.FromHtml("#837AE5");
                leftcolor3.BackColor = (leftcolor3backcolor);

                var leftcolor4backcolor = ColorTranslator.FromHtml("#837AE5");
                leftcolor4.BackColor = (leftcolor4backcolor);

                var leftcolor5backcolor = ColorTranslator.FromHtml("#837AE5");
                leftcolor5.BackColor = (leftcolor5backcolor);

                var buyrenewbackcolor = ColorTranslator.FromHtml("#837AE5");
                buyrenew.BackColor = (buyrenewbackcolor);

                var licencebuyrenewcolorbackcolor = ColorTranslator.FromHtml("#837AE5");
                licencebuyrenewcolor.BackColor = (licencebuyrenewcolorbackcolor);

                var mylicencecolorbackcolor = ColorTranslator.FromHtml("#837AE5");
                mylicencecolor.BackColor = (mylicencecolorbackcolor);

                var avatarbackcolor = ColorTranslator.FromHtml("#837AE5");
                avatar.BackColor = (avatarbackcolor);
            }

            if (Properties.Settings.Default.themecolor == "Red")
            {
                var faviconbackcolor = ColorTranslator.FromHtml("#BF3528");
                favicon.BackColor = (faviconbackcolor);

                var headerbackcolor = ColorTranslator.FromHtml("#EA4333");
                header.BackColor = (headerbackcolor);

                var footerbackcolor = ColorTranslator.FromHtml("#EA4333");
                footer.BackColor = (footerbackcolor);

                var leftcolor1backcolor = ColorTranslator.FromHtml("#EA4333");
                leftcolor1.BackColor = (leftcolor1backcolor);

                var leftcolor2backcolor = ColorTranslator.FromHtml("#EA4333");
                leftcolor2.BackColor = (leftcolor2backcolor);

                var leftcolor3backcolor = ColorTranslator.FromHtml("#EA4333");
                leftcolor3.BackColor = (leftcolor3backcolor);

                var leftcolor4backcolor = ColorTranslator.FromHtml("#EA4333");
                leftcolor4.BackColor = (leftcolor4backcolor);

                var leftcolor5backcolor = ColorTranslator.FromHtml("#EA4333");
                leftcolor5.BackColor = (leftcolor5backcolor);

                var buyrenewbackcolor = ColorTranslator.FromHtml("#EA4333");
                buyrenew.BackColor = (buyrenewbackcolor);

                var licencebuyrenewcolorbackcolor = ColorTranslator.FromHtml("#EA4333");
                licencebuyrenewcolor.BackColor = (licencebuyrenewcolorbackcolor);

                var mylicencecolorbackcolor = ColorTranslator.FromHtml("#EA4333");
                mylicencecolor.BackColor = (mylicencecolorbackcolor);

                var avatarbackcolor = ColorTranslator.FromHtml("#EA4333");
                avatar.BackColor = (avatarbackcolor);
            }

            if (Properties.Settings.Default.themecolor == "Sienna")
            {
                var faviconbackcolor = ColorTranslator.FromHtml("#865740");
                favicon.BackColor = (faviconbackcolor);

                var headerbackcolor = ColorTranslator.FromHtml("#B37557");
                header.BackColor = (headerbackcolor);

                var footerbackcolor = ColorTranslator.FromHtml("#B37557");
                footer.BackColor = (footerbackcolor);

                var leftcolor1backcolor = ColorTranslator.FromHtml("#B37557");
                leftcolor1.BackColor = (leftcolor1backcolor);

                var leftcolor2backcolor = ColorTranslator.FromHtml("#B37557");
                leftcolor2.BackColor = (leftcolor2backcolor);

                var leftcolor3backcolor = ColorTranslator.FromHtml("#B37557");
                leftcolor3.BackColor = (leftcolor3backcolor);

                var leftcolor4backcolor = ColorTranslator.FromHtml("#B37557");
                leftcolor4.BackColor = (leftcolor4backcolor);

                var leftcolor5backcolor = ColorTranslator.FromHtml("#B37557");
                leftcolor5.BackColor = (leftcolor5backcolor);

                var buyrenewbackcolor = ColorTranslator.FromHtml("#B37557");
                buyrenew.BackColor = (buyrenewbackcolor);

                var licencebuyrenewcolorbackcolor = ColorTranslator.FromHtml("#B37557");
                licencebuyrenewcolor.BackColor = (licencebuyrenewcolorbackcolor);

                var mylicencecolorbackcolor = ColorTranslator.FromHtml("#B37557");
                mylicencecolor.BackColor = (mylicencecolorbackcolor);

                var avatarbackcolor = ColorTranslator.FromHtml("#B37557");
                avatar.BackColor = (avatarbackcolor);
            }

            if (Properties.Settings.Default.themecolor == "Steel")
            {
                var faviconbackcolor = ColorTranslator.FromHtml("#5A646E");
                favicon.BackColor = (faviconbackcolor);

                var headerbackcolor = ColorTranslator.FromHtml("#83919F");
                header.BackColor = (headerbackcolor);

                var footerbackcolor = ColorTranslator.FromHtml("#83919F");
                footer.BackColor = (footerbackcolor);

                var leftcolor1backcolor = ColorTranslator.FromHtml("#83919F");
                leftcolor1.BackColor = (leftcolor1backcolor);

                var leftcolor2backcolor = ColorTranslator.FromHtml("#83919F");
                leftcolor2.BackColor = (leftcolor2backcolor);

                var leftcolor3backcolor = ColorTranslator.FromHtml("#83919F");
                leftcolor3.BackColor = (leftcolor3backcolor);

                var leftcolor4backcolor = ColorTranslator.FromHtml("#83919F");
                leftcolor4.BackColor = (leftcolor4backcolor);

                var leftcolor5backcolor = ColorTranslator.FromHtml("#83919F");
                leftcolor5.BackColor = (leftcolor5backcolor);

                var buyrenewbackcolor = ColorTranslator.FromHtml("#83919F");
                buyrenew.BackColor = (buyrenewbackcolor);

                var licencebuyrenewcolorbackcolor = ColorTranslator.FromHtml("#83919F");
                licencebuyrenewcolor.BackColor = (licencebuyrenewcolorbackcolor);

                var mylicencecolorbackcolor = ColorTranslator.FromHtml("#83919F");
                mylicencecolor.BackColor = (mylicencecolorbackcolor);

                var avatarbackcolor = ColorTranslator.FromHtml("#83919F");
                avatar.BackColor = (avatarbackcolor);
            }

            if (Properties.Settings.Default.themecolor == "Taupe")
            {
                var faviconbackcolor = ColorTranslator.FromHtml("#6B644C");
                favicon.BackColor = (faviconbackcolor);

                var headerbackcolor = ColorTranslator.FromHtml("#9F9471");
                header.BackColor = (headerbackcolor);

                var footerbackcolor = ColorTranslator.FromHtml("#9F9471");
                footer.BackColor = (footerbackcolor);

                var leftcolor1backcolor = ColorTranslator.FromHtml("#9F9471");
                leftcolor1.BackColor = (leftcolor1backcolor);

                var leftcolor2backcolor = ColorTranslator.FromHtml("#9F9471");
                leftcolor2.BackColor = (leftcolor2backcolor);

                var leftcolor3backcolor = ColorTranslator.FromHtml("#9F9471");
                leftcolor3.BackColor = (leftcolor3backcolor);

                var leftcolor4backcolor = ColorTranslator.FromHtml("#9F9471");
                leftcolor4.BackColor = (leftcolor4backcolor);

                var leftcolor5backcolor = ColorTranslator.FromHtml("#9F9471");
                leftcolor5.BackColor = (leftcolor5backcolor);

                var buyrenewbackcolor = ColorTranslator.FromHtml("#9F9471");
                buyrenew.BackColor = (buyrenewbackcolor);

                var licencebuyrenewcolorbackcolor = ColorTranslator.FromHtml("#9F9471");
                licencebuyrenewcolor.BackColor = (licencebuyrenewcolorbackcolor);

                var mylicencecolorbackcolor = ColorTranslator.FromHtml("#9F9471");
                mylicencecolor.BackColor = (mylicencecolorbackcolor);

                var avatarbackcolor = ColorTranslator.FromHtml("#9F9471");
                avatar.BackColor = (avatarbackcolor);
            }

            if (Properties.Settings.Default.themecolor == "Teal")
            {
                var faviconbackcolor = ColorTranslator.FromHtml("#248988");
                favicon.BackColor = (faviconbackcolor);

                var headerbackcolor = ColorTranslator.FromHtml("#33BCBA");
                header.BackColor = (headerbackcolor);

                var footerbackcolor = ColorTranslator.FromHtml("#33BCBA");
                footer.BackColor = (footerbackcolor);

                var leftcolor1backcolor = ColorTranslator.FromHtml("#33BCBA");
                leftcolor1.BackColor = (leftcolor1backcolor);

                var leftcolor2backcolor = ColorTranslator.FromHtml("#33BCBA");
                leftcolor2.BackColor = (leftcolor2backcolor);

                var leftcolor3backcolor = ColorTranslator.FromHtml("#33BCBA");
                leftcolor3.BackColor = (leftcolor3backcolor);

                var leftcolor4backcolor = ColorTranslator.FromHtml("#33BCBA");
                leftcolor4.BackColor = (leftcolor4backcolor);

                var leftcolor5backcolor = ColorTranslator.FromHtml("#33BCBA");
                leftcolor5.BackColor = (leftcolor5backcolor);

                var buyrenewbackcolor = ColorTranslator.FromHtml("#33BCBA");
                buyrenew.BackColor = (buyrenewbackcolor);

                var licencebuyrenewcolorbackcolor = ColorTranslator.FromHtml("#33BCBA");
                licencebuyrenewcolor.BackColor = (licencebuyrenewcolorbackcolor);

                var mylicencecolorbackcolor = ColorTranslator.FromHtml("#33BCBA");
                mylicencecolor.BackColor = (mylicencecolorbackcolor);

                var avatarbackcolor = ColorTranslator.FromHtml("#33BCBA");
                avatar.BackColor = (avatarbackcolor);
            }

        }

        private void Loader_Load(object sender, EventArgs e)
        {
            themecolor_Data();
        }

        private void logo2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://memoryhackers.org"); //ByYasin
        }

        private void mylicencelabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            bunifuPages1.PageIndex = 0;
            leftcolor1.Visible = false;
            leftcolor2.Visible = false;
            leftcolor3.Visible = false;
            leftcolor4.Visible = false;
            leftcolor5.Visible = false;
            licencebuyrenewcolor.Visible = false;
            mylicencecolor.Visible = true;
        }

        private void usertext_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            bunifuPages1.PageIndex = 0;
            leftcolor1.Visible = false;
            leftcolor2.Visible = false;
            leftcolor3.Visible = false;
            leftcolor4.Visible = false;
            leftcolor5.Visible = false;
            licencebuyrenewcolor.Visible = false;
            mylicencecolor.Visible = true;
        }

        private void buyrenewlabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            bunifuPages1.PageIndex = 1;
            leftcolor1.Visible = false;
            leftcolor2.Visible = false;
            leftcolor3.Visible = false;
            leftcolor4.Visible = false;
            leftcolor5.Visible = false;
            licencebuyrenewcolor.Visible = true;
            mylicencecolor.Visible = false;
        }

        private void notification_Click(object sender, EventArgs e)
        {
            bunifuPages1.PageIndex = 2;
            leftcolor1.Visible = false;
            leftcolor2.Visible = false;
            leftcolor3.Visible = false;
            leftcolor4.Visible = false;
            leftcolor5.Visible = false;
            licencebuyrenewcolor.Visible = false;
            mylicencecolor.Visible = false;
        }

        private void updates_Click(object sender, EventArgs e)
        {
            bunifuPages1.PageIndex = 3;
            leftcolor1.Visible = false;
            leftcolor2.Visible = false;
            leftcolor3.Visible = false;
            leftcolor4.Visible = false;
            leftcolor5.Visible = false;
            licencebuyrenewcolor.Visible = false;
            mylicencecolor.Visible = false;
        }

        private void settings_Click(object sender, EventArgs e)
        {
            bunifuPages1.PageIndex = 4;
            leftcolor1.Visible = false;
            leftcolor2.Visible = false;
            leftcolor3.Visible = false;
            leftcolor4.Visible = false;
            leftcolor5.Visible = false;
            licencebuyrenewcolor.Visible = false;
            mylicencecolor.Visible = false;
        }

        private void csgobutton_Click(object sender, EventArgs e)
        {
            bunifuPages1.PageIndex = 5;
            leftcolor1.Visible = true;
            leftcolor2.Visible = false;
            leftcolor3.Visible = false;
            leftcolor4.Visible = false;
            leftcolor5.Visible = false;
            licencebuyrenewcolor.Visible = false;
            mylicencecolor.Visible = false;
        }

        private void eftbutton_Click(object sender, EventArgs e)
        {
            bunifuPages1.PageIndex = 6;
            leftcolor1.Visible = false;
            leftcolor2.Visible = true;
            leftcolor3.Visible = false;
            leftcolor4.Visible = false;
            leftcolor5.Visible = false;
            licencebuyrenewcolor.Visible = false;
            mylicencecolor.Visible = false;
        }

        private void lolbutton_Click(object sender, EventArgs e)
        {
            bunifuPages1.PageIndex = 7;
            leftcolor1.Visible = false;
            leftcolor2.Visible = false;
            leftcolor3.Visible = true;
            leftcolor4.Visible = false;
            leftcolor5.Visible = false;
            licencebuyrenewcolor.Visible = false;
            mylicencecolor.Visible = false;
        }

        private void pubgbutton_Click(object sender, EventArgs e)
        {
            bunifuPages1.PageIndex = 8;
            leftcolor1.Visible = false;
            leftcolor2.Visible = false;
            leftcolor3.Visible = false;
            leftcolor4.Visible = true;
            leftcolor5.Visible = false;
            licencebuyrenewcolor.Visible = false;
            mylicencecolor.Visible = false;
        }

        private void rustbutton_Click(object sender, EventArgs e)
        {
            bunifuPages1.PageIndex = 9;
            leftcolor1.Visible = false;
            leftcolor2.Visible = false;
            leftcolor3.Visible = false;
            leftcolor4.Visible = false;
            leftcolor5.Visible = true;
            licencebuyrenewcolor.Visible = false;
            mylicencecolor.Visible = false;
        }
    }

}
