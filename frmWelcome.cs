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
    public partial class frmWelcome : Form
    {
        string conString = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = |DataDirectory|DBMain.mdf; Integrated Security = True";
        SqlConnection Con;

        private int User_ID;
        private frmMain fMain;
        public frmWelcome(frmMain mainForm)
        {
            InitializeComponent();

            //Attach SqlConnection to database
            try
            {
                Con = new SqlConnection(conString);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "DB Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }

            //Assign the reference of frmMain
            fMain = mainForm;
        }


        private bool CheckIfUserExists(string email)
        {
            // Open the connection
            Con.Open();

            // Check if the user is already in the system
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Users WHERE User_Email = @Email", Con);
            cmd.Parameters.AddWithValue("@Email", email);

            // Execute the command and get the inserted user ID
            int iID = Convert.ToInt32(cmd.ExecuteScalar());

            // Close the connection
            Con.Close();

            // Return true if the user exists, false otherwise
            return iID > 0;
        }

        private void ApproveUser(int ID, string sRole)
        {
            //Show new buttons for the user depending on their role
            if (sRole == "Customer" || sRole == "Admin")
            {
                //All customers can access this:
                fMain.btnProfile.Visible = true;
                fMain.btnOrder.Visible = true;
            }

            if (sRole == "Admin")
            {
                //Allow admins to generate reports and manage the orders
                fMain.btnAdminPanel.Visible = true;
            }

            if (sRole == "Driver")
            {
                //Allow drivers to manage orders
                fMain.btnDriverMenu.Visible = true;
            }

            //Set the users ID
            fMain.setUserID(ID);
        }

        private string NameFormat(string Name)
        {
            // This method makes a word into a name format (First letter capital, rest lowercase)
            string sTemp = Name.ToLower();
            string sResult = char.ToUpper(sTemp[0]) + sTemp.Substring(1);

            return sResult;
        }

        private int GetHighestUserID()
        {
            int highestUserID = 0;

            try
            {
                // Open the connection
                Con.Open();

                // Execute the command to retrieve the highest User_ID
                SqlCommand cmd = new SqlCommand("SELECT MAX(User_ID) FROM Users", Con);
                highestUserID = Convert.ToInt32(cmd.ExecuteScalar());

                // Close the connection
                Con.Close();
            }
            catch (Exception ex)
            {
                // Handle any errors
                MessageBox.Show(ex.Message.ToString(), "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return highestUserID;
        }

        private int AddUserToDatabase(string name, string surname, string email, string password)
        {
            // Open the connection
            Con.Open();

            // Add user to Users Table
            SqlCommand cmd = new SqlCommand("INSERT INTO Users (User_Name, User_Surname, User_Email, User_Password, User_Role) VALUES (@Name, @Surname, @Email, @Password, @Role)", Con);
            cmd.Parameters.AddWithValue("@Name", name);
            cmd.Parameters.AddWithValue("@Surname", surname);
            cmd.Parameters.AddWithValue("@Email", email);
            cmd.Parameters.AddWithValue("@Password", password);
            cmd.Parameters.AddWithValue("@Role", "Customer"); //By default a user is given the Customer role

            // Execute the command
            int iResult = cmd.ExecuteNonQuery();

            // Close the connection
            Con.Close();

            return iResult;
        }


        private void btnLogIn_Click(object sender, EventArgs e)
        {
            fMain.hideUserButtons();
            // Get user inputs
            string sEmail = txtLogInEmail.Text.ToLower(); //all emails are forced lowercase
            string sPassword = txtLogInPassword.Text;

            try
            {
                // Open the connection
                Con.Open();

                // Check if the user exists and retrieve the user's role and ID
                SqlCommand cmd = new SqlCommand("SELECT User_ID, User_Role FROM Users WHERE User_Email = @Email AND User_Password = @Password", Con);
                cmd.Parameters.AddWithValue("@Email", sEmail);
                cmd.Parameters.AddWithValue("@Password", sPassword);

                // Execute the command and get the user's role and ID
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    int userId = Convert.ToInt32(reader["User_ID"]);
                    string sRole = Convert.ToString(reader["User_Role"]);

                    // Close the reader
                    reader.Close();
                    // Close the connection
                    Con.Close();

                    // Display a success message
                    MessageBox.Show("Logged in successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Sign User In
                    ApproveUser(userId, sRole);
                }
                else
                {
                    // Close the reader
                    reader.Close();
                    // Close the connection
                    Con.Close();

                    // Display an error message if the user does not exist or the password is incorrect
                    MessageBox.Show("Invalid email or password.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                // Display database errors
                MessageBox.Show(ex.Message.ToString(), "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            fMain.hideUserButtons();
            // Get user inputs
            string sName = NameFormat(txtSignUpName.Text);
            string sSurname = NameFormat(txtSignUpSurname.Text);
            string sEmail = txtSignUpEmail.Text;
            string sPassword = txtSignUpPassword.Text;

            // Verify user input:
            bool isValid = true;
            string errorMessage = "";


            // Verify Name
            if (sName.Length < 3 || sName.Length > 30)
            {
                isValid = false;
                errorMessage += "Name is invalid length.\n";
            }

            // Verify Surname
            if (sSurname.Length < 3 || sSurname.Length > 30)
            {
                isValid = false;
                errorMessage += "Surname is invalid length.\n";
            }

            // Verify Email
            if (sEmail.Length < 10 || sEmail.Length > 50)
            {
                isValid = false;
                errorMessage += "Email  is invalid length.\n";
            }
            else if (!sEmail.Contains("@") && (!sEmail.Contains(".")))
            {
                isValid = false;
                errorMessage += "Email address is invalid.\n";
            }

            // Verify Password
            if (sPassword.Length > 30)
            {
                isValid = false;
                errorMessage += "Password is too long (Max 30)\n";
            }
            else if (sPassword.Length < 7)
            {
                isValid = false;
                errorMessage += "Password must be at least 7 characters long.\n";
            }
            else if (sPassword.Contains("\"") || sPassword.Contains("+") || sPassword.Contains("/"))
            {
                isValid = false;
                errorMessage += "Password cannot contain one of the special characters \" or + or /.\n";
            }
            else if (!sPassword.Any(char.IsDigit))
            {
                isValid = false;
                errorMessage += "Password should contain at least one number.\n";
            }

            if (isValid)
            {
                try
                {
                    // First, check if the user already exists
                    bool userExists = CheckIfUserExists(sEmail);

                    if (userExists)
                    {
                        errorMessage += "User with the provided email already exists.\n";
                        isValid = false;
                    }
                    else
                    {
                        // If the user does not exist, add the user to the database
                        int iAdded = AddUserToDatabase(sName, sSurname, sEmail, sPassword);

                        // Retrieve the highest User_ID from the table
                        int iUserID = GetHighestUserID();

                        if (iAdded == 1)
                        {
                            // Display a success message
                            MessageBox.Show(sName + " " + sSurname + " was added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Sign User In
                            ApproveUser(iUserID, "Customer");
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Display errors
                    MessageBox.Show(ex.Message.ToString(), "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // Display error message to the user
                MessageBox.Show(errorMessage, "Input Verification Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
