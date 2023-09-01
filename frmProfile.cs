﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodOnCampus
{
    public partial class frmProfile : Form
    {
        private int UserId;  //Placeholder, Replace the 0 in Profile_Load with loged in users ID

        private SqlDataAdapter adapter;
        private SqlCommand cmd;
        private SqlConnection conn;
        private DataSet ds;
        private SqlDataReader rdr;

        private int[] restaurantId = new int[100];
        private string[] restaurantName = new string[100];
        private string[] restaurants = new string[100];

        public frmProfile()
        {
            InitializeComponent();
        }

        private void frmProfile_Load(object sender, EventArgs e)
        {
            UserId = 0; //The 0 is a placeholder, replace with the loged in users ID 

            conn = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = |DataDirectory|DBMain.mdf; Integrated Security = True");


            //----------------------Get user name and set label-------------------

            lblHello.Text = "";

            conn.Open();

            cmd = new SqlCommand("SELECT User_Name FROM Users WHERE User_ID = "+UserId+" ", conn);
            rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                lblHello.Text = "Hello, " + rdr.GetValue(0).ToString();
            }

            conn.Close();

            //--------------------------------------------------------------------



            //-------------------------Fill Orders list box-----------------------

            conn.Open();

            cmd = new SqlCommand("SELECT Restaurant_Name FROM Restaurants", conn);
            rdr = cmd.ExecuteReader();
            int countName = 0;

            while (rdr.Read())
            {
                restaurantName[countName] = rdr.GetValue(0).ToString();
                countName++;
            }

            conn.Close();


            conn.Open();

            cmd = new SqlCommand("SELECT Restaurant_ID FROM Orders WHERE Customer_ID = "+UserId+" ", conn);
            rdr = cmd.ExecuteReader();
            int count = 0;

            while (rdr.Read())
            {
                restaurantId[count] = Convert.ToInt32(rdr.GetValue(0));
                count++;
            }

            conn.Close();

            for (int i = 0; i < count; i++) 
            {
                restaurants[i] = restaurantName[restaurantId[i]-1];
            }

            lbxOrders.Items.Clear();
            lbxOrders.Items.Add("Order ID\tRestaurant\tPrice\tDate");
            lbxOrders.Items.Add("");

            conn.Open();

            cmd = new SqlCommand("SELECT Order_ID, Order_Price, Date FROM Orders WHERE Customer_ID = "+UserId+" ", conn);
            rdr = cmd.ExecuteReader();
            int k = 0;

            while (rdr.Read())
            {
                lbxOrders.Items.Add(rdr.GetValue(0).ToString()+"\t"+ restaurants[k] +"\t"+rdr.GetValue(1).ToString()+"\t"+rdr.GetValue(2).ToString());
                k++;
            }

            conn.Close();

            //-------------------------------------------------------------



        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdatePassword_Click(object sender, EventArgs e)
        {
            if(tbxPassword.Text=="")
            {
                MessageBox.Show("Please enter a new password");
            }
            else
            {
                conn.Open();

                string sql = "UPDATE Users SET User_Password = '"+tbxPassword.Text+"' WHERE User_ID = "+UserId+"";
                cmd = new SqlCommand(sql,conn);
                cmd.ExecuteNonQuery();

                conn.Close();
            }
        }

        private void btnUpdateEmail_Click(object sender, EventArgs e)
        {
            if (tbxEmail.Text == "")
            {
                MessageBox.Show("Please enter a new Email");
            }
            else
            {
                conn.Open();

                string sql = "UPDATE Users SET User_Email = '" + tbxEmail.Text + "' WHERE User_ID = " + UserId + "";
                cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();

                conn.Close();
            }
        }
    }
}
