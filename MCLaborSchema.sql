----
-- MCLabor Schema Creation Script
----

-- Create MCLabor Database
PRINT 'Creating MCLabor Database'
USE master
GO
CREATE DATABASE MCLabor ON PRIMARY 
( NAME = N'MCLabor', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL10_50.MCLABOR\MSSQL\DATA\MCLabor.mdf' , SIZE = 16MB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'MCLabor_log', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL10_50.MCLABOR\MSSQL\DATA\MCLabor_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO


-- Create ADMIN_USER table
PRINT 'Creating ADMIN_USER table'
USE MCLabor
GO
CREATE TABLE dbo.ADMIN_USER
(
	adminUserId int IDENTITY(1,1) NOT NULL,
	userName nvarchar(50) NOT NULL,
	password nvarchar(50) NOT NULL,
	CONSTRAINT PK_ADMIN_USER PRIMARY KEY CLUSTERED(adminUserId ASC),
	CONSTRAINT UC_ADMINUSER_USERNAME UNIQUE (userName)
)
GO


-- Insert ADMIN_USER seed data
PRINT 'Inserting ADMIN_USER seed data'
INSERT INTO ADMIN_USER (userName,password) VALUES ('admin','admin')
GO


-- Create EMPLOYEE table
PRINT 'Creating EMPLOYEE table'
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
	CONSTRAINT PK_EMPLOYEE PRIMARY KEY CLUSTERED(employeeId ASC),
	CONSTRAINT UC_EMP_LOGINID UNIQUE (loginId)
)
GO


-- Create WORK_SITE table
PRINT 'Creating WORK_SITE table'
USE MCLabor
GO
CREATE TABLE dbo.WORK_SITE
(
	workSiteId int IDENTITY(1,1) NOT NULL,
	workSiteName nvarchar(50) NOT NULL,
	refCode nvarchar(50),
	description nvarchar(500),
	active bit DEFAULT 1 NOT NULL,
	CONSTRAINT PK_WORKSITE PRIMARY KEY CLUSTERED(workSiteId ASC)
)
GO


-- Create JOB table
PRINT 'Creating JOB table'
USE MCLabor
GO
CREATE TABLE dbo.JOB
(
	jobId int IDENTITY(1,1) NOT NULL,
	jobName nvarchar(50) NOT NULL,
	refCode nvarchar(50),
	description nvarchar(500),
	CONSTRAINT PK_JOB PRIMARY KEY CLUSTERED(jobId ASC)
)
GO


-- Create PAY_RATE table
PRINT 'Creating PAY_RATE table'
USE MCLabor
GO
CREATE TABLE dbo.PAY_RATE
(
	payRateId int IDENTITY(1,1) NOT NULL,
	employeeId int NOT NULL,
	jobId int NOT NULL,
	hourlyPayRate decimal(10,2)	NOT NULL,
	active bit NOT NULL,
	CONSTRAINT PK_PAYRATE PRIMARY KEY CLUSTERED(payRateId ASC),
	CONSTRAINT FK_EMP_PAYRATE FOREIGN KEY (employeeId) REFERENCES EMPLOYEE(employeeId),
	CONSTRAINT FK_JOB_PAYRATE FOREIGN KEY (jobId) REFERENCES JOB(jobId)
)
GO

PRINT 'Creating PAY_RATE index'
CREATE INDEX IX_PAYRATE1 ON PAY_RATE(employeeId, jobId)
GO


-- Create PAY_RATE_OVERRIDE table
PRINT 'Creating PAY_RATE_OVERRIDE table'
USE MCLabor
GO
CREATE TABLE dbo.PAY_RATE_OVERRIDE
(
	payRateOverrideId int IDENTITY(1,1) NOT NULL,
	jobId int NOT NULL,
	workSiteId int NOT NULL,
	employeeId int,
	overrideHourlyPayRate decimal NOT NULL,
	active bit NOT NULL,
	CONSTRAINT PK_PAYRATEOVERRIDE PRIMARY KEY CLUSTERED(payRateOverrideId ASC),
	CONSTRAINT FK_WORKSITE_PROVERRIDE FOREIGN KEY (workSiteId) REFERENCES WORK_SITE(workSiteId),
	CONSTRAINT FK_JOB_PROVERRIDE FOREIGN KEY (jobId) REFERENCES JOB(jobId)
)
GO

PRINT 'Creating PAY_RATE_OVERRIDE index'
USE MCLabor
GO
CREATE INDEX IX_PAYRATEOR1 ON PAY_RATE_OVERRIDE(jobId, workSiteId)
GO


-- Create LABOR_DETAIL table
PRINT 'Creating LABOR_DETAIL table'
USE MCLabor
GO
CREATE TABLE dbo.LABOR_DETAIL
(
	laborDetailId int IDENTITY(1,1) NOT NULL,
	employeeId int NOT NULL,
	workSiteId int NOT NULL,
	jobId int NOT NULL,	
	laborCalendarDate DATE NOT NULL,
	laborStartDateTime DATETIME NOT NULL,
	laborEndDateTime DATETIME,
	laborStartUTCDateTime DATETIME NOT NULL,
	laborEndUTCDateTime DATETIME,
	CONSTRAINT PK_LABORDETAIL PRIMARY KEY CLUSTERED(laborDetailId ASC),
	CONSTRAINT FK_EMP_LABORDTL FOREIGN KEY (employeeId) REFERENCES EMPLOYEE(employeeId),
	CONSTRAINT FK_WORKSITE_LABORDTL FOREIGN KEY (workSiteId) REFERENCES WORK_SITE(workSiteId),
	CONSTRAINT FK_JOB_LABORDTL FOREIGN KEY (jobId) REFERENCES	JOB(jobId)
)
GO

PRINT 'Creating LABOR_DETAIL index'
USE MCLabor
GO	
CREATE INDEX IX_LABORDTL1 ON LABOR_DETAIL (employeeId, workSiteId, jobId, laborCalendarDate DESC)
GO

PRINT 'Creating HIRE_STATUS_ENUM table'
USE MCLAbor
GO
CREATE TABLE dbo.HIRE_STATUS_ENUM
(
	status int NOT NULL,
	description nvarchar(200),
	CONSTRAINT PK_HIRESTATUSENUM PRIMARY KEY (status)
)
GO


PRINT 'Inserting Seed Data into HIRE_STATUS_ENUM'
USE MCLabor
GO
INSERT INTO HIRE_STATUS_ENUM VALUES(0,'Full Time');
INSERT INTO HIRE_STATUS_ENUM VALUES(1,'Part Time');
INSERT INTO HIRE_STATUS_ENUM VALUES(2,'Laid Off / Unemployment');
INSERT INTO HIRE_STATUS_ENUM VALUES(3,'Terminated - Rehirable');
INSERT INTO HIRE_STATUS_ENUM VALUES(4,'Terminated - Non-Rehirable');
GO


PRINT 'Creating EMP_HIRE_STATUS table'
USE MCLabor
GO
CREATE TABLE dbo.EMP_HIRE_STATUS
(
	empHireStatusId int IDENTITY(1,1) NOT NULL,
	employeeId int NOT NULL,
	status int NOT NULL,
	statusStartDate DATE NOT NULL default(getDate()),
	statusEndDate DATE,
	terminationReason nvarchar(1000),
	CONSTRAINT PK_EMPHIRESTATUS PRIMARY KEY (empHireStatusId),
	CONSTRAINT FK_HIRESTATUS_EMP FOREIGN KEY (employeeId) REFERENCES EMPLOYEE (employeeId),
	CONSTRAINT FK_HIRESTATUS_HSENUM FOREIGN KEY (status) REFERENCES HIRE_STATUS_ENUM (status)
)
GO

PRINT 'Creating EMP_HIRE_STATUS index'
USE MCLabor
GO
CREATE INDEX IX_EMPHIRESTATUS1 ON EMP_HIRE_STATUS (employeeId, status)
GO
	
	
