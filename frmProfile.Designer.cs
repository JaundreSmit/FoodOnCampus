namespace FoodOnCampus
{
    partial class frmProfile
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
            this.btnBack = new System.Windows.Forms.Button();
            this.lblHello = new System.Windows.Forms.Label();
            this.lbxOrders = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUpdatePassword = new System.Windows.Forms.Button();
            this.btnUpdateEmail = new System.Windows.Forms.Button();
            this.tbxPassword = new System.Windows.Forms.TextBox();
            this.tbxEmail = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(373, 372);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(139, 43);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblHello
            // 
            this.lblHello.AutoSize = true;
            this.lblHello.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHello.Location = new System.Drawing.Point(385, 11);
            this.lblHello.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHello.Name = "lblHello";
            this.lblHello.Size = new System.Drawing.Size(95, 36);
            this.lblHello.TabIndex = 1;
            this.lblHello.Text = "label1";
            this.lblHello.Click += new System.EventHandler(this.lblHello_Click);
            // 
            // lbxOrders
            // 
            this.lbxOrders.FormattingEnabled = true;
            this.lbxOrders.ItemHeight = 16;
            this.lbxOrders.Location = new System.Drawing.Point(16, 85);
            this.lbxOrders.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbxOrders.Name = "lbxOrders";
            this.lbxOrders.Size = new System.Drawing.Size(444, 244);
            this.lbxOrders.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(184, 65);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Order History";
            // 
            // btnUpdatePassword
            // 
            this.btnUpdatePassword.Location = new System.Drawing.Point(616, 103);
            this.btnUpdatePassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUpdatePassword.Name = "btnUpdatePassword";
            this.btnUpdatePassword.Size = new System.Drawing.Size(148, 33);
            this.btnUpdatePassword.TabIndex = 4;
            this.btnUpdatePassword.Text = "Update Password";
            this.btnUpdatePassword.UseVisualStyleBackColor = true;
            this.btnUpdatePassword.Click += new System.EventHandler(this.btnUpdatePassword_Click);
            // 
            // btnUpdateEmail
            // 
            this.btnUpdateEmail.Location = new System.Drawing.Point(616, 218);
            this.btnUpdateEmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUpdateEmail.Name = "btnUpdateEmail";
            this.btnUpdateEmail.Size = new System.Drawing.Size(148, 28);
            this.btnUpdateEmail.TabIndex = 5;
            this.btnUpdateEmail.Text = "Update Email";
            this.btnUpdateEmail.UseVisualStyleBackColor = true;
            this.btnUpdateEmail.Click += new System.EventHandler(this.btnUpdateEmail_Click);
            // 
            // tbxPassword
            // 
            this.tbxPassword.Location = new System.Drawing.Point(561, 145);
            this.tbxPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbxPassword.Name = "tbxPassword";
            this.tbxPassword.Size = new System.Drawing.Size(248, 22);
            this.tbxPassword.TabIndex = 6;
            // 
            // tbxEmail
            // 
            this.tbxEmail.Location = new System.Drawing.Point(561, 254);
            this.tbxEmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbxEmail.Name = "tbxEmail";
            this.tbxEmail.Size = new System.Drawing.Size(248, 22);
            this.tbxEmail.TabIndex = 7;
            // 
            // frmProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 430);
            this.Controls.Add(this.tbxEmail);
            this.Controls.Add(this.tbxPassword);
            this.Controls.Add(this.btnUpdateEmail);
            this.Controls.Add(this.btnUpdatePassword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbxOrders);
            this.Controls.Add(this.lblHello);
            this.Controls.Add(this.btnBack);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmProfile";
            this.Text = "Profile";
            this.Load += new System.EventHandler(this.frmProfile_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblHello;
        private System.Windows.Forms.ListBox lbxOrders;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUpdatePassword;
        private System.Windows.Forms.Button btnUpdateEmail;
        private System.Windows.Forms.TextBox tbxPassword;
        private System.Windows.Forms.TextBox tbxEmail;
    }
}