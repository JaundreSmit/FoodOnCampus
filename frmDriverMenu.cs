using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodOnCampus
{
    public partial class frmDriverMenu : Form
    {
        public frmDriverMenu()
        {
            InitializeComponent();
        }

        //Variables for database

        string ConString = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = |DataDirectory|DBMain.mdf; Integrated Security = True";

        SqlConnection con;
        SqlCommand com;
        SqlDataAdapter da;
        DataSet ds;

        int Order_ID = 0;
        bool Delivered = false;
        string RestaurantName = "";

        private void frmDriverMenu_Load(object sender, EventArgs e)
        {
            btnDeliverOrder.Enabled = false;
        }

        private void DisplayInProgress()
        {
            btnDeliverOrder.Enabled = true;
            Delivered = true;
            // Only display orders that are "In Progress"
            using (SqlConnection con = new SqlConnection(ConString))
            {
                con.Open();
                using (SqlDataAdapter da = new SqlDataAdapter(
                    "SELECT O.Order_ID AS [Order], O.Driver_ID AS [Driver], DL.Location_Name AS [D Location], " +
                    "R.Restaurant_Name AS [Restaurant], O.Menu_Items_IDs AS [Menu Items] " +
                    "FROM Orders O " +
                    "INNER JOIN Restaurants R ON O.Restaurant_ID = R.Restaurant_ID " +
                    "INNER JOIN DeliveryLocations DL ON O.DP_ID = DL.Location_ID " +
                    "WHERE O.Status = 'In Progress'", con))
                {
                    using (DataSet ds = new DataSet())
                    {
                        da.Fill(ds, "Orders");
                        dgvDriverMenu.DataSource = ds.Tables["Orders"];
                    }
                }
            }
        }

        private void DisplayOrdered()
        {
            btnDeliverOrder.Enabled = true;
            Delivered = false;
            // Show all orders from the Orders table in the datagridview
            using (SqlConnection con = new SqlConnection(ConString))
            {
                con.Open();
                using (SqlDataAdapter da = new SqlDataAdapter(
                    "SELECT O.Order_ID AS [Order], O.Driver_ID AS [Driver], DL.Location_Name AS [D Location], " +
                    "R.Restaurant_Name AS [Restaurant], O.Menu_Items_IDs AS [Menu Items] " +
                    "FROM Orders O " +
                    "INNER JOIN Restaurants R ON O.Restaurant_ID = R.Restaurant_ID " +
                    "INNER JOIN DeliveryLocations DL ON O.DP_ID = DL.Location_ID " +
                    "WHERE O.Status = 'Order Placed'", con))
                {
                    using (DataSet ds = new DataSet())
                    {
                        da.Fill(ds, "Orders");
                        dgvDriverMenu.DataSource = ds.Tables["Orders"];
                    }
                }
            }
        }

        private string GenerateDeliveryLink(int locationID)
        {
            string result = "";

            // Fetch the longitude and latitude from the DeliveryLocations table
            using (SqlConnection con = new SqlConnection(ConString))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT Longitude, Latidue FROM DeliveryLocations WHERE Location_ID = @LocationID", con))
                {
                    cmd.Parameters.AddWithValue("@LocationID", locationID);
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        // Retrieve longitude and latitude values and replace commas with periods
                        double longitude = reader.GetDouble(0);
                        double latitude = reader.GetDouble(1);

                        string formattedLongitude = longitude.ToString(CultureInfo.InvariantCulture);
                        string formattedLatitude = latitude.ToString(CultureInfo.InvariantCulture);

                        // Construct the Google Maps link
                        result = $"https://www.google.com/maps?q={formattedLatitude},{formattedLongitude}";
                    }
                    reader.Close();
                }
            }

            return result;
        }


        private string GetMenuItems(int orderID)
        {
            List<string> descriptions = new List<string>();

            using (SqlConnection con = new SqlConnection(ConString))
            {
                con.Open();

                string sql = "SELECT Menu_Items_IDs FROM Orders WHERE Order_ID = @OrderID";

                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@OrderID", orderID);
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        string sIDs = reader["Menu_Items_IDs"].ToString();
                        string[] IDs = sIDs.Split(',');
                        reader.Close();
                        foreach (string id in IDs)
                        {
                            if (int.TryParse(id, out int menuID))
                            {
                                string menuSql = "SELECT Item_Desc FROM MenuItems WHERE Menu_ID = @MenuID";

                                using (SqlCommand menuCmd = new SqlCommand(menuSql, con))
                                {
                                    menuCmd.Parameters.AddWithValue("@MenuID", menuID);
                                    SqlDataReader menuReader = menuCmd.ExecuteReader();

                                    if (menuReader.Read())
                                    {
                                        descriptions.Add(menuReader["Item_Desc"].ToString());
                                    }

                                    menuReader.Close();
                                }
                            }
                        }
                    }

                    reader.Close();
                }
            }

            return string.Join("\n", descriptions);
        }

        private void btnShowInProgress_Click(object sender, EventArgs e)
        {
            DisplayInProgress();
        }



        private void btnShowAllAvailable_Click(object sender, EventArgs e)
        {
            DisplayOrdered();
        }


        private void dgvDriverMenu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if a valid row is clicked
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Get the OrderID from the selected row
                int orderID = Convert.ToInt32(dgvDriverMenu.Rows[e.RowIndex].Cells["Order"].Value);

                // Retrieve the restaurant name from the cell
                RestaurantName = dgvDriverMenu.Rows[e.RowIndex].Cells["Restaurant"].Value.ToString();

                Order_ID = orderID;
                btnDeliverOrder.Enabled = true;
            }
        }


        private void btnDeliverOrder_Click(object sender, EventArgs e)
        {
            string SQL = "";
            string result = "";
            if (Order_ID != 0)
            {
                if (Delivered == true)
                {
                    // If the driver is done delivering food:
                    SQL = "UPDATE Orders SET Status = 'Complete' WHERE Order_ID = @OrderID";
                    result = "completed.";
                }
                else
                {
                    // If the driver is accepting the delivery:
                    SQL = "UPDATE Orders SET Status = 'In Progress' WHERE Order_ID = @OrderID";
                    result = "being delivered.";
                }

                // Update the database
                using (SqlConnection con = new SqlConnection(ConString))
                {
                    con.Open();
                    using (SqlCommand com = new SqlCommand(SQL, con))
                    {
                        com.Parameters.AddWithValue("@OrderID", Order_ID);
                        com.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Order " + Order_ID.ToString() + " is now " + result);

                // Refresh the DataGridView or update the UI as needed
                if (Delivered == true)
                {
                    DisplayInProgress();
                }
                else
                {
                    DisplayOrdered();

                    // Generate the delivery information
                    string deliveryInfo = "Restaurant:\n" + RestaurantName + "\n\nMenu Items:\n" + GetMenuItems(Order_ID) +
                                          "\n\nDelivery order to:\n" + GenerateDeliveryLink(Order_ID);

                    // Create a SaveFileDialog to let the user choose where to save the text file
                    using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                    {
                        saveFileDialog.Filter = "Text Files (*.txt)|*.txt";
                        saveFileDialog.Title = "Save Delivery Info";
                        saveFileDialog.FileName = "Order" + Order_ID.ToString() + ".txt";

                        if (saveFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            // Save the delivery information to the selected file
                            string fileName = saveFileDialog.FileName;
                            System.IO.File.WriteAllText(fileName, deliveryInfo);

                            MessageBox.Show("Delivery info has been saved to " + fileName, "Delivery Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Select an order first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
