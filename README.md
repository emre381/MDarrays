
---

## Multidimensional Array Program in C#

This program demonstrates how to work with a **3D array** in C#. It initializes a three-dimensional array and then uses nested `for` loops to iterate over each element, printing them to the console.

### Key Concepts

- **Multidimensional Arrays**: In this program, the array `numbers` is a 3D array with the dimensions `[3, 2, 2]`. Each dimension represents:
  - `x`: The first index (size 3), representing three "blocks" in the array.
  - `y`: The second index (size 2), representing two "rows" within each block.
  - `z`: The third index (size 2), representing two "columns" within each row.

### Code Walkthrough

1. **Initialization**:
   The array `numbers` is initialized with pre-defined values:
   ```csharp
   int[, ,] numbers = { { {2,3}, { 4, 5 } }, { {6,7 }, { 8, 9 } }, { {6,3 } , {2, 8 } } };
   ```

   The array holds integers in a structure that looks like this:
   ```
   Block 0:   Block 1:   Block 2:
   2 3        6 7        6 3
   4 5        8 9        2 8
   ```

2. **Nested Loops**:
   The program uses three nested `for` loops to traverse through the 3D array:
   - The outer loop (`x`) iterates over the blocks.
   - The middle loop (`y`) iterates over the rows in each block.
   - The inner loop (`z`) iterates over the elements in each row (columns).

   The structure of the loops ensures that each element is accessed and printed.

3. **Printing the Array**:
   Inside the innermost loop, the program prints each element followed by a new line after each row and block for clarity:
   ```csharp
   Console.Write(numbers[x, y, z]);
   ```

4. **Output**:
   The program produces the following output:

   ```
   23
   45

   67
   89

   63
   28
   ```

### Usage

- Run the program, and it will print the values from the 3D array in a readable format.
- The structure ensures that each block of the array is separated by a line, making it easier to visualize the contents of the multidimensional array.

---

