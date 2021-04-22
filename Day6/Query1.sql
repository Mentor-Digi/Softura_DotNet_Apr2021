--creates a database
create database dbSoftTraining
--Select the database created
use dbSoftTraining
--DDL
create table tblSample
(id int, 
name varchar(20)
)
select * from tblSample
sp_help tblSample

drop table tblSample

create table skills
(skill_name varchar(20) primary key,
skill_description text
)
sp_help skills

drop table skills

create table skills
(skill_name varchar(20) constraint pk_skill primary key,
skill_description text
)

create table Cities
(zip_code char(4),
city varchar(20),
primary key(zip_code)
)
sp_help Cities

create table Employees
(id char(4) primary key,
name varchar(20) not null,
phone varchar(15) not null,
zip char(4) references Cities(zip_code))

sp_help Employees

create table employeeSkill
(employee_id char(4) references employees(id),
skill_name varchar(20) references skills(skill_name),
skill_level float default 1,
constraint pk_empskill primary key(employee_id,skill_name))

sp_help employeeSkill

insert into skills(skill_name,skill_description)
values('C','PLT')
insert into skills values('C++','OOPS')
insert into skills values('h',null)
insert into skills(skill_description,skill_name)
values('Web','Java')
--will fail due to duplication
insert into skills values('C++','OOPS')
--will fail since primary key cannot be null
insert into skills values(null,'OOPS')
--Will fail because of varchar size
insert into skills values('dgjhjlojsnnjsjchsjkchsdjkckjsdhds','OOPS')

sp_help skills


select * from skills

update skills set skill_description = 'something'
where skill_name='h'--where clause - filtering the records

delete from skills where skill_name='h'

insert into Cities	values('1234','ABC')
insert into Cities	values('3211','DFG')

select * from employeeSkill

insert into employees values('E001','Ramu','1234567890','1234')
insert into employees values('E002','Somu','9876543210','3211')
insert into employees values('E003','Somu','9876543210','3211'),('E004','Somu','9876543210','3211')

insert into employeeSkill values('E001','C',7)
insert into employeeSkill values('E001','C++',7)
insert into employeeSkill values('E003','C',7)
insert into employeeSkill values('E003','Java',default)
insert into employeeSkill(employee_id,skill_name)
values('E002','Java')

delete from Cities where zip_code = '1234'