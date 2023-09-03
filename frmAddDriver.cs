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

namespace FoodOnCampus
{
    public partial class frmAddDriver : Form
    {
        string conString = @"Data Source=(LocalDB)\MSSQLLocalDB; AttachDbFilename=|DataDirectory|DBMain.mdf; Integrated Security=True";

        public frmAddDriver()
        {
            InitializeComponent();
        }

        private void frmAddDriver_Load(object sender, EventArgs e)
        {

        }

        private void btnAddDriver_Click(object sender, EventArgs e)
        {
            // Get user inputs
            string name = txtName.Text;
            string surname = txtSurname.Text;
            string email = txtEmail.Text;
            string password = txtPassword.Text;

            // Verify user input:
            bool isValid = true;
            string errorMessage = "";

            // Verify Name
            if (name.Length < 3 || name.Length > 30)
            {
                isValid = false;
                errorMessage += "Name is invalid length.\n";
            }

            // Verify Surname
            if (surname.Length < 3 || surname.Length > 30)
            {
                isValid = false;
                errorMessage += "Surname is invalid length.\n";
            }

            // Verify Email
            if (email.Length < 10 || email.Length > 50)
            {
                isValid = false;
                errorMessage += "Email is invalid length.\n";
            }
            else if (!email.Contains("@") || !email.Contains("."))
            {
                isValid = false;
                errorMessage += "Email address is invalid.\n";
            }

            // Verify Password
            if (password.Length > 30)
            {
                isValid = false;
                errorMessage += "Password is too long (Max 30)\n";
            }
            else if (password.Length < 7)
            {
                isValid = false;
                errorMessage += "Password must be at least 7 characters long.\n";
            }
            else if (password.Contains("\"") || password.Contains("+") || password.Contains("/"))
            {
                isValid = false;
                errorMessage += "Password cannot contain one of the special characters \" or + or /.\n";
            }
            else if (!password.Any(char.IsDigit))
            {
                isValid = false;
                errorMessage += "Password should contain at least one number.\n";
            }


            if (isValid)
            {
                try
                {
                    // Insert the new driver into the "Users" table with the "Driver" role
                    using (SqlConnection con = new SqlConnection(conString))
                    {
                        con.Open();

                        string insertQuery = "INSERT INTO Users (User_Name, User_Surname, User_Email, User_Password, User_Role) VALUES (@Name, @Surname, @Email, @Password, 'Driver')";

                        using (SqlCommand insertCommand = new SqlCommand(insertQuery, con))
                        {
                            insertCommand.Parameters.AddWithValue("@Name", name);
                            insertCommand.Parameters.AddWithValue("@Surname", surname);
                            insertCommand.Parameters.AddWithValue("@Email", email);
                            insertCommand.Parameters.AddWithValue("@Password", password);

                            int rowsAffected = insertCommand.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Driver added successfully.", "Add Driver", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                ClearForm();
                                DialogResult = DialogResult.OK;
                                Close();
                            }
                            else
                            {
                                MessageBox.Show("Failed to add driver.", "Add Driver", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error adding driver: " + ex.Message, "Add Driver Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show(errorMessage, "Input Verification Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearForm()
        {
            // Clear all input fields
            txtName.Text = "";
            txtSurname.Text = "";
            txtEmail.Text = "";
            txtPassword.Text = "";
        }
    }
}
