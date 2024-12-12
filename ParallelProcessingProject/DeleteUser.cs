using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParallelProcessingProject
{
    public partial class DeleteUser : Form
    {
        public DeleteUser()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void UserIdInput_TextChanged(object sender, EventArgs e)
        {


        }

        private async void DeleteButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(UserIdInput.Text) || !int.TryParse(UserIdInput.Text, out int id) || id < 1)
            {
                MessageBox.Show("Please enter a valid User ID greater than 0.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Perform the deletion asynchronously to avoid UI hanging
                await DeleteUserById(id);

                // Notify the user upon success
                MessageBox.Show("User deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task DeleteUserById(int id)
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ATMDB;Integrated Security=True";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                await con.OpenAsync(); // Open the connection asynchronously

                string sql = "DELETE FROM Users WHERE id = @id";
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@id", id);

                    // Execute the command asynchronously
                    await cmd.ExecuteNonQueryAsync();
                }
            }
        }
    }
}
