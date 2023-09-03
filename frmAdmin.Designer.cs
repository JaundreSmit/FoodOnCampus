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
            this.grpDrivers = new System.Windows.Forms.GroupBox();
            this.btnGenReport = new System.Windows.Forms.Button();
            this.lblShowTotalOrders = new System.Windows.Forms.Label();
            this.lblShowPlaced = new System.Windows.Forms.Label();
            this.lblShowInProgress = new System.Windows.Forms.Label();
            this.lblShowCompleted = new System.Windows.Forms.Label();
            this.lblTotalOrders = new System.Windows.Forms.Label();
            this.lblPlaced = new System.Windows.Forms.Label();
            this.lblInProgress = new System.Windows.Forms.Label();
            this.lblCompleted = new System.Windows.Forms.Label();
            this.lblShowAverage = new System.Windows.Forms.Label();
            this.lblShowTotalSpent = new System.Windows.Forms.Label();
            this.lblAverageSpent = new System.Windows.Forms.Label();
            this.lblTotalSpent = new System.Windows.Forms.Label();
            this.dgvDrivers = new System.Windows.Forms.DataGridView();
            this.btnAddDriver = new System.Windows.Forms.Button();
            this.btnDeleteDriver = new System.Windows.Forms.Button();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.grpOrderInfo.SuspendLayout();
            this.grpDrivers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDrivers)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAdmin
            // 
            this.lblAdmin.AutoSize = true;
            this.lblAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdmin.Location = new System.Drawing.Point(282, 27);
            this.lblAdmin.Name = "lblAdmin";
            this.lblAdmin.Size = new System.Drawing.Size(191, 33);
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
            this.grpOrderInfo.Location = new System.Drawing.Point(29, 81);
            this.grpOrderInfo.Name = "grpOrderInfo";
            this.grpOrderInfo.Size = new System.Drawing.Size(282, 271);
            this.grpOrderInfo.TabIndex = 1;
            this.grpOrderInfo.TabStop = false;
            this.grpOrderInfo.Text = "Orders Info:";
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
            this.grpDrivers.Location = new System.Drawing.Point(401, 81);
            this.grpDrivers.Name = "grpDrivers";
            this.grpDrivers.Size = new System.Drawing.Size(416, 271);
            this.grpDrivers.TabIndex = 2;
            this.grpDrivers.TabStop = false;
            this.grpDrivers.Text = "Drivers Info:";
            // 
            // btnGenReport
            // 
            this.btnGenReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenReport.Location = new System.Drawing.Point(288, 370);
            this.btnGenReport.Name = "btnGenReport";
            this.btnGenReport.Size = new System.Drawing.Size(138, 52);
            this.btnGenReport.TabIndex = 3;
            this.btnGenReport.Text = "Generate Report";
            this.btnGenReport.UseVisualStyleBackColor = true;
            this.btnGenReport.Click += new System.EventHandler(this.btnGenReport_Click);
            // 
            // lblShowTotalOrders
            // 
            this.lblShowTotalOrders.AutoSize = true;
            this.lblShowTotalOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowTotalOrders.Location = new System.Drawing.Point(19, 56);
            this.lblShowTotalOrders.Name = "lblShowTotalOrders";
            this.lblShowTotalOrders.Size = new System.Drawing.Size(85, 16);
            this.lblShowTotalOrders.TabIndex = 0;
            this.lblShowTotalOrders.Text = "Total Orders:";
            // 
            // lblShowPlaced
            // 
            this.lblShowPlaced.AutoSize = true;
            this.lblShowPlaced.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowPlaced.Location = new System.Drawing.Point(19, 96);
            this.lblShowPlaced.Name = "lblShowPlaced";
            this.lblShowPlaced.Size = new System.Drawing.Size(151, 16);
            this.lblShowPlaced.TabIndex = 1;
            this.lblShowPlaced.Text = "Orders To Be Assigned:";
            // 
            // lblShowInProgress
            // 
            this.lblShowInProgress.AutoSize = true;
            this.lblShowInProgress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowInProgress.Location = new System.Drawing.Point(19, 135);
            this.lblShowInProgress.Name = "lblShowInProgress";
            this.lblShowInProgress.Size = new System.Drawing.Size(122, 16);
            this.lblShowInProgress.TabIndex = 2;
            this.lblShowInProgress.Text = "Orders In Progress:";
            // 
            // lblShowCompleted
            // 
            this.lblShowCompleted.AutoSize = true;
            this.lblShowCompleted.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowCompleted.Location = new System.Drawing.Point(19, 176);
            this.lblShowCompleted.Name = "lblShowCompleted";
            this.lblShowCompleted.Size = new System.Drawing.Size(120, 16);
            this.lblShowCompleted.TabIndex = 3;
            this.lblShowCompleted.Text = "Orders Completed:";
            // 
            // lblTotalOrders
            // 
            this.lblTotalOrders.AutoSize = true;
            this.lblTotalOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalOrders.Location = new System.Drawing.Point(191, 56);
            this.lblTotalOrders.Name = "lblTotalOrders";
            this.lblTotalOrders.Size = new System.Drawing.Size(15, 16);
            this.lblTotalOrders.TabIndex = 4;
            this.lblTotalOrders.Text = "[]";
            // 
            // lblPlaced
            // 
            this.lblPlaced.AutoSize = true;
            this.lblPlaced.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlaced.Location = new System.Drawing.Point(191, 96);
            this.lblPlaced.Name = "lblPlaced";
            this.lblPlaced.Size = new System.Drawing.Size(15, 16);
            this.lblPlaced.TabIndex = 5;
            this.lblPlaced.Text = "[]";
            // 
            // lblInProgress
            // 
            this.lblInProgress.AutoSize = true;
            this.lblInProgress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInProgress.Location = new System.Drawing.Point(191, 135);
            this.lblInProgress.Name = "lblInProgress";
            this.lblInProgress.Size = new System.Drawing.Size(15, 16);
            this.lblInProgress.TabIndex = 6;
            this.lblInProgress.Text = "[]";
            // 
            // lblCompleted
            // 
            this.lblCompleted.AutoSize = true;
            this.lblCompleted.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompleted.Location = new System.Drawing.Point(191, 176);
            this.lblCompleted.Name = "lblCompleted";
            this.lblCompleted.Size = new System.Drawing.Size(15, 16);
            this.lblCompleted.TabIndex = 7;
            this.lblCompleted.Text = "[]";
            // 
            // lblShowAverage
            // 
            this.lblShowAverage.AutoSize = true;
            this.lblShowAverage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowAverage.Location = new System.Drawing.Point(19, 213);
            this.lblShowAverage.Name = "lblShowAverage";
            this.lblShowAverage.Size = new System.Drawing.Size(144, 16);
            this.lblShowAverage.TabIndex = 8;
            this.lblShowAverage.Text = "Average Money Spent:";
            // 
            // lblShowTotalSpent
            // 
            this.lblShowTotalSpent.AutoSize = true;
            this.lblShowTotalSpent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowTotalSpent.Location = new System.Drawing.Point(19, 242);
            this.lblShowTotalSpent.Name = "lblShowTotalSpent";
            this.lblShowTotalSpent.Size = new System.Drawing.Size(123, 16);
            this.lblShowTotalSpent.TabIndex = 9;
            this.lblShowTotalSpent.Text = "Total Money Spent:";
            // 
            // lblAverageSpent
            // 
            this.lblAverageSpent.AutoSize = true;
            this.lblAverageSpent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAverageSpent.Location = new System.Drawing.Point(191, 213);
            this.lblAverageSpent.Name = "lblAverageSpent";
            this.lblAverageSpent.Size = new System.Drawing.Size(15, 16);
            this.lblAverageSpent.TabIndex = 10;
            this.lblAverageSpent.Text = "[]";
            // 
            // lblTotalSpent
            // 
            this.lblTotalSpent.AutoSize = true;
            this.lblTotalSpent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalSpent.Location = new System.Drawing.Point(191, 242);
            this.lblTotalSpent.Name = "lblTotalSpent";
            this.lblTotalSpent.Size = new System.Drawing.Size(15, 16);
            this.lblTotalSpent.TabIndex = 11;
            this.lblTotalSpent.Text = "[]";
            // 
            // dgvDrivers
            // 
            this.dgvDrivers.AllowUserToAddRows = false;
            this.dgvDrivers.AllowUserToDeleteRows = false;
            this.dgvDrivers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvDrivers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDrivers.Location = new System.Drawing.Point(6, 56);
            this.dgvDrivers.MultiSelect = false;
            this.dgvDrivers.Name = "dgvDrivers";
            this.dgvDrivers.Size = new System.Drawing.Size(404, 160);
            this.dgvDrivers.TabIndex = 0;
            this.dgvDrivers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDrivers_CellClick);
            // 
            // btnAddDriver
            // 
            this.btnAddDriver.Location = new System.Drawing.Point(6, 222);
            this.btnAddDriver.Name = "btnAddDriver";
            this.btnAddDriver.Size = new System.Drawing.Size(107, 36);
            this.btnAddDriver.TabIndex = 1;
            this.btnAddDriver.Text = "Add Driver";
            this.btnAddDriver.UseVisualStyleBackColor = true;
            this.btnAddDriver.Click += new System.EventHandler(this.btnAddDriver_Click);
            // 
            // btnDeleteDriver
            // 
            this.btnDeleteDriver.Location = new System.Drawing.Point(299, 222);
            this.btnDeleteDriver.Name = "btnDeleteDriver";
            this.btnDeleteDriver.Size = new System.Drawing.Size(111, 36);
            this.btnDeleteDriver.TabIndex = 3;
            this.btnDeleteDriver.Text = "Delete Driver";
            this.btnDeleteDriver.UseVisualStyleBackColor = true;
            this.btnDeleteDriver.Click += new System.EventHandler(this.btnDeleteDriver_Click);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(6, 31);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(93, 16);
            this.lblSearch.TabIndex = 4;
            this.lblSearch.Text = "Search Name:";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(125, 25);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(120, 26);
            this.txtSearch.TabIndex = 5;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 450);
            this.Controls.Add(this.btnGenReport);
            this.Controls.Add(this.grpDrivers);
            this.Controls.Add(this.grpOrderInfo);
            this.Controls.Add(this.lblAdmin);
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