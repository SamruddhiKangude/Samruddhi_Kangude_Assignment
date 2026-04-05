-- Question 6 : Write a SQL query to find duplicate records in a table

-- 1. Create a new database for testing
CREATE DATABASE IF NOT EXISTS CompanyDBM;
USE CompanyDBM;

-- 2. Create the Employees table
-- In MySQL, we use AUTO_INCREMENT instead of IDENTITY
CREATE TABLE IF NOT EXISTS Employees (
    Id INT PRIMARY KEY AUTO_INCREMENT,
    Name VARCHAR(100),
    Email VARCHAR(100),
    Department VARCHAR(50)
);

-- 3. Insert values into the table
INSERT INTO Employees (Name, Email, Department)
VALUES  
    ('Samruddhi Kangude', 'samruddhikangude20@gmail.com', 'IT'), 
    ('Jui Kangude', 'jui@gmail.com', 'HR'),
    ('Samruddhi Kangude', 'samruddhikangude20@gmail.com', 'IT'), 
    ('Ramesh Kumar', 'ramesh@gmail.com', 'IT'),
    ('Sakshi Pawar', 'sakshipawar@gmail.com', 'Finance'),
    ('Priya Patil', 'priyapatil33@gmail.com', 'IT'),     
    ('Sneha Dahake', 'snehad2003@gmail.com', 'IT'),
    ('Shruti Kanade', 'skangude77@gmail.com', 'HR'),            
    ('Ramesh Kumar', 'ramesh@gmail.com', 'IT'),                 
    ('Samruddhi Kangude', 'samruddhikangude20@gmail.com', 'IT'), 
    ('Ramesh Kumar', 'ramesh@gmail.com', 'IT'),                 
    ('Shruti Kanade', 'skangude77@gmail.com', 'HR');           

-- 4. THE ANSWER: Query to find duplicate records [cite: 60]
SELECT 
    Name, 
    Email, 
    COUNT(*) as DuplicateCount
FROM 
    Employees
GROUP BY 
    Name, 
    Email
HAVING 
    COUNT(*) > 1;

TRUNCATE TABLE Employees;