Food Cost Calculator

A C# Windows Forms application that calculates food costs, sales tax, and tips.

---

About the Project

The Food Cost Calculator allows users to enter two food items and their prices, calculate the total cost, and display the results.

---

Features

- Calculate the total cost of two food items.
- Calculate 7% sales tax.
- Calculate a 15% tip.
- Display amounts in currency format.
- Handle invalid numeric input.
- Clear input fields and results.
- Close the application.

---


Variables and Constants

Variables store food names, prices, and calculation results.

Constants define fixed values, such as the sales tax and tip rates.

const double SALES_TAX = 7;
const double amountTips = 15;

string food1, food2;
double priceFood1, priceFood2;
double totalAmount, salesTax, tipsAmount, netAmount;

---

Input Handling

The "Text" property reads values from text boxes, while "double.Parse()" converts price inputs into numbers.

food1 = txtfood1.Text;
food2 = txtfood2.Text;

priceFood1 = double.Parse(txtprice1.Text);
priceFood2 = double.Parse(txtprice2.Text);

---

Calculations

Total Amount

Adds the prices of both food items.

totalAmount = priceFood1 + priceFood2;

Sales Tax

Calculates 7% of the total amount.

salesTax = totalAmount * SALES_TAX / 100;

Tip Amount

Calculates 15% of the total amount.

tipsAmount = totalAmount * amountTips / 100;

---

Output Formatting

"ToString("C2")" displays values in currency format with two decimal places.

lblTotalAmount.Text = totalAmount.ToString("C2");

lblSalesTax.Text = salesTax.ToString("C2");

lblTipAmount.Text = tipsAmount.ToString("C2");

lblNetAmount.Text = netAmount.ToString("C2");

---

Exception Handling

The "try-catch" statement handles invalid input and prevents the application from crashing when an error occurs.

"MessageBox.Show()" displays an error message to the user.

---

Button Functions

- Calculate Button: Performs calculations and displays the results.
- Clear Button: Clears the text boxes and output labels.
- Close Button: Closes the current form using "this.Close()".

---


Learning Outcomes

- Declaring variables and constants.
- Reading and converting user input.
- Performing arithmetic calculations.
- Formatting currency output.
- Handling exceptions.
- Using Windows Forms controls and button events.

---

Developed using C# and Windows Forms.
