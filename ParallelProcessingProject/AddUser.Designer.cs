namespace ParallelProcessingProject
{
    partial class AddUser
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            comboBox1 = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button4 = new Button();
            label5 = new Label();
            label6 = new Label();
            button1 = new Button();
            panel1 = new Panel();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(242, 121);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(247, 40);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(242, 216);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(247, 39);
            textBox2.TabIndex = 0;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(242, 309);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(247, 35);
            textBox3.TabIndex = 0;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "User", "Admin" });
            comboBox1.Location = new Point(242, 415);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(247, 28);
            comboBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Tai Le", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(63, 132);
            label1.Name = "label1";
            label1.Size = new Size(120, 29);
            label1.TabIndex = 2;
            label1.Text = "Username";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Tai Le", 13.8F, FontStyle.Bold);
            label2.ForeColor = SystemColors.Highlight;
            label2.Location = new Point(63, 226);
            label2.Name = "label2";
            label2.Size = new Size(52, 29);
            label2.TabIndex = 2;
            label2.Text = "PIN";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Tai Le", 13.8F, FontStyle.Bold);
            label3.ForeColor = SystemColors.Highlight;
            label3.Location = new Point(63, 315);
            label3.Name = "label3";
            label3.Size = new Size(96, 29);
            label3.TabIndex = 2;
            label3.Text = "Balance";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Tai Le", 13.8F, FontStyle.Bold);
            label4.ForeColor = SystemColors.Highlight;
            label4.Location = new Point(528, 78);
            label4.Name = "label4";
            label4.Size = new Size(85, 29);
            label4.TabIndex = 2;
            label4.Text = "Admin";
            // 
            // button4
            // 
            button4.BackColor = SystemColors.GradientActiveCaption;
            button4.Font = new Font("Microsoft YaHei UI", 13.8F, FontStyle.Bold);
            button4.ForeColor = SystemColors.Highlight;
            button4.Location = new Point(352, 541);
            button4.Name = "button4";
            button4.Size = new Size(177, 45);
            button4.TabIndex = 5;
            button4.Text = "Create";
            button4.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            label5.BackColor = SystemColors.Highlight;
            label5.Font = new Font("Microsoft New Tai Lue", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(3, 0);
            label5.Name = "label5";
            label5.Size = new Size(610, 78);
            label5.TabIndex = 6;
            label5.Text = "ATM Management System";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Tai Le", 13.8F, FontStyle.Bold);
            label6.ForeColor = SystemColors.Highlight;
            label6.Location = new Point(63, 415);
            label6.Name = "label6";
            label6.Size = new Size(61, 29);
            label6.TabIndex = 2;
            label6.Text = "Role";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.GradientActiveCaption;
            button1.Font = new Font("Microsoft YaHei UI", 13.8F, FontStyle.Bold);
            button1.ForeColor = SystemColors.Highlight;
            button1.Location = new Point(26, 541);
            button1.Name = "button1";
            button1.Size = new Size(177, 45);
            button1.TabIndex = 5;
            button1.Text = "Log Out";
            button1.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Highlight;
            panel1.Dock = DockStyle.Bottom;
            panel1.ForeColor = SystemColors.Highlight;
            panel1.Location = new Point(0, 605);
            panel1.Name = "panel1";
            panel1.Size = new Size(612, 14);
            panel1.TabIndex = 7;
            // 
            // AddUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(612, 619);
            Controls.Add(panel1);
            Controls.Add(label5);
            Controls.Add(button1);
            Controls.Add(button4);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label6);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddUser";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddUser";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private ComboBox comboBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button4;
        private Label label5;
        private Label label6;
        private Button button1;
        private Panel panel1;
    }
}