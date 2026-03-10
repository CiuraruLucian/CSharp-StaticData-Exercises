# C# Static Data Exercises

## Overview
This repository contains **C# exercises focused on static data and static members**.  
The exercises demonstrate:

- How to declare and use **static fields**
- Using **static methods** to access and modify shared data
- **Static constructors** and when they are executed
- Differences between **instance-level data** and **class-level (static) data**
- Practical example using a `SavingsAccount` class

The goal is to understand **how static data works in C#** and how it can be used to store information shared across all instances of a class.

---

## Exercise Included

### SavingsAccount Class
- **Instance field**: `currBalance` – each account has its own balance.
- **Static field**: `currInterestRate` – shared by all accounts.
- **Constructor**: Initializes the account balance.
- **Static constructor**: Initializes the interest rate when the class is first used.
- **Static methods**:
  - `GetInterestRate()` – returns the current interest rate.
  - `SetInterestRate(double newRate)` – updates the interest rate for all accounts.

### Program
- Creates multiple `SavingsAccount` objects.
- Demonstrates that **changing the static interest rate affects all accounts**.
- Prints the interest rate before and after changes to show that it is **shared across instances**.

---

## How to Run

### Prerequisites
- [.NET SDK](https://dotnet.microsoft.com/download)
- Visual Studio or VS Code (with C# extension)

### Steps
1. Clone the repository:

```bash
git clone https://github.com/CiuraruLucian/CSharp-StaticData-Exercises.git
