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
    public partial class rainbow : UserControl
    {
        public rainbow()
        {
            InitializeComponent();
            themecolor_Data();
        }

        private void themecolor_Data()
        {
            if (Properties.Settings.Default.themecolor == "Blue (Default)")
            {
                var rainbowbuttonbackcolor = ColorTranslator.FromHtml("#3393DF");
                rainbowbutton.BackColor = (rainbowbuttonbackcolor);
                var rainbowbuttonnormalcolor = ColorTranslator.FromHtml("#3393DF");
                rainbowbutton.Normalcolor = (rainbowbuttonnormalcolor);
                var rainbowbuttononhovercolor = ColorTranslator.FromHtml("#3393DF");
                rainbowbutton.OnHovercolor = (rainbowbuttononhovercolor);
            }

            if (Properties.Settings.Default.themecolor == "Brown")
            {
                var rainbowbuttonbackcolor = ColorTranslator.FromHtml("#9B7B56");
                rainbowbutton.BackColor = (rainbowbuttonbackcolor);
                var rainbowbuttonnormalcolor = ColorTranslator.FromHtml("#9B7B56");
                rainbowbutton.Normalcolor = (rainbowbuttonnormalcolor);
                var rainbowbuttononhovercolor = ColorTranslator.FromHtml("#9B7B56");
                rainbowbutton.OnHovercolor = (rainbowbuttononhovercolor);
            }

            if (Properties.Settings.Default.themecolor == "Cobalt")
            {
                var rainbowbuttonbackcolor = ColorTranslator.FromHtml("#3373F2");
                rainbowbutton.BackColor = (rainbowbuttonbackcolor);
                var rainbowbuttonnormalcolor = ColorTranslator.FromHtml("#3373F2");
                rainbowbutton.Normalcolor = (rainbowbuttonnormalcolor);
                var rainbowbuttononhovercolor = ColorTranslator.FromHtml("#3373F2");
                rainbowbutton.OnHovercolor = (rainbowbuttononhovercolor);
            }

            if (Properties.Settings.Default.themecolor == "Crimson")
            {
                var rainbowbuttonbackcolor = ColorTranslator.FromHtml("#B53351");
                rainbowbutton.BackColor = (rainbowbuttonbackcolor);
                var rainbowbuttonnormalcolor = ColorTranslator.FromHtml("#B53351");
                rainbowbutton.Normalcolor = (rainbowbuttonnormalcolor);
                var rainbowbuttononhovercolor = ColorTranslator.FromHtml("#B53351");
                rainbowbutton.OnHovercolor = (rainbowbuttononhovercolor);
            }

            if (Properties.Settings.Default.themecolor == "Cyan")
            {
                var rainbowbuttonbackcolor = ColorTranslator.FromHtml("#49B4E8");
                rainbowbutton.BackColor = (rainbowbuttonbackcolor);
                var rainbowbuttonnormalcolor = ColorTranslator.FromHtml("#49B4E8");
                rainbowbutton.Normalcolor = (rainbowbuttonnormalcolor);
                var rainbowbuttononhovercolor = ColorTranslator.FromHtml("#49B4E8");
                rainbowbutton.OnHovercolor = (rainbowbuttononhovercolor);
            }

            if (Properties.Settings.Default.themecolor == "Dark Gold")
            {
                var rainbowbuttonbackcolor = ColorTranslator.FromHtml("#BF9B30");
                rainbowbutton.BackColor = (rainbowbuttonbackcolor);
                var rainbowbuttonnormalcolor = ColorTranslator.FromHtml("#BF9B30");
                rainbowbutton.Normalcolor = (rainbowbuttonnormalcolor);
                var rainbowbuttononhovercolor = ColorTranslator.FromHtml("#BF9B30");
                rainbowbutton.OnHovercolor = (rainbowbuttononhovercolor);
            }

            if (Properties.Settings.Default.themecolor == "Dark Red")
            {
                var rainbowbuttonbackcolor = ColorTranslator.FromHtml("#AF1001");
                rainbowbutton.BackColor = (rainbowbuttonbackcolor);
                var rainbowbuttonnormalcolor = ColorTranslator.FromHtml("#AF1001");
                rainbowbutton.Normalcolor = (rainbowbuttonnormalcolor);
                var rainbowbuttononhovercolor = ColorTranslator.FromHtml("#AF1001");
                rainbowbutton.OnHovercolor = (rainbowbuttononhovercolor);
            }

            if (Properties.Settings.Default.themecolor == "Emerald")
            {
                var rainbowbuttonbackcolor = ColorTranslator.FromHtml("#33A133");
                rainbowbutton.BackColor = (rainbowbuttonbackcolor);
                var rainbowbuttonnormalcolor = ColorTranslator.FromHtml("#33A133");
                rainbowbutton.Normalcolor = (rainbowbuttonnormalcolor);
                var rainbowbuttononhovercolor = ColorTranslator.FromHtml("#33A133");
                rainbowbutton.OnHovercolor = (rainbowbuttononhovercolor);
            }

            if (Properties.Settings.Default.themecolor == "Green")
            {
                var rainbowbuttonbackcolor = ColorTranslator.FromHtml("#80BA45");
                rainbowbutton.BackColor = (rainbowbuttonbackcolor);
                var rainbowbuttonnormalcolor = ColorTranslator.FromHtml("#80BA45");
                rainbowbutton.Normalcolor = (rainbowbuttonnormalcolor);
                var rainbowbuttononhovercolor = ColorTranslator.FromHtml("#80BA45");
                rainbowbutton.OnHovercolor = (rainbowbuttononhovercolor);
            }

            if (Properties.Settings.Default.themecolor == "Indigo")
            {
                var rainbowbuttonbackcolor = ColorTranslator.FromHtml("#8833FF");
                rainbowbutton.BackColor = (rainbowbuttonbackcolor);
                var rainbowbuttonnormalcolor = ColorTranslator.FromHtml("#8833FF");
                rainbowbutton.Normalcolor = (rainbowbuttonnormalcolor);
                var rainbowbuttononhovercolor = ColorTranslator.FromHtml("#8833FF");
                rainbowbutton.OnHovercolor = (rainbowbuttononhovercolor);
            }

            if (Properties.Settings.Default.themecolor == "Magenta")
            {
                var rainbowbuttonbackcolor = ColorTranslator.FromHtml("#E0338F");
                rainbowbutton.BackColor = (rainbowbuttonbackcolor);
                var rainbowbuttonnormalcolor = ColorTranslator.FromHtml("#E0338F");
                rainbowbutton.Normalcolor = (rainbowbuttonnormalcolor);
                var rainbowbuttononhovercolor = ColorTranslator.FromHtml("#E0338F");
                rainbowbutton.OnHovercolor = (rainbowbuttononhovercolor);
            }

            if (Properties.Settings.Default.themecolor == "Mauve")
            {
                var rainbowbuttonbackcolor = ColorTranslator.FromHtml("#9180A1");
                rainbowbutton.BackColor = (rainbowbuttonbackcolor);
                var rainbowbuttonnormalcolor = ColorTranslator.FromHtml("#9180A1");
                rainbowbutton.Normalcolor = (rainbowbuttonnormalcolor);
                var rainbowbuttononhovercolor = ColorTranslator.FromHtml("#9180A1");
                rainbowbutton.OnHovercolor = (rainbowbuttononhovercolor);
            }

            if (Properties.Settings.Default.themecolor == "Orange")
            {
                var rainbowbuttonbackcolor = ColorTranslator.FromHtml("#FB8633");
                rainbowbutton.BackColor = (rainbowbuttonbackcolor);
                var rainbowbuttonnormalcolor = ColorTranslator.FromHtml("#FB8633");
                rainbowbutton.Normalcolor = (rainbowbuttonnormalcolor);
                var rainbowbuttononhovercolor = ColorTranslator.FromHtml("#FB8633");
                rainbowbutton.OnHovercolor = (rainbowbuttononhovercolor);
            }

            if (Properties.Settings.Default.themecolor == "Pink")
            {
                var rainbowbuttonbackcolor = ColorTranslator.FromHtml("#F68ED9");
                rainbowbutton.BackColor = (rainbowbuttonbackcolor);
                var rainbowbuttonnormalcolor = ColorTranslator.FromHtml("#F68ED9");
                rainbowbutton.Normalcolor = (rainbowbuttonnormalcolor);
                var rainbowbuttononhovercolor = ColorTranslator.FromHtml("#F68ED9");
                rainbowbutton.OnHovercolor = (rainbowbuttononhovercolor);
            }

            if (Properties.Settings.Default.themecolor == "Purple")
            {
                var rainbowbuttonbackcolor = ColorTranslator.FromHtml("#837AE5");
                rainbowbutton.BackColor = (rainbowbuttonbackcolor);
                var rainbowbuttonnormalcolor = ColorTranslator.FromHtml("#837AE5");
                rainbowbutton.Normalcolor = (rainbowbuttonnormalcolor);
                var rainbowbuttononhovercolor = ColorTranslator.FromHtml("#837AE5");
                rainbowbutton.OnHovercolor = (rainbowbuttononhovercolor);
            }

            if (Properties.Settings.Default.themecolor == "Red")
            {
                var rainbowbuttonbackcolor = ColorTranslator.FromHtml("#EA4333");
                rainbowbutton.BackColor = (rainbowbuttonbackcolor);
                var rainbowbuttonnormalcolor = ColorTranslator.FromHtml("#EA4333");
                rainbowbutton.Normalcolor = (rainbowbuttonnormalcolor);
                var rainbowbuttononhovercolor = ColorTranslator.FromHtml("#EA4333");
                rainbowbutton.OnHovercolor = (rainbowbuttononhovercolor);
            }

            if (Properties.Settings.Default.themecolor == "Sienna")
            {
                var rainbowbuttonbackcolor = ColorTranslator.FromHtml("#B37557");
                rainbowbutton.BackColor = (rainbowbuttonbackcolor);
                var rainbowbuttonnormalcolor = ColorTranslator.FromHtml("#B37557");
                rainbowbutton.Normalcolor = (rainbowbuttonnormalcolor);
                var rainbowbuttononhovercolor = ColorTranslator.FromHtml("#B37557");
                rainbowbutton.OnHovercolor = (rainbowbuttononhovercolor);
            }

            if (Properties.Settings.Default.themecolor == "Steel")
            {
                var rainbowbuttonbackcolor = ColorTranslator.FromHtml("#83919F");
                rainbowbutton.BackColor = (rainbowbuttonbackcolor);
                var rainbowbuttonnormalcolor = ColorTranslator.FromHtml("#83919F");
                rainbowbutton.Normalcolor = (rainbowbuttonnormalcolor);
                var rainbowbuttononhovercolor = ColorTranslator.FromHtml("#83919F");
                rainbowbutton.OnHovercolor = (rainbowbuttononhovercolor);
            }

            if (Properties.Settings.Default.themecolor == "Taupe")
            {
                var rainbowbuttonbackcolor = ColorTranslator.FromHtml("#9F9471");
                rainbowbutton.BackColor = (rainbowbuttonbackcolor);
                var rainbowbuttonnormalcolor = ColorTranslator.FromHtml("#9F9471");
                rainbowbutton.Normalcolor = (rainbowbuttonnormalcolor);
                var rainbowbuttononhovercolor = ColorTranslator.FromHtml("#9F9471");
                rainbowbutton.OnHovercolor = (rainbowbuttononhovercolor);
            }

            if (Properties.Settings.Default.themecolor == "Teal")
            {
                var rainbowbuttonbackcolor = ColorTranslator.FromHtml("#33BCBA");
                rainbowbutton.BackColor = (rainbowbuttonbackcolor);
                var rainbowbuttonnormalcolor = ColorTranslator.FromHtml("#33BCBA");
                rainbowbutton.Normalcolor = (rainbowbuttonnormalcolor);
                var rainbowbuttononhovercolor = ColorTranslator.FromHtml("#33BCBA");
                rainbowbutton.OnHovercolor = (rainbowbuttononhovercolor);
            }

        }

        private void rainbow_Load(object sender, EventArgs e)
        {
            themecolor_Data();
        }
    }
}
