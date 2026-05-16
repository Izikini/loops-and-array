# Loops and Arrays

A comprehensive C# project containing practical exercises for mastering **loops** and **arrays** in .NET 10.

## 📋 Overview

This project includes **7 progressive tasks** designed to teach fundamental array manipulation techniques using different loop patterns (`for` and `foreach`).

## ✨ Tasks

### Task 1: Sum of Array Elements
Calculates the sum of all elements in an integer array.

**Method:** `Zadanie1()`  
**Loop Type:** `for`  
**Array:** `[5, 10, 15, 20, 25]`  
**Note:** ⚠️ Contains a bug - loop condition should be `i < tabela.Length` instead of `i <= tabela.Length`

---

### Task 2: Find Minimum and Maximum Values
Identifies the smallest and largest elements in an array.

**Method:** `Zadanie2()`  
**Loop Type:** `foreach`  
**Array:** `[15, 10, 15, 20, 25]`  
**Output Format:** Minimum and maximum values

---

### Task 3: Reverse Array Output
Prints all array elements in reverse order without modifying the original array.

**Method:** `Zadanie3()`  
**Loop Type:** `for` (descending)  
**Array:** `["Jan", "Krzysztof", "Anna", "Maria"]`  
**Use Case:** Demonstrating backward iteration

---

### Task 4: Count Even and Odd Numbers
Counts how many even and odd numbers are present in an array.

**Method:** `Zadanie4()`  
**Loop Type:** `foreach`  
**Array:** `[1, 2, 3, 5, 6, 7, 8, 9]`  
**Calculation:** Uses modulo operator (`%`)

---

### Task 5: Array Transformation
Creates a new array where each element is doubled from the original array.

**Method:** `Zadanie5()`  
**Loop Type:** `for`  
**Original Array:** `[1, 2, 3, 4, 5, 6, 7, 8]`  
**Result:** `[2, 4, 6, 8, 10, 12, 14, 16]`

---

### Task 6: Linear Search
Searches for a user-specified number in an array and returns its index position.

**Method:** `Zadanie6()`  
**Loop Type:** `for`  
**Array:** `[1, 2, 3, ..., 13]`  
**User Input:** Required - enter the number to search  
**Output:** Index position or "not found" message

---

### Task 7: Reverse Array In-Place
Reverses an array by swapping elements from both ends moving toward the center.

**Method:** `Zadanie7()`  
**Loop Type:** `for`  
**Array:** `[12, 4, 5, 1, 54, 20]`  
**Algorithm:** Element swapping technique  
**Result:** `[20, 54, 1, 5, 4, 12]`

---

## 🚀 Getting Started

### Prerequisites
- .NET 10 SDK or later
- Visual Studio 2022 or Visual Studio Code
- C# 14.0 support

### Running the Project

1. **Clone the repository:**