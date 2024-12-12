using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParallelProcessingProject
{
    public partial class GetTransactions : Form
    {
        public GetTransactions()
        {
            InitializeComponent();
        }

        DataTable table = new DataTable();

        private async void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Clear the DataGridView before fetching new data
                dataGridView1.DataSource = null;
                dataGridView1.Rows.Clear();
                dataGridView1.Refresh();

                // Fetch data asynchronously
                await FetchTransactions();

                // Bind the data to the DataGridView
                dataGridView1.DataSource = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Something went wrong: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task FetchTransactions()
        {
            // Use a new connection for each operation
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ATMDB;Integrated Security=True";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    await con.OpenAsync(); // Open connection only when needed

                    // Build the SQL query
                    string sql = "SELECT * FROM Transactions WHERE 1=1";
                    SqlCommand cmd = new SqlCommand(sql, con);

                    if (dateTimePicker1.Value != null)
                    {
                        DateTime selectedDate = dateTimePicker1.Value.Date;
                        sql += " AND CAST(TransactionDate AS DATE) = @date";
                        cmd.Parameters.AddWithValue("@date", selectedDate);
                    }

                    cmd.CommandText = sql;

                    // Use SqlDataAdapter to fetch and fill the DataTable
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    table.Clear();
                    await Task.Run(() => adapter.Fill(table)); // Run the data fetch on a background thread
                }
                catch (Exception ex)
                {
                    throw new Exception("Failed to retrieve data.", ex);
                }
            } // 'using' automatically closes the connection
        }
    }
}
