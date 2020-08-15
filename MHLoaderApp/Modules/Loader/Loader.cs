using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MHLoaderApp.Loader
{
    public partial class Loader : Form
    {
        public Loader()
        {
            InitializeComponent();
        }

        private void Loader_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Loader_Load(object sender, EventArgs e)
        {

        }

        private void logo2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://memoryhackers.org"); //ByYasin
        }

        private void mylicencelabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            bunifuPages1.PageIndex = 0;
            leftcolor1.Visible = false;
            leftcolor2.Visible = false;
            leftcolor3.Visible = false;
            leftcolor4.Visible = false;
            leftcolor5.Visible = false;
            licencebuyrenewcolor.Visible = false;
            mylicencecolor.Visible = true;
        }

        private void usertext_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            bunifuPages1.PageIndex = 0;
            leftcolor1.Visible = false;
            leftcolor2.Visible = false;
            leftcolor3.Visible = false;
            leftcolor4.Visible = false;
            leftcolor5.Visible = false;
            licencebuyrenewcolor.Visible = false;
            mylicencecolor.Visible = true;
        }

        private void buyrenewlabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            bunifuPages1.PageIndex = 1;
            leftcolor1.Visible = false;
            leftcolor2.Visible = false;
            leftcolor3.Visible = false;
            leftcolor4.Visible = false;
            leftcolor5.Visible = false;
            licencebuyrenewcolor.Visible = true;
            mylicencecolor.Visible = false;
        }

        private void notification_Click(object sender, EventArgs e)
        {
            bunifuPages1.PageIndex = 2;
            leftcolor1.Visible = false;
            leftcolor2.Visible = false;
            leftcolor3.Visible = false;
            leftcolor4.Visible = false;
            leftcolor5.Visible = false;
            licencebuyrenewcolor.Visible = false;
            mylicencecolor.Visible = false;
        }

        private void updates_Click(object sender, EventArgs e)
        {
            bunifuPages1.PageIndex = 3;
            leftcolor1.Visible = false;
            leftcolor2.Visible = false;
            leftcolor3.Visible = false;
            leftcolor4.Visible = false;
            leftcolor5.Visible = false;
            licencebuyrenewcolor.Visible = false;
            mylicencecolor.Visible = false;
        }

        private void settings_Click(object sender, EventArgs e)
        {
            bunifuPages1.PageIndex = 4;
            leftcolor1.Visible = false;
            leftcolor2.Visible = false;
            leftcolor3.Visible = false;
            leftcolor4.Visible = false;
            leftcolor5.Visible = false;
            licencebuyrenewcolor.Visible = false;
            mylicencecolor.Visible = false;
        }

        private void csgobutton_Click(object sender, EventArgs e)
        {
            bunifuPages1.PageIndex = 5;
            leftcolor1.Visible = true;
            leftcolor2.Visible = false;
            leftcolor3.Visible = false;
            leftcolor4.Visible = false;
            leftcolor5.Visible = false;
            licencebuyrenewcolor.Visible = false;
            mylicencecolor.Visible = false;
        }

        private void eftbutton_Click(object sender, EventArgs e)
        {
            bunifuPages1.PageIndex = 6;
            leftcolor1.Visible = false;
            leftcolor2.Visible = true;
            leftcolor3.Visible = false;
            leftcolor4.Visible = false;
            leftcolor5.Visible = false;
            licencebuyrenewcolor.Visible = false;
            mylicencecolor.Visible = false;
        }

        private void lolbutton_Click(object sender, EventArgs e)
        {
            bunifuPages1.PageIndex = 7;
            leftcolor1.Visible = false;
            leftcolor2.Visible = false;
            leftcolor3.Visible = true;
            leftcolor4.Visible = false;
            leftcolor5.Visible = false;
            licencebuyrenewcolor.Visible = false;
            mylicencecolor.Visible = false;
        }

        private void pubgbutton_Click(object sender, EventArgs e)
        {
            bunifuPages1.PageIndex = 8;
            leftcolor1.Visible = false;
            leftcolor2.Visible = false;
            leftcolor3.Visible = false;
            leftcolor4.Visible = true;
            leftcolor5.Visible = false;
            licencebuyrenewcolor.Visible = false;
            mylicencecolor.Visible = false;
        }

        private void rustbutton_Click(object sender, EventArgs e)
        {
            bunifuPages1.PageIndex = 9;
            leftcolor1.Visible = false;
            leftcolor2.Visible = false;
            leftcolor3.Visible = false;
            leftcolor4.Visible = false;
            leftcolor5.Visible = true;
            licencebuyrenewcolor.Visible = false;
            mylicencecolor.Visible = false;
        }
    }

}
