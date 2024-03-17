CREATE TABLE Employees (
    ID INT PRIMARY KEY,
    FirstName VARCHAR(30),
    LastName VARCHAR(50),
    Address VARCHAR(100),
    RoleID INT, -- Added column to differentiate between roles
    PayPerHour DECIMAL(5,2) NULL, -- Nullable
    AnnualSalary DECIMAL(10,2) NULL, -- Nullable
    MaxExpenseAmount DECIMAL(10,2) NULL -- Nullable
);

CREATE TABLE Roles(
	ID INT PRIMARY KEY,
	RoleName varchar (20)
)