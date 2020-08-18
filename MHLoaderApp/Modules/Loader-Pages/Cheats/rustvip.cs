using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MHLoaderApp.Modules.Loader_Pages.Cheats
{
    public partial class rustvip : UserControl
    {
        public rustvip()
        {
            InitializeComponent();
            themecolor_Data();
        }

        private void themecolor_Data()
        {
            if (Properties.Settings.Default.themecolor == "Blue (Default)")
            {
                var cheatloadbuttonbackcolor = ColorTranslator.FromHtml("#3393DF");
                cheatloadbutton.BackColor = (cheatloadbuttonbackcolor);
                var cheatloadbuttonnormalcolor = ColorTranslator.FromHtml("#3393DF");
                cheatloadbutton.Normalcolor = (cheatloadbuttonnormalcolor);
                var cheatloadbuttononhovercolor = ColorTranslator.FromHtml("#3393DF");
                cheatloadbutton.OnHovercolor = (cheatloadbuttononhovercolor);
            }

            if (Properties.Settings.Default.themecolor == "Brown")
            {
                var cheatloadbuttonbackcolor = ColorTranslator.FromHtml("#9B7B56");
                cheatloadbutton.BackColor = (cheatloadbuttonbackcolor);
                var cheatloadbuttonnormalcolor = ColorTranslator.FromHtml("#9B7B56");
                cheatloadbutton.Normalcolor = (cheatloadbuttonnormalcolor);
                var cheatloadbuttononhovercolor = ColorTranslator.FromHtml("#9B7B56");
                cheatloadbutton.OnHovercolor = (cheatloadbuttononhovercolor);
            }

            if (Properties.Settings.Default.themecolor == "Cobalt")
            {
                var cheatloadbuttonbackcolor = ColorTranslator.FromHtml("#3373F2");
                cheatloadbutton.BackColor = (cheatloadbuttonbackcolor);
                var cheatloadbuttonnormalcolor = ColorTranslator.FromHtml("#3373F2");
                cheatloadbutton.Normalcolor = (cheatloadbuttonnormalcolor);
                var cheatloadbuttononhovercolor = ColorTranslator.FromHtml("#3373F2");
                cheatloadbutton.OnHovercolor = (cheatloadbuttononhovercolor);
            }

            if (Properties.Settings.Default.themecolor == "Crimson")
            {
                var cheatloadbuttonbackcolor = ColorTranslator.FromHtml("#B53351");
                cheatloadbutton.BackColor = (cheatloadbuttonbackcolor);
                var cheatloadbuttonnormalcolor = ColorTranslator.FromHtml("#B53351");
                cheatloadbutton.Normalcolor = (cheatloadbuttonnormalcolor);
                var cheatloadbuttononhovercolor = ColorTranslator.FromHtml("#B53351");
                cheatloadbutton.OnHovercolor = (cheatloadbuttononhovercolor);
            }

            if (Properties.Settings.Default.themecolor == "Cyan")
            {
                var cheatloadbuttonbackcolor = ColorTranslator.FromHtml("#49B4E8");
                cheatloadbutton.BackColor = (cheatloadbuttonbackcolor);
                var cheatloadbuttonnormalcolor = ColorTranslator.FromHtml("#49B4E8");
                cheatloadbutton.Normalcolor = (cheatloadbuttonnormalcolor);
                var cheatloadbuttononhovercolor = ColorTranslator.FromHtml("#49B4E8");
                cheatloadbutton.OnHovercolor = (cheatloadbuttononhovercolor);
            }

            if (Properties.Settings.Default.themecolor == "Dark Gold")
            {
                var cheatloadbuttonbackcolor = ColorTranslator.FromHtml("#BF9B30");
                cheatloadbutton.BackColor = (cheatloadbuttonbackcolor);
                var cheatloadbuttonnormalcolor = ColorTranslator.FromHtml("#BF9B30");
                cheatloadbutton.Normalcolor = (cheatloadbuttonnormalcolor);
                var cheatloadbuttononhovercolor = ColorTranslator.FromHtml("#BF9B30");
                cheatloadbutton.OnHovercolor = (cheatloadbuttononhovercolor);
            }

            if (Properties.Settings.Default.themecolor == "Dark Red")
            {
                var cheatloadbuttonbackcolor = ColorTranslator.FromHtml("#AF1001");
                cheatloadbutton.BackColor = (cheatloadbuttonbackcolor);
                var cheatloadbuttonnormalcolor = ColorTranslator.FromHtml("#AF1001");
                cheatloadbutton.Normalcolor = (cheatloadbuttonnormalcolor);
                var cheatloadbuttononhovercolor = ColorTranslator.FromHtml("#AF1001");
                cheatloadbutton.OnHovercolor = (cheatloadbuttononhovercolor);
            }

            if (Properties.Settings.Default.themecolor == "Emerald")
            {
                var cheatloadbuttonbackcolor = ColorTranslator.FromHtml("#33A133");
                cheatloadbutton.BackColor = (cheatloadbuttonbackcolor);
                var cheatloadbuttonnormalcolor = ColorTranslator.FromHtml("#33A133");
                cheatloadbutton.Normalcolor = (cheatloadbuttonnormalcolor);
                var cheatloadbuttononhovercolor = ColorTranslator.FromHtml("#33A133");
                cheatloadbutton.OnHovercolor = (cheatloadbuttononhovercolor);
            }

            if (Properties.Settings.Default.themecolor == "Green")
            {
                var cheatloadbuttonbackcolor = ColorTranslator.FromHtml("#80BA45");
                cheatloadbutton.BackColor = (cheatloadbuttonbackcolor);
                var cheatloadbuttonnormalcolor = ColorTranslator.FromHtml("#80BA45");
                cheatloadbutton.Normalcolor = (cheatloadbuttonnormalcolor);
                var cheatloadbuttononhovercolor = ColorTranslator.FromHtml("#80BA45");
                cheatloadbutton.OnHovercolor = (cheatloadbuttononhovercolor);
            }

            if (Properties.Settings.Default.themecolor == "Indigo")
            {
                var cheatloadbuttonbackcolor = ColorTranslator.FromHtml("#8833FF");
                cheatloadbutton.BackColor = (cheatloadbuttonbackcolor);
                var cheatloadbuttonnormalcolor = ColorTranslator.FromHtml("#8833FF");
                cheatloadbutton.Normalcolor = (cheatloadbuttonnormalcolor);
                var cheatloadbuttononhovercolor = ColorTranslator.FromHtml("#8833FF");
                cheatloadbutton.OnHovercolor = (cheatloadbuttononhovercolor);
            }

            if (Properties.Settings.Default.themecolor == "Magenta")
            {
                var cheatloadbuttonbackcolor = ColorTranslator.FromHtml("#E0338F");
                cheatloadbutton.BackColor = (cheatloadbuttonbackcolor);
                var cheatloadbuttonnormalcolor = ColorTranslator.FromHtml("#E0338F");
                cheatloadbutton.Normalcolor = (cheatloadbuttonnormalcolor);
                var cheatloadbuttononhovercolor = ColorTranslator.FromHtml("#E0338F");
                cheatloadbutton.OnHovercolor = (cheatloadbuttononhovercolor);
            }

            if (Properties.Settings.Default.themecolor == "Mauve")
            {
                var cheatloadbuttonbackcolor = ColorTranslator.FromHtml("#9180A1");
                cheatloadbutton.BackColor = (cheatloadbuttonbackcolor);
                var cheatloadbuttonnormalcolor = ColorTranslator.FromHtml("#9180A1");
                cheatloadbutton.Normalcolor = (cheatloadbuttonnormalcolor);
                var cheatloadbuttononhovercolor = ColorTranslator.FromHtml("#9180A1");
                cheatloadbutton.OnHovercolor = (cheatloadbuttononhovercolor);
            }

            if (Properties.Settings.Default.themecolor == "Orange")
            {
                var cheatloadbuttonbackcolor = ColorTranslator.FromHtml("#FB8633");
                cheatloadbutton.BackColor = (cheatloadbuttonbackcolor);
                var cheatloadbuttonnormalcolor = ColorTranslator.FromHtml("#FB8633");
                cheatloadbutton.Normalcolor = (cheatloadbuttonnormalcolor);
                var cheatloadbuttononhovercolor = ColorTranslator.FromHtml("#FB8633");
                cheatloadbutton.OnHovercolor = (cheatloadbuttononhovercolor);
            }

            if (Properties.Settings.Default.themecolor == "Pink")
            {
                var cheatloadbuttonbackcolor = ColorTranslator.FromHtml("#F68ED9");
                cheatloadbutton.BackColor = (cheatloadbuttonbackcolor);
                var cheatloadbuttonnormalcolor = ColorTranslator.FromHtml("#F68ED9");
                cheatloadbutton.Normalcolor = (cheatloadbuttonnormalcolor);
                var cheatloadbuttononhovercolor = ColorTranslator.FromHtml("#F68ED9");
                cheatloadbutton.OnHovercolor = (cheatloadbuttononhovercolor);
            }

            if (Properties.Settings.Default.themecolor == "Purple")
            {
                var cheatloadbuttonbackcolor = ColorTranslator.FromHtml("#837AE5");
                cheatloadbutton.BackColor = (cheatloadbuttonbackcolor);
                var cheatloadbuttonnormalcolor = ColorTranslator.FromHtml("#837AE5");
                cheatloadbutton.Normalcolor = (cheatloadbuttonnormalcolor);
                var cheatloadbuttononhovercolor = ColorTranslator.FromHtml("#837AE5");
                cheatloadbutton.OnHovercolor = (cheatloadbuttononhovercolor);
            }

            if (Properties.Settings.Default.themecolor == "Red")
            {
                var cheatloadbuttonbackcolor = ColorTranslator.FromHtml("#EA4333");
                cheatloadbutton.BackColor = (cheatloadbuttonbackcolor);
                var cheatloadbuttonnormalcolor = ColorTranslator.FromHtml("#EA4333");
                cheatloadbutton.Normalcolor = (cheatloadbuttonnormalcolor);
                var cheatloadbuttononhovercolor = ColorTranslator.FromHtml("#EA4333");
                cheatloadbutton.OnHovercolor = (cheatloadbuttononhovercolor);
            }

            if (Properties.Settings.Default.themecolor == "Sienna")
            {
                var cheatloadbuttonbackcolor = ColorTranslator.FromHtml("#B37557");
                cheatloadbutton.BackColor = (cheatloadbuttonbackcolor);
                var cheatloadbuttonnormalcolor = ColorTranslator.FromHtml("#B37557");
                cheatloadbutton.Normalcolor = (cheatloadbuttonnormalcolor);
                var cheatloadbuttononhovercolor = ColorTranslator.FromHtml("#B37557");
                cheatloadbutton.OnHovercolor = (cheatloadbuttononhovercolor);
            }

            if (Properties.Settings.Default.themecolor == "Steel")
            {
                var cheatloadbuttonbackcolor = ColorTranslator.FromHtml("#83919F");
                cheatloadbutton.BackColor = (cheatloadbuttonbackcolor);
                var cheatloadbuttonnormalcolor = ColorTranslator.FromHtml("#83919F");
                cheatloadbutton.Normalcolor = (cheatloadbuttonnormalcolor);
                var cheatloadbuttononhovercolor = ColorTranslator.FromHtml("#83919F");
                cheatloadbutton.OnHovercolor = (cheatloadbuttononhovercolor);
            }

            if (Properties.Settings.Default.themecolor == "Taupe")
            {
                var cheatloadbuttonbackcolor = ColorTranslator.FromHtml("#9F9471");
                cheatloadbutton.BackColor = (cheatloadbuttonbackcolor);
                var cheatloadbuttonnormalcolor = ColorTranslator.FromHtml("#9F9471");
                cheatloadbutton.Normalcolor = (cheatloadbuttonnormalcolor);
                var cheatloadbuttononhovercolor = ColorTranslator.FromHtml("#9F9471");
                cheatloadbutton.OnHovercolor = (cheatloadbuttononhovercolor);
            }

            if (Properties.Settings.Default.themecolor == "Teal")
            {
                var cheatloadbuttonbackcolor = ColorTranslator.FromHtml("#33BCBA");
                cheatloadbutton.BackColor = (cheatloadbuttonbackcolor);
                var cheatloadbuttonnormalcolor = ColorTranslator.FromHtml("#33BCBA");
                cheatloadbutton.Normalcolor = (cheatloadbuttonnormalcolor);
                var cheatloadbuttononhovercolor = ColorTranslator.FromHtml("#33BCBA");
                cheatloadbutton.OnHovercolor = (cheatloadbuttononhovercolor);
            }

        }

        private void rustvip_Load(object sender, EventArgs e)
        {
            themecolor_Data();
        }
    }
}
