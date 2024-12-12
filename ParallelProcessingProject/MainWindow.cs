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
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void start_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(userIdText.Text) || !int.TryParse(userIdText.Text, out int threadCount) || threadCount <= 0)
            {
                MessageBox.Show("Please enter a valid number of threads.");
                return;
            }
            else
            {
                StartSession(threadCount);
            }
        }

        private void StartSession(int count)
        {
            for (int i =1; i <= count; i++)
            {
                int threadnum = i;
                Task.Run(() =>
                {
                    var loginWindow = new Login(threadnum);
                    Application.Run(Login);
                });
                ThreadsList.Items.Add($"Thread {threadnum} started.");
            }

        }
    }
}
