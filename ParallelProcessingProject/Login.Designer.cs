namespace ParallelProcessingProject
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            Id = new TextBox();
            Password = new TextBox();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            button2 = new Button();
            checkpassword = new Label();
            checkId = new Label();
            Invalid = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.GradientActiveCaption;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(768, 79);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Highlight;
            label1.Font = new Font("Microsoft New Tai Lue", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(0, 1);
            label1.Name = "label1";
            label1.Size = new Size(775, 78);
            label1.TabIndex = 1;
            label1.Text = "ATM Management System";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft New Tai Lue", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Highlight;
            label2.Location = new Point(626, 79);
            label2.Name = "label2";
            label2.Size = new Size(142, 58);
            label2.TabIndex = 1;
            label2.Text = "Login";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft New Tai Lue", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.Highlight;
            label3.Location = new Point(197, 116);
            label3.Name = "label3";
            label3.Size = new Size(349, 45);
            label3.TabIndex = 1;
            label3.Text = "Identification Number";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft New Tai Lue", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.Highlight;
            label4.Location = new Point(197, 234);
            label4.Name = "label4";
            label4.Size = new Size(161, 45);
            label4.TabIndex = 1;
            label4.Text = "Password";
            label4.Click += label3_Click;
            // 
            // Id
            // 
            Id.Location = new Point(197, 154);
            Id.Multiline = true;
            Id.Name = "Id";
            Id.Size = new Size(489, 52);
            Id.TabIndex = 2;
            Id.TextChanged += Id_TextChanged;
            // 
            // Password
            // 
            Password.Location = new Point(188, 282);
            Password.Multiline = true;
            Password.Name = "Password";
            Password.Size = new Size(489, 50);
            Password.TabIndex = 2;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.GradientActiveCaption;
            button1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.Highlight;
            button1.Location = new Point(245, 380);
            button1.Name = "button1";
            button1.Size = new Size(113, 45);
            button1.TabIndex = 3;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 164);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(160, 196);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.GradientActiveCaption;
            button2.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.Highlight;
            button2.Location = new Point(491, 380);
            button2.Name = "button2";
            button2.Size = new Size(113, 45);
            button2.TabIndex = 3;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // checkpassword
            // 
            checkpassword.AutoSize = true;
            checkpassword.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkpassword.ForeColor = Color.Red;
            checkpassword.Location = new Point(197, 335);
            checkpassword.Name = "checkpassword";
            checkpassword.Size = new Size(217, 23);
            checkpassword.TabIndex = 5;
            checkpassword.Text = "Please enter your Password";
            checkpassword.Visible = false;
            // 
            // checkId
            // 
            checkId.AutoSize = true;
            checkId.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkId.ForeColor = Color.Red;
            checkId.Location = new Point(197, 209);
            checkId.Name = "checkId";
            checkId.Size = new Size(162, 23);
            checkId.TabIndex = 5;
            checkId.Text = "Please enter your Id";
            checkId.Visible = false;
            // 
            // Invalid
            // 
            Invalid.AutoSize = true;
            Invalid.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Invalid.ForeColor = Color.Red;
            Invalid.Location = new Point(330, 335);
            Invalid.Name = "Invalid";
            Invalid.Size = new Size(183, 28);
            Invalid.TabIndex = 6;
            Invalid.Text = "Invalid Credentials !";
            Invalid.Visible = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(768, 437);
            Controls.Add(Invalid);
            Controls.Add(checkId);
            Controls.Add(checkpassword);
            Controls.Add(pictureBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(Password);
            Controls.Add(Id);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Login_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox Id;
        private TextBox Password;
        private Button button1;
        private PictureBox pictureBox1;
        private Button button2;
        private Label checkpassword;
        private Label checkId;
        private Label Invalid;
    }
}