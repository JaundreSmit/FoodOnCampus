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
            this.components = new System.ComponentModel.Container();
            this.btnProfile = new System.Windows.Forms.Button();
            this.pnlNavigate = new System.Windows.Forms.Panel();
            this.btnWelcome = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnRestaurants = new System.Windows.Forms.Button();
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
            this.pnlNavigate.Controls.Add(this.btnRestaurants);
            this.pnlNavigate.Controls.Add(this.btnProfile);
            this.pnlNavigate.Controls.Add(this.btnWelcome);
            this.pnlNavigate.Location = new System.Drawing.Point(0, 0);
            this.pnlNavigate.Name = "pnlNavigate";
            this.pnlNavigate.Size = new System.Drawing.Size(879, 64);
            this.pnlNavigate.TabIndex = 1;
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
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // btnRestaurants
            // 
            this.btnRestaurants.Location = new System.Drawing.Point(122, 12);
            this.btnRestaurants.Name = "btnRestaurants";
            this.btnRestaurants.Size = new System.Drawing.Size(96, 36);
            this.btnRestaurants.TabIndex = 2;
            this.btnRestaurants.Text = "Restaurants";
            this.btnRestaurants.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 521);
            this.Controls.Add(this.pnlNavigate);
            this.IsMdiContainer = true;
            this.Name = "frmMain";
            this.Text = "Food On Campus";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.pnlNavigate.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlNavigate;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        internal System.Windows.Forms.Button btnRestaurants;
        internal System.Windows.Forms.Button btnProfile;
        internal System.Windows.Forms.Button btnWelcome;
    }
}

