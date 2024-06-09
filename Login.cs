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

namespace PaymentFormSystem
{
    public partial class Login : Form
    {
        private string connectionString = "Data Source=WIN-MAODJ10OMLA;Initial Catalog=payment_form;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;";
        private const int AdminContactNumber = 91404;
        private const string AdminPassword = "!@0100";

        public Login()
        {
            InitializeComponent();
            EnterPasswordTextBox.PasswordChar = '*';
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            int enteredContactNumber;
            string enteredPassword;

            if (!int.TryParse(EnterEmailTextBox.Text, out enteredContactNumber))
            {
                MessageBox.Show("Invalid input for contact number.");
                return;
            }
            enteredPassword = EnterPasswordTextBox.Text;

            if (enteredContactNumber == AdminContactNumber && enteredPassword == AdminPassword)
            {
                MessageBox.Show("Admin login successful!");
                OpenUserDetailsForm();
                this.Hide();
            }
            else
            {
                if (CheckRegisteredAccount(enteredContactNumber, enteredPassword))
                {
                    OpenPayments(enteredContactNumber, enteredPassword);
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid credentials.");
                }
            }
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            RegistrationForm registerForm = new RegistrationForm(this);
            registerForm.Show();
            this.Hide();
        }

        private bool CheckRegisteredAccount(int enteredContactNumber, string enteredPassword)
        {
            string query = "SELECT COUNT(*) FROM Registration WHERE contact_number = @ContactNumber AND contact_password = @ContactPassword";
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ContactNumber", enteredContactNumber);
                        command.Parameters.AddWithValue("@ContactPassword", enteredPassword);

                        int count = (int)command.ExecuteScalar();
                        return count > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
                return false;
            }
        }

        private void OpenUserDetailsForm()
        {
            UserDetailsForm userDetailsForm = new UserDetailsForm(this);
            userDetailsForm.Show();
            this.Hide();
        }

        private void OpenPayments(int contactNumber, string contactPassword)
        {
            Payments paymentPage = new Payments
            {
                ContactNumber = contactNumber,
                ContactPassword = contactPassword
            };
            paymentPage.SetContactName();
            paymentPage.Show();
            this.Hide();
        }

        private void UserDetails_Click(object sender, EventArgs e)
        {

        }
    }
}
