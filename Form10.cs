using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace INVENTORY_MANAGEMENT
{
    public partial class Form10 : Form
    {
        // Replace this connection string with your actual connection string
        private const string ConnectionString = @"Data Source=(local)\SQLEXPRESS;Initial Catalog=invin1;Integrated Security=True";

        public Form10()
        {
            InitializeComponent();
            VIEW.Click += new EventHandler(VIEW_Click);
            ADD.Click += new EventHandler(ADDO_Click);
        }

        private void Form10_Load(object sender, EventArgs e)
        {
            // Initialize or load anything needed on form load
        }

        private void VIEW_Click(object sender, EventArgs e)
        {
            // Handle the click event for the VIEW button
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                string query = "SELECT * FROM OrderDetail";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                orderdetailgrid.DataSource = dataTable;
            }
        }

        private void ADDO_Click(object sender, EventArgs e)
        {
            // Handle the click event for the ADDO button
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                // Replace the following placeholders with actual column names
                string query = "INSERT INTO OrderDetail (OrderDetailID, OrderID, ProductID, Quantity, UnitPrice, Subtotal) " +
                               "VALUES (@OrderDetailID, @OrderID, @ProductID, @Quantity, @UnitPrice, @Subtotal)";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@OrderDetailID", string.IsNullOrEmpty(textBox1.Text) ? DBNull.Value : (object)textBox1.Text);
                command.Parameters.AddWithValue("@OrderID", string.IsNullOrEmpty(textBox2.Text) ? DBNull.Value : (object)textBox2.Text);
                command.Parameters.AddWithValue("@ProductID", string.IsNullOrEmpty(textBox3.Text) ? DBNull.Value : (object)textBox3.Text);
                command.Parameters.AddWithValue("@Quantity", string.IsNullOrEmpty(textBox4.Text) ? DBNull.Value : (object)textBox4.Text);
                command.Parameters.AddWithValue("@UnitPrice", string.IsNullOrEmpty(textBox5.Text) ? DBNull.Value : (object)textBox5.Text);
                command.Parameters.AddWithValue("@Subtotal", string.IsNullOrEmpty(textBox6.Text) ? DBNull.Value : (object)textBox6.Text);

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
