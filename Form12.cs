using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace INVENTORY_MANAGEMENT
{
    public partial class Form12 : Form
    {
        // Replace this connection string with your actual connection string
        private const string ConnectionString = @"Data Source=(local)\SQLEXPRESS;Initial Catalog=invin1;Integrated Security=True";

        public Form12()
        {
            InitializeComponent();
            VIEW.Click += new EventHandler(VIEW_Click);
            ADD.Click += new EventHandler(ADD_Click);
        }

        private void Form12_Load(object sender, EventArgs e)
        {
            // Initialize or load anything needed on form load
        }

        private void VIEW_Click(object sender, EventArgs e)
        {
            // Handle the click event for the VIEW button
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                string query = "SELECT * FROM OrderDetailHistory";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                ORDHISTDETAILGRID.DataSource = dataTable;
            }
        }

        private void ADD_Click(object sender, EventArgs e)
        {
            // Handle the click event for the ADD button
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                // Replace the following placeholders with actual column names
                string query = "INSERT INTO OrderDetailHistory (OrderDetailID, OrderID, ProductID, Quantity, UnitPrice, Subtotal) " +
                               "VALUES (@OrderDetailID, @OrderID, @ProductID, @Quantity, @UnitPrice, @Subtotal)";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@OrderDetailID", string.IsNullOrEmpty(orddetail.Text) ? DBNull.Value : (object)orddetail.Text);
                command.Parameters.AddWithValue("@OrderID", string.IsNullOrEmpty(ordid.Text) ? DBNull.Value : (object)ordid.Text);
                command.Parameters.AddWithValue("@ProductID", string.IsNullOrEmpty(prdid.Text) ? DBNull.Value : (object)prdid.Text);
                command.Parameters.AddWithValue("@Quantity", string.IsNullOrEmpty(quantity.Text) ? DBNull.Value : (object)quantity.Text);
                command.Parameters.AddWithValue("@UnitPrice", string.IsNullOrEmpty(unitprice.Text) ? DBNull.Value : (object)unitprice.Text);
                command.Parameters.AddWithValue("@Subtotal", string.IsNullOrEmpty(subtotal.Text) ? DBNull.Value : (object)subtotal.Text);

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
