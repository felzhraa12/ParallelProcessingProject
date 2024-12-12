namespace ParallelProcessingProject
{
    partial class Deposit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Deposit));
            label1 = new Label();
            label2 = new Label();
            checkId = new Label();
            amountToDeposit = new TextBox();
            label3 = new Label();
            nextDeposit = new Button();
            button2 = new Button();
            pictureBox1 = new PictureBox();
            BalanceLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Highlight;
            label1.Font = new Font("Microsoft New Tai Lue", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(0, -1);
            label1.Name = "label1";
            label1.Size = new Size(775, 78);
            label1.TabIndex = 2;
            label1.Text = "ATM Management System";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft New Tai Lue", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Highlight;
            label2.Location = new Point(272, 103);
            label2.Name = "label2";
            label2.Size = new Size(184, 58);
            label2.TabIndex = 3;
            label2.Text = "Deposit";
            // 
            // checkId
            // 
            checkId.AutoSize = true;
            checkId.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkId.ForeColor = Color.Red;
            checkId.Location = new Point(31, 382);
            checkId.Name = "checkId";
            checkId.Size = new Size(355, 23);
            checkId.TabIndex = 8;
            checkId.Text = "Please enter the amount you want to deposit";
            checkId.Visible = false;
            checkId.Click += checkId_Click;
            // 
            // amountToDeposit
            // 
            amountToDeposit.Location = new Point(31, 327);
            amountToDeposit.Multiline = true;
            amountToDeposit.Name = "amountToDeposit";
            amountToDeposit.Size = new Size(489, 52);
            amountToDeposit.TabIndex = 7;
            amountToDeposit.TextChanged += amountToDeposit_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft New Tai Lue", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.Highlight;
            label3.Location = new Point(31, 279);
            label3.Name = "label3";
            label3.Size = new Size(141, 45);
            label3.TabIndex = 6;
            label3.Text = "Amount";
            label3.Click += label3_Click;
            // 
            // nextDeposit
            // 
            nextDeposit.BackColor = SystemColors.GradientActiveCaption;
            nextDeposit.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nextDeposit.ForeColor = SystemColors.Highlight;
            nextDeposit.Location = new Point(454, 483);
            nextDeposit.Name = "nextDeposit";
            nextDeposit.Size = new Size(113, 45);
            nextDeposit.TabIndex = 9;
            nextDeposit.Text = "Verify";
            nextDeposit.UseVisualStyleBackColor = false;
            nextDeposit.Click += nextDeposit_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.GradientActiveCaption;
            button2.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.Highlight;
            button2.Location = new Point(165, 483);
            button2.Name = "button2";
            button2.Size = new Size(113, 45);
            button2.TabIndex = 10;
            button2.Text = "Previous";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(553, 198);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(197, 196);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // BalanceLabel
            // 
            BalanceLabel.AutoSize = true;
            BalanceLabel.Font = new Font("Microsoft New Tai Lue", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BalanceLabel.ForeColor = SystemColors.Highlight;
            BalanceLabel.Location = new Point(224, 175);
            BalanceLabel.Name = "BalanceLabel";
            BalanceLabel.Size = new Size(277, 45);
            BalanceLabel.TabIndex = 21;
            BalanceLabel.Text = "Available Balance";
            // 
            // Deposit
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(775, 586);
            Controls.Add(BalanceLabel);
            Controls.Add(pictureBox1);
            Controls.Add(button2);
            Controls.Add(nextDeposit);
            Controls.Add(checkId);
            Controls.Add(amountToDeposit);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Deposit";
            Text = "Deposit";
            Load += Deposit_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label checkId;
        private TextBox amountToDeposit;
        private Label label3;
        private Button nextDeposit;
        private Button button2;
        private PictureBox pictureBox1;
        private Label BalanceLabel;
    }
}