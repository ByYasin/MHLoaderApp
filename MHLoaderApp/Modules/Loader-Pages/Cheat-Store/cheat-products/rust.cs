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
    public partial class rust : UserControl
    {
        public rust()
        {
            InitializeComponent();
            themecolor_Data();
        }

        private void themecolor_Data()
        {
            if (Properties.Settings.Default.themecolor == "Blue (Default)")
            {
                var rustbuttonbackcolor = ColorTranslator.FromHtml("#3393DF");
                rustbutton.BackColor = (rustbuttonbackcolor);
                var rustbuttonnormalcolor = ColorTranslator.FromHtml("#3393DF");
                rustbutton.Normalcolor = (rustbuttonnormalcolor);
                var rustbuttononhovercolor = ColorTranslator.FromHtml("#3393DF");
                rustbutton.OnHovercolor = (rustbuttononhovercolor);
            }

            if (Properties.Settings.Default.themecolor == "Brown")
            {
                var rustbuttonbackcolor = ColorTranslator.FromHtml("#9B7B56");
                rustbutton.BackColor = (rustbuttonbackcolor);
                var rustbuttonnormalcolor = ColorTranslator.FromHtml("#9B7B56");
                rustbutton.Normalcolor = (rustbuttonnormalcolor);
                var rustbuttononhovercolor = ColorTranslator.FromHtml("#9B7B56");
                rustbutton.OnHovercolor = (rustbuttononhovercolor);
            }

            if (Properties.Settings.Default.themecolor == "Cobalt")
            {
                var rustbuttonbackcolor = ColorTranslator.FromHtml("#3373F2");
                rustbutton.BackColor = (rustbuttonbackcolor);
                var rustbuttonnormalcolor = ColorTranslator.FromHtml("#3373F2");
                rustbutton.Normalcolor = (rustbuttonnormalcolor);
                var rustbuttononhovercolor = ColorTranslator.FromHtml("#3373F2");
                rustbutton.OnHovercolor = (rustbuttononhovercolor);
            }

            if (Properties.Settings.Default.themecolor == "Crimson")
            {
                var rustbuttonbackcolor = ColorTranslator.FromHtml("#B53351");
                rustbutton.BackColor = (rustbuttonbackcolor);
                var rustbuttonnormalcolor = ColorTranslator.FromHtml("#B53351");
                rustbutton.Normalcolor = (rustbuttonnormalcolor);
                var rustbuttononhovercolor = ColorTranslator.FromHtml("#B53351");
                rustbutton.OnHovercolor = (rustbuttononhovercolor);
            }

            if (Properties.Settings.Default.themecolor == "Cyan")
            {
                var rustbuttonbackcolor = ColorTranslator.FromHtml("#49B4E8");
                rustbutton.BackColor = (rustbuttonbackcolor);
                var rustbuttonnormalcolor = ColorTranslator.FromHtml("#49B4E8");
                rustbutton.Normalcolor = (rustbuttonnormalcolor);
                var rustbuttononhovercolor = ColorTranslator.FromHtml("#49B4E8");
                rustbutton.OnHovercolor = (rustbuttononhovercolor);
            }

            if (Properties.Settings.Default.themecolor == "Dark Gold")
            {
                var rustbuttonbackcolor = ColorTranslator.FromHtml("#BF9B30");
                rustbutton.BackColor = (rustbuttonbackcolor);
                var rustbuttonnormalcolor = ColorTranslator.FromHtml("#BF9B30");
                rustbutton.Normalcolor = (rustbuttonnormalcolor);
                var rustbuttononhovercolor = ColorTranslator.FromHtml("#BF9B30");
                rustbutton.OnHovercolor = (rustbuttononhovercolor);
            }

            if (Properties.Settings.Default.themecolor == "Dark Red")
            {
                var rustbuttonbackcolor = ColorTranslator.FromHtml("#AF1001");
                rustbutton.BackColor = (rustbuttonbackcolor);
                var rustbuttonnormalcolor = ColorTranslator.FromHtml("#AF1001");
                rustbutton.Normalcolor = (rustbuttonnormalcolor);
                var rustbuttononhovercolor = ColorTranslator.FromHtml("#AF1001");
                rustbutton.OnHovercolor = (rustbuttononhovercolor);
            }

            if (Properties.Settings.Default.themecolor == "Emerald")
            {
                var rustbuttonbackcolor = ColorTranslator.FromHtml("#33A133");
                rustbutton.BackColor = (rustbuttonbackcolor);
                var rustbuttonnormalcolor = ColorTranslator.FromHtml("#33A133");
                rustbutton.Normalcolor = (rustbuttonnormalcolor);
                var rustbuttononhovercolor = ColorTranslator.FromHtml("#33A133");
                rustbutton.OnHovercolor = (rustbuttononhovercolor);
            }

            if (Properties.Settings.Default.themecolor == "Green")
            {
                var rustbuttonbackcolor = ColorTranslator.FromHtml("#80BA45");
                rustbutton.BackColor = (rustbuttonbackcolor);
                var rustbuttonnormalcolor = ColorTranslator.FromHtml("#80BA45");
                rustbutton.Normalcolor = (rustbuttonnormalcolor);
                var rustbuttononhovercolor = ColorTranslator.FromHtml("#80BA45");
                rustbutton.OnHovercolor = (rustbuttononhovercolor);
            }

            if (Properties.Settings.Default.themecolor == "Indigo")
            {
                var rustbuttonbackcolor = ColorTranslator.FromHtml("#8833FF");
                rustbutton.BackColor = (rustbuttonbackcolor);
                var rustbuttonnormalcolor = ColorTranslator.FromHtml("#8833FF");
                rustbutton.Normalcolor = (rustbuttonnormalcolor);
                var rustbuttononhovercolor = ColorTranslator.FromHtml("#8833FF");
                rustbutton.OnHovercolor = (rustbuttononhovercolor);
            }

            if (Properties.Settings.Default.themecolor == "Magenta")
            {
                var rustbuttonbackcolor = ColorTranslator.FromHtml("#E0338F");
                rustbutton.BackColor = (rustbuttonbackcolor);
                var rustbuttonnormalcolor = ColorTranslator.FromHtml("#E0338F");
                rustbutton.Normalcolor = (rustbuttonnormalcolor);
                var rustbuttononhovercolor = ColorTranslator.FromHtml("#E0338F");
                rustbutton.OnHovercolor = (rustbuttononhovercolor);
            }

            if (Properties.Settings.Default.themecolor == "Mauve")
            {
                var rustbuttonbackcolor = ColorTranslator.FromHtml("#9180A1");
                rustbutton.BackColor = (rustbuttonbackcolor);
                var rustbuttonnormalcolor = ColorTranslator.FromHtml("#9180A1");
                rustbutton.Normalcolor = (rustbuttonnormalcolor);
                var rustbuttononhovercolor = ColorTranslator.FromHtml("#9180A1");
                rustbutton.OnHovercolor = (rustbuttononhovercolor);
            }

            if (Properties.Settings.Default.themecolor == "Orange")
            {
                var rustbuttonbackcolor = ColorTranslator.FromHtml("#FB8633");
                rustbutton.BackColor = (rustbuttonbackcolor);
                var rustbuttonnormalcolor = ColorTranslator.FromHtml("#FB8633");
                rustbutton.Normalcolor = (rustbuttonnormalcolor);
                var rustbuttononhovercolor = ColorTranslator.FromHtml("#FB8633");
                rustbutton.OnHovercolor = (rustbuttononhovercolor);
            }

            if (Properties.Settings.Default.themecolor == "Pink")
            {
                var rustbuttonbackcolor = ColorTranslator.FromHtml("#F68ED9");
                rustbutton.BackColor = (rustbuttonbackcolor);
                var rustbuttonnormalcolor = ColorTranslator.FromHtml("#F68ED9");
                rustbutton.Normalcolor = (rustbuttonnormalcolor);
                var rustbuttononhovercolor = ColorTranslator.FromHtml("#F68ED9");
                rustbutton.OnHovercolor = (rustbuttononhovercolor);
            }

            if (Properties.Settings.Default.themecolor == "Purple")
            {
                var rustbuttonbackcolor = ColorTranslator.FromHtml("#837AE5");
                rustbutton.BackColor = (rustbuttonbackcolor);
                var rustbuttonnormalcolor = ColorTranslator.FromHtml("#837AE5");
                rustbutton.Normalcolor = (rustbuttonnormalcolor);
                var rustbuttononhovercolor = ColorTranslator.FromHtml("#837AE5");
                rustbutton.OnHovercolor = (rustbuttononhovercolor);
            }

            if (Properties.Settings.Default.themecolor == "Red")
            {
                var rustbuttonbackcolor = ColorTranslator.FromHtml("#EA4333");
                rustbutton.BackColor = (rustbuttonbackcolor);
                var rustbuttonnormalcolor = ColorTranslator.FromHtml("#EA4333");
                rustbutton.Normalcolor = (rustbuttonnormalcolor);
                var rustbuttononhovercolor = ColorTranslator.FromHtml("#EA4333");
                rustbutton.OnHovercolor = (rustbuttononhovercolor);
            }

            if (Properties.Settings.Default.themecolor == "Sienna")
            {
                var rustbuttonbackcolor = ColorTranslator.FromHtml("#B37557");
                rustbutton.BackColor = (rustbuttonbackcolor);
                var rustbuttonnormalcolor = ColorTranslator.FromHtml("#B37557");
                rustbutton.Normalcolor = (rustbuttonnormalcolor);
                var rustbuttononhovercolor = ColorTranslator.FromHtml("#B37557");
                rustbutton.OnHovercolor = (rustbuttononhovercolor);
            }

            if (Properties.Settings.Default.themecolor == "Steel")
            {
                var rustbuttonbackcolor = ColorTranslator.FromHtml("#83919F");
                rustbutton.BackColor = (rustbuttonbackcolor);
                var rustbuttonnormalcolor = ColorTranslator.FromHtml("#83919F");
                rustbutton.Normalcolor = (rustbuttonnormalcolor);
                var rustbuttononhovercolor = ColorTranslator.FromHtml("#83919F");
                rustbutton.OnHovercolor = (rustbuttononhovercolor);
            }

            if (Properties.Settings.Default.themecolor == "Taupe")
            {
                var rustbuttonbackcolor = ColorTranslator.FromHtml("#9F9471");
                rustbutton.BackColor = (rustbuttonbackcolor);
                var rustbuttonnormalcolor = ColorTranslator.FromHtml("#9F9471");
                rustbutton.Normalcolor = (rustbuttonnormalcolor);
                var rustbuttononhovercolor = ColorTranslator.FromHtml("#9F9471");
                rustbutton.OnHovercolor = (rustbuttononhovercolor);
            }

            if (Properties.Settings.Default.themecolor == "Teal")
            {
                var rustbuttonbackcolor = ColorTranslator.FromHtml("#33BCBA");
                rustbutton.BackColor = (rustbuttonbackcolor);
                var rustbuttonnormalcolor = ColorTranslator.FromHtml("#33BCBA");
                rustbutton.Normalcolor = (rustbuttonnormalcolor);
                var rustbuttononhovercolor = ColorTranslator.FromHtml("#33BCBA");
                rustbutton.OnHovercolor = (rustbuttononhovercolor);
            }

        }

        private void rust_Load(object sender, EventArgs e)
        {
            themecolor_Data();
        }
    }
}
