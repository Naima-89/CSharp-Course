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

            //double const SALES_TAX 
            const double SALES_TAX = 7;


            //Declare variables
            string food1, food2;
            double priceFood1, priceFood2;
            double amountTips;
            double totalAmount, salesTax, tipsAmount, netAmount;

            // try 
            try
            {


                //Read texbox input
                food1 = txtfood1.Text;
                food2 = txtfood2.Text;
                priceFood1 = double.Parse(txtprice1.Text);
                priceFood2 = double.Parse(txtprice2.Text);
                amountTips = double.Parse(txtAmountTip.Text);
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
        //Clear input
            txtfood1.Clear();
            txtprice1.Clear();
            txtfood2.Clear();
            txtprice2.Clear();
            txtAmountTip.Clear();
            lblSales.Text = "";
            lblTipAmount.Text = "";
            lblTotalAmount.Text = "";
            lblNetAmount.Text = "";

        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
        // Close the form
            this.Close();
        }

        private void txtsalestax_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
