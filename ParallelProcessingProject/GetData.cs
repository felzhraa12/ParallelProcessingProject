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
    public partial class GetData : Form
    {
        public GetData()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ATMDB;Integrated Security=True");

        DataTable table = new DataTable();
        SqlCommand cmd;

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.DataSource = null;
                dataGridView1.Rows.Clear();
                dataGridView1.Refresh();

                con.Open();
                string sql = "SELECT * FROM Transactions WHERE 1=1";
                cmd = new SqlCommand();

                if (dateTimePicker1.Value != null)
                {
                    DateTime selectedDate = dateTimePicker1.Value.Date;
                    sql += " AND CAST(TransactionDate AS DATE) = @date";
                    cmd.Parameters.AddWithValue("@date", selectedDate);
                }
                else
                {
                    sql += "";
                }
                cmd.CommandText = sql;
                cmd.Connection = con;
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                table.Clear();
                adapter.Fill(table);

                dataGridView1.DataSource = table;

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void GetData_Load(object sender, EventArgs e)
        {

        }
        private void UserIdInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkId_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
