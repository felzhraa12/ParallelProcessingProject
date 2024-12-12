namespace ParallelProcessingProject
{
    partial class DeleteUser
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
            button2 = new Button();
            DeleteButton = new Button();
            UserIdInput = new TextBox();
            label3 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // button2
            // 
            button2.BackColor = SystemColors.GradientActiveCaption;
            button2.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.Highlight;
            button2.Location = new Point(165, 482);
            button2.Name = "button2";
            button2.Size = new Size(113, 45);
            button2.TabIndex = 15;
            button2.Text = "Previous";
            button2.UseVisualStyleBackColor = false;
            // 
            // DeleteButton
            // 
            DeleteButton.BackColor = SystemColors.GradientActiveCaption;
            DeleteButton.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DeleteButton.ForeColor = SystemColors.Highlight;
            DeleteButton.Location = new Point(454, 482);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(113, 45);
            DeleteButton.TabIndex = 14;
            DeleteButton.Text = "Verify";
            DeleteButton.UseVisualStyleBackColor = false;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // UserIdInput
            // 
            UserIdInput.Location = new Point(31, 247);
            UserIdInput.Multiline = true;
            UserIdInput.Name = "UserIdInput";
            UserIdInput.Size = new Size(489, 52);
            UserIdInput.TabIndex = 13;
            UserIdInput.TextChanged += UserIdInput_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft New Tai Lue", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.Highlight;
            label3.Location = new Point(31, 146);
            label3.Name = "label3";
            label3.Size = new Size(256, 45);
            label3.TabIndex = 12;
            label3.Text = "Deleted User ID";
            label3.Click += label3_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Highlight;
            label1.Font = new Font("Microsoft New Tai Lue", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(0, -2);
            label1.Name = "label1";
            label1.Size = new Size(775, 78);
            label1.TabIndex = 11;
            label1.Text = "ATM Management System";
            // 
            // DeleteUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(765, 592);
            Controls.Add(button2);
            Controls.Add(DeleteButton);
            Controls.Add(UserIdInput);
            Controls.Add(label3);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "DeleteUser";
            Text = "DeleteUser";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private Button DeleteButton;
        private TextBox UserIdInput;
        private Label label3;
        private Label label1;
    }
}