 ToString, Parse, and Try-Catch

1. ToString()

"ToString()" converts a value into a string (text).

Example:

int age = 20;
string result = age.ToString();

Console.WriteLine(result);

Use: To convert numbers or other values into text.

2. Parse()

"Parse()" converts a string into a specified data type, such as "int" or "double".

Example:

string number = "100";
int result = int.Parse(number);

Console.WriteLine(result + 10);

Output:

110

Use: To convert text into a number for calculations.

Note: "Parse()" throws an exception if the input is invalid.

3. Try-Catch

"try-catch" handles exceptions that occur while a program is running.

Example:

try
{
    int number = int.Parse("abc");
    Console.WriteLine(number);
}
catch (FormatException)
{
    Console.WriteLine("Invalid number");
}

Output:

Invalid number

Use: To handle errors and prevent unhandled exceptions from terminating the program.

- "try": Contains code that may cause an exception.
- "catch": Handles the specified exception.

Summary

Concept| Purpose
"ToString()"| Converts a value to text.
"Parse()"| Converts text to a specified data type.
"try-catch"| Handles exceptions.