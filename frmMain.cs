﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodOnCampus
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private int User_ID = 0; //The user ID of the currently signed in user

        private void frmMain_Load(object sender, EventArgs e)
        {
            //maximize form
            this.WindowState = FormWindowState.Maximized;

            //btnProfile.left = screen size - btnProfile.width - 20
            btnProfile.Left = this.ClientSize.Width - btnProfile.Width - 20;
            



          ResizeControls();

          hideUserButtons();
        }

        internal void setUserID(int ID)
        {
            //Allow other forms to set the user id
            User_ID = ID;
        }

        private void OpenFormAndCloseOthers(Form form)
        {
            // Close all open child forms
            foreach (Form childForm in this.MdiChildren)
            {
                childForm.Close();
            }

            // Open the specified form
            form.MdiParent = this;

            // Set the visual aspects of the form
            form.FormBorderStyle = FormBorderStyle.None;
            form.StartPosition = FormStartPosition.Manual;
            form.Width = this.Width;
            form.Height = this.Height - pnlNavigate.Height;
            form.Top = pnlNavigate.Height;
            form.Left = 0;

            form.Show();
        }

        private void ResizeControls()
        {
            // Calculate the scaling factor for the form's width and height
            float widthRatio = (float)this.ClientSize.Width / 900; 
            float heightRatio = (float)this.ClientSize.Height / 900; 

            // Iterate through each control on the form
            foreach (Control control in this.Controls)
            {
                // Resize and reposition the control based on the scaling factor
                control.Left = (int)(control.Left * widthRatio);
                control.Top = (int)(control.Top * heightRatio);
                control.Width = (int)(control.Width * widthRatio);
                control.Height = (int)(control.Height * heightRatio);
                control.Font = new Font(control.Font.FontFamily, control.Font.Size * heightRatio, control.Font.Style);
            }

            //Ensure that the panel is always as wide as the screen
            pnlNavigate.Width = this.ClientSize.Width;
        }

        internal void hideUserButtons()
        {
            //Hide certain forms from being accessed if the user in not logged in:
            //Insert relevant buttons that open other forms
            btnProfile.Visible = false;
            btnOrder.Visible = false;
            btnDriverMenu.Visible = false;
            btnAdminPanel.Visible = false;
        }


        private void btnProfile_Click(object sender, EventArgs e)
        {
            if (User_ID == 0)
            {
                MessageBox.Show("User is not signed in", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                this.Close();
            }
            else
            {
                frmProfile profile = new frmProfile(User_ID);
                OpenFormAndCloseOthers(profile);
            }

            
        }

        private void btnWelcome_Click(object sender, EventArgs e)
        {
            //If the user has already logged in:
            if (User_ID > 0)
            {
                hideUserButtons();
                User_ID = 0;
            }
            
            frmWelcome fWelcome = new frmWelcome(this);
            OpenFormAndCloseOthers(fWelcome);
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            if (User_ID == 0)
            {
                MessageBox.Show("User is not signed in", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                this.Close();
            }
            else
            {
                frmOrders fOrders = new frmOrders(User_ID);
                OpenFormAndCloseOthers(fOrders);
            }
            
        }

        private void btnDriverMenu_Click(object sender, EventArgs e)
        {
            if (User_ID == 0)
            {
                MessageBox.Show("User is not signed in", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                this.Close();
            }
            else
            {
                frmDriverMenu fDriverMenu = new frmDriverMenu();
                OpenFormAndCloseOthers(fDriverMenu);
            }
        }

        private void btnAdminPanel_Click(object sender, EventArgs e)
        {
            if (User_ID == 0)
            {
                MessageBox.Show("User is not signed in", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                this.Close();
            }
            else
            {
                frmAdmin fAdmin = new frmAdmin();
                OpenFormAndCloseOthers(fAdmin);
            }
        }

        private void pnlNavigate_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
