--all columns
select * from authors
--projection - restriction on columns for display
select au_lname,au_fname from authors
--Giving alias name for columns for display
select au_fname First_Name, au_lname Last_Name from authors
--Selection - filter the rows
select * from authors where state = 'CA'
select * from authors where state != 'CA'
Select * from employee where minit is not null
select * from employee where job_id>10
select * from employee where job_id<10
select * from employee where job_id>10 and job_id<15
select * from employee where job_id between 10 and 15
select * from employee where job_id=11 or job_id=14 or job_id=6
--same as above
select * from employee where job_id in(11,14,6)
select * from employee where job_id!=11 or job_id!=14 or job_id!=6
select * from employee where job_id!=11 and job_id!=14 and job_id!=6
--same as above
select * from employee where job_id not in(11,14,6)
select * from employee where fname ='Maria'
select * from employee where fname != 'Maria'
--first 3 char should be mar then any number of char and any chars
select * from employee where fname like'Mar%'
--first char can be anything the second char should be o and then any chars any number of chars
select * from employee where fname like '_o%'

select emp_id from employee where fname like '_o%'
select fname,lname from employee where job_id not in(11,14,6)

select * from titles
--Unique values of a repeaded data column
select distinct pub_id from titles
--aggregate
select sum(advance) total from titles
select count(advance) number_count from titles
select min(advance) minimum from titles
select max(advance) maximum from titles
select avg(advance) average from titles

select count(*) number_count from titles where pub_id=0877
select count(*) number_count from titles where pub_id=1389
--group by(for every)
select pub_id,count(*) number_count from titles group by  pub_id
--average advance for the titles pushed by every publisher
select pub_id,avg(advance) average_advance from titles group by  pub_id
select pub_id,count(title) ,avg(advance) average_advance from titles group by  pub_id

select * from sales
--print the sum of quantity for every title
select title_id ,sum(qty) sum_quantity from sales group by title_id
--Prselect type,avg(royalty) average_royalty from titles group by type
select type,avg(royalty) average_royalty from titles group by type
--Print the number of orders placed in every store
select stor_id, count(payterms) as Number_of_orders from sales group by stor_id
--Print the number of orders placed in every store where the number of orders are more than 2
select stor_id, count(payterms) as Number_of_orders from sales 
group by stor_id
having count(payterms)>2
--select the average royalty for every type is the average is less than 15
select type,avg(royalty)avg_royalty 
from titles  
group by type 
having avg(royalty)<15
--Sorting
select * from authors order by au_lname
select * from authors order by city
select * from authors order by state,city
select * from authors order by city desc
select * from authors order by phone desc
--update authors set au_lname = 'Paul',au_fname = '' where au_id = '341-22-1782'
--select * from authors where au_id = '341-22-1782'
--order select ,from,where,group by,having ,order by
--select ,from,where,order by
--order select ,from,where
--order select ,from ,group by,having ,order by
--order select ,from,where,group by
--order select ,from,where,group by,having 
--order select ,from order by
--Sub Query
select * from titles
select * from sales
--Print teh sales of teh title 'The Gourmet Microwave'
select * from sales where title_id = 'MC3021'
select title_id from titles where title = 'The Gourmet Microwave'
--instead
select * from sales where title_id = 
(select title_id from titles where title = 'The Busy Executive''s Database Guide')
select * from publishers
select * from sales where title_id in 
(select title_id from titles where pub_id = 
(select pub_id from publishers where pub_name='New Moon Books'))

select title_id,sum(qty) sum_Of_quantity from sales where title_id in 
(select title_id from titles where pub_id = 
(select pub_id from publishers where pub_name='New Moon Books'))
group by title_id
having sum(qty)<=25
order by sum_Of_quantity

--print the title name and the sale quantity
--titl name is titles table and sale quantity is in sales
--inner join- fetches the related data from both the table
select title ,qty from titles join sales 
on
titles.title_id = sales.title_id
--with instance
select title ,qty from titles t join sales s
on
t.title_id = s.title_id

--Print the title_id in the sales table
select title_id from sales
--Print the unique title_id in the sales table
select distinct title_id from sales
--Print the  title_id in the titles table that are not in sales table
select title_id  from titles where title_id not in 
(select distinct title_id from sales)

--Join with the title_id
select t.title_id,title ,qty from titles t join sales s
on
t.title_id = s.title_id


--I want all teh titleId and titke name, If it is sold i want the quantity as well
--left outer join - fetch all the records from the left table
--Even if it does not have a matching record in the right side table
select t.title_id,title ,qty from titles t left outer join sales s
on
t.title_id = s.title_id

--print the publisher name and the title name
select pub_name,title from publishers join titleson publishers.pub_id=titles.pub_id

--print all the publisher's name if they have published a title then print the title name too
select pub_name,title from publishers left outer join titleson publishers.pub_id=titles.pub_id
