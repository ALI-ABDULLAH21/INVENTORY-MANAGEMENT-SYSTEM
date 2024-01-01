using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace INVENTORY_MANAGEMENT
{
    public partial class Form7 : Form
    {
        // Replace this connection string with your actual connection string
        private const string ConnectionString = @"Data Source=(local)\SQLEXPRESS;Initial Catalog=invin1;Integrated Security=True";

        public Form7()
        {
            InitializeComponent();
            button1.Click += new EventHandler(button1_Click);
            Add.Click += new EventHandler(Add_Click);
            DELETEBUTT.Click += new EventHandler(DELETEBUTT_Click);
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            // Initialize or load anything needed on form load
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Handle the click event for the VIEW button
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                string query = "SELECT * FROM Supplier";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                suppgrid.DataSource = dataTable;
            }
        }

        private void Add_Click(object sender, EventArgs e)
        {
            // Handle the click event for the ADD button
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                // Replace the following placeholders with actual column names
                string query = "INSERT INTO Supplier (SupplierID, SupplierName, ContactPerson, ContactNumber, Email, Address) " +
                               "VALUES (@SupplierID, @SupplierName, @ContactPerson, @ContactNumber, @Email, @Address)";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@SupplierID", string.IsNullOrEmpty(suppid.Text) ? DBNull.Value : (object)suppid.Text);
                command.Parameters.AddWithValue("@SupplierName", string.IsNullOrEmpty(suppname.Text) ? DBNull.Value : (object)suppname.Text);
                command.Parameters.AddWithValue("@ContactPerson", string.IsNullOrEmpty(cntchperson.Text) ? DBNull.Value : (object)cntchperson.Text);
                command.Parameters.AddWithValue("@ContactNumber", string.IsNullOrEmpty(cntchnum.Text) ? DBNull.Value : (object)cntchnum.Text);
                command.Parameters.AddWithValue("@Email", string.IsNullOrEmpty(email.Text) ? DBNull.Value : (object)email.Text);
                command.Parameters.AddWithValue("@Address", string.IsNullOrEmpty(address.Text) ? DBNull.Value : (object)address.Text);

                try
                {
                    command.ExecuteNonQuery();
                    MessageBox.Show("Data added successfully!");

                    // Refresh the view after adding data
                    button1_Click(sender, e);
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

                // First, delete related records in the StockTransaction table
                string deleteStockTransactionsQuery = "DELETE FROM StockTransaction WHERE ProductID IN (SELECT ProductID FROM Product WHERE SupplierID = @SupplierID)";
                SqlCommand deleteStockTransactionsCommand = new SqlCommand(deleteStockTransactionsQuery, connection);
                deleteStockTransactionsCommand.Parameters.AddWithValue("@SupplierID", string.IsNullOrEmpty(DELETEBOX.Text) ? DBNull.Value : (object)DELETEBOX.Text);

                try
                {
                    deleteStockTransactionsCommand.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error deleting related stock transactions: {ex.Message}");
                    return;
                }

                // Second, delete related records in the Orderdetail table
                string deleteOrderDetailsQuery = "DELETE FROM Orderdetail WHERE ProductID IN (SELECT ProductID FROM Product WHERE SupplierID = @SupplierID)";
                SqlCommand deleteOrderDetailsCommand = new SqlCommand(deleteOrderDetailsQuery, connection);
                deleteOrderDetailsCommand.Parameters.AddWithValue("@SupplierID", string.IsNullOrEmpty(DELETEBOX.Text) ? DBNull.Value : (object)DELETEBOX.Text);

                try
                {
                    deleteOrderDetailsCommand.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error deleting related order details: {ex.Message}");
                    return;
                }

                // Third, delete related records in the Product table
                string deleteProductsQuery = "DELETE FROM Product WHERE SupplierID = @SupplierID";
                SqlCommand deleteProductsCommand = new SqlCommand(deleteProductsQuery, connection);
                deleteProductsCommand.Parameters.AddWithValue("@SupplierID", string.IsNullOrEmpty(DELETEBOX.Text) ? DBNull.Value : (object)DELETEBOX.Text);

                try
                {
                    deleteProductsCommand.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error deleting related products: {ex.Message}");
                    return;
                }

                // Finally, delete the supplier record
                string deleteSupplierQuery = "DELETE FROM Supplier WHERE SupplierID = @SupplierID";
                SqlCommand deleteSupplierCommand = new SqlCommand(deleteSupplierQuery, connection);
                deleteSupplierCommand.Parameters.AddWithValue("@SupplierID", string.IsNullOrEmpty(DELETEBOX.Text) ? DBNull.Value : (object)DELETEBOX.Text);

                try
                {
                    deleteSupplierCommand.ExecuteNonQuery();
                    MessageBox.Show("Data deleted successfully!");

                    // Refresh the view after deleting data
                    button1_Click(sender, e);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error deleting supplier data: {ex.Message}");
                }
            }
        }
    }
}
