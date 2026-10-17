namespace week_four
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblSalary = new Label();
            lblYears = new Label();
            txtYears = new TextBox();
            txtSalary = new TextBox();
            btnCheck = new Button();
            lblDecision = new Label();
            btnExit = new Button();
            btnClear = new Button();
            txtDecision = new TextBox();
            SuspendLayout();
            // 
            // lblSalary
            // 
            lblSalary.AutoSize = true;
            lblSalary.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            lblSalary.Location = new Point(28, 47);
            lblSalary.Name = "lblSalary";
            lblSalary.Size = new Size(148, 22);
            lblSalary.TabIndex = 0;
            lblSalary.Text = "Monthly Salary:";
            lblSalary.Click += label1_Click;
            // 
            // lblYears
            // 
            lblYears.AutoSize = true;
            lblYears.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            lblYears.Location = new Point(28, 106);
            lblYears.Name = "lblYears";
            lblYears.Size = new Size(142, 22);
            lblYears.TabIndex = 1;
            lblYears.Text = "Years Worked:";
            // 
            // txtYears
            // 
            txtYears.BorderStyle = BorderStyle.FixedSingle;
            txtYears.Location = new Point(195, 106);
            txtYears.Name = "txtYears";
            txtYears.Size = new Size(204, 31);
            txtYears.TabIndex = 3;
            // 
            // txtSalary
            // 
            txtSalary.BorderStyle = BorderStyle.FixedSingle;
            txtSalary.Location = new Point(195, 43);
            txtSalary.Name = "txtSalary";
            txtSalary.Size = new Size(204, 31);
            txtSalary.TabIndex = 2;
            txtSalary.TextChanged += textBox2_TextChanged;
            // 
            // btnCheck
            // 
            btnCheck.BackColor = SystemColors.InactiveBorder;
            btnCheck.Font = new Font("Segoe UI", 9F);
            btnCheck.Location = new Point(296, 248);
            btnCheck.Name = "btnCheck";
            btnCheck.Size = new Size(123, 71);
            btnCheck.TabIndex = 8;
            btnCheck.Text = "Check Qualification";
            btnCheck.UseVisualStyleBackColor = false;
            btnCheck.Click += btnCheck_Click;
            // 
            // lblDecision
            // 
            lblDecision.AutoSize = true;
            lblDecision.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            lblDecision.Location = new Point(27, 178);
            lblDecision.Name = "lblDecision";
            lblDecision.Size = new Size(143, 22);
            lblDecision.TabIndex = 4;
            lblDecision.Text = "Loan Decision:";
            // 
            // btnExit
            // 
            btnExit.BackColor = SystemColors.InactiveBorder;
            btnExit.Font = new Font("Segoe UI", 9F);
            btnExit.Location = new Point(66, 248);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(123, 71);
            btnExit.TabIndex = 7;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = SystemColors.InactiveBorder;
            btnClear.Font = new Font("Segoe UI", 9F);
            btnClear.Location = new Point(536, 248);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(123, 71);
            btnClear.TabIndex = 8;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // txtDecision
            // 
            txtDecision.BorderStyle = BorderStyle.FixedSingle;
            txtDecision.Location = new Point(195, 178);
            txtDecision.Name = "txtDecision";
            txtDecision.Size = new Size(464, 31);
            txtDecision.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(txtDecision);
            Controls.Add(btnClear);
            Controls.Add(btnExit);
            Controls.Add(lblDecision);
            Controls.Add(btnCheck);
            Controls.Add(txtSalary);
            Controls.Add(txtYears);
            Controls.Add(lblYears);
            Controls.Add(lblSalary);
            Name = "Form1";
            Text = "Loan";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSalary;
        private Label lblYears;
        private TextBox txtYears;
        private TextBox txtSalary;
        private Button btnCheck;
        private Label lblDecision;
        private Button btnExit;
        private Button btnClear;
        private TextBox txtDecision;
    }
}
