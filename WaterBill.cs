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
    public partial class WaterBill : Form
    {
        public int ContactNumber { get; set; }
        public string ContactPassword { get; set; }
        public string ContactName { get; set; }
        private string connectionString = "Data Source=WIN-MAODJ10OMLA;Initial Catalog=payment_form;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;";
        public WaterBill()
        {
            InitializeComponent();
            this.Load += WaterBill_Load;
        }

        private void WaterBill_Load(object sender, EventArgs e)
        {
            SetWaterBill();
        }

        public void SetWaterBill()
        {
            label4.Text = "Water Bill: " + GetWaterBill(ContactNumber, ContactPassword);
        }

        private string GetWaterBill(int contactNumber, string contactPassword)
        {
            string query = "SELECT water_bill FROM Registration WHERE contact_number = @ContactNumber AND contact_password = @ContactPassword";
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
                return "Error";
            }
        }

        private void UpdateWaterBill(decimal newBillAmount)
        {
            string query = "UPDATE Registration SET water_bill = @NewWaterBill WHERE contact_number = @ContactNumber AND contact_password = @ContactPassword";
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@NewWaterBill", newBillAmount);
                        command.Parameters.AddWithValue("@ContactNumber", ContactNumber);
                        command.Parameters.AddWithValue("@ContactPassword", ContactPassword);

                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Water bill updated successfully!");
                        }
                        else
                        {
                            MessageBox.Show("Failed to update water bill.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
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

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(WaterPaymentTextBox.Text, out decimal payment))
            {
                decimal currentBill = decimal.Parse(GetWaterBill(ContactNumber, ContactPassword));
                decimal newBillAmount = currentBill - payment;

                if (newBillAmount < 0)
                {
                    newBillAmount = 0;
                    MessageBox.Show("Payment exceeds the current bill amount. The remaining bill is set to 0.");
                }

                UpdateWaterBill(newBillAmount);
                label4.Text = "Water Bill: " + newBillAmount.ToString("0.00");
            }
            else
            {
                MessageBox.Show("Please enter a valid payment amount.");
            }
        }
    }
}
