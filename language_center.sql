SELECT name, type_desc, is_disabled 
FROM sys.server_principals
WHERE type IN ('S', 'U', 'G')  -- S = SQL user, U = Windows user, G = Windows group
ORDER BY name;

SELECT name, is_disabled FROM sys.sql_logins WHERE name = 'sa';

ALTER LOGIN sa ENABLE;

ALTER LOGIN sa WITH PASSWORD = 'admin123';

--______________________________________________________________________________________________________________________________________

create database language_center
use language_center


	create table Course_Name
	(
		cID int primary key Identity(1,1),
		cName nvarchar(50) not null,
		cPrice varchar(50)
	)

insert into Course_Name (cName,cPrice) values ('Arabic',150);
insert into Course_Name (cName,cPrice) values ('English',200);
insert into Course_Name (cName,cPrice) values ('French',300);
insert into Course_Name (cName,cPrice) values ('Chinese',500);
insert into Course_Name (cName,cPrice) values ('German',300);


	create table Teacher
	(
		tID int  primary key identity(1,1),
		tFName varchar(50) not null,
		tLName varchar(50) not null,
		tGender varchar(50),
		tAge int,
		Salary varchar(50),
		Course int,
		Foreign key (Course) References Course_Name(cId)
	)

insert into Teacher(tFName,tLName,tGender,tAge,Salary,Course)Values ('Catherine','Deneuve','Female',36,'30000',3);
insert into Teacher(tFName,tLName,tGender,tAge,Salary,Course)Values ('Zanila','Zhao','Male',45,'60500',4);
insert into Teacher(tFName,tLName,tGender,tAge,Salary,Course)Values ('Emma','Thompson','Fmale',41,'70000',2);
insert into Teacher(tFName,tLName,tGender,tAge,Salary,Course)Values ('Bill','Kaulitz','Male',27,'20000',5);
insert into Teacher(tFName,tLName,tGender,tAge,Salary,Course)Values ('Kadim','Al Shahir','Male',48,'52000',1);
insert into Teacher(tFName,tLName,tGender,tAge,Salary,Course)Values ('Daniel','Radcliffe','Male',34,'30000',2);
insert into Teacher(tFName,tLName,tGender,tAge,Salary,Course)Values ('Ragheb','Alama','Male',35,'60000',1);
insert into Teacher(tFName,tLName,tGender,tAge,Salary,Course)Values ('Christopher','Lambert','Male',32,'40000',3);
insert into Teacher(tFName,tLName,tGender,tAge,Salary,Course)Values ('Dominic','Monaghan','Male',28,'20000',5);
insert into Teacher(tFName,tLName,tGender,tAge,Salary,Course)Values ('Carla','Bruni','Fmale',40,'60300',3); 
insert into Teacher(tFName,tLName,tGender,tAge,Salary,Course)Values ('Hamdan','Maktoum','Male',45,'60000',1);
insert into Teacher(tFName,tLName,tGender,tAge,Salary,Course)Values ('Duan','Yihong','Male',40,'70000',4);
  

	create table Student
	(
		sID int Identity(1,1),
		sFName varchar(50) not null,
		sLName varchar(50) not null,
		Gender varchar(50),
		Age varchar(50),
		CoursePrice varchar(50),
		Course_ID int,
		Foreign key (Course_ID) References Course_Name(cId),
		Paid varchar(50),
		Teacher int,
		Foreign key (Teacher) References Teacher(tID)
     )





insert into Student(sFName,sLName,Gender,Age,CoursePrice,Paid,Teacher) values('Ahmed','Mohsen','Male','18','300','300',1);
insert into Student(sFName,sLName,Gender,Age,CoursePrice,Paid,Teacher) values('Mona','Fathy','Female','16','200','200',3);
insert into Student(sFName,sLName,Gender,Age,CoursePrice,Paid,Teacher) values('Menna','Jamal','Female','21','500','500',12);
insert into Student(sFName,sLName,Gender,Age,CoursePrice,Paid,Teacher) values('Ali','Yasser','Male','16','200','200',2);
insert into Student(sFName,sLName,Gender,Age,CoursePrice,Paid,Teacher) values('Ali','Omran','Male','31','150','150',5);






--______________________________________________________________________________________________________________________________________




select sFName,sLName,Gender,Age,CoursePrice,Paid,Teacher,tFName,tLName,tGender,tAge,Salary,Course
from Student,Teacher
 where tID=Teacher


--select cName,tFName,tLName,tGender,tAge,Salary
-- from CourseName,Teachers
-- where cId = Course

 select cID,cName,cPrice from Course_Name

 select tID,tFName,tLName,tGender,tAge,Salary,cName from Teacher, Course_Name where cId = Course


