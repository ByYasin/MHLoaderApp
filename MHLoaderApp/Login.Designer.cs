namespace MHLoaderApp
{
    partial class Login
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.ToggleSwitch.ToggleState toggleState1 = new Bunifu.ToggleSwitch.ToggleState();
            Bunifu.ToggleSwitch.ToggleState toggleState2 = new Bunifu.ToggleSwitch.ToggleState();
            Bunifu.ToggleSwitch.ToggleState toggleState3 = new Bunifu.ToggleSwitch.ToggleState();
            Bunifu.ToggleSwitch.ToggleState toggleState4 = new Bunifu.ToggleSwitch.ToggleState();
            Bunifu.ToggleSwitch.ToggleState toggleState5 = new Bunifu.ToggleSwitch.ToggleState();
            Bunifu.ToggleSwitch.ToggleState toggleState6 = new Bunifu.ToggleSwitch.ToggleState();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuAnimatorNS.Animation animation1 = new Bunifu.UI.WinForms.BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.header = new System.Windows.Forms.Panel();
            this.title = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.favicon = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.minimizebox = new Guna.UI2.WinForms.Guna2ControlBox();
            this.closebox = new Guna.UI2.WinForms.Guna2ControlBox();
            this.footer = new System.Windows.Forms.Panel();
            this.status = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.statustitle = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.loginbackpanel = new System.Windows.Forms.Panel();
            this.loginbutton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.autologinlabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.remembermelabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.autologin = new Bunifu.ToggleSwitch.BunifuToggleSwitch();
            this.rememberme = new Bunifu.ToggleSwitch.BunifuToggleSwitch();
            this.bunifuPictureBox1 = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.passwordtext = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.usernametext = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.logo = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.logintimer = new System.Windows.Forms.Timer(this.components);
            this.bunifuTransition1 = new Bunifu.UI.WinForms.BunifuTransition(this.components);
            this.header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.favicon)).BeginInit();
            this.footer.SuspendLayout();
            this.loginbackpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 0;
            this.bunifuElipse1.TargetControl = this;
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(147)))), ((int)(((byte)(223)))));
            this.header.Controls.Add(this.title);
            this.header.Controls.Add(this.favicon);
            this.header.Controls.Add(this.minimizebox);
            this.header.Controls.Add(this.closebox);
            this.bunifuTransition1.SetDecoration(this.header, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(550, 32);
            this.header.TabIndex = 1;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.title, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.title.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.title.ForeColor = System.Drawing.Color.White;
            this.title.Location = new System.Drawing.Point(34, 6);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(184, 20);
            this.title.TabIndex = 3;
            this.title.Text = "LOADER LICENCE - LOGIN";
            // 
            // favicon
            // 
            this.favicon.AllowFocused = false;
            this.favicon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(113)))), ((int)(((byte)(188)))));
            this.favicon.BorderRadius = 0;
            this.bunifuTransition1.SetDecoration(this.favicon, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.favicon.Dock = System.Windows.Forms.DockStyle.Left;
            this.favicon.Image = global::MHLoaderApp.Properties.Resources.icons8_login_as_user_32;
            this.favicon.IsCircle = false;
            this.favicon.Location = new System.Drawing.Point(0, 0);
            this.favicon.Name = "favicon";
            this.favicon.Size = new System.Drawing.Size(32, 32);
            this.favicon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.favicon.TabIndex = 3;
            this.favicon.TabStop = false;
            this.favicon.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Custom;
            // 
            // minimizebox
            // 
            this.minimizebox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimizebox.BackColor = System.Drawing.Color.Transparent;
            this.minimizebox.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.bunifuTransition1.SetDecoration(this.minimizebox, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.minimizebox.FillColor = System.Drawing.Color.Transparent;
            this.minimizebox.HoverState.Parent = this.minimizebox;
            this.minimizebox.IconColor = System.Drawing.Color.White;
            this.minimizebox.Location = new System.Drawing.Point(460, 0);
            this.minimizebox.Name = "minimizebox";
            this.minimizebox.ShadowDecoration.Parent = this.minimizebox;
            this.minimizebox.Size = new System.Drawing.Size(45, 33);
            this.minimizebox.TabIndex = 5;
            // 
            // closebox
            // 
            this.closebox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closebox.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.closebox, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.closebox.FillColor = System.Drawing.Color.Transparent;
            this.closebox.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(17)))), ((int)(((byte)(35)))));
            this.closebox.HoverState.Parent = this.closebox;
            this.closebox.IconColor = System.Drawing.Color.White;
            this.closebox.Location = new System.Drawing.Point(505, 0);
            this.closebox.Name = "closebox";
            this.closebox.ShadowDecoration.Parent = this.closebox;
            this.closebox.Size = new System.Drawing.Size(45, 33);
            this.closebox.TabIndex = 4;
            // 
            // footer
            // 
            this.footer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(147)))), ((int)(((byte)(223)))));
            this.footer.Controls.Add(this.status);
            this.footer.Controls.Add(this.statustitle);
            this.bunifuTransition1.SetDecoration(this.footer, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.footer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.footer.Location = new System.Drawing.Point(0, 327);
            this.footer.Name = "footer";
            this.footer.Size = new System.Drawing.Size(550, 23);
            this.footer.TabIndex = 2;
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.status, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.status.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.status.ForeColor = System.Drawing.Color.White;
            this.status.Location = new System.Drawing.Point(53, 3);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(393, 17);
            this.status.TabIndex = 7;
            this.status.Text = "Welcome! This section will display your license and hwid status!";
            // 
            // statustitle
            // 
            this.statustitle.AutoSize = true;
            this.statustitle.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.statustitle, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.statustitle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.statustitle.ForeColor = System.Drawing.Color.White;
            this.statustitle.Location = new System.Drawing.Point(4, 2);
            this.statustitle.Name = "statustitle";
            this.statustitle.Size = new System.Drawing.Size(53, 17);
            this.statustitle.TabIndex = 6;
            this.statustitle.Text = "Status :";
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.header;
            this.bunifuDragControl1.Vertical = true;
            // 
            // loginbackpanel
            // 
            this.loginbackpanel.AutoSize = true;
            this.loginbackpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.loginbackpanel.Controls.Add(this.loginbutton);
            this.loginbackpanel.Controls.Add(this.autologinlabel);
            this.loginbackpanel.Controls.Add(this.remembermelabel);
            this.loginbackpanel.Controls.Add(this.autologin);
            this.loginbackpanel.Controls.Add(this.rememberme);
            this.loginbackpanel.Controls.Add(this.bunifuPictureBox1);
            this.loginbackpanel.Controls.Add(this.passwordtext);
            this.loginbackpanel.Controls.Add(this.usernametext);
            this.bunifuTransition1.SetDecoration(this.loginbackpanel, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.loginbackpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loginbackpanel.Location = new System.Drawing.Point(272, 32);
            this.loginbackpanel.Name = "loginbackpanel";
            this.loginbackpanel.Size = new System.Drawing.Size(278, 295);
            this.loginbackpanel.TabIndex = 6;
            // 
            // loginbutton
            // 
            this.loginbutton.AllowToggling = true;
            this.loginbutton.AnimationSpeed = 200;
            this.loginbutton.AutoGenerateColors = false;
            this.loginbutton.AutoSize = true;
            this.loginbutton.BackColor = System.Drawing.Color.Transparent;
            this.loginbutton.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(147)))), ((int)(((byte)(223)))));
            this.loginbutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("loginbutton.BackgroundImage")));
            this.loginbutton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.loginbutton.ButtonText = "Login";
            this.loginbutton.ButtonTextMarginLeft = 1;
            this.loginbutton.ColorContrastOnClick = 45;
            this.loginbutton.ColorContrastOnHover = 45;
            this.loginbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.loginbutton.CustomizableEdges = borderEdges1;
            this.bunifuTransition1.SetDecoration(this.loginbutton, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.loginbutton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.loginbutton.DisabledBorderColor = System.Drawing.Color.White;
            this.loginbutton.DisabledFillColor = System.Drawing.Color.Transparent;
            this.loginbutton.DisabledForecolor = System.Drawing.Color.Transparent;
            this.loginbutton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.loginbutton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.loginbutton.ForeColor = System.Drawing.Color.White;
            this.loginbutton.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.loginbutton.IconMarginLeft = 16;
            this.loginbutton.IconPadding = 7;
            this.loginbutton.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.loginbutton.IdleBorderColor = System.Drawing.Color.White;
            this.loginbutton.IdleBorderRadius = 3;
            this.loginbutton.IdleBorderThickness = 1;
            this.loginbutton.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(147)))), ((int)(((byte)(223)))));
            this.loginbutton.IdleIconLeftImage = global::MHLoaderApp.Properties.Resources.enter_32;
            this.loginbutton.IdleIconRightImage = null;
            this.loginbutton.IndicateFocus = true;
            this.loginbutton.Location = new System.Drawing.Point(85, 247);
            this.loginbutton.Name = "loginbutton";
            this.loginbutton.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.loginbutton.onHoverState.BorderRadius = 3;
            this.loginbutton.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.loginbutton.onHoverState.BorderThickness = 1;
            this.loginbutton.onHoverState.FillColor = System.Drawing.Color.Transparent;
            this.loginbutton.onHoverState.ForeColor = System.Drawing.Color.White;
            this.loginbutton.onHoverState.IconLeftImage = null;
            this.loginbutton.onHoverState.IconRightImage = null;
            this.loginbutton.OnIdleState.BorderColor = System.Drawing.Color.White;
            this.loginbutton.OnIdleState.BorderRadius = 3;
            this.loginbutton.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.loginbutton.OnIdleState.BorderThickness = 1;
            this.loginbutton.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(147)))), ((int)(((byte)(223)))));
            this.loginbutton.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.loginbutton.OnIdleState.IconLeftImage = global::MHLoaderApp.Properties.Resources.enter_32;
            this.loginbutton.OnIdleState.IconRightImage = null;
            this.loginbutton.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.loginbutton.OnPressedState.BorderRadius = 3;
            this.loginbutton.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.loginbutton.OnPressedState.BorderThickness = 1;
            this.loginbutton.OnPressedState.FillColor = System.Drawing.Color.Transparent;
            this.loginbutton.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.loginbutton.OnPressedState.IconLeftImage = null;
            this.loginbutton.OnPressedState.IconRightImage = null;
            this.loginbutton.Size = new System.Drawing.Size(108, 31);
            this.loginbutton.TabIndex = 13;
            this.loginbutton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.loginbutton.TextMarginLeft = 1;
            this.loginbutton.UseDefaultRadiusAndThickness = true;
            this.loginbutton.Click += new System.EventHandler(this.loginbutton_Click);
            // 
            // autologinlabel
            // 
            this.autologinlabel.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.autologinlabel, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.autologinlabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.autologinlabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.autologinlabel.Location = new System.Drawing.Point(8, 212);
            this.autologinlabel.Name = "autologinlabel";
            this.autologinlabel.Size = new System.Drawing.Size(79, 20);
            this.autologinlabel.TabIndex = 11;
            this.autologinlabel.Text = "Auto login";
            // 
            // remembermelabel
            // 
            this.remembermelabel.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.remembermelabel, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.remembermelabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.remembermelabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.remembermelabel.Location = new System.Drawing.Point(8, 180);
            this.remembermelabel.Name = "remembermelabel";
            this.remembermelabel.Size = new System.Drawing.Size(107, 20);
            this.remembermelabel.TabIndex = 10;
            this.remembermelabel.Text = "Remember me";
            // 
            // autologin
            // 
            this.autologin.Animation = 5;
            this.autologin.BackColor = System.Drawing.Color.Transparent;
            this.autologin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("autologin.BackgroundImage")));
            this.autologin.Checked = false;
            this.autologin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.autologin, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.autologin.InnerCirclePadding = 3;
            this.autologin.Location = new System.Drawing.Point(231, 212);
            this.autologin.Name = "autologin";
            this.autologin.Size = new System.Drawing.Size(40, 20);
            this.autologin.TabIndex = 9;
            toggleState1.BackColor = System.Drawing.Color.Empty;
            toggleState1.BackColorInner = System.Drawing.Color.Empty;
            toggleState1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(0)))), ((int)(((byte)(140)))));
            toggleState1.BorderColorInner = System.Drawing.Color.Empty;
            toggleState1.BorderRadius = 1;
            toggleState1.BorderRadiusInner = 1;
            toggleState1.BorderThickness = 1;
            toggleState1.BorderThicknessInner = 1;
            this.autologin.ToggleStateDisabled = toggleState1;
            toggleState2.BackColor = System.Drawing.Color.Transparent;
            toggleState2.BackColorInner = System.Drawing.Color.White;
            toggleState2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            toggleState2.BorderColorInner = System.Drawing.Color.White;
            toggleState2.BorderRadius = 17;
            toggleState2.BorderRadiusInner = 11;
            toggleState2.BorderThickness = 2;
            toggleState2.BorderThicknessInner = 1;
            this.autologin.ToggleStateOff = toggleState2;
            toggleState3.BackColor = System.Drawing.Color.DodgerBlue;
            toggleState3.BackColorInner = System.Drawing.Color.White;
            toggleState3.BorderColor = System.Drawing.Color.DodgerBlue;
            toggleState3.BorderColorInner = System.Drawing.Color.White;
            toggleState3.BorderRadius = 17;
            toggleState3.BorderRadiusInner = 11;
            toggleState3.BorderThickness = 1;
            toggleState3.BorderThicknessInner = 1;
            this.autologin.ToggleStateOn = toggleState3;
            this.autologin.Value = false;
            // 
            // rememberme
            // 
            this.rememberme.Animation = 5;
            this.rememberme.BackColor = System.Drawing.Color.Transparent;
            this.rememberme.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rememberme.BackgroundImage")));
            this.rememberme.Checked = false;
            this.rememberme.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.rememberme, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.rememberme.InnerCirclePadding = 3;
            this.rememberme.Location = new System.Drawing.Point(230, 180);
            this.rememberme.Name = "rememberme";
            this.rememberme.Size = new System.Drawing.Size(40, 20);
            this.rememberme.TabIndex = 8;
            toggleState4.BackColor = System.Drawing.Color.Empty;
            toggleState4.BackColorInner = System.Drawing.Color.Empty;
            toggleState4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(0)))), ((int)(((byte)(140)))));
            toggleState4.BorderColorInner = System.Drawing.Color.Empty;
            toggleState4.BorderRadius = 1;
            toggleState4.BorderRadiusInner = 1;
            toggleState4.BorderThickness = 1;
            toggleState4.BorderThicknessInner = 1;
            this.rememberme.ToggleStateDisabled = toggleState4;
            toggleState5.BackColor = System.Drawing.Color.Transparent;
            toggleState5.BackColorInner = System.Drawing.Color.White;
            toggleState5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            toggleState5.BorderColorInner = System.Drawing.Color.White;
            toggleState5.BorderRadius = 17;
            toggleState5.BorderRadiusInner = 11;
            toggleState5.BorderThickness = 2;
            toggleState5.BorderThicknessInner = 1;
            this.rememberme.ToggleStateOff = toggleState5;
            toggleState6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(147)))), ((int)(((byte)(223)))));
            toggleState6.BackColorInner = System.Drawing.Color.White;
            toggleState6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(147)))), ((int)(((byte)(223)))));
            toggleState6.BorderColorInner = System.Drawing.Color.White;
            toggleState6.BorderRadius = 17;
            toggleState6.BorderRadiusInner = 11;
            toggleState6.BorderThickness = 1;
            toggleState6.BorderThicknessInner = 1;
            this.rememberme.ToggleStateOn = toggleState6;
            this.rememberme.Value = false;
            // 
            // bunifuPictureBox1
            // 
            this.bunifuPictureBox1.AllowFocused = false;
            this.bunifuPictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuPictureBox1.BorderRadius = 0;
            this.bunifuTransition1.SetDecoration(this.bunifuPictureBox1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuPictureBox1.Image = global::MHLoaderApp.Properties.Resources.login_logo_64x_64;
            this.bunifuPictureBox1.IsCircle = false;
            this.bunifuPictureBox1.Location = new System.Drawing.Point(107, 5);
            this.bunifuPictureBox1.Name = "bunifuPictureBox1";
            this.bunifuPictureBox1.Size = new System.Drawing.Size(64, 64);
            this.bunifuPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.bunifuPictureBox1.TabIndex = 7;
            this.bunifuPictureBox1.TabStop = false;
            this.bunifuPictureBox1.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Custom;
            // 
            // passwordtext
            // 
            this.passwordtext.AcceptsReturn = false;
            this.passwordtext.AcceptsTab = false;
            this.passwordtext.AnimationSpeed = 200;
            this.passwordtext.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.passwordtext.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.passwordtext.AutoSize = true;
            this.passwordtext.BackColor = System.Drawing.Color.Transparent;
            this.passwordtext.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("passwordtext.BackgroundImage")));
            this.passwordtext.BorderColorActive = System.Drawing.Color.White;
            this.passwordtext.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.passwordtext.BorderColorHover = System.Drawing.Color.White;
            this.passwordtext.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.passwordtext.BorderRadius = 1;
            this.passwordtext.BorderThickness = 1;
            this.passwordtext.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.passwordtext.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuTransition1.SetDecoration(this.passwordtext, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.passwordtext.DefaultFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.passwordtext.DefaultText = "";
            this.passwordtext.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.passwordtext.ForeColor = System.Drawing.Color.White;
            this.passwordtext.HideSelection = true;
            this.passwordtext.IconLeft = global::MHLoaderApp.Properties.Resources.password_16;
            this.passwordtext.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.passwordtext.IconPadding = 6;
            this.passwordtext.IconRight = null;
            this.passwordtext.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.passwordtext.Lines = new string[0];
            this.passwordtext.Location = new System.Drawing.Point(10, 129);
            this.passwordtext.MaxLength = 32767;
            this.passwordtext.MinimumSize = new System.Drawing.Size(1, 1);
            this.passwordtext.Modified = false;
            this.passwordtext.Multiline = false;
            this.passwordtext.Name = "passwordtext";
            stateProperties1.BorderColor = System.Drawing.Color.White;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.passwordtext.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.Empty;
            stateProperties2.FillColor = System.Drawing.Color.White;
            stateProperties2.ForeColor = System.Drawing.Color.Empty;
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.passwordtext.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.White;
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.passwordtext.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            stateProperties4.ForeColor = System.Drawing.Color.White;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.passwordtext.OnIdleState = stateProperties4;
            this.passwordtext.PasswordChar = '●';
            this.passwordtext.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.passwordtext.PlaceholderText = "Password";
            this.passwordtext.ReadOnly = false;
            this.passwordtext.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.passwordtext.SelectedText = "";
            this.passwordtext.SelectionLength = 0;
            this.passwordtext.SelectionStart = 0;
            this.passwordtext.ShortcutsEnabled = true;
            this.passwordtext.Size = new System.Drawing.Size(259, 29);
            this.passwordtext.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.passwordtext.TabIndex = 6;
            this.passwordtext.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.passwordtext.TextMarginBottom = 0;
            this.passwordtext.TextMarginLeft = 5;
            this.passwordtext.TextMarginTop = 0;
            this.passwordtext.TextPlaceholder = "Password";
            this.passwordtext.UseSystemPasswordChar = true;
            this.passwordtext.WordWrap = true;
            // 
            // usernametext
            // 
            this.usernametext.AcceptsReturn = false;
            this.usernametext.AcceptsTab = false;
            this.usernametext.AnimationSpeed = 200;
            this.usernametext.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.usernametext.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.usernametext.AutoSize = true;
            this.usernametext.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.usernametext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.usernametext.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("usernametext.BackgroundImage")));
            this.usernametext.BorderColorActive = System.Drawing.Color.White;
            this.usernametext.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.usernametext.BorderColorHover = System.Drawing.Color.White;
            this.usernametext.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.usernametext.BorderRadius = 1;
            this.usernametext.BorderThickness = 1;
            this.usernametext.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.usernametext.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuTransition1.SetDecoration(this.usernametext, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.usernametext.DefaultFont = new System.Drawing.Font("Segoe UI", 9.75F);
            this.usernametext.DefaultText = "";
            this.usernametext.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.usernametext.ForeColor = System.Drawing.Color.White;
            this.usernametext.HideSelection = true;
            this.usernametext.IconLeft = global::MHLoaderApp.Properties.Resources.user_male_16;
            this.usernametext.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.usernametext.IconPadding = 6;
            this.usernametext.IconRight = null;
            this.usernametext.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.usernametext.Lines = new string[0];
            this.usernametext.Location = new System.Drawing.Point(10, 81);
            this.usernametext.MaxLength = 32767;
            this.usernametext.MinimumSize = new System.Drawing.Size(1, 1);
            this.usernametext.Modified = false;
            this.usernametext.Multiline = false;
            this.usernametext.Name = "usernametext";
            stateProperties5.BorderColor = System.Drawing.Color.White;
            stateProperties5.FillColor = System.Drawing.Color.Empty;
            stateProperties5.ForeColor = System.Drawing.Color.Empty;
            stateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.usernametext.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            stateProperties6.FillColor = System.Drawing.Color.White;
            stateProperties6.ForeColor = System.Drawing.Color.Empty;
            stateProperties6.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.usernametext.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = System.Drawing.Color.White;
            stateProperties7.FillColor = System.Drawing.Color.Empty;
            stateProperties7.ForeColor = System.Drawing.Color.Empty;
            stateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.usernametext.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties8.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            stateProperties8.ForeColor = System.Drawing.Color.White;
            stateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.usernametext.OnIdleState = stateProperties8;
            this.usernametext.PasswordChar = '\0';
            this.usernametext.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.usernametext.PlaceholderText = "Username";
            this.usernametext.ReadOnly = false;
            this.usernametext.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.usernametext.SelectedText = "";
            this.usernametext.SelectionLength = 0;
            this.usernametext.SelectionStart = 0;
            this.usernametext.ShortcutsEnabled = true;
            this.usernametext.Size = new System.Drawing.Size(259, 29);
            this.usernametext.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.usernametext.TabIndex = 5;
            this.usernametext.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.usernametext.TextMarginBottom = 0;
            this.usernametext.TextMarginLeft = 5;
            this.usernametext.TextMarginTop = 0;
            this.usernametext.TextPlaceholder = "Username";
            this.usernametext.UseSystemPasswordChar = false;
            this.usernametext.WordWrap = true;
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.bunifuSeparator1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(270, 32);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(10, 295);
            this.bunifuSeparator1.TabIndex = 12;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = true;
            // 
            // logo
            // 
            this.logo.AllowFocused = false;
            this.logo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.logo.BackgroundImage = global::MHLoaderApp.Properties.Resources.mhback;
            this.logo.BorderRadius = 0;
            this.bunifuTransition1.SetDecoration(this.logo, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.logo.Dock = System.Windows.Forms.DockStyle.Left;
            this.logo.Image = global::MHLoaderApp.Properties.Resources.mh2muye;
            this.logo.IsCircle = false;
            this.logo.Location = new System.Drawing.Point(0, 32);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(272, 295);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo.TabIndex = 4;
            this.logo.TabStop = false;
            this.logo.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Custom;
            // 
            // logintimer
            // 
            this.logintimer.Interval = 2000;
            this.logintimer.Tick += new System.EventHandler(this.logintimer_Tick);
            // 
            // bunifuTransition1
            // 
            this.bunifuTransition1.AnimationType = Bunifu.UI.WinForms.BunifuAnimatorNS.AnimationType.VertSlide;
            this.bunifuTransition1.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.bunifuTransition1.DefaultAnimation = animation1;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.ClientSize = new System.Drawing.Size(550, 350);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.loginbackpanel);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.footer);
            this.Controls.Add(this.header);
            this.bunifuTransition1.SetDecoration(this, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Login";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MH-Subscriber Login";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Login_FormClosing);
            this.Load += new System.EventHandler(this.Login_Load);
            this.header.ResumeLayout(false);
            this.header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.favicon)).EndInit();
            this.footer.ResumeLayout(false);
            this.footer.PerformLayout();
            this.loginbackpanel.ResumeLayout(false);
            this.loginbackpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Guna.UI2.WinForms.Guna2ControlBox minimizebox;
        private Guna.UI2.WinForms.Guna2ControlBox closebox;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuCustomLabel title;
        private Bunifu.UI.WinForms.BunifuPictureBox logo;
        private Bunifu.Framework.UI.BunifuCustomLabel statustitle;
        private Bunifu.UI.WinForms.BunifuPictureBox bunifuPictureBox1;
        private Bunifu.Framework.UI.BunifuCustomLabel autologinlabel;
        private Bunifu.Framework.UI.BunifuCustomLabel remembermelabel;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private Bunifu.Framework.UI.BunifuCustomLabel status;
        private System.Windows.Forms.Timer logintimer;
        private Bunifu.UI.WinForms.BunifuTransition bunifuTransition1;
        public System.Windows.Forms.Panel loginbackpanel;
        public Bunifu.ToggleSwitch.BunifuToggleSwitch rememberme;
        public Bunifu.ToggleSwitch.BunifuToggleSwitch autologin;
        public System.Windows.Forms.Panel footer;
        public Bunifu.UI.WinForms.BunifuButton.BunifuButton loginbutton;
        public Bunifu.UI.WinForms.BunifuPictureBox favicon;
        public System.Windows.Forms.Panel header;
        public Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox usernametext;
        public Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox passwordtext;
    }
}

