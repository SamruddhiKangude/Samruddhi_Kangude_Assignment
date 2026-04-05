# Question 2:  Write a program to find the largest number in an array.

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
 ```mermaid
flowchart TD
    A[Start] --> B[Initialize Array]
    B --> C["largest = Array[0]"]
    C --> D["Loop i = 1"]
    D --> E{"i < Length?"}
    E -- No --> F[Print largest]
    F --> G[End]
    E -- Yes --> H{"Array[i] > largest?"}
    H -- Yes --> I["largest = Array[i]"]
    H -- No --> J[i++]
    I --> J
    J --> E


---

## 3. Project Structure
Question2/<br>
├── Program.cs          # Main source code containing the logic<br>
├── Question2.csproj    # .NET project configuration file<br>
├── Question2.sln       # Visual Studio Solution file<br>
└── README.md           # Project documentation (this file)<br>


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

When you run the program, it will display:<br>
--- Largest Number Finder ---<br>
Let's find the biggest number in our list!<br>

List of numbers: 15, 82, 4, 99, 23, 42<br>

--- Result ---
Largest number is: 99
-----------------------------

