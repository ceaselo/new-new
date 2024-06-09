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

namespace PaymentFormSystem
{
    public partial class Payments : Form
    {
        private Login loginPage;
        public int ContactNumber { get; set; }
        public string ContactPassword { get; set; }
        private string connectionString = "Data Source=WIN-MAODJ10OMLA;Initial Catalog=payment_form;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;";
        public Payments()
        {
            loginPage = new Login();
            InitializeComponent();
        }

        public void SetContactName()
        {
            DefaultLabel.Text = GetContactName(ContactNumber, ContactPassword);
        }

        private string GetContactName(int contactNumber, string contactPassword)
        {
            string query = "SELECT contact_name FROM Registration WHERE contact_number = @ContactNumber AND contact_password = @ContactPassword";
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ContactNumber", contactNumber);
                        command.Parameters.AddWithValue("@ContactPassword", contactPassword);

                        object result = command.ExecuteScalar();
                        if (result != null)
                        {
                            return result.ToString();
                        }
                        else
                        {
                            return null;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
                return null;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login loginPage = new Login();
            loginPage.Show();
            this.Hide();
        }

        private void ElectricityButton_Click(object sender, EventArgs e)
        {
            ElectricBill electricalForm = new ElectricBill();
            electricalForm.ContactNumber = ContactNumber;
            electricalForm.ContactPassword = ContactPassword;
            electricalForm.ContactName = GetContactName(ContactNumber, ContactPassword);
            electricalForm.Show();
            this.Hide();
        }

        private void InternetButton_Click(object sender, EventArgs e)
        {
            InternetBill internetForm = new InternetBill();
            internetForm.ContactNumber = ContactNumber;
            internetForm.ContactPassword = ContactPassword.ToString();
            internetForm.ContactName = GetContactName(ContactNumber, ContactPassword);
            internetForm.Show();
            this.Hide();
        }

        private void WaterButton_Click(object sender, EventArgs e)
        {
            WaterBill waterForm = new WaterBill();
            waterForm.ContactNumber = ContactNumber;
            waterForm.ContactPassword = ContactPassword;
            waterForm.ContactName = GetContactName(ContactNumber, ContactPassword);
            waterForm.Show();
            this.Hide();
        }

        private void EducationButton_Click(object sender, EventArgs e)
        {
             Education waterForm = new Education();
             waterForm.ContactNumber = ContactNumber;
             waterForm.ContactPassword = ContactPassword;
             waterForm.ContactName = GetContactName(ContactNumber, ContactPassword);
             waterForm.Show();
             this.Hide();
        }
    }
}
