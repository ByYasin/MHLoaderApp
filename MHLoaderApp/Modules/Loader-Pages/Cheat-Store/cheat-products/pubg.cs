using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MHLoaderApp.Modules.Loader_Pages.Cheat_Store.cheat_products
{
    public partial class pubg : UserControl
    {
        public pubg()
        {
            InitializeComponent();
            themecolor_Data();
        }

        private void themecolor_Data()
        {
            if (Properties.Settings.Default.themecolor == "Blue (Default)")
            {
                var pubgbuttonbackcolor = ColorTranslator.FromHtml("#3393DF");
                pubgbutton.BackColor = (pubgbuttonbackcolor);
                var pubgbuttonnormalcolor = ColorTranslator.FromHtml("#3393DF");
                pubgbutton.Normalcolor = (pubgbuttonnormalcolor);
                var pubgbuttononhovercolor = ColorTranslator.FromHtml("#3393DF");
                pubgbutton.OnHovercolor = (pubgbuttononhovercolor);
            }

            if (Properties.Settings.Default.themecolor == "Brown")
            {
                var pubgbuttonbackcolor = ColorTranslator.FromHtml("#9B7B56");
                pubgbutton.BackColor = (pubgbuttonbackcolor);
                var pubgbuttonnormalcolor = ColorTranslator.FromHtml("#9B7B56");
                pubgbutton.Normalcolor = (pubgbuttonnormalcolor);
                var pubgbuttononhovercolor = ColorTranslator.FromHtml("#9B7B56");
                pubgbutton.OnHovercolor = (pubgbuttononhovercolor);
            }

            if (Properties.Settings.Default.themecolor == "Cobalt")
            {
                var pubgbuttonbackcolor = ColorTranslator.FromHtml("#3373F2");
                pubgbutton.BackColor = (pubgbuttonbackcolor);
                var pubgbuttonnormalcolor = ColorTranslator.FromHtml("#3373F2");
                pubgbutton.Normalcolor = (pubgbuttonnormalcolor);
                var pubgbuttononhovercolor = ColorTranslator.FromHtml("#3373F2");
                pubgbutton.OnHovercolor = (pubgbuttononhovercolor);
            }

            if (Properties.Settings.Default.themecolor == "Crimson")
            {
                var pubgbuttonbackcolor = ColorTranslator.FromHtml("#B53351");
                pubgbutton.BackColor = (pubgbuttonbackcolor);
                var pubgbuttonnormalcolor = ColorTranslator.FromHtml("#B53351");
                pubgbutton.Normalcolor = (pubgbuttonnormalcolor);
                var pubgbuttononhovercolor = ColorTranslator.FromHtml("#B53351");
                pubgbutton.OnHovercolor = (pubgbuttononhovercolor);
            }

            if (Properties.Settings.Default.themecolor == "Cyan")
            {
                var pubgbuttonbackcolor = ColorTranslator.FromHtml("#49B4E8");
                pubgbutton.BackColor = (pubgbuttonbackcolor);
                var pubgbuttonnormalcolor = ColorTranslator.FromHtml("#49B4E8");
                pubgbutton.Normalcolor = (pubgbuttonnormalcolor);
                var pubgbuttononhovercolor = ColorTranslator.FromHtml("#49B4E8");
                pubgbutton.OnHovercolor = (pubgbuttononhovercolor);
            }

            if (Properties.Settings.Default.themecolor == "Dark Gold")
            {
                var pubgbuttonbackcolor = ColorTranslator.FromHtml("#BF9B30");
                pubgbutton.BackColor = (pubgbuttonbackcolor);
                var pubgbuttonnormalcolor = ColorTranslator.FromHtml("#BF9B30");
                pubgbutton.Normalcolor = (pubgbuttonnormalcolor);
                var pubgbuttononhovercolor = ColorTranslator.FromHtml("#BF9B30");
                pubgbutton.OnHovercolor = (pubgbuttononhovercolor);
            }

            if (Properties.Settings.Default.themecolor == "Dark Red")
            {
                var pubgbuttonbackcolor = ColorTranslator.FromHtml("#AF1001");
                pubgbutton.BackColor = (pubgbuttonbackcolor);
                var pubgbuttonnormalcolor = ColorTranslator.FromHtml("#AF1001");
                pubgbutton.Normalcolor = (pubgbuttonnormalcolor);
                var pubgbuttononhovercolor = ColorTranslator.FromHtml("#AF1001");
                pubgbutton.OnHovercolor = (pubgbuttononhovercolor);
            }

            if (Properties.Settings.Default.themecolor == "Emerald")
            {
                var pubgbuttonbackcolor = ColorTranslator.FromHtml("#33A133");
                pubgbutton.BackColor = (pubgbuttonbackcolor);
                var pubgbuttonnormalcolor = ColorTranslator.FromHtml("#33A133");
                pubgbutton.Normalcolor = (pubgbuttonnormalcolor);
                var pubgbuttononhovercolor = ColorTranslator.FromHtml("#33A133");
                pubgbutton.OnHovercolor = (pubgbuttononhovercolor);
            }

            if (Properties.Settings.Default.themecolor == "Green")
            {
                var pubgbuttonbackcolor = ColorTranslator.FromHtml("#80BA45");
                pubgbutton.BackColor = (pubgbuttonbackcolor);
                var pubgbuttonnormalcolor = ColorTranslator.FromHtml("#80BA45");
                pubgbutton.Normalcolor = (pubgbuttonnormalcolor);
                var pubgbuttononhovercolor = ColorTranslator.FromHtml("#80BA45");
                pubgbutton.OnHovercolor = (pubgbuttononhovercolor);
            }

            if (Properties.Settings.Default.themecolor == "Indigo")
            {
                var pubgbuttonbackcolor = ColorTranslator.FromHtml("#8833FF");
                pubgbutton.BackColor = (pubgbuttonbackcolor);
                var pubgbuttonnormalcolor = ColorTranslator.FromHtml("#8833FF");
                pubgbutton.Normalcolor = (pubgbuttonnormalcolor);
                var pubgbuttononhovercolor = ColorTranslator.FromHtml("#8833FF");
                pubgbutton.OnHovercolor = (pubgbuttononhovercolor);
            }

            if (Properties.Settings.Default.themecolor == "Magenta")
            {
                var pubgbuttonbackcolor = ColorTranslator.FromHtml("#E0338F");
                pubgbutton.BackColor = (pubgbuttonbackcolor);
                var pubgbuttonnormalcolor = ColorTranslator.FromHtml("#E0338F");
                pubgbutton.Normalcolor = (pubgbuttonnormalcolor);
                var pubgbuttononhovercolor = ColorTranslator.FromHtml("#E0338F");
                pubgbutton.OnHovercolor = (pubgbuttononhovercolor);
            }

            if (Properties.Settings.Default.themecolor == "Mauve")
            {
                var pubgbuttonbackcolor = ColorTranslator.FromHtml("#9180A1");
                pubgbutton.BackColor = (pubgbuttonbackcolor);
                var pubgbuttonnormalcolor = ColorTranslator.FromHtml("#9180A1");
                pubgbutton.Normalcolor = (pubgbuttonnormalcolor);
                var pubgbuttononhovercolor = ColorTranslator.FromHtml("#9180A1");
                pubgbutton.OnHovercolor = (pubgbuttononhovercolor);
            }

            if (Properties.Settings.Default.themecolor == "Orange")
            {
                var pubgbuttonbackcolor = ColorTranslator.FromHtml("#FB8633");
                pubgbutton.BackColor = (pubgbuttonbackcolor);
                var pubgbuttonnormalcolor = ColorTranslator.FromHtml("#FB8633");
                pubgbutton.Normalcolor = (pubgbuttonnormalcolor);
                var pubgbuttononhovercolor = ColorTranslator.FromHtml("#FB8633");
                pubgbutton.OnHovercolor = (pubgbuttononhovercolor);
            }

            if (Properties.Settings.Default.themecolor == "Pink")
            {
                var pubgbuttonbackcolor = ColorTranslator.FromHtml("#F68ED9");
                pubgbutton.BackColor = (pubgbuttonbackcolor);
                var pubgbuttonnormalcolor = ColorTranslator.FromHtml("#F68ED9");
                pubgbutton.Normalcolor = (pubgbuttonnormalcolor);
                var pubgbuttononhovercolor = ColorTranslator.FromHtml("#F68ED9");
                pubgbutton.OnHovercolor = (pubgbuttononhovercolor);
            }

            if (Properties.Settings.Default.themecolor == "Purple")
            {
                var pubgbuttonbackcolor = ColorTranslator.FromHtml("#837AE5");
                pubgbutton.BackColor = (pubgbuttonbackcolor);
                var pubgbuttonnormalcolor = ColorTranslator.FromHtml("#837AE5");
                pubgbutton.Normalcolor = (pubgbuttonnormalcolor);
                var pubgbuttononhovercolor = ColorTranslator.FromHtml("#837AE5");
                pubgbutton.OnHovercolor = (pubgbuttononhovercolor);
            }

            if (Properties.Settings.Default.themecolor == "Red")
            {
                var pubgbuttonbackcolor = ColorTranslator.FromHtml("#EA4333");
                pubgbutton.BackColor = (pubgbuttonbackcolor);
                var pubgbuttonnormalcolor = ColorTranslator.FromHtml("#EA4333");
                pubgbutton.Normalcolor = (pubgbuttonnormalcolor);
                var pubgbuttononhovercolor = ColorTranslator.FromHtml("#EA4333");
                pubgbutton.OnHovercolor = (pubgbuttononhovercolor);
            }

            if (Properties.Settings.Default.themecolor == "Sienna")
            {
                var pubgbuttonbackcolor = ColorTranslator.FromHtml("#B37557");
                pubgbutton.BackColor = (pubgbuttonbackcolor);
                var pubgbuttonnormalcolor = ColorTranslator.FromHtml("#B37557");
                pubgbutton.Normalcolor = (pubgbuttonnormalcolor);
                var pubgbuttononhovercolor = ColorTranslator.FromHtml("#B37557");
                pubgbutton.OnHovercolor = (pubgbuttononhovercolor);
            }

            if (Properties.Settings.Default.themecolor == "Steel")
            {
                var pubgbuttonbackcolor = ColorTranslator.FromHtml("#83919F");
                pubgbutton.BackColor = (pubgbuttonbackcolor);
                var pubgbuttonnormalcolor = ColorTranslator.FromHtml("#83919F");
                pubgbutton.Normalcolor = (pubgbuttonnormalcolor);
                var pubgbuttononhovercolor = ColorTranslator.FromHtml("#83919F");
                pubgbutton.OnHovercolor = (pubgbuttononhovercolor);
            }

            if (Properties.Settings.Default.themecolor == "Taupe")
            {
                var pubgbuttonbackcolor = ColorTranslator.FromHtml("#9F9471");
                pubgbutton.BackColor = (pubgbuttonbackcolor);
                var pubgbuttonnormalcolor = ColorTranslator.FromHtml("#9F9471");
                pubgbutton.Normalcolor = (pubgbuttonnormalcolor);
                var pubgbuttononhovercolor = ColorTranslator.FromHtml("#9F9471");
                pubgbutton.OnHovercolor = (pubgbuttononhovercolor);
            }

            if (Properties.Settings.Default.themecolor == "Teal")
            {
                var pubgbuttonbackcolor = ColorTranslator.FromHtml("#33BCBA");
                pubgbutton.BackColor = (pubgbuttonbackcolor);
                var pubgbuttonnormalcolor = ColorTranslator.FromHtml("#33BCBA");
                pubgbutton.Normalcolor = (pubgbuttonnormalcolor);
                var pubgbuttononhovercolor = ColorTranslator.FromHtml("#33BCBA");
                pubgbutton.OnHovercolor = (pubgbuttononhovercolor);
            }

        }

        private void pubg_Load(object sender, EventArgs e)
        {
            themecolor_Data();
        }
    }
}
