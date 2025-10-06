use VehicleMakesDB;

--  select statments
select * from VehicleDetails ;
select * from Makes;
select * from MakeModels ;
select * from SubModels ;
select * from Bodies ;
select * from DriveTypes ;
select * from FuelTypes;

-- select distinct
select distinct  ModelID from VehicleDetails ;

--Where Statement + AND , OR, NOT
select * from VehicleDetails
where MakeID = 2 ;

select * from VehicleDetails
where MakeID = 2 and BodyID = 16; 

select * from VehicleDetails 
where MakeID = 2 Or MakeID = 3 ;

select * from VehicleDetails 
where NOt (MakeID = 2 Or MakeID =3) ;


--'IN' Operator
select * From VehicleDetails 
where BodyID IN (16,15) ;

-- Sorting: order by
select * from VehicleDetails 
order by ModelID ASC;

select * from VehicleDetails 
order by ModelID  DESc ;

--Top statment
select Top 10 * from VehicleDetails ;

--Select AS 
select ID As 'VehicleDetailID' , Year 'Make At' 
from VehicleDetails;

select 'VehicleDetil ID'=ID , MakeAT=Year 
from VehicleDetails;

--Between Operator
select * From VehicleDetails 
where Year between 1990 and 2000
order by Year ;

-- aggregation function=> Count(),Min, Max , Sum , AVG

select count (*) AS NumbreOfRows
from VehicleDetails ;

select Min(ID) MinimumID
from VehicleDetails ;

select Max(Year) LastYear
from VehicleDetails ;

--Group by
select MakeID , count(*) NumberOfVehicles
from VehicleDetails
group by MakeID
order by MakeID;

-- group by query 
select MakeID, ModelID, count(*) NumberOfVehicles

from VehicleDetails
group by MakeID,ModelID
order By MakeID;

--having statment
-- Note where statment must come before group by and having statments
select MakeID,ModelID , count(*) NumberOfVehicles
from VehicleDetails
where ModelID IN (615,7477,4526)
group by MakeID , ModelID
having count(*) between 6 and 8
 
order by 3

--Like statment 
select * from VehicleDetails
where Vehicle_Display_Name LIKe 'AC %' ;

select * from VehicleDetails
where Vehicle_Display_Name LIKe 'acur_ %' ;

--Wild Cards

select * from VehicleDetails 
where Vehicle_Display_Name like 'Acura RSX 200[36]%'

select * from VehicleDetails 
where Vehicle_Display_Name like 'Acura RSX 200[^36]%'

--Search for
select * from VehicleDetails 
where Vehicle_Display_Name like 'Acura RSX 200[1-9]%';

-- search for rang [1-20] like following 
select * from VehicleDetails 
where Vehicle_Display_Name like 'Acura RSX 200[0-9]%'
	OR Vehicle_Display_Name like 'Acura RSX 201[0-9]'
	OR Vehicle_Display_Name like 'Acura RSX 2020'

--Join statment 
select v.ID, v.MakeID, m.Make , v.Vehicle_Display_Name 
from VehicleDetails v 
join 
Makes m 
on v.MakeID = m.MakeID
where m.MakeID = 2;

-- select all the cars with thier bodies 
select  v.BodyID ,b.BodyName  , count(*) as NumberOfVehiclesUsingBody
from VehicleDetails v
join Bodies b
on v.BodyID = b.BodyID 
group by v.BodyID ,b.BodyName 
order by v.BodyID ;

select ID, Engine
from VehicleDetails 
where Exists
		(select top 1 X='Yes' from FuelTypes
		 where  VehicleDetails.FuelTypeID = FuelTypes.FuelTypeID
		)

select ID ,MakeID ,
NumOfDoors=
Case 
	when NumDoors is null then 0
	else 
	NumDoors

end

From VehicleDetails 
order by NumOfDoors desc 