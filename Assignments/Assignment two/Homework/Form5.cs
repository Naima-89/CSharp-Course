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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void txtid_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {

            // DECLARE ALL VARIABLES 

            string studentName = string.Empty;
            string studentId = string.Empty;
            int numberOfCourses = 0;
            int studyLevel = 0;
            decimal transportFee = 0m;
            decimal feePerCourse = 0m;
            decimal basicTuitionFee = 0m;
            decimal accommodationFee = 120m;
            bool isAccommodationSelected = true;
            bool isTransportSelected = false;
            decimal accommodationTotal = 0m;
            decimal discountAmount = 0m;
            decimal subTotal = 0m;
            decimal finalAmount = 0m;

            // INPUTS & VALIDATION

            studentName = txtName.Text;
            studentId = txtid.Text;

            if (!int.TryParse(txtcourses.Text, out numberOfCourses))
            {
                MessageBox.Show("Please enter a valid numeric value for the number of courses.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtcourses.Focus();
                return;
            }


            if (numberOfCourses < 1 || numberOfCourses > 8)
            {
                MessageBox.Show("Number of courses must be between 1 and 8.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }

            // Validate Study Level (must be between 1 and 4)
            if (!int.TryParse(txtlevel.Text, out studyLevel) || studyLevel < 1 || studyLevel > 4)
            {
                MessageBox.Show("Please enter a valid study level between 1 and 4.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtlevel.Focus();
                return;
            }

            // Parse transport fee input
            decimal.TryParse(textransport.Text, out transportFee);
            isTransportSelected = transportFee > 0;

            // CALCULATIONS

            switch (studyLevel)
            {
                case 1:
                    feePerCourse = 40m; // Year 1: $40
                    break;
                case 2:
                    feePerCourse = 45m; // Year 2: 
                    break;
                case 3:
                    feePerCourse = 50m; // Year 3: $50
                    break;
                case 4:
                    feePerCourse = 55m; // Year 4: $55
                    break;
            }

            // Calculate basic tuition fee
            basicTuitionFee = numberOfCourses * feePerCourse;

            // Accommodation total
            accommodationTotal = isAccommodationSelected ? accommodationFee : 0m;

            // Subtotal before discounts
            subTotal = basicTuitionFee + accommodationTotal + transportFee;


            if (numberOfCourses >= 6)
            {
                discountAmount += basicTuitionFee * 0.10m;
            }


            if (isAccommodationSelected && isTransportSelected && numberOfCourses == 8)
            {
                discountAmount += subTotal * 0.05m;
            }

            // Final registration fee calculation
            finalAmount = subTotal - discountAmount;


            // DISPLAY OUTPUTS

            lblStudentName.Text = "Name : " + studentName;
            lblStudentId.Text = "Id : " + studentId;
            lblCourses.Text = "Number Courses : " + numberOfCourses;
            lblStudyYear.Text = "Study year : " + studyLevel;
            lbltransport.Text = "Transport Fee : " + transportFee.ToString("0.00");
            lblDiscount.Text = "Discount : " + discountAmount.ToString("0.00");
            lblTution.Text = "Tution fee : " + basicTuitionFee.ToString("0.00");
            lblFinalAmount.Text = "Final Amount : " + finalAmount.ToString("0.00");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtid.Clear();
            txtcourses.Clear();
            txtlevel.Clear();
            textransport.Clear();
            lblStudentName.Text = "";
            lblStudentId.Text = "";
            lblCourses.Text = "";
            lblStudyYear.Text = "";
            lbltransport.Text = "";
            lblDiscount.Text = "";
            lblTution.Text = "";
            lblFinalAmount.Text = "";
        }

        private void btnExist_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
