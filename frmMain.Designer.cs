namespace FoodOnCampus
{
    partial class frmMain
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
            this.btnProfile = new System.Windows.Forms.Button();
            this.pnlNavigate = new System.Windows.Forms.Panel();
            this.btnAdminPanel = new System.Windows.Forms.Button();
            this.btnDriverMenu = new System.Windows.Forms.Button();
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnWelcome = new System.Windows.Forms.Button();
            this.pnlNavigate.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnProfile
            // 
            this.btnProfile.Location = new System.Drawing.Point(773, 12);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(96, 36);
            this.btnProfile.TabIndex = 0;
            this.btnProfile.Text = "Profile";
            this.btnProfile.UseVisualStyleBackColor = true;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // pnlNavigate
            // 
            this.pnlNavigate.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pnlNavigate.Controls.Add(this.btnAdminPanel);
            this.pnlNavigate.Controls.Add(this.btnDriverMenu);
            this.pnlNavigate.Controls.Add(this.btnOrder);
            this.pnlNavigate.Controls.Add(this.btnProfile);
            this.pnlNavigate.Controls.Add(this.btnWelcome);
            this.pnlNavigate.Location = new System.Drawing.Point(0, 0);
            this.pnlNavigate.Name = "pnlNavigate";
            this.pnlNavigate.Size = new System.Drawing.Size(879, 64);
            this.pnlNavigate.TabIndex = 1;
            // 
            // btnAdminPanel
            // 
            this.btnAdminPanel.Location = new System.Drawing.Point(364, 12);
            this.btnAdminPanel.Name = "btnAdminPanel";
            this.btnAdminPanel.Size = new System.Drawing.Size(96, 36);
            this.btnAdminPanel.TabIndex = 4;
            this.btnAdminPanel.Text = "Admin Panel";
            this.btnAdminPanel.UseVisualStyleBackColor = true;
            this.btnAdminPanel.Click += new System.EventHandler(this.btnAdminPanel_Click);
            // 
            // btnDriverMenu
            // 
            this.btnDriverMenu.Location = new System.Drawing.Point(243, 12);
            this.btnDriverMenu.Name = "btnDriverMenu";
            this.btnDriverMenu.Size = new System.Drawing.Size(96, 36);
            this.btnDriverMenu.TabIndex = 3;
            this.btnDriverMenu.Text = "Driver Menu";
            this.btnDriverMenu.UseVisualStyleBackColor = true;
            this.btnDriverMenu.Click += new System.EventHandler(this.btnDriverMenu_Click);
            // 
            // btnOrder
            // 
            this.btnOrder.Location = new System.Drawing.Point(122, 12);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(96, 36);
            this.btnOrder.TabIndex = 2;
            this.btnOrder.Text = "Place Order";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // btnWelcome
            // 
            this.btnWelcome.Location = new System.Drawing.Point(3, 12);
            this.btnWelcome.Name = "btnWelcome";
            this.btnWelcome.Size = new System.Drawing.Size(96, 36);
            this.btnWelcome.TabIndex = 1;
            this.btnWelcome.Text = "Welcome Page";
            this.btnWelcome.UseVisualStyleBackColor = true;
            this.btnWelcome.Click += new System.EventHandler(this.btnWelcome_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FoodOnCampus.Properties.Resources.FoodOnCampusBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(884, 861);
            this.Controls.Add(this.pnlNavigate);
            this.DoubleBuffered = true;
            this.IsMdiContainer = true;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Food On Campus";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.pnlNavigate.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        internal System.Windows.Forms.Button btnOrder;
        internal System.Windows.Forms.Button btnProfile;
        internal System.Windows.Forms.Button btnWelcome;
        internal System.Windows.Forms.Button btnDriverMenu;
        internal System.Windows.Forms.Button btnAdminPanel;
        public System.Windows.Forms.Panel pnlNavigate;
    }
}

