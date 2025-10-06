


--create database koko;

-- check if the database name already exists or not 
if not exists(select * from sys.databases where name ='koko')
begin 
	create database koko;
end

-- this for showing all the databases in the server
--select * from sys.databases  ;

-- we use this to drop database 
drop database DB1;

-- first we check if the database exist 
if exists (select * from sys.databases where name ='kok')
begin
drop database koko;
end

--- -----------------------------------------

-- create table
use DB1;

Create table Employees(
ID int Not NULL,
Name nvarchar(50) not null,
Phone nvarchar(10) NULL,
Salary smallmoney NULL,
Primary key(ID)

);
--- drop a table from the database 
use DB1;
drop table Employees;






