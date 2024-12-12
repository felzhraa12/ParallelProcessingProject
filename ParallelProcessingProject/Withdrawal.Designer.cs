
namespace ParallelProcessingProject
{
    partial class Withdrawal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Withdrawal));
            pictureBox1 = new PictureBox();
            button2 = new Button();
            WithdrawalSubmit = new Button();
            checkId = new Label();
            Withdrawaltext = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            withdrawalLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(555, 129);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(197, 196);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.GradientActiveCaption;
            button2.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.Highlight;
            button2.Location = new Point(170, 430);
            button2.Name = "button2";
            button2.Size = new Size(113, 45);
            button2.TabIndex = 18;
            button2.Text = "Previous";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // WithdrawalSubmit
            // 
            WithdrawalSubmit.BackColor = SystemColors.GradientActiveCaption;
            WithdrawalSubmit.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            WithdrawalSubmit.ForeColor = SystemColors.Highlight;
            WithdrawalSubmit.Location = new Point(469, 430);
            WithdrawalSubmit.Name = "WithdrawalSubmit";
            WithdrawalSubmit.Size = new Size(113, 45);
            WithdrawalSubmit.TabIndex = 17;
            WithdrawalSubmit.Text = "Verify";
            WithdrawalSubmit.UseVisualStyleBackColor = false;
            WithdrawalSubmit.Click += WithdrawalSubmit_Click;
            // 
            // checkId
            // 
            checkId.AutoSize = true;
            checkId.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkId.ForeColor = Color.Red;
            checkId.Location = new Point(44, 351);
            checkId.Name = "checkId";
            checkId.Size = new Size(368, 23);
            checkId.TabIndex = 16;
            checkId.Text = "Please enter the amount you want to withdraw";
            checkId.Visible = false;
            // 
            // Withdrawaltext
            // 
            Withdrawaltext.Location = new Point(44, 273);
            Withdrawaltext.Multiline = true;
            Withdrawaltext.Name = "Withdrawaltext";
            Withdrawaltext.Size = new Size(489, 52);
            Withdrawaltext.TabIndex = 15;
            Withdrawaltext.TextChanged += Withdrawaltext_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft New Tai Lue", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.Highlight;
            label3.Location = new Point(44, 212);
            label3.Name = "label3";
            label3.Size = new Size(141, 45);
            label3.TabIndex = 14;
            label3.Text = "Amount";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft New Tai Lue", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Highlight;
            label2.Location = new Point(209, 91);
            label2.Name = "label2";
            label2.Size = new Size(266, 58);
            label2.TabIndex = 13;
            label2.Text = "Withdrawal";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Highlight;
            label1.Font = new Font("Microsoft New Tai Lue", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(-1, 0);
            label1.Name = "label1";
            label1.Size = new Size(775, 78);
            label1.TabIndex = 12;
            label1.Text = "ATM Management System";
            // 
            // withdrawalLabel
            // 
            withdrawalLabel.AutoSize = true;
            withdrawalLabel.Font = new Font("Microsoft New Tai Lue", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            withdrawalLabel.ForeColor = SystemColors.Highlight;
            withdrawalLabel.Location = new Point(198, 149);
            withdrawalLabel.Name = "withdrawalLabel";
            withdrawalLabel.Size = new Size(277, 45);
            withdrawalLabel.TabIndex = 20;
            withdrawalLabel.Text = "Available Balance";
            withdrawalLabel.Click += label4_Click;
            // 
            // Withdrawal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(774, 516);
            Controls.Add(withdrawalLabel);
            Controls.Add(pictureBox1);
            Controls.Add(button2);
            Controls.Add(WithdrawalSubmit);
            Controls.Add(checkId);
            Controls.Add(Withdrawaltext);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Withdrawal";
            Text = "Withdrawal";
            Load += Withdrawal_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void TestConcurrencyButton_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button button2;
        private Button WithdrawalSubmit;
        private Label checkId;
        private TextBox Withdrawaltext;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label withdrawalLabel;
    }
}