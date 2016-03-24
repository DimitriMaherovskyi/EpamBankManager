USE BANK;
GO

-- Review DM: VALUES ()
-- Review DM: IDENTITY_INSERT ON/OFF;
SET IDENTITY_INSERT tblUser ON
INSERT INTO tblUser(Id, FirstName, LastName, [Login], [Password], [Disabled])
-- Review DM: No TAB requred.
		VALUES(1, 'Andriy', 'Ivanenko', 'IvanenkoAndr', 'dad4b8412dd743c690edb6d0bb1e00ee', 0), --password ivanenkobank
			  (2, 'Petro', 'Gavryliv', 'GavrPetro', '1f146989d5fb02294a76b22c122dd8c0', 0),--password gavrylivbank
			  (3, 'Ivan', 'Kocur', 'IvanKoc', '50520358029bc641df88f61f07df6499', 0);--password kocurbank
SET IDENTITY_INSERT tblUser OFF
GO

SET IDENTITY_INSERT tblTypeOfCredit ON
INSERT INTO tblTypeOfCredit(Id, [Type], MaxTerm)
		VALUES(1, 'Short-Term', 6),
			  (2, 'Middle-Term', 24),
			  (3, 'Long-Term', 120);
SET IDENTITY_INSERT tblTypeOfCredit OFF
GO

SET IDENTITY_INSERT tblDebitors ON
INSERT INTO tblDebitors(Id, FirstName, LastName, [Address], PhoneNumber, UserId)
		VALUES(1, 'Ivan', 'Petrenko', 'Lviv', '380976584567', 1),
			  (2, 'Max', 'Ivanenko', 'Kyiv', '380687563458', 3),
			  (3, 'Anatoliy', 'Semerenko', 'London', '380984657324', 2),
			  (4, 'Maryan', 'Mayher', 'Paris', '380973659867', 2),
			  (5, 'Rostyslav', 'Kocur', 'Drogobych',  '380637845623', 3),
			  (6, 'Ostap', 'Voznyak', 'Lviv',  '380506785883', 1),
			  (7, 'Mykola', 'Yarema', 'Moskow', '380681247856', 2),
			  (8, 'Dmytro', 'Yachno', 'Warsaw', '380673458923', 1),
			  (9, 'Semen', 'Parashak', 'Odessa', '380675487823', 3),
			  (10, 'Petro', 'Ivaniv', 'Berlin', '380934578324', 3);
SET IDENTITY_INSERT tblDebitors OFF
GO


SET IDENTITY_INSERT tblCredits ON
INSERT INTO tblCredits(Id, DebitorId, OpenDate, Amount, Balance, TypeId, [State], UserId)
		VALUES (1, 1, '2016-01-19', 100000, 100000, 1, 'Active', 1),
			   (2, 1, '2016-03-16', 40000, 25000, 2, 'Active', 2),
			   (3, 3, '2016-03-14', 55000, 45000, 3, 'Active', 3),
			   (4, 5, '2016-02-14', 70000, 50000, 1, 'Active', 3),
			   (5, 5, '2016-03-12', 35000, 35000, 2, 'Active', 1),
			   (6, 6, '2016-02-14', 90000, 60000, 3, 'Active', 2),
			   (7, 7, '2014-11-10', 110000, 110000, 1, 'Active', 2),
			   (8, 7, '2016-01-16', 43000, 43000, 2, 'Active', 2),
			   (9, 9, '2016-02-05', 57000, 50000, 3, 'Active', 3),
			   (10, 9, '2016-03-15', 72000, 72000, 1,'Active', 1);
SET IDENTITY_INSERT tblCredits OFF
GO

SET IDENTITY_INSERT tblPayments ON
INSERT INTO tblPayments (Id, CreditId, PaymentDate, Amount, UserId)
		VALUES (1, 3, '2016-03-20', 10000, 1),
		       (2, 2, '2016-04-20', 15000, 1),
			   (3, 4, '2016-03-25', 20000, 2),
			   (4, 6, '2016-03-10', 30000, 2),
			   (5, 9, '2016-03-15', 7000, 3);
SET IDENTITY_INSERT tblPayments OFF
GO



