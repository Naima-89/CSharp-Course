namespace week_four
{
    partial class Loan
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
            btnExit = new Button();
            btnClear = new Button();
            btnCheck = new Button();
            txtLoan = new TextBox();
            lblLoan = new Label();
            txtYears = new TextBox();
            txtSalary = new TextBox();
            lblWorked = new Label();
            lblMonthly = new Label();
            SuspendLayout();
            // 
            // btnExit
            // 
            btnExit.Location = new Point(462, 269);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(112, 64);
            btnExit.TabIndex = 26;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(263, 269);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(112, 64);
            btnClear.TabIndex = 25;
            btnClear.Text = "Claer";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // btnCheck
            // 
            btnCheck.Location = new Point(96, 269);
            btnCheck.Name = "btnCheck";
            btnCheck.Size = new Size(112, 64);
            btnCheck.TabIndex = 24;
            btnCheck.Text = "Check\r\nQualification\r\n";
            btnCheck.UseVisualStyleBackColor = true;
            btnCheck.Click += lblCalculate_Click;
            // 
            // txtLoan
            // 
            txtLoan.Location = new Point(244, 148);
            txtLoan.Name = "txtLoan";
            txtLoan.Size = new Size(342, 31);
            txtLoan.TabIndex = 23;
            // 
            // lblLoan
            // 
            lblLoan.AutoSize = true;
            lblLoan.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLoan.Location = new Point(19, 148);
            lblLoan.Name = "lblLoan";
            lblLoan.Size = new Size(140, 25);
            lblLoan.TabIndex = 22;
            lblLoan.Text = "Loan Decition:";
            // 
            // txtYears
            // 
            txtYears.Location = new Point(244, 89);
            txtYears.Name = "txtYears";
            txtYears.Size = new Size(218, 31);
            txtYears.TabIndex = 21;
            // 
            // txtSalary
            // 
            txtSalary.Location = new Point(244, 46);
            txtSalary.Name = "txtSalary";
            txtSalary.Size = new Size(218, 31);
            txtSalary.TabIndex = 20;
            // 
            // lblWorked
            // 
            lblWorked.AutoSize = true;
            lblWorked.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWorked.Location = new Point(19, 89);
            lblWorked.Name = "lblWorked";
            lblWorked.Size = new Size(189, 25);
            lblWorked.TabIndex = 19;
            lblWorked.Text = "Enter years worked:";
            // 
            // lblMonthly
            // 
            lblMonthly.AutoSize = true;
            lblMonthly.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMonthly.Location = new Point(19, 46);
            lblMonthly.Name = "lblMonthly";
            lblMonthly.Size = new Size(202, 25);
            lblMonthly.TabIndex = 18;
            lblMonthly.Text = "Enter monthly salary:";
            // 
            // Loan
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(btnExit);
            Controls.Add(btnClear);
            Controls.Add(btnCheck);
            Controls.Add(txtLoan);
            Controls.Add(lblLoan);
            Controls.Add(txtYears);
            Controls.Add(txtSalary);
            Controls.Add(lblWorked);
            Controls.Add(lblMonthly);
            Name = "Loan";
            Text = "Bonus";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnExit;
        private Button btnClear;
        private Button btnCheck;
        private TextBox txtLoan;
        private Label lblLoan;
        private TextBox txtYears;
        private TextBox txtSalary;
        private Label lblWorked;
        private Label lblMonthly;
    }
}