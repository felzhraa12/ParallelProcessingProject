namespace ParallelProcessingProject
{
    partial class GetData
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
            getButton = new Button();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            dateTimePicker1 = new DateTimePicker();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // getButton
            // 
            getButton.BackColor = SystemColors.GradientActiveCaption;
            getButton.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            getButton.ForeColor = SystemColors.Highlight;
            getButton.Location = new Point(331, 515);
            getButton.Name = "getButton";
            getButton.Size = new Size(113, 45);
            getButton.TabIndex = 16;
            getButton.Text = "Apply";
            getButton.UseVisualStyleBackColor = false;
            getButton.Click += DeleteButton_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Highlight;
            label1.Font = new Font("Microsoft New Tai Lue", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(-4, 0);
            label1.Name = "label1";
            label1.Size = new Size(775, 78);
            label1.TabIndex = 15;
            label1.Text = "ATM Management System";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(49, 115);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(646, 227);
            dataGridView1.TabIndex = 17;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(62, 408);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 19;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Red;
            label2.Location = new Point(62, 438);
            label2.Name = "label2";
            label2.Size = new Size(201, 20);
            label2.TabIndex = 20;
            label2.Text = "Choose The Transaction Date";
            label2.Click += label2_Click;
            // 
            // GetData
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(771, 627);
            Controls.Add(label2);
            Controls.Add(dateTimePicker1);
            Controls.Add(dataGridView1);
            Controls.Add(getButton);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "GetData";
            Text = "GetData";
            Load += GetData_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button getButton;
        private Label label1;
        private DataGridView dataGridView1;
        private DateTimePicker dateTimePicker1;
        private Label label2;
    }
}