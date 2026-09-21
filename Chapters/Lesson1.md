# Chapter 1 — Introduction to Visual C#

## Summary

This chapter introduces the basic ideas of Visual C#, Visual Studio, Windows Forms, controls, properties, and event-driven programming.

## 1. Objects

An **object** is a thing in a program that has:

- **Properties** — describe the object.
- **Methods** — actions the object can perform.

## 2. Visual Studio

Visual Studio is the development environment used to create Visual C# applications.

Important parts include:

- **Designer** — used to design the application's interface.
- **Solution Explorer** — shows projects and files.
- **Properties Window** — used to view and change properties.
- **Toolbox** — contains controls that can be added to a form.
- **Toolbar** — provides commonly used commands.

### Toolbox

The **Toolbox** is the parent area that contains controls.

Examples of controls:

- Label
- Button
- PictureBox

## 3. Projects and Solutions

- A **Solution** can contain one or more projects.
- A **Project** contains the files needed for an application.
- Project files include source-code files and other application resources.

## 4. Forms and Controls

A **Form** is the main window of a Windows Forms application.

**Controls** are objects placed on a form to create the user interface.

Examples:

- Label — displays text.
- Button — allows the user to perform an action.
- PictureBox — displays an image.

## 5. Properties Window

The **Properties Window** allows you to view and change properties of a selected form or control.

Examples:

- `Text` — changes the displayed text.
- `Name` — identifies a control in code.
- `TextAlign` — controls text alignment.
- `Visible` — controls whether a control is visible.
- `SizeMode` — controls how an image is displayed in a PictureBox.

### Text Alignment

For a Label or Button, `TextAlign` can be used to position text.

For example:

```text
MiddleCenter
```

places the text in the center.

## 6. Naming Controls

Controls can be given meaningful names so they can be used easily in C# code.

The chapter uses **camelCase** naming.

Example:

```text
answerLabel
```

## 7. C# Code

C# code is organized using:

```text
Namespace
    ↓
Class
    ↓
Method
```

Important files include:

- `Program.cs`
- `Form1.cs`

## 8. Event-Driven Programming

Visual C# applications use **event-driven programming**.

An event happens because of an action, such as clicking a button.

An **event handler** is code that runs when the event occurs.

Example:

```csharp
private void helloButton_Click(object sender, EventArgs e)
{
    MessageBox.Show("Hello World");
}
```

## 9. MessageBox

`MessageBox.Show()` displays a message to the user.

Example:

```csharp
MessageBox.Show("Hello World");
```

## 10. Label Control

A Label displays text on a form.

Its `Text` property can be changed in the Properties Window or in code.

Example:

```csharp
answerLabel.Text = "";
```

## 11. PictureBox

A **PictureBox** is used to display an image.

Important properties include:

- `Image`
- `SizeMode`
- `Visible`




