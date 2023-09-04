namespace FoodOnCampus
{
    partial class frmOrders
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
            this.lstOutput = new System.Windows.Forms.ListBox();
            this.cbRestaurants = new System.Windows.Forms.ComboBox();
            this.cbMenuItems = new System.Windows.Forms.ComboBox();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.lblMenuItem = new System.Windows.Forms.Label();
            this.lblRestaurant = new System.Windows.Forms.Label();
            this.grpOrdering = new System.Windows.Forms.GroupBox();
            this.lblDeliveryPoints = new System.Windows.Forms.Label();
            this.cbDeliveryPoints = new System.Windows.Forms.ComboBox();
            this.lblOrderTotal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.grpOrdering.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstOutput
            // 
            this.lstOutput.FormattingEnabled = true;
            this.lstOutput.Location = new System.Drawing.Point(231, 165);
            this.lstOutput.Name = "lstOutput";
            this.lstOutput.Size = new System.Drawing.Size(263, 277);
            this.lstOutput.TabIndex = 10;
            // 
            // cbRestaurants
            // 
            this.cbRestaurants.FormattingEnabled = true;
            this.cbRestaurants.Location = new System.Drawing.Point(81, 31);
            this.cbRestaurants.Name = "cbRestaurants";
            this.cbRestaurants.Size = new System.Drawing.Size(121, 21);
            this.cbRestaurants.TabIndex = 0;
            this.cbRestaurants.SelectedIndexChanged += new System.EventHandler(this.cbRestaurants_SelectedIndexChanged);
            // 
            // cbMenuItems
            // 
            this.cbMenuItems.FormattingEnabled = true;
            this.cbMenuItems.Location = new System.Drawing.Point(81, 86);
            this.cbMenuItems.Name = "cbMenuItems";
            this.cbMenuItems.Size = new System.Drawing.Size(121, 21);
            this.cbMenuItems.TabIndex = 1;
            // 
            // pbLogo
            // 
            this.pbLogo.Image = global::FoodOnCampus.Properties.Resources.OrderHere;
            this.pbLogo.Location = new System.Drawing.Point(12, 12);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(482, 136);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 9;
            this.pbLogo.TabStop = false;
            // 
            // btnOrder
            // 
            this.btnOrder.Location = new System.Drawing.Point(127, 249);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(75, 23);
            this.btnOrder.TabIndex = 4;
            this.btnOrder.Text = "Order";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // btnAddItem
            // 
            this.btnAddItem.Location = new System.Drawing.Point(6, 249);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(75, 23);
            this.btnAddItem.TabIndex = 5;
            this.btnAddItem.Text = "Add Item";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // lblMenuItem
            // 
            this.lblMenuItem.AutoSize = true;
            this.lblMenuItem.Location = new System.Drawing.Point(13, 89);
            this.lblMenuItem.Name = "lblMenuItem";
            this.lblMenuItem.Size = new System.Drawing.Size(60, 13);
            this.lblMenuItem.TabIndex = 7;
            this.lblMenuItem.Text = "Menu Item:";
            // 
            // lblRestaurant
            // 
            this.lblRestaurant.AutoSize = true;
            this.lblRestaurant.Location = new System.Drawing.Point(13, 34);
            this.lblRestaurant.Name = "lblRestaurant";
            this.lblRestaurant.Size = new System.Drawing.Size(62, 13);
            this.lblRestaurant.TabIndex = 6;
            this.lblRestaurant.Text = "Restaurant:";
            // 
            // grpOrdering
            // 
            this.grpOrdering.Controls.Add(this.lblDeliveryPoints);
            this.grpOrdering.Controls.Add(this.cbDeliveryPoints);
            this.grpOrdering.Controls.Add(this.cbRestaurants);
            this.grpOrdering.Controls.Add(this.btnOrder);
            this.grpOrdering.Controls.Add(this.btnAddItem);
            this.grpOrdering.Controls.Add(this.lblMenuItem);
            this.grpOrdering.Controls.Add(this.cbMenuItems);
            this.grpOrdering.Controls.Add(this.lblRestaurant);
            this.grpOrdering.Location = new System.Drawing.Point(12, 165);
            this.grpOrdering.Name = "grpOrdering";
            this.grpOrdering.Size = new System.Drawing.Size(213, 278);
            this.grpOrdering.TabIndex = 11;
            this.grpOrdering.TabStop = false;
            this.grpOrdering.Text = "Ordering";
            // 
            // lblDeliveryPoints
            // 
            this.lblDeliveryPoints.AutoSize = true;
            this.lblDeliveryPoints.Location = new System.Drawing.Point(6, 146);
            this.lblDeliveryPoints.Name = "lblDeliveryPoints";
            this.lblDeliveryPoints.Size = new System.Drawing.Size(75, 13);
            this.lblDeliveryPoints.TabIndex = 9;
            this.lblDeliveryPoints.Text = "Delivery Point:";
            // 
            // cbDeliveryPoints
            // 
            this.cbDeliveryPoints.FormattingEnabled = true;
            this.cbDeliveryPoints.Location = new System.Drawing.Point(81, 143);
            this.cbDeliveryPoints.Name = "cbDeliveryPoints";
            this.cbDeliveryPoints.Size = new System.Drawing.Size(121, 21);
            this.cbDeliveryPoints.TabIndex = 8;
            this.cbDeliveryPoints.SelectedIndexChanged += new System.EventHandler(this.cbDeliveryPoints_SelectedIndexChanged);
            // 
            // lblOrderTotal
            // 
            this.lblOrderTotal.AutoSize = true;
            this.lblOrderTotal.Location = new System.Drawing.Point(390, 445);
            this.lblOrderTotal.Name = "lblOrderTotal";
            this.lblOrderTotal.Size = new System.Drawing.Size(60, 13);
            this.lblOrderTotal.TabIndex = 12;
            this.lblOrderTotal.Text = "Order Total";
            // 
            // frmOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 480);
            this.Controls.Add(this.lblOrderTotal);
            this.Controls.Add(this.lstOutput);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.grpOrdering);
            this.Name = "frmOrders";
            this.Text = "frmOrders";
            this.Load += new System.EventHandler(this.frmOrders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.grpOrdering.ResumeLayout(false);
            this.grpOrdering.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstOutput;
        private System.Windows.Forms.ComboBox cbRestaurants;
        private System.Windows.Forms.ComboBox cbMenuItems;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.Label lblMenuItem;
        private System.Windows.Forms.Label lblRestaurant;
        private System.Windows.Forms.GroupBox grpOrdering;
        private System.Windows.Forms.Label lblDeliveryPoints;
        private System.Windows.Forms.ComboBox cbDeliveryPoints;
        private System.Windows.Forms.Label lblOrderTotal;
    }
}