using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FoodOnCampus
{
    public partial class OrderForm : Form
    {
        //ORDER VARIABLES
        //Needs to be set at form creation. No way to get from here
        public int Customer_ID;
        //set in form
        public int DP_ID;
        public int Restaurant_ID;
        public float Order_Price = 0;
        public String Menu_Items_IDs;
        public DateTime Date;
        public String Status = "Incomplete";

        //SQL VARIABLES
        public SqlDataReader dataReader;
        public SqlConnection con;
        public SqlCommand comm;
        public String connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename= |DataDirectory|DBMain.mdf;Integrated Security=True";

        //Switchable temp Variables
        private int tempID;
        private String SQL;
        private String Order;


        public OrderForm()
        {
            InitializeComponent();
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            //When the form is loaded it connects to the database and refreshes the combobox for the restaurants and the delivery Points
            con = new SqlConnection(connectionString);
            ComboUpdate(comboBox1,"SELECT * FROM Restaurants",1);
            ComboUpdate(comboBox3, "SELECT * FROM DeliveryLocations", 1);
        }

        public void ComboUpdate(ComboBox combobox, String SQL, int index)
        {
            //Used to update the comboboxes
            combobox.Items.Clear();
            comm = new SqlCommand(SQL,con);
            dataReader = comm.ExecuteReader();

            while(dataReader.Read())
            {
                combobox.Items.Add(dataReader.GetString(index));
            }
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //When the selected restaurant changes it takes the position in the index as the ID;
            tempID = comboBox1.SelectedIndex;
            Restaurant_ID = tempID;
            //And gets the menu ID for that restaurant
            SQL = "SELECT Menu_ID FROM RestaurantMenu WHERE Restaurant_ID = " + tempID;
            comm = new SqlCommand(SQL, con);
            dataReader = comm.ExecuteReader();
            tempID = dataReader.GetInt32(0);

            SQL = "SELECT Item_Desc FROM MenuItems WHERE Menu_ID = " + tempID;
            //The Refreshes the Menu Items Combobox with the correct items.
            ComboUpdate(comboBox2,SQL,0);
        }

        private void button2_Click(object sender, EventArgs e)
        {

            //This is the add to order button
            try
            {
                if(comboBox2.SelectedText == "")
                {
                    //It checks if the text is selected
                    MessageBox.Show("Please select a menu item to order.", "Error");
                }
                else
                {
                    // Then finds the items price and adds it to the order with the ID.
                    SQL = "SELECT * FROM MenuItems WHERE Item_Desc == '" + comboBox2.Text +"'";
                    comm = new SqlCommand(SQL, con);
                    dataReader = comm.ExecuteReader();
                    Order_Price = Order_Price + dataReader.GetFloat(2);
                    Menu_Items_IDs = Menu_Items_IDs + "/" + dataReader.GetString(0);


                    Order = comboBox2.Text + ": \t R" + dataReader.GetFloat(0);
                    listBox1.Items.Add(Order);
                    comboBox1.Enabled= false;
                }
            }
            catch(SqlException error)
            {
                MessageBox.Show(error.Message, "Error");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if(comboBox1.Text == "" || comboBox2.Text == ""|| comboBox3.Text == "")
                {
                    MessageBox.Show("Please fill all the necesary requirements", "Error");
                }
                else
                {
                    Date = DateTime.Now;
                    SQL = "INSERT INTO Orders(Customer_ID,DP_ID,Restaurant_ID,Order_Price,Menu_Items_IDs,Date,Status) VALUES('{Customer_ID}','{DP_ID}','{Restaurant_ID}',{Order_Price},{MenuItems_IDs},{Date},{Status})"; 
                }
                
            }
            catch
            {

            }
            
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            SQL = "SELECT Location_ID FROM DeliverLocations WHERE Location_Name = " + comboBox3.Text;
            comm = new SqlCommand(SQL, con);
            dataReader = comm.ExecuteReader();
            DP_ID = dataReader.GetInt32(0);
        }
    }
}
