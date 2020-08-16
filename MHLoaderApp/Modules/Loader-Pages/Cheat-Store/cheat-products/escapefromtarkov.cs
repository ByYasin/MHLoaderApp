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
    public partial class escapefromtarkov : UserControl
    {
        public escapefromtarkov()
        {
            InitializeComponent();
            themecolor_Data();
        }

        private void themecolor_Data()
        {
            if (Properties.Settings.Default.themecolor == "Blue (Default)")
            {
                var eftbuttonbackcolor = ColorTranslator.FromHtml("#3393DF");
                eftbutton.BackColor = (eftbuttonbackcolor);
                var eftbuttonnormalcolor = ColorTranslator.FromHtml("#3393DF");
                eftbutton.Normalcolor = (eftbuttonnormalcolor);
                var eftbuttononhovercolor = ColorTranslator.FromHtml("#3393DF");
                eftbutton.OnHovercolor = (eftbuttononhovercolor);
            }

            if (Properties.Settings.Default.themecolor == "Brown")
            {
                var eftbuttonbackcolor = ColorTranslator.FromHtml("#9B7B56");
                eftbutton.BackColor = (eftbuttonbackcolor);
                var eftbuttonnormalcolor = ColorTranslator.FromHtml("#9B7B56");
                eftbutton.Normalcolor = (eftbuttonnormalcolor);
                var eftbuttononhovercolor = ColorTranslator.FromHtml("#9B7B56");
                eftbutton.OnHovercolor = (eftbuttononhovercolor);
            }

            if (Properties.Settings.Default.themecolor == "Cobalt")
            {
                var eftbuttonbackcolor = ColorTranslator.FromHtml("#3373F2");
                eftbutton.BackColor = (eftbuttonbackcolor);
                var eftbuttonnormalcolor = ColorTranslator.FromHtml("#3373F2");
                eftbutton.Normalcolor = (eftbuttonnormalcolor);
                var eftbuttononhovercolor = ColorTranslator.FromHtml("#3373F2");
                eftbutton.OnHovercolor = (eftbuttononhovercolor);
            }

            if (Properties.Settings.Default.themecolor == "Crimson")
            {
                var eftbuttonbackcolor = ColorTranslator.FromHtml("#B53351");
                eftbutton.BackColor = (eftbuttonbackcolor);
                var eftbuttonnormalcolor = ColorTranslator.FromHtml("#B53351");
                eftbutton.Normalcolor = (eftbuttonnormalcolor);
                var eftbuttononhovercolor = ColorTranslator.FromHtml("#B53351");
                eftbutton.OnHovercolor = (eftbuttononhovercolor);
            }

            if (Properties.Settings.Default.themecolor == "Cyan")
            {
                var eftbuttonbackcolor = ColorTranslator.FromHtml("#49B4E8");
                eftbutton.BackColor = (eftbuttonbackcolor);
                var eftbuttonnormalcolor = ColorTranslator.FromHtml("#49B4E8");
                eftbutton.Normalcolor = (eftbuttonnormalcolor);
                var eftbuttononhovercolor = ColorTranslator.FromHtml("#49B4E8");
                eftbutton.OnHovercolor = (eftbuttononhovercolor);
            }

            if (Properties.Settings.Default.themecolor == "Dark Gold")
            {
                var eftbuttonbackcolor = ColorTranslator.FromHtml("#BF9B30");
                eftbutton.BackColor = (eftbuttonbackcolor);
                var eftbuttonnormalcolor = ColorTranslator.FromHtml("#BF9B30");
                eftbutton.Normalcolor = (eftbuttonnormalcolor);
                var eftbuttononhovercolor = ColorTranslator.FromHtml("#BF9B30");
                eftbutton.OnHovercolor = (eftbuttononhovercolor);
            }

            if (Properties.Settings.Default.themecolor == "Dark Red")
            {
                var eftbuttonbackcolor = ColorTranslator.FromHtml("#AF1001");
                eftbutton.BackColor = (eftbuttonbackcolor);
                var eftbuttonnormalcolor = ColorTranslator.FromHtml("#AF1001");
                eftbutton.Normalcolor = (eftbuttonnormalcolor);
                var eftbuttononhovercolor = ColorTranslator.FromHtml("#AF1001");
                eftbutton.OnHovercolor = (eftbuttononhovercolor);
            }

            if (Properties.Settings.Default.themecolor == "Emerald")
            {
                var eftbuttonbackcolor = ColorTranslator.FromHtml("#33A133");
                eftbutton.BackColor = (eftbuttonbackcolor);
                var eftbuttonnormalcolor = ColorTranslator.FromHtml("#33A133");
                eftbutton.Normalcolor = (eftbuttonnormalcolor);
                var eftbuttononhovercolor = ColorTranslator.FromHtml("#33A133");
                eftbutton.OnHovercolor = (eftbuttononhovercolor);
            }

            if (Properties.Settings.Default.themecolor == "Green")
            {
                var eftbuttonbackcolor = ColorTranslator.FromHtml("#80BA45");
                eftbutton.BackColor = (eftbuttonbackcolor);
                var eftbuttonnormalcolor = ColorTranslator.FromHtml("#80BA45");
                eftbutton.Normalcolor = (eftbuttonnormalcolor);
                var eftbuttononhovercolor = ColorTranslator.FromHtml("#80BA45");
                eftbutton.OnHovercolor = (eftbuttononhovercolor);
            }

            if (Properties.Settings.Default.themecolor == "Indigo")
            {
                var eftbuttonbackcolor = ColorTranslator.FromHtml("#8833FF");
                eftbutton.BackColor = (eftbuttonbackcolor);
                var eftbuttonnormalcolor = ColorTranslator.FromHtml("#8833FF");
                eftbutton.Normalcolor = (eftbuttonnormalcolor);
                var eftbuttononhovercolor = ColorTranslator.FromHtml("#8833FF");
                eftbutton.OnHovercolor = (eftbuttononhovercolor);
            }

            if (Properties.Settings.Default.themecolor == "Magenta")
            {
                var eftbuttonbackcolor = ColorTranslator.FromHtml("#E0338F");
                eftbutton.BackColor = (eftbuttonbackcolor);
                var eftbuttonnormalcolor = ColorTranslator.FromHtml("#E0338F");
                eftbutton.Normalcolor = (eftbuttonnormalcolor);
                var eftbuttononhovercolor = ColorTranslator.FromHtml("#E0338F");
                eftbutton.OnHovercolor = (eftbuttononhovercolor);
            }

            if (Properties.Settings.Default.themecolor == "Mauve")
            {
                var eftbuttonbackcolor = ColorTranslator.FromHtml("#9180A1");
                eftbutton.BackColor = (eftbuttonbackcolor);
                var eftbuttonnormalcolor = ColorTranslator.FromHtml("#9180A1");
                eftbutton.Normalcolor = (eftbuttonnormalcolor);
                var eftbuttononhovercolor = ColorTranslator.FromHtml("#9180A1");
                eftbutton.OnHovercolor = (eftbuttononhovercolor);
            }

            if (Properties.Settings.Default.themecolor == "Orange")
            {
                var eftbuttonbackcolor = ColorTranslator.FromHtml("#FB8633");
                eftbutton.BackColor = (eftbuttonbackcolor);
                var eftbuttonnormalcolor = ColorTranslator.FromHtml("#FB8633");
                eftbutton.Normalcolor = (eftbuttonnormalcolor);
                var eftbuttononhovercolor = ColorTranslator.FromHtml("#FB8633");
                eftbutton.OnHovercolor = (eftbuttononhovercolor);
            }

            if (Properties.Settings.Default.themecolor == "Pink")
            {
                var eftbuttonbackcolor = ColorTranslator.FromHtml("#F68ED9");
                eftbutton.BackColor = (eftbuttonbackcolor);
                var eftbuttonnormalcolor = ColorTranslator.FromHtml("#F68ED9");
                eftbutton.Normalcolor = (eftbuttonnormalcolor);
                var eftbuttononhovercolor = ColorTranslator.FromHtml("#F68ED9");
                eftbutton.OnHovercolor = (eftbuttononhovercolor);
            }

            if (Properties.Settings.Default.themecolor == "Purple")
            {
                var eftbuttonbackcolor = ColorTranslator.FromHtml("#837AE5");
                eftbutton.BackColor = (eftbuttonbackcolor);
                var eftbuttonnormalcolor = ColorTranslator.FromHtml("#837AE5");
                eftbutton.Normalcolor = (eftbuttonnormalcolor);
                var eftbuttononhovercolor = ColorTranslator.FromHtml("#837AE5");
                eftbutton.OnHovercolor = (eftbuttononhovercolor);
            }

            if (Properties.Settings.Default.themecolor == "Red")
            {
                var eftbuttonbackcolor = ColorTranslator.FromHtml("#EA4333");
                eftbutton.BackColor = (eftbuttonbackcolor);
                var eftbuttonnormalcolor = ColorTranslator.FromHtml("#EA4333");
                eftbutton.Normalcolor = (eftbuttonnormalcolor);
                var eftbuttononhovercolor = ColorTranslator.FromHtml("#EA4333");
                eftbutton.OnHovercolor = (eftbuttononhovercolor);
            }

            if (Properties.Settings.Default.themecolor == "Sienna")
            {
                var eftbuttonbackcolor = ColorTranslator.FromHtml("#B37557");
                eftbutton.BackColor = (eftbuttonbackcolor);
                var eftbuttonnormalcolor = ColorTranslator.FromHtml("#B37557");
                eftbutton.Normalcolor = (eftbuttonnormalcolor);
                var eftbuttononhovercolor = ColorTranslator.FromHtml("#B37557");
                eftbutton.OnHovercolor = (eftbuttononhovercolor);
            }

            if (Properties.Settings.Default.themecolor == "Steel")
            {
                var eftbuttonbackcolor = ColorTranslator.FromHtml("#83919F");
                eftbutton.BackColor = (eftbuttonbackcolor);
                var eftbuttonnormalcolor = ColorTranslator.FromHtml("#83919F");
                eftbutton.Normalcolor = (eftbuttonnormalcolor);
                var eftbuttononhovercolor = ColorTranslator.FromHtml("#83919F");
                eftbutton.OnHovercolor = (eftbuttononhovercolor);
            }

            if (Properties.Settings.Default.themecolor == "Taupe")
            {
                var eftbuttonbackcolor = ColorTranslator.FromHtml("#9F9471");
                eftbutton.BackColor = (eftbuttonbackcolor);
                var eftbuttonnormalcolor = ColorTranslator.FromHtml("#9F9471");
                eftbutton.Normalcolor = (eftbuttonnormalcolor);
                var eftbuttononhovercolor = ColorTranslator.FromHtml("#9F9471");
                eftbutton.OnHovercolor = (eftbuttononhovercolor);
            }

            if (Properties.Settings.Default.themecolor == "Teal")
            {
                var eftbuttonbackcolor = ColorTranslator.FromHtml("#33BCBA");
                eftbutton.BackColor = (eftbuttonbackcolor);
                var eftbuttonnormalcolor = ColorTranslator.FromHtml("#33BCBA");
                eftbutton.Normalcolor = (eftbuttonnormalcolor);
                var eftbuttononhovercolor = ColorTranslator.FromHtml("#33BCBA");
                eftbutton.OnHovercolor = (eftbuttononhovercolor);
            }

        }

        private void escapefromtarkov_Load(object sender, EventArgs e)
        {
            themecolor_Data();
        }
    }
}
