namespace ParallelProcessingProject
{
    partial class CheckBalance
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
            label5 = new Label();
            panel1 = new Panel();
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // label5
            // 
            label5.BackColor = SystemColors.Highlight;
            label5.Font = new Font("Microsoft New Tai Lue", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(-3, -3);
            label5.Name = "label5";
            label5.Size = new Size(796, 78);
            label5.TabIndex = 7;
            label5.Text = "ATM Management System";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Highlight;
            panel1.Dock = DockStyle.Bottom;
            panel1.ForeColor = SystemColors.Highlight;
            panel1.Location = new Point(0, 436);
            panel1.Name = "panel1";
            panel1.Size = new Size(795, 14);
            panel1.TabIndex = 8;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.GradientActiveCaption;
            button1.Font = new Font("Microsoft YaHei UI", 13.8F, FontStyle.Bold);
            button1.ForeColor = SystemColors.Highlight;
            button1.Location = new Point(435, 385);
            button1.Name = "button1";
            button1.Size = new Size(177, 45);
            button1.TabIndex = 9;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.GradientActiveCaption;
            button2.Font = new Font("Microsoft YaHei UI", 13.8F, FontStyle.Bold);
            button2.ForeColor = SystemColors.Highlight;
            button2.Location = new Point(125, 385);
            button2.Name = "button2";
            button2.Size = new Size(177, 45);
            button2.TabIndex = 9;
            button2.Text = "Log Out";
            button2.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft New Tai Lue", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(113, 124);
            label1.Name = "label1";
            label1.Size = new Size(272, 40);
            label1.TabIndex = 10;
            label1.Text = "Account Number :";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Highlight;
            label2.Location = new Point(453, 137);
            label2.Name = "label2";
            label2.Size = new Size(130, 38);
            label2.TabIndex = 11;
            label2.Text = "Acc Num";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft New Tai Lue", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.Highlight;
            label3.Location = new Point(113, 248);
            label3.Name = "label3";
            label3.Size = new Size(215, 40);
            label3.TabIndex = 10;
            label3.Text = "Your Balance :";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.Highlight;
            label4.Location = new Point(453, 261);
            label4.Name = "label4";
            label4.Size = new Size(140, 38);
            label4.TabIndex = 11;
            label4.Text = "Balane EG";
            label4.Click += label2_Click;
            // 
            // CheckBalance
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(795, 450);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(panel1);
            Controls.Add(label5);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CheckBalance";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CheckBalance";
            Load += CheckBalance_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private Panel panel1;
        private Button button1;
        private Button button2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}