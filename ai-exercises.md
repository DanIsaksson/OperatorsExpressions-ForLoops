### **Exercise 1: Predict the Outcome**

Given the following C# code, determine the final value of the `result` variable without using a compiler. Use the operator precedence table from your sheet to manually calculate the outcome.

```csharp
bool result = 10 + 2 * 3 > 15 && 20 - 5 / 5 == 19;
```

<br>

### **Exercise 2: The Ternary Operator**

Write a C# `for` loop that iterates from 1 to 10. Inside the loop, use the ternary operator (`?:`) to determine if the current number is greater than 5. If it is, print "[number] is greater than 5"; otherwise, print "[number] is not greater than 5".

<br>

### **Exercise 3: For Loop with Compound Conditions**

Analyze the following C# code. Your task is to determine how many times the message "Condition met!" will be printed to the console. Use the operator precedence rules to evaluate the `if` statement's condition in each iteration of the loop.

```csharp
for (int i = 0; i < 10; i++)
{
    if (i > 2 && i < 6 || i == 8)
    {
        Console.WriteLine("Condition met!");
    }
}
```

---

## **Solutions**

### **Solution to Exercise 1**

The final value of `result` is `false`.

**Explanation:**

1.  **Multiplication/Division:** The `*` and `/` operators are evaluated first.
    *   `2 * 3` becomes `6`.
    *   `5 / 5` becomes `1`.
    *   The expression is now: `10 + 6 > 15 && 20 - 1 == 19`
2.  **Addition/Subtraction:** The `+` and `-` operators are evaluated next.
    *   `10 + 6` becomes `16`.
    *   `20 - 1` becomes `19`.
    *   The expression is now: `16 > 15 && 19 == 19`
3.  **Comparisons:** The `>` and `==` operators are evaluated.
    *   `16 > 15` is `true`.
    *   `19 == 19` is `true`.
    *   The expression is now: `true && true`
4.  **AND Operator:** Finally, the `&&` operator is evaluated.
    *   `true && true` is `true`.

Wait, there seems to be a mistake in the reasoning provided above, let me re-evaluate based on the provided image.

**Corrected Solution to Exercise 1**
The final value of `result` is `true`.

**Explanation:**

1.  **Multiplication/Division:** The `*` and `/` operators are evaluated first, from left to right.
    *   `2 * 3` evaluates to `6`.
    *   `5 / 5` evaluates to `1`.
    *   The expression becomes: `10 + 6 > 15 && 20 - 1 == 19`.
2.  **Addition/Subtraction:** The `+` and `-` operators are evaluated next, from left to right.
    *   `10 + 6` evaluates to `16`.
    *   `20 - 1` evaluates to `19`.
    *   The expression becomes: `16 > 15 && 19 == 19`.
3.  **Comparisons:** The `>` and `==` operators are evaluated next.
    *   `16 > 15` evaluates to `true`.
    *   `19 == 19` evaluates to `true`.
    *   The expression becomes: `true && true`.
4.  **AND Operator:** The `&&` operator is evaluated last.
    *   `true && true` evaluates to `true`.

### **Solution to Exercise 2**

```csharp
for (int i = 1; i <= 10; i++)
{
    string message = i > 5 ? $"{i} is greater than 5" : $"{i} is not greater than 5";
    Console.WriteLine(message);
}
```

**Explanation:**

The ternary operator `?:` is used as a concise way to write an `if-else` statement. The condition `i > 5` is evaluated first. If it's `true`, the expression resolves to the value after the `?`. If it's `false`, it resolves to the value after the `:`.

### **Solution to Exercise 3**

The message "Condition met!" will be printed **4 times**.

**Explanation:**

According to the operator precedence table, the `&&` operator is evaluated before the `||` operator.

The condition is `i > 2 && i < 6 || i == 8`.

Let's trace the loop:

*   `i = 0`: `false && true || false` -> `false || false` -> `false`
*   `i = 1`: `false && true || false` -> `false || false` -> `false`
*   `i = 2`: `false && true || false` -> `false || false` -> `false`
*   `i = 3`: `true && true || false` -> `true || false` -> `true` (**prints**)
*   `i = 4`: `true && true || false` -> `true || false` -> `true` (**prints**)
*   `i = 5`: `true && true || false` -> `true || false` -> `true` (**prints**)
*   `i = 6`: `true && false || false` -> `false || false` -> `false`
*   `i = 7`: `true && false || false` -> `false || false` -> `false`
*   `i = 8`: `true && false || true` -> `false || true` -> `true` (**prints**)
*   `i = 9`: `true && false || false` -> `false || false` -> `false`

The condition is true for `i = 3, 4, 5, 8`.