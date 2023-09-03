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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FoodOnCampus
{
    public partial class frmOrders : Form
    {
        private int Customer_ID;
        private int DP_ID;
        private int Restaurant_ID;
        private decimal Order_Price = 0;
        private string Menu_Items_IDs;
        private DateTime Date;
        private string Status = "Incomplete";

        private SqlDataReader dataReader;
        private SqlConnection con;
        private SqlCommand comm;
        private string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|DBMain.mdf;Integrated Security=True";

        private int tempID;
        private string SQL;
        private string Order;

        public frmOrders(int User_ID)
        {
            InitializeComponent();

            //set customer ID:
            Customer_ID = User_ID;
        }

        private void frmOrders_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(connectionString);
            con.Open(); // Open the connection here
            ComboUpdate(cbRestaurants, "SELECT * FROM Restaurants", "Restaurant_Name");
            ComboUpdate(cbDeliveryPoints, "SELECT * FROM DeliveryLocations", "Location_Name");
            con.Close(); // Close the connection after use

            //Hide order total label until an order is being placed:
            lblOrderTotal.Visible = false;
        }

        public void ComboUpdate(System.Windows.Forms.ComboBox comboBox, string SQL, string columnName)
        {
            comboBox.Items.Clear();
            comm = new SqlCommand(SQL, con);
            dataReader = comm.ExecuteReader();

            while (dataReader.Read())
            {
                comboBox.Items.Add(dataReader[columnName].ToString());
            }

            dataReader.Close();
        }

        public void ProcessPayment()
        {
            //TODO
            //This method must send an email to the driver details about the order
            //Also should direct user to a payment screen
            //No formal payment functionality is required, maybe just a mock screen?

            frmPayment frmPayment = new frmPayment();
            frmPayment.Data = Order_Price;
            frmPayment.ShowDialog();

            if (frmPayment.Payed)
            {

            }

        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(cbRestaurants.Text) || string.IsNullOrEmpty(cbMenuItems.Text) || string.IsNullOrEmpty(cbDeliveryPoints.Text))
                {
                    MessageBox.Show("Please fill all the necessary requirements", "Error");
                }
                else
                {
                    Date = DateTime.Now;
                    SQL = "INSERT INTO Orders(Customer_ID,Driver_ID, DP_ID, Restaurant_ID, Order_Price, Menu_Items_IDs, Date, Status) " +
                          "VALUES(@Customer_ID,@Driver_ID, @DP_ID, @Restaurant_ID, @Order_Price, @Menu_Items_IDs, @Date, @Status)";

                    if (con.State == ConnectionState.Open)
                    {
                        con.Close();
                    }
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(SQL, con))
                    {
                        cmd.Parameters.AddWithValue("@Customer_ID", Customer_ID);
                        cmd.Parameters.AddWithValue("@Driver_ID", 2);
                        cmd.Parameters.AddWithValue("@DP_ID", DP_ID);
                        cmd.Parameters.AddWithValue("@Restaurant_ID", Restaurant_ID);
                        cmd.Parameters.AddWithValue("@Order_Price", Order_Price);
                        cmd.Parameters.AddWithValue("@Menu_Items_IDs", Menu_Items_IDs);
                        cmd.Parameters.AddWithValue("@Date", Date);
                        cmd.Parameters.AddWithValue("@Status", "Order Placed");
                        cmd.ExecuteNonQuery();
                    }
                    con.Close();

                    // Ask the user to confirm the order
                    string confirmationMessage = $"Order Details:\n\n" +
                        $"Restaurant: {cbRestaurants.Text}\n" +
                        $"Total Price: " + Order_Price.ToString("c") +"\n" +
                        $"Delivery Point: {cbDeliveryPoints.Text}\n" +
                        $"Date: {Date}\n\n" +
                        "Do you want to confirm this order?";

                    DialogResult confirmationResult = MessageBox.Show(confirmationMessage, "Order Confirmation", MessageBoxButtons.YesNo);

                    if (confirmationResult == DialogResult.Yes)
                    {
                        // User confirmed the order, process the payment
                        ProcessPayment();
                        //Clear the order:
                        lstOutput.Items.Clear();
                        cbRestaurants.Enabled = true;
                        cbDeliveryPoints.SelectedIndex = -1;
                        cbRestaurants.SelectedIndex = -1;
                        cbMenuItems.SelectedIndex = -1;
                    }
                   

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error");
            }
        }

        private void cbRestaurants_SelectedIndexChanged(object sender, EventArgs e)
        {
            //When a restaurant is selected, its matching menu items are retrieved from RestaurantMenu table
            //Then each menu item id from the restaurant is stored in an array
            //The array is then used to add each item to the combo box
            try
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }

                con.Open();

                // Get the selected restaurant's Menu_ID
                tempID = cbRestaurants.SelectedIndex;
                Restaurant_ID = tempID + 1;
                

                SQL = "SELECT Menu_ID FROM RestaurantMenu WHERE Restaurant_ID = " + Restaurant_ID;
                comm = new SqlCommand(SQL, con);
                dataReader = comm.ExecuteReader();

                int[] MenuIDs = new int[50];
                int iCounter = 0;
                while (dataReader.Read())
                {
                    int menuID = dataReader.GetInt32(0);
                    MenuIDs[iCounter++] = menuID;
                    
                }
                dataReader.Close();


                cbMenuItems.Items.Clear();
                //Add each item to combobox: 
                for (int i = 0; i < iCounter; i++)
                {
                    SqlCommand cmd = new SqlCommand("SELECT Item_Desc FROM MenuItems WHERE Menu_ID = " + MenuIDs[i], con);
                    dataReader = cmd.ExecuteReader();

                    if (dataReader.HasRows) // Check if there are rows to read
                    {
                        while (dataReader.Read()) // Iterate through the rows
                        {
                            cbMenuItems.Items.Add(dataReader.GetString(0));
                        }
                    }

                    dataReader.Close();
                }




                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error");
            }
        }



        private void btnAddItem_Click(object sender, EventArgs e)
        {
            try
            {

                if (cbMenuItems.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select a menu item to order.", "Error");
                }
                else
                {
                    if (con.State == ConnectionState.Open)
                    {
                        con.Close();
                    }

                    SQL = "SELECT * FROM MenuItems WHERE Item_Desc = @ItemDesc";
                    con.Open();
                    comm = new SqlCommand(SQL, con);
                    comm.Parameters.AddWithValue("@ItemDesc", cbMenuItems.Text);
                    dataReader = comm.ExecuteReader();
                   
                    if (dataReader.Read())
                    {
                       
                        Order_Price += dataReader.GetDecimal(2);
                        Menu_Items_IDs += "/" + dataReader.GetInt32(0).ToString();

                        string Order = cbMenuItems.Text + ": \t " + dataReader.GetDecimal(2).ToString("c");
                        lstOutput.Items.Add(Order);
                        lblOrderTotal.Visible = true;
                        lblOrderTotal.Text = "Order Total: " + Order_Price.ToString("c");
                        cbRestaurants.Enabled = false; 
                    }
                    dataReader.Close();
                    con.Close();
                }
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message, "Error");
            }
        }

        private void cbDeliveryPoints_SelectedIndexChanged(object sender, EventArgs e)
        {
            DP_ID = cbDeliveryPoints.SelectedIndex + 1;
        }
    }
}
