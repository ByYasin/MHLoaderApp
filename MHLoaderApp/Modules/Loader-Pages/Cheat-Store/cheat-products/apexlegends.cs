using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MHLoaderApp.Modules.Loader_Pages.Cheat_Store.cheats
{
    public partial class apexlegends : UserControl
    {
        public apexlegends()
        {
            InitializeComponent();
            themecolor_Data();
        }

        private void themecolor_Data()
        {
            if (Properties.Settings.Default.themecolor == "Blue (Default)")
            {
                var apexlegendsbuttonbackcolor = ColorTranslator.FromHtml("#3393DF");
                apexlegendsbutton.BackColor = (apexlegendsbuttonbackcolor);
                var apexlegendsbuttonnormalcolor = ColorTranslator.FromHtml("#3393DF");
                apexlegendsbutton.Normalcolor = (apexlegendsbuttonnormalcolor);
                var apexlegendsbuttononhovercolor = ColorTranslator.FromHtml("#3393DF");
                apexlegendsbutton.OnHovercolor = (apexlegendsbuttononhovercolor);
            }

            if (Properties.Settings.Default.themecolor == "Brown")
            {
                var apexlegendsbuttonbackcolor = ColorTranslator.FromHtml("#9B7B56");
                apexlegendsbutton.BackColor = (apexlegendsbuttonbackcolor);
                var apexlegendsbuttonnormalcolor = ColorTranslator.FromHtml("#9B7B56");
                apexlegendsbutton.Normalcolor = (apexlegendsbuttonnormalcolor);
                var apexlegendsbuttononhovercolor = ColorTranslator.FromHtml("#9B7B56");
                apexlegendsbutton.OnHovercolor = (apexlegendsbuttononhovercolor);
            }

            if (Properties.Settings.Default.themecolor == "Cobalt")
            {
                var apexlegendsbuttonbackcolor = ColorTranslator.FromHtml("#3373F2");
                apexlegendsbutton.BackColor = (apexlegendsbuttonbackcolor);
                var apexlegendsbuttonnormalcolor = ColorTranslator.FromHtml("#3373F2");
                apexlegendsbutton.Normalcolor = (apexlegendsbuttonnormalcolor);
                var apexlegendsbuttononhovercolor = ColorTranslator.FromHtml("#3373F2");
                apexlegendsbutton.OnHovercolor = (apexlegendsbuttononhovercolor);
            }

            if (Properties.Settings.Default.themecolor == "Crimson")
            {
                var apexlegendsbuttonbackcolor = ColorTranslator.FromHtml("#B53351");
                apexlegendsbutton.BackColor = (apexlegendsbuttonbackcolor);
                var apexlegendsbuttonnormalcolor = ColorTranslator.FromHtml("#B53351");
                apexlegendsbutton.Normalcolor = (apexlegendsbuttonnormalcolor);
                var apexlegendsbuttononhovercolor = ColorTranslator.FromHtml("#B53351");
                apexlegendsbutton.OnHovercolor = (apexlegendsbuttononhovercolor);
            }

            if (Properties.Settings.Default.themecolor == "Cyan")
            {
                var apexlegendsbuttonbackcolor = ColorTranslator.FromHtml("#49B4E8");
                apexlegendsbutton.BackColor = (apexlegendsbuttonbackcolor);
                var apexlegendsbuttonnormalcolor = ColorTranslator.FromHtml("#49B4E8");
                apexlegendsbutton.Normalcolor = (apexlegendsbuttonnormalcolor);
                var apexlegendsbuttononhovercolor = ColorTranslator.FromHtml("#49B4E8");
                apexlegendsbutton.OnHovercolor = (apexlegendsbuttononhovercolor);
            }

            if (Properties.Settings.Default.themecolor == "Dark Gold")
            {
                var apexlegendsbuttonbackcolor = ColorTranslator.FromHtml("#BF9B30");
                apexlegendsbutton.BackColor = (apexlegendsbuttonbackcolor);
                var apexlegendsbuttonnormalcolor = ColorTranslator.FromHtml("#BF9B30");
                apexlegendsbutton.Normalcolor = (apexlegendsbuttonnormalcolor);
                var apexlegendsbuttononhovercolor = ColorTranslator.FromHtml("#BF9B30");
                apexlegendsbutton.OnHovercolor = (apexlegendsbuttononhovercolor);
            }

            if (Properties.Settings.Default.themecolor == "Dark Red")
            {
                var apexlegendsbuttonbackcolor = ColorTranslator.FromHtml("#AF1001");
                apexlegendsbutton.BackColor = (apexlegendsbuttonbackcolor);
                var apexlegendsbuttonnormalcolor = ColorTranslator.FromHtml("#AF1001");
                apexlegendsbutton.Normalcolor = (apexlegendsbuttonnormalcolor);
                var apexlegendsbuttononhovercolor = ColorTranslator.FromHtml("#AF1001");
                apexlegendsbutton.OnHovercolor = (apexlegendsbuttononhovercolor);
            }

            if (Properties.Settings.Default.themecolor == "Emerald")
            {
                var apexlegendsbuttonbackcolor = ColorTranslator.FromHtml("#33A133");
                apexlegendsbutton.BackColor = (apexlegendsbuttonbackcolor);
                var apexlegendsbuttonnormalcolor = ColorTranslator.FromHtml("#33A133");
                apexlegendsbutton.Normalcolor = (apexlegendsbuttonnormalcolor);
                var apexlegendsbuttononhovercolor = ColorTranslator.FromHtml("#33A133");
                apexlegendsbutton.OnHovercolor = (apexlegendsbuttononhovercolor);
            }

            if (Properties.Settings.Default.themecolor == "Green")
            {
                var apexlegendsbuttonbackcolor = ColorTranslator.FromHtml("#80BA45");
                apexlegendsbutton.BackColor = (apexlegendsbuttonbackcolor);
                var apexlegendsbuttonnormalcolor = ColorTranslator.FromHtml("#80BA45");
                apexlegendsbutton.Normalcolor = (apexlegendsbuttonnormalcolor);
                var apexlegendsbuttononhovercolor = ColorTranslator.FromHtml("#80BA45");
                apexlegendsbutton.OnHovercolor = (apexlegendsbuttononhovercolor);
            }

            if (Properties.Settings.Default.themecolor == "Indigo")
            {
                var apexlegendsbuttonbackcolor = ColorTranslator.FromHtml("#8833FF");
                apexlegendsbutton.BackColor = (apexlegendsbuttonbackcolor);
                var apexlegendsbuttonnormalcolor = ColorTranslator.FromHtml("#8833FF");
                apexlegendsbutton.Normalcolor = (apexlegendsbuttonnormalcolor);
                var apexlegendsbuttononhovercolor = ColorTranslator.FromHtml("#8833FF");
                apexlegendsbutton.OnHovercolor = (apexlegendsbuttononhovercolor);
            }

            if (Properties.Settings.Default.themecolor == "Magenta")
            {
                var apexlegendsbuttonbackcolor = ColorTranslator.FromHtml("#E0338F");
                apexlegendsbutton.BackColor = (apexlegendsbuttonbackcolor);
                var apexlegendsbuttonnormalcolor = ColorTranslator.FromHtml("#E0338F");
                apexlegendsbutton.Normalcolor = (apexlegendsbuttonnormalcolor);
                var apexlegendsbuttononhovercolor = ColorTranslator.FromHtml("#E0338F");
                apexlegendsbutton.OnHovercolor = (apexlegendsbuttononhovercolor);
            }

            if (Properties.Settings.Default.themecolor == "Mauve")
            {
                var apexlegendsbuttonbackcolor = ColorTranslator.FromHtml("#9180A1");
                apexlegendsbutton.BackColor = (apexlegendsbuttonbackcolor);
                var apexlegendsbuttonnormalcolor = ColorTranslator.FromHtml("#9180A1");
                apexlegendsbutton.Normalcolor = (apexlegendsbuttonnormalcolor);
                var apexlegendsbuttononhovercolor = ColorTranslator.FromHtml("#9180A1");
                apexlegendsbutton.OnHovercolor = (apexlegendsbuttononhovercolor);
            }

            if (Properties.Settings.Default.themecolor == "Orange")
            {
                var apexlegendsbuttonbackcolor = ColorTranslator.FromHtml("#FB8633");
                apexlegendsbutton.BackColor = (apexlegendsbuttonbackcolor);
                var apexlegendsbuttonnormalcolor = ColorTranslator.FromHtml("#FB8633");
                apexlegendsbutton.Normalcolor = (apexlegendsbuttonnormalcolor);
                var apexlegendsbuttononhovercolor = ColorTranslator.FromHtml("#FB8633");
                apexlegendsbutton.OnHovercolor = (apexlegendsbuttononhovercolor);
            }

            if (Properties.Settings.Default.themecolor == "Pink")
            {
                var apexlegendsbuttonbackcolor = ColorTranslator.FromHtml("#F68ED9");
                apexlegendsbutton.BackColor = (apexlegendsbuttonbackcolor);
                var apexlegendsbuttonnormalcolor = ColorTranslator.FromHtml("#F68ED9");
                apexlegendsbutton.Normalcolor = (apexlegendsbuttonnormalcolor);
                var apexlegendsbuttononhovercolor = ColorTranslator.FromHtml("#F68ED9");
                apexlegendsbutton.OnHovercolor = (apexlegendsbuttononhovercolor);
            }

            if (Properties.Settings.Default.themecolor == "Purple")
            {
                var apexlegendsbuttonbackcolor = ColorTranslator.FromHtml("#837AE5");
                apexlegendsbutton.BackColor = (apexlegendsbuttonbackcolor);
                var apexlegendsbuttonnormalcolor = ColorTranslator.FromHtml("#837AE5");
                apexlegendsbutton.Normalcolor = (apexlegendsbuttonnormalcolor);
                var apexlegendsbuttononhovercolor = ColorTranslator.FromHtml("#837AE5");
                apexlegendsbutton.OnHovercolor = (apexlegendsbuttononhovercolor);
            }

            if (Properties.Settings.Default.themecolor == "Red")
            {
                var apexlegendsbuttonbackcolor = ColorTranslator.FromHtml("#EA4333");
                apexlegendsbutton.BackColor = (apexlegendsbuttonbackcolor);
                var apexlegendsbuttonnormalcolor = ColorTranslator.FromHtml("#EA4333");
                apexlegendsbutton.Normalcolor = (apexlegendsbuttonnormalcolor);
                var apexlegendsbuttononhovercolor = ColorTranslator.FromHtml("#EA4333");
                apexlegendsbutton.OnHovercolor = (apexlegendsbuttononhovercolor);
            }

            if (Properties.Settings.Default.themecolor == "Sienna")
            {
                var apexlegendsbuttonbackcolor = ColorTranslator.FromHtml("#B37557");
                apexlegendsbutton.BackColor = (apexlegendsbuttonbackcolor);
                var apexlegendsbuttonnormalcolor = ColorTranslator.FromHtml("#B37557");
                apexlegendsbutton.Normalcolor = (apexlegendsbuttonnormalcolor);
                var apexlegendsbuttononhovercolor = ColorTranslator.FromHtml("#B37557");
                apexlegendsbutton.OnHovercolor = (apexlegendsbuttononhovercolor);
            }

            if (Properties.Settings.Default.themecolor == "Steel")
            {
                var apexlegendsbuttonbackcolor = ColorTranslator.FromHtml("#83919F");
                apexlegendsbutton.BackColor = (apexlegendsbuttonbackcolor);
                var apexlegendsbuttonnormalcolor = ColorTranslator.FromHtml("#83919F");
                apexlegendsbutton.Normalcolor = (apexlegendsbuttonnormalcolor);
                var apexlegendsbuttononhovercolor = ColorTranslator.FromHtml("#83919F");
                apexlegendsbutton.OnHovercolor = (apexlegendsbuttononhovercolor);
            }

            if (Properties.Settings.Default.themecolor == "Taupe")
            {
                var apexlegendsbuttonbackcolor = ColorTranslator.FromHtml("#9F9471");
                apexlegendsbutton.BackColor = (apexlegendsbuttonbackcolor);
                var apexlegendsbuttonnormalcolor = ColorTranslator.FromHtml("#9F9471");
                apexlegendsbutton.Normalcolor = (apexlegendsbuttonnormalcolor);
                var apexlegendsbuttononhovercolor = ColorTranslator.FromHtml("#9F9471");
                apexlegendsbutton.OnHovercolor = (apexlegendsbuttononhovercolor);
            }

            if (Properties.Settings.Default.themecolor == "Teal")
            {
                var apexlegendsbuttonbackcolor = ColorTranslator.FromHtml("#33BCBA");
                apexlegendsbutton.BackColor = (apexlegendsbuttonbackcolor);
                var apexlegendsbuttonnormalcolor = ColorTranslator.FromHtml("#33BCBA");
                apexlegendsbutton.Normalcolor = (apexlegendsbuttonnormalcolor);
                var apexlegendsbuttononhovercolor = ColorTranslator.FromHtml("#33BCBA");
                apexlegendsbutton.OnHovercolor = (apexlegendsbuttononhovercolor);
            }

        }

        private void apexlegends_Load(object sender, EventArgs e)
        {
            themecolor_Data();
        }
    }
}
