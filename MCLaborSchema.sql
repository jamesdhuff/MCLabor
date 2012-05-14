----
-- MCLabor Schema Creation Script
----

-- Create MCLabor Database
USE master
GO
CREATE DATABASE MCLabor ON PRIMARY 
( NAME = N'MCLabor', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL10_50.MCLABOR\MSSQL\DATA\MCLabor.mdf' , SIZE = 2048KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'MCLabor_log', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL10_50.MCLABOR\MSSQL\DATA\MCLabor_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO


-- Create ADMIN_USER table
USE MCLabor
GO
CREATE TABLE dbo.ADMIN_USER
(
	adminUserId int IDENTITY(1,1) NOT NULL,
	userName nvarchar(50) NOT NULL,
	password nvarchar(50) NOT NULL,
	CONSTRAINT PK_ADMIN_USER PRIMARY KEY CLUSTERED(adminUserId ASC)
)
GO

-- Insert ADMIN_USER seed data
INSERT INTO ADMIN_USER (userName,password) VALUES ('admin','admin')
GO


-- Create EMPLOYEE table
USE MCLabor
GO
CREATE TABLE dbo.EMPLOYEE
(
	employeeId int IDENTITY(1,1) NOT NULL,
	refCode nvarchar(50),
	firstName nvarchar(50),
	middleName nvarchar(50),
	lastName nvarchar(50),
	loginId int NOT NULL,
	address nvarchar(100),
	city nvarchar(50),
	state nvarchar(25),
	zip int,
	ssn nvarchar(20),
	primaryPhone nvarchar(20),
	alternatePhone nvarchar(20),
	emergencyContactName nvarchar(100),
	emergencyContactRelationship nvarchar(25),
	emergencyContactAddress nvarchar(100),
	emergencyContactCity nvarchar(50),
	emergencyContactState nvarchar(25),
	emergencyContactZip int,
	emergencyContactPhone nvarchar(20),
	CONSTRAINT PK_EMPLOYEE PRIMARY KEY CLUSTERED(employeeId ASC)
)
	
