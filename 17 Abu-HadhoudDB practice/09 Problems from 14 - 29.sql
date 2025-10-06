--Problem Solving ProgrammingAdvices.com

Use VehicleMakesDB;

--  Problem 14: Get all Makes with make starts with 'B'
select * from Makes 
where Make like 'B%' ;


--  Problem 15: Get all Makes with make ends with 'W'
select * from Makes 
where Make like '%W';

--  Problem 16: Get all Makes that manufactures DriveTypeName = FWD
select distinct m.Make ,dt.DriveTypeName

from VehicleDetails v 
join Makes m
on (m.MakeID = v.MakeID)
join DriveTypes dt
on (dt.DriveTypeID = v.DriveTypeID)

where dt.DriveTypeName = 'FWD'


--  Problem 17: Get total Makes that Mantufactures DriveTypeName=FWD
select count(*) as TotalMakeWithFWD
from
(
	select distinct m.Make ,dt.DriveTypeName

	from VehicleDetails v 
	join Makes m
	on (m.MakeID = v.MakeID)
	join DriveTypes dt
	on (dt.DriveTypeID = v.DriveTypeID)

	where dt.DriveTypeName = 'FWD'
) R1 ;


--  Problem 18: Get total vehicles per DriveTypeName Per Make and 
-- order them per make asc then per total Desc
select m.Make, dt.DriveTypeName ,count(*) as Total

from VehicleDetails v
join Makes m
on (v.MakeID = m.MakeID)
join DriveTypes dt
on (v.DriveTypeID = dt.DriveTypeID)
group by m.Make ,dt.DriveTypeName 
order by m.Make asc , Total desc


--  Problem 19: Get total vehicles per DriveTypeName Per Make then 
--filter only results with total > 10,000
select m.Make, dt.DriveTypeName ,count(*) as Total

from VehicleDetails v
join Makes m
on (v.MakeID = m.MakeID)
join DriveTypes dt
on (v.DriveTypeID = dt.DriveTypeID)

group by m.Make ,dt.DriveTypeName
having count(*) > 10000

order by m.Make asc , Total desc


--  Problem 20: Get all Vehicles that number of doors is not specified
select * from VehicleDetails 
where  NumDoors is null ;


--  Problem 21: Get Total Vehicles that number of doors is not specified
select count(*) as TotalVehicleswithNoSpecifiedDoors
from VehicleDetails 
where  NumDoors is null ;


--  Problem 22: Get percentage of vehicles that has no doors specified
select 
(
	cast( 
			(select count(*) as TotalVehicleswithNoSpecifiedDoors
			  from VehicleDetails 
			  where  NumDoors is null ) as float 
		) 
		/
		
		cast ( (select count(*) from VehicleDetails ) as float )
		
)PercOfNoSpecifiedDoors;


--Problem 23: Get MakeID , Make, SubModelName for all vehicles that have SubModelName 'Elite'
select distinct v.MakeID , m.Make, sm.SubModelName
from VehicleDetails v
join Makes m
on (v.MakeID = m.MakeID)
join SubModels sm
on (v.SubModelID = sm.SubModelID)

where sm.SubModelName = 'Elite' ;


--Problem 24: Get all vehicles that have Engines > 3 Liters and have only 2 doors
select * from VehicleDetails 
where Engine_Liter_Display > 3 and NumDoors = 2 ;


--  Problem 25: Get make and vehicles that the engine contains 'OHV' and have Cylinders = 4
select m.Make ,v.*

from VehicleDetails v
join Makes m
on (v.MakeID = m.MakeID) 
where (v.Engine like '%OHV%') and (Engine_Cylinders = 4);


--  Problem 26: Get all vehicles that their body is 'Sport Utility' and Year > 2020
select b.BodyName ,v.* 

from VehicleDetails v 
join Bodies b
on (v.BodyID = b.BodyID)
where b.BodyName = 'Sport Utility' and v.Year > 2020


--  Problem 27: Get all vehicles that their Body is 'Coupe' or 'Hatchback' or 'Sedan'
select b.BodyName ,v.* 

from VehicleDetails v 
join Bodies b
on (v.BodyID = b.BodyID)
where b.BodyName in ('Coupe','Hatchback','Sedan') ;


--Problem 28: Get all vehicles that their body is 'Coupe' or 'Hatchback' or 'Sedan' 
-- and manufactured in year 2008 or 2020 or 2021

select b.BodyName ,v.* 

from VehicleDetails v 
join Bodies b
on (v.BodyID = b.BodyID)
where b.BodyName in ('Coupe','Hatchback','Sedan') and v.Year IN (2008,2020,2021) ;


--  Problem 29: Return found=1 if there is any vehicle made in year 1950

select found=1 
where EXists (
	select top 1  C='x' from VehicleDetails 
	where Year = 1950 
);

--Abu-hadhoud way
select found=1 
where 
exists (
        select top 1 * from VehicleDetails where Year =1950
      )


