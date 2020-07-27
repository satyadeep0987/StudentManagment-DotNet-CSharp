create database Student

use Student

create table Course
(
	CID int constraint pk_cid primary key identity,
	CourseName varchar(50) not null,
	fees bigint not null,
	Duration varchar(10) not null,
)

drop table Course

create proc sp_coures(@cname varchar(50),@fees bigint,@dur varchar(10),@cid int out)
as
begin
	insert into Course values(@cname,@fees,@dur)
	select @cid = @@IDENTITY
end


create table Teacher
(
	TID int constraint pk_tid primary key identity,
	TeacherName varchar(50) not null,
	Subject varchar(50) not null,
	Qualification varchar(50) not null,
)

drop table Teacher

create proc sp_teacher(@name varchar(50),@sub varchar(50),@Quali varchar(50), @tid int out)
as
begin
	insert into Teacher values(@name,@sub,@Quali)
	select @tid = @@IDENTITY
end


create table studentInfo
(
	SID int constraint pk_sid primary key identity,
	Fname varchar(30) not null,
	Sname varchar(30),
	Address varchar(50) not null,
	Email varchar(30) not null,
	PinCode bigint not null,
	Contact bigint not null,
	StartDate varchar(30) not null,
	Enddate varchar(30) not null,
	CID int references course (CID),
	TID int references teacher(TID),
	college varchar(50) not null,
	fees bigint not null,
	Detail varchar(50) not null,
	FeesPaid bigint,
	RemFees bigint,
)

drop table studentInfo

create proc sp_StudentInfo(@fn varchar(30),@sn varchar(30),@ad varchar(50),@em varchar(30),@pin bigint,@con bigint,@sd varchar(30),@ed varchar(30),@cid int,@tid int,@col varchar(50),@fee bigint,@det varchar(50),@fp bigint,@rf bigint,@sid int out)
as
begin
	insert into studentInfo values(@fn,@sn,@ad,@em,@pin,@con,@sd,@ed,@cid,@tid,@col,@fee,@det,@fp,@rf)
	select @sid = @@IDENTITY
end

declare @id int
exec sp_StudentInfo "ane","ss","add","sd",23,45,"23","4",7,1,"col",200,"dhdh",20,30,@id out
print @id