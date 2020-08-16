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
    public partial class blackdesert : UserControl
    {
        public blackdesert()
        {
            InitializeComponent();
            themecolor_Data();
        }

        private void themecolor_Data()
        {
            if (Properties.Settings.Default.themecolor == "Blue (Default)")
            {
                var blackdesertbuttonbackcolor = ColorTranslator.FromHtml("#3393DF");
                blackdesertbutton.BackColor = (blackdesertbuttonbackcolor);
                var blackdesertbuttonnormalcolor = ColorTranslator.FromHtml("#3393DF");
                blackdesertbutton.Normalcolor = (blackdesertbuttonnormalcolor);
                var blackdesertbuttononhovercolor = ColorTranslator.FromHtml("#3393DF");
                blackdesertbutton.OnHovercolor = (blackdesertbuttononhovercolor);
            }

            if (Properties.Settings.Default.themecolor == "Brown")
            {
                var blackdesertbuttonbackcolor = ColorTranslator.FromHtml("#9B7B56");
                blackdesertbutton.BackColor = (blackdesertbuttonbackcolor);
                var blackdesertbuttonnormalcolor = ColorTranslator.FromHtml("#9B7B56");
                blackdesertbutton.Normalcolor = (blackdesertbuttonnormalcolor);
                var blackdesertbuttononhovercolor = ColorTranslator.FromHtml("#9B7B56");
                blackdesertbutton.OnHovercolor = (blackdesertbuttononhovercolor);
            }

            if (Properties.Settings.Default.themecolor == "Cobalt")
            {
                var blackdesertbuttonbackcolor = ColorTranslator.FromHtml("#3373F2");
                blackdesertbutton.BackColor = (blackdesertbuttonbackcolor);
                var blackdesertbuttonnormalcolor = ColorTranslator.FromHtml("#3373F2");
                blackdesertbutton.Normalcolor = (blackdesertbuttonnormalcolor);
                var blackdesertbuttononhovercolor = ColorTranslator.FromHtml("#3373F2");
                blackdesertbutton.OnHovercolor = (blackdesertbuttononhovercolor);
            }

            if (Properties.Settings.Default.themecolor == "Crimson")
            {
                var blackdesertbuttonbackcolor = ColorTranslator.FromHtml("#B53351");
                blackdesertbutton.BackColor = (blackdesertbuttonbackcolor);
                var blackdesertbuttonnormalcolor = ColorTranslator.FromHtml("#B53351");
                blackdesertbutton.Normalcolor = (blackdesertbuttonnormalcolor);
                var blackdesertbuttononhovercolor = ColorTranslator.FromHtml("#B53351");
                blackdesertbutton.OnHovercolor = (blackdesertbuttononhovercolor);
            }

            if (Properties.Settings.Default.themecolor == "Cyan")
            {
                var blackdesertbuttonbackcolor = ColorTranslator.FromHtml("#49B4E8");
                blackdesertbutton.BackColor = (blackdesertbuttonbackcolor);
                var blackdesertbuttonnormalcolor = ColorTranslator.FromHtml("#49B4E8");
                blackdesertbutton.Normalcolor = (blackdesertbuttonnormalcolor);
                var blackdesertbuttononhovercolor = ColorTranslator.FromHtml("#49B4E8");
                blackdesertbutton.OnHovercolor = (blackdesertbuttononhovercolor);
            }

            if (Properties.Settings.Default.themecolor == "Dark Gold")
            {
                var blackdesertbuttonbackcolor = ColorTranslator.FromHtml("#BF9B30");
                blackdesertbutton.BackColor = (blackdesertbuttonbackcolor);
                var blackdesertbuttonnormalcolor = ColorTranslator.FromHtml("#BF9B30");
                blackdesertbutton.Normalcolor = (blackdesertbuttonnormalcolor);
                var blackdesertbuttononhovercolor = ColorTranslator.FromHtml("#BF9B30");
                blackdesertbutton.OnHovercolor = (blackdesertbuttononhovercolor);
            }

            if (Properties.Settings.Default.themecolor == "Dark Red")
            {
                var blackdesertbuttonbackcolor = ColorTranslator.FromHtml("#AF1001");
                blackdesertbutton.BackColor = (blackdesertbuttonbackcolor);
                var blackdesertbuttonnormalcolor = ColorTranslator.FromHtml("#AF1001");
                blackdesertbutton.Normalcolor = (blackdesertbuttonnormalcolor);
                var blackdesertbuttononhovercolor = ColorTranslator.FromHtml("#AF1001");
                blackdesertbutton.OnHovercolor = (blackdesertbuttononhovercolor);
            }

            if (Properties.Settings.Default.themecolor == "Emerald")
            {
                var blackdesertbuttonbackcolor = ColorTranslator.FromHtml("#33A133");
                blackdesertbutton.BackColor = (blackdesertbuttonbackcolor);
                var blackdesertbuttonnormalcolor = ColorTranslator.FromHtml("#33A133");
                blackdesertbutton.Normalcolor = (blackdesertbuttonnormalcolor);
                var blackdesertbuttononhovercolor = ColorTranslator.FromHtml("#33A133");
                blackdesertbutton.OnHovercolor = (blackdesertbuttononhovercolor);
            }

            if (Properties.Settings.Default.themecolor == "Green")
            {
                var blackdesertbuttonbackcolor = ColorTranslator.FromHtml("#80BA45");
                blackdesertbutton.BackColor = (blackdesertbuttonbackcolor);
                var blackdesertbuttonnormalcolor = ColorTranslator.FromHtml("#80BA45");
                blackdesertbutton.Normalcolor = (blackdesertbuttonnormalcolor);
                var blackdesertbuttononhovercolor = ColorTranslator.FromHtml("#80BA45");
                blackdesertbutton.OnHovercolor = (blackdesertbuttononhovercolor);
            }

            if (Properties.Settings.Default.themecolor == "Indigo")
            {
                var blackdesertbuttonbackcolor = ColorTranslator.FromHtml("#8833FF");
                blackdesertbutton.BackColor = (blackdesertbuttonbackcolor);
                var blackdesertbuttonnormalcolor = ColorTranslator.FromHtml("#8833FF");
                blackdesertbutton.Normalcolor = (blackdesertbuttonnormalcolor);
                var blackdesertbuttononhovercolor = ColorTranslator.FromHtml("#8833FF");
                blackdesertbutton.OnHovercolor = (blackdesertbuttononhovercolor);
            }

            if (Properties.Settings.Default.themecolor == "Magenta")
            {
                var blackdesertbuttonbackcolor = ColorTranslator.FromHtml("#E0338F");
                blackdesertbutton.BackColor = (blackdesertbuttonbackcolor);
                var blackdesertbuttonnormalcolor = ColorTranslator.FromHtml("#E0338F");
                blackdesertbutton.Normalcolor = (blackdesertbuttonnormalcolor);
                var blackdesertbuttononhovercolor = ColorTranslator.FromHtml("#E0338F");
                blackdesertbutton.OnHovercolor = (blackdesertbuttononhovercolor);
            }

            if (Properties.Settings.Default.themecolor == "Mauve")
            {
                var blackdesertbuttonbackcolor = ColorTranslator.FromHtml("#9180A1");
                blackdesertbutton.BackColor = (blackdesertbuttonbackcolor);
                var blackdesertbuttonnormalcolor = ColorTranslator.FromHtml("#9180A1");
                blackdesertbutton.Normalcolor = (blackdesertbuttonnormalcolor);
                var blackdesertbuttononhovercolor = ColorTranslator.FromHtml("#9180A1");
                blackdesertbutton.OnHovercolor = (blackdesertbuttononhovercolor);
            }

            if (Properties.Settings.Default.themecolor == "Orange")
            {
                var blackdesertbuttonbackcolor = ColorTranslator.FromHtml("#FB8633");
                blackdesertbutton.BackColor = (blackdesertbuttonbackcolor);
                var blackdesertbuttonnormalcolor = ColorTranslator.FromHtml("#FB8633");
                blackdesertbutton.Normalcolor = (blackdesertbuttonnormalcolor);
                var blackdesertbuttononhovercolor = ColorTranslator.FromHtml("#FB8633");
                blackdesertbutton.OnHovercolor = (blackdesertbuttononhovercolor);
            }

            if (Properties.Settings.Default.themecolor == "Pink")
            {
                var blackdesertbuttonbackcolor = ColorTranslator.FromHtml("#F68ED9");
                blackdesertbutton.BackColor = (blackdesertbuttonbackcolor);
                var blackdesertbuttonnormalcolor = ColorTranslator.FromHtml("#F68ED9");
                blackdesertbutton.Normalcolor = (blackdesertbuttonnormalcolor);
                var blackdesertbuttononhovercolor = ColorTranslator.FromHtml("#F68ED9");
                blackdesertbutton.OnHovercolor = (blackdesertbuttononhovercolor);
            }

            if (Properties.Settings.Default.themecolor == "Purple")
            {
                var blackdesertbuttonbackcolor = ColorTranslator.FromHtml("#837AE5");
                blackdesertbutton.BackColor = (blackdesertbuttonbackcolor);
                var blackdesertbuttonnormalcolor = ColorTranslator.FromHtml("#837AE5");
                blackdesertbutton.Normalcolor = (blackdesertbuttonnormalcolor);
                var blackdesertbuttononhovercolor = ColorTranslator.FromHtml("#837AE5");
                blackdesertbutton.OnHovercolor = (blackdesertbuttononhovercolor);
            }

            if (Properties.Settings.Default.themecolor == "Red")
            {
                var blackdesertbuttonbackcolor = ColorTranslator.FromHtml("#EA4333");
                blackdesertbutton.BackColor = (blackdesertbuttonbackcolor);
                var blackdesertbuttonnormalcolor = ColorTranslator.FromHtml("#EA4333");
                blackdesertbutton.Normalcolor = (blackdesertbuttonnormalcolor);
                var blackdesertbuttononhovercolor = ColorTranslator.FromHtml("#EA4333");
                blackdesertbutton.OnHovercolor = (blackdesertbuttononhovercolor);
            }

            if (Properties.Settings.Default.themecolor == "Sienna")
            {
                var blackdesertbuttonbackcolor = ColorTranslator.FromHtml("#B37557");
                blackdesertbutton.BackColor = (blackdesertbuttonbackcolor);
                var blackdesertbuttonnormalcolor = ColorTranslator.FromHtml("#B37557");
                blackdesertbutton.Normalcolor = (blackdesertbuttonnormalcolor);
                var blackdesertbuttononhovercolor = ColorTranslator.FromHtml("#B37557");
                blackdesertbutton.OnHovercolor = (blackdesertbuttononhovercolor);
            }

            if (Properties.Settings.Default.themecolor == "Steel")
            {
                var blackdesertbuttonbackcolor = ColorTranslator.FromHtml("#83919F");
                blackdesertbutton.BackColor = (blackdesertbuttonbackcolor);
                var blackdesertbuttonnormalcolor = ColorTranslator.FromHtml("#83919F");
                blackdesertbutton.Normalcolor = (blackdesertbuttonnormalcolor);
                var blackdesertbuttononhovercolor = ColorTranslator.FromHtml("#83919F");
                blackdesertbutton.OnHovercolor = (blackdesertbuttononhovercolor);
            }

            if (Properties.Settings.Default.themecolor == "Taupe")
            {
                var blackdesertbuttonbackcolor = ColorTranslator.FromHtml("#9F9471");
                blackdesertbutton.BackColor = (blackdesertbuttonbackcolor);
                var blackdesertbuttonnormalcolor = ColorTranslator.FromHtml("#9F9471");
                blackdesertbutton.Normalcolor = (blackdesertbuttonnormalcolor);
                var blackdesertbuttononhovercolor = ColorTranslator.FromHtml("#9F9471");
                blackdesertbutton.OnHovercolor = (blackdesertbuttononhovercolor);
            }

            if (Properties.Settings.Default.themecolor == "Teal")
            {
                var blackdesertbuttonbackcolor = ColorTranslator.FromHtml("#33BCBA");
                blackdesertbutton.BackColor = (blackdesertbuttonbackcolor);
                var blackdesertbuttonnormalcolor = ColorTranslator.FromHtml("#33BCBA");
                blackdesertbutton.Normalcolor = (blackdesertbuttonnormalcolor);
                var blackdesertbuttononhovercolor = ColorTranslator.FromHtml("#33BCBA");
                blackdesertbutton.OnHovercolor = (blackdesertbuttononhovercolor);
            }

        }

        private void blackdesert_Load(object sender, EventArgs e)
        {
            themecolor_Data();
        }
    }
}
