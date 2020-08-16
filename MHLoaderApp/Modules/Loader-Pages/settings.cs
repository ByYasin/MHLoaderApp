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
            themecolor_Data();
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

        private void themecolor_Data()
        {
			if (Properties.Settings.Default.themecolor == "Blue (Default)")
			{
				var loginsettingscolorbackcolor = ColorTranslator.FromHtml("#3393DF");
				loginsettingscolor.BackColor = (loginsettingscolorbackcolor);

				var loadersettingscolorbackcolor = ColorTranslator.FromHtml("#3393DF");
				loadersettingscolor.BackColor = (loadersettingscolorbackcolor);

				var remembermeoncheckbordercolor = ColorTranslator.FromHtml("#3393DF");
				rememberme.OnCheck.BorderColor = (remembermeoncheckbordercolor);

				var remembermeoncheckcheckboxcolor = ColorTranslator.FromHtml("#3393DF");
				rememberme.OnCheck.CheckBoxColor = (remembermeoncheckcheckboxcolor);

				var remembermeonhovercheckedbordercolor = ColorTranslator.FromHtml("#3393DF");
				rememberme.OnHoverChecked.BorderColor = (remembermeonhovercheckedbordercolor);

				var remembermeonhovercheckedcheckboxcolor = ColorTranslator.FromHtml("#3393DF");
				rememberme.OnHoverChecked.CheckBoxColor = (remembermeonhovercheckedcheckboxcolor);

				var remembermeonhoveruncheckedbordercolor = ColorTranslator.FromHtml("#3393DF");
				rememberme.OnHoverUnchecked.BorderColor = (remembermeonhoveruncheckedbordercolor);

				var remembermeonuncheckbordercolor = ColorTranslator.FromHtml("#3393DF");
				rememberme.OnUncheck.BorderColor = (remembermeonuncheckbordercolor);

				var autologinoncheckbordercolor = ColorTranslator.FromHtml("#3393DF");
				autologin.OnCheck.BorderColor = (autologinoncheckbordercolor);

				var autologinoncheckcheckboxcolor = ColorTranslator.FromHtml("#3393DF");
				autologin.OnCheck.CheckBoxColor = (autologinoncheckcheckboxcolor);

				var autologinonhovercheckedbordercolor = ColorTranslator.FromHtml("#3393DF");
				autologin.OnHoverChecked.BorderColor = (autologinonhovercheckedbordercolor);

				var autologinonhovercheckedcheckboxcolor = ColorTranslator.FromHtml("#3393DF");
				autologin.OnHoverChecked.CheckBoxColor = (autologinonhovercheckedcheckboxcolor);

				var autologinonhoveruncheckedbordercolor = ColorTranslator.FromHtml("#3393DF");
				autologin.OnHoverUnchecked.BorderColor = (autologinonhoveruncheckedbordercolor);

				var autologinonuncheckbordercolor = ColorTranslator.FromHtml("#3393DF");
				autologin.OnUncheck.BorderColor = (autologinonuncheckbordercolor);

				var autoupdatecheckoncheckbordercolor = ColorTranslator.FromHtml("#3393DF");
				autoupdatecheck.OnCheck.BorderColor = (autoupdatecheckoncheckbordercolor);

				var autoupdatecheckoncheckcheckboxcolor = ColorTranslator.FromHtml("#3393DF");
				autoupdatecheck.OnCheck.CheckBoxColor = (autoupdatecheckoncheckcheckboxcolor);

				var autoupdatecheckonhovercheckedbordercolor = ColorTranslator.FromHtml("#3393DF");
				autoupdatecheck.OnHoverChecked.BorderColor = (autoupdatecheckonhovercheckedbordercolor);

				var autoupdatecheckonhovercheckedcheckboxcolor = ColorTranslator.FromHtml("#3393DF");
				autoupdatecheck.OnHoverChecked.CheckBoxColor = (autoupdatecheckonhovercheckedcheckboxcolor);

				var autoupdatecheckonhoveruncheckedbordercolor = ColorTranslator.FromHtml("#3393DF");
				autoupdatecheck.OnHoverUnchecked.BorderColor = (autoupdatecheckonhoveruncheckedbordercolor);

				var autoupdatecheckonuncheckbordercolor = ColorTranslator.FromHtml("#3393DF");
				autoupdatecheck.OnUncheck.BorderColor = (autoupdatecheckonuncheckbordercolor);

				var autoinjectoncheckbordercolor = ColorTranslator.FromHtml("#3393DF");
				autoinject.OnCheck.BorderColor = (autoinjectoncheckbordercolor);

				var autoinjectoncheckcheckboxcolor = ColorTranslator.FromHtml("#3393DF");
				autoinject.OnCheck.CheckBoxColor = (autoinjectoncheckcheckboxcolor);

				var autoinjectonhovercheckedbordercolor = ColorTranslator.FromHtml("#3393DF");
				autoinject.OnHoverChecked.BorderColor = (autoinjectonhovercheckedbordercolor);

				var autoinjectonhovercheckedcheckboxcolor = ColorTranslator.FromHtml("#3393DF");
				autoinject.OnHoverChecked.CheckBoxColor = (autoinjectonhovercheckedcheckboxcolor);

				var autoinjectonhoveruncheckedbordercolor = ColorTranslator.FromHtml("#3393DF");
				autoinject.OnHoverUnchecked.BorderColor = (autoinjectonhoveruncheckedbordercolor);

				var autoinjectonuncheckbordercolor = ColorTranslator.FromHtml("#3393DF");
				autoinject.OnUncheck.BorderColor = (autoinjectonuncheckbordercolor);
			}

			if (Properties.Settings.Default.themecolor == "Brown")
			{
				var loginsettingscolorbackcolor = ColorTranslator.FromHtml("#9B7B56");
				loginsettingscolor.BackColor = (loginsettingscolorbackcolor);

				var loadersettingscolorbackcolor = ColorTranslator.FromHtml("#9B7B56");
				loadersettingscolor.BackColor = (loadersettingscolorbackcolor);

				var remembermeoncheckbordercolor = ColorTranslator.FromHtml("#9B7B56");
				rememberme.OnCheck.BorderColor = (remembermeoncheckbordercolor);

				var remembermeoncheckcheckboxcolor = ColorTranslator.FromHtml("#9B7B56");
				rememberme.OnCheck.CheckBoxColor = (remembermeoncheckcheckboxcolor);

				var remembermeonhovercheckedbordercolor = ColorTranslator.FromHtml("#9B7B56");
				rememberme.OnHoverChecked.BorderColor = (remembermeonhovercheckedbordercolor);

				var remembermeonhovercheckedcheckboxcolor = ColorTranslator.FromHtml("#9B7B56");
				rememberme.OnHoverChecked.CheckBoxColor = (remembermeonhovercheckedcheckboxcolor);

				var remembermeonhoveruncheckedbordercolor = ColorTranslator.FromHtml("#9B7B56");
				rememberme.OnHoverUnchecked.BorderColor = (remembermeonhoveruncheckedbordercolor);

				var remembermeonuncheckbordercolor = ColorTranslator.FromHtml("#9B7B56");
				rememberme.OnUncheck.BorderColor = (remembermeonuncheckbordercolor);

				var autologinoncheckbordercolor = ColorTranslator.FromHtml("#9B7B56");
				autologin.OnCheck.BorderColor = (autologinoncheckbordercolor);

				var autologinoncheckcheckboxcolor = ColorTranslator.FromHtml("#9B7B56");
				autologin.OnCheck.CheckBoxColor = (autologinoncheckcheckboxcolor);

				var autologinonhovercheckedbordercolor = ColorTranslator.FromHtml("#9B7B56");
				autologin.OnHoverChecked.BorderColor = (autologinonhovercheckedbordercolor);

				var autologinonhovercheckedcheckboxcolor = ColorTranslator.FromHtml("#9B7B56");
				autologin.OnHoverChecked.CheckBoxColor = (autologinonhovercheckedcheckboxcolor);

				var autologinonhoveruncheckedbordercolor = ColorTranslator.FromHtml("#9B7B56");
				autologin.OnHoverUnchecked.BorderColor = (autologinonhoveruncheckedbordercolor);

				var autologinonuncheckbordercolor = ColorTranslator.FromHtml("#9B7B56");
				autologin.OnUncheck.BorderColor = (autologinonuncheckbordercolor);

				var autoupdatecheckoncheckbordercolor = ColorTranslator.FromHtml("#9B7B56");
				autoupdatecheck.OnCheck.BorderColor = (autoupdatecheckoncheckbordercolor);

				var autoupdatecheckoncheckcheckboxcolor = ColorTranslator.FromHtml("#9B7B56");
				autoupdatecheck.OnCheck.CheckBoxColor = (autoupdatecheckoncheckcheckboxcolor);

				var autoupdatecheckonhovercheckedbordercolor = ColorTranslator.FromHtml("#9B7B56");
				autoupdatecheck.OnHoverChecked.BorderColor = (autoupdatecheckonhovercheckedbordercolor);

				var autoupdatecheckonhovercheckedcheckboxcolor = ColorTranslator.FromHtml("#9B7B56");
				autoupdatecheck.OnHoverChecked.CheckBoxColor = (autoupdatecheckonhovercheckedcheckboxcolor);

				var autoupdatecheckonhoveruncheckedbordercolor = ColorTranslator.FromHtml("#9B7B56");
				autoupdatecheck.OnHoverUnchecked.BorderColor = (autoupdatecheckonhoveruncheckedbordercolor);

				var autoupdatecheckonuncheckbordercolor = ColorTranslator.FromHtml("#9B7B56");
				autoupdatecheck.OnUncheck.BorderColor = (autoupdatecheckonuncheckbordercolor);

				var autoinjectoncheckbordercolor = ColorTranslator.FromHtml("#9B7B56");
				autoinject.OnCheck.BorderColor = (autoinjectoncheckbordercolor);

				var autoinjectoncheckcheckboxcolor = ColorTranslator.FromHtml("#9B7B56");
				autoinject.OnCheck.CheckBoxColor = (autoinjectoncheckcheckboxcolor);

				var autoinjectonhovercheckedbordercolor = ColorTranslator.FromHtml("#9B7B56");
				autoinject.OnHoverChecked.BorderColor = (autoinjectonhovercheckedbordercolor);

				var autoinjectonhovercheckedcheckboxcolor = ColorTranslator.FromHtml("#9B7B56");
				autoinject.OnHoverChecked.CheckBoxColor = (autoinjectonhovercheckedcheckboxcolor);

				var autoinjectonhoveruncheckedbordercolor = ColorTranslator.FromHtml("#9B7B56");
				autoinject.OnHoverUnchecked.BorderColor = (autoinjectonhoveruncheckedbordercolor);

				var autoinjectonuncheckbordercolor = ColorTranslator.FromHtml("#9B7B56");
				autoinject.OnUncheck.BorderColor = (autoinjectonuncheckbordercolor);
			}

			if (Properties.Settings.Default.themecolor == "Cobalt")
			{
				var loginsettingscolorbackcolor = ColorTranslator.FromHtml("#3373F2");
				loginsettingscolor.BackColor = (loginsettingscolorbackcolor);

				var loadersettingscolorbackcolor = ColorTranslator.FromHtml("#3373F2");
				loadersettingscolor.BackColor = (loadersettingscolorbackcolor);

				var remembermeoncheckbordercolor = ColorTranslator.FromHtml("#3373F2");
				rememberme.OnCheck.BorderColor = (remembermeoncheckbordercolor);

				var remembermeoncheckcheckboxcolor = ColorTranslator.FromHtml("#3373F2");
				rememberme.OnCheck.CheckBoxColor = (remembermeoncheckcheckboxcolor);

				var remembermeonhovercheckedbordercolor = ColorTranslator.FromHtml("#3373F2");
				rememberme.OnHoverChecked.BorderColor = (remembermeonhovercheckedbordercolor);

				var remembermeonhovercheckedcheckboxcolor = ColorTranslator.FromHtml("#3373F2");
				rememberme.OnHoverChecked.CheckBoxColor = (remembermeonhovercheckedcheckboxcolor);

				var remembermeonhoveruncheckedbordercolor = ColorTranslator.FromHtml("#3373F2");
				rememberme.OnHoverUnchecked.BorderColor = (remembermeonhoveruncheckedbordercolor);

				var remembermeonuncheckbordercolor = ColorTranslator.FromHtml("#3373F2");
				rememberme.OnUncheck.BorderColor = (remembermeonuncheckbordercolor);

				var autologinoncheckbordercolor = ColorTranslator.FromHtml("#3373F2");
				autologin.OnCheck.BorderColor = (autologinoncheckbordercolor);

				var autologinoncheckcheckboxcolor = ColorTranslator.FromHtml("#3373F2");
				autologin.OnCheck.CheckBoxColor = (autologinoncheckcheckboxcolor);

				var autologinonhovercheckedbordercolor = ColorTranslator.FromHtml("#3373F2");
				autologin.OnHoverChecked.BorderColor = (autologinonhovercheckedbordercolor);

				var autologinonhovercheckedcheckboxcolor = ColorTranslator.FromHtml("#3373F2");
				autologin.OnHoverChecked.CheckBoxColor = (autologinonhovercheckedcheckboxcolor);

				var autologinonhoveruncheckedbordercolor = ColorTranslator.FromHtml("#3373F2");
				autologin.OnHoverUnchecked.BorderColor = (autologinonhoveruncheckedbordercolor);

				var autologinonuncheckbordercolor = ColorTranslator.FromHtml("#3373F2");
				autologin.OnUncheck.BorderColor = (autologinonuncheckbordercolor);

				var autoupdatecheckoncheckbordercolor = ColorTranslator.FromHtml("#3373F2");
				autoupdatecheck.OnCheck.BorderColor = (autoupdatecheckoncheckbordercolor);

				var autoupdatecheckoncheckcheckboxcolor = ColorTranslator.FromHtml("#3373F2");
				autoupdatecheck.OnCheck.CheckBoxColor = (autoupdatecheckoncheckcheckboxcolor);

				var autoupdatecheckonhovercheckedbordercolor = ColorTranslator.FromHtml("#3373F2");
				autoupdatecheck.OnHoverChecked.BorderColor = (autoupdatecheckonhovercheckedbordercolor);

				var autoupdatecheckonhovercheckedcheckboxcolor = ColorTranslator.FromHtml("#3373F2");
				autoupdatecheck.OnHoverChecked.CheckBoxColor = (autoupdatecheckonhovercheckedcheckboxcolor);

				var autoupdatecheckonhoveruncheckedbordercolor = ColorTranslator.FromHtml("#3373F2");
				autoupdatecheck.OnHoverUnchecked.BorderColor = (autoupdatecheckonhoveruncheckedbordercolor);

				var autoupdatecheckonuncheckbordercolor = ColorTranslator.FromHtml("#3373F2");
				autoupdatecheck.OnUncheck.BorderColor = (autoupdatecheckonuncheckbordercolor);

				var autoinjectoncheckbordercolor = ColorTranslator.FromHtml("#3373F2");
				autoinject.OnCheck.BorderColor = (autoinjectoncheckbordercolor);

				var autoinjectoncheckcheckboxcolor = ColorTranslator.FromHtml("#3373F2");
				autoinject.OnCheck.CheckBoxColor = (autoinjectoncheckcheckboxcolor);

				var autoinjectonhovercheckedbordercolor = ColorTranslator.FromHtml("#3373F2");
				autoinject.OnHoverChecked.BorderColor = (autoinjectonhovercheckedbordercolor);

				var autoinjectonhovercheckedcheckboxcolor = ColorTranslator.FromHtml("#3373F2");
				autoinject.OnHoverChecked.CheckBoxColor = (autoinjectonhovercheckedcheckboxcolor);

				var autoinjectonhoveruncheckedbordercolor = ColorTranslator.FromHtml("#3373F2");
				autoinject.OnHoverUnchecked.BorderColor = (autoinjectonhoveruncheckedbordercolor);

				var autoinjectonuncheckbordercolor = ColorTranslator.FromHtml("#3373F2");
				autoinject.OnUncheck.BorderColor = (autoinjectonuncheckbordercolor);
			}

			if (Properties.Settings.Default.themecolor == "Crimson")
			{
				var loginsettingscolorbackcolor = ColorTranslator.FromHtml("#B53351");
				loginsettingscolor.BackColor = (loginsettingscolorbackcolor);

				var loadersettingscolorbackcolor = ColorTranslator.FromHtml("#B53351");
				loadersettingscolor.BackColor = (loadersettingscolorbackcolor);

				var remembermeoncheckbordercolor = ColorTranslator.FromHtml("#B53351");
				rememberme.OnCheck.BorderColor = (remembermeoncheckbordercolor);

				var remembermeoncheckcheckboxcolor = ColorTranslator.FromHtml("#B53351");
				rememberme.OnCheck.CheckBoxColor = (remembermeoncheckcheckboxcolor);

				var remembermeonhovercheckedbordercolor = ColorTranslator.FromHtml("#B53351");
				rememberme.OnHoverChecked.BorderColor = (remembermeonhovercheckedbordercolor);

				var remembermeonhovercheckedcheckboxcolor = ColorTranslator.FromHtml("#B53351");
				rememberme.OnHoverChecked.CheckBoxColor = (remembermeonhovercheckedcheckboxcolor);

				var remembermeonhoveruncheckedbordercolor = ColorTranslator.FromHtml("#B53351");
				rememberme.OnHoverUnchecked.BorderColor = (remembermeonhoveruncheckedbordercolor);

				var remembermeonuncheckbordercolor = ColorTranslator.FromHtml("#B53351");
				rememberme.OnUncheck.BorderColor = (remembermeonuncheckbordercolor);

				var autologinoncheckbordercolor = ColorTranslator.FromHtml("#B53351");
				autologin.OnCheck.BorderColor = (autologinoncheckbordercolor);

				var autologinoncheckcheckboxcolor = ColorTranslator.FromHtml("#B53351");
				autologin.OnCheck.CheckBoxColor = (autologinoncheckcheckboxcolor);

				var autologinonhovercheckedbordercolor = ColorTranslator.FromHtml("#B53351");
				autologin.OnHoverChecked.BorderColor = (autologinonhovercheckedbordercolor);

				var autologinonhovercheckedcheckboxcolor = ColorTranslator.FromHtml("#B53351");
				autologin.OnHoverChecked.CheckBoxColor = (autologinonhovercheckedcheckboxcolor);

				var autologinonhoveruncheckedbordercolor = ColorTranslator.FromHtml("#B53351");
				autologin.OnHoverUnchecked.BorderColor = (autologinonhoveruncheckedbordercolor);

				var autologinonuncheckbordercolor = ColorTranslator.FromHtml("#B53351");
				autologin.OnUncheck.BorderColor = (autologinonuncheckbordercolor);

				var autoupdatecheckoncheckbordercolor = ColorTranslator.FromHtml("#B53351");
				autoupdatecheck.OnCheck.BorderColor = (autoupdatecheckoncheckbordercolor);

				var autoupdatecheckoncheckcheckboxcolor = ColorTranslator.FromHtml("#B53351");
				autoupdatecheck.OnCheck.CheckBoxColor = (autoupdatecheckoncheckcheckboxcolor);

				var autoupdatecheckonhovercheckedbordercolor = ColorTranslator.FromHtml("#B53351");
				autoupdatecheck.OnHoverChecked.BorderColor = (autoupdatecheckonhovercheckedbordercolor);

				var autoupdatecheckonhovercheckedcheckboxcolor = ColorTranslator.FromHtml("#B53351");
				autoupdatecheck.OnHoverChecked.CheckBoxColor = (autoupdatecheckonhovercheckedcheckboxcolor);

				var autoupdatecheckonhoveruncheckedbordercolor = ColorTranslator.FromHtml("#B53351");
				autoupdatecheck.OnHoverUnchecked.BorderColor = (autoupdatecheckonhoveruncheckedbordercolor);

				var autoupdatecheckonuncheckbordercolor = ColorTranslator.FromHtml("#B53351");
				autoupdatecheck.OnUncheck.BorderColor = (autoupdatecheckonuncheckbordercolor);

				var autoinjectoncheckbordercolor = ColorTranslator.FromHtml("#B53351");
				autoinject.OnCheck.BorderColor = (autoinjectoncheckbordercolor);

				var autoinjectoncheckcheckboxcolor = ColorTranslator.FromHtml("#B53351");
				autoinject.OnCheck.CheckBoxColor = (autoinjectoncheckcheckboxcolor);

				var autoinjectonhovercheckedbordercolor = ColorTranslator.FromHtml("#B53351");
				autoinject.OnHoverChecked.BorderColor = (autoinjectonhovercheckedbordercolor);

				var autoinjectonhovercheckedcheckboxcolor = ColorTranslator.FromHtml("#B53351");
				autoinject.OnHoverChecked.CheckBoxColor = (autoinjectonhovercheckedcheckboxcolor);

				var autoinjectonhoveruncheckedbordercolor = ColorTranslator.FromHtml("#B53351");
				autoinject.OnHoverUnchecked.BorderColor = (autoinjectonhoveruncheckedbordercolor);

				var autoinjectonuncheckbordercolor = ColorTranslator.FromHtml("#B53351");
				autoinject.OnUncheck.BorderColor = (autoinjectonuncheckbordercolor);
			}

			if (Properties.Settings.Default.themecolor == "Cyan")
			{
				var loginsettingscolorbackcolor = ColorTranslator.FromHtml("#49B4E8");
				loginsettingscolor.BackColor = (loginsettingscolorbackcolor);

				var loadersettingscolorbackcolor = ColorTranslator.FromHtml("#49B4E8");
				loadersettingscolor.BackColor = (loadersettingscolorbackcolor);

				var remembermeoncheckbordercolor = ColorTranslator.FromHtml("#49B4E8");
				rememberme.OnCheck.BorderColor = (remembermeoncheckbordercolor);

				var remembermeoncheckcheckboxcolor = ColorTranslator.FromHtml("#49B4E8");
				rememberme.OnCheck.CheckBoxColor = (remembermeoncheckcheckboxcolor);

				var remembermeonhovercheckedbordercolor = ColorTranslator.FromHtml("#49B4E8");
				rememberme.OnHoverChecked.BorderColor = (remembermeonhovercheckedbordercolor);

				var remembermeonhovercheckedcheckboxcolor = ColorTranslator.FromHtml("#49B4E8");
				rememberme.OnHoverChecked.CheckBoxColor = (remembermeonhovercheckedcheckboxcolor);

				var remembermeonhoveruncheckedbordercolor = ColorTranslator.FromHtml("#49B4E8");
				rememberme.OnHoverUnchecked.BorderColor = (remembermeonhoveruncheckedbordercolor);

				var remembermeonuncheckbordercolor = ColorTranslator.FromHtml("#49B4E8");
				rememberme.OnUncheck.BorderColor = (remembermeonuncheckbordercolor);

				var autologinoncheckbordercolor = ColorTranslator.FromHtml("#49B4E8");
				autologin.OnCheck.BorderColor = (autologinoncheckbordercolor);

				var autologinoncheckcheckboxcolor = ColorTranslator.FromHtml("#49B4E8");
				autologin.OnCheck.CheckBoxColor = (autologinoncheckcheckboxcolor);

				var autologinonhovercheckedbordercolor = ColorTranslator.FromHtml("#49B4E8");
				autologin.OnHoverChecked.BorderColor = (autologinonhovercheckedbordercolor);

				var autologinonhovercheckedcheckboxcolor = ColorTranslator.FromHtml("#49B4E8");
				autologin.OnHoverChecked.CheckBoxColor = (autologinonhovercheckedcheckboxcolor);

				var autologinonhoveruncheckedbordercolor = ColorTranslator.FromHtml("#49B4E8");
				autologin.OnHoverUnchecked.BorderColor = (autologinonhoveruncheckedbordercolor);

				var autologinonuncheckbordercolor = ColorTranslator.FromHtml("#49B4E8");
				autologin.OnUncheck.BorderColor = (autologinonuncheckbordercolor);

				var autoupdatecheckoncheckbordercolor = ColorTranslator.FromHtml("#49B4E8");
				autoupdatecheck.OnCheck.BorderColor = (autoupdatecheckoncheckbordercolor);

				var autoupdatecheckoncheckcheckboxcolor = ColorTranslator.FromHtml("#49B4E8");
				autoupdatecheck.OnCheck.CheckBoxColor = (autoupdatecheckoncheckcheckboxcolor);

				var autoupdatecheckonhovercheckedbordercolor = ColorTranslator.FromHtml("#49B4E8");
				autoupdatecheck.OnHoverChecked.BorderColor = (autoupdatecheckonhovercheckedbordercolor);

				var autoupdatecheckonhovercheckedcheckboxcolor = ColorTranslator.FromHtml("#49B4E8");
				autoupdatecheck.OnHoverChecked.CheckBoxColor = (autoupdatecheckonhovercheckedcheckboxcolor);

				var autoupdatecheckonhoveruncheckedbordercolor = ColorTranslator.FromHtml("#49B4E8");
				autoupdatecheck.OnHoverUnchecked.BorderColor = (autoupdatecheckonhoveruncheckedbordercolor);

				var autoupdatecheckonuncheckbordercolor = ColorTranslator.FromHtml("#49B4E8");
				autoupdatecheck.OnUncheck.BorderColor = (autoupdatecheckonuncheckbordercolor);

				var autoinjectoncheckbordercolor = ColorTranslator.FromHtml("#49B4E8");
				autoinject.OnCheck.BorderColor = (autoinjectoncheckbordercolor);

				var autoinjectoncheckcheckboxcolor = ColorTranslator.FromHtml("#49B4E8");
				autoinject.OnCheck.CheckBoxColor = (autoinjectoncheckcheckboxcolor);

				var autoinjectonhovercheckedbordercolor = ColorTranslator.FromHtml("#49B4E8");
				autoinject.OnHoverChecked.BorderColor = (autoinjectonhovercheckedbordercolor);

				var autoinjectonhovercheckedcheckboxcolor = ColorTranslator.FromHtml("#49B4E8");
				autoinject.OnHoverChecked.CheckBoxColor = (autoinjectonhovercheckedcheckboxcolor);

				var autoinjectonhoveruncheckedbordercolor = ColorTranslator.FromHtml("#49B4E8");
				autoinject.OnHoverUnchecked.BorderColor = (autoinjectonhoveruncheckedbordercolor);

				var autoinjectonuncheckbordercolor = ColorTranslator.FromHtml("#49B4E8");
				autoinject.OnUncheck.BorderColor = (autoinjectonuncheckbordercolor);
			}

			if (Properties.Settings.Default.themecolor == "Dark Gold")
			{
				var loginsettingscolorbackcolor = ColorTranslator.FromHtml("#BF9B30");
				loginsettingscolor.BackColor = (loginsettingscolorbackcolor);

				var loadersettingscolorbackcolor = ColorTranslator.FromHtml("#BF9B30");
				loadersettingscolor.BackColor = (loadersettingscolorbackcolor);

				var remembermeoncheckbordercolor = ColorTranslator.FromHtml("#BF9B30");
				rememberme.OnCheck.BorderColor = (remembermeoncheckbordercolor);

				var remembermeoncheckcheckboxcolor = ColorTranslator.FromHtml("#BF9B30");
				rememberme.OnCheck.CheckBoxColor = (remembermeoncheckcheckboxcolor);

				var remembermeonhovercheckedbordercolor = ColorTranslator.FromHtml("#BF9B30");
				rememberme.OnHoverChecked.BorderColor = (remembermeonhovercheckedbordercolor);

				var remembermeonhovercheckedcheckboxcolor = ColorTranslator.FromHtml("#BF9B30");
				rememberme.OnHoverChecked.CheckBoxColor = (remembermeonhovercheckedcheckboxcolor);

				var remembermeonhoveruncheckedbordercolor = ColorTranslator.FromHtml("#BF9B30");
				rememberme.OnHoverUnchecked.BorderColor = (remembermeonhoveruncheckedbordercolor);

				var remembermeonuncheckbordercolor = ColorTranslator.FromHtml("#BF9B30");
				rememberme.OnUncheck.BorderColor = (remembermeonuncheckbordercolor);

				var autologinoncheckbordercolor = ColorTranslator.FromHtml("#BF9B30");
				autologin.OnCheck.BorderColor = (autologinoncheckbordercolor);

				var autologinoncheckcheckboxcolor = ColorTranslator.FromHtml("#BF9B30");
				autologin.OnCheck.CheckBoxColor = (autologinoncheckcheckboxcolor);

				var autologinonhovercheckedbordercolor = ColorTranslator.FromHtml("#BF9B30");
				autologin.OnHoverChecked.BorderColor = (autologinonhovercheckedbordercolor);

				var autologinonhovercheckedcheckboxcolor = ColorTranslator.FromHtml("#BF9B30");
				autologin.OnHoverChecked.CheckBoxColor = (autologinonhovercheckedcheckboxcolor);

				var autologinonhoveruncheckedbordercolor = ColorTranslator.FromHtml("#BF9B30");
				autologin.OnHoverUnchecked.BorderColor = (autologinonhoveruncheckedbordercolor);

				var autologinonuncheckbordercolor = ColorTranslator.FromHtml("#BF9B30");
				autologin.OnUncheck.BorderColor = (autologinonuncheckbordercolor);

				var autoupdatecheckoncheckbordercolor = ColorTranslator.FromHtml("#BF9B30");
				autoupdatecheck.OnCheck.BorderColor = (autoupdatecheckoncheckbordercolor);

				var autoupdatecheckoncheckcheckboxcolor = ColorTranslator.FromHtml("#BF9B30");
				autoupdatecheck.OnCheck.CheckBoxColor = (autoupdatecheckoncheckcheckboxcolor);

				var autoupdatecheckonhovercheckedbordercolor = ColorTranslator.FromHtml("#BF9B30");
				autoupdatecheck.OnHoverChecked.BorderColor = (autoupdatecheckonhovercheckedbordercolor);

				var autoupdatecheckonhovercheckedcheckboxcolor = ColorTranslator.FromHtml("#BF9B30");
				autoupdatecheck.OnHoverChecked.CheckBoxColor = (autoupdatecheckonhovercheckedcheckboxcolor);

				var autoupdatecheckonhoveruncheckedbordercolor = ColorTranslator.FromHtml("#BF9B30");
				autoupdatecheck.OnHoverUnchecked.BorderColor = (autoupdatecheckonhoveruncheckedbordercolor);

				var autoupdatecheckonuncheckbordercolor = ColorTranslator.FromHtml("#BF9B30");
				autoupdatecheck.OnUncheck.BorderColor = (autoupdatecheckonuncheckbordercolor);

				var autoinjectoncheckbordercolor = ColorTranslator.FromHtml("#BF9B30");
				autoinject.OnCheck.BorderColor = (autoinjectoncheckbordercolor);

				var autoinjectoncheckcheckboxcolor = ColorTranslator.FromHtml("#BF9B30");
				autoinject.OnCheck.CheckBoxColor = (autoinjectoncheckcheckboxcolor);

				var autoinjectonhovercheckedbordercolor = ColorTranslator.FromHtml("#BF9B30");
				autoinject.OnHoverChecked.BorderColor = (autoinjectonhovercheckedbordercolor);

				var autoinjectonhovercheckedcheckboxcolor = ColorTranslator.FromHtml("#BF9B30");
				autoinject.OnHoverChecked.CheckBoxColor = (autoinjectonhovercheckedcheckboxcolor);

				var autoinjectonhoveruncheckedbordercolor = ColorTranslator.FromHtml("#BF9B30");
				autoinject.OnHoverUnchecked.BorderColor = (autoinjectonhoveruncheckedbordercolor);

				var autoinjectonuncheckbordercolor = ColorTranslator.FromHtml("#BF9B30");
				autoinject.OnUncheck.BorderColor = (autoinjectonuncheckbordercolor);
			}

			if (Properties.Settings.Default.themecolor == "Dark Red")
			{
				var loginsettingscolorbackcolor = ColorTranslator.FromHtml("#AF1001");
				loginsettingscolor.BackColor = (loginsettingscolorbackcolor);

				var loadersettingscolorbackcolor = ColorTranslator.FromHtml("#AF1001");
				loadersettingscolor.BackColor = (loadersettingscolorbackcolor);

				var remembermeoncheckbordercolor = ColorTranslator.FromHtml("#AF1001");
				rememberme.OnCheck.BorderColor = (remembermeoncheckbordercolor);

				var remembermeoncheckcheckboxcolor = ColorTranslator.FromHtml("#AF1001");
				rememberme.OnCheck.CheckBoxColor = (remembermeoncheckcheckboxcolor);

				var remembermeonhovercheckedbordercolor = ColorTranslator.FromHtml("#AF1001");
				rememberme.OnHoverChecked.BorderColor = (remembermeonhovercheckedbordercolor);

				var remembermeonhovercheckedcheckboxcolor = ColorTranslator.FromHtml("#AF1001");
				rememberme.OnHoverChecked.CheckBoxColor = (remembermeonhovercheckedcheckboxcolor);

				var remembermeonhoveruncheckedbordercolor = ColorTranslator.FromHtml("#AF1001");
				rememberme.OnHoverUnchecked.BorderColor = (remembermeonhoveruncheckedbordercolor);

				var remembermeonuncheckbordercolor = ColorTranslator.FromHtml("#AF1001");
				rememberme.OnUncheck.BorderColor = (remembermeonuncheckbordercolor);

				var autologinoncheckbordercolor = ColorTranslator.FromHtml("#AF1001");
				autologin.OnCheck.BorderColor = (autologinoncheckbordercolor);

				var autologinoncheckcheckboxcolor = ColorTranslator.FromHtml("#AF1001");
				autologin.OnCheck.CheckBoxColor = (autologinoncheckcheckboxcolor);

				var autologinonhovercheckedbordercolor = ColorTranslator.FromHtml("#AF1001");
				autologin.OnHoverChecked.BorderColor = (autologinonhovercheckedbordercolor);

				var autologinonhovercheckedcheckboxcolor = ColorTranslator.FromHtml("#AF1001");
				autologin.OnHoverChecked.CheckBoxColor = (autologinonhovercheckedcheckboxcolor);

				var autologinonhoveruncheckedbordercolor = ColorTranslator.FromHtml("#AF1001");
				autologin.OnHoverUnchecked.BorderColor = (autologinonhoveruncheckedbordercolor);

				var autologinonuncheckbordercolor = ColorTranslator.FromHtml("#AF1001");
				autologin.OnUncheck.BorderColor = (autologinonuncheckbordercolor);

				var autoupdatecheckoncheckbordercolor = ColorTranslator.FromHtml("#AF1001");
				autoupdatecheck.OnCheck.BorderColor = (autoupdatecheckoncheckbordercolor);

				var autoupdatecheckoncheckcheckboxcolor = ColorTranslator.FromHtml("#AF1001");
				autoupdatecheck.OnCheck.CheckBoxColor = (autoupdatecheckoncheckcheckboxcolor);

				var autoupdatecheckonhovercheckedbordercolor = ColorTranslator.FromHtml("#AF1001");
				autoupdatecheck.OnHoverChecked.BorderColor = (autoupdatecheckonhovercheckedbordercolor);

				var autoupdatecheckonhovercheckedcheckboxcolor = ColorTranslator.FromHtml("#AF1001");
				autoupdatecheck.OnHoverChecked.CheckBoxColor = (autoupdatecheckonhovercheckedcheckboxcolor);

				var autoupdatecheckonhoveruncheckedbordercolor = ColorTranslator.FromHtml("#AF1001");
				autoupdatecheck.OnHoverUnchecked.BorderColor = (autoupdatecheckonhoveruncheckedbordercolor);

				var autoupdatecheckonuncheckbordercolor = ColorTranslator.FromHtml("#AF1001");
				autoupdatecheck.OnUncheck.BorderColor = (autoupdatecheckonuncheckbordercolor);

				var autoinjectoncheckbordercolor = ColorTranslator.FromHtml("#AF1001");
				autoinject.OnCheck.BorderColor = (autoinjectoncheckbordercolor);

				var autoinjectoncheckcheckboxcolor = ColorTranslator.FromHtml("#AF1001");
				autoinject.OnCheck.CheckBoxColor = (autoinjectoncheckcheckboxcolor);

				var autoinjectonhovercheckedbordercolor = ColorTranslator.FromHtml("#AF1001");
				autoinject.OnHoverChecked.BorderColor = (autoinjectonhovercheckedbordercolor);

				var autoinjectonhovercheckedcheckboxcolor = ColorTranslator.FromHtml("#AF1001");
				autoinject.OnHoverChecked.CheckBoxColor = (autoinjectonhovercheckedcheckboxcolor);

				var autoinjectonhoveruncheckedbordercolor = ColorTranslator.FromHtml("#AF1001");
				autoinject.OnHoverUnchecked.BorderColor = (autoinjectonhoveruncheckedbordercolor);

				var autoinjectonuncheckbordercolor = ColorTranslator.FromHtml("#AF1001");
				autoinject.OnUncheck.BorderColor = (autoinjectonuncheckbordercolor);
			}

			if (Properties.Settings.Default.themecolor == "Emerald")
			{
				var loginsettingscolorbackcolor = ColorTranslator.FromHtml("#33A133");
				loginsettingscolor.BackColor = (loginsettingscolorbackcolor);

				var loadersettingscolorbackcolor = ColorTranslator.FromHtml("#33A133");
				loadersettingscolor.BackColor = (loadersettingscolorbackcolor);

				var remembermeoncheckbordercolor = ColorTranslator.FromHtml("#33A133");
				rememberme.OnCheck.BorderColor = (remembermeoncheckbordercolor);

				var remembermeoncheckcheckboxcolor = ColorTranslator.FromHtml("#33A133");
				rememberme.OnCheck.CheckBoxColor = (remembermeoncheckcheckboxcolor);

				var remembermeonhovercheckedbordercolor = ColorTranslator.FromHtml("#33A133");
				rememberme.OnHoverChecked.BorderColor = (remembermeonhovercheckedbordercolor);

				var remembermeonhovercheckedcheckboxcolor = ColorTranslator.FromHtml("#33A133");
				rememberme.OnHoverChecked.CheckBoxColor = (remembermeonhovercheckedcheckboxcolor);

				var remembermeonhoveruncheckedbordercolor = ColorTranslator.FromHtml("#33A133");
				rememberme.OnHoverUnchecked.BorderColor = (remembermeonhoveruncheckedbordercolor);

				var remembermeonuncheckbordercolor = ColorTranslator.FromHtml("#33A133");
				rememberme.OnUncheck.BorderColor = (remembermeonuncheckbordercolor);

				var autologinoncheckbordercolor = ColorTranslator.FromHtml("#33A133");
				autologin.OnCheck.BorderColor = (autologinoncheckbordercolor);

				var autologinoncheckcheckboxcolor = ColorTranslator.FromHtml("#33A133");
				autologin.OnCheck.CheckBoxColor = (autologinoncheckcheckboxcolor);

				var autologinonhovercheckedbordercolor = ColorTranslator.FromHtml("#33A133");
				autologin.OnHoverChecked.BorderColor = (autologinonhovercheckedbordercolor);

				var autologinonhovercheckedcheckboxcolor = ColorTranslator.FromHtml("#33A133");
				autologin.OnHoverChecked.CheckBoxColor = (autologinonhovercheckedcheckboxcolor);

				var autologinonhoveruncheckedbordercolor = ColorTranslator.FromHtml("#33A133");
				autologin.OnHoverUnchecked.BorderColor = (autologinonhoveruncheckedbordercolor);

				var autologinonuncheckbordercolor = ColorTranslator.FromHtml("#33A133");
				autologin.OnUncheck.BorderColor = (autologinonuncheckbordercolor);

				var autoupdatecheckoncheckbordercolor = ColorTranslator.FromHtml("#33A133");
				autoupdatecheck.OnCheck.BorderColor = (autoupdatecheckoncheckbordercolor);

				var autoupdatecheckoncheckcheckboxcolor = ColorTranslator.FromHtml("#33A133");
				autoupdatecheck.OnCheck.CheckBoxColor = (autoupdatecheckoncheckcheckboxcolor);

				var autoupdatecheckonhovercheckedbordercolor = ColorTranslator.FromHtml("#33A133");
				autoupdatecheck.OnHoverChecked.BorderColor = (autoupdatecheckonhovercheckedbordercolor);

				var autoupdatecheckonhovercheckedcheckboxcolor = ColorTranslator.FromHtml("#33A133");
				autoupdatecheck.OnHoverChecked.CheckBoxColor = (autoupdatecheckonhovercheckedcheckboxcolor);

				var autoupdatecheckonhoveruncheckedbordercolor = ColorTranslator.FromHtml("#33A133");
				autoupdatecheck.OnHoverUnchecked.BorderColor = (autoupdatecheckonhoveruncheckedbordercolor);

				var autoupdatecheckonuncheckbordercolor = ColorTranslator.FromHtml("#33A133");
				autoupdatecheck.OnUncheck.BorderColor = (autoupdatecheckonuncheckbordercolor);

				var autoinjectoncheckbordercolor = ColorTranslator.FromHtml("#33A133");
				autoinject.OnCheck.BorderColor = (autoinjectoncheckbordercolor);

				var autoinjectoncheckcheckboxcolor = ColorTranslator.FromHtml("#33A133");
				autoinject.OnCheck.CheckBoxColor = (autoinjectoncheckcheckboxcolor);

				var autoinjectonhovercheckedbordercolor = ColorTranslator.FromHtml("#33A133");
				autoinject.OnHoverChecked.BorderColor = (autoinjectonhovercheckedbordercolor);

				var autoinjectonhovercheckedcheckboxcolor = ColorTranslator.FromHtml("#33A133");
				autoinject.OnHoverChecked.CheckBoxColor = (autoinjectonhovercheckedcheckboxcolor);

				var autoinjectonhoveruncheckedbordercolor = ColorTranslator.FromHtml("#33A133");
				autoinject.OnHoverUnchecked.BorderColor = (autoinjectonhoveruncheckedbordercolor);

				var autoinjectonuncheckbordercolor = ColorTranslator.FromHtml("#33A133");
				autoinject.OnUncheck.BorderColor = (autoinjectonuncheckbordercolor);
			}

			if (Properties.Settings.Default.themecolor == "Green")
			{
				var loginsettingscolorbackcolor = ColorTranslator.FromHtml("#80BA45");
				loginsettingscolor.BackColor = (loginsettingscolorbackcolor);

				var loadersettingscolorbackcolor = ColorTranslator.FromHtml("#80BA45");
				loadersettingscolor.BackColor = (loadersettingscolorbackcolor);

				var remembermeoncheckbordercolor = ColorTranslator.FromHtml("#80BA45");
				rememberme.OnCheck.BorderColor = (remembermeoncheckbordercolor);

				var remembermeoncheckcheckboxcolor = ColorTranslator.FromHtml("#80BA45");
				rememberme.OnCheck.CheckBoxColor = (remembermeoncheckcheckboxcolor);

				var remembermeonhovercheckedbordercolor = ColorTranslator.FromHtml("#80BA45");
				rememberme.OnHoverChecked.BorderColor = (remembermeonhovercheckedbordercolor);

				var remembermeonhovercheckedcheckboxcolor = ColorTranslator.FromHtml("#80BA45");
				rememberme.OnHoverChecked.CheckBoxColor = (remembermeonhovercheckedcheckboxcolor);

				var remembermeonhoveruncheckedbordercolor = ColorTranslator.FromHtml("#80BA45");
				rememberme.OnHoverUnchecked.BorderColor = (remembermeonhoveruncheckedbordercolor);

				var remembermeonuncheckbordercolor = ColorTranslator.FromHtml("#80BA45");
				rememberme.OnUncheck.BorderColor = (remembermeonuncheckbordercolor);

				var autologinoncheckbordercolor = ColorTranslator.FromHtml("#80BA45");
				autologin.OnCheck.BorderColor = (autologinoncheckbordercolor);

				var autologinoncheckcheckboxcolor = ColorTranslator.FromHtml("#80BA45");
				autologin.OnCheck.CheckBoxColor = (autologinoncheckcheckboxcolor);

				var autologinonhovercheckedbordercolor = ColorTranslator.FromHtml("#80BA45");
				autologin.OnHoverChecked.BorderColor = (autologinonhovercheckedbordercolor);

				var autologinonhovercheckedcheckboxcolor = ColorTranslator.FromHtml("#80BA45");
				autologin.OnHoverChecked.CheckBoxColor = (autologinonhovercheckedcheckboxcolor);

				var autologinonhoveruncheckedbordercolor = ColorTranslator.FromHtml("#80BA45");
				autologin.OnHoverUnchecked.BorderColor = (autologinonhoveruncheckedbordercolor);

				var autologinonuncheckbordercolor = ColorTranslator.FromHtml("#80BA45");
				autologin.OnUncheck.BorderColor = (autologinonuncheckbordercolor);

				var autoupdatecheckoncheckbordercolor = ColorTranslator.FromHtml("#80BA45");
				autoupdatecheck.OnCheck.BorderColor = (autoupdatecheckoncheckbordercolor);

				var autoupdatecheckoncheckcheckboxcolor = ColorTranslator.FromHtml("#80BA45");
				autoupdatecheck.OnCheck.CheckBoxColor = (autoupdatecheckoncheckcheckboxcolor);

				var autoupdatecheckonhovercheckedbordercolor = ColorTranslator.FromHtml("#80BA45");
				autoupdatecheck.OnHoverChecked.BorderColor = (autoupdatecheckonhovercheckedbordercolor);

				var autoupdatecheckonhovercheckedcheckboxcolor = ColorTranslator.FromHtml("#80BA45");
				autoupdatecheck.OnHoverChecked.CheckBoxColor = (autoupdatecheckonhovercheckedcheckboxcolor);

				var autoupdatecheckonhoveruncheckedbordercolor = ColorTranslator.FromHtml("#80BA45");
				autoupdatecheck.OnHoverUnchecked.BorderColor = (autoupdatecheckonhoveruncheckedbordercolor);

				var autoupdatecheckonuncheckbordercolor = ColorTranslator.FromHtml("#80BA45");
				autoupdatecheck.OnUncheck.BorderColor = (autoupdatecheckonuncheckbordercolor);

				var autoinjectoncheckbordercolor = ColorTranslator.FromHtml("#80BA45");
				autoinject.OnCheck.BorderColor = (autoinjectoncheckbordercolor);

				var autoinjectoncheckcheckboxcolor = ColorTranslator.FromHtml("#80BA45");
				autoinject.OnCheck.CheckBoxColor = (autoinjectoncheckcheckboxcolor);

				var autoinjectonhovercheckedbordercolor = ColorTranslator.FromHtml("#80BA45");
				autoinject.OnHoverChecked.BorderColor = (autoinjectonhovercheckedbordercolor);

				var autoinjectonhovercheckedcheckboxcolor = ColorTranslator.FromHtml("#80BA45");
				autoinject.OnHoverChecked.CheckBoxColor = (autoinjectonhovercheckedcheckboxcolor);

				var autoinjectonhoveruncheckedbordercolor = ColorTranslator.FromHtml("#80BA45");
				autoinject.OnHoverUnchecked.BorderColor = (autoinjectonhoveruncheckedbordercolor);

				var autoinjectonuncheckbordercolor = ColorTranslator.FromHtml("#80BA45");
				autoinject.OnUncheck.BorderColor = (autoinjectonuncheckbordercolor);
			}

			if (Properties.Settings.Default.themecolor == "Indigo")
			{
				var loginsettingscolorbackcolor = ColorTranslator.FromHtml("#8833FF");
				loginsettingscolor.BackColor = (loginsettingscolorbackcolor);

				var loadersettingscolorbackcolor = ColorTranslator.FromHtml("#8833FF");
				loadersettingscolor.BackColor = (loadersettingscolorbackcolor);

				var remembermeoncheckbordercolor = ColorTranslator.FromHtml("#8833FF");
				rememberme.OnCheck.BorderColor = (remembermeoncheckbordercolor);

				var remembermeoncheckcheckboxcolor = ColorTranslator.FromHtml("#8833FF");
				rememberme.OnCheck.CheckBoxColor = (remembermeoncheckcheckboxcolor);

				var remembermeonhovercheckedbordercolor = ColorTranslator.FromHtml("#8833FF");
				rememberme.OnHoverChecked.BorderColor = (remembermeonhovercheckedbordercolor);

				var remembermeonhovercheckedcheckboxcolor = ColorTranslator.FromHtml("#8833FF");
				rememberme.OnHoverChecked.CheckBoxColor = (remembermeonhovercheckedcheckboxcolor);

				var remembermeonhoveruncheckedbordercolor = ColorTranslator.FromHtml("#8833FF");
				rememberme.OnHoverUnchecked.BorderColor = (remembermeonhoveruncheckedbordercolor);

				var remembermeonuncheckbordercolor = ColorTranslator.FromHtml("#8833FF");
				rememberme.OnUncheck.BorderColor = (remembermeonuncheckbordercolor);

				var autologinoncheckbordercolor = ColorTranslator.FromHtml("#8833FF");
				autologin.OnCheck.BorderColor = (autologinoncheckbordercolor);

				var autologinoncheckcheckboxcolor = ColorTranslator.FromHtml("#8833FF");
				autologin.OnCheck.CheckBoxColor = (autologinoncheckcheckboxcolor);

				var autologinonhovercheckedbordercolor = ColorTranslator.FromHtml("#8833FF");
				autologin.OnHoverChecked.BorderColor = (autologinonhovercheckedbordercolor);

				var autologinonhovercheckedcheckboxcolor = ColorTranslator.FromHtml("#8833FF");
				autologin.OnHoverChecked.CheckBoxColor = (autologinonhovercheckedcheckboxcolor);

				var autologinonhoveruncheckedbordercolor = ColorTranslator.FromHtml("#8833FF");
				autologin.OnHoverUnchecked.BorderColor = (autologinonhoveruncheckedbordercolor);

				var autologinonuncheckbordercolor = ColorTranslator.FromHtml("#8833FF");
				autologin.OnUncheck.BorderColor = (autologinonuncheckbordercolor);

				var autoupdatecheckoncheckbordercolor = ColorTranslator.FromHtml("#8833FF");
				autoupdatecheck.OnCheck.BorderColor = (autoupdatecheckoncheckbordercolor);

				var autoupdatecheckoncheckcheckboxcolor = ColorTranslator.FromHtml("#8833FF");
				autoupdatecheck.OnCheck.CheckBoxColor = (autoupdatecheckoncheckcheckboxcolor);

				var autoupdatecheckonhovercheckedbordercolor = ColorTranslator.FromHtml("#8833FF");
				autoupdatecheck.OnHoverChecked.BorderColor = (autoupdatecheckonhovercheckedbordercolor);

				var autoupdatecheckonhovercheckedcheckboxcolor = ColorTranslator.FromHtml("#8833FF");
				autoupdatecheck.OnHoverChecked.CheckBoxColor = (autoupdatecheckonhovercheckedcheckboxcolor);

				var autoupdatecheckonhoveruncheckedbordercolor = ColorTranslator.FromHtml("#8833FF");
				autoupdatecheck.OnHoverUnchecked.BorderColor = (autoupdatecheckonhoveruncheckedbordercolor);

				var autoupdatecheckonuncheckbordercolor = ColorTranslator.FromHtml("#8833FF");
				autoupdatecheck.OnUncheck.BorderColor = (autoupdatecheckonuncheckbordercolor);

				var autoinjectoncheckbordercolor = ColorTranslator.FromHtml("#8833FF");
				autoinject.OnCheck.BorderColor = (autoinjectoncheckbordercolor);

				var autoinjectoncheckcheckboxcolor = ColorTranslator.FromHtml("#8833FF");
				autoinject.OnCheck.CheckBoxColor = (autoinjectoncheckcheckboxcolor);

				var autoinjectonhovercheckedbordercolor = ColorTranslator.FromHtml("#8833FF");
				autoinject.OnHoverChecked.BorderColor = (autoinjectonhovercheckedbordercolor);

				var autoinjectonhovercheckedcheckboxcolor = ColorTranslator.FromHtml("#8833FF");
				autoinject.OnHoverChecked.CheckBoxColor = (autoinjectonhovercheckedcheckboxcolor);

				var autoinjectonhoveruncheckedbordercolor = ColorTranslator.FromHtml("#8833FF");
				autoinject.OnHoverUnchecked.BorderColor = (autoinjectonhoveruncheckedbordercolor);

				var autoinjectonuncheckbordercolor = ColorTranslator.FromHtml("#8833FF");
				autoinject.OnUncheck.BorderColor = (autoinjectonuncheckbordercolor);
			}

			if (Properties.Settings.Default.themecolor == "Magenta")
			{
				var loginsettingscolorbackcolor = ColorTranslator.FromHtml("#E0338F");
				loginsettingscolor.BackColor = (loginsettingscolorbackcolor);

				var loadersettingscolorbackcolor = ColorTranslator.FromHtml("#E0338F");
				loadersettingscolor.BackColor = (loadersettingscolorbackcolor);

				var remembermeoncheckbordercolor = ColorTranslator.FromHtml("#E0338F");
				rememberme.OnCheck.BorderColor = (remembermeoncheckbordercolor);

				var remembermeoncheckcheckboxcolor = ColorTranslator.FromHtml("#E0338F");
				rememberme.OnCheck.CheckBoxColor = (remembermeoncheckcheckboxcolor);

				var remembermeonhovercheckedbordercolor = ColorTranslator.FromHtml("#E0338F");
				rememberme.OnHoverChecked.BorderColor = (remembermeonhovercheckedbordercolor);

				var remembermeonhovercheckedcheckboxcolor = ColorTranslator.FromHtml("#E0338F");
				rememberme.OnHoverChecked.CheckBoxColor = (remembermeonhovercheckedcheckboxcolor);

				var remembermeonhoveruncheckedbordercolor = ColorTranslator.FromHtml("#E0338F");
				rememberme.OnHoverUnchecked.BorderColor = (remembermeonhoveruncheckedbordercolor);

				var remembermeonuncheckbordercolor = ColorTranslator.FromHtml("#E0338F");
				rememberme.OnUncheck.BorderColor = (remembermeonuncheckbordercolor);

				var autologinoncheckbordercolor = ColorTranslator.FromHtml("#E0338F");
				autologin.OnCheck.BorderColor = (autologinoncheckbordercolor);

				var autologinoncheckcheckboxcolor = ColorTranslator.FromHtml("#E0338F");
				autologin.OnCheck.CheckBoxColor = (autologinoncheckcheckboxcolor);

				var autologinonhovercheckedbordercolor = ColorTranslator.FromHtml("#E0338F");
				autologin.OnHoverChecked.BorderColor = (autologinonhovercheckedbordercolor);

				var autologinonhovercheckedcheckboxcolor = ColorTranslator.FromHtml("#E0338F");
				autologin.OnHoverChecked.CheckBoxColor = (autologinonhovercheckedcheckboxcolor);

				var autologinonhoveruncheckedbordercolor = ColorTranslator.FromHtml("#E0338F");
				autologin.OnHoverUnchecked.BorderColor = (autologinonhoveruncheckedbordercolor);

				var autologinonuncheckbordercolor = ColorTranslator.FromHtml("#E0338F");
				autologin.OnUncheck.BorderColor = (autologinonuncheckbordercolor);

				var autoupdatecheckoncheckbordercolor = ColorTranslator.FromHtml("#E0338F");
				autoupdatecheck.OnCheck.BorderColor = (autoupdatecheckoncheckbordercolor);

				var autoupdatecheckoncheckcheckboxcolor = ColorTranslator.FromHtml("#E0338F");
				autoupdatecheck.OnCheck.CheckBoxColor = (autoupdatecheckoncheckcheckboxcolor);

				var autoupdatecheckonhovercheckedbordercolor = ColorTranslator.FromHtml("#E0338F");
				autoupdatecheck.OnHoverChecked.BorderColor = (autoupdatecheckonhovercheckedbordercolor);

				var autoupdatecheckonhovercheckedcheckboxcolor = ColorTranslator.FromHtml("#E0338F");
				autoupdatecheck.OnHoverChecked.CheckBoxColor = (autoupdatecheckonhovercheckedcheckboxcolor);

				var autoupdatecheckonhoveruncheckedbordercolor = ColorTranslator.FromHtml("#E0338F");
				autoupdatecheck.OnHoverUnchecked.BorderColor = (autoupdatecheckonhoveruncheckedbordercolor);

				var autoupdatecheckonuncheckbordercolor = ColorTranslator.FromHtml("#E0338F");
				autoupdatecheck.OnUncheck.BorderColor = (autoupdatecheckonuncheckbordercolor);

				var autoinjectoncheckbordercolor = ColorTranslator.FromHtml("#E0338F");
				autoinject.OnCheck.BorderColor = (autoinjectoncheckbordercolor);

				var autoinjectoncheckcheckboxcolor = ColorTranslator.FromHtml("#E0338F");
				autoinject.OnCheck.CheckBoxColor = (autoinjectoncheckcheckboxcolor);

				var autoinjectonhovercheckedbordercolor = ColorTranslator.FromHtml("#E0338F");
				autoinject.OnHoverChecked.BorderColor = (autoinjectonhovercheckedbordercolor);

				var autoinjectonhovercheckedcheckboxcolor = ColorTranslator.FromHtml("#E0338F");
				autoinject.OnHoverChecked.CheckBoxColor = (autoinjectonhovercheckedcheckboxcolor);

				var autoinjectonhoveruncheckedbordercolor = ColorTranslator.FromHtml("#E0338F");
				autoinject.OnHoverUnchecked.BorderColor = (autoinjectonhoveruncheckedbordercolor);

				var autoinjectonuncheckbordercolor = ColorTranslator.FromHtml("#E0338F");
				autoinject.OnUncheck.BorderColor = (autoinjectonuncheckbordercolor);
			}

			if (Properties.Settings.Default.themecolor == "Mauve")
			{
				var loginsettingscolorbackcolor = ColorTranslator.FromHtml("#9180A1");
				loginsettingscolor.BackColor = (loginsettingscolorbackcolor);

				var loadersettingscolorbackcolor = ColorTranslator.FromHtml("#9180A1");
				loadersettingscolor.BackColor = (loadersettingscolorbackcolor);

				var remembermeoncheckbordercolor = ColorTranslator.FromHtml("#9180A1");
				rememberme.OnCheck.BorderColor = (remembermeoncheckbordercolor);

				var remembermeoncheckcheckboxcolor = ColorTranslator.FromHtml("#9180A1");
				rememberme.OnCheck.CheckBoxColor = (remembermeoncheckcheckboxcolor);

				var remembermeonhovercheckedbordercolor = ColorTranslator.FromHtml("#9180A1");
				rememberme.OnHoverChecked.BorderColor = (remembermeonhovercheckedbordercolor);

				var remembermeonhovercheckedcheckboxcolor = ColorTranslator.FromHtml("#9180A1");
				rememberme.OnHoverChecked.CheckBoxColor = (remembermeonhovercheckedcheckboxcolor);

				var remembermeonhoveruncheckedbordercolor = ColorTranslator.FromHtml("#9180A1");
				rememberme.OnHoverUnchecked.BorderColor = (remembermeonhoveruncheckedbordercolor);

				var remembermeonuncheckbordercolor = ColorTranslator.FromHtml("#9180A1");
				rememberme.OnUncheck.BorderColor = (remembermeonuncheckbordercolor);

				var autologinoncheckbordercolor = ColorTranslator.FromHtml("#9180A1");
				autologin.OnCheck.BorderColor = (autologinoncheckbordercolor);

				var autologinoncheckcheckboxcolor = ColorTranslator.FromHtml("#9180A1");
				autologin.OnCheck.CheckBoxColor = (autologinoncheckcheckboxcolor);

				var autologinonhovercheckedbordercolor = ColorTranslator.FromHtml("#9180A1");
				autologin.OnHoverChecked.BorderColor = (autologinonhovercheckedbordercolor);

				var autologinonhovercheckedcheckboxcolor = ColorTranslator.FromHtml("#9180A1");
				autologin.OnHoverChecked.CheckBoxColor = (autologinonhovercheckedcheckboxcolor);

				var autologinonhoveruncheckedbordercolor = ColorTranslator.FromHtml("#9180A1");
				autologin.OnHoverUnchecked.BorderColor = (autologinonhoveruncheckedbordercolor);

				var autologinonuncheckbordercolor = ColorTranslator.FromHtml("#9180A1");
				autologin.OnUncheck.BorderColor = (autologinonuncheckbordercolor);

				var autoupdatecheckoncheckbordercolor = ColorTranslator.FromHtml("#9180A1");
				autoupdatecheck.OnCheck.BorderColor = (autoupdatecheckoncheckbordercolor);

				var autoupdatecheckoncheckcheckboxcolor = ColorTranslator.FromHtml("#9180A1");
				autoupdatecheck.OnCheck.CheckBoxColor = (autoupdatecheckoncheckcheckboxcolor);

				var autoupdatecheckonhovercheckedbordercolor = ColorTranslator.FromHtml("#9180A1");
				autoupdatecheck.OnHoverChecked.BorderColor = (autoupdatecheckonhovercheckedbordercolor);

				var autoupdatecheckonhovercheckedcheckboxcolor = ColorTranslator.FromHtml("#9180A1");
				autoupdatecheck.OnHoverChecked.CheckBoxColor = (autoupdatecheckonhovercheckedcheckboxcolor);

				var autoupdatecheckonhoveruncheckedbordercolor = ColorTranslator.FromHtml("#9180A1");
				autoupdatecheck.OnHoverUnchecked.BorderColor = (autoupdatecheckonhoveruncheckedbordercolor);

				var autoupdatecheckonuncheckbordercolor = ColorTranslator.FromHtml("#9180A1");
				autoupdatecheck.OnUncheck.BorderColor = (autoupdatecheckonuncheckbordercolor);

				var autoinjectoncheckbordercolor = ColorTranslator.FromHtml("#9180A1");
				autoinject.OnCheck.BorderColor = (autoinjectoncheckbordercolor);

				var autoinjectoncheckcheckboxcolor = ColorTranslator.FromHtml("#9180A1");
				autoinject.OnCheck.CheckBoxColor = (autoinjectoncheckcheckboxcolor);

				var autoinjectonhovercheckedbordercolor = ColorTranslator.FromHtml("#9180A1");
				autoinject.OnHoverChecked.BorderColor = (autoinjectonhovercheckedbordercolor);

				var autoinjectonhovercheckedcheckboxcolor = ColorTranslator.FromHtml("#9180A1");
				autoinject.OnHoverChecked.CheckBoxColor = (autoinjectonhovercheckedcheckboxcolor);

				var autoinjectonhoveruncheckedbordercolor = ColorTranslator.FromHtml("#9180A1");
				autoinject.OnHoverUnchecked.BorderColor = (autoinjectonhoveruncheckedbordercolor);

				var autoinjectonuncheckbordercolor = ColorTranslator.FromHtml("#9180A1");
				autoinject.OnUncheck.BorderColor = (autoinjectonuncheckbordercolor);
			}

			if (Properties.Settings.Default.themecolor == "Orange")
			{
				var loginsettingscolorbackcolor = ColorTranslator.FromHtml("#FB8633");
				loginsettingscolor.BackColor = (loginsettingscolorbackcolor);

				var loadersettingscolorbackcolor = ColorTranslator.FromHtml("#FB8633");
				loadersettingscolor.BackColor = (loadersettingscolorbackcolor);

				var remembermeoncheckbordercolor = ColorTranslator.FromHtml("#FB8633");
				rememberme.OnCheck.BorderColor = (remembermeoncheckbordercolor);

				var remembermeoncheckcheckboxcolor = ColorTranslator.FromHtml("#FB8633");
				rememberme.OnCheck.CheckBoxColor = (remembermeoncheckcheckboxcolor);

				var remembermeonhovercheckedbordercolor = ColorTranslator.FromHtml("#FB8633");
				rememberme.OnHoverChecked.BorderColor = (remembermeonhovercheckedbordercolor);

				var remembermeonhovercheckedcheckboxcolor = ColorTranslator.FromHtml("#FB8633");
				rememberme.OnHoverChecked.CheckBoxColor = (remembermeonhovercheckedcheckboxcolor);

				var remembermeonhoveruncheckedbordercolor = ColorTranslator.FromHtml("#FB8633");
				rememberme.OnHoverUnchecked.BorderColor = (remembermeonhoveruncheckedbordercolor);

				var remembermeonuncheckbordercolor = ColorTranslator.FromHtml("#FB8633");
				rememberme.OnUncheck.BorderColor = (remembermeonuncheckbordercolor);

				var autologinoncheckbordercolor = ColorTranslator.FromHtml("#FB8633");
				autologin.OnCheck.BorderColor = (autologinoncheckbordercolor);

				var autologinoncheckcheckboxcolor = ColorTranslator.FromHtml("#FB8633");
				autologin.OnCheck.CheckBoxColor = (autologinoncheckcheckboxcolor);

				var autologinonhovercheckedbordercolor = ColorTranslator.FromHtml("#FB8633");
				autologin.OnHoverChecked.BorderColor = (autologinonhovercheckedbordercolor);

				var autologinonhovercheckedcheckboxcolor = ColorTranslator.FromHtml("#FB8633");
				autologin.OnHoverChecked.CheckBoxColor = (autologinonhovercheckedcheckboxcolor);

				var autologinonhoveruncheckedbordercolor = ColorTranslator.FromHtml("#FB8633");
				autologin.OnHoverUnchecked.BorderColor = (autologinonhoveruncheckedbordercolor);

				var autologinonuncheckbordercolor = ColorTranslator.FromHtml("#FB8633");
				autologin.OnUncheck.BorderColor = (autologinonuncheckbordercolor);

				var autoupdatecheckoncheckbordercolor = ColorTranslator.FromHtml("#FB8633");
				autoupdatecheck.OnCheck.BorderColor = (autoupdatecheckoncheckbordercolor);

				var autoupdatecheckoncheckcheckboxcolor = ColorTranslator.FromHtml("#FB8633");
				autoupdatecheck.OnCheck.CheckBoxColor = (autoupdatecheckoncheckcheckboxcolor);

				var autoupdatecheckonhovercheckedbordercolor = ColorTranslator.FromHtml("#FB8633");
				autoupdatecheck.OnHoverChecked.BorderColor = (autoupdatecheckonhovercheckedbordercolor);

				var autoupdatecheckonhovercheckedcheckboxcolor = ColorTranslator.FromHtml("#FB8633");
				autoupdatecheck.OnHoverChecked.CheckBoxColor = (autoupdatecheckonhovercheckedcheckboxcolor);

				var autoupdatecheckonhoveruncheckedbordercolor = ColorTranslator.FromHtml("#FB8633");
				autoupdatecheck.OnHoverUnchecked.BorderColor = (autoupdatecheckonhoveruncheckedbordercolor);

				var autoupdatecheckonuncheckbordercolor = ColorTranslator.FromHtml("#FB8633");
				autoupdatecheck.OnUncheck.BorderColor = (autoupdatecheckonuncheckbordercolor);

				var autoinjectoncheckbordercolor = ColorTranslator.FromHtml("#FB8633");
				autoinject.OnCheck.BorderColor = (autoinjectoncheckbordercolor);

				var autoinjectoncheckcheckboxcolor = ColorTranslator.FromHtml("#FB8633");
				autoinject.OnCheck.CheckBoxColor = (autoinjectoncheckcheckboxcolor);

				var autoinjectonhovercheckedbordercolor = ColorTranslator.FromHtml("#FB8633");
				autoinject.OnHoverChecked.BorderColor = (autoinjectonhovercheckedbordercolor);

				var autoinjectonhovercheckedcheckboxcolor = ColorTranslator.FromHtml("#FB8633");
				autoinject.OnHoverChecked.CheckBoxColor = (autoinjectonhovercheckedcheckboxcolor);

				var autoinjectonhoveruncheckedbordercolor = ColorTranslator.FromHtml("#FB8633");
				autoinject.OnHoverUnchecked.BorderColor = (autoinjectonhoveruncheckedbordercolor);

				var autoinjectonuncheckbordercolor = ColorTranslator.FromHtml("#FB8633");
				autoinject.OnUncheck.BorderColor = (autoinjectonuncheckbordercolor);
			}

			if (Properties.Settings.Default.themecolor == "Pink")
			{
				var loginsettingscolorbackcolor = ColorTranslator.FromHtml("#F68ED9");
				loginsettingscolor.BackColor = (loginsettingscolorbackcolor);

				var loadersettingscolorbackcolor = ColorTranslator.FromHtml("#F68ED9");
				loadersettingscolor.BackColor = (loadersettingscolorbackcolor);

				var remembermeoncheckbordercolor = ColorTranslator.FromHtml("#F68ED9");
				rememberme.OnCheck.BorderColor = (remembermeoncheckbordercolor);

				var remembermeoncheckcheckboxcolor = ColorTranslator.FromHtml("#F68ED9");
				rememberme.OnCheck.CheckBoxColor = (remembermeoncheckcheckboxcolor);

				var remembermeonhovercheckedbordercolor = ColorTranslator.FromHtml("#F68ED9");
				rememberme.OnHoverChecked.BorderColor = (remembermeonhovercheckedbordercolor);

				var remembermeonhovercheckedcheckboxcolor = ColorTranslator.FromHtml("#F68ED9");
				rememberme.OnHoverChecked.CheckBoxColor = (remembermeonhovercheckedcheckboxcolor);

				var remembermeonhoveruncheckedbordercolor = ColorTranslator.FromHtml("#F68ED9");
				rememberme.OnHoverUnchecked.BorderColor = (remembermeonhoveruncheckedbordercolor);

				var remembermeonuncheckbordercolor = ColorTranslator.FromHtml("#F68ED9");
				rememberme.OnUncheck.BorderColor = (remembermeonuncheckbordercolor);

				var autologinoncheckbordercolor = ColorTranslator.FromHtml("#F68ED9");
				autologin.OnCheck.BorderColor = (autologinoncheckbordercolor);

				var autologinoncheckcheckboxcolor = ColorTranslator.FromHtml("#F68ED9");
				autologin.OnCheck.CheckBoxColor = (autologinoncheckcheckboxcolor);

				var autologinonhovercheckedbordercolor = ColorTranslator.FromHtml("#F68ED9");
				autologin.OnHoverChecked.BorderColor = (autologinonhovercheckedbordercolor);

				var autologinonhovercheckedcheckboxcolor = ColorTranslator.FromHtml("#F68ED9");
				autologin.OnHoverChecked.CheckBoxColor = (autologinonhovercheckedcheckboxcolor);

				var autologinonhoveruncheckedbordercolor = ColorTranslator.FromHtml("#F68ED9");
				autologin.OnHoverUnchecked.BorderColor = (autologinonhoveruncheckedbordercolor);

				var autologinonuncheckbordercolor = ColorTranslator.FromHtml("#F68ED9");
				autologin.OnUncheck.BorderColor = (autologinonuncheckbordercolor);

				var autoupdatecheckoncheckbordercolor = ColorTranslator.FromHtml("#F68ED9");
				autoupdatecheck.OnCheck.BorderColor = (autoupdatecheckoncheckbordercolor);

				var autoupdatecheckoncheckcheckboxcolor = ColorTranslator.FromHtml("#F68ED9");
				autoupdatecheck.OnCheck.CheckBoxColor = (autoupdatecheckoncheckcheckboxcolor);

				var autoupdatecheckonhovercheckedbordercolor = ColorTranslator.FromHtml("#F68ED9");
				autoupdatecheck.OnHoverChecked.BorderColor = (autoupdatecheckonhovercheckedbordercolor);

				var autoupdatecheckonhovercheckedcheckboxcolor = ColorTranslator.FromHtml("#F68ED9");
				autoupdatecheck.OnHoverChecked.CheckBoxColor = (autoupdatecheckonhovercheckedcheckboxcolor);

				var autoupdatecheckonhoveruncheckedbordercolor = ColorTranslator.FromHtml("#F68ED9");
				autoupdatecheck.OnHoverUnchecked.BorderColor = (autoupdatecheckonhoveruncheckedbordercolor);

				var autoupdatecheckonuncheckbordercolor = ColorTranslator.FromHtml("#F68ED9");
				autoupdatecheck.OnUncheck.BorderColor = (autoupdatecheckonuncheckbordercolor);

				var autoinjectoncheckbordercolor = ColorTranslator.FromHtml("#F68ED9");
				autoinject.OnCheck.BorderColor = (autoinjectoncheckbordercolor);

				var autoinjectoncheckcheckboxcolor = ColorTranslator.FromHtml("#F68ED9");
				autoinject.OnCheck.CheckBoxColor = (autoinjectoncheckcheckboxcolor);

				var autoinjectonhovercheckedbordercolor = ColorTranslator.FromHtml("#F68ED9");
				autoinject.OnHoverChecked.BorderColor = (autoinjectonhovercheckedbordercolor);

				var autoinjectonhovercheckedcheckboxcolor = ColorTranslator.FromHtml("#F68ED9");
				autoinject.OnHoverChecked.CheckBoxColor = (autoinjectonhovercheckedcheckboxcolor);

				var autoinjectonhoveruncheckedbordercolor = ColorTranslator.FromHtml("#F68ED9");
				autoinject.OnHoverUnchecked.BorderColor = (autoinjectonhoveruncheckedbordercolor);

				var autoinjectonuncheckbordercolor = ColorTranslator.FromHtml("#F68ED9");
				autoinject.OnUncheck.BorderColor = (autoinjectonuncheckbordercolor);
			}

			if (Properties.Settings.Default.themecolor == "Purple")
			{
				var loginsettingscolorbackcolor = ColorTranslator.FromHtml("#837AE5");
				loginsettingscolor.BackColor = (loginsettingscolorbackcolor);

				var loadersettingscolorbackcolor = ColorTranslator.FromHtml("#837AE5");
				loadersettingscolor.BackColor = (loadersettingscolorbackcolor);

				var remembermeoncheckbordercolor = ColorTranslator.FromHtml("#837AE5");
				rememberme.OnCheck.BorderColor = (remembermeoncheckbordercolor);

				var remembermeoncheckcheckboxcolor = ColorTranslator.FromHtml("#837AE5");
				rememberme.OnCheck.CheckBoxColor = (remembermeoncheckcheckboxcolor);

				var remembermeonhovercheckedbordercolor = ColorTranslator.FromHtml("#837AE5");
				rememberme.OnHoverChecked.BorderColor = (remembermeonhovercheckedbordercolor);

				var remembermeonhovercheckedcheckboxcolor = ColorTranslator.FromHtml("#837AE5");
				rememberme.OnHoverChecked.CheckBoxColor = (remembermeonhovercheckedcheckboxcolor);

				var remembermeonhoveruncheckedbordercolor = ColorTranslator.FromHtml("#837AE5");
				rememberme.OnHoverUnchecked.BorderColor = (remembermeonhoveruncheckedbordercolor);

				var remembermeonuncheckbordercolor = ColorTranslator.FromHtml("#837AE5");
				rememberme.OnUncheck.BorderColor = (remembermeonuncheckbordercolor);

				var autologinoncheckbordercolor = ColorTranslator.FromHtml("#837AE5");
				autologin.OnCheck.BorderColor = (autologinoncheckbordercolor);

				var autologinoncheckcheckboxcolor = ColorTranslator.FromHtml("#837AE5");
				autologin.OnCheck.CheckBoxColor = (autologinoncheckcheckboxcolor);

				var autologinonhovercheckedbordercolor = ColorTranslator.FromHtml("#837AE5");
				autologin.OnHoverChecked.BorderColor = (autologinonhovercheckedbordercolor);

				var autologinonhovercheckedcheckboxcolor = ColorTranslator.FromHtml("#837AE5");
				autologin.OnHoverChecked.CheckBoxColor = (autologinonhovercheckedcheckboxcolor);

				var autologinonhoveruncheckedbordercolor = ColorTranslator.FromHtml("#837AE5");
				autologin.OnHoverUnchecked.BorderColor = (autologinonhoveruncheckedbordercolor);

				var autologinonuncheckbordercolor = ColorTranslator.FromHtml("#837AE5");
				autologin.OnUncheck.BorderColor = (autologinonuncheckbordercolor);

				var autoupdatecheckoncheckbordercolor = ColorTranslator.FromHtml("#837AE5");
				autoupdatecheck.OnCheck.BorderColor = (autoupdatecheckoncheckbordercolor);

				var autoupdatecheckoncheckcheckboxcolor = ColorTranslator.FromHtml("#837AE5");
				autoupdatecheck.OnCheck.CheckBoxColor = (autoupdatecheckoncheckcheckboxcolor);

				var autoupdatecheckonhovercheckedbordercolor = ColorTranslator.FromHtml("#837AE5");
				autoupdatecheck.OnHoverChecked.BorderColor = (autoupdatecheckonhovercheckedbordercolor);

				var autoupdatecheckonhovercheckedcheckboxcolor = ColorTranslator.FromHtml("#837AE5");
				autoupdatecheck.OnHoverChecked.CheckBoxColor = (autoupdatecheckonhovercheckedcheckboxcolor);

				var autoupdatecheckonhoveruncheckedbordercolor = ColorTranslator.FromHtml("#837AE5");
				autoupdatecheck.OnHoverUnchecked.BorderColor = (autoupdatecheckonhoveruncheckedbordercolor);

				var autoupdatecheckonuncheckbordercolor = ColorTranslator.FromHtml("#837AE5");
				autoupdatecheck.OnUncheck.BorderColor = (autoupdatecheckonuncheckbordercolor);

				var autoinjectoncheckbordercolor = ColorTranslator.FromHtml("#837AE5");
				autoinject.OnCheck.BorderColor = (autoinjectoncheckbordercolor);

				var autoinjectoncheckcheckboxcolor = ColorTranslator.FromHtml("#837AE5");
				autoinject.OnCheck.CheckBoxColor = (autoinjectoncheckcheckboxcolor);

				var autoinjectonhovercheckedbordercolor = ColorTranslator.FromHtml("#837AE5");
				autoinject.OnHoverChecked.BorderColor = (autoinjectonhovercheckedbordercolor);

				var autoinjectonhovercheckedcheckboxcolor = ColorTranslator.FromHtml("#837AE5");
				autoinject.OnHoverChecked.CheckBoxColor = (autoinjectonhovercheckedcheckboxcolor);

				var autoinjectonhoveruncheckedbordercolor = ColorTranslator.FromHtml("#837AE5");
				autoinject.OnHoverUnchecked.BorderColor = (autoinjectonhoveruncheckedbordercolor);

				var autoinjectonuncheckbordercolor = ColorTranslator.FromHtml("#837AE5");
				autoinject.OnUncheck.BorderColor = (autoinjectonuncheckbordercolor);
			}

			if (Properties.Settings.Default.themecolor == "Red")
			{
				var loginsettingscolorbackcolor = ColorTranslator.FromHtml("#EA4333");
				loginsettingscolor.BackColor = (loginsettingscolorbackcolor);

				var loadersettingscolorbackcolor = ColorTranslator.FromHtml("#EA4333");
				loadersettingscolor.BackColor = (loadersettingscolorbackcolor);

				var remembermeoncheckbordercolor = ColorTranslator.FromHtml("#EA4333");
				rememberme.OnCheck.BorderColor = (remembermeoncheckbordercolor);

				var remembermeoncheckcheckboxcolor = ColorTranslator.FromHtml("#EA4333");
				rememberme.OnCheck.CheckBoxColor = (remembermeoncheckcheckboxcolor);

				var remembermeonhovercheckedbordercolor = ColorTranslator.FromHtml("#EA4333");
				rememberme.OnHoverChecked.BorderColor = (remembermeonhovercheckedbordercolor);

				var remembermeonhovercheckedcheckboxcolor = ColorTranslator.FromHtml("#EA4333");
				rememberme.OnHoverChecked.CheckBoxColor = (remembermeonhovercheckedcheckboxcolor);

				var remembermeonhoveruncheckedbordercolor = ColorTranslator.FromHtml("#EA4333");
				rememberme.OnHoverUnchecked.BorderColor = (remembermeonhoveruncheckedbordercolor);

				var remembermeonuncheckbordercolor = ColorTranslator.FromHtml("#EA4333");
				rememberme.OnUncheck.BorderColor = (remembermeonuncheckbordercolor);

				var autologinoncheckbordercolor = ColorTranslator.FromHtml("#EA4333");
				autologin.OnCheck.BorderColor = (autologinoncheckbordercolor);

				var autologinoncheckcheckboxcolor = ColorTranslator.FromHtml("#EA4333");
				autologin.OnCheck.CheckBoxColor = (autologinoncheckcheckboxcolor);

				var autologinonhovercheckedbordercolor = ColorTranslator.FromHtml("#EA4333");
				autologin.OnHoverChecked.BorderColor = (autologinonhovercheckedbordercolor);

				var autologinonhovercheckedcheckboxcolor = ColorTranslator.FromHtml("#EA4333");
				autologin.OnHoverChecked.CheckBoxColor = (autologinonhovercheckedcheckboxcolor);

				var autologinonhoveruncheckedbordercolor = ColorTranslator.FromHtml("#EA4333");
				autologin.OnHoverUnchecked.BorderColor = (autologinonhoveruncheckedbordercolor);

				var autologinonuncheckbordercolor = ColorTranslator.FromHtml("#EA4333");
				autologin.OnUncheck.BorderColor = (autologinonuncheckbordercolor);

				var autoupdatecheckoncheckbordercolor = ColorTranslator.FromHtml("#EA4333");
				autoupdatecheck.OnCheck.BorderColor = (autoupdatecheckoncheckbordercolor);

				var autoupdatecheckoncheckcheckboxcolor = ColorTranslator.FromHtml("#EA4333");
				autoupdatecheck.OnCheck.CheckBoxColor = (autoupdatecheckoncheckcheckboxcolor);

				var autoupdatecheckonhovercheckedbordercolor = ColorTranslator.FromHtml("#EA4333");
				autoupdatecheck.OnHoverChecked.BorderColor = (autoupdatecheckonhovercheckedbordercolor);

				var autoupdatecheckonhovercheckedcheckboxcolor = ColorTranslator.FromHtml("#EA4333");
				autoupdatecheck.OnHoverChecked.CheckBoxColor = (autoupdatecheckonhovercheckedcheckboxcolor);

				var autoupdatecheckonhoveruncheckedbordercolor = ColorTranslator.FromHtml("#EA4333");
				autoupdatecheck.OnHoverUnchecked.BorderColor = (autoupdatecheckonhoveruncheckedbordercolor);

				var autoupdatecheckonuncheckbordercolor = ColorTranslator.FromHtml("#EA4333");
				autoupdatecheck.OnUncheck.BorderColor = (autoupdatecheckonuncheckbordercolor);

				var autoinjectoncheckbordercolor = ColorTranslator.FromHtml("#EA4333");
				autoinject.OnCheck.BorderColor = (autoinjectoncheckbordercolor);

				var autoinjectoncheckcheckboxcolor = ColorTranslator.FromHtml("#EA4333");
				autoinject.OnCheck.CheckBoxColor = (autoinjectoncheckcheckboxcolor);

				var autoinjectonhovercheckedbordercolor = ColorTranslator.FromHtml("#EA4333");
				autoinject.OnHoverChecked.BorderColor = (autoinjectonhovercheckedbordercolor);

				var autoinjectonhovercheckedcheckboxcolor = ColorTranslator.FromHtml("#EA4333");
				autoinject.OnHoverChecked.CheckBoxColor = (autoinjectonhovercheckedcheckboxcolor);

				var autoinjectonhoveruncheckedbordercolor = ColorTranslator.FromHtml("#EA4333");
				autoinject.OnHoverUnchecked.BorderColor = (autoinjectonhoveruncheckedbordercolor);

				var autoinjectonuncheckbordercolor = ColorTranslator.FromHtml("#EA4333");
				autoinject.OnUncheck.BorderColor = (autoinjectonuncheckbordercolor);
			}

			if (Properties.Settings.Default.themecolor == "Sienna")
			{
				var loginsettingscolorbackcolor = ColorTranslator.FromHtml("#B37557");
				loginsettingscolor.BackColor = (loginsettingscolorbackcolor);

				var loadersettingscolorbackcolor = ColorTranslator.FromHtml("#B37557");
				loadersettingscolor.BackColor = (loadersettingscolorbackcolor);

				var remembermeoncheckbordercolor = ColorTranslator.FromHtml("#B37557");
				rememberme.OnCheck.BorderColor = (remembermeoncheckbordercolor);

				var remembermeoncheckcheckboxcolor = ColorTranslator.FromHtml("#B37557");
				rememberme.OnCheck.CheckBoxColor = (remembermeoncheckcheckboxcolor);

				var remembermeonhovercheckedbordercolor = ColorTranslator.FromHtml("#B37557");
				rememberme.OnHoverChecked.BorderColor = (remembermeonhovercheckedbordercolor);

				var remembermeonhovercheckedcheckboxcolor = ColorTranslator.FromHtml("#B37557");
				rememberme.OnHoverChecked.CheckBoxColor = (remembermeonhovercheckedcheckboxcolor);

				var remembermeonhoveruncheckedbordercolor = ColorTranslator.FromHtml("#B37557");
				rememberme.OnHoverUnchecked.BorderColor = (remembermeonhoveruncheckedbordercolor);

				var remembermeonuncheckbordercolor = ColorTranslator.FromHtml("#B37557");
				rememberme.OnUncheck.BorderColor = (remembermeonuncheckbordercolor);

				var autologinoncheckbordercolor = ColorTranslator.FromHtml("#B37557");
				autologin.OnCheck.BorderColor = (autologinoncheckbordercolor);

				var autologinoncheckcheckboxcolor = ColorTranslator.FromHtml("#B37557");
				autologin.OnCheck.CheckBoxColor = (autologinoncheckcheckboxcolor);

				var autologinonhovercheckedbordercolor = ColorTranslator.FromHtml("#B37557");
				autologin.OnHoverChecked.BorderColor = (autologinonhovercheckedbordercolor);

				var autologinonhovercheckedcheckboxcolor = ColorTranslator.FromHtml("#B37557");
				autologin.OnHoverChecked.CheckBoxColor = (autologinonhovercheckedcheckboxcolor);

				var autologinonhoveruncheckedbordercolor = ColorTranslator.FromHtml("#B37557");
				autologin.OnHoverUnchecked.BorderColor = (autologinonhoveruncheckedbordercolor);

				var autologinonuncheckbordercolor = ColorTranslator.FromHtml("#B37557");
				autologin.OnUncheck.BorderColor = (autologinonuncheckbordercolor);

				var autoupdatecheckoncheckbordercolor = ColorTranslator.FromHtml("#B37557");
				autoupdatecheck.OnCheck.BorderColor = (autoupdatecheckoncheckbordercolor);

				var autoupdatecheckoncheckcheckboxcolor = ColorTranslator.FromHtml("#B37557");
				autoupdatecheck.OnCheck.CheckBoxColor = (autoupdatecheckoncheckcheckboxcolor);

				var autoupdatecheckonhovercheckedbordercolor = ColorTranslator.FromHtml("#B37557");
				autoupdatecheck.OnHoverChecked.BorderColor = (autoupdatecheckonhovercheckedbordercolor);

				var autoupdatecheckonhovercheckedcheckboxcolor = ColorTranslator.FromHtml("#B37557");
				autoupdatecheck.OnHoverChecked.CheckBoxColor = (autoupdatecheckonhovercheckedcheckboxcolor);

				var autoupdatecheckonhoveruncheckedbordercolor = ColorTranslator.FromHtml("#B37557");
				autoupdatecheck.OnHoverUnchecked.BorderColor = (autoupdatecheckonhoveruncheckedbordercolor);

				var autoupdatecheckonuncheckbordercolor = ColorTranslator.FromHtml("#B37557");
				autoupdatecheck.OnUncheck.BorderColor = (autoupdatecheckonuncheckbordercolor);

				var autoinjectoncheckbordercolor = ColorTranslator.FromHtml("#B37557");
				autoinject.OnCheck.BorderColor = (autoinjectoncheckbordercolor);

				var autoinjectoncheckcheckboxcolor = ColorTranslator.FromHtml("#B37557");
				autoinject.OnCheck.CheckBoxColor = (autoinjectoncheckcheckboxcolor);

				var autoinjectonhovercheckedbordercolor = ColorTranslator.FromHtml("#B37557");
				autoinject.OnHoverChecked.BorderColor = (autoinjectonhovercheckedbordercolor);

				var autoinjectonhovercheckedcheckboxcolor = ColorTranslator.FromHtml("#B37557");
				autoinject.OnHoverChecked.CheckBoxColor = (autoinjectonhovercheckedcheckboxcolor);

				var autoinjectonhoveruncheckedbordercolor = ColorTranslator.FromHtml("#B37557");
				autoinject.OnHoverUnchecked.BorderColor = (autoinjectonhoveruncheckedbordercolor);

				var autoinjectonuncheckbordercolor = ColorTranslator.FromHtml("#B37557");
				autoinject.OnUncheck.BorderColor = (autoinjectonuncheckbordercolor);
			}

			if (Properties.Settings.Default.themecolor == "Steel")
			{
				var loginsettingscolorbackcolor = ColorTranslator.FromHtml("#83919F");
				loginsettingscolor.BackColor = (loginsettingscolorbackcolor);

				var loadersettingscolorbackcolor = ColorTranslator.FromHtml("#83919F");
				loadersettingscolor.BackColor = (loadersettingscolorbackcolor);

				var remembermeoncheckbordercolor = ColorTranslator.FromHtml("#83919F");
				rememberme.OnCheck.BorderColor = (remembermeoncheckbordercolor);

				var remembermeoncheckcheckboxcolor = ColorTranslator.FromHtml("#83919F");
				rememberme.OnCheck.CheckBoxColor = (remembermeoncheckcheckboxcolor);

				var remembermeonhovercheckedbordercolor = ColorTranslator.FromHtml("#83919F");
				rememberme.OnHoverChecked.BorderColor = (remembermeonhovercheckedbordercolor);

				var remembermeonhovercheckedcheckboxcolor = ColorTranslator.FromHtml("#83919F");
				rememberme.OnHoverChecked.CheckBoxColor = (remembermeonhovercheckedcheckboxcolor);

				var remembermeonhoveruncheckedbordercolor = ColorTranslator.FromHtml("#83919F");
				rememberme.OnHoverUnchecked.BorderColor = (remembermeonhoveruncheckedbordercolor);

				var remembermeonuncheckbordercolor = ColorTranslator.FromHtml("#83919F");
				rememberme.OnUncheck.BorderColor = (remembermeonuncheckbordercolor);

				var autologinoncheckbordercolor = ColorTranslator.FromHtml("#83919F");
				autologin.OnCheck.BorderColor = (autologinoncheckbordercolor);

				var autologinoncheckcheckboxcolor = ColorTranslator.FromHtml("#83919F");
				autologin.OnCheck.CheckBoxColor = (autologinoncheckcheckboxcolor);

				var autologinonhovercheckedbordercolor = ColorTranslator.FromHtml("#83919F");
				autologin.OnHoverChecked.BorderColor = (autologinonhovercheckedbordercolor);

				var autologinonhovercheckedcheckboxcolor = ColorTranslator.FromHtml("#83919F");
				autologin.OnHoverChecked.CheckBoxColor = (autologinonhovercheckedcheckboxcolor);

				var autologinonhoveruncheckedbordercolor = ColorTranslator.FromHtml("#83919F");
				autologin.OnHoverUnchecked.BorderColor = (autologinonhoveruncheckedbordercolor);

				var autologinonuncheckbordercolor = ColorTranslator.FromHtml("#83919F");
				autologin.OnUncheck.BorderColor = (autologinonuncheckbordercolor);

				var autoupdatecheckoncheckbordercolor = ColorTranslator.FromHtml("#83919F");
				autoupdatecheck.OnCheck.BorderColor = (autoupdatecheckoncheckbordercolor);

				var autoupdatecheckoncheckcheckboxcolor = ColorTranslator.FromHtml("#83919F");
				autoupdatecheck.OnCheck.CheckBoxColor = (autoupdatecheckoncheckcheckboxcolor);

				var autoupdatecheckonhovercheckedbordercolor = ColorTranslator.FromHtml("#83919F");
				autoupdatecheck.OnHoverChecked.BorderColor = (autoupdatecheckonhovercheckedbordercolor);

				var autoupdatecheckonhovercheckedcheckboxcolor = ColorTranslator.FromHtml("#83919F");
				autoupdatecheck.OnHoverChecked.CheckBoxColor = (autoupdatecheckonhovercheckedcheckboxcolor);

				var autoupdatecheckonhoveruncheckedbordercolor = ColorTranslator.FromHtml("#83919F");
				autoupdatecheck.OnHoverUnchecked.BorderColor = (autoupdatecheckonhoveruncheckedbordercolor);

				var autoupdatecheckonuncheckbordercolor = ColorTranslator.FromHtml("#83919F");
				autoupdatecheck.OnUncheck.BorderColor = (autoupdatecheckonuncheckbordercolor);

				var autoinjectoncheckbordercolor = ColorTranslator.FromHtml("#83919F");
				autoinject.OnCheck.BorderColor = (autoinjectoncheckbordercolor);

				var autoinjectoncheckcheckboxcolor = ColorTranslator.FromHtml("#83919F");
				autoinject.OnCheck.CheckBoxColor = (autoinjectoncheckcheckboxcolor);

				var autoinjectonhovercheckedbordercolor = ColorTranslator.FromHtml("#83919F");
				autoinject.OnHoverChecked.BorderColor = (autoinjectonhovercheckedbordercolor);

				var autoinjectonhovercheckedcheckboxcolor = ColorTranslator.FromHtml("#83919F");
				autoinject.OnHoverChecked.CheckBoxColor = (autoinjectonhovercheckedcheckboxcolor);

				var autoinjectonhoveruncheckedbordercolor = ColorTranslator.FromHtml("#83919F");
				autoinject.OnHoverUnchecked.BorderColor = (autoinjectonhoveruncheckedbordercolor);

				var autoinjectonuncheckbordercolor = ColorTranslator.FromHtml("#83919F");
				autoinject.OnUncheck.BorderColor = (autoinjectonuncheckbordercolor);
			}

			if (Properties.Settings.Default.themecolor == "Taupe")
			{
				var loginsettingscolorbackcolor = ColorTranslator.FromHtml("#9F9471");
				loginsettingscolor.BackColor = (loginsettingscolorbackcolor);

				var loadersettingscolorbackcolor = ColorTranslator.FromHtml("#9F9471");
				loadersettingscolor.BackColor = (loadersettingscolorbackcolor);

				var remembermeoncheckbordercolor = ColorTranslator.FromHtml("#9F9471");
				rememberme.OnCheck.BorderColor = (remembermeoncheckbordercolor);

				var remembermeoncheckcheckboxcolor = ColorTranslator.FromHtml("#9F9471");
				rememberme.OnCheck.CheckBoxColor = (remembermeoncheckcheckboxcolor);

				var remembermeonhovercheckedbordercolor = ColorTranslator.FromHtml("#9F9471");
				rememberme.OnHoverChecked.BorderColor = (remembermeonhovercheckedbordercolor);

				var remembermeonhovercheckedcheckboxcolor = ColorTranslator.FromHtml("#9F9471");
				rememberme.OnHoverChecked.CheckBoxColor = (remembermeonhovercheckedcheckboxcolor);

				var remembermeonhoveruncheckedbordercolor = ColorTranslator.FromHtml("#9F9471");
				rememberme.OnHoverUnchecked.BorderColor = (remembermeonhoveruncheckedbordercolor);

				var remembermeonuncheckbordercolor = ColorTranslator.FromHtml("#9F9471");
				rememberme.OnUncheck.BorderColor = (remembermeonuncheckbordercolor);

				var autologinoncheckbordercolor = ColorTranslator.FromHtml("#9F9471");
				autologin.OnCheck.BorderColor = (autologinoncheckbordercolor);

				var autologinoncheckcheckboxcolor = ColorTranslator.FromHtml("#9F9471");
				autologin.OnCheck.CheckBoxColor = (autologinoncheckcheckboxcolor);

				var autologinonhovercheckedbordercolor = ColorTranslator.FromHtml("#9F9471");
				autologin.OnHoverChecked.BorderColor = (autologinonhovercheckedbordercolor);

				var autologinonhovercheckedcheckboxcolor = ColorTranslator.FromHtml("#9F9471");
				autologin.OnHoverChecked.CheckBoxColor = (autologinonhovercheckedcheckboxcolor);

				var autologinonhoveruncheckedbordercolor = ColorTranslator.FromHtml("#9F9471");
				autologin.OnHoverUnchecked.BorderColor = (autologinonhoveruncheckedbordercolor);

				var autologinonuncheckbordercolor = ColorTranslator.FromHtml("#9F9471");
				autologin.OnUncheck.BorderColor = (autologinonuncheckbordercolor);

				var autoupdatecheckoncheckbordercolor = ColorTranslator.FromHtml("#9F9471");
				autoupdatecheck.OnCheck.BorderColor = (autoupdatecheckoncheckbordercolor);

				var autoupdatecheckoncheckcheckboxcolor = ColorTranslator.FromHtml("#9F9471");
				autoupdatecheck.OnCheck.CheckBoxColor = (autoupdatecheckoncheckcheckboxcolor);

				var autoupdatecheckonhovercheckedbordercolor = ColorTranslator.FromHtml("#9F9471");
				autoupdatecheck.OnHoverChecked.BorderColor = (autoupdatecheckonhovercheckedbordercolor);

				var autoupdatecheckonhovercheckedcheckboxcolor = ColorTranslator.FromHtml("#9F9471");
				autoupdatecheck.OnHoverChecked.CheckBoxColor = (autoupdatecheckonhovercheckedcheckboxcolor);

				var autoupdatecheckonhoveruncheckedbordercolor = ColorTranslator.FromHtml("#9F9471");
				autoupdatecheck.OnHoverUnchecked.BorderColor = (autoupdatecheckonhoveruncheckedbordercolor);

				var autoupdatecheckonuncheckbordercolor = ColorTranslator.FromHtml("#9F9471");
				autoupdatecheck.OnUncheck.BorderColor = (autoupdatecheckonuncheckbordercolor);

				var autoinjectoncheckbordercolor = ColorTranslator.FromHtml("#9F9471");
				autoinject.OnCheck.BorderColor = (autoinjectoncheckbordercolor);

				var autoinjectoncheckcheckboxcolor = ColorTranslator.FromHtml("#9F9471");
				autoinject.OnCheck.CheckBoxColor = (autoinjectoncheckcheckboxcolor);

				var autoinjectonhovercheckedbordercolor = ColorTranslator.FromHtml("#9F9471");
				autoinject.OnHoverChecked.BorderColor = (autoinjectonhovercheckedbordercolor);

				var autoinjectonhovercheckedcheckboxcolor = ColorTranslator.FromHtml("#9F9471");
				autoinject.OnHoverChecked.CheckBoxColor = (autoinjectonhovercheckedcheckboxcolor);

				var autoinjectonhoveruncheckedbordercolor = ColorTranslator.FromHtml("#9F9471");
				autoinject.OnHoverUnchecked.BorderColor = (autoinjectonhoveruncheckedbordercolor);

				var autoinjectonuncheckbordercolor = ColorTranslator.FromHtml("#9F9471");
				autoinject.OnUncheck.BorderColor = (autoinjectonuncheckbordercolor);
			}

			if (Properties.Settings.Default.themecolor == "Teal")
			{
				var loginsettingscolorbackcolor = ColorTranslator.FromHtml("#33BCBA");
				loginsettingscolor.BackColor = (loginsettingscolorbackcolor);

				var loadersettingscolorbackcolor = ColorTranslator.FromHtml("#33BCBA");
				loadersettingscolor.BackColor = (loadersettingscolorbackcolor);

				var remembermeoncheckbordercolor = ColorTranslator.FromHtml("#33BCBA");
				rememberme.OnCheck.BorderColor = (remembermeoncheckbordercolor);

				var remembermeoncheckcheckboxcolor = ColorTranslator.FromHtml("#33BCBA");
				rememberme.OnCheck.CheckBoxColor = (remembermeoncheckcheckboxcolor);

				var remembermeonhovercheckedbordercolor = ColorTranslator.FromHtml("#33BCBA");
				rememberme.OnHoverChecked.BorderColor = (remembermeonhovercheckedbordercolor);

				var remembermeonhovercheckedcheckboxcolor = ColorTranslator.FromHtml("#33BCBA");
				rememberme.OnHoverChecked.CheckBoxColor = (remembermeonhovercheckedcheckboxcolor);

				var remembermeonhoveruncheckedbordercolor = ColorTranslator.FromHtml("#33BCBA");
				rememberme.OnHoverUnchecked.BorderColor = (remembermeonhoveruncheckedbordercolor);

				var remembermeonuncheckbordercolor = ColorTranslator.FromHtml("#33BCBA");
				rememberme.OnUncheck.BorderColor = (remembermeonuncheckbordercolor);

				var autologinoncheckbordercolor = ColorTranslator.FromHtml("#33BCBA");
				autologin.OnCheck.BorderColor = (autologinoncheckbordercolor);

				var autologinoncheckcheckboxcolor = ColorTranslator.FromHtml("#33BCBA");
				autologin.OnCheck.CheckBoxColor = (autologinoncheckcheckboxcolor);

				var autologinonhovercheckedbordercolor = ColorTranslator.FromHtml("#33BCBA");
				autologin.OnHoverChecked.BorderColor = (autologinonhovercheckedbordercolor);

				var autologinonhovercheckedcheckboxcolor = ColorTranslator.FromHtml("#33BCBA");
				autologin.OnHoverChecked.CheckBoxColor = (autologinonhovercheckedcheckboxcolor);

				var autologinonhoveruncheckedbordercolor = ColorTranslator.FromHtml("#33BCBA");
				autologin.OnHoverUnchecked.BorderColor = (autologinonhoveruncheckedbordercolor);

				var autologinonuncheckbordercolor = ColorTranslator.FromHtml("#33BCBA");
				autologin.OnUncheck.BorderColor = (autologinonuncheckbordercolor);

				var autoupdatecheckoncheckbordercolor = ColorTranslator.FromHtml("#33BCBA");
				autoupdatecheck.OnCheck.BorderColor = (autoupdatecheckoncheckbordercolor);

				var autoupdatecheckoncheckcheckboxcolor = ColorTranslator.FromHtml("#33BCBA");
				autoupdatecheck.OnCheck.CheckBoxColor = (autoupdatecheckoncheckcheckboxcolor);

				var autoupdatecheckonhovercheckedbordercolor = ColorTranslator.FromHtml("#33BCBA");
				autoupdatecheck.OnHoverChecked.BorderColor = (autoupdatecheckonhovercheckedbordercolor);

				var autoupdatecheckonhovercheckedcheckboxcolor = ColorTranslator.FromHtml("#33BCBA");
				autoupdatecheck.OnHoverChecked.CheckBoxColor = (autoupdatecheckonhovercheckedcheckboxcolor);

				var autoupdatecheckonhoveruncheckedbordercolor = ColorTranslator.FromHtml("#33BCBA");
				autoupdatecheck.OnHoverUnchecked.BorderColor = (autoupdatecheckonhoveruncheckedbordercolor);

				var autoupdatecheckonuncheckbordercolor = ColorTranslator.FromHtml("#33BCBA");
				autoupdatecheck.OnUncheck.BorderColor = (autoupdatecheckonuncheckbordercolor);

				var autoinjectoncheckbordercolor = ColorTranslator.FromHtml("#33BCBA");
				autoinject.OnCheck.BorderColor = (autoinjectoncheckbordercolor);

				var autoinjectoncheckcheckboxcolor = ColorTranslator.FromHtml("#33BCBA");
				autoinject.OnCheck.CheckBoxColor = (autoinjectoncheckcheckboxcolor);

				var autoinjectonhovercheckedbordercolor = ColorTranslator.FromHtml("#33BCBA");
				autoinject.OnHoverChecked.BorderColor = (autoinjectonhovercheckedbordercolor);

				var autoinjectonhovercheckedcheckboxcolor = ColorTranslator.FromHtml("#33BCBA");
				autoinject.OnHoverChecked.CheckBoxColor = (autoinjectonhovercheckedcheckboxcolor);

				var autoinjectonhoveruncheckedbordercolor = ColorTranslator.FromHtml("#33BCBA");
				autoinject.OnHoverUnchecked.BorderColor = (autoinjectonhoveruncheckedbordercolor);

				var autoinjectonuncheckbordercolor = ColorTranslator.FromHtml("#33BCBA");
				autoinject.OnUncheck.BorderColor = (autoinjectonuncheckbordercolor);
			}
		}

        public void SaveSettings()
        {
            Properties.Settings.Default.Save();
        }


        private void settings_Load(object sender, EventArgs e)
        {
            SaveSettings();
            themecolor_Data();
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
