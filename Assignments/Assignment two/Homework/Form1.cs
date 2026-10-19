namespace Homework
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // Ticket prices
            decimal firstClassPrice = 500m;
            decimal normalClassPrice = 200m;
            decimal businessClassPrice = 350m;

            // Get passenger name
            string name = txtName.Text;
            int age, tickets;
            decimal baggage;

            // Check passenger name
            if (name == "")
            {
                MessageBox.Show("Enter passenger name.");
                return;
            }

            // Validate numeric inputs
            if (!int.TryParse(txtAge.Text, out age) ||
                !int.TryParse(txtTicket.Text, out tickets) ||
                !decimal.TryParse(txtWeight.Text, out baggage))
            {
                MessageBox.Show("Enter valid numeric values.");
                return;
            }

            // Validate age
            if (age < 1 || age > 100)
            {
                MessageBox.Show("Age must be between 1 and 100.");
                return;
            }

            // Validate tickets
            if (tickets < 1 || tickets > 5)
            {
                MessageBox.Show("Tickets must be between 1 and 5.");
                return;
            }

            // Validate baggage
            if (baggage < 0 || baggage > 50)
            {
                MessageBox.Show("Baggage must be between 0 and 50 kg.");
                return;
            }

            // Check travel class selection
            if (!rdoFirst.Checked &&
                !rdoBussines.Checked &&
                !rdoNormal.Checked)
            {
                MessageBox.Show("Please select a travel class.");
                return;
            }

            // Children cannot book First Class
            if (age < 12 && rdoFirst.Checked)
            {
                MessageBox.Show(
                    "Passengers below 12 cannot book First Class.");
                return;
            }

            // Select ticket price and class
            decimal price;
            string travelClass;

            if (rdoFirst.Checked)
            {
                price = firstClassPrice;
                travelClass = "First Class";
            }
            else if (rdoBussines.Checked)
            {
                price = businessClassPrice;
                travelClass = "Business Class";
            }
            else
            {
                price = normalClassPrice;
                travelClass = "Normal Class";
            }

            // Calculate basic ticket cost
            decimal basicCost = price * tickets;
            decimal discount = 0;

            // Ticket discount
            if (tickets == 5)
            {
                discount = basicCost * 0.10m;
            }
            else if (tickets >= 3)
            {
                discount = basicCost * 0.05m;
            }

            // Age discount
            decimal remaining = basicCost - discount;

            if (age < 12)
            {
                discount += remaining * 0.20m;
            }
            else if (age >= 60)
            {
                discount += remaining * 0.10m;
            }

            // Baggage above 20 kg costs $10 per kg per ticket
            decimal baggageCost =
                Math.Max(0, baggage - 20) * 10 * tickets;

            // Insurance costs $25 per ticket
            decimal insuranceCost = 0;

            if (ckTravel.Checked)
            {
                insuranceCost = 25 * tickets;
            }

            // Calculate final cost
            decimal total = basicCost - discount
                            + baggageCost + insuranceCost;

            // Display results 
            BookingDetails.Items.Clear();

            BookingDetails.Items.Add("AIRLINE TICKET BOOKING DETAILS");
            BookingDetails.Items.Add("----------------------------------");
            BookingDetails.Items.Add("Passenger Name: " + name);
            BookingDetails.Items.Add("Passenger Age: " + age);
            BookingDetails.Items.Add("Number of Tickets: " + tickets);
            BookingDetails.Items.Add("Travel Class: " + travelClass);
            BookingDetails.Items.Add(
                "Price per Ticket: $" + price.ToString("0.00"));
            BookingDetails.Items.Add(
                "Basic Ticket Cost: $" + basicCost.ToString("0.00"));
            BookingDetails.Items.Add(
                "Total Discount: $" + discount.ToString("0.00"));
            BookingDetails.Items.Add(
                "Baggage Cost: $" + baggageCost.ToString("0.00"));
            BookingDetails.Items.Add(
                "Insurance Cost: $" + insuranceCost.ToString("0.00"));
            BookingDetails.Items.Add("----------------------------------");
            BookingDetails.Items.Add(
                "TOTAL COST: $" + total.ToString("0.00"));
            BookingDetails.Items.Add("Booking Status: APPROVED");
        }

       
       
       

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtAge.Clear();
            txtTicket.Clear();
            txtWeight.Clear();
            rdoFirst.Checked = false;
            rdoNormal.Checked = false;
            rdoBussines.Checked = false;
            ckTravel.Checked = false;
            BookingDetails.Items.Clear();

        }
        private void btnExist_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}


