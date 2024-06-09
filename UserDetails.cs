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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace PaymentFormSystem
{
    public partial class UserDetailsForm : Form
    {
        private Login loginPage;
        private string connectionString = "Data Source=WIN-MAODJ10OMLA;Initial Catalog=payment_form;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;";
        public UserDetailsForm(Login page)
        {
            InitializeComponent();
            loginPage = page;
            LoadRegisteredAccounts();
            BackButton.Click += BackButton_Click;
            UpdateButton.Click += UpdateButton_Click;
            DeleteButton.Click += DeleteButton_Click;
        }

        private void LoadRegisteredAccounts()
        {
            string query = "SELECT contact_number, contact_name, contact_email, contact_password, electric_bill, water_bill, cable_bill, education_bill FROM Registration";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    UserDetailsDataGridView.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            loginPage.Show();
            this.Close();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE Registration SET contact_name = @contact_name, contact_password = @contact_password, electric_bill = @electric_bill, water_bill = @water_bill, cable_bill = @cable_bill WHERE contact_number = @contact_number";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@contact_number", int.Parse(ContactNumberTextBox.Text));
                cmd.Parameters.AddWithValue("@contact_name", ContactNameTextBox.Text);
                cmd.Parameters.AddWithValue("@contact_email", EmailTextBox.Text);
                cmd.Parameters.AddWithValue("@contact_password", PasswordTextBox.Text);
                cmd.Parameters.AddWithValue("@electric_bill", decimal.Parse(ElectricBillTextBox.Text));
                cmd.Parameters.AddWithValue("@water_bill", decimal.Parse(WaterBillTextBox.Text));
                cmd.Parameters.AddWithValue("@cable_bill", decimal.Parse(InternetBillTextBox.Text));
                cmd.Parameters.AddWithValue("@education_bill", decimal.Parse(EducationBillTextBox.Text));

                try
                {
                    connection.Open();
                    cmd.ExecuteNonQuery();
                    LoadRegisteredAccounts();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Registration WHERE contact_number = @contact_number";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@contact_number", int.Parse(ContactNumberTextBox.Text));
                try
                {
                    connection.Open();
                    cmd.ExecuteNonQuery();
                    LoadRegisteredAccounts();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

        private void UserDetailsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.UserDetailsDataGridView.Rows[e.RowIndex];
                ContactNumberTextBox.Text = row.Cells["contact_number"].Value.ToString();
                ContactNameTextBox.Text = row.Cells["contact_name"].Value.ToString();
                EmailTextBox.Text = row.Cells["contact_email"].Value.ToString();
                PasswordTextBox.Text = row.Cells["contact_password"].Value.ToString();
                ElectricBillTextBox.Text = row.Cells["electric_bill"].Value.ToString();
                WaterBillTextBox.Text = row.Cells["water_bill"].Value.ToString();
                InternetBillTextBox.Text = row.Cells["cable_bill"].Value.ToString();
                EducationBillTextBox.Text = row.Cells["education_bill"].Value.ToString();
            }
        }
    }
}
