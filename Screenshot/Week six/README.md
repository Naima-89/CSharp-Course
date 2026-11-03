# C# Loop Practice – Windows Forms

Introduction

This project is a practical exercise created using C# Windows Forms in Visual Studio. The purpose of this practice is to understand how loops work in C# and how to display repeated results inside a ListBox using a single Button.

Loops are important in programming because they allow us to execute the same block of code multiple times without writing the same statements repeatedly.

Project Objectives

- Understand the three main types of loops in C#.
- Learn how to repeat statements using different loop structures.
- Practice using conditions inside loops.
- Learn how to display multiple values in a ListBox.
- Understand how a Button click event executes code.
- Improve problem-solving and programming skills.

Topics Covered

1. For Loop

A for loop is used when we know how many times we want to repeat a block of code.

Syntax:

for (initialization; condition; increment)
{
    // Statements
}

Example:

for (int i = 1; i <= 5; i++)
{
    listBox1.Items.Add(i);
}

Notes:

- "int i = 1" initializes the counter.
- "i <= 5" is the condition.
- "i++" increases the counter by one.
- The loop stops when the condition becomes false.

2. While Loop

A while loop repeats a block of code as long as its condition is true.

Syntax:

while (condition)
{
    // Statements
}

Example:

int x = 1;

while (x <= 5)
{
    listBox1.Items.Add(x);
    x++;
}

Notes:

- The variable starts at 1.
- The condition is checked before execution.
- The loop continues while "x" is less than or equal to 5.
- "x++" increases the value after each repetition.
- If the condition is false at the beginning, the loop will not execute.

3. Do While Loop

A do while loop executes the code first and checks the condition afterward.

Syntax:

do
{
    // Statements
}
while (condition);

Example:

int y = 1;

do
{
    listBox1.Items.Add(y);
    y++;
}
while (y <= 5);

Notes:

- The code executes before the condition is checked.
- The condition is checked after each repetition.
- The loop continues while the condition is true.
- A do while loop always executes at least once.

Windows Forms Controls Used

Control| Name| Purpose
Button| btnShow| Executes the loops
ListBox| listBox1| Displays the results

Complete Project Code

using System;
using System.Windows.Forms;

namespace LoopPractice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            // For Loop
            listBox1.Items.Add("FOR LOOP");

            for (int i = 1; i <= 5; i++)
            {
                listBox1.Items.Add(i);
            }

            // While Loop
            listBox1.Items.Add("WHILE LOOP");

            int x = 1;

            while (x <= 5)
            {
                listBox1.Items.Add(x);
                x++;
            }

            // Do While Loop
            listBox1.Items.Add("DO WHILE LOOP");

            int y = 1;

            do
            {
                listBox1.Items.Add(y);
                y++;
            }
            while (y <= 5);
        }
    }
}

Expected Output

When the user clicks the Show button, the ListBox displays:

FOR LOOP
1
2
3
4
5

WHILE LOOP
1
2
3
4
5

DO WHILE LOOP
1
2
3
4
5

