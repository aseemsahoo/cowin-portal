namespace Cowin_Portal
{
    partial class Login_UI
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
            this.components = new System.ComponentModel.Container();
            this.errorProvider_cowin = new System.Windows.Forms.ErrorProvider(this.components);
            this.status_label = new System.Windows.Forms.Label();
            this.cowin_tab = new System.Windows.Forms.TabControl();
            this.intro_page = new System.Windows.Forms.TabPage();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.signup_page = new System.Windows.Forms.TabPage();
            this.passwordInsTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.usernameInsTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.PhNumberInsTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.signup_final_button = new Guna.UI2.WinForms.Guna2Button();
            this.label8 = new System.Windows.Forms.Label();
            this.guna2Separator2 = new Guna.UI2.WinForms.Guna2Separator();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.login_page = new System.Windows.Forms.TabPage();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.login_password = new Guna.UI2.WinForms.Guna2TextBox();
            this.login_username = new Guna.UI2.WinForms.Guna2TextBox();
            this.login_final_button = new Guna.UI2.WinForms.Guna2Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.login_select_button = new Guna.UI2.WinForms.Guna2Button();
            this.signup_select_Button = new Guna.UI2.WinForms.Guna2Button();
            this.exit_label = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_cowin)).BeginInit();
            this.cowin_tab.SuspendLayout();
            this.intro_page.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.signup_page.SuspendLayout();
            this.login_page.SuspendLayout();
            this.guna2CustomGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // errorProvider_cowin
            // 
            this.errorProvider_cowin.ContainerControl = this;
            // 
            // status_label
            // 
            this.status_label.AutoSize = true;
            this.status_label.Location = new System.Drawing.Point(578, 450);
            this.status_label.Name = "status_label";
            this.status_label.Size = new System.Drawing.Size(35, 13);
            this.status_label.TabIndex = 3;
            this.status_label.Text = "label1";
            // 
            // cowin_tab
            // 
            this.cowin_tab.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.cowin_tab.Controls.Add(this.intro_page);
            this.cowin_tab.Controls.Add(this.signup_page);
            this.cowin_tab.Controls.Add(this.login_page);
            this.cowin_tab.Location = new System.Drawing.Point(314, -22);
            this.cowin_tab.Name = "cowin_tab";
            this.cowin_tab.SelectedIndex = 0;
            this.cowin_tab.Size = new System.Drawing.Size(431, 467);
            this.cowin_tab.TabIndex = 12;
            // 
            // intro_page
            // 
            this.intro_page.BackColor = System.Drawing.Color.WhiteSmoke;
            this.intro_page.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.intro_page.Controls.Add(this.guna2PictureBox1);
            this.intro_page.Location = new System.Drawing.Point(4, 25);
            this.intro_page.Name = "intro_page";
            this.intro_page.Padding = new System.Windows.Forms.Padding(3);
            this.intro_page.Size = new System.Drawing.Size(423, 438);
            this.intro_page.TabIndex = 0;
            this.intro_page.Text = "intro";
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.guna2PictureBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.Image = global::Cowin_Portal.Properties.Resources.cowin_intro_pic2;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(3, 55);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(411, 306);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 2;
            this.guna2PictureBox1.TabStop = false;
            // 
            // signup_page
            // 
            this.signup_page.BackColor = System.Drawing.Color.WhiteSmoke;
            this.signup_page.Controls.Add(this.passwordInsTxt);
            this.signup_page.Controls.Add(this.usernameInsTxt);
            this.signup_page.Controls.Add(this.PhNumberInsTxt);
            this.signup_page.Controls.Add(this.signup_final_button);
            this.signup_page.Controls.Add(this.label8);
            this.signup_page.Controls.Add(this.guna2Separator2);
            this.signup_page.Controls.Add(this.label7);
            this.signup_page.Controls.Add(this.label6);
            this.signup_page.Controls.Add(this.label9);
            this.signup_page.Location = new System.Drawing.Point(4, 25);
            this.signup_page.Name = "signup_page";
            this.signup_page.Padding = new System.Windows.Forms.Padding(3);
            this.signup_page.Size = new System.Drawing.Size(423, 438);
            this.signup_page.TabIndex = 1;
            this.signup_page.Text = "sign_up";
            // 
            // passwordInsTxt
            // 
            this.passwordInsTxt.BackColor = System.Drawing.Color.Transparent;
            this.passwordInsTxt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.passwordInsTxt.BorderColor = System.Drawing.Color.Navy;
            this.passwordInsTxt.BorderThickness = 2;
            this.passwordInsTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passwordInsTxt.DefaultText = "";
            this.passwordInsTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.passwordInsTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.passwordInsTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passwordInsTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passwordInsTxt.FillColor = System.Drawing.Color.WhiteSmoke;
            this.passwordInsTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.passwordInsTxt.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.passwordInsTxt.ForeColor = System.Drawing.Color.Black;
            this.passwordInsTxt.HoverState.BorderColor = System.Drawing.Color.Blue;
            this.passwordInsTxt.HoverState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.passwordInsTxt.Location = new System.Drawing.Point(73, 275);
            this.passwordInsTxt.Name = "passwordInsTxt";
            this.passwordInsTxt.PasswordChar = '●';
            this.passwordInsTxt.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.passwordInsTxt.PlaceholderText = "Enter your password";
            this.passwordInsTxt.SelectedText = "";
            this.passwordInsTxt.Size = new System.Drawing.Size(270, 41);
            this.passwordInsTxt.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.passwordInsTxt.TabIndex = 106;
            this.passwordInsTxt.UseSystemPasswordChar = true;
            this.passwordInsTxt.WordWrap = false;
            // 
            // usernameInsTxt
            // 
            this.usernameInsTxt.BackColor = System.Drawing.Color.Transparent;
            this.usernameInsTxt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.usernameInsTxt.BorderColor = System.Drawing.Color.Navy;
            this.usernameInsTxt.BorderThickness = 2;
            this.usernameInsTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.usernameInsTxt.DefaultText = "";
            this.usernameInsTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.usernameInsTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.usernameInsTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.usernameInsTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.usernameInsTxt.FillColor = System.Drawing.Color.WhiteSmoke;
            this.usernameInsTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.usernameInsTxt.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.usernameInsTxt.ForeColor = System.Drawing.Color.Black;
            this.usernameInsTxt.HoverState.BorderColor = System.Drawing.Color.Blue;
            this.usernameInsTxt.HoverState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.usernameInsTxt.Location = new System.Drawing.Point(73, 200);
            this.usernameInsTxt.Name = "usernameInsTxt";
            this.usernameInsTxt.PasswordChar = '\0';
            this.usernameInsTxt.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.usernameInsTxt.PlaceholderText = "Enter your username";
            this.usernameInsTxt.SelectedText = "";
            this.usernameInsTxt.Size = new System.Drawing.Size(270, 41);
            this.usernameInsTxt.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.usernameInsTxt.TabIndex = 105;
            // 
            // PhNumberInsTxt
            // 
            this.PhNumberInsTxt.BackColor = System.Drawing.Color.Transparent;
            this.PhNumberInsTxt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PhNumberInsTxt.BorderColor = System.Drawing.Color.Navy;
            this.PhNumberInsTxt.BorderThickness = 2;
            this.PhNumberInsTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PhNumberInsTxt.DefaultText = "";
            this.PhNumberInsTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.PhNumberInsTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.PhNumberInsTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PhNumberInsTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PhNumberInsTxt.FillColor = System.Drawing.Color.WhiteSmoke;
            this.PhNumberInsTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PhNumberInsTxt.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.PhNumberInsTxt.ForeColor = System.Drawing.Color.Black;
            this.PhNumberInsTxt.HoverState.BorderColor = System.Drawing.Color.Blue;
            this.PhNumberInsTxt.HoverState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.PhNumberInsTxt.Location = new System.Drawing.Point(73, 126);
            this.PhNumberInsTxt.Name = "PhNumberInsTxt";
            this.PhNumberInsTxt.PasswordChar = '\0';
            this.PhNumberInsTxt.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.PhNumberInsTxt.PlaceholderText = "Enter your phone number";
            this.PhNumberInsTxt.SelectedText = "";
            this.PhNumberInsTxt.Size = new System.Drawing.Size(270, 41);
            this.PhNumberInsTxt.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.PhNumberInsTxt.TabIndex = 104;
            // 
            // signup_final_button
            // 
            this.signup_final_button.Animated = true;
            this.signup_final_button.BackColor = System.Drawing.Color.Transparent;
            this.signup_final_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.signup_final_button.BorderColor = System.Drawing.Color.Navy;
            this.signup_final_button.BorderRadius = 15;
            this.signup_final_button.BorderThickness = 2;
            this.signup_final_button.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.signup_final_button.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.signup_final_button.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.signup_final_button.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.signup_final_button.FillColor = System.Drawing.Color.Navy;
            this.signup_final_button.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signup_final_button.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.signup_final_button.HoverState.BorderColor = System.Drawing.Color.DarkBlue;
            this.signup_final_button.HoverState.FillColor = System.Drawing.Color.White;
            this.signup_final_button.HoverState.ForeColor = System.Drawing.Color.Navy;
            this.signup_final_button.Location = new System.Drawing.Point(72, 363);
            this.signup_final_button.Name = "signup_final_button";
            this.signup_final_button.Size = new System.Drawing.Size(273, 32);
            this.signup_final_button.TabIndex = 103;
            this.signup_final_button.Text = "Sign Up";
            this.signup_final_button.TextOffset = new System.Drawing.Point(0, -2);
            this.signup_final_button.UseTransparentBackground = true;
            this.signup_final_button.Click += new System.EventHandler(this.signup_final_button_Click);
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label8.Dock = System.Windows.Forms.DockStyle.Top;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 21.75F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(32)))), ((int)(((byte)(94)))));
            this.label8.Location = new System.Drawing.Point(3, 3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(417, 60);
            this.label8.TabIndex = 102;
            this.label8.Text = "Sign Up";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2Separator2
            // 
            this.guna2Separator2.Location = new System.Drawing.Point(133, 65);
            this.guna2Separator2.Name = "guna2Separator2";
            this.guna2Separator2.Size = new System.Drawing.Size(151, 10);
            this.guna2Separator2.TabIndex = 101;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label7.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.RosyBrown;
            this.label7.Location = new System.Drawing.Point(69, 104);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 18);
            this.label7.TabIndex = 100;
            this.label7.Text = "Phone Number";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label6.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.RosyBrown;
            this.label6.Location = new System.Drawing.Point(69, 254);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 18);
            this.label6.TabIndex = 99;
            this.label6.Text = "Password";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label9.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.RosyBrown;
            this.label9.Location = new System.Drawing.Point(69, 179);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 18);
            this.label9.TabIndex = 98;
            this.label9.Text = "Username";
            // 
            // login_page
            // 
            this.login_page.BackColor = System.Drawing.Color.WhiteSmoke;
            this.login_page.Controls.Add(this.guna2Separator1);
            this.login_page.Controls.Add(this.login_password);
            this.login_page.Controls.Add(this.login_username);
            this.login_page.Controls.Add(this.login_final_button);
            this.login_page.Controls.Add(this.label10);
            this.login_page.Controls.Add(this.label11);
            this.login_page.Controls.Add(this.label12);
            this.login_page.Location = new System.Drawing.Point(4, 25);
            this.login_page.Name = "login_page";
            this.login_page.Padding = new System.Windows.Forms.Padding(3);
            this.login_page.Size = new System.Drawing.Size(423, 438);
            this.login_page.TabIndex = 2;
            this.login_page.Text = "login";
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.Location = new System.Drawing.Point(133, 65);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(151, 10);
            this.guna2Separator1.TabIndex = 105;
            // 
            // login_password
            // 
            this.login_password.BackColor = System.Drawing.Color.Transparent;
            this.login_password.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.login_password.BorderColor = System.Drawing.Color.Navy;
            this.login_password.BorderThickness = 2;
            this.login_password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.login_password.DefaultText = "";
            this.login_password.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.login_password.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.login_password.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.login_password.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.login_password.FillColor = System.Drawing.Color.WhiteSmoke;
            this.login_password.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.login_password.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.login_password.ForeColor = System.Drawing.Color.Black;
            this.login_password.HoverState.BorderColor = System.Drawing.Color.Blue;
            this.login_password.HoverState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.login_password.Location = new System.Drawing.Point(73, 230);
            this.login_password.Name = "login_password";
            this.login_password.PasswordChar = '●';
            this.login_password.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.login_password.PlaceholderText = "Enter your password";
            this.login_password.SelectedText = "";
            this.login_password.Size = new System.Drawing.Size(270, 41);
            this.login_password.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.login_password.TabIndex = 104;
            this.login_password.UseSystemPasswordChar = true;
            this.login_password.WordWrap = false;
            // 
            // login_username
            // 
            this.login_username.BackColor = System.Drawing.Color.Transparent;
            this.login_username.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.login_username.BorderColor = System.Drawing.Color.Navy;
            this.login_username.BorderThickness = 2;
            this.login_username.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.login_username.DefaultText = "";
            this.login_username.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.login_username.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.login_username.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.login_username.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.login_username.FillColor = System.Drawing.Color.WhiteSmoke;
            this.login_username.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.login_username.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.login_username.ForeColor = System.Drawing.Color.Black;
            this.login_username.HoverState.BorderColor = System.Drawing.Color.Blue;
            this.login_username.HoverState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.login_username.Location = new System.Drawing.Point(73, 148);
            this.login_username.Name = "login_username";
            this.login_username.PasswordChar = '\0';
            this.login_username.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.login_username.PlaceholderText = "Enter your username";
            this.login_username.SelectedText = "";
            this.login_username.Size = new System.Drawing.Size(270, 41);
            this.login_username.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.login_username.TabIndex = 103;
            // 
            // login_final_button
            // 
            this.login_final_button.Animated = true;
            this.login_final_button.BackColor = System.Drawing.Color.Transparent;
            this.login_final_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.login_final_button.BorderColor = System.Drawing.Color.Navy;
            this.login_final_button.BorderRadius = 15;
            this.login_final_button.BorderThickness = 2;
            this.login_final_button.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.login_final_button.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.login_final_button.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.login_final_button.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.login_final_button.FillColor = System.Drawing.Color.Navy;
            this.login_final_button.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.login_final_button.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.login_final_button.HoverState.BorderColor = System.Drawing.Color.DarkBlue;
            this.login_final_button.HoverState.FillColor = System.Drawing.Color.White;
            this.login_final_button.HoverState.ForeColor = System.Drawing.Color.Navy;
            this.login_final_button.Location = new System.Drawing.Point(72, 318);
            this.login_final_button.Name = "login_final_button";
            this.login_final_button.Size = new System.Drawing.Size(271, 32);
            this.login_final_button.TabIndex = 102;
            this.login_final_button.Text = "Login";
            this.login_final_button.TextOffset = new System.Drawing.Point(0, -2);
            this.login_final_button.UseTransparentBackground = true;
            this.login_final_button.Click += new System.EventHandler(this.login_final_button_Click);
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Dock = System.Windows.Forms.DockStyle.Top;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 21.75F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(32)))), ((int)(((byte)(94)))));
            this.label10.Location = new System.Drawing.Point(3, 3);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(417, 60);
            this.label10.TabIndex = 101;
            this.label10.Text = "Login";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label11.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.RosyBrown;
            this.label11.Location = new System.Drawing.Point(69, 210);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 18);
            this.label11.TabIndex = 100;
            this.label11.Text = "Password";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label12.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.Color.RosyBrown;
            this.label12.Location = new System.Drawing.Point(69, 127);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(72, 18);
            this.label12.TabIndex = 99;
            this.label12.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(535, 450);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Status : ";
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.BackColor = System.Drawing.Color.Silver;
            this.guna2CustomGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.guna2CustomGradientPanel1.Controls.Add(this.login_select_button);
            this.guna2CustomGradientPanel1.Controls.Add(this.signup_select_Button);
            this.guna2CustomGradientPanel1.Controls.Add(this.exit_label);
            this.guna2CustomGradientPanel1.Controls.Add(this.pictureBox1);
            this.guna2CustomGradientPanel1.Controls.Add(this.label1);
            this.guna2CustomGradientPanel1.Controls.Add(this.label2);
            this.guna2CustomGradientPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(32)))), ((int)(((byte)(50)))));
            this.guna2CustomGradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(32)))), ((int)(((byte)(94)))));
            this.guna2CustomGradientPanel1.FillColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(32)))), ((int)(((byte)(94)))));
            this.guna2CustomGradientPanel1.FillColor4 = System.Drawing.Color.MediumBlue;
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(0, -5);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.Quality = 3;
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(312, 477);
            this.guna2CustomGradientPanel1.TabIndex = 14;
            // 
            // login_select_button
            // 
            this.login_select_button.Animated = true;
            this.login_select_button.BackColor = System.Drawing.Color.Transparent;
            this.login_select_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.login_select_button.BorderColor = System.Drawing.Color.White;
            this.login_select_button.BorderRadius = 15;
            this.login_select_button.BorderThickness = 2;
            this.login_select_button.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.login_select_button.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.login_select_button.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.login_select_button.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.login_select_button.FillColor = System.Drawing.Color.Transparent;
            this.login_select_button.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_select_button.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.login_select_button.HoverState.BorderColor = System.Drawing.Color.White;
            this.login_select_button.HoverState.FillColor = System.Drawing.Color.White;
            this.login_select_button.HoverState.ForeColor = System.Drawing.Color.Transparent;
            this.login_select_button.Location = new System.Drawing.Point(27, 393);
            this.login_select_button.Name = "login_select_button";
            this.login_select_button.Size = new System.Drawing.Size(125, 35);
            this.login_select_button.TabIndex = 105;
            this.login_select_button.Text = "Login";
            this.login_select_button.TextOffset = new System.Drawing.Point(0, -2);
            this.login_select_button.UseTransparentBackground = true;
            this.login_select_button.Click += new System.EventHandler(this.login_select_button_Click);
            // 
            // signup_select_Button
            // 
            this.signup_select_Button.Animated = true;
            this.signup_select_Button.BackColor = System.Drawing.Color.Transparent;
            this.signup_select_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.signup_select_Button.BorderColor = System.Drawing.Color.White;
            this.signup_select_Button.BorderRadius = 15;
            this.signup_select_Button.BorderThickness = 2;
            this.signup_select_Button.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.signup_select_Button.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.signup_select_Button.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.signup_select_Button.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.signup_select_Button.FillColor = System.Drawing.Color.Transparent;
            this.signup_select_Button.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signup_select_Button.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.signup_select_Button.HoverState.BorderColor = System.Drawing.Color.White;
            this.signup_select_Button.HoverState.FillColor = System.Drawing.Color.White;
            this.signup_select_Button.HoverState.ForeColor = System.Drawing.Color.Transparent;
            this.signup_select_Button.Location = new System.Drawing.Point(160, 393);
            this.signup_select_Button.Name = "signup_select_Button";
            this.signup_select_Button.Size = new System.Drawing.Size(125, 35);
            this.signup_select_Button.TabIndex = 104;
            this.signup_select_Button.Text = "Sign Up";
            this.signup_select_Button.TextOffset = new System.Drawing.Point(0, -2);
            this.signup_select_Button.UseTransparentBackground = true;
            this.signup_select_Button.Click += new System.EventHandler(this.signup_select_Button_Click);
            // 
            // exit_label
            // 
            this.exit_label.AutoSize = true;
            this.exit_label.BackColor = System.Drawing.Color.Transparent;
            this.exit_label.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Underline);
            this.exit_label.ForeColor = System.Drawing.Color.Beige;
            this.exit_label.Location = new System.Drawing.Point(261, 443);
            this.exit_label.Name = "exit_label";
            this.exit_label.Size = new System.Drawing.Size(28, 17);
            this.exit_label.TabIndex = 17;
            this.exit_label.Text = "Exit";
            this.exit_label.Click += new System.EventHandler(this.exit_label_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::Cowin_Portal.Properties.Resources.cowin_intro_pic1;
            this.pictureBox1.Location = new System.Drawing.Point(17, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(272, 94);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic);
            this.label1.ForeColor = System.Drawing.Color.Beige;
            this.label1.Location = new System.Drawing.Point(27, 243);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 84);
            this.label1.TabIndex = 15;
            this.label1.Text = "\"India is set to defeat Covid-19. \r\nEvery Indian is making it possible.\"\r\n\r\n- PM " +
    "Narendra Modi\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Beige;
            this.label2.Location = new System.Drawing.Point(12, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 37);
            this.label2.TabIndex = 14;
            this.label2.Text = "CoWin Portal";
            // 
            // Login_UI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(745, 471);
            this.Controls.Add(this.guna2CustomGradientPanel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cowin_tab);
            this.Controls.Add(this.status_label);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login_UI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_cowin)).EndInit();
            this.cowin_tab.ResumeLayout(false);
            this.intro_page.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.signup_page.ResumeLayout(false);
            this.signup_page.PerformLayout();
            this.login_page.ResumeLayout(false);
            this.login_page.PerformLayout();
            this.guna2CustomGradientPanel1.ResumeLayout(false);
            this.guna2CustomGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ErrorProvider errorProvider_cowin;
        private System.Windows.Forms.Label status_label;
        private System.Windows.Forms.TabControl cowin_tab;
        private System.Windows.Forms.TabPage intro_page;
        private System.Windows.Forms.TabPage signup_page;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2TextBox passwordInsTxt;
        private Guna.UI2.WinForms.Guna2TextBox usernameInsTxt;
        private Guna.UI2.WinForms.Guna2TextBox PhNumberInsTxt;
        private Guna.UI2.WinForms.Guna2Button signup_final_button;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TabPage login_page;
        private Guna.UI2.WinForms.Guna2TextBox login_password;
        private Guna.UI2.WinForms.Guna2TextBox login_username;
        private Guna.UI2.WinForms.Guna2Button login_final_button;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private System.Windows.Forms.Label exit_label;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button signup_select_Button;
        private Guna.UI2.WinForms.Guna2Button login_select_button;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
    }
}

