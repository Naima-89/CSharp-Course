C# Windows Forms – Input, Process and Clear

Exercise

This exercise demonstrates input, processing, output, and clearing data in a C# Windows Forms application.

Controls Used

- TextBox: "txtFirstName" — First Name
- TextBox: "txtSecondName" — Second Name
- TextBox: "txtLastName" — Last Name
- Button: "btnConcatenate" — Concatenate
- Button: "btnClear" — Clear
- Label: "lblOutput" — Output

Steps

1. Enter the First Name.
2. Enter the Second Name.
3. Enter the Last Name.
4. Click Concatenate to combine the names.
5. The full name is displayed in the Output Label.
6. Click Clear to remove all entered names and the output.

Concatenate Code

private void btnConcatenate_Click(object sender, EventArgs e)
{
    string firstName, secondName, lastName, fullName;

    firstName = txtFirstName.Text;
    secondName = txtSecondName.Text;
    lastName = txtLastName.Text;

    fullName = firstName + " " + secondName + " " + lastName;

    lblOutput.Text = fullName;
}

Clear Code

private void btnClear_Click(object sender, EventArgs e)
{
    txtFirstName.Clear();
    txtSecondName.Clear();
    txtLastName.Clear();
    lblOutput.Text = "";
}

Example

Input:

First Name: Nimca
Second Name: Sugaal
Last Name: mohamud

Output:

Nimca Sugaal mohamud

After clicking Clear, all TextBoxes and the Output Label become empty.

Program Flow

Input → Variables → Process → Output
                    ↓
                  Clear