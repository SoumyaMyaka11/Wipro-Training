CREATE TABLE STUDENT(
    Student_id INT PRIMARY KEY,
	FirstName VARCHAR(50),
	LastName VARCHAR(50),
	Age INT ,
	Department VARCHAR(50),
	Marks INT 
	);

insert into student(student_id,firstname,lastname,age,department,marks)
values
(4,'keerthi','busa',22,'electrical',85),
(5,'harshika','chavva',21,'electrical',80);

select * from student;

select * from student  where Department = 'computer science';

update student set marks = 95 where student_id = 3;
update student set marks = 75 where student_id = 2;
update student set marks = 90 where student_id = 1;

insert into student(student_id,firstname,lastname,age,department,marks)
values
(6,'harshitha','bandham',22,'mechanical',85),
(7,'deepika','seepathi',23,'IT',90);

update student set department = 'IT' where firstname ='amit';

delete from student where student_id = 1;
delete from student where marks<50;
delete from student where student_id =2;

truncate table student;

drop table student;