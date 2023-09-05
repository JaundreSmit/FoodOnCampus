namespace FoodOnCampus
{
    partial class frmWelcome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmWelcome));
            this.pnlLogIn = new System.Windows.Forms.Panel();
            this.btnLogIn = new System.Windows.Forms.Button();
            this.txtLogInPassword = new System.Windows.Forms.TextBox();
            this.lblLogInPassword = new System.Windows.Forms.Label();
            this.txtLogInEmail = new System.Windows.Forms.TextBox();
            this.lblLogInEmail = new System.Windows.Forms.Label();
            this.lblLogIn = new System.Windows.Forms.Label();
            this.pnlSignUp = new System.Windows.Forms.Panel();
            this.txtSignUpPassword = new System.Windows.Forms.TextBox();
            this.lblSignUpPassword = new System.Windows.Forms.Label();
            this.txtSignUpEmail = new System.Windows.Forms.TextBox();
            this.lblSignUpEmail = new System.Windows.Forms.Label();
            this.txtSignUpSurname = new System.Windows.Forms.TextBox();
            this.lblSignUpSurname = new System.Windows.Forms.Label();
            this.txtSignUpName = new System.Windows.Forms.TextBox();
            this.lblSignUpName = new System.Windows.Forms.Label();
            this.btnSignUp = new System.Windows.Forms.Button();
            this.lblSignUp = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxConfirmPassword = new System.Windows.Forms.TextBox();
            this.pnlLogIn.SuspendLayout();
            this.pnlSignUp.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlLogIn
            // 
            this.pnlLogIn.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pnlLogIn.Controls.Add(this.btnLogIn);
            this.pnlLogIn.Controls.Add(this.txtLogInPassword);
            this.pnlLogIn.Controls.Add(this.lblLogInPassword);
            this.pnlLogIn.Controls.Add(this.txtLogInEmail);
            this.pnlLogIn.Controls.Add(this.lblLogInEmail);
            this.pnlLogIn.Controls.Add(this.lblLogIn);
            this.pnlLogIn.Location = new System.Drawing.Point(106, 244);
            this.pnlLogIn.Margin = new System.Windows.Forms.Padding(4);
            this.pnlLogIn.Name = "pnlLogIn";
            this.pnlLogIn.Size = new System.Drawing.Size(416, 412);
            this.pnlLogIn.TabIndex = 0;
            this.pnlLogIn.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlLogIn_Paint);
            // 
            // btnLogIn
            // 
            this.btnLogIn.Location = new System.Drawing.Point(115, 313);
            this.btnLogIn.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(183, 80);
            this.btnLogIn.TabIndex = 5;
            this.btnLogIn.Text = "Log In";
            this.btnLogIn.UseVisualStyleBackColor = true;
            this.btnLogIn.Click += new System.EventHandler(this.btnLogIn_Click);
            // 
            // txtLogInPassword
            // 
            this.txtLogInPassword.Location = new System.Drawing.Point(149, 146);
            this.txtLogInPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtLogInPassword.Name = "txtLogInPassword";
            this.txtLogInPassword.PasswordChar = '*';
            this.txtLogInPassword.Size = new System.Drawing.Size(241, 22);
            this.txtLogInPassword.TabIndex = 4;
            this.txtLogInPassword.Text = "Jaundre1";
            this.txtLogInPassword.UseSystemPasswordChar = true;
            // 
            // lblLogInPassword
            // 
            this.lblLogInPassword.AutoSize = true;
            this.lblLogInPassword.Location = new System.Drawing.Point(29, 150);
            this.lblLogInPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLogInPassword.Name = "lblLogInPassword";
            this.lblLogInPassword.Size = new System.Drawing.Size(70, 16);
            this.lblLogInPassword.TabIndex = 3;
            this.lblLogInPassword.Text = "Password:";
            // 
            // txtLogInEmail
            // 
            this.txtLogInEmail.Location = new System.Drawing.Point(149, 95);
            this.txtLogInEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtLogInEmail.Name = "txtLogInEmail";
            this.txtLogInEmail.Size = new System.Drawing.Size(241, 22);
            this.txtLogInEmail.TabIndex = 2;
            this.txtLogInEmail.Text = "jaundre123.smit@gmail.com";
            // 
            // lblLogInEmail
            // 
            this.lblLogInEmail.AutoSize = true;
            this.lblLogInEmail.Location = new System.Drawing.Point(29, 98);
            this.lblLogInEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLogInEmail.Name = "lblLogInEmail";
            this.lblLogInEmail.Size = new System.Drawing.Size(48, 16);
            this.lblLogInEmail.TabIndex = 1;
            this.lblLogInEmail.Text = "E-Mail:";
            // 
            // lblLogIn
            // 
            this.lblLogIn.AutoSize = true;
            this.lblLogIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogIn.Location = new System.Drawing.Point(160, 22);
            this.lblLogIn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLogIn.Name = "lblLogIn";
            this.lblLogIn.Size = new System.Drawing.Size(95, 31);
            this.lblLogIn.TabIndex = 0;
            this.lblLogIn.Text = "Log In";
            // 
            // pnlSignUp
            // 
            this.pnlSignUp.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pnlSignUp.Controls.Add(this.tbxConfirmPassword);
            this.pnlSignUp.Controls.Add(this.label1);
            this.pnlSignUp.Controls.Add(this.txtSignUpPassword);
            this.pnlSignUp.Controls.Add(this.lblSignUpPassword);
            this.pnlSignUp.Controls.Add(this.txtSignUpEmail);
            this.pnlSignUp.Controls.Add(this.lblSignUpEmail);
            this.pnlSignUp.Controls.Add(this.txtSignUpSurname);
            this.pnlSignUp.Controls.Add(this.lblSignUpSurname);
            this.pnlSignUp.Controls.Add(this.txtSignUpName);
            this.pnlSignUp.Controls.Add(this.lblSignUpName);
            this.pnlSignUp.Controls.Add(this.btnSignUp);
            this.pnlSignUp.Controls.Add(this.lblSignUp);
            this.pnlSignUp.Location = new System.Drawing.Point(898, 244);
            this.pnlSignUp.Margin = new System.Windows.Forms.Padding(4);
            this.pnlSignUp.Name = "pnlSignUp";
            this.pnlSignUp.Size = new System.Drawing.Size(416, 412);
            this.pnlSignUp.TabIndex = 1;
            this.pnlSignUp.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlSignUp_Paint);
            // 
            // txtSignUpPassword
            // 
            this.txtSignUpPassword.Location = new System.Drawing.Point(148, 217);
            this.txtSignUpPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtSignUpPassword.Name = "txtSignUpPassword";
            this.txtSignUpPassword.Size = new System.Drawing.Size(241, 22);
            this.txtSignUpPassword.TabIndex = 14;
            this.txtSignUpPassword.UseSystemPasswordChar = true;
            // 
            // lblSignUpPassword
            // 
            this.lblSignUpPassword.AutoSize = true;
            this.lblSignUpPassword.Location = new System.Drawing.Point(15, 221);
            this.lblSignUpPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSignUpPassword.Name = "lblSignUpPassword";
            this.lblSignUpPassword.Size = new System.Drawing.Size(70, 16);
            this.lblSignUpPassword.TabIndex = 13;
            this.lblSignUpPassword.Text = "Password:";
            // 
            // txtSignUpEmail
            // 
            this.txtSignUpEmail.Location = new System.Drawing.Point(148, 166);
            this.txtSignUpEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtSignUpEmail.Name = "txtSignUpEmail";
            this.txtSignUpEmail.Size = new System.Drawing.Size(241, 22);
            this.txtSignUpEmail.TabIndex = 12;
            // 
            // lblSignUpEmail
            // 
            this.lblSignUpEmail.AutoSize = true;
            this.lblSignUpEmail.Location = new System.Drawing.Point(15, 170);
            this.lblSignUpEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSignUpEmail.Name = "lblSignUpEmail";
            this.lblSignUpEmail.Size = new System.Drawing.Size(48, 16);
            this.lblSignUpEmail.TabIndex = 11;
            this.lblSignUpEmail.Text = "E-Mail:";
            // 
            // txtSignUpSurname
            // 
            this.txtSignUpSurname.Location = new System.Drawing.Point(148, 118);
            this.txtSignUpSurname.Margin = new System.Windows.Forms.Padding(4);
            this.txtSignUpSurname.Name = "txtSignUpSurname";
            this.txtSignUpSurname.Size = new System.Drawing.Size(241, 22);
            this.txtSignUpSurname.TabIndex = 10;
            // 
            // lblSignUpSurname
            // 
            this.lblSignUpSurname.AutoSize = true;
            this.lblSignUpSurname.Location = new System.Drawing.Point(15, 122);
            this.lblSignUpSurname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSignUpSurname.Name = "lblSignUpSurname";
            this.lblSignUpSurname.Size = new System.Drawing.Size(64, 16);
            this.lblSignUpSurname.TabIndex = 9;
            this.lblSignUpSurname.Text = "Surname:";
            // 
            // txtSignUpName
            // 
            this.txtSignUpName.Location = new System.Drawing.Point(148, 70);
            this.txtSignUpName.Margin = new System.Windows.Forms.Padding(4);
            this.txtSignUpName.Name = "txtSignUpName";
            this.txtSignUpName.Size = new System.Drawing.Size(241, 22);
            this.txtSignUpName.TabIndex = 8;
            // 
            // lblSignUpName
            // 
            this.lblSignUpName.AutoSize = true;
            this.lblSignUpName.Location = new System.Drawing.Point(15, 74);
            this.lblSignUpName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSignUpName.Name = "lblSignUpName";
            this.lblSignUpName.Size = new System.Drawing.Size(47, 16);
            this.lblSignUpName.TabIndex = 7;
            this.lblSignUpName.Text = "Name:";
            // 
            // btnSignUp
            // 
            this.btnSignUp.Location = new System.Drawing.Point(128, 313);
            this.btnSignUp.Margin = new System.Windows.Forms.Padding(4);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(183, 80);
            this.btnSignUp.TabIndex = 6;
            this.btnSignUp.Text = "Sign Up";
            this.btnSignUp.UseVisualStyleBackColor = true;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // lblSignUp
            // 
            this.lblSignUp.AutoSize = true;
            this.lblSignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSignUp.Location = new System.Drawing.Point(164, 22);
            this.lblSignUp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSignUp.Name = "lblSignUp";
            this.lblSignUp.Size = new System.Drawing.Size(117, 31);
            this.lblSignUp.TabIndex = 0;
            this.lblSignUp.Text = "Sign Up";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 266);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 16);
            this.label1.TabIndex = 15;
            this.label1.Text = "Confirm Password:";
            // 
            // tbxConfirmPassword
            // 
            this.tbxConfirmPassword.Location = new System.Drawing.Point(148, 260);
            this.tbxConfirmPassword.Margin = new System.Windows.Forms.Padding(4);
            this.tbxConfirmPassword.Name = "tbxConfirmPassword";
            this.tbxConfirmPassword.Size = new System.Drawing.Size(241, 22);
            this.tbxConfirmPassword.TabIndex = 16;
            this.tbxConfirmPassword.UseSystemPasswordChar = true;
            // 
            // frmWelcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1464, 832);
            this.Controls.Add(this.pnlSignUp);
            this.Controls.Add(this.pnlLogIn);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmWelcome";
            this.Text = "Welcome";
            this.Load += new System.EventHandler(this.frmWelcome_Load);
            this.pnlLogIn.ResumeLayout(false);
            this.pnlLogIn.PerformLayout();
            this.pnlSignUp.ResumeLayout(false);
            this.pnlSignUp.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlLogIn;
        private System.Windows.Forms.TextBox txtLogInEmail;
        private System.Windows.Forms.Label lblLogInEmail;
        private System.Windows.Forms.Label lblLogIn;
        private System.Windows.Forms.Panel pnlSignUp;
        private System.Windows.Forms.Label lblSignUp;
        private System.Windows.Forms.Button btnLogIn;
        private System.Windows.Forms.TextBox txtLogInPassword;
        private System.Windows.Forms.Label lblLogInPassword;
        private System.Windows.Forms.Button btnSignUp;
        private System.Windows.Forms.TextBox txtSignUpEmail;
        private System.Windows.Forms.Label lblSignUpEmail;
        private System.Windows.Forms.TextBox txtSignUpSurname;
        private System.Windows.Forms.Label lblSignUpSurname;
        private System.Windows.Forms.TextBox txtSignUpName;
        private System.Windows.Forms.Label lblSignUpName;
        private System.Windows.Forms.TextBox txtSignUpPassword;
        private System.Windows.Forms.Label lblSignUpPassword;
        private System.Windows.Forms.TextBox tbxConfirmPassword;
        private System.Windows.Forms.Label label1;
    }
}