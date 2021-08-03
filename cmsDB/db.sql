DROP DATABASE IF EXISTS cmsDB;
CREATE DATABASE cmsDB;
USE cmsDB;

CREATE TABLE Customers(
	customerID int NOT NULL AUTO_INCREMENT,
    firstName varchar(50) NOT NULL,
    lastName varchar(50) NOT NULL,
    dateOfBirth date NOT NULL,
    emailAddress nchar(100),
    phoneNumber nchar(15) NOT NULL,
    streetAddress nchar(50) NOT NULL,
    suburb nchar(50) NOT NULL,
    city nchar(50) NOT NULL,
    postCode nchar(10) NOT NULL,
    PRIMARY KEY (customerID)
    ) Engine=InnoDB;

SELECT * FROM Customers;

DELETE FROM Customers WHERE customerID = 2;