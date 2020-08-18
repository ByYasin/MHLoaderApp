using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MHLoaderApp.Modules.Loader_Pages
{
    public partial class mylicence : UserControl
    {
        public mylicence()
        {
            InitializeComponent();
            themecolor_Data();
        }

        private void themecolor_Data()
        {
            if (Properties.Settings.Default.themecolor == "Blue (Default)")
            {
                var hwidresetbuttonbackcolor = ColorTranslator.FromHtml("#3393DF");
                hwidresetbutton.BackColor = (hwidresetbuttonbackcolor);
                var hwidresetbuttonnormalcolor = ColorTranslator.FromHtml("#3393DF");
                hwidresetbutton.Normalcolor = (hwidresetbuttonnormalcolor);
                var hwidresetbuttononhovercolor = ColorTranslator.FromHtml("#3393DF");
                hwidresetbutton.OnHovercolor = (hwidresetbuttononhovercolor);
            }

            if (Properties.Settings.Default.themecolor == "Brown")
            {
                var hwidresetbuttonbackcolor = ColorTranslator.FromHtml("#9B7B56");
                hwidresetbutton.BackColor = (hwidresetbuttonbackcolor);
                var hwidresetbuttonnormalcolor = ColorTranslator.FromHtml("#9B7B56");
                hwidresetbutton.Normalcolor = (hwidresetbuttonnormalcolor);
                var hwidresetbuttononhovercolor = ColorTranslator.FromHtml("#9B7B56");
                hwidresetbutton.OnHovercolor = (hwidresetbuttononhovercolor);
            }

            if (Properties.Settings.Default.themecolor == "Cobalt")
            {
                var hwidresetbuttonbackcolor = ColorTranslator.FromHtml("#3373F2");
                hwidresetbutton.BackColor = (hwidresetbuttonbackcolor);
                var hwidresetbuttonnormalcolor = ColorTranslator.FromHtml("#3373F2");
                hwidresetbutton.Normalcolor = (hwidresetbuttonnormalcolor);
                var hwidresetbuttononhovercolor = ColorTranslator.FromHtml("#3373F2");
                hwidresetbutton.OnHovercolor = (hwidresetbuttononhovercolor);
            }

            if (Properties.Settings.Default.themecolor == "Crimson")
            {
                var hwidresetbuttonbackcolor = ColorTranslator.FromHtml("#B53351");
                hwidresetbutton.BackColor = (hwidresetbuttonbackcolor);
                var hwidresetbuttonnormalcolor = ColorTranslator.FromHtml("#B53351");
                hwidresetbutton.Normalcolor = (hwidresetbuttonnormalcolor);
                var hwidresetbuttononhovercolor = ColorTranslator.FromHtml("#B53351");
                hwidresetbutton.OnHovercolor = (hwidresetbuttononhovercolor);
            }

            if (Properties.Settings.Default.themecolor == "Cyan")
            {
                var hwidresetbuttonbackcolor = ColorTranslator.FromHtml("#49B4E8");
                hwidresetbutton.BackColor = (hwidresetbuttonbackcolor);
                var hwidresetbuttonnormalcolor = ColorTranslator.FromHtml("#49B4E8");
                hwidresetbutton.Normalcolor = (hwidresetbuttonnormalcolor);
                var hwidresetbuttononhovercolor = ColorTranslator.FromHtml("#49B4E8");
                hwidresetbutton.OnHovercolor = (hwidresetbuttononhovercolor);
            }

            if (Properties.Settings.Default.themecolor == "Dark Gold")
            {
                var hwidresetbuttonbackcolor = ColorTranslator.FromHtml("#BF9B30");
                hwidresetbutton.BackColor = (hwidresetbuttonbackcolor);
                var hwidresetbuttonnormalcolor = ColorTranslator.FromHtml("#BF9B30");
                hwidresetbutton.Normalcolor = (hwidresetbuttonnormalcolor);
                var hwidresetbuttononhovercolor = ColorTranslator.FromHtml("#BF9B30");
                hwidresetbutton.OnHovercolor = (hwidresetbuttononhovercolor);
            }

            if (Properties.Settings.Default.themecolor == "Dark Red")
            {
                var hwidresetbuttonbackcolor = ColorTranslator.FromHtml("#AF1001");
                hwidresetbutton.BackColor = (hwidresetbuttonbackcolor);
                var hwidresetbuttonnormalcolor = ColorTranslator.FromHtml("#AF1001");
                hwidresetbutton.Normalcolor = (hwidresetbuttonnormalcolor);
                var hwidresetbuttononhovercolor = ColorTranslator.FromHtml("#AF1001");
                hwidresetbutton.OnHovercolor = (hwidresetbuttononhovercolor);
            }

            if (Properties.Settings.Default.themecolor == "Emerald")
            {
                var hwidresetbuttonbackcolor = ColorTranslator.FromHtml("#33A133");
                hwidresetbutton.BackColor = (hwidresetbuttonbackcolor);
                var hwidresetbuttonnormalcolor = ColorTranslator.FromHtml("#33A133");
                hwidresetbutton.Normalcolor = (hwidresetbuttonnormalcolor);
                var hwidresetbuttononhovercolor = ColorTranslator.FromHtml("#33A133");
                hwidresetbutton.OnHovercolor = (hwidresetbuttononhovercolor);
            }

            if (Properties.Settings.Default.themecolor == "Green")
            {
                var hwidresetbuttonbackcolor = ColorTranslator.FromHtml("#80BA45");
                hwidresetbutton.BackColor = (hwidresetbuttonbackcolor);
                var hwidresetbuttonnormalcolor = ColorTranslator.FromHtml("#80BA45");
                hwidresetbutton.Normalcolor = (hwidresetbuttonnormalcolor);
                var hwidresetbuttononhovercolor = ColorTranslator.FromHtml("#80BA45");
                hwidresetbutton.OnHovercolor = (hwidresetbuttononhovercolor);
            }

            if (Properties.Settings.Default.themecolor == "Indigo")
            {
                var hwidresetbuttonbackcolor = ColorTranslator.FromHtml("#8833FF");
                hwidresetbutton.BackColor = (hwidresetbuttonbackcolor);
                var hwidresetbuttonnormalcolor = ColorTranslator.FromHtml("#8833FF");
                hwidresetbutton.Normalcolor = (hwidresetbuttonnormalcolor);
                var hwidresetbuttononhovercolor = ColorTranslator.FromHtml("#8833FF");
                hwidresetbutton.OnHovercolor = (hwidresetbuttononhovercolor);
            }

            if (Properties.Settings.Default.themecolor == "Magenta")
            {
                var hwidresetbuttonbackcolor = ColorTranslator.FromHtml("#E0338F");
                hwidresetbutton.BackColor = (hwidresetbuttonbackcolor);
                var hwidresetbuttonnormalcolor = ColorTranslator.FromHtml("#E0338F");
                hwidresetbutton.Normalcolor = (hwidresetbuttonnormalcolor);
                var hwidresetbuttononhovercolor = ColorTranslator.FromHtml("#E0338F");
                hwidresetbutton.OnHovercolor = (hwidresetbuttononhovercolor);
            }

            if (Properties.Settings.Default.themecolor == "Mauve")
            {
                var hwidresetbuttonbackcolor = ColorTranslator.FromHtml("#9180A1");
                hwidresetbutton.BackColor = (hwidresetbuttonbackcolor);
                var hwidresetbuttonnormalcolor = ColorTranslator.FromHtml("#9180A1");
                hwidresetbutton.Normalcolor = (hwidresetbuttonnormalcolor);
                var hwidresetbuttononhovercolor = ColorTranslator.FromHtml("#9180A1");
                hwidresetbutton.OnHovercolor = (hwidresetbuttononhovercolor);
            }

            if (Properties.Settings.Default.themecolor == "Orange")
            {
                var hwidresetbuttonbackcolor = ColorTranslator.FromHtml("#FB8633");
                hwidresetbutton.BackColor = (hwidresetbuttonbackcolor);
                var hwidresetbuttonnormalcolor = ColorTranslator.FromHtml("#FB8633");
                hwidresetbutton.Normalcolor = (hwidresetbuttonnormalcolor);
                var hwidresetbuttononhovercolor = ColorTranslator.FromHtml("#FB8633");
                hwidresetbutton.OnHovercolor = (hwidresetbuttononhovercolor);
            }

            if (Properties.Settings.Default.themecolor == "Pink")
            {
                var hwidresetbuttonbackcolor = ColorTranslator.FromHtml("#F68ED9");
                hwidresetbutton.BackColor = (hwidresetbuttonbackcolor);
                var hwidresetbuttonnormalcolor = ColorTranslator.FromHtml("#F68ED9");
                hwidresetbutton.Normalcolor = (hwidresetbuttonnormalcolor);
                var hwidresetbuttononhovercolor = ColorTranslator.FromHtml("#F68ED9");
                hwidresetbutton.OnHovercolor = (hwidresetbuttononhovercolor);
            }

            if (Properties.Settings.Default.themecolor == "Purple")
            {
                var hwidresetbuttonbackcolor = ColorTranslator.FromHtml("#837AE5");
                hwidresetbutton.BackColor = (hwidresetbuttonbackcolor);
                var hwidresetbuttonnormalcolor = ColorTranslator.FromHtml("#837AE5");
                hwidresetbutton.Normalcolor = (hwidresetbuttonnormalcolor);
                var hwidresetbuttononhovercolor = ColorTranslator.FromHtml("#837AE5");
                hwidresetbutton.OnHovercolor = (hwidresetbuttononhovercolor);
            }

            if (Properties.Settings.Default.themecolor == "Red")
            {
                var hwidresetbuttonbackcolor = ColorTranslator.FromHtml("#EA4333");
                hwidresetbutton.BackColor = (hwidresetbuttonbackcolor);
                var hwidresetbuttonnormalcolor = ColorTranslator.FromHtml("#EA4333");
                hwidresetbutton.Normalcolor = (hwidresetbuttonnormalcolor);
                var hwidresetbuttononhovercolor = ColorTranslator.FromHtml("#EA4333");
                hwidresetbutton.OnHovercolor = (hwidresetbuttononhovercolor);
            }

            if (Properties.Settings.Default.themecolor == "Sienna")
            {
                var hwidresetbuttonbackcolor = ColorTranslator.FromHtml("#B37557");
                hwidresetbutton.BackColor = (hwidresetbuttonbackcolor);
                var hwidresetbuttonnormalcolor = ColorTranslator.FromHtml("#B37557");
                hwidresetbutton.Normalcolor = (hwidresetbuttonnormalcolor);
                var hwidresetbuttononhovercolor = ColorTranslator.FromHtml("#B37557");
                hwidresetbutton.OnHovercolor = (hwidresetbuttononhovercolor);
            }

            if (Properties.Settings.Default.themecolor == "Steel")
            {
                var hwidresetbuttonbackcolor = ColorTranslator.FromHtml("#83919F");
                hwidresetbutton.BackColor = (hwidresetbuttonbackcolor);
                var hwidresetbuttonnormalcolor = ColorTranslator.FromHtml("#83919F");
                hwidresetbutton.Normalcolor = (hwidresetbuttonnormalcolor);
                var hwidresetbuttononhovercolor = ColorTranslator.FromHtml("#83919F");
                hwidresetbutton.OnHovercolor = (hwidresetbuttononhovercolor);
            }

            if (Properties.Settings.Default.themecolor == "Taupe")
            {
                var hwidresetbuttonbackcolor = ColorTranslator.FromHtml("#9F9471");
                hwidresetbutton.BackColor = (hwidresetbuttonbackcolor);
                var hwidresetbuttonnormalcolor = ColorTranslator.FromHtml("#9F9471");
                hwidresetbutton.Normalcolor = (hwidresetbuttonnormalcolor);
                var hwidresetbuttononhovercolor = ColorTranslator.FromHtml("#9F9471");
                hwidresetbutton.OnHovercolor = (hwidresetbuttononhovercolor);
            }

            if (Properties.Settings.Default.themecolor == "Teal")
            {
                var hwidresetbuttonbackcolor = ColorTranslator.FromHtml("#33BCBA");
                hwidresetbutton.BackColor = (hwidresetbuttonbackcolor);
                var hwidresetbuttonnormalcolor = ColorTranslator.FromHtml("#33BCBA");
                hwidresetbutton.Normalcolor = (hwidresetbuttonnormalcolor);
                var hwidresetbuttononhovercolor = ColorTranslator.FromHtml("#33BCBA");
                hwidresetbutton.OnHovercolor = (hwidresetbuttononhovercolor);
            }

        }

        private void mylicence_Load(object sender, EventArgs e)
        {
            themecolor_Data();
        }

        private void hwidresetbutton_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(hwidnolabel.Text);
            MessageBox.Show("Hwid reset system will be added soon!", "This feature is coming soon!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
