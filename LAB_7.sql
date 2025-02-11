--LAB-7
use CSE_4B_364
-- Create the Customers table
CREATE TABLE Customers (
 Customer_id INT PRIMARY KEY,
 Customer_Name VARCHAR(250) NOT NULL,
 Email VARCHAR(50) UNIQUE
);
-- Create the Orders table
CREATE TABLE Orders (
 Order_id INT PRIMARY KEY,
 Customer_id INT,
 Order_date DATE NOT NULL,
 FOREIGN KEY (Customer_id) REFERENCES Customers(Customer_id)
);
--PART-A
--1 Handle Divide by Zero Error and Print message like: Error occurs that is - Divide by zero error
CREATE OR ALTER PROCEDURE PR_ZeroDivisionError
@num INT,
@den INT
AS
BEGIN
	BEGIN TRY
		DECLARE @ANS INT = @num/@den 
		PRINT 'Division = '+CAST(@ANS AS VARCHAR)
	END TRY
	BEGIN CATCH
		PRINT 'Error occurs that is - Divide by zero error.'
	END CATCH
END
PR_ZeroDivisionError 1,0
--2 Try to convert string to integer and handle the error using try…catch block.
CREATE OR ALTER PROCEDURE PR_StringToInt
@a VARCHAR(10)
AS
BEGIN
	BEGIN TRY
		DECLARE @i INT=CAST(@a AS INT)
		PRINT 'In Int = '+CAST(@i AS VARCHAR)
	END TRY
	BEGIN CATCH
		PRINT ERROR_MESSAGE()
	END CATCH
END
PR_StringToInt 'abc'
--3 Create a procedure that prints the sum of two numbers: take both numbers as integer & handle exception with all error functions if any one enters string value in numbers otherwise print result.
CREATE OR ALTER PROCEDURE PR_SumError
@n1 VARCHAR(50),
@n2 VARCHAR(50)
AS
BEGIN
	BEGIN TRY
		DECLARE @ANS INT=CAST(@n1 AS INT)+CAST(@n2 AS INT)
		PRINT 'Sum = '+CAST(@ANS AS VARCHAR)
	END TRY
	BEGIN CATCH
		PRINT 'Error Number = '+CAST(ERROR_NUMBER() AS VARCHAR)
		PRINT 'Error Message = '+CAST(ERROR_MESSAGE() AS VARCHAR)
		PRINT 'Error Procedure = '+CAST(ERROR_PROCEDURE() AS VARCHAR)
		PRINT 'Error State = '+CAST(ERROR_STATE() AS VARCHAR)
		PRINT 'Error Severity = '+CAST(ERROR_SEVERITY() AS VARCHAR)
		PRINT 'Error Line = '+CAST(ERROR_LINE() AS VARCHAR)
	END CATCH
END
PR_SumError 'ABC',1

--4 Handle a Primary Key Violation while inserting data into customers table and print the error details such as the error message, error number, severity, and state.
CREATE OR ALTER PROCEDURE PR_PrimaryKeyCustomer
@Cid INT,
@Cname VARCHAR(250),
@Email VARCHAR(50)
AS
BEGIN
	BEGIN TRY
		INSERT INTO Customers VALUES (@Cid,@Cname,@Email)
	END TRY
	BEGIN CATCH
		PRINT 'Error Number = '+CAST(ERROR_NUMBER() AS VARCHAR)
		PRINT 'Error Message = '+CAST(ERROR_MESSAGE() AS VARCHAR)
		PRINT 'Error Procedure = '+CAST(ERROR_PROCEDURE() AS VARCHAR)
		PRINT 'Error State = '+CAST(ERROR_STATE() AS VARCHAR)
		PRINT 'Error Severity = '+CAST(ERROR_SEVERITY() AS VARCHAR)
		PRINT 'Error Line = '+CAST(ERROR_LINE() AS VARCHAR)
	END CATCH
END
PR_PrimaryKeyCustomer 1,'Rahul','a@b'
PR_PrimaryKeyCustomer 1,'Rohan','b@c'

--5 Throw custom exception using stored procedure which accepts Customer_id as input & that throws Error like no Customer_id is available in database.
CREATE OR ALTER PROCEDURE PR_Customers_CustomException
@Cid INT
AS
BEGIN
		IF NOT EXISTS (SELECT 1 FROM Customers WHERE Customer_id=@Cid) 
		BEGIN
			THROW 50031,'No Customer_id is available in database',1;
		END;
			SELECT * FROM Customers WHERE Customer_id=@Cid;
END
PR_Customers_CustomException 0
--PART-B
--6 Handle a Foreign Key Violation while inserting data into Orders table and print appropriate error message.
CREATE OR ALTER PROCEDURE PR_ForeignKeyViolation
@Oid INT,
@Cid INT,
@ODate DATE
AS
BEGIN
	BEGIN TRY
		INSERT INTO Orders VALUES (@Oid,@Cid,@ODate)
	END TRY
	BEGIN CATCH
		PRINT ERROR_MESSAGE()
	END CATCH
END

--7 Throw custom exception that throws error if the data is invalid.
CREATE OR ALTER PROCEDURE PR_Customers_InvalidDataException
@Cid INT,
@CName VARCHAR(50),
@Email VARCHAR(50)
AS
BEGIN
	THROW 
END
--8 Create a Procedure to Update Customer’s Email with Error Handling
CREATE OR ALTER PROCEDURE PR_Customer_Email
@Cid INT,
@Email VARCHAR(50)
AS
BEGIN
    BEGIN TRY
        IF NOT EXISTS (SELECT 1 FROM Customers WHERE Customer_id = @Cid)
            THROW 50032, 'Customer_id not found in database', 1;
        UPDATE Customers
        SET Email = @Email
        WHERE Customer_id = @Cid;
    END TRY
    BEGIN CATCH
        DECLARE @ErrorMessage NVARCHAR(4000) = ERROR_MESSAGE();
        DECLARE @ErrorSeverity INT = ERROR_SEVERITY();
        DECLARE @ErrorState INT = ERROR_STATE();
        THROW 50033, @ErrorMessage, 1;
    END CATCH
END;

--PART-C
--9 Create a procedure which prints the error message that “The Customer_id is already taken. Try another one”.
CREATE OR ALTER PROCEDURE PR_Check_CustomerId
@Cid INT
AS
BEGIN
    IF EXISTS (SELECT 1 FROM Customers WHERE Customer_id = @Cid)
    BEGIN
        PRINT 'The Customer_id is already taken. Try another one';
    END
    ELSE
    BEGIN
        PRINT 'Customer_id is available';
    END
END;

