if exists (select * from dbo.sysobjects where id = object_id(N'tbadmin') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table tbadmin
GO

CREATE TABLE tbadmin
(	loginid varchar(50) not null primary key,
	loginpwd varchar(50) not null 
)
GO

if exists (select * from dbo.sysobjects where id = object_id(N'tbdepartment') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table tbdepartment
GO

CREATE TABLE tbdepartment
(	depID varchar(50) not null primary key,
	depname varchar(50)  null,
	depphone varchar(50)  null
)
GO

if exists (select * from dbo.sysobjects where id = object_id(N'tbclass') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table tbclass
GO

CREATE TABLE tbclass
(	classID varchar(50) not null primary key,
	classname varchar(50) null,
	depID varchar(50)  null,
	studentnum int null
)
GO

if exists (select * from dbo.sysobjects where id = object_id(N'tbstudent') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table tbstudent
GO

CREATE TABLE tbstudent
(	studentID int not null IDENTITY(1,1) primary key,
	loginid varchar(50) null,
	loginpwd varchar(50) null,
	studentNO varchar(50),
	studentname varchar(50) null,
	classID varchar(50),
	Sex char (2),
	studentIDCard varchar(50),
	phone varchar(50) null,
	email varchar(50) null,
	userstate int null
)
GO

if exists (select * from dbo.sysobjects where id = object_id(N'tbcourse') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table tbcourse
GO

CREATE TABLE tbcourse
(	courseID varchar(50) not null primary key,
	coursename varchar(50) null,
	coursecredit int
)
GO

if exists (select * from dbo.sysobjects where id = object_id(N'tbteacher') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table tbteacher
GO

CREATE TABLE tbteacher
(	teacherID varchar(50) primary key,
	teacherName varchar(50),
	loginpwd varchar(50),
	depname varchar(50),
        coursename varchar(50),
	userstate int null
)
GO


if exists (select * from dbo.sysobjects where id = object_id(N'tbscore') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table  tbscore
GO

CREATE TABLE tbscore
(	studentNO varchar(50) not null,
	courseID varchar(50) ,
	score int,
	term int,
	Year varchar(10)
)
GO
