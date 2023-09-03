using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClosedXML.Excel;

namespace FoodOnCampus
{
    public partial class frmAdmin : Form
    {

        string conString = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = |DataDirectory|DBMain.mdf; Integrated Security = True";
        SqlConnection Con;


        string DriverEmail = "";
        public frmAdmin()
        {
            InitializeComponent();
        }

        private void LoadOrderDetails()
        {
            //This method records all the relevant info about all orders:
            int TotalOrders = 0;
            int OrdersPlaced = 0;
            int InProgress = 0;
            int Completed = 0;
            double AverageMoneySpent = 0;
            double TotalMoneySpent = 0;

            try
            {
                using (SqlConnection con = new SqlConnection(conString))
                {
                    con.Open();

                    // Total Orders: Count all rows in the Orders table
                    SqlCommand cmdTotalOrders = new SqlCommand("SELECT COUNT(*) FROM Orders", con);
                    TotalOrders = (int)cmdTotalOrders.ExecuteScalar();

                    // Orders Placed: Count rows with status 'Order Placed'
                    SqlCommand cmdOrdersPlaced = new SqlCommand("SELECT COUNT(*) FROM Orders WHERE Status = 'Order Placed'", con);
                    OrdersPlaced = (int)cmdOrdersPlaced.ExecuteScalar();

                    // In Progress: Count rows with status 'In Progress'
                    SqlCommand cmdInProgress = new SqlCommand("SELECT COUNT(*) FROM Orders WHERE Status = 'In Progress'", con);
                    InProgress = (int)cmdInProgress.ExecuteScalar();

                    // Completed: Count rows with status 'Completed'
                    SqlCommand cmdCompleted = new SqlCommand("SELECT COUNT(*) FROM Orders WHERE Status = 'Complete'", con);
                    Completed = (int)cmdCompleted.ExecuteScalar();

                    // Average Money Spent: Calculate average amount spent in all orders
                    SqlCommand cmdAvgMoneySpent = new SqlCommand("SELECT AVG(Order_Price) FROM Orders", con);
                    AverageMoneySpent = Convert.ToDouble(cmdAvgMoneySpent.ExecuteScalar());

                    // Total Money Spent: Calculate sum of TotalAmount in all orders
                    SqlCommand cmdTotalMoneySpent = new SqlCommand("SELECT SUM(Order_Price) FROM Orders", con);
                    TotalMoneySpent = Convert.ToDouble(cmdTotalMoneySpent.ExecuteScalar());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Reading Orders Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



            //Show data:
            lblTotalOrders.Text = TotalOrders.ToString();
            lblPlaced.Text = OrdersPlaced.ToString();
            lblInProgress.Text = InProgress.ToString();
            lblCompleted.Text = Completed.ToString();
            lblAverageSpent.Text = AverageMoneySpent.ToString("c");
            lblTotalSpent.Text = TotalMoneySpent.ToString("c");

        }

        private void ShowDrivers(string sql)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(conString))
                {
                    con.Open();

                    // Create a SqlDataAdapter to fetch data from the database
                    SqlDataAdapter adapter = new SqlDataAdapter(sql, con);

                    // Create a DataSet to store the data
                    DataSet dataSet = new DataSet();

                    // Fill the DataSet with the data from the database
                    adapter.Fill(dataSet);

                    // Set the DataGridView's data source to the DataSet's first table (assuming there's only one table)
                    dgvDrivers.DataSource = dataSet.Tables[0];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Loading Drivers Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        private void frmAdmin_Load(object sender, EventArgs e)
        {
            LoadOrderDetails();
            ShowDrivers("SELECT User_Name AS Name, User_Surname AS Surname, User_Email AS Email FROM Users WHERE User_Role = 'Driver' ORDER BY User_Name DESC");

            //Button is not enabled until the admin selects a driver
            btnDeleteDriver.Enabled = false;
        }

        private void generateAdminReport()
        {
            try
            {
                // Create a SaveFileDialog to allow the user to choose the file location
                SaveFileDialog saveFileDialog = new SaveFileDialog
                {
                    Filter = "Excel Files|*.xlsx",
                    FileName = "FoodOnCampusReport" + DateTime.Now.ToString("yyyyMMdd") + ".xlsx"
                };

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Define the connection string and SQL query
                    string conString = @"Data Source=(LocalDB)\MSSQLLocalDB; AttachDbFilename=|DataDirectory|DBMain.mdf; Integrated Security=True";
                    string sqlQuery = "SELECT Order_ID as 'Order ID', Customer_ID as 'Customer ID', Driver_ID as 'Driver ID', Restaurant_ID as 'Restaurant ID', Order_Price as 'Order Price (R)', Menu_Items_IDs as 'Menu Items', Date, Status as 'Order Status' FROM Orders";

                    // Create a new SqlConnection and SqlDataAdapter
                    using (SqlConnection con = new SqlConnection(conString))
                    using (SqlDataAdapter adapter = new SqlDataAdapter(sqlQuery, con))
                    {
                        con.Open();

                        // Create a new DataTable to hold the data
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        // Calculate Total Order Price
                        double totalOrderPrice = dt.AsEnumerable().Sum(row => Convert.ToDouble(row["Order Price (R)"]));

                        // Calculate Average Order Total
                        double averageOrderTotal = totalOrderPrice / dt.Rows.Count;


                        // Create a new Excel workbook and worksheet
                        using (var workbook = new XLWorkbook())
                        {
                            var worksheet = workbook.Worksheets.Add("Orders");

                            // Add the data from the DataTable to the worksheet
                            worksheet.Cell(1, 1).InsertTable(dt);

                            // Add Total Order Price and Average Order Total to the worksheet
                            worksheet.Cell(dt.Rows.Count + 3, 2).Value = "Total Order Price (R)";
                            worksheet.Cell(dt.Rows.Count + 3, 3).Value = totalOrderPrice;

                            worksheet.Cell(dt.Rows.Count + 4, 2).Value = "Average Order Total (R)";
                            worksheet.Cell(dt.Rows.Count + 4, 3).Value = averageOrderTotal;

                            // Auto-fit columns and rows to content
                            worksheet.Columns().AdjustToContents();
                            worksheet.Rows().AdjustToContents();

                            // Save the workbook to the user-selected file location
                            workbook.SaveAs(saveFileDialog.FileName);

                            MessageBox.Show("Report exported successfully!", "Export Report", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error exporting the report: " + ex.Message, "Export Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string Name = txtSearch.Text;
            string SQL;
            if (Name.Length > 0)
            {
                SQL = "SELECT User_Name AS Name, User_Surname AS Surname, User_Email AS Email FROM Users WHERE User_Name LIKE '%" + Name + "%' AND User_Role = 'Driver' ORDER BY User_Name DESC";
            }
            else
            {
                SQL = "SELECT User_Name AS Name, User_Surname AS Surname, User_Email AS Email FROM Users WHERE User_Role = 'Driver' ORDER BY User_Name DESC";
            }

            ShowDrivers(SQL);
        }

        private void dgvDrivers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the click event is within the Email column
            if (e.RowIndex >= 0)
            {
                // Get the value from the clicked cell in the "Email" column
                DriverEmail = dgvDrivers.Rows[e.RowIndex].Cells["Email"].Value.ToString();
                btnDeleteDriver.Enabled = true;
            }
            else
            {
                DriverEmail = "";
                btnDeleteDriver.Enabled = false;
            }
        }

        private void btnGenReport_Click(object sender, EventArgs e)
        {
            generateAdminReport();
        }

        private void btnDeleteDriver_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(DriverEmail))
            {
                try
                {
                    using (SqlConnection con = new SqlConnection(conString))
                    {
                        con.Open();

                        // Query to retrieve the user's name and surname for confirmation
                        string selectQuery = "SELECT User_Name, User_Surname FROM Users WHERE User_Email = @Email";

                        // Create a command to execute the query
                        using (SqlCommand selectCommand = new SqlCommand(selectQuery, con))
                        {
                            selectCommand.Parameters.AddWithValue("@Email", DriverEmail);

                            // Execute the query and read the user's name and surname
                            using (SqlDataReader reader = selectCommand.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    string userName = reader["User_Name"].ToString();
                                    string userSurname = reader["User_Surname"].ToString();

                                    // Ask for user confirmation
                                    string confirmationMessage = $"Are you sure you want to delete {userName} {userSurname}?";

                                    DialogResult confirmationResult = MessageBox.Show(confirmationMessage, "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                                    if (confirmationResult == DialogResult.Yes)
                                    {
                                        // Delete the driver record
                                        string deleteQuery = "DELETE FROM Users WHERE User_Email = @Email";

                                        using (SqlCommand deleteCommand = new SqlCommand(deleteQuery, con))
                                        {
                                            deleteCommand.Parameters.AddWithValue("@Email", DriverEmail);
                                            int rowsAffected = deleteCommand.ExecuteNonQuery();

                                            if (rowsAffected > 0)
                                            {
                                                MessageBox.Show("Driver deleted successfully.", "Deletion Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                // Refresh the driver list after deletion if necessary
                                                ShowDrivers("SELECT User_Name AS Name, User_Surname AS Surname, User_Email AS Email FROM Users WHERE User_Role = 'Driver' ORDER BY User_Name DESC");
                                            }
                                            else
                                            {
                                                MessageBox.Show("Driver deletion failed.", "Deletion Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            }
                                        }
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Driver not found.", "Driver Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting driver: " + ex.Message, "Deletion Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select a driver to delete.", "No Driver Selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnAddDriver_Click(object sender, EventArgs e)
        {
            // Opens a new form to add a driver:
            frmAddDriver fAddDriver = new frmAddDriver();
            DialogResult result = fAddDriver.ShowDialog();

            // If the dialog is closed with OK result, refresh the list of drivers
            if (result == DialogResult.OK)
            {
                ShowDrivers("SELECT User_Name AS Name, User_Surname AS Surname, User_Email AS Email FROM Users WHERE User_Role = 'Driver' ORDER BY User_Name DESC");
            }
        }

    }
}
