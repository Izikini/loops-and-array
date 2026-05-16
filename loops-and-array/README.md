# Loops and Arrays

A comprehensive C# project containing practical exercises for mastering **loops** and **arrays** in .NET 10.

## 📋 Overview

This project includes **7 progressive tasks** designed to teach fundamental array manipulation techniques using different loop patterns (`for` and `foreach`).

## ✨ Tasks

### Task 1: Sum of Array Elements
Calculates the sum of all elements in an integer array.

**Method:** `Exercise1()`  
**Loop Type:** `for`  
**Array:** `[5, 10, 15, 20, 25]`  
**Note:** ⚠️ Contains a bug - loop condition should be `i < array.Length` instead of `i <= array.Length`

---

### Task 2: Find Minimum and Maximum Values
Identifies the smallest and largest elements in an array.

**Method:** `Exercise2()`  
**Loop Type:** `foreach`  
**Array:** `[15, 10, 15, 20, 25]`  
**Output Format:** Minimum and maximum values

---

### Task 3: Reverse Array Output
Prints all array elements in reverse order without modifying the original array.

**Method:** `Exercise3()`  
**Loop Type:** `for` (descending)  
**Array:** `["Jan", "Krzysztof", "Anna", "Maria"]`  
**Use Case:** Demonstrating backward iteration

---

### Task 4: Count Even and Odd Numbers
Counts how many even and odd numbers are present in an array.

**Method:** `Exercise4()`  
**Loop Type:** `foreach`  
**Array:** `[1, 2, 3, 5, 6, 7, 8, 9]`  
**Calculation:** Uses modulo operator (`%`)

---

### Task 5: Array Transformation
Creates a new array where each element is doubled from the original array.

**Method:** `Exercise5()`  
**Loop Type:** `for`  
**Original Array:** `[1, 2, 3, 4, 5, 6, 7, 8]`  
**Result:** `[2, 4, 6, 8, 10, 12, 14, 16]`

---

### Task 6: Linear Search
Searches for a user-specified number in an array and returns its index position.

**Method:** `Exercise6()`  
**Loop Type:** `for`  
**Array:** `[1, 2, 3, ..., 13]`  
**User Input:** Required - enter the number to search  
**Output:** Index position or "not found" message

---

## 🚀 Getting Started

### Prerequisites
- .NET 10 SDK or later
- Visual Studio 2022 or Visual Studio Code
- C# 14.0 support

### Running the Project

1. **Clone the repository:**