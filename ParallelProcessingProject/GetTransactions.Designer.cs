namespace ParallelProcessingProject
{
    partial class GetTransactions
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            dateTimePicker1 = new DateTimePicker();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Highlight;
            label1.Font = new Font("Microsoft New Tai Lue", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(1, -2);
            label1.Name = "label1";
            label1.Size = new Size(775, 78);
            label1.TabIndex = 16;
            label1.Text = "ATM Management System";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Red;
            label2.Location = new Point(46, 386);
            label2.Name = "label2";
            label2.Size = new Size(201, 20);
            label2.TabIndex = 23;
            label2.Text = "Choose The Transaction Date";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(46, 356);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 22;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(46, 93);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(646, 227);
            dataGridView1.TabIndex = 21;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.GradientActiveCaption;
            button1.ForeColor = SystemColors.Highlight;
            button1.Location = new Point(315, 434);
            button1.Name = "button1";
            button1.Size = new Size(111, 41);
            button1.TabIndex = 24;
            button1.Text = "Apply";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // GetTransactions
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(775, 508);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(dateTimePicker1);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Name = "GetTransactions";
            Text = "GetTransactions";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private DateTimePicker dateTimePicker1;
        private DataGridView dataGridView1;
        private Button button1;
    }
}