# Loan Qualification

Objective

Practice using C# Windows Forms to check whether an employee qualifies for a loan based on annual salary and years worked at their current job.

Controls Used

- Label: Displays text for each input and result.
- TextBox: Accepts annual salary and years worked and displays the loan decision.
- Button: Checks qualification, clears fields, or exits the application.


Variables

- "salary" – stores the annual salary.
- "years" – stores the number of years worked.

Programming Concepts

1. Variable Declaration

Variables are declared before assigning values.

double salary;
int years;

2. Try and Catch

The "try" block contains code that may cause an exception. The "catch" block handles invalid input or other errors.

try
{
    salary = double.Parse(txtSalary.Text);
    years = int.Parse(txtYears.Text);
}
catch (FormatException)
{
    MessageBox.Show("Please enter valid numbers.");
}

3. If, Else If, and Else

Conditional statements check the salary and years worked to determine the loan decision.

- Salary of at least $50,000 and 5 years worked: high loan qualification.
- Salary of at least $30,000 and 3 years worked: medium loan qualification.
- Salary of at least $20,000 and 1 year worked: small loan qualification.
- Otherwise, the applicant does not qualify.

These are example rules for practice, not actual bank requirements.

4. Button Click Events

- Check Qualification: Evaluates the entered values.
- Clear: Clears the text boxes and resets the form.
- Exit: Closes the application.

Tab Order

"TabIndex" determines the order in which controls receive focus when the user presses the Tab key.

Conclusion

This practice helps develop skills in Windows Forms design, variables, data conversion, conditional statements, exception handling, and button click events.