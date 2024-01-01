using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace INVENTORY_MANAGEMENT
{
    public partial class ADD : Form
    {
        // Replace this connection string with your actual connection string
        private const string ConnectionString = @"Data Source=(local)\SQLEXPRESS;Initial Catalog=invin1;Integrated Security=True";

        public ADD()
        {
            InitializeComponent();
            VIEW.Click += new EventHandler(VIEW_Click);
            ADDO.Click += new EventHandler(ADDO_Click);
        }

        private void ADD_Load(object sender, EventArgs e)
        {
            // Initialize or load anything needed on form load
        }

        private void VIEW_Click(object sender, EventArgs e)
        {
            // Handle the click event for the VIEW button
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                string query = "SELECT * FROM ORDERTABLE";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                ORDERGRID.DataSource = dataTable;
            }
        }

        private void ADDO_Click(object sender, EventArgs e)
        {
            // Handle the click event for the ADDO button
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                // Replace the following placeholders with actual column names
                string query = "INSERT INTO ORDERTABLE (OrderID, CustomerID, OrderDate, SupplierID, TotalAmount, Status) " +
                               "VALUES (CAST(@OrderID AS NVARCHAR), CAST(@CustomerID AS NVARCHAR), CAST(@OrderDate AS NVARCHAR), CAST(@SupplierID AS NVARCHAR), CAST(@TotalAmount AS DECIMAL), CAST(@Status AS NVARCHAR))";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@OrderID", string.IsNullOrEmpty(ordid.Text) ? DBNull.Value : (object)ordid.Text);
                command.Parameters.AddWithValue("@CustomerID", string.IsNullOrEmpty(custid.Text) ? DBNull.Value : (object)custid.Text);
                command.Parameters.AddWithValue("@OrderDate", string.IsNullOrEmpty(orderdate.Text) ? DBNull.Value : (object)orderdate.Text);
                command.Parameters.AddWithValue("@SupplierID", string.IsNullOrEmpty(suppid.Text) ? DBNull.Value : (object)suppid.Text);


                decimal totalAmount;
                command.Parameters.AddWithValue("@TotalAmount", decimal.TryParse(total.Text, out totalAmount) ? (object)totalAmount : DBNull.Value);

                command.Parameters.AddWithValue("@Status", string.IsNullOrEmpty(status.Text) ? DBNull.Value : (object)status.Text);

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
