namespace FoodOnCampus
{
    partial class frmDriverMenu
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
            this.btnDeliverOrder = new System.Windows.Forms.Button();
            this.btnShowAllAvailable = new System.Windows.Forms.Button();
            this.btnShowInProgress = new System.Windows.Forms.Button();
            this.dgvDriverMenu = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDriverMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDeliverOrder
            // 
            this.btnDeliverOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeliverOrder.Location = new System.Drawing.Point(346, 11);
            this.btnDeliverOrder.Name = "btnDeliverOrder";
            this.btnDeliverOrder.Size = new System.Drawing.Size(107, 35);
            this.btnDeliverOrder.TabIndex = 11;
            this.btnDeliverOrder.Text = "Update Order";
            this.btnDeliverOrder.UseVisualStyleBackColor = true;
            this.btnDeliverOrder.Click += new System.EventHandler(this.btnDeliverOrder_Click);
            // 
            // btnShowAllAvailable
            // 
            this.btnShowAllAvailable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowAllAvailable.Location = new System.Drawing.Point(11, 11);
            this.btnShowAllAvailable.Margin = new System.Windows.Forms.Padding(2);
            this.btnShowAllAvailable.Name = "btnShowAllAvailable";
            this.btnShowAllAvailable.Size = new System.Drawing.Size(156, 36);
            this.btnShowAllAvailable.TabIndex = 10;
            this.btnShowAllAvailable.Text = "Show Available Orders";
            this.btnShowAllAvailable.UseVisualStyleBackColor = true;
            this.btnShowAllAvailable.Click += new System.EventHandler(this.btnShowAllAvailable_Click);
            // 
            // btnShowInProgress
            // 
            this.btnShowInProgress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowInProgress.Location = new System.Drawing.Point(189, 11);
            this.btnShowInProgress.Margin = new System.Windows.Forms.Padding(2);
            this.btnShowInProgress.Name = "btnShowInProgress";
            this.btnShowInProgress.Size = new System.Drawing.Size(137, 36);
            this.btnShowInProgress.TabIndex = 9;
            this.btnShowInProgress.Text = "In Progress Orders";
            this.btnShowInProgress.UseVisualStyleBackColor = true;
            this.btnShowInProgress.Click += new System.EventHandler(this.btnShowInProgress_Click);
            // 
            // dgvDriverMenu
            // 
            this.dgvDriverMenu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvDriverMenu.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvDriverMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDriverMenu.Location = new System.Drawing.Point(11, 51);
            this.dgvDriverMenu.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDriverMenu.Name = "dgvDriverMenu";
            this.dgvDriverMenu.RowHeadersWidth = 51;
            this.dgvDriverMenu.RowTemplate.Height = 24;
            this.dgvDriverMenu.Size = new System.Drawing.Size(648, 223);
            this.dgvDriverMenu.TabIndex = 8;
            this.dgvDriverMenu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDriverMenu_CellContentClick);
            // 
            // frmDriverMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDeliverOrder);
            this.Controls.Add(this.btnShowAllAvailable);
            this.Controls.Add(this.btnShowInProgress);
            this.Controls.Add(this.dgvDriverMenu);
            this.Name = "frmDriverMenu";
            this.Text = "Driver Menu";
            this.Load += new System.EventHandler(this.frmDriverMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDriverMenu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDeliverOrder;
        private System.Windows.Forms.Button btnShowAllAvailable;
        private System.Windows.Forms.Button btnShowInProgress;
        private System.Windows.Forms.DataGridView dgvDriverMenu;
    }
}