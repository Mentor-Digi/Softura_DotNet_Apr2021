sp_help tblEmployee

create table tblEmployee
(id int identity(101,1) primary key,
name varchar(20),
age int default 18,
manager_id int)

alter table tblEmployee
add constraint fk_mgrId foreign key(manager_id) references tblEmployee(id)

insert into tblEmployee(name,age) values('Ramu',35)
insert into tblEmployee(name,age) values('Somu',31)
insert into tblEmployee(name,age,manager_id) values('Sita',21,101)
insert into tblEmployee(name,age,manager_id) values('Geeta',22,101)
insert into tblEmployee(name,age,manager_id) values('Anita',20,102)



select * from tblEmployee

select id,manager_id from tblEmployee

select emp.id employee_id,emp.name employee_name, 
mgr.id manager_id ,mgr.name manager_name
from tblEmployee emp left outer join
tblEmployee mgr on emp.manager_id = mgr.id


select * from employee cross join sales

create procedure proc_example
as
begin
    select * from authors
end

exec proc_example

create proc proc_SampleInput(@un varchar(20))
as
begin
   select @un
end

exec proc_SampleInput 'Ramu'

alter proc proc_SampleInput(@un varchar(20))
as
begin
   select concat('Welcome ',@un)
end

alter proc proc_SampleInput(@un varchar(20),@gen varchar(6))
as
begin
	if(@gen = 'Male')
	begin
		select concat('Welcome Mr. ',@un)
	end
    else
	begin
		select concat('Welcome Miss. ',@un)
    end
end

exec proc_SampleInput 'Ramu', 'Male'
exec proc_SampleInput 'Rita', 'Female'

create proc proc_FetchTitleUsingAuthorName(@auname varchar(50))
as
begin
   select * from titles where title_id in
   (select title_id from titleauthor where au_id in
   (select au_id from authors where au_fname = @auname))
end

select * from authors
exec proc_FetchTitleUsingAuthorName 'Dean'
--Create a sp for printing the sale details if a title name is given
create proc proc_FetchsaleUsingTitle(@title varchar(50))asbegin   select *  from sales where title_id in   (select title_id from titles where title  = @title)end

proc_FetchsaleUsingTitle 'You Can Combat Computer Stress!'
--given a title name comment on its sale
--print good if the title is sold more than once 
alter proc proc_CommentOnTitleSale(@title varchar(50))--parameter
as
begin
   declare--variable declaration
   @saleCount int
   --set is a keyword for assignment
   set @saleCount = (select count(*) from sales where title_id =(select title_id from titles where title = @title))
   if(@saleCount >1)
      select concat('Good sales. Number ',@saleCount)
   else
      select concat('Not that great. Count is ',@saleCount)
end
exec proc_CommentOnTitleSale 'You Can Combat Computer Stress!'
exec proc_CommentOnTitleSale 'The Busy Executive''s Database Guide'

select title_id,count(*) from sales group by title_id

select * from titles where title_id = 'BU1032'

--Alter the procedure so that it allows only 6 employees under every manager
create proc proc_InsertEmployee(@ename varchar(20), @eage int,@emgrid int)
as
begin
      if(@emgrid =0)
		insert into tblEmployee(name,age) values(@ename,@eage)
	  else
		insert into tblEmployee(name,age,manager_id) values(@ename,@eage,@emgrid)
end
alter proc proc_InsertEmployee(@ename varchar(20), @eage int,@emgrid int)
as
begin
      if(@emgrid =0)
		insert into tblEmployee(name,age) values(@ename,@eage)
	  else
	  begin
	  declare
		 @empCount int
		 set @empCount = (select count(*) from tblEmployee where manager_id = @emgrid)
		 if(@empCount < 6)
			insert into tblEmployee(name,age,manager_id) values(@ename,@eage,@emgrid)
		 else
		    select 'Manager already has 6 employees'
	  end
end

drop proc proc_InsertEmployee
exec proc_InsertEmployee 'Jill',22,101

select * from tblEmployee

create proc proc_UnderstandingOutParameter(@dataIn int,@dataOut int out )
as
begin
    set @dataOut = @dataIn * 100;
end

declare 
@myData int
exec proc_UnderstandingOutParameter 25,@myData out
select @myData


create table tblSampleDate(dob date)

insert into tblSampleDate values('2021-04-26')

select * from tblSampleDate


