namespace Cowin_Portal
{
    partial class User_Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(User_Dashboard));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.panel_display = new Bunifu.UI.WinForms.BunifuPanel();
            this.bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            this.dashboard_label = new System.Windows.Forms.Label();
            this.optionsPanel = new Bunifu.UI.WinForms.BunifuPanel();
            this.aboutButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.user_centersButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.user_dashboardButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.profilePanel = new Bunifu.UI.WinForms.BunifuPanel();
            this.username_label = new System.Windows.Forms.Label();
            this.bunifuPictureBox2 = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.bunifuPanel1.SuspendLayout();
            this.optionsPanel.SuspendLayout();
            this.profilePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_display
            // 
            this.panel_display.AutoScroll = true;
            this.panel_display.BackgroundColor = System.Drawing.Color.Transparent;
            this.panel_display.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel_display.BackgroundImage")));
            this.panel_display.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_display.BorderColor = System.Drawing.Color.Transparent;
            this.panel_display.BorderRadius = 0;
            this.panel_display.BorderThickness = 0;
            this.panel_display.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_display.Location = new System.Drawing.Point(200, 47);
            this.panel_display.Name = "panel_display";
            this.panel_display.ShowBorders = true;
            this.panel_display.Size = new System.Drawing.Size(584, 514);
            this.panel_display.TabIndex = 2;
            // 
            // bunifuPanel1
            // 
            this.bunifuPanel1.BackgroundColor = System.Drawing.Color.LightSeaGreen;
            this.bunifuPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel1.BackgroundImage")));
            this.bunifuPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel1.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanel1.BorderRadius = 0;
            this.bunifuPanel1.BorderThickness = 0;
            this.bunifuPanel1.Controls.Add(this.dashboard_label);
            this.bunifuPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuPanel1.ForeColor = System.Drawing.Color.BurlyWood;
            this.bunifuPanel1.Location = new System.Drawing.Point(200, 0);
            this.bunifuPanel1.Name = "bunifuPanel1";
            this.bunifuPanel1.ShowBorders = true;
            this.bunifuPanel1.Size = new System.Drawing.Size(584, 47);
            this.bunifuPanel1.TabIndex = 1;
            // 
            // dashboard_label
            // 
            this.dashboard_label.BackColor = System.Drawing.Color.Transparent;
            this.dashboard_label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dashboard_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.dashboard_label.ForeColor = System.Drawing.Color.FloralWhite;
            this.dashboard_label.Location = new System.Drawing.Point(0, 0);
            this.dashboard_label.Name = "dashboard_label";
            this.dashboard_label.Size = new System.Drawing.Size(584, 47);
            this.dashboard_label.TabIndex = 1;
            this.dashboard_label.Text = "Your Dashboard";
            this.dashboard_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // optionsPanel
            // 
            this.optionsPanel.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(32)))), ((int)(((byte)(94)))));
            this.optionsPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("optionsPanel.BackgroundImage")));
            this.optionsPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.optionsPanel.BorderColor = System.Drawing.Color.Transparent;
            this.optionsPanel.BorderRadius = 0;
            this.optionsPanel.BorderThickness = 0;
            this.optionsPanel.Controls.Add(this.aboutButton);
            this.optionsPanel.Controls.Add(this.user_centersButton);
            this.optionsPanel.Controls.Add(this.user_dashboardButton);
            this.optionsPanel.Controls.Add(this.profilePanel);
            this.optionsPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.optionsPanel.Location = new System.Drawing.Point(0, 0);
            this.optionsPanel.Name = "optionsPanel";
            this.optionsPanel.ShowBorders = true;
            this.optionsPanel.Size = new System.Drawing.Size(200, 561);
            this.optionsPanel.TabIndex = 0;
            // 
            // aboutButton
            // 
            this.aboutButton.AllowAnimations = true;
            this.aboutButton.AllowMouseEffects = true;
            this.aboutButton.AllowToggling = false;
            this.aboutButton.AnimationSpeed = 200;
            this.aboutButton.AutoGenerateColors = false;
            this.aboutButton.AutoRoundBorders = false;
            this.aboutButton.AutoSizeLeftIcon = true;
            this.aboutButton.AutoSizeRightIcon = true;
            this.aboutButton.BackColor = System.Drawing.Color.Transparent;
            this.aboutButton.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(32)))), ((int)(((byte)(94)))));
            this.aboutButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("aboutButton.BackgroundImage")));
            this.aboutButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.aboutButton.ButtonText = "About";
            this.aboutButton.ButtonTextMarginLeft = 0;
            this.aboutButton.ColorContrastOnClick = 45;
            this.aboutButton.ColorContrastOnHover = 45;
            this.aboutButton.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.aboutButton.CustomizableEdges = borderEdges1;
            this.aboutButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.aboutButton.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.aboutButton.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.aboutButton.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.aboutButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.aboutButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.aboutButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.aboutButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.aboutButton.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.aboutButton.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.aboutButton.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.aboutButton.IconMarginLeft = 11;
            this.aboutButton.IconPadding = 10;
            this.aboutButton.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.aboutButton.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.aboutButton.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.aboutButton.IconSize = 25;
            this.aboutButton.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(32)))), ((int)(((byte)(94)))));
            this.aboutButton.IdleBorderRadius = 1;
            this.aboutButton.IdleBorderThickness = 1;
            this.aboutButton.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(32)))), ((int)(((byte)(94)))));
            this.aboutButton.IdleIconLeftImage = global::Cowin_Portal.Properties.Resources.icons8_info_96;
            this.aboutButton.IdleIconRightImage = null;
            this.aboutButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.aboutButton.IndicateFocus = false;
            this.aboutButton.Location = new System.Drawing.Point(0, 195);
            this.aboutButton.Name = "aboutButton";
            this.aboutButton.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.aboutButton.OnDisabledState.BorderRadius = 1;
            this.aboutButton.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.aboutButton.OnDisabledState.BorderThickness = 1;
            this.aboutButton.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.aboutButton.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.aboutButton.OnDisabledState.IconLeftImage = null;
            this.aboutButton.OnDisabledState.IconRightImage = null;
            this.aboutButton.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(32)))), ((int)(((byte)(150)))));
            this.aboutButton.onHoverState.BorderRadius = 1;
            this.aboutButton.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.aboutButton.onHoverState.BorderThickness = 1;
            this.aboutButton.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(32)))), ((int)(((byte)(150)))));
            this.aboutButton.onHoverState.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.aboutButton.onHoverState.IconLeftImage = null;
            this.aboutButton.onHoverState.IconRightImage = null;
            this.aboutButton.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(32)))), ((int)(((byte)(94)))));
            this.aboutButton.OnIdleState.BorderRadius = 1;
            this.aboutButton.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.aboutButton.OnIdleState.BorderThickness = 1;
            this.aboutButton.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(32)))), ((int)(((byte)(94)))));
            this.aboutButton.OnIdleState.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.aboutButton.OnIdleState.IconLeftImage = global::Cowin_Portal.Properties.Resources.icons8_info_96;
            this.aboutButton.OnIdleState.IconRightImage = null;
            this.aboutButton.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(32)))), ((int)(((byte)(150)))));
            this.aboutButton.OnPressedState.BorderRadius = 1;
            this.aboutButton.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.aboutButton.OnPressedState.BorderThickness = 1;
            this.aboutButton.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(32)))), ((int)(((byte)(150)))));
            this.aboutButton.OnPressedState.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.aboutButton.OnPressedState.IconLeftImage = null;
            this.aboutButton.OnPressedState.IconRightImage = null;
            this.aboutButton.Size = new System.Drawing.Size(200, 50);
            this.aboutButton.TabIndex = 4;
            this.aboutButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.aboutButton.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.aboutButton.TextMarginLeft = 0;
            this.aboutButton.TextPadding = new System.Windows.Forms.Padding(0);
            this.aboutButton.UseDefaultRadiusAndThickness = true;
            // 
            // user_centersButton
            // 
            this.user_centersButton.AllowAnimations = true;
            this.user_centersButton.AllowMouseEffects = true;
            this.user_centersButton.AllowToggling = false;
            this.user_centersButton.AnimationSpeed = 200;
            this.user_centersButton.AutoGenerateColors = false;
            this.user_centersButton.AutoRoundBorders = false;
            this.user_centersButton.AutoSizeLeftIcon = true;
            this.user_centersButton.AutoSizeRightIcon = true;
            this.user_centersButton.BackColor = System.Drawing.Color.Transparent;
            this.user_centersButton.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(32)))), ((int)(((byte)(94)))));
            this.user_centersButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("user_centersButton.BackgroundImage")));
            this.user_centersButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.user_centersButton.ButtonText = "Nearest Centers";
            this.user_centersButton.ButtonTextMarginLeft = 0;
            this.user_centersButton.ColorContrastOnClick = 45;
            this.user_centersButton.ColorContrastOnHover = 45;
            this.user_centersButton.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.user_centersButton.CustomizableEdges = borderEdges2;
            this.user_centersButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.user_centersButton.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.user_centersButton.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.user_centersButton.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.user_centersButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.user_centersButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.user_centersButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.user_centersButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.user_centersButton.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.user_centersButton.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.user_centersButton.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.user_centersButton.IconMarginLeft = 11;
            this.user_centersButton.IconPadding = 10;
            this.user_centersButton.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.user_centersButton.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.user_centersButton.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.user_centersButton.IconSize = 25;
            this.user_centersButton.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(32)))), ((int)(((byte)(94)))));
            this.user_centersButton.IdleBorderRadius = 1;
            this.user_centersButton.IdleBorderThickness = 1;
            this.user_centersButton.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(32)))), ((int)(((byte)(94)))));
            this.user_centersButton.IdleIconLeftImage = global::Cowin_Portal.Properties.Resources.icons8_search_96;
            this.user_centersButton.IdleIconRightImage = null;
            this.user_centersButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.user_centersButton.IndicateFocus = false;
            this.user_centersButton.Location = new System.Drawing.Point(0, 145);
            this.user_centersButton.Name = "user_centersButton";
            this.user_centersButton.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.user_centersButton.OnDisabledState.BorderRadius = 1;
            this.user_centersButton.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.user_centersButton.OnDisabledState.BorderThickness = 1;
            this.user_centersButton.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.user_centersButton.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.user_centersButton.OnDisabledState.IconLeftImage = null;
            this.user_centersButton.OnDisabledState.IconRightImage = null;
            this.user_centersButton.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(32)))), ((int)(((byte)(150)))));
            this.user_centersButton.onHoverState.BorderRadius = 1;
            this.user_centersButton.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.user_centersButton.onHoverState.BorderThickness = 1;
            this.user_centersButton.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(32)))), ((int)(((byte)(150)))));
            this.user_centersButton.onHoverState.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.user_centersButton.onHoverState.IconLeftImage = null;
            this.user_centersButton.onHoverState.IconRightImage = null;
            this.user_centersButton.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(32)))), ((int)(((byte)(94)))));
            this.user_centersButton.OnIdleState.BorderRadius = 1;
            this.user_centersButton.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.user_centersButton.OnIdleState.BorderThickness = 1;
            this.user_centersButton.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(32)))), ((int)(((byte)(94)))));
            this.user_centersButton.OnIdleState.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.user_centersButton.OnIdleState.IconLeftImage = global::Cowin_Portal.Properties.Resources.icons8_search_96;
            this.user_centersButton.OnIdleState.IconRightImage = null;
            this.user_centersButton.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(32)))), ((int)(((byte)(150)))));
            this.user_centersButton.OnPressedState.BorderRadius = 1;
            this.user_centersButton.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.user_centersButton.OnPressedState.BorderThickness = 1;
            this.user_centersButton.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(32)))), ((int)(((byte)(150)))));
            this.user_centersButton.OnPressedState.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.user_centersButton.OnPressedState.IconLeftImage = null;
            this.user_centersButton.OnPressedState.IconRightImage = null;
            this.user_centersButton.Size = new System.Drawing.Size(200, 50);
            this.user_centersButton.TabIndex = 3;
            this.user_centersButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.user_centersButton.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.user_centersButton.TextMarginLeft = 0;
            this.user_centersButton.TextPadding = new System.Windows.Forms.Padding(0);
            this.user_centersButton.UseDefaultRadiusAndThickness = true;
            this.user_centersButton.Click += new System.EventHandler(this.user_centersButton_Click);
            // 
            // user_dashboardButton
            // 
            this.user_dashboardButton.AllowAnimations = true;
            this.user_dashboardButton.AllowMouseEffects = true;
            this.user_dashboardButton.AllowToggling = false;
            this.user_dashboardButton.AnimationSpeed = 200;
            this.user_dashboardButton.AutoGenerateColors = false;
            this.user_dashboardButton.AutoRoundBorders = false;
            this.user_dashboardButton.AutoSizeLeftIcon = true;
            this.user_dashboardButton.AutoSizeRightIcon = true;
            this.user_dashboardButton.BackColor = System.Drawing.Color.Transparent;
            this.user_dashboardButton.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(32)))), ((int)(((byte)(94)))));
            this.user_dashboardButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("user_dashboardButton.BackgroundImage")));
            this.user_dashboardButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.user_dashboardButton.ButtonText = "Dashboard";
            this.user_dashboardButton.ButtonTextMarginLeft = 0;
            this.user_dashboardButton.ColorContrastOnClick = 45;
            this.user_dashboardButton.ColorContrastOnHover = 45;
            this.user_dashboardButton.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            this.user_dashboardButton.CustomizableEdges = borderEdges3;
            this.user_dashboardButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.user_dashboardButton.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.user_dashboardButton.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.user_dashboardButton.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.user_dashboardButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.user_dashboardButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.user_dashboardButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.user_dashboardButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.user_dashboardButton.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.user_dashboardButton.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.user_dashboardButton.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.user_dashboardButton.IconMarginLeft = 11;
            this.user_dashboardButton.IconPadding = 10;
            this.user_dashboardButton.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.user_dashboardButton.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.user_dashboardButton.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.user_dashboardButton.IconSize = 25;
            this.user_dashboardButton.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(32)))), ((int)(((byte)(94)))));
            this.user_dashboardButton.IdleBorderRadius = 1;
            this.user_dashboardButton.IdleBorderThickness = 1;
            this.user_dashboardButton.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(32)))), ((int)(((byte)(94)))));
            this.user_dashboardButton.IdleIconLeftImage = global::Cowin_Portal.Properties.Resources.icons8_dashboard_layout_96;
            this.user_dashboardButton.IdleIconRightImage = null;
            this.user_dashboardButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.user_dashboardButton.IndicateFocus = false;
            this.user_dashboardButton.Location = new System.Drawing.Point(0, 95);
            this.user_dashboardButton.Name = "user_dashboardButton";
            this.user_dashboardButton.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.user_dashboardButton.OnDisabledState.BorderRadius = 1;
            this.user_dashboardButton.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.user_dashboardButton.OnDisabledState.BorderThickness = 1;
            this.user_dashboardButton.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.user_dashboardButton.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.user_dashboardButton.OnDisabledState.IconLeftImage = null;
            this.user_dashboardButton.OnDisabledState.IconRightImage = null;
            this.user_dashboardButton.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(32)))), ((int)(((byte)(150)))));
            this.user_dashboardButton.onHoverState.BorderRadius = 1;
            this.user_dashboardButton.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.user_dashboardButton.onHoverState.BorderThickness = 1;
            this.user_dashboardButton.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(32)))), ((int)(((byte)(150)))));
            this.user_dashboardButton.onHoverState.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.user_dashboardButton.onHoverState.IconLeftImage = null;
            this.user_dashboardButton.onHoverState.IconRightImage = null;
            this.user_dashboardButton.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(32)))), ((int)(((byte)(94)))));
            this.user_dashboardButton.OnIdleState.BorderRadius = 1;
            this.user_dashboardButton.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.user_dashboardButton.OnIdleState.BorderThickness = 1;
            this.user_dashboardButton.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(32)))), ((int)(((byte)(94)))));
            this.user_dashboardButton.OnIdleState.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.user_dashboardButton.OnIdleState.IconLeftImage = global::Cowin_Portal.Properties.Resources.icons8_dashboard_layout_96;
            this.user_dashboardButton.OnIdleState.IconRightImage = null;
            this.user_dashboardButton.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(32)))), ((int)(((byte)(150)))));
            this.user_dashboardButton.OnPressedState.BorderRadius = 1;
            this.user_dashboardButton.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.user_dashboardButton.OnPressedState.BorderThickness = 1;
            this.user_dashboardButton.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(32)))), ((int)(((byte)(150)))));
            this.user_dashboardButton.OnPressedState.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.user_dashboardButton.OnPressedState.IconLeftImage = null;
            this.user_dashboardButton.OnPressedState.IconRightImage = null;
            this.user_dashboardButton.Size = new System.Drawing.Size(200, 50);
            this.user_dashboardButton.TabIndex = 1;
            this.user_dashboardButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.user_dashboardButton.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.user_dashboardButton.TextMarginLeft = 0;
            this.user_dashboardButton.TextPadding = new System.Windows.Forms.Padding(0);
            this.user_dashboardButton.UseDefaultRadiusAndThickness = true;
            this.user_dashboardButton.Click += new System.EventHandler(this.user_dashboardButton_Click);
            // 
            // profilePanel
            // 
            this.profilePanel.BackgroundColor = System.Drawing.Color.Lavender;
            this.profilePanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("profilePanel.BackgroundImage")));
            this.profilePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.profilePanel.BorderColor = System.Drawing.Color.Transparent;
            this.profilePanel.BorderRadius = 0;
            this.profilePanel.BorderThickness = 0;
            this.profilePanel.Controls.Add(this.username_label);
            this.profilePanel.Controls.Add(this.bunifuPictureBox2);
            this.profilePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.profilePanel.Location = new System.Drawing.Point(0, 0);
            this.profilePanel.Name = "profilePanel";
            this.profilePanel.ShowBorders = true;
            this.profilePanel.Size = new System.Drawing.Size(200, 95);
            this.profilePanel.TabIndex = 0;
            // 
            // username_label
            // 
            this.username_label.AutoSize = true;
            this.username_label.BackColor = System.Drawing.Color.Transparent;
            this.username_label.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_label.Location = new System.Drawing.Point(94, 39);
            this.username_label.Name = "username_label";
            this.username_label.Size = new System.Drawing.Size(54, 17);
            this.username_label.TabIndex = 1;
            this.username_label.Text = "[NAME]";
            // 
            // bunifuPictureBox2
            // 
            this.bunifuPictureBox2.AllowFocused = false;
            this.bunifuPictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuPictureBox2.AutoSizeHeight = true;
            this.bunifuPictureBox2.BorderRadius = 37;
            this.bunifuPictureBox2.Image = global::Cowin_Portal.Properties.Resources.icons8_display_pic;
            this.bunifuPictureBox2.IsCircle = true;
            this.bunifuPictureBox2.Location = new System.Drawing.Point(11, 10);
            this.bunifuPictureBox2.Name = "bunifuPictureBox2";
            this.bunifuPictureBox2.Size = new System.Drawing.Size(75, 75);
            this.bunifuPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuPictureBox2.TabIndex = 0;
            this.bunifuPictureBox2.TabStop = false;
            this.bunifuPictureBox2.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            // 
            // User_Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.panel_display);
            this.Controls.Add(this.bunifuPanel1);
            this.Controls.Add(this.optionsPanel);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "User_Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User_Dashboard";
            this.bunifuPanel1.ResumeLayout(false);
            this.optionsPanel.ResumeLayout(false);
            this.profilePanel.ResumeLayout(false);
            this.profilePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuPanel optionsPanel;
        private Bunifu.UI.WinForms.BunifuPanel profilePanel;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton aboutButton;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton user_centersButton;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton user_dashboardButton;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
        private Bunifu.UI.WinForms.BunifuPanel panel_display;
        private Bunifu.UI.WinForms.BunifuPictureBox bunifuPictureBox2;
        private System.Windows.Forms.Label username_label;
        private System.Windows.Forms.Label dashboard_label;
    }
}