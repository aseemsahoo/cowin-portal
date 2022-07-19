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
            this.panel_display = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dashboard_label = new System.Windows.Forms.Label();
            this.optionsPanel = new System.Windows.Forms.Panel();
            this.user_aboutButton = new Guna.UI2.WinForms.Guna2Button();
            this.user_centersButton = new Guna.UI2.WinForms.Guna2Button();
            this.user_dashboardButton = new Guna.UI2.WinForms.Guna2Button();
            this.profilePanel = new System.Windows.Forms.Panel();
            this.username_label = new System.Windows.Forms.Label();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.panel1.SuspendLayout();
            this.optionsPanel.SuspendLayout();
            this.profilePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_display
            // 
            this.panel_display.Location = new System.Drawing.Point(200, 46);
            this.panel_display.Name = "panel_display";
            this.panel_display.Size = new System.Drawing.Size(584, 515);
            this.panel_display.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Controls.Add(this.dashboard_label);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(200, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(584, 47);
            this.panel1.TabIndex = 0;
            // 
            // dashboard_label
            // 
            this.dashboard_label.BackColor = System.Drawing.Color.Transparent;
            this.dashboard_label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dashboard_label.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboard_label.ForeColor = System.Drawing.Color.FloralWhite;
            this.dashboard_label.Location = new System.Drawing.Point(0, 0);
            this.dashboard_label.Name = "dashboard_label";
            this.dashboard_label.Size = new System.Drawing.Size(584, 47);
            this.dashboard_label.TabIndex = 2;
            this.dashboard_label.Text = "Your Dashboard";
            this.dashboard_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // optionsPanel
            // 
            this.optionsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(32)))), ((int)(((byte)(94)))));
            this.optionsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.optionsPanel.Controls.Add(this.user_aboutButton);
            this.optionsPanel.Controls.Add(this.user_centersButton);
            this.optionsPanel.Controls.Add(this.user_dashboardButton);
            this.optionsPanel.Controls.Add(this.profilePanel);
            this.optionsPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.optionsPanel.Location = new System.Drawing.Point(0, 0);
            this.optionsPanel.Name = "optionsPanel";
            this.optionsPanel.Size = new System.Drawing.Size(200, 561);
            this.optionsPanel.TabIndex = 1;
            // 
            // user_aboutButton
            // 
            this.user_aboutButton.Animated = true;
            this.user_aboutButton.BorderColor = System.Drawing.Color.Transparent;
            this.user_aboutButton.BorderRadius = 1;
            this.user_aboutButton.BorderThickness = 1;
            this.user_aboutButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.user_aboutButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.user_aboutButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.user_aboutButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.user_aboutButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.user_aboutButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(32)))), ((int)(((byte)(94)))));
            this.user_aboutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_aboutButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.user_aboutButton.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(32)))), ((int)(((byte)(150)))));
            this.user_aboutButton.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(32)))), ((int)(((byte)(150)))));
            this.user_aboutButton.HoverState.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.user_aboutButton.Image = global::Cowin_Portal.Properties.Resources.icons8_info_96;
            this.user_aboutButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.user_aboutButton.ImageSize = new System.Drawing.Size(30, 30);
            this.user_aboutButton.Location = new System.Drawing.Point(0, 203);
            this.user_aboutButton.Name = "user_aboutButton";
            this.user_aboutButton.Padding = new System.Windows.Forms.Padding(3);
            this.user_aboutButton.Size = new System.Drawing.Size(198, 50);
            this.user_aboutButton.TabIndex = 9;
            this.user_aboutButton.Text = "About";
            // 
            // user_centersButton
            // 
            this.user_centersButton.Animated = true;
            this.user_centersButton.BorderColor = System.Drawing.Color.Transparent;
            this.user_centersButton.BorderRadius = 1;
            this.user_centersButton.BorderThickness = 1;
            this.user_centersButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.user_centersButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.user_centersButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.user_centersButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.user_centersButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.user_centersButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(32)))), ((int)(((byte)(94)))));
            this.user_centersButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_centersButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.user_centersButton.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(32)))), ((int)(((byte)(150)))));
            this.user_centersButton.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(32)))), ((int)(((byte)(150)))));
            this.user_centersButton.HoverState.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.user_centersButton.Image = global::Cowin_Portal.Properties.Resources.icons8_search_96;
            this.user_centersButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.user_centersButton.ImageSize = new System.Drawing.Size(30, 30);
            this.user_centersButton.Location = new System.Drawing.Point(0, 153);
            this.user_centersButton.Name = "user_centersButton";
            this.user_centersButton.Padding = new System.Windows.Forms.Padding(3);
            this.user_centersButton.Size = new System.Drawing.Size(198, 50);
            this.user_centersButton.TabIndex = 8;
            this.user_centersButton.Text = "Nearest Centers";
            this.user_centersButton.Click += new System.EventHandler(this.user_centersButton_Click);
            // 
            // user_dashboardButton
            // 
            this.user_dashboardButton.Animated = true;
            this.user_dashboardButton.BorderColor = System.Drawing.Color.Transparent;
            this.user_dashboardButton.BorderRadius = 1;
            this.user_dashboardButton.BorderThickness = 1;
            this.user_dashboardButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.user_dashboardButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.user_dashboardButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.user_dashboardButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.user_dashboardButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.user_dashboardButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(32)))), ((int)(((byte)(94)))));
            this.user_dashboardButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_dashboardButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.user_dashboardButton.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(32)))), ((int)(((byte)(150)))));
            this.user_dashboardButton.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(32)))), ((int)(((byte)(150)))));
            this.user_dashboardButton.HoverState.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.user_dashboardButton.Image = global::Cowin_Portal.Properties.Resources.icons8_dashboard_layout_96;
            this.user_dashboardButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.user_dashboardButton.ImageSize = new System.Drawing.Size(30, 30);
            this.user_dashboardButton.Location = new System.Drawing.Point(0, 103);
            this.user_dashboardButton.Name = "user_dashboardButton";
            this.user_dashboardButton.Padding = new System.Windows.Forms.Padding(3);
            this.user_dashboardButton.Size = new System.Drawing.Size(198, 50);
            this.user_dashboardButton.TabIndex = 7;
            this.user_dashboardButton.Text = "Dashboard";
            this.user_dashboardButton.Click += new System.EventHandler(this.user_dashboardButton_Click);
            // 
            // profilePanel
            // 
            this.profilePanel.BackColor = System.Drawing.Color.Bisque;
            this.profilePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.profilePanel.Controls.Add(this.username_label);
            this.profilePanel.Controls.Add(this.guna2PictureBox1);
            this.profilePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.profilePanel.Location = new System.Drawing.Point(0, 0);
            this.profilePanel.Name = "profilePanel";
            this.profilePanel.Size = new System.Drawing.Size(198, 103);
            this.profilePanel.TabIndex = 6;
            // 
            // username_label
            // 
            this.username_label.AutoSize = true;
            this.username_label.BackColor = System.Drawing.Color.Transparent;
            this.username_label.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_label.Location = new System.Drawing.Point(105, 57);
            this.username_label.Name = "username_label";
            this.username_label.Size = new System.Drawing.Size(54, 17);
            this.username_label.TabIndex = 1;
            this.username_label.Text = "[NAME]";
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = global::Cowin_Portal.Properties.Resources.icons8_display_pic;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(12, 12);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(87, 79);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 0;
            this.guna2PictureBox1.TabStop = false;
            // 
            // User_Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.optionsPanel);
            this.Controls.Add(this.panel_display);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "User_Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User_Dashboard";
            this.panel1.ResumeLayout(false);
            this.optionsPanel.ResumeLayout(false);
            this.profilePanel.ResumeLayout(false);
            this.profilePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_display;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label dashboard_label;
        private System.Windows.Forms.Panel optionsPanel;
        private System.Windows.Forms.Panel profilePanel;
        private System.Windows.Forms.Label username_label;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2Button user_dashboardButton;
        private Guna.UI2.WinForms.Guna2Button user_aboutButton;
        private Guna.UI2.WinForms.Guna2Button user_centersButton;
    }
}