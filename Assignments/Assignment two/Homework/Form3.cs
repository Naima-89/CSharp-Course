using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            string customerName = txtName.Text;
            string vehicleType = "";

            int age, days, experience;
            decimal rate = 0;
            decimal basicCost, discount = 0;
            decimal insuranceCost = 0;
            decimal surcharge = 0;
            decimal finalCost;

            // Check customer name
            if (customerName == "")
            {
                MessageBox.Show("Enter customer name.");
                return;
            }

            // Validate age
            if (!int.TryParse(txtAge.Text, out age))
            {
                MessageBox.Show("Enter a valid age.");
                return;
            }

            if (age < 18 || age > 80)
            {
                MessageBox.Show("Age must be between 18 and 80.");
                return;
            }

            // Validate rental days
            if (!int.TryParse(txtdays.Text, out days))
            {
                MessageBox.Show("Enter valid rental days.");
                return;
            }

            if (days < 1 || days > 30)
            {
                MessageBox.Show("Rental days must be between 1 and 30.");
                return;
            }

            // Validate driving experience
            if (!int.TryParse(txtexperience.Text, out experience))
            {
                MessageBox.Show("Enter valid driving experience.");
                return;
            }

            if (experience < 0)
            {
                MessageBox.Show("Experience cannot be negative.");
                return;
            }

            // Get selected vehicle
            if (rdoEconomy.Checked)
                vehicleType = "Economy";
            else if (rdoSUV.Checked)
                vehicleType = "SUV";
            else if (rdoLuxury.Checked)
                vehicleType = "Luxury";

            // Check rental eligibility
            if (age < 21)
            {
                MessageBox.Show("You must be at least 21 to rent.");
                return;
            }
            else if (experience < 1)
            {
                MessageBox.Show("At least 1 year of experience is required.");
                return;
            }
            else if (vehicleType == "")
            {
                MessageBox.Show("Select a vehicle.");
                return;
            }
            else if (vehicleType == "Luxury" &&
                     (age < 25 || experience < 3))
            {
                MessageBox.Show(
                    "Luxury requires age 25+ and 3 years of experience.");
                return;
            }

            // Set daily rental rate
            if (vehicleType == "Economy")
                rate = 35;
            else if (vehicleType == "SUV")
                rate = 60;
            else if (vehicleType == "Luxury")
                rate = 100;

            // Calculate basic rental cost
            basicCost = rate * days;

            // Calculate discount
            if (days >= 7 && days <= 13)
                discount = basicCost * 0.05m;
            else if (days >= 14)
                discount = basicCost * 0.10m;

            // Add insurance cost
            if (chkInsurance.Checked)
                insuranceCost = 15 * days;

            // Add young-driver surcharge
            if (age >= 21 && age <= 24)
                surcharge = basicCost * 0.10m;

            // Calculate final cost
            finalCost = basicCost - discount
                        + insuranceCost + surcharge;

            // Display results
            lsrental.Items.Clear();
            lsrental.Items.Add("Rental Details:");
            lsrental.Items.Add("-------------------");
            lsrental.Items.Add("Customer Name: " + customerName);
            lsrental.Items.Add("customer Age: " + age);
            lsrental.Items.Add("Rental Days: " + days);
            lsrental.Items.Add("Customer Experience: " + experience + " years");
            lsrental.Items.Add("Vehicle Type: " + vehicleType);
            lsrental.Items.Add("Daily Rate: " + rate.ToString("C2"));
            lsrental.Items.Add("Basic Rental Cost: " +
                                 basicCost.ToString("C2"));
            lsrental.Items.Add("Discount: " + discount.ToString("C2"));
            lsrental.Items.Add("Insurance: " +
                                 insuranceCost.ToString("C2"));
            lsrental.Items.Add("Young Driver Surcharge: " +
                                 surcharge.ToString("C2"));
            lsrental.Items.Add("Final Rental Cost: " +
                                 finalCost.ToString("C2"));
            lsrental.Items.Add("-------------------");
            lsrental.Items.Add("Renatl status: Approved");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtAge.Clear();
            txtdays.Clear();
            txtexperience.Clear();

            rdoEconomy.Checked = false;
            rdoSUV.Checked = false;
            rdoLuxury.Checked = false;
            chkInsurance.Checked = false;
            lsrental.Items.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
