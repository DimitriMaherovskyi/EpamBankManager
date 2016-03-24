IF NOT EXISTS (SELECT * FROM sysdatabases WHERE name = 'BANK')
	CREATE DATABASE BANK;
GO

-- Review DM: USE BANK;
USE BANK
GO

-- Review DM: PK, FK and so what in lowercase.
CREATE TABLE tblTypeOfCredit
(
	Id int IDENTITY(1, 1) NOT NULL,
	[Type] nvarchar(30) NOT NULL,
	MaxTerm int NOT NULL,
	CONSTRAINT PK_tblTypeOfCredit_Id PRIMARY KEY (Id)
);
GO

CREATE TABLE tblUser
(
	Id int NOT NULL IDENTITY(1, 1),
	FirstName nvarchar(50) NOT NULL,
	LastName nvarchar(50) NOT NULL,
	[Login] varchar(50) NOT NULL,
	[Password] varchar(50) NOT NULL,
	[Disabled] bit NOT NULL
	CONSTRAINT PK_tblUser_Id PRIMARY KEY (Id),
	CONSTRAINT UQ_tblUser_Login UNIQUE ([Login])
);
GO

CREATE TABLE tblDebitors
(
	Id int NOT NULL IDENTITY(1, 1),
	FirstName nvarchar(50) NOT NULL,
	LastName nvarchar(50) NOT NULL,
	[Address] nvarchar(100) NOT NULL,
	PhoneNumber nvarchar(12) NOT NULL,
	UserId int NOT NULL,
	CONSTRAINT PK_tblDebitors_Id PRIMARY KEY (Id),
	CONSTRAINT FK_tblDebitorsUserId_tblUserId FOREIGN KEY (UserId) REFERENCES tblUser(Id)
	--Why exactly 11?
	CONSTRAINT CK_CheckPhoneNumber CHECK (PhoneNumber LIKE '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]')
);
GO



CREATE TABLE tblCredits
(
	Id int NOT NULL IDENTITY(1, 1),
	DebitorId int NOT NULL,
	OpenDate datetime NOT NULL,
	Amount numeric(18, 4) NOT NULL,
	Balance numeric(18, 4) NOT NULL,
	TypeId int NOT NULL,
	[State] nvarchar(6) NOT NULL,
	UserId int NOT NULL,
	CONSTRAINT PK_tblCredits_Id PRIMARY KEY (Id),
	CONSTRAINT FK_tblCreditsDebitorId_tblDebitorsId FOREIGN KEY (DebitorId) REFERENCES tblDebitors(Id),
	CONSTRAINT FK_tblCreditsTypeId_tblTypeOfCreditsId FOREIGN KEY (TypeId) REFERENCES tblTypeOfCredit(Id),
	CONSTRAINT CK_CheckAmountOfCredit CHECK (Amount > 1000 AND Balance >= 0),
	CONSTRAINT FK_tblCreditsUserId_tblUserId FOREIGN KEY (UserId) REFERENCES tblUser(Id)
);
GO

CREATE TABLE tblPayments
(
	Id int NOT NULL IDENTITY(1, 1),
	CreditId int NOT NULL,
	PaymentDate datetime NOT NULL,
	Amount numeric(18, 4) NOT NULL,
	UserId int NOT NULL,
	CONSTRAINT PK_tblPayments_Id PRIMARY KEY (Id),
	CONSTRAINT FK_tblPaymentsCreditId_tblCreditsId FOREIGN KEY (CreditId) REFERENCES tblCredits(Id),
	CONSTRAINT FK_tblCPaymentsUserId_tblUserId FOREIGN KEY (UserId) REFERENCES tblUser(Id),
	CONSTRAINT CK_CheckAmountOfPayment CHECK (Amount > 0)
);
GO





