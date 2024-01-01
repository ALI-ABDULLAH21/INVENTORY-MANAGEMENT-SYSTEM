using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace INVENTORY_MANAGEMENT
{
    public partial class Form1 : Form
    {
        private Form2 form2;
        private Form3 form3;
        private Form4 form4;

        public Form1()
        {
            InitializeComponent();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            string username = Username.Text;
            string password = Password.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter your username and password.");
            }
            else
            {
                string connString = @"Data Source=(local)\SQLEXPRESS;Initial Catalog=invin1;Integrated Security=True";

                using (SqlConnection conn = new SqlConnection(connString))
                {
                    try
                    {
                        conn.Open();

                        // Use a SqlCommand to check the credentials against the database
                        string query = "SELECT UserType FROM UserTable WHERE Username = @Username AND Password = @Password";
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@Username", username);
                            cmd.Parameters.AddWithValue("@Password", password);

                            string userType = cmd.ExecuteScalar()?.ToString();

                            if (!string.IsNullOrEmpty(userType))
                            {
                                MessageBox.Show($"Login Successful. UserType: {userType}");

                                // Open Form2 for Admin, Form3 for Employee, or Form4 for Customer
                                if (userType == "Admin")
                                {
                                    form2 = new Form2();
                                    form2.FormClosed += (s, args) => ShowForm1();
                                    this.Hide();
                                    form2.Show();
                                }
                                else if (userType == "Employee")
                                {
                                    form3 = new Form3();
                                    form3.FormClosed += (s, args) => ShowForm1();
                                    this.Hide();
                                    form3.Show();
                                }
                                else if (userType == "Customer")
                                {
                                    form4 = new Form4();
                                    form4.FormClosed += (s, args) => ShowForm1();
                                    this.Hide();
                                    form4.Show();
                                }
                            }
                            else
                            {
                                MessageBox.Show("Invalid username or password.");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error: {ex.Message}");
                    }
                }
            }
        }

        private void ShowForm1()
        {
            this.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
