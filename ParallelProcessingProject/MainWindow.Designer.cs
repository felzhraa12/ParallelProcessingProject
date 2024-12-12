namespace ParallelProcessingProject
{
    partial class MainWindow
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
            userIdText = new TextBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            start = new Button();
            ThreadsList = new ListBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // userIdText
            // 
            userIdText.Location = new Point(21, 188);
            userIdText.Multiline = true;
            userIdText.Name = "userIdText";
            userIdText.Size = new Size(264, 27);
            userIdText.TabIndex = 17;
            // 
            // start
            // 
            start.BackColor = SystemColors.GradientActiveCaption;
            start.ForeColor = SystemColors.Highlight;
            start.Location = new Point(171, 307);
            start.Name = "start";
            start.Size = new Size(125, 29);
            start.TabIndex = 18;
            start.Text = "Start Session";
            start.UseVisualStyleBackColor = false;
            start.Click += start_Click;
            // 
            // ThreadsList
            // 
            ThreadsList.FormattingEnabled = true;
            ThreadsList.Location = new Point(316, 155);
            ThreadsList.Name = "ThreadsList";
            ThreadsList.Size = new Size(150, 104);
            ThreadsList.TabIndex = 19;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Red;
            label1.Location = new Point(21, 219);
            label1.Name = "label1";
            label1.Size = new Size(223, 20);
            label1.TabIndex = 20;
            label1.Text = "Enter Number of Threads to Test";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.Highlight;
            label2.Font = new Font("Microsoft Sans Serif", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(480, 42);
            label2.TabIndex = 21;
            label2.Text = "ATM Management System";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.Highlight;
            label3.Location = new Point(110, 80);
            label3.Name = "label3";
            label3.Size = new Size(238, 29);
            label3.TabIndex = 22;
            label3.Text = "Test Multithreading";
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(478, 365);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(ThreadsList);
            Controls.Add(start);
            Controls.Add(userIdText);
            Name = "MainWindow";
            Text = "MainWindow";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox userIdText;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button start;
        private ListBox ThreadsList;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}