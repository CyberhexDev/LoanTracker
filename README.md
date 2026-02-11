# Loan Amortization Calculator (C# Console Application)

## Overview

This project is a **C# console-based loan calculator** developed for the *CEIS209 – Selection and Repetition Control Structures* course project.
The application collects loan information from the user, validates the input, calculates the monthly payment using the standard amortization formula, and generates a full **loan amortization schedule** showing how each payment is divided between interest and principal over time.

The program demonstrates practical use of control structures such as:

* Input validation
* Conditional logic (`if` statements)
* Iteration (`while` loops and `for` loops)
* Mathematical computation
* Financial modeling

---

## Features

* User input prompts for loan details
* Input validation with error handling
* Monthly payment calculation
* Full amortization schedule generation
* Currency-formatted output
* Iterative balance tracking

The schedule shows for each payment:

* Payment number
* Monthly payment amount
* Interest paid
* Principal paid
* Remaining loan balance

---

## Technologies Used

* **Language:** C#
* **Framework:** .NET Console Application
* **Concepts Demonstrated:**

  * Selection Control Structures (`if` statements)
  * Repetition Control Structures (`while` and `for` loops)
  * Input Validation
  * Decimal precision calculations
  * Financial formulas

---

## How It Works

### 1. User Input

The program prompts the user to enter:

* Loan purpose
* Loan amount (0 – 250,000)
* Interest rate (0 – 25%)
* Loan term (0 – 30 years)

Invalid input is rejected and the user is repeatedly prompted until valid values are entered.

---

### 2. Monthly Payment Calculation

The program calculates the monthly payment using the standard amortization formula:

Payment = P × [ r(1+r)^n ] / [ (1+r)^n − 1 ]

Where:

| Variable | Meaning               |
| -------- | --------------------- |
| P        | Loan amount           |
| r        | Monthly interest rate |
| n        | Number of payments    |

Monthly interest rate:

```
interestRate / 1200
```

Number of payments:

```
loanTerm * 12
```

---

### 3. Amortization Schedule

After calculating the payment, the program generates a full amortization table.

For each payment:

1. Interest is calculated from remaining balance
2. Principal is calculated from payment minus interest
3. Balance is reduced by the principal

---

## Example Output

```
Amortization Schedule ---
 Payment #        Payment        Interest       Principal        Balance
 =========        =======        ========       =========        =======

         1        $536.82        $416.67        $120.15        $99,879.85
         2        $536.82        $416.16        $120.66        $99,759.19
         3        $536.82        $415.66        $121.16        $99,638.03
...
```

---

## Input Validation Rules

| Field         | Constraints          |
| ------------- | -------------------- |
| Loan Amount   | 0 < amount ≤ 250,000 |
| Interest Rate | 0 < rate ≤ 25        |
| Loan Term     | 0 < years ≤ 30       |

If invalid input is entered, the program displays an error and asks again.

---

## What This Project Demonstrates

This project shows understanding of:

* Loop-based user validation
* Financial computation
* Mathematical modeling in software
* Structured console output formatting
* Real-world programming application

---

## Author

**Christopher Cummings**
Session: July 2025
Course: CEIS209

---

## Possible Future Improvements

* Handle zero-interest loans
* Export amortization schedule to CSV
* Add graphical user interface (GUI)
* Allow extra principal payments
* Display total interest paid

---

## How to Run

1. Install **.NET SDK** (6.0 or newer)
2. Clone the repository

```
git clone https://github.com/yourusername/loan-amortization-calculator.git
```

3. Navigate into the project folder

```
cd loan-amortization-calculator
```

4. Run the application

```
dotnet run
```
