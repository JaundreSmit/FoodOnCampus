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
    public partial class DriverForm : Form
    {
        public DriverForm()
        {
            InitializeComponent();
        }

        //Variables for database

        string ConString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\rober\OneDrive\Desktop\CMPG 223 TAAK FINAL\DBMain.mdf"";Integrated Security=True";

        SqlConnection con;
        SqlCommand com;
        SqlDataAdapter da;
        DataSet ds;



        private void button2_Click(object sender, EventArgs e)
        {
            //Only display orders that are "In Progress"
            con = new SqlConnection(ConString);
            con.Open();
            da = new SqlDataAdapter("SELECT * FROM Orders WHERE Status = 'In Progress'", con);
            ds = new DataSet();
            da.Fill(ds, "Orders");
            dataGridView1.DataSource = ds.Tables["Orders"];
            con.Close();

        }

        private void DriverForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Show the orders form the Orders table in the datagridview

            con = new SqlConnection(ConString);
            con.Open();
            da = new SqlDataAdapter("SELECT * FROM Orders", con);
            ds = new DataSet();
            da.Fill(ds, "Orders");
            dataGridView1.DataSource = ds.Tables["Orders"];
            con.Close();




        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //if user clicks on field in the database the order status must change to "In Progress"

            // Check if a valid row is clicked
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Get the OrderID from the selected row
                int orderID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["Order_ID"].Value);

                // Update the database
                using (SqlConnection con = new SqlConnection(ConString))
                {
                    con.Open();
                    using (SqlCommand com = new SqlCommand("UPDATE Orders SET Status = 'In Progress' WHERE Order_ID = @OrderID", con))
                    {
                        com.Parameters.AddWithValue("@OrderID", orderID);
                        com.ExecuteNonQuery();
                    }
                }

                // Refresh the DataGridView or update the UI as needed
                dataGridView1.Refresh();
            }


        }
    }
  }

