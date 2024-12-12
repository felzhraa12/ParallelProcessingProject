namespace ParallelProcessingProject
{
    partial class SelectTransaction
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectTransaction));
            label1 = new Label();
            button2 = new Button();
            button1 = new Button();
            button3 = new Button();
            button4 = new Button();
            button6 = new Button();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Highlight;
            label1.Font = new Font("Microsoft New Tai Lue", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(0, -1);
            label1.Name = "label1";
            label1.Size = new Size(887, 78);
            label1.TabIndex = 2;
            label1.Text = "Select Your Transaction Please";
            label1.Click += label1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.GradientActiveCaption;
            button2.Font = new Font("Microsoft YaHei UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.Highlight;
            button2.Location = new Point(68, 238);
            button2.Name = "button2";
            button2.Size = new Size(196, 52);
            button2.TabIndex = 4;
            button2.Text = "Deposit";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.GradientActiveCaption;
            button1.Font = new Font("Microsoft YaHei UI", 13.8F, FontStyle.Bold);
            button1.ForeColor = SystemColors.Highlight;
            button1.Location = new Point(68, 308);
            button1.Name = "button1";
            button1.Size = new Size(196, 56);
            button1.TabIndex = 4;
            button1.Text = "Check Balance";
            button1.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.GradientActiveCaption;
            button3.Font = new Font("Microsoft YaHei UI", 13.8F, FontStyle.Bold);
            button3.ForeColor = SystemColors.Highlight;
            button3.Location = new Point(605, 308);
            button3.Name = "button3";
            button3.Size = new Size(205, 56);
            button3.TabIndex = 4;
            button3.Text = "Mini Statement";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.GradientActiveCaption;
            button4.Font = new Font("Microsoft YaHei UI", 13.8F, FontStyle.Bold);
            button4.ForeColor = SystemColors.Highlight;
            button4.Location = new Point(337, 497);
            button4.Name = "button4";
            button4.Size = new Size(177, 45);
            button4.TabIndex = 4;
            button4.Text = "Log out";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button6
            // 
            button6.BackColor = SystemColors.GradientActiveCaption;
            button6.Font = new Font("Microsoft YaHei UI", 13.8F, FontStyle.Bold);
            button6.ForeColor = SystemColors.Highlight;
            button6.Location = new Point(605, 238);
            button6.Name = "button6";
            button6.Size = new Size(205, 52);
            button6.TabIndex = 4;
            button6.Text = "Withdraw";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(270, 95);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(329, 386);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Highlight;
            panel1.Dock = DockStyle.Bottom;
            panel1.ForeColor = SystemColors.Highlight;
            panel1.Location = new Point(0, 561);
            panel1.Name = "panel1";
            panel1.Size = new Size(879, 14);
            panel1.TabIndex = 6;
            panel1.Paint += panel1_Paint;
            // 
            // SelectTransaction
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(879, 575);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Controls.Add(button6);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SelectTransaction";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SelectTransaction";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button2;
        private Button button1;
        private Button button3;
        private Button button4;
        private Button button6;
        private PictureBox pictureBox1;
        private Panel panel1;
    }
}