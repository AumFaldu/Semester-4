--LAB-5
use CSE_4B_364
-- Creating PersonInfo Table 
CREATE TABLE PersonInfo ( 
PersonID INT PRIMARY KEY, 
PersonName VARCHAR(100) NOT NULL, 
Salary DECIMAL(8,2) NOT NULL, 
JoiningDate DATETIME NULL, 
City VARCHAR(100) NOT NULL, 
Age INT NULL, 
BirthDate DATETIME NOT NULL 
);
-- Creating PersonLog Table 

CREATE TABLE PersonLog ( 
PLogID INT PRIMARY KEY IDENTITY(1,1), 
PersonID INT NOT NULL, 
PersonName VARCHAR(250) NOT NULL, 
Operation VARCHAR(50) NOT NULL, 
UpdateDate DATETIME NOT NULL, 
); 
--PART-A
--1. Create a trigger that fires on INSERT, UPDATE and DELETE operation on the PersonInfo table to display a message “Record is Affected.”  
CREATE OR ALTER TRIGGER TR_PersonInfo_Insert_Update_Delete
ON PersonInfo
AFTER INSERT,UPDATE,DELETE
AS
BEGIN
	PRINT 'Record is Affected'
END
--2. Create a trigger that fires on INSERT, UPDATE and DELETE operation on the PersonInfo table. For that, log all operations performed on the person table into PersonLog. 
CREATE OR ALTER TRIGGER TR_PersonInfo_Insert
ON PersonInfo
AFTER INSERT
AS
BEGIN
	DECLARE @PersonID INT,@PersonName VARCHAR(250)
	SELECT @PersonID=PersonID,@PersonName=PersonName FROM inserted
	INSERT INTO PersonLog VALUES (@PersonID,@PersonName,'INSERT',GETDATE())
END
CREATE OR ALTER TRIGGER TR_PersonInfo_DELETE
ON PersonInfo
AFTER DELETE
AS
BEGIN
	DECLARE @PersonID INT,@PersonName VARCHAR(250)
	SELECT @PersonID=PersonID,@PersonName=PersonName FROM deleted
	INSERT INTO PersonLog VALUES (@PersonID,@PersonName,'DELETE',GETDATE())
END
CREATE OR ALTER TRIGGER TR_PersonInfo_Update
ON PersonInfo
AFTER UPDATE
AS
BEGIN
	DECLARE @PersonID INT,@PersonName VARCHAR(250)
	SELECT @PersonID=PersonID,@PersonName=PersonName FROM inserted
	INSERT INTO PersonLog VALUES (@PersonID,@PersonName,'UPDATE',GETDATE())
END
--3. Create an INSTEAD OF trigger that fires on INSERT, UPDATE and DELETE operation on the PersonInfo table. For that, log all operations performed on the person table into PersonLog. 
CREATE OR ALTER TRIGGER TR_PersonInfo_Insert_INSTEADOF
ON PersonInfo
INSTEAD OF INSERT
AS
BEGIN
	INSERT INTO PersonLog (PersonID, PersonName, Operation, UpdateDate)
    SELECT PersonID, PersonName, 'INSERT', GETDATE()
    FROM inserted;
END
CREATE OR ALTER TRIGGER TR_PersonInfo_DELETE_INSTEADOF
ON PersonInfo
INSTEAD OF DELETE
AS
BEGIN
	INSERT INTO PersonLog (PersonID, PersonName, Operation, UpdateDate)
    SELECT PersonID, PersonName, 'DELETE', GETDATE()
    FROM deleted;
END
CREATE OR ALTER TRIGGER TR_PersonInfo_Update_INSTEADOF
ON PersonInfo
INSTEAD OF UPDATE
AS
BEGIN
	INSERT INTO PersonLog (PersonID, PersonName, Operation, UpdateDate)
    SELECT PersonID, PersonName, 'UPDATE', GETDATE()
    FROM inserted;
END
--4. Create a trigger that fires on INSERT operation on the PersonInfo table to convert person name into uppercase whenever the record is inserted. 
CREATE OR ALTER TRIGGER TR_PersonInfo_Insert_Upper
ON PersonInfo
AFTER INSERT
AS
BEGIN
	DECLARE @PersonName VARCHAR(250),@PersonID INT
	SELECT @PersonID=PersonID,@PersonName=PersonName FROM inserted
	Update PersonInfo
	SET PersonName=UPPER(@PersonName)
	WHERE PersonID=@PersonID
END
--5. Create trigger that prevent duplicate entries of person name on PersonInfo table. 
CREATE OR ALTER TRIGGER TR_PersonInfo_Insert_Prevent_Duplicate
ON PersonInfo
AFTER INSERT
AS
BEGIN
	DECLARE @PersonID INT, @PersonName VARCHAR(250)
    SELECT @PersonID = PersonID, @PersonName = PersonName FROM inserted
    IF @PersonName NOT IN (SELECT PersonName FROM PersonInfo WHERE PersonID <> @PersonID)
    BEGIN
        INSERT INTO PersonLog (PersonID, PersonName, Operation, UpdateDate)
        VALUES (@PersonID, @PersonName, 'INSERT', GETDATE())
    END
END
--6. Create trigger that prevent Age below 18 years.
CREATE OR ALTER TRIGGER TR_PREVENT_BELOW_18
ON PersonInfo
INSTEAD OF INSERT
AS
BEGIN
	INSERT INTO PersonInfo (PersonID, PersonName, Salary, JoiningDate, City, Age, BirthDate)
    SELECT PersonID, PersonName, Salary, JoiningDate, City, Age, BirthDate
    FROM inserted
    WHERE Age >= 18;
END
--PART – B 
--7. Create a trigger that fires on INSERT operation on person table, which calculates the age and update that age in Person table. 
CREATE OR ALTER TRIGGER TR_INSERT_CALC_UPDATE_AGE
ON PersonInfo
AFTER INSERT
AS
BEGIN
	DECLARE @age INT,@PersonID INT
	SELECT @age=DATEDIFF(YEAR,BirthDate,GETDATE()),@PersonID=PersonID FROM inserted
	UPDATE PersonInfo
	SET Age=@age
	WHERE PersonID=@PersonID
END
--8. Create a Trigger to Limit Salary Decrease by a 10%. 
CREATE OR ALTER TRIGGER TR_PersonInfo_Update_Decrease_Sal
ON PersonInfo
AFTER UPDATE
AS
BEGIN
    DECLARE @PersonID INT, @OldSalary DECIMAL(8, 2), @NewSalary DECIMAL(8, 2)
    SELECT @PersonID = PersonID, @OldSalary = Salary FROM deleted
    SELECT @NewSalary = Salary FROM inserted
    IF (@NewSalary < @OldSalary * 0.9)
    BEGIN
        UPDATE PersonInfo
        SET Salary = @OldSalary * 0.9
        WHERE PersonID = @PersonID;
    END
END;

--PART– C  
--9. Create Trigger to Automatically Update JoiningDate to Current Date on INSERT if JoiningDate is NULL during an INSERT. 
CREATE OR ALTER TRIGGER TR_PersonInfo_Insert_Update_JoiningDate
ON PersonInfo
AFTER INSERT
AS
BEGIN
	DECLARE @JoiningDate DATETIME,@PersonID INT
	SELECT @PersonID=PersonID,@JoiningDate=JoiningDate FROM inserted
	IF @JoiningDate iS NULL
	BEGIN
		UPDATE PersonInfo
		SET JoiningDate=GETDATE()
		WHERE PersonID=@PersonID
	END
END
--10. Create DELETE trigger on PersonLog table, when we delete any record of PersonLog table it prints ‘Record deleted successfully from PersonLog’.
CREATE OR ALTER TRIGGER TR_PersonLog_Delete
ON PersonLog
AFTER DELETE
AS
BEGIN
	PRINT 'Record deleted successfully from PersonLog'
END
