USE CompanyDB;
GO

-- Department Table
CREATE TABLE Department
(
    Dnumber INT PRIMARY KEY,

    Dname VARCHAR(50) NOT NULL UNIQUE,

    NumberOfEmployees INT NOT NULL
        DEFAULT 0
        CHECK (NumberOfEmployees >= 0),

    Mgr_ssn CHAR(9) NULL,

    Mgr_start_date DATE NULL
);



-- Employee Table
CREATE TABLE Employee
(
    Ssn CHAR(9) PRIMARY KEY,

    Fname VARCHAR(30) NOT NULL,

    Minit CHAR(1),

    Lname VARCHAR(30) NOT NULL,

    Address VARCHAR(100),

    Sex CHAR(1)
        CHECK (Sex IN ('M','F')),

    Bdate DATE,

    Salary DECIMAL(10,2) NOT NULL
        CHECK (Salary >= 0),

    Dno INT NULL,

    Super_ssn CHAR(9) NULL,


    CONSTRAINT FK_Employee_Department
    FOREIGN KEY (Dno)
    REFERENCES Department(Dnumber),


    CONSTRAINT FK_Employee_Supervisor
    FOREIGN KEY (Super_ssn)
    REFERENCES Employee(Ssn)
);



-- Add Manager Foreign Key after Employee creation
ALTER TABLE Department
ADD CONSTRAINT FK_Department_Manager
FOREIGN KEY (Mgr_ssn)
REFERENCES Employee(Ssn);



-- Department Locations Table
-- Handles multivalued attribute Location
CREATE TABLE Dept_Locations
(
    Dnumber INT NOT NULL,

    Dlocation VARCHAR(50) NOT NULL,


    PRIMARY KEY (Dnumber, Dlocation),


    CONSTRAINT FK_DeptLocations_Department
    FOREIGN KEY (Dnumber)
    REFERENCES Department(Dnumber)
);



-- Project Table
CREATE TABLE Project
(
    Pnumber INT PRIMARY KEY,

    Pname VARCHAR(50) NOT NULL UNIQUE,

    Plocation VARCHAR(50),

    Dnum INT NOT NULL,


    CONSTRAINT FK_Project_Department
    FOREIGN KEY (Dnum)
    REFERENCES Department(Dnumber)
);



-- Works_On Junction Table
CREATE TABLE Works_On
(
    Essn CHAR(9) NOT NULL,

    Pno INT NOT NULL,

    Hours DECIMAL(5,2)
        CHECK (Hours >= 0),


    PRIMARY KEY (Essn, Pno),


    CONSTRAINT FK_WorksOn_Employee
    FOREIGN KEY (Essn)
    REFERENCES Employee(Ssn),


    CONSTRAINT FK_WorksOn_Project
    FOREIGN KEY (Pno)
    REFERENCES Project(Pnumber)
);



-- Dependent Weak Entity Table
CREATE TABLE Dependent
(
    Essn CHAR(9) NOT NULL,

    Dependent_name VARCHAR(50) NOT NULL,

    Sex CHAR(1)
        CHECK (Sex IN ('M','F')),

    Bdate DATE,

    Relationship VARCHAR(30),


    PRIMARY KEY (Essn, Dependent_name),


    CONSTRAINT FK_Dependent_Employee
    FOREIGN KEY (Essn)
    REFERENCES Employee(Ssn)
);
