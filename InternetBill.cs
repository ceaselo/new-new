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
    public partial class InternetBill : Form
    {
        public int ContactNumber { get; set; }
        public string ContactPassword { get; set; }
        public string ContactName { get; set; }
        private string connectionString = "Data Source=WIN-MAODJ10OMLA;Initial Catalog=payment_form;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;";
        public InternetBill()
        {
            InitializeComponent();
            this.Load += InternetBill_Load;
        }

        public void SetCableBill()
        {
            DefaultLabel.Text = GetCableBill(ContactNumber, ContactPassword);
        }

        private string GetCableBill(int contactNumber, string contactPassword)
        {
            string query = "SELECT cable_bill FROM Registration WHERE contact_number = @ContactNumber AND contact_password = @ContactPassword";
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
                            return "Bill not found";
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

        private void SubmitButton_Click(object sender, EventArgs e)
        {

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Payments paymentPage = new Payments();
            paymentPage.ContactNumber = ContactNumber;
            paymentPage.ContactPassword = ContactPassword;
            paymentPage.SetContactName();
            paymentPage.Show();
            this.Close();
        }

        private void InternetBill_Load(object sender, EventArgs e)
        {
            SetCableBill();
        }

    }
}
