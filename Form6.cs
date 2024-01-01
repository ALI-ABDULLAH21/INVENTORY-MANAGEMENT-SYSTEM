using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace INVENTORY_MANAGEMENT
{
    public partial class Form6 : Form
    {
        // Replace this connection string with your actual connection string
        private const string ConnectionString = @"Data Source=(local)\SQLEXPRESS;Initial Catalog=invin1;Integrated Security=True";

        public Form6()
        {
            InitializeComponent();
            view.Click += new EventHandler(VIEW_Click);
            ADD.Click += new EventHandler(ADDO_Click);
            DELETEBUTT.Click += new EventHandler(DELETEBUTT_Click);
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            // Initialize or load anything needed on form load
        }

        private void VIEW_Click(object sender, EventArgs e)
        {
            // Handle the click event for the VIEW button
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                string query = "SELECT * FROM Product";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                prdgrid.DataSource = dataTable;
            }
        }

        private void ADDO_Click(object sender, EventArgs e)
        {
            // Handle the click event for the ADDO button
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                // Replace the following placeholders with actual column names
                string query = "INSERT INTO Product (ProductID, ProductName, Description, CategoryID, UnitPrice, StockQuantity, ReorderLevel, SupplierID, DateAdded) " +
                               "VALUES (@ProductID, @ProductName, @Description, @CategoryID, @UnitPrice, @StockQuantity, @ReorderLevel, @SupplierID, @DateAdded)";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ProductID", string.IsNullOrEmpty(prdid.Text) ? DBNull.Value : (object)prdid.Text);
                command.Parameters.AddWithValue("@ProductName", string.IsNullOrEmpty(prdname.Text) ? DBNull.Value : (object)prdname.Text);
                command.Parameters.AddWithValue("@Description", string.IsNullOrEmpty(descp.Text) ? DBNull.Value : (object)descp.Text);
                command.Parameters.AddWithValue("@CategoryID", string.IsNullOrEmpty(cid.Text) ? DBNull.Value : (object)cid.Text);
                command.Parameters.AddWithValue("@UnitPrice", string.IsNullOrEmpty(unitp.Text) ? DBNull.Value : (object)unitp.Text);
                command.Parameters.AddWithValue("@StockQuantity", string.IsNullOrEmpty(stockqty.Text) ? DBNull.Value : (object)stockqty.Text);
                command.Parameters.AddWithValue("@ReorderLevel", string.IsNullOrEmpty(recorder.Text) ? DBNull.Value : (object)recorder.Text);
                command.Parameters.AddWithValue("@SupplierID", string.IsNullOrEmpty(suppid.Text) ? DBNull.Value : (object)suppid.Text);
                command.Parameters.AddWithValue("@DateAdded", string.IsNullOrEmpty(date.Text) ? DBNull.Value : (object)date.Text);

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

                // Replace the following placeholder with the actual column name
                string query = "DELETE FROM Product WHERE ProductID = @ProductID";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ProductID", string.IsNullOrEmpty(DELETEBOX.Text) ? DBNull.Value : (object)DELETEBOX.Text);

                try
                {
                    command.ExecuteNonQuery();
                    MessageBox.Show("Data deleted successfully!");

                    // Refresh the view after deleting data
                    VIEW_Click(sender, e);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error deleting data: {ex.Message}");
                }
            }
        }
    }
}
