create database dbDay8Question

use dbDay8Question

create table Employees
(id int identity(100,1) primary key,
Name varchar(20),
age int check(age>18),
phone varchar(15) not null,
gender varchar(15) check(gender in('Male','Female')))

create table Salary
(id int identity(1,100) primary key,
basic float,
hra float,
da float,
deductions float)

create table EmployeeSalary
(transaction_id int primary key,
employee_id int references Employees(id),
salary_id int references Salary(id),
salary_date date,
constraint uq_emp_sal unique(employee_id,salary_id,salary_date))

select * from Employees

select * from Salary

insert into EmployeeSalary values(1001,100,101,'2010-12-28')
insert into EmployeeSalary values(1002,100,101,'2011-01-28')
insert into EmployeeSalary values(1003,100,101,'2011-02-28')
insert into EmployeeSalary values(1004,101,1,'2011-01-28'),(1005,102,201,'2011-01-28')
insert into EmployeeSalary values(1006,100,1,'2011-03-28')

select * from EmployeeSalary

alter table employees
add Email varchar(100)

update Employees set email='ramu@gmail.com' where id=100

create proc proc_PrintNetSal(@eid int,@sdate date)
as
begin
  select (basic+hra+da-deductions) from EmployeeSalary es join Salary s
  on es.salary_id = s.id
  where es.employee_id = @eid and es.salary_date = @sdate
end

exec proc_PrintNetSal 100 ,'2010-12-28'

create proc proc_PrintAverageSalary(@eid int)
as
begin
  select avg(basic+hra+da-deductions) from EmployeeSalary es join Salary s
  on es.salary_id = s.id
  where es.employee_id = @eid 
end

exec proc_PrintAverageSalary 100

create proc proc_CalculateTax(@eid int,@tax float out)
as
begin
declare
@total float,
@taxPayable float
  set @total = (select sum(basic+hra+da-deductions) from EmployeeSalary es join Salary s
  on es.salary_id = s.id
  where es.employee_id = @eid )
  if(@total<100000)
	set @tax = 0
  else if(@total>100000 and @total<200000)
    set @tax = 5
  else if(@total>200000 and @total<350000)
    set @tax = 6
  else 
    set @tax = 7.5
  set @taxPayable = @total*@tax/100
  select concat('Total tax ',@taxPayable)
end

declare 
@myTax float
exec proc_CalculateTax 100, @myTax out
print @myTax

 select sum(basic+hra+da-deductions) from EmployeeSalary es join Salary s
  on es.salary_id = s.id
  where es.employee_id = 100

  create function fn_CalSal(@basic float,@hra float,@da float,@ded float)
  returns float
  as
  begin 
	  declare 
	  @netSal float
	  set @netSal = @basic+@hra+@da-@ded
	  return @netSal
  end

  select basic,hra,da,deductions,dbo.fn_CalSal(basic,hra,da,deductions) 'Net Total' from Salary

  create function fn_PrintCompleteSalDetails(@eid int)
  returns @EmpSalTax Table
  (
     Ename varchar(15), 
	 TotalSal float,
	 Tax float)
	as
	begin
	declare
		@total float,
		@tax float,
		@taxPayable float,
		@Ename varchar(15)
		  set @total = (select sum(basic+hra+da-deductions) from EmployeeSalary es join Salary s
		  on es.salary_id = s.id
		  where es.employee_id = @eid )
		  if(@total<100000)
			set @tax = 0
		  else if(@total>100000 and @total<200000)
			set @tax = 5
		  else if(@total>200000 and @total<350000)
			set @tax = 6
		  else 
			set @tax = 7.5
		  set @taxPayable = @total*@tax/100
		  set @ename = (select name from employees where id = @eid)
		  insert into @EmpSalTax values(@Ename,@total,@taxPayable)
		  return
	end

select * from dbo.fn_PrintCompleteSalDetails(100)

select * from EmployeeSalary

create table EmployeeNetSal
(transaction_id int,
netSal float)

create table btblDummy
(f1 int,
f2 varchar(20))

create trigger trgInsertDummy
on btblDummy
after Insert
as
begin
   select 'Hello there!!!!'
end

select * from btblDummy

drop trigger trgInsertDummy

insert into btblDummy values(2,'Ramu')

create trigger trgInsertDummy
on btblDummy
after Insert
as
begin
 select concat('Hello there!!!!',f2) from inserted
end

select * from employeenetsal
select * from salary
select * from EmployeeSalary

create trigger trg_InsertNetSal
on EmployeeSalary
after insert
as
begin
   declare
   @totalSal float
   set @totalSal = (select dbo.fn_CalSal(basic,hra,da,deductions) from Salary where id = (select Salary_id from inserted))
   insert into employeeNetSal values((select transaction_id from inserted),@totalSal)				
end

insert into EmployeeSalary values(1007,102,201,'2011-03-28')

--create a trigger for the employee table which prints a welcome messgae to the employee
--example
--Welcome Mr. Ramu
--Welcome Miss. Lata
 create trigger trg_Welcome1 on Employees after Insert as begin   if((select gender from inserted)='male')     select concat('Welcome  Mr.',name) from inserted   else if((select gender from inserted)='female')     select concat('Welcome Miss.',name) from inserted end
 drop trigger trgWelcome

 create trigger trgWelcomeon Employeesafter Insertasbegin	declare 	@gender varchar(20)	set @gender=(select gender from inserted)	if(@gender='Male')	select concat('Welcome - Mr.',name) from inserted	else	select concat('Welcome - Miss.',name) from insertedend

select * from EmployeeSalary
select * from Employees

 insert into employees(name,age,gender,phone,email) values('Fomu',21,'female','1234567888','Fomu@gmail.com')

 insert into EmployeeSalary values(1007,108,101,'2021-04-27')


 --does all or does not do it at all
 begin transaction 
    insert into employees(name,age,gender,phone,email) values('Yomu',27,'Male','6578567888','Yomu@gmail.com')
	insert into EmployeeSalary values(1007,110,101,'2021-04-27')
   if((select max(employee_id) from employeesalary)=111)
		commit
	else
	    rollback--all DML queries from begin tran

--for every customer
--Print Customer Name
--The salary details for very date

select * from Employees
select * from salary
select * from EmployeeSalary
--cursor
--Declare,Open,Fetch,close,deallocate
declare @eid int,@ename varchar(15)
declare cur_employee cursor for
select id,name from employees
open cur_employee
fetch next from cur_employee 
into @eid,@ename
print 'Employee Data'
while @@FETCH_STATUS =0
begin
  print 'Employee Id : '+Cast(@eid as varchar(10))
  print 'Employee Name : '+@ename
  print '-----------------------------'
  fetch next from cur_employee 
  into @eid,@ename
end
close cur_employee
deallocate cur_employee


--for every employee
--Print employee Name
--The salary details for very date
declare @eid int,@ename varchar(15)
declare cur_employee cursor for
select id,name from employees
open cur_employee
fetch next from cur_employee 
into @eid,@ename
print 'Employee Data'
while @@FETCH_STATUS =0
begin
  print 'Employee Id : '+Cast(@eid as varchar(10))
  print 'Employee Name : '+@ename
  print '-----------------------------'
  declare
  @sid int,@date date,@Total float
  declare cur_empSal cursor for
  select salary_id,salary_date from EmployeeSalary where employee_id = @eid
  open cur_empSal
  fetch next from cur_empSal into @sid,@date
  print '##############################'
  print 'Salary Details'
  while @@FETCH_STATUS =0
  begin
      set @Total = (select basic+hra+da-deductions from Salary where id = @sid)
	  print 'Date : '+Cast(@date as varchar(20))
	  print 'Net Salary : '+Cast(@Total as varchar(20))
	  fetch next from cur_empSal into @sid,@date
  end
  print '##############################'
  close cur_empSal
  deallocate cur_empSal
  fetch next from cur_employee 
  into @eid,@ename
end
close cur_employee
deallocate cur_employee





