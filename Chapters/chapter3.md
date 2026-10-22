C# Chapter 3 – Making Decisions

Overview

This chapter covers decision structures, logical operators, input validation, RadioButtons, CheckBoxes, switch statements, and ListBox controls in C# Windows Forms.

1. Decision Structures and "if"

A decision structure executes code depending on whether a condition is true or false.

if (sales > 50000)
{
    bonus = 500;
}

Relational Operators

Operator| Meaning
">"| Greater than
"<"| Less than
">="| Greater than or equal to
"<="| Less than or equal to
"=="| Equal to
"!="| Not equal to

2. The "if-else" Statement

Executes one block when a condition is true and another when it is false.

if (age >= 18)
{
    MessageBox.Show("Adult");
}
else
{
    MessageBox.Show("Minor");
}

3. Nested Decision Structures

A nested decision structure places one "if" statement inside another to check multiple conditions.

if (salary >= 30000)
{
    if (years >= 2)
    {
        MessageBox.Show("Loan approved");
    }
}

The "if-else-if" Statement

Used to check multiple conditions in sequence.

if (score >= 90)
{
    grade = "A";
}
else if (score >= 80)
{
    grade = "B";
}
else
{
    grade = "C";
}

4. Logical Operators

Operator| Meaning
"&&"| AND: both conditions must be true
`| 
"!"| NOT: reverses the condition

if (age >= 18 && age <= 60)
{
    MessageBox.Show("Valid age");
}

5. Boolean Variables and Flags

A "bool" variable stores either "true" or "false".

A flag is a variable used to indicate whether a particular condition exists.

bool isValid = true;

6. Comparing Strings

Strings can be compared using "==", "!=", or "String.Compare()".

if (name1 == name2)
{
    MessageBox.Show("Names match");
}

7. Preventing Data Conversion Exceptions

The "TryParse()" method checks whether input can be converted to a specified data type.

Common methods:

- "int.TryParse()"
- "double.TryParse()"
- "decimal.TryParse()"

int age;

if (int.TryParse(txtAge.Text, out age))
{
    MessageBox.Show("Valid number");
}
else
{
    MessageBox.Show("Enter a number");
}

8. Input Validation

Input validation checks whether entered data is acceptable before it is used.

"TryParse()" checks whether the input can be converted. Additional conditions check whether the value is reasonable.

int hours;

if (int.TryParse(txtHours.Text, out hours))
{
    if (hours > 0 && hours <= 168)
    {
        MessageBox.Show("Valid hours");
    }
}

9. Radio Buttons and Check Boxes

RadioButton

Allows the user to select one option from a group.

Important properties:

- "Text"
- "Checked"

if (rdoFirst.Checked)
{
    MessageBox.Show("First option selected");
}

CheckBox

Allows the user to select multiple options.

if (chkBreakfast.Checked)
{
    MessageBox.Show("Breakfast selected");
}

CheckedChanged Event

The "CheckedChanged" event occurs when a RadioButton or CheckBox changes its checked state.

10. The "switch" Statement

The "switch" statement selects a path based on the value of an expression.

- "case": specifies a value to match.
- "break": ends the case.
- "default": handles values that do not match any case.

switch (day)
{
    case 1:
        MessageBox.Show("Monday");
        break;

    case 2:
        MessageBox.Show("Tuesday");
        break;

    default:
        MessageBox.Show("Invalid day");
        break;
}

11. Introduction to ListBox

A "ListBox" displays a list of items and allows the user to select an item.

Important Properties

Property| Purpose
"Text"| Gets the selected text
"Items"| Contains the list items
"Items.Count"| Returns the number of items
"SelectedItem"| Gets the selected item
"SelectedIndex"| Gets the selected item's zero-based index

Adding Items

lstDays.Items.Add("Monday");
lstDays.Items.Add("Tuesday");
lstDays.Items.Add("Wednesday");

Getting the Selected Item

if (lstDays.SelectedIndex != -1)
{
    string day = lstDays.SelectedItem.ToString();
    MessageBox.Show(day);
}

The first item has index "0", the second has index "1", and "-1" means no item is selected.

Removing a Specific Item

lstDays.Items.Remove("Tuesday");

Removing an Item by Index

lstDays.Items.RemoveAt(2);

The index must be valid or an exception will occur.

Clearing All Items

lstDays.Items.Clear();

Summary

- "if" and "if-else" control program decisions.
- Nested decisions check multiple conditions.
- Logical operators combine Boolean expressions.
- Boolean variables store true or false values.
- String comparison checks whether strings match.
- "TryParse()" prevents invalid conversions.
- Input validation checks whether values are acceptable.
- RadioButtons usually allow one choice; CheckBoxes allow multiple choices.
- "switch" selects a case based on a value.
- ListBox controls display, add, select, remove, and clear items.

Source: Starting Out with Visual C#, Sixth Edition — uploaded PowerPoint on Making Decisions.