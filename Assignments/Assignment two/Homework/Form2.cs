namespace Homework
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void lblGuest_Click(object sender, EventArgs e)
        {

        }

        private void lblnumNight_Click(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            string Name = txtName.Text;
            string RoomType = "";
            double RatePerNight = 0;
            int Age, Nights, Guests;
            double BreakfastCost = 0;
            double nightDiscountRate = 0;
            double seniorDiscountRate = 0;
            double baseRoomCost = 0;
            double stayDiscountAmount = 0;
            double seniorDiscountAmount = 0;
            double totalCost = 0;
            bool BookingAproved = true;

            this.BookingAproved.Items.Clear();

            // Check name
            if (Name == "")
            {
                MessageBox.Show("Please enter your name.");
                BookingAproved = false;
            }

            // Check age
            if (int.TryParse(txtAge.Text, out Age))
            {
                if (Age < 18 || Age > 90)
                {
                    MessageBox.Show("Age must be between 18 and 90.");
                    BookingAproved = false;
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid age.");
                BookingAproved = false;
            }

            // Check nights
            if (int.TryParse(txtNight.Text, out Nights))
            {
                if (Nights < 1 || Nights > 30)
                {
                    MessageBox.Show("Nights must be between 1 and 30.");
                    BookingAproved = false;
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid number of nights.");
                BookingAproved = false;
            }

            // Check guests
            if (int.TryParse(txtGuests.Text, out Guests))
            {
                if (Guests < 1 || Guests > 6)
                {
                    MessageBox.Show("Guests must be between 1 and 6.");
                    BookingAproved = false;
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid number of guests.");
                BookingAproved = false;
            }

            // Select room using switch
            switch (true)
            {
                case true when rdoStandard.Checked:
                    RoomType = "Standard";
                    RatePerNight = 50;
                    break;

                case true when rdoNormal.Checked:
                    RoomType = "Normal";
                    RatePerNight = 80;
                    break;

                case true when rdoHight.Checked:
                    RoomType = "Hight";
                    RatePerNight = 130;
                    break;

                default:
                    MessageBox.Show("Please select a room type.");
                    BookingAproved = false;
                    break;
            }

            // Check guest capacity
            if (rdoStandard.Checked && Guests > 2)
            {
                MessageBox.Show("Standard room allows a maximum of 2 guests.");
                BookingAproved = false;
            }
            else if (rdoNormal.Checked && Guests > 4)
            {
                MessageBox.Show("Normal room allows a maximum of 4 guests.");
                BookingAproved = false;
            }
            else if (rdoHight.Checked && Guests > 6)
            {
                MessageBox.Show("Hight room allows a maximum of 6 guests.");
                BookingAproved = false;
            }

            // Show results
            if (BookingAproved == true)
            {
                baseRoomCost = RatePerNight * Nights;

                // Stay discount
                if (Nights >= 1 && Nights <= 4)
                {
                    nightDiscountRate = 0;
                }
                else if (Nights >= 5 && Nights <= 9)
                {
                    nightDiscountRate = 0.05;
                }
                else
                {
                    nightDiscountRate = 0.12;
                }

                stayDiscountAmount = baseRoomCost * nightDiscountRate;

                // Senior discount
                if (Age >= 60)
                {
                    seniorDiscountRate = 0.10;
                }
                else
                {
                    seniorDiscountRate = 0;
                }

                seniorDiscountAmount = baseRoomCost * seniorDiscountRate;

                // Breakfast cost
                if (ckBreakFast.Checked)
                {
                    BreakfastCost = 10 * Guests * Nights;
                }
                else
                {
                    BreakfastCost = 0;
                }

                // Calculate final total
                totalCost = baseRoomCost
                            - stayDiscountAmount
                            - seniorDiscountAmount
                            + BreakfastCost;

                // Display booking details
                this.BookingAproved.Items.Add("Booking approved!");
                this.BookingAproved.Items.Add("----------------------------------");
                this.BookingAproved.Items.Add("Guest Name: " + Name);
                this.BookingAproved.Items.Add("Age: " + Age);
                this.BookingAproved.Items.Add("Room Type: " + RoomType);
                this.BookingAproved.Items.Add("Rate Per Night: $" + RatePerNight);
                this.BookingAproved.Items.Add("Nights: " + Nights);
                this.BookingAproved.Items.Add("Guests: " + Guests);
                this.BookingAproved.Items.Add("Room Cost: $" + baseRoomCost);
                this.BookingAproved.Items.Add("Stay Discount: " + (nightDiscountRate * 100) + "%");
                this.BookingAproved.Items.Add("Stay Discount Amount: $" + stayDiscountAmount);
                this.BookingAproved.Items.Add("Senior Discount: " + (seniorDiscountRate * 100) + "%");
                this.BookingAproved.Items.Add("Senior Discount Amount: $" + seniorDiscountAmount);
                this.BookingAproved.Items.Add("Breakfast Cost: $" + BreakfastCost);
                this.BookingAproved.Items.Add("----------------------------------");
                this.BookingAproved.Items.Add(
                    "Final Total: $" + totalCost.ToString("0.00"));
            }
            else
            {
                this.BookingAproved.Items.Add("Booking not approved.");
            }
        }
        private void btnExist_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtAge.Clear();
            txtNight.Clear();
            txtGuests.Clear();
            rdoStandard.Checked = false;
            rdoNormal.Checked = false;
            rdoHight.Checked = false;
            ckBreakFast.Checked = false;
            BookingAproved.Items.Clear();
        }

        private void listBook_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
    }
}