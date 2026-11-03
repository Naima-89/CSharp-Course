# Chapter 4 Study Notes: Loops, Files, and Random Numbers

---

## 5.1 The `while` Loop

### Concept & Overview
* The `while` loop repeats a statement or set of statements as long as a specified Boolean expression evaluates to `true`.
* **Basic Structure:**
  1. **Boolean Expression:** Evaluated before every iteration.
  2. **Body:** Statement(s) executed repeatedly as long as the condition is `true`.

### Syntax
```csharp
while (BooleanExpression)
{
    // Statements to repeat
}
```

* **While Clause:** The first line (`while (BooleanExpression)`).
* **Loop Body:** The statements contained within curly braces `{}`.
* **Iteration:** Each complete execution of the loop body is called an *iteration*.
* **Counter Variables:** Used to track how many times a loop executes.

### Pretest Loop Behavior
* The `while` loop is a **pretest loop**, meaning it evaluates its Boolean expression *before* executing the body.
* **Initialization Requirement:** To ensure the loop runs at least once, variables inside the condition must be initialized appropriately beforehand.
* If the condition starts as `false`, the loop body will not execute at all.

#### Example (Executes 5 times):
```csharp
int count = 0;
while (count < 5)
{
    MessageBox.Show("Hello");
    count = count + 1; // Incrementing counter
}
```

#### Example (Executes 0 times):
```csharp
int count = 5;
while (count < 5)
{
    MessageBox.Show("Hello");
    count = count + 1;
}
```

### Infinite Loops
* An **infinite loop** continues repeating indefinitely until the program is interrupted.
* Occurs when the Boolean expression never becomes `false`.
* **Common Cause:** Forgetting to update/increment the loop control variable within the loop body.

---

## 5.2 The `++` and `--` Operators

### Increment & Decrement Operators
* **Increment (`++`):** Increases a variable's value by 1.
* **Decrement (`--`):** Decreases a variable's value by 1.

| Operation | Equivalent C# Expressons |
| :--- | :--- |
| **Increment** | `count++;` $\quad$ `count += 1;` $\quad$ `count = count + 1;` |
| **Decrement** | `count--;` $\quad$ `count -= 1;` $\quad$ `count = count - 1;` |

### Postfix vs. Prefix Modes

* **Postfix Mode (`count++` / `count--`):**
  * The operator appears *after* the operand.
  * Uses the variable's **current value** in the statement first, then increments/decrements it.
  
* **Prefix Mode (`++count` / `--count`):**
  * The operator appears *before* the operand.
  * Increments/decrements the variable's value **first**, then uses the new value in the statement.

---

## 5.3 The `for` Loop

### Overview
* Specially designed for counter-controlled loops where the exact number of iterations is known in advance.
* It is a **pretest loop**.

### Syntax & Components
```csharp
for (InitializationExpression; TestExpression; UpdateExpression)
{
    // Body statements
}
```

1. **Initialization:** Executes once at the beginning to set up the initial counter value.
2. **Test:** A Boolean expression checked before each iteration. If `true`, the body executes; if `false`, the loop terminates.
3. **Update:** Modifies the counter variable at the end of each iteration.

#### Example:
```csharp
for (int count = 0; count < 5; count++)
{
    MessageBox.Show("Hello");
}
```

### Alternative Update Expressions
* The update step is not limited to incrementing by 1.
* **Stepping by values other than 1:**
  ```csharp
  for (int count = 0; count <= 100; count += 10)
  {
      MessageBox.Show(count.ToString());
  }
  ```
* **Counting Backward:**
  ```csharp
  for (int count = 10; count >= 0; count--)
  {
      MessageBox.Show(count.ToString());
  }
  ```

---

## 5.4 The `do-while` Loop

### Concept
* The `do-while` loop is a **posttest loop**.
* It executes its body statements **first** before checking the Boolean expression.
* **Key Characteristic:** Guarantees that the loop body runs **at least once**, regardless of the initial condition.

### Syntax
```csharp
do
{
    // Body statements
} while (BooleanExpression);
```
