# C Chapter 2 – Processing Data

## Using Named Constants

A **named constant** is a name that represents a value that cannot change while the program is running.

Use the `const` keyword to declare a constant.

```csharp
const double INTEREST_RATE = 0.129;
```

- `const` declares a constant.
- `double` is the data type.
- `INTEREST_RATE` is the constant name.
- `0.129` is the value.

**Important:** You cannot assign a new value to a constant after it has been declared. Uppercase names are a common convention for constants, but they are not required.

## Declaring Variables as Fields

A **field** is a variable declared inside a class but outside any method.

```csharp
public partial class Form1 : Form
{
    private string name = "Charles";

    public Form1()
    {
        InitializeComponent();
    }

    private void showNameButton_Click(object sender, EventArgs e)
    {
        MessageBox.Show(name);
    }
}
```

- `name` is a field.
- `private` means the field is accessible within its class.
- Different methods in the class can use the field.
- The field is created as part of the form object.

**Difference:** A local variable belongs to a method; a field belongs to a class or class instance.

## The FieldDemo Application

The FieldDemo application demonstrates how a field can be used by multiple event handlers in the same form.

```csharp
private string name = "Charles";
```

The field initially stores `"Charles"`. A button event handler can change it:

```csharp
private void dariusButton_Click(object sender, EventArgs e)
{
    name = "Darius";
}

private void carmenButton_Click(object sender, EventArgs e)
{
    name = "Carmen";
}
```

A different event handler can display the current value:

```csharp
MessageBox.Show(name);
```

**Important:** When one handler changes the field, other methods can access its updated value.

## Field Code: Main Points

The example uses the field `name` and changes it in different button event handlers.

```csharp
private string name = "Charles";

private void showNameButton_Click(object sender, EventArgs e)
{
    MessageBox.Show(name);
}

private void dariusButton_Click(object sender, EventArgs e)
{
    name = "Darius";
}

private void carmenButton_Click(object sender, EventArgs e)
{
    name = "Carmen";
}
```

- The initial value is `"Charles"`.
- Clicking the Darius button changes the value to `"Darius"`.
- Clicking the Carmen button changes the value to `"Carmen"`.
- The Show Name button displays whichever value is currently stored.

## Using the Math Class

The .NET `Math` class provides methods for mathematical calculations.

| Method or constant | Purpose | Example |
|---|---|---|
| `Math.Sqrt(x)` | Returns the square root of `x` | `Math.Sqrt(25)` gives `5` |
| `Math.Pow(x, y)` | Raises `x` to the power of `y` | `Math.Pow(2, 3)` gives `8` |
| `Math.Max(x, y)` | Returns the larger value | `Math.Max(4, 9)` gives `9` |
| `Math.Min(x, y)` | Returns the smaller value | `Math.Min(4, 9)` gives `4` |
| `Math.Round(x)` | Rounds a number to the nearest integer | `Math.Round(4.6)` gives `5` |
| `Math.PI` | Represents pi | Used in circle calculations |
| `Math.E` | Represents the natural logarithm base | Used in mathematical calculations |

Example:

```csharp
double squareRoot = Math.Sqrt(64);
double power = Math.Pow(3, 2);
double larger = Math.Max(10, 20);
```

## More GUI Details: Tab Order

When an application is running, one control on the form has **focus**. The control with focus receives keyboard input.

- Pressing **Tab** moves focus between controls according to the tab order.
- A button with focus may respond when the user presses **Enter**.
- `TabIndex` indicates a control's position in the tab order.
- The tab index starts at `0`.

For example, the first control in the tab order normally has `TabIndex = 0`.

## Setting the Tab Order

To set the tab order in Visual Studio:

1. Open the form in the Windows Forms Designer.
2. Choose **View → Tab Order**.
3. Click each control in the order you want the user to move through them.
4. Finish setting the order.

**Important:** Label controls do not accept keyboard input and cannot receive focus, so their `TabIndex` values are not useful for keyboard navigation.

## Changing Focus with the Focus Method

Use the `Focus()` method to move focus to a control.

Syntax:

```csharp
ControlName.Focus();
```

Example:

```csharp
private void clearButton_Click(object sender, EventArgs e)
{
    nameTextBox.Focus();
}
```

When the Clear button is clicked, the focus moves to `nameTextBox`.

## Assigning Keyboard Access Keys to Buttons

An **access key**, also called a mnemonic, lets a user access a control by pressing **Alt** plus a letter.

To assign an access key, put an ampersand (`&`) before a letter in the button's `Text` property.

Example:

```csharp
button1.Text = "&Exit";
```

The user can press **Alt + E** to activate the button.

- The access key is used with the Alt key.
- Uppercase and lowercase letters are treated the same for access keys.

## Setting Colors

Forms and most controls have a `BackColor` property. Controls that display text also have a `ForeColor` property.

- `BackColor` sets the background color.
- `ForeColor` sets the text color.

Example:

```csharp
messageLabel.BackColor = Color.Black;
messageLabel.ForeColor = Color.Yellow;
```

Color choices in the Properties window may be grouped into:

- **Custom:** a color palette for selecting a color.
- **Web:** colors commonly supported by web browsers.
- **System:** colors defined by Windows.

## Background Images for Forms

A Windows Form has a `BackgroundImage` property, which sets an image behind the controls. You can select an image through the Select Resource window.

The `BackgroundImageLayout` property controls how the image appears in the form.

## Background Image Layout Options

The main `BackgroundImageLayout` options are:

| Option | What it does |
|---|---|
| `None` | Shows the image at its original size, starting at the upper-left corner. |
| `Tile` | Repeats the image to fill the available area. |
| `Center` | Places the image in the center of the form. |
| `Stretch` | Resizes the image to fill the form, which may distort it. |
| `Zoom` | Resizes the image proportionally to fit, keeping its aspect ratio. |

Choose the option that makes the background suitable for the form.

## GroupBoxes versus Panels

A **GroupBox** and a **Panel** are container controls that can hold other controls.

### GroupBox
- Has a border.
- Can display a title through its `Text` property.
- Can group related controls under a heading.

### Panel
- Can hold other controls.
- Does not have a title or a `Text` property.
- Its border appearance can be controlled through `BorderStyle`.

Use a GroupBox when a titled group is helpful. Use a Panel when you need a container without a title.

## Using the Debugger to Locate Logic Errors

A **logic error** occurs when a program runs but produces an incorrect result.

Examples include:
- Using an incorrect mathematical formula.
- Assigning a value to the wrong variable.
- Assigning the wrong value to a variable.

Logic errors can be difficult to find because the application may run without showing an error message. Visual Studio provides debugging tools to help locate them.

## Breakpoints

A **breakpoint** is a selected line of code where the debugger pauses program execution.

When the program reaches a breakpoint:
1. The program pauses.
2. Visual Studio enters **Break mode**.
3. You can inspect variable values and control properties.

Breakpoints help you investigate what the program is doing at a particular point.

## Working with Breakpoints

To use a breakpoint in Visual Studio:

1. Open the code file.
2. Click in the left margin next to the line where you want execution to pause.
3. A red dot indicates the breakpoint.
4. Run the application using the debugger.
5. Perform the action that reaches that line.
6. When execution pauses, inspect the program's state.

Choose a line before or near the code where you suspect the problem occurs.

## Break Mode

**Break mode** is the state in which the debugger has paused the application at a breakpoint.

While in Break mode, you can examine the current values of variables and control properties.

Move the mouse pointer over a variable or property name in the Code Editor to see its current value, when available.

## The Locals and Watch Windows

### Locals window

The **Locals** window displays the variables in the current procedure, including their values and data types.

### Watch window

The **Watch** window displays variables or expressions that you choose to monitor.

You can use these windows to check whether values change as expected while debugging.

To open them, use the Visual Studio menu:

**Debug → Windows → Locals** or **Debug → Windows → Watch**.

## Reading the Locals Window

The Locals window presents information in columns, such as:

- **Name:** the variable or item name.
- **Value:** the current value.
- **Type:** the data type.

For example, a procedure might contain variables named `runner1`, `runner2`, `runner3`, and `average`. The Locals window can show each variable's current value and type.

This makes it easier to see whether a variable contains the value you expect.

## Single-Stepping Through Code

**Single-stepping** means executing a program one statement at a time while using the debugger.

After each statement executes, you can inspect variable values and control properties. This helps identify the statement that causes an incorrect result.

Single-stepping is useful after execution has paused at a breakpoint.

## How to Single-Step

In Visual Studio, you can single-step through code by:

- Pressing **F11**.
- Clicking **Step Into** on the toolbar.
- Choosing **Debug → Step Into** from the menu.

After each step, check the variable values and compare them with the values you expect.

## Quick Revision

- **`const`:** declares a value that cannot be changed.
- **Field:** a variable declared inside a class but outside a method.
- **`Math` class:** provides mathematical methods and constants.
- **Focus:** identifies the control that receives keyboard input.
- **`TabIndex`:** indicates a control's position in the tab order.
- **`Focus()`:** moves focus to a control.
- **`BackColor`:** sets a control's background color.
- **`ForeColor`:** sets a control's text color.
- **`BackgroundImageLayout`:** controls how a form's background image is displayed.
- **GroupBox:** a container that can have a title.
- **Panel:** a container without a title.
- **Logic error:** a mistake that causes incorrect results while the program runs.
- **Breakpoint:** a selected line where execution pauses.
- **Break mode:** the debugger's paused state.
- **Locals window:** displays local variables and their values and types.
- **Watch window:** displays selected variables or expressions.
- **Single-stepping:** executes code one statement at a time.
