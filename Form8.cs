using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace INVENTORY_MANAGEMENT
{
    public partial class Form8 : Form
    {
        // Replace this connection string with your actual connection string
        private const string ConnectionString = @"Data Source=(local)\SQLEXPRESS;Initial Catalog=invin1;Integrated Security=True";

        public Form8()
        {
            InitializeComponent();
            VIEW.Click += new EventHandler(VIEW_Click);
            Add.Click += new EventHandler(Add_Click);
            DELETEBUTT.Click += new EventHandler(DELETEBUTT_Click);
        }

        private void Form8_Load_1(object sender, EventArgs e)
        {
            // Initialize or load anything needed on form load
        }

        private void VIEW_Click(object sender, EventArgs e)
        {
            // Handle the click event for the VIEW button
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                string query = "SELECT * FROM StockTransaction";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                Stockgrid.DataSource = dataTable;
            }
        }

        private void Add_Click(object sender, EventArgs e)
        {
            // Handle the click event for the ADD button
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                // Replace the following placeholders with actual column names
                string query = "INSERT INTO StockTransaction (TransactionID, ProductID, TransactionType, Quantity, TransactionDate, Remarks) " +
                               "VALUES (@TransactionID, @ProductID, @TransactionType, @Quantity, @TransactionDate, @Remarks)";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@TransactionID", string.IsNullOrEmpty(textBox1.Text) ? DBNull.Value : (object)textBox1.Text);
                command.Parameters.AddWithValue("@ProductID", string.IsNullOrEmpty(textBox2.Text) ? DBNull.Value : (object)textBox2.Text);
                command.Parameters.AddWithValue("@TransactionType", string.IsNullOrEmpty(textBox3.Text) ? DBNull.Value : (object)textBox3.Text);
                command.Parameters.AddWithValue("@Quantity", string.IsNullOrEmpty(textBox4.Text) ? DBNull.Value : (object)textBox4.Text);
                command.Parameters.AddWithValue("@TransactionDate", string.IsNullOrEmpty(textBox5.Text) ? DBNull.Value : (object)textBox5.Text);
                command.Parameters.AddWithValue("@Remarks", string.IsNullOrEmpty(textBox6.Text) ? DBNull.Value : (object)textBox6.Text);

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

        private void DELETEBUTT_Click(object sender, EventArgs e)
        {
            // Handle the click event for the DELETEBUTT button
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                // Delete the record from the StockTransaction table
                string deleteStockTransactionQuery = "DELETE FROM StockTransaction WHERE TransactionID = @TransactionID";
                SqlCommand deleteStockTransactionCommand = new SqlCommand(deleteStockTransactionQuery, connection);
                deleteStockTransactionCommand.Parameters.AddWithValue("@TransactionID", string.IsNullOrEmpty(DELETEBOX.Text) ? DBNull.Value : (object)DELETEBOX.Text);

                try
                {
                    deleteStockTransactionCommand.ExecuteNonQuery();
                    MessageBox.Show("Data deleted successfully!");

                    // Refresh the view after deleting data
                    VIEW_Click(sender, e);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error deleting stock transaction data: {ex.Message}");
                }
            }
        }
    }
}
