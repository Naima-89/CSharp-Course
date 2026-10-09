Processing Data in C#
A variable is a storage location in memory. Its name identifies the location, and its data type specifies what kind of value it can store.
Numeric Data Types
int stores whole numbers.
double stores numbers that may contain decimal parts.
decimal stores decimal values with greater precision and is commonly used for financial calculations.
int age = 20;
double temperature = 87.6;
decimal price = 28.75m;
A numeric literal is a number written directly in code.
int hoursWorked = 40;
double temperature = 87.6;
decimal payRate = 28.75m;
Integer literals such as 40 are treated as int. Numbers with a decimal point, such as 87.6, are treated as double. Add m or M to a numeric literal to make it a decimal, such as 28.75m. Numeric literals are not surrounded by quotation marks.
Assigning Values to Variables
A value assigned to a variable must be compatible with its data type.
int hoursWorked = 40;       // Valid
int unitsSold = 650m;       // Error: decimal assigned to int
int score = -25.5;          // Error: double assigned to int

double distance = 28.75;    // Valid
double speed = 75;          // Valid
double sales = 6500.0m;     // Error: decimal assigned to double

decimal balance = 9280.73m; // Valid
decimal price = 50;         // Valid
decimal sales = 6500.0;     // Error: double assigned to decimal
A double value cannot be assigned directly to a decimal variable, and a decimal value cannot be assigned directly to a double variable. Use the correct data type or convert the value when necessary.
Type Casting
Casting explicitly converts a value from one data type to another. Write the target type in parentheses before the value.
decimal moneyNumber = 4500m;
int wholeNumber = (int)moneyNumber;

decimal anotherMoneyNumber = 625.70m;
double realNumber = (double)anotherMoneyNumber;
Casting a decimal value to int removes its fractional part.
The var Keyword
The var keyword allows the compiler to determine a local variable's data type from the value assigned to it.
var interestRate = 12.0;       // double
var stockCode = "D465U";       // string
var accountBalance = 1000.0m;  // decimal
A variable declared with var must be initialized when it is declared. The compiler determines its type from that initial value. In this lesson, var is used for local variables declared inside a method.
Arithmetic Operators
C# uses arithmetic operators to perform calculations.
Operator
Meaning
+
Addition
-
Subtraction
*
Multiplication
/
Division
%
Remainder (modulus)
int total = 5 + 4;
A mathematical expression performs a calculation and produces a value.
int x = 5, y = 4;
MessageBox.Show((x + y).ToString());

result = (a + b) / 4;
Follow the normal order of operations. Use parentheses when you need to control the order of calculations.
When an operation uses an int and a double, the int is treated as a double, and the result is a double. When an operation uses an int and a decimal, the int is treated as a decimal, and the result is a decimal. An operation that mixes double and decimal is not allowed directly.
Integer Division
When both values in a division operation are integers, the result is an integer. Any fractional part is discarded.
int x = 7, y = 3;
MessageBox.Show((x / y).ToString()); // Displays 2
To get a fractional result, convert one value to double or use double variables.
int x = 7, y = 3;
MessageBox.Show(((double)x / y).ToString()); // About 2.3333
Reading Numeric Input
Keyboard input from a TextBox is stored as text, even if the user enters a number. Convert the Text property to the required numeric data type before using the input in a calculation.
int hoursWorked = int.Parse(hoursWorkedTextBox.Text);
double temperature = double.Parse(temperatureTextBox.Text);
decimal price = decimal.Parse(priceTextBox.Text);
Common conversion methods include int.Parse(), double.Parse(), and decimal.Parse(). A cast operator cannot directly convert a string to a numeric type. If the entered text is not a valid number, parsing can cause an exception.
Displaying Numeric Values
A control's Text property accepts text. Use ToString() to convert a numeric value to a string before displaying it in a label, text box, or message box.
decimal grossPay = 1550.0m;
grossPayLabel.Text = grossPay.ToString();

int myNumber = 123;
MessageBox.Show(myNumber.ToString());
You can also combine text and a number using the + operator.
int idNumber = 1044;
string output = "Your ID number is " + idNumber;
Formatting Numbers
The ToString() method can format a number to appear in a particular way.
Format
Purpose
Example
"N"
Number format
value.ToString("N3")
"F"
Fixed-point format
value.ToString("F2")
"E"
Exponential format
value.ToString("E3")
"C"
Currency format
value.ToString("C")
"P"
Percentage format
value.ToString("P2")
double price = 12.3;
string formattedPrice = price.ToString("N3"); // 12.300
The exact currency symbol and formatting can depend on the computer's regional settings.
Exception Handling
An exception is an unexpected error that occurs while a program is running. Examples include dividing by zero, trying to open a file that does not exist, or entering invalid data. If an exception is not handled, the program may stop unexpectedly.
Exception handling allows a program to respond to an error instead of stopping unexpectedly. The code that responds to an exception is called an exception handler.
The try-catch Statement
Place statements that might cause an exception inside the try block. Place the statements that respond to the error inside the catch block.
try
{
    // Statements that might cause an exception
}
catch
{
    // Statements that respond to the exception
}
For example, parsing nonnumeric text with double.Parse() can throw an exception.
try
{
    double miles = double.Parse(milesTextBox.Text);
}
catch
{
    MessageBox.Show("Invalid data was entered.");
}
If the user enters text that is not a valid number, the program moves to the catch block and displays an error message.
Throwing means an error occurs and an exception is raised. Catching means the program handles the exception and decides what to do next.
Displaying an Exception Message
An exception object has a Message property that contains a description of the error. Use catch (Exception ex) to access the exception object.
try
{
    // Statements that might cause an exception
}
catch (Exception ex)
{
    MessageBox.Show(ex.Message);
}
Named Constants
A named constant is a name representing a value that cannot be changed while the program is running. Use the const keyword to declare a constant.
const double INTEREST_RATE = 0.129;
Writing constant names in uppercase is a common convention, but it is not required.
