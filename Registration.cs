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
    public partial class RegistrationForm : Form
    {
        private Login loginPage;
        public RegistrationForm(Login page)
        {
            InitializeComponent();
            loginPage = page;
        }

        private void Registration_Load(object sender, EventArgs e)
        {

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            loginPage.Show();
            this.Close();
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            string contactName = ContactNameRegistrationTextBox.Text;
            int contactNumber;
            string contactEmail = EmailRegistrationTextBox.Text;
            string contactPassword = PasswordRegistrationTextBox.Text;

            if (!int.TryParse(ContactNumberRegistrationTextBox.Text, out contactNumber))
            {
                MessageBox.Show("Invalid input for contact number.");
                return;
            }
            if (string.IsNullOrEmpty(contactEmail))
            {
                MessageBox.Show("Email cannot be empty.");
                return;
            }
                if (string.IsNullOrEmpty(contactPassword))
            {
                MessageBox.Show("Password cannot be empty.");
                return;
            }

            string connectionString = "Data Source=WIN-MAODJ10OMLA;Initial Catalog=payment_form;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;";
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "INSERT INTO Registration (contact_name, contact_number, contact_password) VALUES (@ContactName, @ContactNumber, @ContactPassword)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ContactName", contactName);
                        command.Parameters.AddWithValue("@ContactNumber", contactNumber);
                        command.Parameters.AddWithValue("@ContactPassword", contactPassword);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Successfully Registered!");
                        }
                        else
                        {
                            MessageBox.Show("Unsuccessfully Registered.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void ClickToLoginLabel_Click(object sender, EventArgs e)
        {
            loginPage.Show();
            this.Close();
        }
    }
}
