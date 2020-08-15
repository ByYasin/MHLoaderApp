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
        }

        private void hwidcopybutton_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(hwidnolabel.Text);
            MessageBox.Show("Hwid reset system will be added soon!", "This feature is coming soon!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
