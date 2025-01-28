--AFTER TRIGGER
CREATE TABLE EMPLOYEEDETAILS
(
	EmployeeID Int Primary Key,
	EmployeeName Varchar(100) Not Null,
	ContactNo Varchar(100) Not Null,
	Department Varchar(100) Not Null,
	Salary Decimal(10,2) Not Null,
	JoiningDate DateTime Null
)
CREATE TABLE EmployeeLogs (
    LogID INT PRIMARY KEY IDENTITY(1,1),
    EmployeeID INT NOT NULL,
    EmployeeName VARCHAR(100) NOT NULL,
    ActionPerformed VARCHAR(100) NOT NULL,
    ActionDate DATETIME NOT NULL
);
--1) Create a trigger that fires AFTER INSERT, UPDATE, and DELETE operations on the EmployeeDetails table to display the message "Employee record inserted", "Employee record updated", "Employee record deleted"
CREATE OR ALTER TRIGGER TR_EmployeeDetails_AfterInsertUpdateDelete
ON EmployeeDetails
AFTER INSERT,UPDATE,DELETE
AS
BEGIN
	IF EXISTS (SELECT * FROM inserted)
	BEGIN
		IF EXISTS (SELECT * FROM deleted)
		BEGIN
			PRINT 'Employee record updated'
		END
		ELSE
		BEGIN
			PRINT 'Employee record inserted'
		END
	END
	ELSE
	BEGIN
		PRINT 'Employee record deleted'
	END
END

--2) Create a trigger that fires AFTER INSERT, UPDATE, and DELETE operations on the EmployeeDetails table to log all operations into the EmployeeLog table.
CREATE OR ALTER TRIGGER TR_EmployeeLog_AfterInsertUpdateDelete
ON EmployeeDetails
AFTER INSERT,UPDATE,DELETE
AS
BEGIN
	IF EXISTS (SELECT * FROM inserted) AND EXISTS(SELECT * FROM deleted)
	BEGIN
		INSERT INTO EmployeeLogs(EmployeeID,EmployeeName,ActionPerformed,ActionDate)
		(SELECT EmployeeID,EmployeeName,'UPDATE',GETDATE() FROM inserted)
	END
	ELSE IF EXISTS(SELECT * FROM inserted)
	BEGIN
		INSERT INTO EmployeeLogs(EmployeeID,EmployeeName,ActionPerformed,ActionDate)
		(SELECT EmployeeID,EmployeeName,'INSERT',GETDATE() FROM inserted)
	END
	ELSE IF EXISTS(SELECT * FROM deleted)
	BEGIN
		INSERT INTO EmployeeLogs(EmployeeID,EmployeeName,ActionPerformed,ActionDate)
		(SELECT EmployeeID,EmployeeName,'DELETE',GETDATE() FROM deleted)
	END
END

--3) Create a trigger that fires AFTER INSERT to automatically calculate the joining bonus (10% of the salary) for new employees and update a bonus column in the EmployeeDetails table.
CREATE OR ALTER TRIGGER TR_EmployeeDetails_AfterInsert
ON EmployeeDetails
AFTER INSERT
AS
BEGIN
	DECLARE @id INT, @salary DECIMAL(10, 2);
    SELECT @id = EmployeeID, @salary = Salary FROM inserted;
    
    UPDATE EmployeeDetails
    SET Salary = @salary * 1.1
    WHERE EmployeeID = @id;
END

--4) Create a trigger to ensure that the JoiningDate is automatically set to the current date if it is NULL during an INSERT operation.
CREATE OR ALTER TRIGGER TR_EmployeeDetails_AfterInsert_ChangeDate
ON EmployeeDetails
AFTER INSERT
AS
BEGIN
		UPDATE EmployeeDetails
		SET JoiningDate=GETDATE()
		WHERE EmployeeID IN (SELECT EmployeeID FROM inserted WHERE JoiningDate IS NULL)
END
--5) Create a trigger that ensure that ContactNo is valid during insert(Like ContactNo length is 10)
CREATE OR ALTER TRIGGER TR_EmployeeDetails_AfterInsert_ContactNo
ON EmployeeDetails
AFTER INSERT
AS
BEGIN
	DELETE FROM EmployeeDetails
    WHERE EmployeeID IN (SELECT EmployeeID FROM inserted WHERE LEN(ContactNo) != 10)
END
--INSTEAD OF
CREATE TABLE Movies (
    MovieID INT PRIMARY KEY,
    MovieTitle VARCHAR(255) NOT NULL,
    ReleaseYear INT NOT NULL,
    Genre VARCHAR(100) NOT NULL,
    Rating DECIMAL(3, 1) NOT NULL,
    Duration INT NOT NULL
);
CREATE TABLE MoviesLog
(
	LogID INT PRIMARY KEY IDENTITY(1,1),
	MovieID INT NOT NULL,
	MovieTitle VARCHAR(255) NOT NULL,
	ActionPerformed VARCHAR(100) NOT NULL,
	ActionDate	DATETIME  NOT NULL
);
--1 Create an INSTEAD OF trigger that fires on INSERT, UPDATE and DELETE operation on the Movies table. For that, log all operations performed on the Movies table into MoviesLog.
CREATE OR ALTER TRIGGER TR_LogMoviesOperations
ON Movies
INSTEAD OF INSERT, UPDATE, DELETE
AS
BEGIN
    INSERT INTO MoviesLog(MovieID, MovieTitle, ActionPerformed, ActionDate)
    SELECT 
        MovieID, 
        MovieTitle, 
        'INSERT', 
        GETDATE()
    FROM inserted;

    INSERT INTO Movies(MovieID, MovieTitle, ReleaseYear, Genre, Rating, Duration)
    SELECT 
        MovieID, 
        MovieTitle, 
        ReleaseYear, 
        Genre, 
        Rating, 
        Duration
    FROM inserted;

    INSERT INTO MoviesLog(MovieID, MovieTitle, ActionPerformed, ActionDate)
    SELECT 
        d.MovieID, 
        d.MovieTitle, 
        'UPDATE', 
        GETDATE()
    FROM deleted d
    JOIN inserted i ON d.MovieID = i.MovieID;

    UPDATE Movies
    SET 
        MovieTitle = i.MovieTitle,
        ReleaseYear = i.ReleaseYear,
        Genre = i.Genre,
        Rating = i.Rating,
        Duration = i.Duration
    FROM inserted i
    WHERE i.MovieID = Movies.MovieID;

    INSERT INTO MoviesLog(MovieID, MovieTitle, ActionPerformed, ActionDate)
    SELECT 
        MovieID, 
        MovieTitle, 
        'DELETE', 
        GETDATE()
    FROM deleted;
    DELETE FROM Movies
    WHERE MovieID IN (SELECT MovieID FROM deleted);
END;

--2 Create a trigger that only allows to insert movies for which Rating is greater than 5.5 .
CREATE OR ALTER TRIGGER TR_Movies_InsteadOfRatingInsert
ON Movies
INSTEAD OF INSERT
AS
BEGIN
	INSERT INTO Movies(MovieID,MovieTitle,ReleaseYear,Genre,Rating,Duration)
	SELECT MovieID,MovieTitle,ReleaseYear,Genre,Rating,Duration
	FROM inserted
	WHERE Rating>5.5
END
--3 Create trigger that prevent duplicate 'MovieTitle' of Movies table and log details of it in MoviesLog table.
CREATE OR ALTER TRIGGER TR_Movies_PreventDuplicateMovieTitle
ON Movies
INSTEAD OF INSERT
AS
BEGIN
	INSERT INTO MoviesLog(MovieID,MovieTitle,ActionPerformed,ActionDate)
	SELECT MovieID,MovieTitle,'Duplicate',GETDATE() FROM inserted
	where MovieTitle IN (SELECT MovieTitle FROM Movies)

	INSERT INTO Movies(MovieID,MovieTitle,ReleaseYear,Genre,Rating,Duration)
	SELECT MovieID,MovieTitle,ReleaseYear,Genre,Rating,Duration FROM inserted
	WHERE MovieTitle NOT IN (SELECT MovieTitle FROM Movies)
END
--4 Create trigger that prevents to insert pre-release movies.
CREATE OR ALTER TRIGGER TR_Movies_PreventPreReleaseInsert
ON Movies
INSTEAD OF INSERT
AS
BEGIN
	Insert INTO MoviesLog(MovieID,MovieTitle,ActionPerformed,ActionDate)
	SELECT MovieID,MovieTitle,'PRE-RELEASE ATTEMPT',GETDATE() FROM inserted
	WHERE ReleaseYear>YEAR(GETDATE())
	INSERT INTO Movies(MovieID,MovieTitle,ReleaseYear,Genre,Rating,Duration)
	SELECT MovieID,MovieTitle,ReleaseYear,Genre,Rating,Duration FROM inserted
	WHERE ReleaseYear<=YEAR(GETDATE())
END
--5 Develop a trigger to ensure that the Duration of a movie cannot be updated to a value greater than 120 minutes (2 hours) to prevent unrealistic entries.
CREATE OR ALTER TRIGGER TR_Movies_PreventUnrealisticEntries
ON Movies
INSTEAD OF UPDATE
AS
BEGIN
	INSERT INTO MoviesLog(MovieID, MovieTitle, ActionPerformed, ActionDate)
    SELECT 
        d.MovieID, 
        d.MovieTitle, 
        'INVALID DURATION UPDATE ATTEMPT', 
        GETDATE()
    FROM deleted d
    JOIN inserted i ON d.MovieID = i.MovieID
    WHERE i.Duration > 120;
	UPDATE Movies
	SET MovieTitle = i.MovieTitle,
        ReleaseYear = i.ReleaseYear,
        Genre = i.Genre,
        Rating = i.Rating,
        Duration = i.Duration
	FROM inserted i
	WHERE i.MovieID=Movies.MovieID and i.Duration<=120
END