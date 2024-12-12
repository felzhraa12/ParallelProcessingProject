using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParallelProcessingProject
{
    public partial class Deposit : Form
    {
        public Deposit()
        {
            InitializeComponent();
        }

        //SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ATMDB;Integrated Security=True");
        const string con = (@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ATMDB;Integrated Security=True");
        private readonly SemaphoreSlim semaphore = new SemaphoreSlim(1, 1);
        decimal oldBalance , newBalance;
        int Acc = 2 ;

        private async void nextDeposit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Input: " + amountToDeposit.Text);

            if (amountToDeposit.Text == "" || !int.TryParse(amountToDeposit.Text, out int depositAmount) || depositAmount <= 0)
            {
                MessageBox.Show("Please enter a valid amount to withdrawal.");
                return;
            }

            if (depositAmount > oldBalance)
            {
                MessageBox.Show("The balance cannot be negative.");
                return;
            }

            await ProcessDeposit(depositAmount);
            var home = new SelectTransaction();
            home.Show();
            this.Hide();

        }
        
        private async void Deposit_Load(object sender, EventArgs e)
        {
            await GetBlanceMethod();
        }

        private async void amountToDeposit_TextChanged(object sender, EventArgs e)
        {
            await GetBlanceMethod();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SelectTransaction home = new SelectTransaction();
            home.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void checkId_Click(object sender, EventArgs e)
        {

        }

        private async Task ProcessDeposit(decimal depositAmount)
        {
            if (!semaphore.Wait(0))
            {
                MessageBox.Show("Resource is busy. Try again later.");
                return;
            }
                try
                {
                using(var connection = new SqlConnection(con))
                {
                    
                    newBalance = oldBalance + depositAmount;
                    await connection.OpenAsync();

                    string updateQuery = "UPDATE Users SET Balance = @newBalance WHERE Id = @Acc";
                    SqlCommand updateCmd = new SqlCommand(updateQuery, connection);
                    updateCmd.Parameters.AddWithValue("@newBalance", newBalance);
                    updateCmd.Parameters.AddWithValue("@Acc", Acc);
                    await updateCmd.ExecuteNonQueryAsync();

                    string insertTransactionQuery = "INSERT INTO Transactions (TransactionType, Amount, UserId) VALUES (@TransactionType, @Amount, @UserId)";
                    SqlCommand insertTransactionCmd = new SqlCommand(insertTransactionQuery, connection);
                    insertTransactionCmd.Parameters.AddWithValue("@TransactionType", "Deposit");
                    insertTransactionCmd.Parameters.AddWithValue("@Amount", depositAmount);
                    insertTransactionCmd.Parameters.AddWithValue("@UserId", Acc);
                    await insertTransactionCmd.ExecuteNonQueryAsync();

                }

                    oldBalance = newBalance; // Update the balance in memory
                    BalanceLabel.Text = $"Balance Rs: {oldBalance}";
                    MessageBox.Show("Amount successfully withdrawn and transaction recorded.");
                
            }
                catch (Exception ex)
                {
                this.Invoke(new Action(() =>
                {
                    MessageBox.Show($"Error processing withdrawal: {ex.Message}");
                }));
            }
            finally
            {
                semaphore.Release();
            }
        }
        public async Task GetBlanceMethod()
        {
            
                try
                {
                 using (SqlConnection connection = new SqlConnection(con))
                {
                    await connection.OpenAsync();
                    SqlCommand cmd = new SqlCommand("SELECT Balance FROM Users WHERE Id = @Acc", connection);
                    cmd.Parameters.AddWithValue("@Acc", Acc);

                    SqlDataReader reader = await cmd.ExecuteReaderAsync();
                    if (await reader.ReadAsync())
                    {
                        oldBalance = reader.GetInt32(0);
                        BalanceLabel.Text = $"Balance Rs: {oldBalance}";
                    }

                    await reader.CloseAsync();
                }

            }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error fetching balance: {ex.Message}");
                }
        }


    }
}
