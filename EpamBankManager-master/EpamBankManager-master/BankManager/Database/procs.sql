-- Review DM: USE BANK;
USE BANK
GO

-- Review DM: Same with INSERT VALUES as in Insert.sql.

-- Review DM: The same debitor with changed phone number may come.
-- Review DM: Important to check all the information.
CREATE PROCEDURE spAddNewDebitor
	@firstName nvarchar(50),
	@lastName nvarchar(50),
	@address nvarchar(100),
	@phoneNumber  nvarchar(12),
	@userId int,
	
	@newDebitorId int OUTPUT
AS
BEGIN
	DECLARE @debId int;
	SELECT @debId = Id FROM tblDebitors WHERE @phoneNumber = PhoneNumber;

	IF @debId IS NULL
	BEGIN
		INSERT INTO tblDebitors(FirstName, LastName, [Address], PhoneNumber, UserId)
				VALUES(@firstName, @lastName, @address, @phoneNumber, @userId);
		SELECT @debId = @@IDENTITY;
		SELECT @newDebitorId = @debId;
	END
	ELSE
		SELECT @newDebitorId = -1;
END;
GO

CREATE PROCEDURE spOpenNewCredit
	@debitorId int,
	@openDate datetime,
	@amount numeric(18, 4),
	@typeId int,
	@userId int,

	@newCreditId int OUTPUT
AS
BEGIN
	DECLARE @debId int;

	SELECT @debID = Id FROM tblDebitors WHERE Id = @debitorId;
	IF @debId IS NOT NULL AND @amount > 1000
	BEGIN
		INSERT INTO tblCredits(DebitorId, OpenDate, Amount, Balance, TypeId,  [State], UserId)
				VALUES(@debitorId, @openDate, @amount, @amount, @typeId, 'Active', @userId);

		SELECT @newCreditId = @@IDENTITY;
	END
	ELSE
	BEGIN
		SELECT @newCreditId = -1;
	END
END;
GO

CREATE PROCEDURE spGetDebitors
	@searchedFName nvarchar(50) = '%',
	@searchedLName nvarchar(50) = '%',
	@searchedAddress nvarchar(100) = '%',
	@searchedPhone nvarchar(12) = '%'
AS
BEGIN
	SELECT Id, FirstName, LastName, [Address], PhoneNumber, UserId 
	FROM tblDebitors 
	WHERE FirstName LIKE '%' + @searchedFName +'%' AND LastName LIKE '%' + @searchedLName + '%'
	 AND [Address] LIKE '%' + @searchedAddress + '%' AND PhoneNumber LIKE '%' + @searchedPhone + '%'
END;
GO

CREATE PROCEDURE spGetCredits
	@debitorId int = NULL
AS
BEGIN
	IF @debitorId IS NULL
	BEGIN
		SELECT Id, DebitorId, OpenDate, Amount, Balance, TypeId, [State], UserId
		FROM tblCredits;
    END
	ELSE
	BEGIN
		SELECT Id, DebitorId, OpenDate, Amount, Balance, TypeId, [State], UserId
		FROM tblCredits
		WHERE DebitorId = @debitorId;
	END
END;
GO


CREATE PROCEDURE spGetPayments
	@creditId int = NULL
AS
BEGIN
	IF @creditId IS NULL
	BEGIN
		SELECT Id, CreditId, PaymentDate, Amount, UserId FROM tblPayments;
	END
	ELSE
	BEGIN
		SELECT Id, CreditId, PaymentDate, Amount, UserId
		FROM tblPayments 
		WHERE CreditId = @creditId;
	END
END
GO

-- Review DM: This is better to do with nested Procedures.
CREATE PROCEDURE spPassNewPayment
	@creditId int,
	@paymentDate datetime,
	@amount numeric(18, 4),
	@userId int,

	@newPaymentId int OUTPUT
AS
BEGIN
	--We need to find out is there credit with that Id
	DECLARE @credId int;
	SELECT @credId = Id FROM tblCredits WHERE Id = @creditId;

	IF @credId IS NOT NULL
	BEGIN
		--If credit exists we are trying to find out is payment date is not less then open credit date
		DECLARE @creditDate datetime;
		DECLARE @balance numeric(18, 4);
		SELECT @creditDate = OpenDate FROM tblCredits WHERE Id = @creditID;
		SELECT @balance = Balance FROM tblCredits WHERE Id = @creditId;

		IF (@paymentDate >= @creditDate) AND (@amount > 100) AND (@balance - @amount >= 0)
		BEGIN
			--If payment date is bigger than open credit date we are passing new payment and return Id of new payment
			INSERT INTO tblPayments(CreditId, PaymentDate, Amount, UserId)
					VALUES(@creditId, @paymentDate, @amount, @userId);
			SELECT @newPaymentId = @@IDENTITY

			--We need to update the balance of credit on which we were passing payment
			UPDATE tblCredits SET Balance = Balance - @amount WHERE Id = @creditId;
			
			--If balance of credit is <= 0 it means that credit is repaid
			SELECT @balance = Balance FROM tblCredits WHERE Id = @creditId;
			IF(@balance = 0)
			BEGIN
				UPDATE tblCredits SET Balance = 0, [State] = 'Repaid' WHERE Id = @creditId;
			END		
		END
		ELSE
			SELECT @newPaymentId = -1;
    END
	ELSE
	BEGIN
		SELECT @newPaymentId = -1;
	END
END;
GO

CREATE PROCEDURE spGetTypesOfCredit
AS
BEGIN
	SELECT Id, [Type], MaxTerm
	FROM tblTypeOfCredit;
END
GO

CREATE PROCEDURE spGetUser
	@Login varchar(50),
	@Password varchar(50)
AS
BEGIN
	SELECT Id, FirstName, LastName, [Login], [Disabled]
	FROM tblUser
	WHERE [Login] = @Login AND [Password] = @Password AND [Disabled] <> 1;
END;
GO

