using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace INVENTORY_MANAGEMENT
{
    public partial class Form11 : Form
    {
        // Replace this connection string with your actual connection string
        private const string ConnectionString = @"Data Source=(local)\SQLEXPRESS;Initial Catalog=invin1;Integrated Security=True";

        public Form11()
        {
            InitializeComponent();
            view.Click += new EventHandler(View_Click);
            ADD.Click += new EventHandler(ADD_Click);
        }

        private void Form11_Load(object sender, EventArgs e)
        {
            // Initialize or load anything needed on form load
        }

        private void View_Click(object sender, EventArgs e)
        {
            // Handle the click event for the VIEW button
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                string query = "SELECT * FROM OrderHistory";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                ordhistgrid.DataSource = dataTable;
            }
        }

        private void ADD_Click(object sender, EventArgs e)
        {
            // Handle the click event for the ADD button
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                // Replace the following placeholders with actual column names
                string query = "INSERT INTO OrderHistory (OrderID, CustomerID, OrderDate, TotalAmount, Status) " +
                               "VALUES (@OrderID, @CustomerID, @OrderDate, @TotalAmount, @Status)";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@OrderID", string.IsNullOrEmpty(ordid.Text) ? DBNull.Value : (object)ordid.Text);
                command.Parameters.AddWithValue("@CustomerID", string.IsNullOrEmpty(custid.Text) ? DBNull.Value : (object)custid.Text);
                command.Parameters.AddWithValue("@OrderDate", string.IsNullOrEmpty(orddate.Text) ? DBNull.Value : (object)orddate.Text);
                command.Parameters.AddWithValue("@TotalAmount", string.IsNullOrEmpty(totalamount.Text) ? DBNull.Value : (object)totalamount.Text);
                command.Parameters.AddWithValue("@Status", string.IsNullOrEmpty(status.Text) ? DBNull.Value : (object)status.Text);

                try
                {
                    command.ExecuteNonQuery();
                    MessageBox.Show("Data added successfully!");

                    // Refresh the view after adding data
                    View_Click(sender, e);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error adding data: {ex.Message}");
                }
            }
        }
    }
}
