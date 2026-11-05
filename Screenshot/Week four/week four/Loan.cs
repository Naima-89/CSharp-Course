using System;
using System.Windows.Forms;

namespace week_four
{
    public partial class Loan : Form
    {
        ////declare variables for salary and years of work experience
        //private System.Windows.Forms.TextBox txtSalary;
        //private System.Windows.Forms.TextBox txtYears;
        //private System.Windows.Forms.TextBox txtLoan;
        //private System.Windows.Forms.Label lblMonthly;
        //private System.Windows.Forms.Label lblWorked;
        //private System.Windows.Forms.Label lblLoan;
        public Loan()
        {
            InitializeComponent();
        }

        private void lblCalculate_Click (object sender, EventArgs e)
        {
            double salary;
            int years;

            try
            {
                 salary = double.Parse(txtSalary.Text);
                 years = int.Parse(txtYears.Text);

                if (salary >= 5000 && years >= 5)
                {
                    txtLoan.Text = "You qualify for a high loan.";
                }
                else if (salary >= 500 && years >= 3)
                {
                    txtLoan.Text = "You qualify for a medium loan.";
                }
                else if (salary >= 200 && years >= 1)
                {
                    txtLoan.Text = "You qualify for a small loan.";
                }
                else
                {
                    txtLoan.Text = "You do not qualify for a loan.";
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid numbers.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
          
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}