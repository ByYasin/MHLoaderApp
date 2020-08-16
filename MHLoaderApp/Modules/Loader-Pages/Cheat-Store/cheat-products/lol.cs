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
    public partial class lol : UserControl
    {
        public lol()
        {
            InitializeComponent();
            themecolor_Data();
        }

        private void themecolor_Data()
        {
            if (Properties.Settings.Default.themecolor == "Blue (Default)")
            {
                var lolbuttonbackcolor = ColorTranslator.FromHtml("#3393DF");
                lolbutton.BackColor = (lolbuttonbackcolor);
                var lolbuttonnormalcolor = ColorTranslator.FromHtml("#3393DF");
                lolbutton.Normalcolor = (lolbuttonnormalcolor);
                var lolbuttononhovercolor = ColorTranslator.FromHtml("#3393DF");
                lolbutton.OnHovercolor = (lolbuttononhovercolor);
            }

            if (Properties.Settings.Default.themecolor == "Brown")
            {
                var lolbuttonbackcolor = ColorTranslator.FromHtml("#9B7B56");
                lolbutton.BackColor = (lolbuttonbackcolor);
                var lolbuttonnormalcolor = ColorTranslator.FromHtml("#9B7B56");
                lolbutton.Normalcolor = (lolbuttonnormalcolor);
                var lolbuttononhovercolor = ColorTranslator.FromHtml("#9B7B56");
                lolbutton.OnHovercolor = (lolbuttononhovercolor);
            }

            if (Properties.Settings.Default.themecolor == "Cobalt")
            {
                var lolbuttonbackcolor = ColorTranslator.FromHtml("#3373F2");
                lolbutton.BackColor = (lolbuttonbackcolor);
                var lolbuttonnormalcolor = ColorTranslator.FromHtml("#3373F2");
                lolbutton.Normalcolor = (lolbuttonnormalcolor);
                var lolbuttononhovercolor = ColorTranslator.FromHtml("#3373F2");
                lolbutton.OnHovercolor = (lolbuttononhovercolor);
            }

            if (Properties.Settings.Default.themecolor == "Crimson")
            {
                var lolbuttonbackcolor = ColorTranslator.FromHtml("#B53351");
                lolbutton.BackColor = (lolbuttonbackcolor);
                var lolbuttonnormalcolor = ColorTranslator.FromHtml("#B53351");
                lolbutton.Normalcolor = (lolbuttonnormalcolor);
                var lolbuttononhovercolor = ColorTranslator.FromHtml("#B53351");
                lolbutton.OnHovercolor = (lolbuttononhovercolor);
            }

            if (Properties.Settings.Default.themecolor == "Cyan")
            {
                var lolbuttonbackcolor = ColorTranslator.FromHtml("#49B4E8");
                lolbutton.BackColor = (lolbuttonbackcolor);
                var lolbuttonnormalcolor = ColorTranslator.FromHtml("#49B4E8");
                lolbutton.Normalcolor = (lolbuttonnormalcolor);
                var lolbuttononhovercolor = ColorTranslator.FromHtml("#49B4E8");
                lolbutton.OnHovercolor = (lolbuttononhovercolor);
            }

            if (Properties.Settings.Default.themecolor == "Dark Gold")
            {
                var lolbuttonbackcolor = ColorTranslator.FromHtml("#BF9B30");
                lolbutton.BackColor = (lolbuttonbackcolor);
                var lolbuttonnormalcolor = ColorTranslator.FromHtml("#BF9B30");
                lolbutton.Normalcolor = (lolbuttonnormalcolor);
                var lolbuttononhovercolor = ColorTranslator.FromHtml("#BF9B30");
                lolbutton.OnHovercolor = (lolbuttononhovercolor);
            }

            if (Properties.Settings.Default.themecolor == "Dark Red")
            {
                var lolbuttonbackcolor = ColorTranslator.FromHtml("#AF1001");
                lolbutton.BackColor = (lolbuttonbackcolor);
                var lolbuttonnormalcolor = ColorTranslator.FromHtml("#AF1001");
                lolbutton.Normalcolor = (lolbuttonnormalcolor);
                var lolbuttononhovercolor = ColorTranslator.FromHtml("#AF1001");
                lolbutton.OnHovercolor = (lolbuttononhovercolor);
            }

            if (Properties.Settings.Default.themecolor == "Emerald")
            {
                var lolbuttonbackcolor = ColorTranslator.FromHtml("#33A133");
                lolbutton.BackColor = (lolbuttonbackcolor);
                var lolbuttonnormalcolor = ColorTranslator.FromHtml("#33A133");
                lolbutton.Normalcolor = (lolbuttonnormalcolor);
                var lolbuttononhovercolor = ColorTranslator.FromHtml("#33A133");
                lolbutton.OnHovercolor = (lolbuttononhovercolor);
            }

            if (Properties.Settings.Default.themecolor == "Green")
            {
                var lolbuttonbackcolor = ColorTranslator.FromHtml("#80BA45");
                lolbutton.BackColor = (lolbuttonbackcolor);
                var lolbuttonnormalcolor = ColorTranslator.FromHtml("#80BA45");
                lolbutton.Normalcolor = (lolbuttonnormalcolor);
                var lolbuttononhovercolor = ColorTranslator.FromHtml("#80BA45");
                lolbutton.OnHovercolor = (lolbuttononhovercolor);
            }

            if (Properties.Settings.Default.themecolor == "Indigo")
            {
                var lolbuttonbackcolor = ColorTranslator.FromHtml("#8833FF");
                lolbutton.BackColor = (lolbuttonbackcolor);
                var lolbuttonnormalcolor = ColorTranslator.FromHtml("#8833FF");
                lolbutton.Normalcolor = (lolbuttonnormalcolor);
                var lolbuttononhovercolor = ColorTranslator.FromHtml("#8833FF");
                lolbutton.OnHovercolor = (lolbuttononhovercolor);
            }

            if (Properties.Settings.Default.themecolor == "Magenta")
            {
                var lolbuttonbackcolor = ColorTranslator.FromHtml("#E0338F");
                lolbutton.BackColor = (lolbuttonbackcolor);
                var lolbuttonnormalcolor = ColorTranslator.FromHtml("#E0338F");
                lolbutton.Normalcolor = (lolbuttonnormalcolor);
                var lolbuttononhovercolor = ColorTranslator.FromHtml("#E0338F");
                lolbutton.OnHovercolor = (lolbuttononhovercolor);
            }

            if (Properties.Settings.Default.themecolor == "Mauve")
            {
                var lolbuttonbackcolor = ColorTranslator.FromHtml("#9180A1");
                lolbutton.BackColor = (lolbuttonbackcolor);
                var lolbuttonnormalcolor = ColorTranslator.FromHtml("#9180A1");
                lolbutton.Normalcolor = (lolbuttonnormalcolor);
                var lolbuttononhovercolor = ColorTranslator.FromHtml("#9180A1");
                lolbutton.OnHovercolor = (lolbuttononhovercolor);
            }

            if (Properties.Settings.Default.themecolor == "Orange")
            {
                var lolbuttonbackcolor = ColorTranslator.FromHtml("#FB8633");
                lolbutton.BackColor = (lolbuttonbackcolor);
                var lolbuttonnormalcolor = ColorTranslator.FromHtml("#FB8633");
                lolbutton.Normalcolor = (lolbuttonnormalcolor);
                var lolbuttononhovercolor = ColorTranslator.FromHtml("#FB8633");
                lolbutton.OnHovercolor = (lolbuttononhovercolor);
            }

            if (Properties.Settings.Default.themecolor == "Pink")
            {
                var lolbuttonbackcolor = ColorTranslator.FromHtml("#F68ED9");
                lolbutton.BackColor = (lolbuttonbackcolor);
                var lolbuttonnormalcolor = ColorTranslator.FromHtml("#F68ED9");
                lolbutton.Normalcolor = (lolbuttonnormalcolor);
                var lolbuttononhovercolor = ColorTranslator.FromHtml("#F68ED9");
                lolbutton.OnHovercolor = (lolbuttononhovercolor);
            }

            if (Properties.Settings.Default.themecolor == "Purple")
            {
                var lolbuttonbackcolor = ColorTranslator.FromHtml("#837AE5");
                lolbutton.BackColor = (lolbuttonbackcolor);
                var lolbuttonnormalcolor = ColorTranslator.FromHtml("#837AE5");
                lolbutton.Normalcolor = (lolbuttonnormalcolor);
                var lolbuttononhovercolor = ColorTranslator.FromHtml("#837AE5");
                lolbutton.OnHovercolor = (lolbuttononhovercolor);
            }

            if (Properties.Settings.Default.themecolor == "Red")
            {
                var lolbuttonbackcolor = ColorTranslator.FromHtml("#EA4333");
                lolbutton.BackColor = (lolbuttonbackcolor);
                var lolbuttonnormalcolor = ColorTranslator.FromHtml("#EA4333");
                lolbutton.Normalcolor = (lolbuttonnormalcolor);
                var lolbuttononhovercolor = ColorTranslator.FromHtml("#EA4333");
                lolbutton.OnHovercolor = (lolbuttononhovercolor);
            }

            if (Properties.Settings.Default.themecolor == "Sienna")
            {
                var lolbuttonbackcolor = ColorTranslator.FromHtml("#B37557");
                lolbutton.BackColor = (lolbuttonbackcolor);
                var lolbuttonnormalcolor = ColorTranslator.FromHtml("#B37557");
                lolbutton.Normalcolor = (lolbuttonnormalcolor);
                var lolbuttononhovercolor = ColorTranslator.FromHtml("#B37557");
                lolbutton.OnHovercolor = (lolbuttononhovercolor);
            }

            if (Properties.Settings.Default.themecolor == "Steel")
            {
                var lolbuttonbackcolor = ColorTranslator.FromHtml("#83919F");
                lolbutton.BackColor = (lolbuttonbackcolor);
                var lolbuttonnormalcolor = ColorTranslator.FromHtml("#83919F");
                lolbutton.Normalcolor = (lolbuttonnormalcolor);
                var lolbuttononhovercolor = ColorTranslator.FromHtml("#83919F");
                lolbutton.OnHovercolor = (lolbuttononhovercolor);
            }

            if (Properties.Settings.Default.themecolor == "Taupe")
            {
                var lolbuttonbackcolor = ColorTranslator.FromHtml("#9F9471");
                lolbutton.BackColor = (lolbuttonbackcolor);
                var lolbuttonnormalcolor = ColorTranslator.FromHtml("#9F9471");
                lolbutton.Normalcolor = (lolbuttonnormalcolor);
                var lolbuttononhovercolor = ColorTranslator.FromHtml("#9F9471");
                lolbutton.OnHovercolor = (lolbuttononhovercolor);
            }

            if (Properties.Settings.Default.themecolor == "Teal")
            {
                var lolbuttonbackcolor = ColorTranslator.FromHtml("#33BCBA");
                lolbutton.BackColor = (lolbuttonbackcolor);
                var lolbuttonnormalcolor = ColorTranslator.FromHtml("#33BCBA");
                lolbutton.Normalcolor = (lolbuttonnormalcolor);
                var lolbuttononhovercolor = ColorTranslator.FromHtml("#33BCBA");
                lolbutton.OnHovercolor = (lolbuttononhovercolor);
            }

        }

        private void lol_Load(object sender, EventArgs e)
        {
            themecolor_Data();
        }
    }
}
