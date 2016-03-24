-- Review DM: Drop BANK after all?
USE BANK;
GO

DROP PROCEDURE spAddNewDebitor;
DROP PROCEDURE spOpenNewCredit;
DROP PROCEDURE spGetDebitors;
DROP PROCEDURE spGetCredits;
DROP PROCEDURE spPassNewPayment;
DROP PROCEDURE spGetPayments;
DROP PROCEDURE spGetUser;
DROP PROCEDURE spGetTypesOfCredit;
GO

DROP TABLE tblPayments;
DROP TABLE tblCredits;
DROP TABLE tblDebitors;
DROP TABLE tblTypeOfCredit;
DROP TABLE tblUser;
GO

