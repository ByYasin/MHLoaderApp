using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MHLoaderApp.Modules.Loader_Pages
{
    public partial class settings : UserControl
    {
        public settings()
        {
            InitializeComponent();
            Init_Data();
            AutoInıt_Data();
        }

        private void Init_Data()
        {
            if (Properties.Settings.Default.remember == true)
            {
                rememberme.Checked = true;
            }
            else
            {

            }

        }

        private void Save_Data()
        {
            if (rememberme.Checked)
            {
                Properties.Settings.Default.remember = true;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.remember = false;
                Properties.Settings.Default.Save();
            }

        }

        private void AutoInıt_Data()
        {
            if (Properties.Settings.Default.autologinsave == true)
            {
                autologin.Checked = true;
            }
            else
            {

            }
        }

        private void Auto_Save_Data()
        {
            if (autologin.Checked)
            {
                Properties.Settings.Default.autologinsave = true;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.autologinsave = false;
                Properties.Settings.Default.Save();
            }
        }

        public void SaveSettings()
        {
            Properties.Settings.Default.Save();
        }


        private void settings_Load(object sender, EventArgs e)
        {
            SaveSettings();
            themecomboBox.Text = Properties.Settings.Default.themecolor;
        }

        private void rememberme_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs e)
        {
            Save_Data();
        }

        private void autologin_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs e)
        {
            Auto_Save_Data();
        }

        private void changethemebutton_Click(object sender, EventArgs e)
        {
            if (themecomboBox.SelectedItem == "Blue (Default)")
            {
                Properties.Settings.Default.themecolor = "Blue (Default)";
            }

            if (themecomboBox.SelectedItem == "Brown")
            {
                Properties.Settings.Default.themecolor = "Brown";
            }


            if (themecomboBox.SelectedItem == "Cobalt")
            {
                Properties.Settings.Default.themecolor = "Cobalt";
            }


            if (themecomboBox.SelectedItem == "Crimson")
            {
                Properties.Settings.Default.themecolor = "Crimson";
            }


            if (themecomboBox.SelectedItem == "Cyan")
            {
                Properties.Settings.Default.themecolor = "Cyan";
            }

            if (themecomboBox.SelectedItem == "Dark Gold")
            {
                Properties.Settings.Default.themecolor = "Dark Gold";
            }

            if (themecomboBox.SelectedItem == "Dark Red")
            {
                Properties.Settings.Default.themecolor = "Dark Red";
            }

            if (themecomboBox.SelectedItem == "Emerald")
            {
                Properties.Settings.Default.themecolor = "Emerald";
            }


            if (themecomboBox.SelectedItem == "Green")
            {
                Properties.Settings.Default.themecolor = "Green";
            }


            if (themecomboBox.SelectedItem == "Indigo")
            {
                Properties.Settings.Default.themecolor = "Indigo";
            }


            if (themecomboBox.SelectedItem == "Magenta")
            {
                Properties.Settings.Default.themecolor = "Magenta";
            }


            if (themecomboBox.SelectedItem == "Mauve")
            {
                Properties.Settings.Default.themecolor = "Mauve";
            }


            if (themecomboBox.SelectedItem == "Orange")
            {
                Properties.Settings.Default.themecolor = "Orange";
            }


            if (themecomboBox.SelectedItem == "Pink")
            {
                Properties.Settings.Default.themecolor = "Pink";
            }


            if (themecomboBox.SelectedItem == "Purple")
            {
                Properties.Settings.Default.themecolor = "Purple";
            }


            if (themecomboBox.SelectedItem == "Red")
            {
                Properties.Settings.Default.themecolor = "Red";
            }

            if (themecomboBox.SelectedItem == "Sienna")
            {
                Properties.Settings.Default.themecolor = "Sienna";
            }


            if (themecomboBox.SelectedItem == "Steel")
            {
                Properties.Settings.Default.themecolor = "Steel";
            }


            if (themecomboBox.SelectedItem == "Taupe")
            {
                Properties.Settings.Default.themecolor = "Taupe";
            }


            if (themecomboBox.SelectedItem == "Teal")
            {
                Properties.Settings.Default.themecolor = "Teal";
            }
            SaveSettings();
            Application.Restart();
        }
    }

}
