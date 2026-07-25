

-- Part 3: CRUD Operations

-- INSERT Statements

-- Insert Departments
INSERT INTO Department (Dnumber, Dname, NumberOfEmployees)
VALUES
(1, 'IT Department', 0),
(2, 'HR Department', 0);



-- Insert Employees
INSERT INTO Employee
(Ssn, Fname, Minit, Lname, Address, Sex, Bdate, Salary, Dno, Super_ssn)
VALUES
('111111111', 'Ahmed', 'A', 'Ali', 'Muscat', 'M', '2026-05-10', 1500, 1, NULL),
('222222222', 'Salim', 'B', 'Khalid', 'Nizwa', 'M', '2026-03-15', 900, 1, '111111111'),
('333333333', 'Fatma', 'C', 'Hassan', 'Sohar', 'F', '2026-07-20', 800, 2, NULL);


-- Assign Department Manager
UPDATE Department
SET Mgr_ssn = '111111111',
    Mgr_start_date = '2026-01-01'
WHERE Dnumber = 1;



-- Insert Projects
INSERT INTO Project
(Pnumber, Pname, Plocation, Dnum)
VALUES
(101, 'Database System', 'Muscat', 1),
(102, 'HR Application', 'Nizwa', 2);


-- Insert Works_On Records
INSERT INTO Works_On
(Essn, Pno, Hours)
VALUES
('222222222', 101, 20),
('333333333', 102, 15);


-- Insert Dependent Record
INSERT INTO Dependent
(Essn, Dependent_name, Sex, Bdate, Relationship)
VALUES
('111111111', 'Mariam Ali', 'F', '2026-06-12', 'Daughter');




-- UPDATE Statements

-- 1. Give an employee a salary raise
UPDATE Employee
SET Salary = Salary + 200
WHERE Ssn = '222222222';



-- 2. Reassign employee to another department
UPDATE Employee
SET Dno = 2
WHERE Ssn = '333333333';



-- 3. Change project location
UPDATE Project
SET Plocation = 'Salalah'
WHERE Pnumber = 101;



-- 4. Update hours worked on a project
UPDATE Works_On
SET Hours = 30
WHERE Essn = '222222222'
AND Pno = 101;



-- 5. Correct dependent relationship
UPDATE Dependent
SET Relationship = 'Son'
WHERE Essn = '111111111'
AND Dependent_name = 'Mariam Ali';



-- DELETE Statements

-- Delete dependent first because Employee owns the weak entity
DELETE FROM Dependent
WHERE Essn = '111111111'
AND Dependent_name = 'Mariam Ali';


-- Delete employee after removing related records
DELETE FROM Works_On
WHERE Essn = '222222222';

DELETE FROM Employee
WHERE Ssn = '222222222';
