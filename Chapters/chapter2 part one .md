 C# Chapter 2 – Processing Data

These notes cover Slides of Chapter 2: Processing Data.

Topics Covered

1. Reading Input with TextBox Controls

- A "TextBox" allows users to enter keyboard input.
- The "Text" property stores the user's input.
- You can clear a TextBox using:

textBox1.Clear();
textBox1.Text = "";
textBox1.Text = string.Empty;

2. Variables

A variable is a storage location in memory.

Syntax:

DataType VariableName;

Example:

string name;

3. Data Types

A data type specifies what type of data a variable can store.

Examples:

- "string"
- "int"
- "double"
- "decimal"

Primitive data types are basic, built-in data types provided by C#.

4. Variable Names

Variable names should be meaningful.

Rules:

- The first character must be a letter or "_".
- Spaces are not allowed.
- Reserved words cannot be used as variable names.

5. String Variables

A "string" stores a combination of characters.

Example:

string university = "Jamhuuriya University";

Display using:

MessageBox.Show(university);

6. String Concatenation

Concatenation means joining strings together.

The "+" operator is used.

Example:

string fullName = firstName + " " + lastName;

You can also combine strings with numbers:

"Total is " + 25.75

7. Local Variables and Scope

A local variable belongs to the method where it is declared.

- Scope = the part of the program where a variable can be accessed.
- Lifetime = the period during which the variable exists in memory.

8. Duplicate Variable Names

Two variables cannot have the same name in the same scope.

However, variables with the same name can exist in different methods.

9. Assignment Compatibility

A value can be assigned to a variable only when the value is compatible with the variable's data type.

Example:

string name = "Nimca";

10. Initializing Variables

A variable must be assigned a value before it can be used.

Example:

string productDescription = "Computer";

Using an unassigned local variable causes a compiler error.

11. Multiple Variables

Multiple variables of the same type can be declared in one statement:

string lastName, firstName, middleName;

---

Example

string fullName;

fullName = firstNameTextBox.Text + " " + lastNameTextBox.Text;

fullNameLabel.Text = fullName;

This example:

1. Declares a string variable.
2. Gets input from two TextBox controls.
3. Combines the names.
4. Displays the result in a Label.

---

Key Terms

Term| Meaning
Variable| Storage location in memory
Data Type| Specifies the type of data a variable can hold
String| A combination of characters
Concatenation| Joining strings together
Scope| Where a variable can be accessed
Lifetime| How long a variable exists in memory
Initialization| Giving a variable its first value
TextBox| Control used to receive keyboard input

