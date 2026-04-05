# Question 2: Find the Largest Number in an Array

This project is a **C# Console Application** that identifies the maximum value within a predefined set of integers. It demonstrates fundamental array traversal and comparison logic.

---

## 1. Algorithm Description

The program follows a **linear search approach** to find the maximum value:

- **Initialize**: Create an array of integers.  
- **Assume**: Set the first element of the array as the current `largestNumber`.  
- **Iterate**: Start a loop from the second element (index 1) to the end of the array.  
- **Compare**: For each element, check if it is greater than the current `largestNumber`.  
- **Update**: If the current element is larger, update `largestNumber` with this new value.  
- **Result**: After checking all elements, the `largestNumber` holds the highest value.  

---

## 2. Logic Flowchart
   [Start]
      |
      [Initialize Array]
          |
[largest = Array[0]]
          |
    [Loop: i = 1]
          |
   /---{i < Length?}-- No --> [Print largest] -- [End]
   |      | (Yes)
   | {Array[i] > largest?} -- No --\
   |      | (Yes)                  |
   | [largest = Array[i]]          |
   |      |                        |
   \---[i++] <---------------------/


---

## 3. Project Structure
Question2/
├── Program.cs          # Main source code containing the logic
├── Question2.csproj    # .NET project configuration file
├── Question2.sln       # Visual Studio Solution file
└── README.md           # Project documentation (this file)


---

## 4. How to Run the Program

**Step 1: Open Terminal**
Open Command Prompt, PowerShell, or VS Code Terminal.

**Step 2: Navigate to Project Folder**
```bash
cd Question2
```

**Step 3: Run the Program**

```bash
dotnet run
```

## 5. Expected Output

When you run the program, it will display:
--- Largest Number Finder ---
Let's find the biggest number in our list!

List of numbers: 15, 82, 4, 99, 23, 42

--- Result ---
Largest number is: 99
-----------------------------

