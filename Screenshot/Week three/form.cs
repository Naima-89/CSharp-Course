namespace Assignments
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void btnCalculate_Click(object sender, EventArgs e)
        {

            //double const 
            const double SALES_TAX = 7;
            const double amountTips = 15;


            //Declare variables
            string food1, food2;
            double priceFood1, priceFood2;
            double totalAmount, salesTax, tipsAmount, netAmount;

            // try 
            try
            {


                //Read texbox input
                food1 = txtfood1.Text;
                food2 = txtfood2.Text;
                priceFood1 = double.Parse(txtprice1.Text);
                priceFood2 = double.Parse(txtprice2.Text);
                //Calculate total amount, sales tax, tips amount, and net amount
                totalAmount = priceFood1 + priceFood2;
                salesTax = totalAmount * SALES_TAX / 100;
                tipsAmount = totalAmount * amountTips / 100;
                netAmount = totalAmount - salesTax;
                //output the results
                lblSalesTax.Text = salesTax.ToString("C2");
                lblTipAmount.Text = tipsAmount.ToString("C2");
                lblTotalAmount.Text = totalAmount.ToString("C2");
                lblNetAmount.Text = netAmount.ToString("C2");


            }

            catch (FormatException)
            {
                MessageBox.Show("Please enter valid numeric values for price and tip amount.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception )
            {
                MessageBox.Show(
              "Please enter valid numbers.",
              "Error",
              MessageBoxButtons.OK,
              MessageBoxIcon.Error);
            }
        }
private void btnClear_Click_1(object sender, EventArgs e)
        {
            txtfood1.Clear();
            txtprice1.Clear();
            txtfood2.Clear();
            txtprice2.Clear();
            lblSales.Text = "";
            lblTipAmount.Text = "";
            lblTotalAmount.Text = "";
            lblNetAmount.Text = "";

        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtsalestax_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
