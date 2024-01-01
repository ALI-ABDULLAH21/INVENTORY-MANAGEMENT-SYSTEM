using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace INVENTORY_MANAGEMENT
{
    public partial class Form5 : Form
    {
        // Replace this connection string with your actual connection string
        private const string ConnectionString = @"Data Source=(local)\SQLEXPRESS;Initial Catalog=invin1;Integrated Security=True";

        public Form5()
        {
            InitializeComponent();
            view.Click += new EventHandler(VIEW_Click);
            ADD.Click += new EventHandler(ADDO_Click);
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // Initialize or load anything needed on form load
        }

        private void VIEW_Click(object sender, EventArgs e)
        {
            // Handle the click event for the VIEW button
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                string query = "SELECT * FROM Customer"; // Replace with your actual table name
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                custgrid.DataSource = dataTable;
            }
        }

        private void ADDO_Click(object sender, EventArgs e)
        {
            // Handle the click event for the ADDO button
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                // Replace the following placeholders with actual column names
                string query = "INSERT INTO Customer (CustomerID, CustomerName, ContactNumber, Email, Address) " +
                               "VALUES (@CustomerID, @CustomerName, @ContactNumber, @Email, @Address)";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@CustomerID", string.IsNullOrEmpty(custid.Text) ? DBNull.Value : (object)custid.Text);
                command.Parameters.AddWithValue("@CustomerName", string.IsNullOrEmpty(custname.Text) ? DBNull.Value : (object)custname.Text);
                command.Parameters.AddWithValue("@ContactNumber", string.IsNullOrEmpty(custnum.Text) ? DBNull.Value : (object)custnum.Text);
                command.Parameters.AddWithValue("@Email", string.IsNullOrEmpty(custemail.Text) ? DBNull.Value : (object)custemail.Text);
                command.Parameters.AddWithValue("@Address", string.IsNullOrEmpty(custaddress.Text) ? DBNull.Value : (object)custaddress.Text);

                try
                {
                    command.ExecuteNonQuery();
                    MessageBox.Show("Data added successfully!");

                    // Refresh the view after adding data
                    VIEW_Click(sender, e);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error adding data: {ex.Message}");
                }
            }
        }
    }
}
