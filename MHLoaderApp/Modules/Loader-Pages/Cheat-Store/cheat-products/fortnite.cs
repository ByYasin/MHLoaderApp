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
    public partial class fortnite : UserControl
    {
        public fortnite()
        {
            InitializeComponent();
            themecolor_Data();
        }

        private void themecolor_Data()
        {
            if (Properties.Settings.Default.themecolor == "Blue (Default)")
            {
                var fortnitebuttonbackcolor = ColorTranslator.FromHtml("#3393DF");
                fortnitebutton.BackColor = (fortnitebuttonbackcolor);
                var fortnitebuttonnormalcolor = ColorTranslator.FromHtml("#3393DF");
                fortnitebutton.Normalcolor = (fortnitebuttonnormalcolor);
                var fortnitebuttononhovercolor = ColorTranslator.FromHtml("#3393DF");
                fortnitebutton.OnHovercolor = (fortnitebuttononhovercolor);
            }

            if (Properties.Settings.Default.themecolor == "Brown")
            {
                var fortnitebuttonbackcolor = ColorTranslator.FromHtml("#9B7B56");
                fortnitebutton.BackColor = (fortnitebuttonbackcolor);
                var fortnitebuttonnormalcolor = ColorTranslator.FromHtml("#9B7B56");
                fortnitebutton.Normalcolor = (fortnitebuttonnormalcolor);
                var fortnitebuttononhovercolor = ColorTranslator.FromHtml("#9B7B56");
                fortnitebutton.OnHovercolor = (fortnitebuttononhovercolor);
            }

            if (Properties.Settings.Default.themecolor == "Cobalt")
            {
                var fortnitebuttonbackcolor = ColorTranslator.FromHtml("#3373F2");
                fortnitebutton.BackColor = (fortnitebuttonbackcolor);
                var fortnitebuttonnormalcolor = ColorTranslator.FromHtml("#3373F2");
                fortnitebutton.Normalcolor = (fortnitebuttonnormalcolor);
                var fortnitebuttononhovercolor = ColorTranslator.FromHtml("#3373F2");
                fortnitebutton.OnHovercolor = (fortnitebuttononhovercolor);
            }

            if (Properties.Settings.Default.themecolor == "Crimson")
            {
                var fortnitebuttonbackcolor = ColorTranslator.FromHtml("#B53351");
                fortnitebutton.BackColor = (fortnitebuttonbackcolor);
                var fortnitebuttonnormalcolor = ColorTranslator.FromHtml("#B53351");
                fortnitebutton.Normalcolor = (fortnitebuttonnormalcolor);
                var fortnitebuttononhovercolor = ColorTranslator.FromHtml("#B53351");
                fortnitebutton.OnHovercolor = (fortnitebuttononhovercolor);
            }

            if (Properties.Settings.Default.themecolor == "Cyan")
            {
                var fortnitebuttonbackcolor = ColorTranslator.FromHtml("#49B4E8");
                fortnitebutton.BackColor = (fortnitebuttonbackcolor);
                var fortnitebuttonnormalcolor = ColorTranslator.FromHtml("#49B4E8");
                fortnitebutton.Normalcolor = (fortnitebuttonnormalcolor);
                var fortnitebuttononhovercolor = ColorTranslator.FromHtml("#49B4E8");
                fortnitebutton.OnHovercolor = (fortnitebuttononhovercolor);
            }

            if (Properties.Settings.Default.themecolor == "Dark Gold")
            {
                var fortnitebuttonbackcolor = ColorTranslator.FromHtml("#BF9B30");
                fortnitebutton.BackColor = (fortnitebuttonbackcolor);
                var fortnitebuttonnormalcolor = ColorTranslator.FromHtml("#BF9B30");
                fortnitebutton.Normalcolor = (fortnitebuttonnormalcolor);
                var fortnitebuttononhovercolor = ColorTranslator.FromHtml("#BF9B30");
                fortnitebutton.OnHovercolor = (fortnitebuttononhovercolor);
            }

            if (Properties.Settings.Default.themecolor == "Dark Red")
            {
                var fortnitebuttonbackcolor = ColorTranslator.FromHtml("#AF1001");
                fortnitebutton.BackColor = (fortnitebuttonbackcolor);
                var fortnitebuttonnormalcolor = ColorTranslator.FromHtml("#AF1001");
                fortnitebutton.Normalcolor = (fortnitebuttonnormalcolor);
                var fortnitebuttononhovercolor = ColorTranslator.FromHtml("#AF1001");
                fortnitebutton.OnHovercolor = (fortnitebuttononhovercolor);
            }

            if (Properties.Settings.Default.themecolor == "Emerald")
            {
                var fortnitebuttonbackcolor = ColorTranslator.FromHtml("#33A133");
                fortnitebutton.BackColor = (fortnitebuttonbackcolor);
                var fortnitebuttonnormalcolor = ColorTranslator.FromHtml("#33A133");
                fortnitebutton.Normalcolor = (fortnitebuttonnormalcolor);
                var fortnitebuttononhovercolor = ColorTranslator.FromHtml("#33A133");
                fortnitebutton.OnHovercolor = (fortnitebuttononhovercolor);
            }

            if (Properties.Settings.Default.themecolor == "Green")
            {
                var fortnitebuttonbackcolor = ColorTranslator.FromHtml("#80BA45");
                fortnitebutton.BackColor = (fortnitebuttonbackcolor);
                var fortnitebuttonnormalcolor = ColorTranslator.FromHtml("#80BA45");
                fortnitebutton.Normalcolor = (fortnitebuttonnormalcolor);
                var fortnitebuttononhovercolor = ColorTranslator.FromHtml("#80BA45");
                fortnitebutton.OnHovercolor = (fortnitebuttononhovercolor);
            }

            if (Properties.Settings.Default.themecolor == "Indigo")
            {
                var fortnitebuttonbackcolor = ColorTranslator.FromHtml("#8833FF");
                fortnitebutton.BackColor = (fortnitebuttonbackcolor);
                var fortnitebuttonnormalcolor = ColorTranslator.FromHtml("#8833FF");
                fortnitebutton.Normalcolor = (fortnitebuttonnormalcolor);
                var fortnitebuttononhovercolor = ColorTranslator.FromHtml("#8833FF");
                fortnitebutton.OnHovercolor = (fortnitebuttononhovercolor);
            }

            if (Properties.Settings.Default.themecolor == "Magenta")
            {
                var fortnitebuttonbackcolor = ColorTranslator.FromHtml("#E0338F");
                fortnitebutton.BackColor = (fortnitebuttonbackcolor);
                var fortnitebuttonnormalcolor = ColorTranslator.FromHtml("#E0338F");
                fortnitebutton.Normalcolor = (fortnitebuttonnormalcolor);
                var fortnitebuttononhovercolor = ColorTranslator.FromHtml("#E0338F");
                fortnitebutton.OnHovercolor = (fortnitebuttononhovercolor);
            }

            if (Properties.Settings.Default.themecolor == "Mauve")
            {
                var fortnitebuttonbackcolor = ColorTranslator.FromHtml("#9180A1");
                fortnitebutton.BackColor = (fortnitebuttonbackcolor);
                var fortnitebuttonnormalcolor = ColorTranslator.FromHtml("#9180A1");
                fortnitebutton.Normalcolor = (fortnitebuttonnormalcolor);
                var fortnitebuttononhovercolor = ColorTranslator.FromHtml("#9180A1");
                fortnitebutton.OnHovercolor = (fortnitebuttononhovercolor);
            }

            if (Properties.Settings.Default.themecolor == "Orange")
            {
                var fortnitebuttonbackcolor = ColorTranslator.FromHtml("#FB8633");
                fortnitebutton.BackColor = (fortnitebuttonbackcolor);
                var fortnitebuttonnormalcolor = ColorTranslator.FromHtml("#FB8633");
                fortnitebutton.Normalcolor = (fortnitebuttonnormalcolor);
                var fortnitebuttononhovercolor = ColorTranslator.FromHtml("#FB8633");
                fortnitebutton.OnHovercolor = (fortnitebuttononhovercolor);
            }

            if (Properties.Settings.Default.themecolor == "Pink")
            {
                var fortnitebuttonbackcolor = ColorTranslator.FromHtml("#F68ED9");
                fortnitebutton.BackColor = (fortnitebuttonbackcolor);
                var fortnitebuttonnormalcolor = ColorTranslator.FromHtml("#F68ED9");
                fortnitebutton.Normalcolor = (fortnitebuttonnormalcolor);
                var fortnitebuttononhovercolor = ColorTranslator.FromHtml("#F68ED9");
                fortnitebutton.OnHovercolor = (fortnitebuttononhovercolor);
            }

            if (Properties.Settings.Default.themecolor == "Purple")
            {
                var fortnitebuttonbackcolor = ColorTranslator.FromHtml("#837AE5");
                fortnitebutton.BackColor = (fortnitebuttonbackcolor);
                var fortnitebuttonnormalcolor = ColorTranslator.FromHtml("#837AE5");
                fortnitebutton.Normalcolor = (fortnitebuttonnormalcolor);
                var fortnitebuttononhovercolor = ColorTranslator.FromHtml("#837AE5");
                fortnitebutton.OnHovercolor = (fortnitebuttononhovercolor);
            }

            if (Properties.Settings.Default.themecolor == "Red")
            {
                var fortnitebuttonbackcolor = ColorTranslator.FromHtml("#EA4333");
                fortnitebutton.BackColor = (fortnitebuttonbackcolor);
                var fortnitebuttonnormalcolor = ColorTranslator.FromHtml("#EA4333");
                fortnitebutton.Normalcolor = (fortnitebuttonnormalcolor);
                var fortnitebuttononhovercolor = ColorTranslator.FromHtml("#EA4333");
                fortnitebutton.OnHovercolor = (fortnitebuttononhovercolor);
            }

            if (Properties.Settings.Default.themecolor == "Sienna")
            {
                var fortnitebuttonbackcolor = ColorTranslator.FromHtml("#B37557");
                fortnitebutton.BackColor = (fortnitebuttonbackcolor);
                var fortnitebuttonnormalcolor = ColorTranslator.FromHtml("#B37557");
                fortnitebutton.Normalcolor = (fortnitebuttonnormalcolor);
                var fortnitebuttononhovercolor = ColorTranslator.FromHtml("#B37557");
                fortnitebutton.OnHovercolor = (fortnitebuttononhovercolor);
            }

            if (Properties.Settings.Default.themecolor == "Steel")
            {
                var fortnitebuttonbackcolor = ColorTranslator.FromHtml("#83919F");
                fortnitebutton.BackColor = (fortnitebuttonbackcolor);
                var fortnitebuttonnormalcolor = ColorTranslator.FromHtml("#83919F");
                fortnitebutton.Normalcolor = (fortnitebuttonnormalcolor);
                var fortnitebuttononhovercolor = ColorTranslator.FromHtml("#83919F");
                fortnitebutton.OnHovercolor = (fortnitebuttononhovercolor);
            }

            if (Properties.Settings.Default.themecolor == "Taupe")
            {
                var fortnitebuttonbackcolor = ColorTranslator.FromHtml("#9F9471");
                fortnitebutton.BackColor = (fortnitebuttonbackcolor);
                var fortnitebuttonnormalcolor = ColorTranslator.FromHtml("#9F9471");
                fortnitebutton.Normalcolor = (fortnitebuttonnormalcolor);
                var fortnitebuttononhovercolor = ColorTranslator.FromHtml("#9F9471");
                fortnitebutton.OnHovercolor = (fortnitebuttononhovercolor);
            }

            if (Properties.Settings.Default.themecolor == "Teal")
            {
                var fortnitebuttonbackcolor = ColorTranslator.FromHtml("#33BCBA");
                fortnitebutton.BackColor = (fortnitebuttonbackcolor);
                var fortnitebuttonnormalcolor = ColorTranslator.FromHtml("#33BCBA");
                fortnitebutton.Normalcolor = (fortnitebuttonnormalcolor);
                var fortnitebuttononhovercolor = ColorTranslator.FromHtml("#33BCBA");
                fortnitebutton.OnHovercolor = (fortnitebuttononhovercolor);
            }

        }

        private void fortnite_Load(object sender, EventArgs e)
        {
            themecolor_Data();
        }
    }
}
