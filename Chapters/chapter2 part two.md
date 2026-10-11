Processing Data in C#

1. Variables and Data Types

A variable is a storage location in memory. Its name identifies the location, and its data type determines what kind of value it can store.

Numeric Data Types

Data Type| Description
"int"| Stores whole numbers
"double"| Stores numbers with decimal parts
"decimal"| Stores precise decimal values, commonly used for money

Example:

int age = 20;
double temperature = 87.6;
decimal price = 28.75m;

---

2. Numeric Literals

A numeric literal is a value written directly in code.

Example:

int hoursWorked = 40;
double temperature = 87.6;
decimal payRate = 28.75m;

Rules:

- "40" is an integer literal.
- "87.6" is a double literal.
- "28.75m" is a decimal literal.
- The suffix "m" or "M" identifies a decimal literal.
- Numeric literals are not enclosed in quotation marks.

---

3. Assigning Values and Data Type Compatibility

A value assigned to a variable must be compatible with its data type.

Valid Assignments

int age = 20;

double distance = 28.75;
double quantity = 10;

decimal salary = 1500.50m;
decimal amount = 100;

Invalid Assignments

int number = 50.5;         // Error
int unitsSold = 650m;      // Error

double sales = 6500.0m;    // Error
decimal balance = 6500.0;  // Error

Important rules:

- An "int" cannot directly store a decimal value.
- An integer can be assigned to a "double" or "decimal".
- A "double" cannot be assigned directly to a "decimal".
- A "decimal" cannot be assigned directly to a "double".

---

4. Type Casting

Type casting explicitly converts a value from one data type to another.

Example 1: Decimal to Integer

decimal amount = 4500.75m;
int wholeNumber = (int)amount;

Result: "4500"

The fractional part is removed, not rounded.

Example 2: Double to Decimal

double number = 25.5;
decimal price = (decimal)number;

The cast operator is written before the value using parentheses containing the target type.

Remember: Casting does not directly convert a string into a numeric type.

---

5. The "var" Keyword

The "var" keyword allows the compiler to determine a local variable's type from its initial value.

Example:

var interestRate = 12.0;       // double
var stockCode = "D465U";       // string
var accountBalance = 1000.0m;  // decimal

Rules:

- A "var" variable must be initialized when declared.
- The compiler determines its type at compile time.
- Its type cannot later be changed to another type.

---

6. Arithmetic Operators

Arithmetic operators perform mathematical calculations.

Operator| Meaning| Example
"+"| Addition| "5 + 4"
"-"| Subtraction| "10 - 3"
"*"| Multiplication| "5 * 4"
"/"| Division| "10 / 2"
"%"| Remainder| "7 % 3"

Example:

int total = 5 + 4;
int difference = 10 - 3;
int product = 5 * 4;
int quotient = 10 / 2;
int remainder = 7 % 3;

Mathematical Expressions

An expression performs a calculation and produces a value.

int x = 5;
int y = 4;

MessageBox.Show((x + y).ToString());

C# follows the normal order of mathematical operations. Parentheses control the order of calculations.

int result = (10 + 6) / 4;

Data type rules:

- "int" combined with "double" produces a "double" result.
- "int" combined with "decimal" produces a "decimal" result.
- "double" and "decimal" cannot be mixed directly in one arithmetic expression.

---

7. Integer Division

When both operands are integers, the result is an integer. Any fractional part is discarded.

Example:

int result = 7 / 3;
MessageBox.Show(result.ToString());

Output:

2

Getting a Decimal Result

Convert at least one operand to "double".

double result = (double)7 / 3;
MessageBox.Show(result.ToString());

Output: Approximately "2.333333"

---

8. Reading Numeric Input

Text entered into a "TextBox" is stored as a string, even when the user enters a number.

Parsing converts that text into the required numeric data type.

Using "int.Parse()"

Converts valid numeric text into an integer.

int hoursWorked = int.Parse(hoursWorkedTextBox.Text);

Using "double.Parse()"

Converts valid numeric text into a double.

double temperature = double.Parse(temperatureTextBox.Text);

Using "decimal.Parse()"

Converts valid numeric text into a decimal.

decimal price = decimal.Parse(priceTextBox.Text);

Important: If the text is invalid, "Parse()" can throw an exception. A cast operator cannot directly convert a string to a number.

---

9. Displaying Values with "ToString()"

The "ToString()" method converts a value into text. It is useful when displaying numeric results in a label, text box, or message box.

Displaying a Number

int myNumber = 123;

MessageBox.Show(myNumber.ToString());

Displaying a Value in a Label

decimal grossPay = 1550.0m;

grossPayLabel.Text = grossPay.ToString();

Combining Text and Numbers

The "+" operator can combine text and numeric values.

int idNumber = 1044;

string output = "Your ID number is " + idNumber;

---

10. Formatting Numbers

The "ToString()" method can format numbers for display.

Format| Purpose| Example
""N""| Number with digit grouping| "value.ToString("N3")"
""F""| Fixed decimal places| "value.ToString("F2")"
""E""| Exponential notation| "value.ToString("E3")"
""C""| Currency| "value.ToString("C")"
""P""| Percentage| "value.ToString("P2")"

Example

double price = 12.3;

string formattedPrice = price.ToString("N3");

Output:

12.300

Remember:

- ""N3"" displays three decimal places with number grouping.
- ""F2"" displays two decimal places.
- ""C"" displays currency formatting.
- ""P2"" displays a percentage with two decimal places.

The currency symbol and some formatting details depend on the computer's regional settings.

---

11. Exception Handling

An exception is an error that occurs while a program is running.

Examples include:

- Entering invalid numeric data.
- Attempting to open a file that does not exist.
- Dividing an integer or decimal value by zero.

Exception handling allows a program to respond to errors instead of stopping unexpectedly.

The "try-catch" Statement

- "try" contains code that might cause an exception.
- "catch" handles the exception if one occurs.

Example:

try
{
    double miles = double.Parse(milesTextBox.Text);
}
catch
{
    MessageBox.Show("Invalid data was entered.");
}

If the user enters invalid numeric text, the program moves to the "catch" block.

Displaying an Exception Message

Use "catch (Exception ex)" to access information about the exception.

try
{
    double miles = double.Parse(milesTextBox.Text);
}
catch (Exception ex)
{
    MessageBox.Show(ex.Message);
}

Important terms:

- Throwing: An exception is raised when an error occurs.
- Catching: The program handles the exception.

---

12. Named Constants

A named constant represents a value that cannot be reassigned after declaration.

Use the "const" keyword to declare a constant.

Example:

const double INTEREST_RATE = 0.129;
const int MAX_HOURS = 40;

Uppercase names are a common convention for constants, but they are not required.


