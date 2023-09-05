namespace FoodOnCampus
{
    partial class frmAdmin
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
            this.lblAdmin = new System.Windows.Forms.Label();
            this.grpOrderInfo = new System.Windows.Forms.GroupBox();
            this.lblTotalSpent = new System.Windows.Forms.Label();
            this.lblAverageSpent = new System.Windows.Forms.Label();
            this.lblShowTotalSpent = new System.Windows.Forms.Label();
            this.lblShowAverage = new System.Windows.Forms.Label();
            this.lblCompleted = new System.Windows.Forms.Label();
            this.lblInProgress = new System.Windows.Forms.Label();
            this.lblPlaced = new System.Windows.Forms.Label();
            this.lblTotalOrders = new System.Windows.Forms.Label();
            this.lblShowCompleted = new System.Windows.Forms.Label();
            this.lblShowInProgress = new System.Windows.Forms.Label();
            this.lblShowPlaced = new System.Windows.Forms.Label();
            this.lblShowTotalOrders = new System.Windows.Forms.Label();
            this.grpDrivers = new System.Windows.Forms.GroupBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.btnDeleteDriver = new System.Windows.Forms.Button();
            this.btnAddDriver = new System.Windows.Forms.Button();
            this.dgvDrivers = new System.Windows.Forms.DataGridView();
            this.btnGenReport = new System.Windows.Forms.Button();
            this.grpOrderInfo.SuspendLayout();
            this.grpDrivers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDrivers)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAdmin
            // 
            this.lblAdmin.AutoSize = true;
            this.lblAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdmin.Location = new System.Drawing.Point(376, 33);
            this.lblAdmin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAdmin.Name = "lblAdmin";
            this.lblAdmin.Size = new System.Drawing.Size(240, 42);
            this.lblAdmin.TabIndex = 0;
            this.lblAdmin.Text = "Admin Panel";
            // 
            // grpOrderInfo
            // 
            this.grpOrderInfo.BackColor = System.Drawing.SystemColors.ControlLight;
            this.grpOrderInfo.Controls.Add(this.lblTotalSpent);
            this.grpOrderInfo.Controls.Add(this.lblAverageSpent);
            this.grpOrderInfo.Controls.Add(this.lblShowTotalSpent);
            this.grpOrderInfo.Controls.Add(this.lblShowAverage);
            this.grpOrderInfo.Controls.Add(this.lblCompleted);
            this.grpOrderInfo.Controls.Add(this.lblInProgress);
            this.grpOrderInfo.Controls.Add(this.lblPlaced);
            this.grpOrderInfo.Controls.Add(this.lblTotalOrders);
            this.grpOrderInfo.Controls.Add(this.lblShowCompleted);
            this.grpOrderInfo.Controls.Add(this.lblShowInProgress);
            this.grpOrderInfo.Controls.Add(this.lblShowPlaced);
            this.grpOrderInfo.Controls.Add(this.lblShowTotalOrders);
            this.grpOrderInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpOrderInfo.Location = new System.Drawing.Point(39, 100);
            this.grpOrderInfo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpOrderInfo.Name = "grpOrderInfo";
            this.grpOrderInfo.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpOrderInfo.Size = new System.Drawing.Size(376, 334);
            this.grpOrderInfo.TabIndex = 1;
            this.grpOrderInfo.TabStop = false;
            this.grpOrderInfo.Text = "Orders Info:";
            // 
            // lblTotalSpent
            // 
            this.lblTotalSpent.AutoSize = true;
            this.lblTotalSpent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalSpent.Location = new System.Drawing.Point(255, 298);
            this.lblTotalSpent.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalSpent.Name = "lblTotalSpent";
            this.lblTotalSpent.Size = new System.Drawing.Size(19, 20);
            this.lblTotalSpent.TabIndex = 11;
            this.lblTotalSpent.Text = "[]";
            // 
            // lblAverageSpent
            // 
            this.lblAverageSpent.AutoSize = true;
            this.lblAverageSpent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAverageSpent.Location = new System.Drawing.Point(255, 262);
            this.lblAverageSpent.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAverageSpent.Name = "lblAverageSpent";
            this.lblAverageSpent.Size = new System.Drawing.Size(19, 20);
            this.lblAverageSpent.TabIndex = 10;
            this.lblAverageSpent.Text = "[]";
            // 
            // lblShowTotalSpent
            // 
            this.lblShowTotalSpent.AutoSize = true;
            this.lblShowTotalSpent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowTotalSpent.Location = new System.Drawing.Point(25, 298);
            this.lblShowTotalSpent.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblShowTotalSpent.Name = "lblShowTotalSpent";
            this.lblShowTotalSpent.Size = new System.Drawing.Size(153, 20);
            this.lblShowTotalSpent.TabIndex = 9;
            this.lblShowTotalSpent.Text = "Total Money Spent:";
            // 
            // lblShowAverage
            // 
            this.lblShowAverage.AutoSize = true;
            this.lblShowAverage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowAverage.Location = new System.Drawing.Point(25, 262);
            this.lblShowAverage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblShowAverage.Name = "lblShowAverage";
            this.lblShowAverage.Size = new System.Drawing.Size(177, 20);
            this.lblShowAverage.TabIndex = 8;
            this.lblShowAverage.Text = "Average Money Spent:";
            // 
            // lblCompleted
            // 
            this.lblCompleted.AutoSize = true;
            this.lblCompleted.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompleted.Location = new System.Drawing.Point(255, 217);
            this.lblCompleted.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCompleted.Name = "lblCompleted";
            this.lblCompleted.Size = new System.Drawing.Size(19, 20);
            this.lblCompleted.TabIndex = 7;
            this.lblCompleted.Text = "[]";
            // 
            // lblInProgress
            // 
            this.lblInProgress.AutoSize = true;
            this.lblInProgress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInProgress.Location = new System.Drawing.Point(255, 166);
            this.lblInProgress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInProgress.Name = "lblInProgress";
            this.lblInProgress.Size = new System.Drawing.Size(19, 20);
            this.lblInProgress.TabIndex = 6;
            this.lblInProgress.Text = "[]";
            // 
            // lblPlaced
            // 
            this.lblPlaced.AutoSize = true;
            this.lblPlaced.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlaced.Location = new System.Drawing.Point(255, 118);
            this.lblPlaced.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPlaced.Name = "lblPlaced";
            this.lblPlaced.Size = new System.Drawing.Size(19, 20);
            this.lblPlaced.TabIndex = 5;
            this.lblPlaced.Text = "[]";
            // 
            // lblTotalOrders
            // 
            this.lblTotalOrders.AutoSize = true;
            this.lblTotalOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalOrders.Location = new System.Drawing.Point(255, 69);
            this.lblTotalOrders.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalOrders.Name = "lblTotalOrders";
            this.lblTotalOrders.Size = new System.Drawing.Size(19, 20);
            this.lblTotalOrders.TabIndex = 4;
            this.lblTotalOrders.Text = "[]";
            // 
            // lblShowCompleted
            // 
            this.lblShowCompleted.AutoSize = true;
            this.lblShowCompleted.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowCompleted.Location = new System.Drawing.Point(25, 217);
            this.lblShowCompleted.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblShowCompleted.Name = "lblShowCompleted";
            this.lblShowCompleted.Size = new System.Drawing.Size(151, 20);
            this.lblShowCompleted.TabIndex = 3;
            this.lblShowCompleted.Text = "Orders Completed:";
            // 
            // lblShowInProgress
            // 
            this.lblShowInProgress.AutoSize = true;
            this.lblShowInProgress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowInProgress.Location = new System.Drawing.Point(25, 166);
            this.lblShowInProgress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblShowInProgress.Name = "lblShowInProgress";
            this.lblShowInProgress.Size = new System.Drawing.Size(157, 20);
            this.lblShowInProgress.TabIndex = 2;
            this.lblShowInProgress.Text = "Orders In Progress:";
            // 
            // lblShowPlaced
            // 
            this.lblShowPlaced.AutoSize = true;
            this.lblShowPlaced.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowPlaced.Location = new System.Drawing.Point(25, 118);
            this.lblShowPlaced.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblShowPlaced.Name = "lblShowPlaced";
            this.lblShowPlaced.Size = new System.Drawing.Size(190, 20);
            this.lblShowPlaced.TabIndex = 1;
            this.lblShowPlaced.Text = "Orders To Be Assigned:";
            // 
            // lblShowTotalOrders
            // 
            this.lblShowTotalOrders.AutoSize = true;
            this.lblShowTotalOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowTotalOrders.Location = new System.Drawing.Point(25, 69);
            this.lblShowTotalOrders.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblShowTotalOrders.Name = "lblShowTotalOrders";
            this.lblShowTotalOrders.Size = new System.Drawing.Size(108, 20);
            this.lblShowTotalOrders.TabIndex = 0;
            this.lblShowTotalOrders.Text = "Total Orders:";
            // 
            // grpDrivers
            // 
            this.grpDrivers.BackColor = System.Drawing.SystemColors.ControlLight;
            this.grpDrivers.Controls.Add(this.txtSearch);
            this.grpDrivers.Controls.Add(this.lblSearch);
            this.grpDrivers.Controls.Add(this.btnDeleteDriver);
            this.grpDrivers.Controls.Add(this.btnAddDriver);
            this.grpDrivers.Controls.Add(this.dgvDrivers);
            this.grpDrivers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDrivers.Location = new System.Drawing.Point(535, 100);
            this.grpDrivers.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpDrivers.Name = "grpDrivers";
            this.grpDrivers.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpDrivers.Size = new System.Drawing.Size(555, 334);
            this.grpDrivers.TabIndex = 2;
            this.grpDrivers.TabStop = false;
            this.grpDrivers.Text = "Drivers Info:";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(167, 31);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(159, 30);
            this.txtSearch.TabIndex = 5;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(8, 38);
            this.lblSearch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(116, 20);
            this.lblSearch.TabIndex = 4;
            this.lblSearch.Text = "Search Name:";
            // 
            // btnDeleteDriver
            // 
            this.btnDeleteDriver.Location = new System.Drawing.Point(399, 273);
            this.btnDeleteDriver.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDeleteDriver.Name = "btnDeleteDriver";
            this.btnDeleteDriver.Size = new System.Drawing.Size(148, 44);
            this.btnDeleteDriver.TabIndex = 3;
            this.btnDeleteDriver.Text = "Delete Driver";
            this.btnDeleteDriver.UseVisualStyleBackColor = true;
            this.btnDeleteDriver.Click += new System.EventHandler(this.btnDeleteDriver_Click);
            // 
            // btnAddDriver
            // 
            this.btnAddDriver.Location = new System.Drawing.Point(8, 273);
            this.btnAddDriver.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddDriver.Name = "btnAddDriver";
            this.btnAddDriver.Size = new System.Drawing.Size(143, 44);
            this.btnAddDriver.TabIndex = 1;
            this.btnAddDriver.Text = "Add Driver";
            this.btnAddDriver.UseVisualStyleBackColor = true;
            this.btnAddDriver.Click += new System.EventHandler(this.btnAddDriver_Click);
            // 
            // dgvDrivers
            // 
            this.dgvDrivers.AllowUserToAddRows = false;
            this.dgvDrivers.AllowUserToDeleteRows = false;
            this.dgvDrivers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvDrivers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDrivers.Location = new System.Drawing.Point(8, 69);
            this.dgvDrivers.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvDrivers.MultiSelect = false;
            this.dgvDrivers.Name = "dgvDrivers";
            this.dgvDrivers.RowHeadersWidth = 51;
            this.dgvDrivers.Size = new System.Drawing.Size(539, 197);
            this.dgvDrivers.TabIndex = 0;
            this.dgvDrivers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDrivers_CellClick);
            // 
            // btnGenReport
            // 
            this.btnGenReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenReport.Location = new System.Drawing.Point(384, 455);
            this.btnGenReport.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGenReport.Name = "btnGenReport";
            this.btnGenReport.Size = new System.Drawing.Size(184, 64);
            this.btnGenReport.TabIndex = 3;
            this.btnGenReport.Text = "Generate Report";
            this.btnGenReport.UseVisualStyleBackColor = true;
            this.btnGenReport.Click += new System.EventHandler(this.btnGenReport_Click);
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1093, 554);
            this.Controls.Add(this.btnGenReport);
            this.Controls.Add(this.grpDrivers);
            this.Controls.Add(this.grpOrderInfo);
            this.Controls.Add(this.lblAdmin);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmAdmin";
            this.Text = "Admin Panel";
            this.Load += new System.EventHandler(this.frmAdmin_Load);
            this.grpOrderInfo.ResumeLayout(false);
            this.grpOrderInfo.PerformLayout();
            this.grpDrivers.ResumeLayout(false);
            this.grpDrivers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDrivers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAdmin;
        private System.Windows.Forms.GroupBox grpOrderInfo;
        private System.Windows.Forms.Label lblShowInProgress;
        private System.Windows.Forms.Label lblShowPlaced;
        private System.Windows.Forms.Label lblShowTotalOrders;
        private System.Windows.Forms.GroupBox grpDrivers;
        private System.Windows.Forms.Button btnGenReport;
        private System.Windows.Forms.Label lblCompleted;
        private System.Windows.Forms.Label lblInProgress;
        private System.Windows.Forms.Label lblPlaced;
        private System.Windows.Forms.Label lblTotalOrders;
        private System.Windows.Forms.Label lblShowCompleted;
        private System.Windows.Forms.Label lblTotalSpent;
        private System.Windows.Forms.Label lblAverageSpent;
        private System.Windows.Forms.Label lblShowTotalSpent;
        private System.Windows.Forms.Label lblShowAverage;
        private System.Windows.Forms.Button btnDeleteDriver;
        private System.Windows.Forms.Button btnAddDriver;
        private System.Windows.Forms.DataGridView dgvDrivers;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSearch;
    }
}