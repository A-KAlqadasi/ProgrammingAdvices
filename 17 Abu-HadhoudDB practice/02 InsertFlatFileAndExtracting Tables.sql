--create database CarsData ;
use CarsData;

-- extracting tables from the carsData 

--create table Makes (
--	MakeID int identity(1,1) ,
--	MakeName nvarchar(50) not null ,
--	constraint pk_Makes primary key(MakeID)

--);

select * from CarsDetails;
select * from Makes ;

-- this is how to insert data between two tables
insert into Makes
select distinct Make from CarsDetails
order by Make ASC ;

--Update the MakeID in the CarsDetails table based on the Makes table 
-- 

update CarsDetails
Set MakeID = (select MakeID from Makes  where CarsDetails.Make = MakeName)

-- select the makeID and the makeName 

select ymm_id ,C.MakeID ,M.MakeName
from CarsDetails as C 
inner join Makes M
on (C.MakeID = M.MakeID) ;


