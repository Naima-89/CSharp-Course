using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignments
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // Get input values
            string foodName1 = food1.Text;
            string foodName2 = food2.Text;

            double price1 = double.Parse(txtprice1.Text);
            double price2 = double.Parse(txtprice2.Text);
            double tipVat = double.Parse(txtvat.Text);

            // Calculate sales tax (7%)
            const double SALES_TAX = 0.07;

            double subtotal = price1 + price2;
            double salesTax = subtotal * SALES_TAX;
            double tipAmount = subtotal * tipVat / 100;
            double totalAmount = subtotal + salesTax + tipAmount;
            double netAmount = totalAmount-salesTax;

            // Display results
            txtsales.Text = salesTax.ToString("F2");
            txtTip.Text = tipAmount.ToString("F2");
            txtTotalAmount.Text = totalAmount.ToString("F2");
            txtNetAmount.Text = netAmount.ToString("F2");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {

            txtfood1.Clear();
            txtfood2.Clear();   
            txtprice1.Clear();
            txtprice2.Clear();
            txtvat.Clear();
            txtsales.Clear();
            txtTip.Clear();
            txtTotalAmount.Clear(); 
            txtNetAmount.Clear();
            
        }
    }
}
