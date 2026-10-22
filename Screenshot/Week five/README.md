 # C# Hotel Room Booking System – Week Five

Overview

This project is a Hotel Room Booking System developed using C# Windows Forms. It allows users to enter guest details, select a room type, choose breakfast, validate booking information, and calculate the final room cost.

1. Input Controls

- "txtName" – Enter the guest's name.
- "txtAge" – Enter the guest's age.
- "txtNight" – Enter the number of nights.
- "txtGuests" – Enter the number of guests.
- "rdoStandard" – Select a Standard room.
- "rdoNormal" – Select a Normal room.
- "rdoHight" – Select a High room.
- "ckBreakFast" – Select breakfast.

2. Variables

- "Name" – Stores the guest's name.
- "RoomType" – Stores the selected room type.
- "RatePerNight" – Stores the room price per night.
- "Age", "Nights", "Guests" – Store the guest's age, nights, and number of guests.
- "BreakfastCost" – Stores the total breakfast cost.
- "baseRoomCost" – Stores the room cost before discounts.
- "nightDiscountRate" – Stores the discount rate based on the length of stay.
- "seniorDiscountRate" – Stores the senior discount rate.
- "stayDiscountAmount" – Stores the stay discount amount.
- "seniorDiscountAmount" – Stores the senior discount amount.
- "totalCost" – Stores the final booking cost.
- "BookingAproved" – A Boolean flag indicating whether the booking information is valid.

3. Input Validation

The program checks the following requirements:

- Guest name must not be empty.
- Age must be between 18 and 90.
- Nights must be between 1 and 30.
- Guests must be between 1 and 6.
- A room type must be selected.
- The number of guests must not exceed the room capacity.

The "int.TryParse()" method checks whether age, nights, and guests can be converted into integers.

4. Switch Statement

The "switch" statement selects the room type and assigns its price.

Room Type| Rate Per Night| Maximum Guests
Standard| $50| 2
Normal| $80| 4
High| $130| 6

The selected room is determined using the "Checked" property of each RadioButton.

5. Stay Discount

The discount depends on the number of nights booked.

Number of Nights| Discount
1–4 nights| 0%
5–9 nights| 5%
10–30 nights| 12%

The discount amount is calculated using:

stayDiscountAmount = baseRoomCost * nightDiscountRate;

6. Senior Discount

Guests aged 60 or older receive a 10% senior discount.

if (Age >= 60)
{
    seniorDiscountRate = 0.10;
}
else
{
    seniorDiscountRate = 0;
}

The senior discount amount is calculated using the base room cost.

7. Breakfast Cost

If the breakfast CheckBox is selected, breakfast costs $10 per guest per night.

if (ckBreakFast.Checked)
{
    BreakfastCost = 10 * Guests * Nights;
}

If breakfast is not selected, the breakfast cost is zero.

8. Final Cost Calculation

The final total is calculated by subtracting both discounts from the base room cost and adding breakfast costs.

totalCost = baseRoomCost
            - stayDiscountAmount
            - seniorDiscountAmount
            + BreakfastCost;

The base room cost is calculated as:

baseRoomCost = RatePerNight * Nights;

9. ListBox Output

The "BookingAproved" ListBox displays the booking results.

The "Items.Add()" method displays the guest details, room type, room cost, discounts, breakfast cost, and final total.

BookingAproved.Items.Add("Booking approved!");
BookingAproved.Items.Add("Guest Name: " + Name);
BookingAproved.Items.Add("Final Total: $" + totalCost.ToString("0.00"));

The "Items.Clear()" method removes all existing items before displaying new results.

10. Calculate Button

The "btnCalculate_Click" event runs when the Calculate button is clicked.

It:

1. Reads the input values.
2. Validates the guest information.
3. Checks the selected room type.
4. Checks the room capacity.
5. Calculates room costs and discounts.
6. Adds breakfast costs if selected.
7. Displays the booking results or a rejection message.

11. Clear Button

The "btnClear_Click" event clears the text boxes, deselects the RadioButtons and CheckBox, and clears the ListBox.

12. Exit Button

The "btnExist_Click" event closes the current form using:

this.Close();

C# Concepts Used

- Variables and data types
- "if", "else if", and "else" statements
- "switch" statement
- Logical operators
- Boolean variables
- "int.TryParse()" for input validation
- RadioButtons and CheckBoxes
- Event handling
- ListBox controls
- Arithmetic operations
- String formatting

