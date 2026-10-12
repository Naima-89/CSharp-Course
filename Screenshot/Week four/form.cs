namespace week_four
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void btnCheck_Click(object sender, EventArgs e)
        {
            double salary;
            int years;

            try
            {
                salary = double.Parse(txtSalary.Text);
                years = int.Parse(txtYears.Text);

                if (salary >= 5000 && years >= 5)
                {
                    txtDecision.Text = "You qualify for a high loan.";
                }
                else if (salary >= 500 && years >= 3)
                {
                    txtDecision.Text = "You qualify for a medium loan.";
                }
                else if (salary >= 200 && years >= 1)
                {
                    txtDecision.Text = "You qualify for a small loan.";
                }
                else
                {
                    txtDecision.Text = "You do not qualify for a loan.";
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Please enter valid numbers. " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDecision.Clear();
            txtSalary.Clear();
            txtYears.Clear();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

