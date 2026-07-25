

-- Part 2: Referential Integrity & Constraints

-- Employee Table Constraint Updates

ALTER TABLE Employee
ALTER COLUMN Dno INT NOT NULL;
GO

ALTER TABLE Employee
ADD CONSTRAINT CK_Employee_Salary_Positive
CHECK (Salary > 0);
GO


-- Referential Integrity Relationships

-- WORKS_FOR: Employee must belong to a Department
ALTER TABLE Employee
ADD CONSTRAINT FK_Employee_Works_For_Department
FOREIGN KEY (Dno)
REFERENCES Department(Dnumber);
GO


-- MANAGES: Department manager is an Employee
ALTER TABLE Department
ADD CONSTRAINT FK_Department_Manager_Employee
FOREIGN KEY (Mgr_ssn)
REFERENCES Employee(Ssn);
GO


-- WORKS_ON: Employee works on Project
ALTER TABLE Works_On
ADD CONSTRAINT FK_Works_On_Employee
FOREIGN KEY (Essn)
REFERENCES Employee(Ssn);
GO

ALTER TABLE Works_On
ADD CONSTRAINT FK_Works_On_Project
FOREIGN KEY (Pno)
REFERENCES Project(Pnumber);
GO


-- CONTROLS: Department controls Project
ALTER TABLE Project
ADD CONSTRAINT FK_Project_Controls_Department
FOREIGN KEY (Dnum)
REFERENCES Department(Dnumber);
GO


-- SUPERVISION: Recursive Employee Supervision Relationship
ALTER TABLE Employee
ADD CONSTRAINT FK_Employee_Supervision
FOREIGN KEY (Super_ssn)
REFERENCES Employee(Ssn);
GO


-- DEPENDENTS_OF: Weak Entity with Composite Primary Key
-- Dependent(Essn, Dependent_name)
ALTER TABLE Dependent
ADD CONSTRAINT FK_Dependent_Owner_Employee
FOREIGN KEY (Essn)
REFERENCES Employee(Ssn);
GO


-- Domain Constraints

ALTER TABLE Employee
ADD CONSTRAINT CK_Employee_Sex
CHECK (Sex IN ('M','F'));
GO

ALTER TABLE Dependent
ADD CONSTRAINT CK_Dependent_Sex
CHECK (Sex IN ('M','F'));
GO