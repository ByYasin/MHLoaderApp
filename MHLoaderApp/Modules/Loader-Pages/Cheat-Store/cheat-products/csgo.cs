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
    public partial class csgo : UserControl
    {
        public csgo()
        {
            InitializeComponent();
            themecolor_Data();
        }

        private void themecolor_Data()
        {
            if (Properties.Settings.Default.themecolor == "Blue (Default)")
            {
                var csgobuttonbackcolor = ColorTranslator.FromHtml("#3393DF");
                csgobutton.BackColor = (csgobuttonbackcolor);
                var csgobuttonnormalcolor = ColorTranslator.FromHtml("#3393DF");
                csgobutton.Normalcolor = (csgobuttonnormalcolor);
                var csgobuttononhovercolor = ColorTranslator.FromHtml("#3393DF");
                csgobutton.OnHovercolor = (csgobuttononhovercolor);
            }

            if (Properties.Settings.Default.themecolor == "Brown")
            {
                var csgobuttonbackcolor = ColorTranslator.FromHtml("#9B7B56");
                csgobutton.BackColor = (csgobuttonbackcolor);
                var csgobuttonnormalcolor = ColorTranslator.FromHtml("#9B7B56");
                csgobutton.Normalcolor = (csgobuttonnormalcolor);
                var csgobuttononhovercolor = ColorTranslator.FromHtml("#9B7B56");
                csgobutton.OnHovercolor = (csgobuttononhovercolor);
            }

            if (Properties.Settings.Default.themecolor == "Cobalt")
            {
                var csgobuttonbackcolor = ColorTranslator.FromHtml("#3373F2");
                csgobutton.BackColor = (csgobuttonbackcolor);
                var csgobuttonnormalcolor = ColorTranslator.FromHtml("#3373F2");
                csgobutton.Normalcolor = (csgobuttonnormalcolor);
                var csgobuttononhovercolor = ColorTranslator.FromHtml("#3373F2");
                csgobutton.OnHovercolor = (csgobuttononhovercolor);
            }

            if (Properties.Settings.Default.themecolor == "Crimson")
            {
                var csgobuttonbackcolor = ColorTranslator.FromHtml("#B53351");
                csgobutton.BackColor = (csgobuttonbackcolor);
                var csgobuttonnormalcolor = ColorTranslator.FromHtml("#B53351");
                csgobutton.Normalcolor = (csgobuttonnormalcolor);
                var csgobuttononhovercolor = ColorTranslator.FromHtml("#B53351");
                csgobutton.OnHovercolor = (csgobuttononhovercolor);
            }

            if (Properties.Settings.Default.themecolor == "Cyan")
            {
                var csgobuttonbackcolor = ColorTranslator.FromHtml("#49B4E8");
                csgobutton.BackColor = (csgobuttonbackcolor);
                var csgobuttonnormalcolor = ColorTranslator.FromHtml("#49B4E8");
                csgobutton.Normalcolor = (csgobuttonnormalcolor);
                var csgobuttononhovercolor = ColorTranslator.FromHtml("#49B4E8");
                csgobutton.OnHovercolor = (csgobuttononhovercolor);
            }

            if (Properties.Settings.Default.themecolor == "Dark Gold")
            {
                var csgobuttonbackcolor = ColorTranslator.FromHtml("#BF9B30");
                csgobutton.BackColor = (csgobuttonbackcolor);
                var csgobuttonnormalcolor = ColorTranslator.FromHtml("#BF9B30");
                csgobutton.Normalcolor = (csgobuttonnormalcolor);
                var csgobuttononhovercolor = ColorTranslator.FromHtml("#BF9B30");
                csgobutton.OnHovercolor = (csgobuttononhovercolor);
            }

            if (Properties.Settings.Default.themecolor == "Dark Red")
            {
                var csgobuttonbackcolor = ColorTranslator.FromHtml("#AF1001");
                csgobutton.BackColor = (csgobuttonbackcolor);
                var csgobuttonnormalcolor = ColorTranslator.FromHtml("#AF1001");
                csgobutton.Normalcolor = (csgobuttonnormalcolor);
                var csgobuttononhovercolor = ColorTranslator.FromHtml("#AF1001");
                csgobutton.OnHovercolor = (csgobuttononhovercolor);
            }

            if (Properties.Settings.Default.themecolor == "Emerald")
            {
                var csgobuttonbackcolor = ColorTranslator.FromHtml("#33A133");
                csgobutton.BackColor = (csgobuttonbackcolor);
                var csgobuttonnormalcolor = ColorTranslator.FromHtml("#33A133");
                csgobutton.Normalcolor = (csgobuttonnormalcolor);
                var csgobuttononhovercolor = ColorTranslator.FromHtml("#33A133");
                csgobutton.OnHovercolor = (csgobuttononhovercolor);
            }

            if (Properties.Settings.Default.themecolor == "Green")
            {
                var csgobuttonbackcolor = ColorTranslator.FromHtml("#80BA45");
                csgobutton.BackColor = (csgobuttonbackcolor);
                var csgobuttonnormalcolor = ColorTranslator.FromHtml("#80BA45");
                csgobutton.Normalcolor = (csgobuttonnormalcolor);
                var csgobuttononhovercolor = ColorTranslator.FromHtml("#80BA45");
                csgobutton.OnHovercolor = (csgobuttononhovercolor);
            }

            if (Properties.Settings.Default.themecolor == "Indigo")
            {
                var csgobuttonbackcolor = ColorTranslator.FromHtml("#8833FF");
                csgobutton.BackColor = (csgobuttonbackcolor);
                var csgobuttonnormalcolor = ColorTranslator.FromHtml("#8833FF");
                csgobutton.Normalcolor = (csgobuttonnormalcolor);
                var csgobuttononhovercolor = ColorTranslator.FromHtml("#8833FF");
                csgobutton.OnHovercolor = (csgobuttononhovercolor);
            }

            if (Properties.Settings.Default.themecolor == "Magenta")
            {
                var csgobuttonbackcolor = ColorTranslator.FromHtml("#E0338F");
                csgobutton.BackColor = (csgobuttonbackcolor);
                var csgobuttonnormalcolor = ColorTranslator.FromHtml("#E0338F");
                csgobutton.Normalcolor = (csgobuttonnormalcolor);
                var csgobuttononhovercolor = ColorTranslator.FromHtml("#E0338F");
                csgobutton.OnHovercolor = (csgobuttononhovercolor);
            }

            if (Properties.Settings.Default.themecolor == "Mauve")
            {
                var csgobuttonbackcolor = ColorTranslator.FromHtml("#9180A1");
                csgobutton.BackColor = (csgobuttonbackcolor);
                var csgobuttonnormalcolor = ColorTranslator.FromHtml("#9180A1");
                csgobutton.Normalcolor = (csgobuttonnormalcolor);
                var csgobuttononhovercolor = ColorTranslator.FromHtml("#9180A1");
                csgobutton.OnHovercolor = (csgobuttononhovercolor);
            }

            if (Properties.Settings.Default.themecolor == "Orange")
            {
                var csgobuttonbackcolor = ColorTranslator.FromHtml("#FB8633");
                csgobutton.BackColor = (csgobuttonbackcolor);
                var csgobuttonnormalcolor = ColorTranslator.FromHtml("#FB8633");
                csgobutton.Normalcolor = (csgobuttonnormalcolor);
                var csgobuttononhovercolor = ColorTranslator.FromHtml("#FB8633");
                csgobutton.OnHovercolor = (csgobuttononhovercolor);
            }

            if (Properties.Settings.Default.themecolor == "Pink")
            {
                var csgobuttonbackcolor = ColorTranslator.FromHtml("#F68ED9");
                csgobutton.BackColor = (csgobuttonbackcolor);
                var csgobuttonnormalcolor = ColorTranslator.FromHtml("#F68ED9");
                csgobutton.Normalcolor = (csgobuttonnormalcolor);
                var csgobuttononhovercolor = ColorTranslator.FromHtml("#F68ED9");
                csgobutton.OnHovercolor = (csgobuttononhovercolor);
            }

            if (Properties.Settings.Default.themecolor == "Purple")
            {
                var csgobuttonbackcolor = ColorTranslator.FromHtml("#837AE5");
                csgobutton.BackColor = (csgobuttonbackcolor);
                var csgobuttonnormalcolor = ColorTranslator.FromHtml("#837AE5");
                csgobutton.Normalcolor = (csgobuttonnormalcolor);
                var csgobuttononhovercolor = ColorTranslator.FromHtml("#837AE5");
                csgobutton.OnHovercolor = (csgobuttononhovercolor);
            }

            if (Properties.Settings.Default.themecolor == "Red")
            {
                var csgobuttonbackcolor = ColorTranslator.FromHtml("#EA4333");
                csgobutton.BackColor = (csgobuttonbackcolor);
                var csgobuttonnormalcolor = ColorTranslator.FromHtml("#EA4333");
                csgobutton.Normalcolor = (csgobuttonnormalcolor);
                var csgobuttononhovercolor = ColorTranslator.FromHtml("#EA4333");
                csgobutton.OnHovercolor = (csgobuttononhovercolor);
            }

            if (Properties.Settings.Default.themecolor == "Sienna")
            {
                var csgobuttonbackcolor = ColorTranslator.FromHtml("#B37557");
                csgobutton.BackColor = (csgobuttonbackcolor);
                var csgobuttonnormalcolor = ColorTranslator.FromHtml("#B37557");
                csgobutton.Normalcolor = (csgobuttonnormalcolor);
                var csgobuttononhovercolor = ColorTranslator.FromHtml("#B37557");
                csgobutton.OnHovercolor = (csgobuttononhovercolor);
            }

            if (Properties.Settings.Default.themecolor == "Steel")
            {
                var csgobuttonbackcolor = ColorTranslator.FromHtml("#83919F");
                csgobutton.BackColor = (csgobuttonbackcolor);
                var csgobuttonnormalcolor = ColorTranslator.FromHtml("#83919F");
                csgobutton.Normalcolor = (csgobuttonnormalcolor);
                var csgobuttononhovercolor = ColorTranslator.FromHtml("#83919F");
                csgobutton.OnHovercolor = (csgobuttononhovercolor);
            }

            if (Properties.Settings.Default.themecolor == "Taupe")
            {
                var csgobuttonbackcolor = ColorTranslator.FromHtml("#9F9471");
                csgobutton.BackColor = (csgobuttonbackcolor);
                var csgobuttonnormalcolor = ColorTranslator.FromHtml("#9F9471");
                csgobutton.Normalcolor = (csgobuttonnormalcolor);
                var csgobuttononhovercolor = ColorTranslator.FromHtml("#9F9471");
                csgobutton.OnHovercolor = (csgobuttononhovercolor);
            }

            if (Properties.Settings.Default.themecolor == "Teal")
            {
                var csgobuttonbackcolor = ColorTranslator.FromHtml("#33BCBA");
                csgobutton.BackColor = (csgobuttonbackcolor);
                var csgobuttonnormalcolor = ColorTranslator.FromHtml("#33BCBA");
                csgobutton.Normalcolor = (csgobuttonnormalcolor);
                var csgobuttononhovercolor = ColorTranslator.FromHtml("#33BCBA");
                csgobutton.OnHovercolor = (csgobuttononhovercolor);
            }

        }

        private void csgo_Load(object sender, EventArgs e)
        {
            themecolor_Data();
        }
    }
}
