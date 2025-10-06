--Problem Solving ProgrammingAdvices.com

Use VehicleMakesDB;

--Problem 8: Get Make, FuelTypeName and Number of Vehicles per FuelType per Make

select m.Make , ft.FuelTypeName, count(*) as NumberOfVehicles

from VehicleDetails v
join Makes m
on v.MakeID = m.MakeID
join FuelTypes ft
on (v.FuelTypeID = ft.FuelTypeID)
where (v.Year between 1950 and 2000)
group by m.Make ,ft.FuelTypeName
order by m.Make


--  Problem 9: Get all vehicles that runs with GAS

select v.*, ft.FuelTypeName 
from VehicleDetails v
 join FuelTypes ft
on v.FuelTypeID = ft.FuelTypeID
where ft.FuelTypeName = N'GAS'

--N for searching in uniqude 

--  Problem 10: Get all Makes that runs with GAS

select distinct m.Make ,ft.FuelTypeName
from VehicleDetails v
join FuelTypes ft 
on (v.FuelTypeID = ft.FuelTypeID)
join Makes m
on (v.MakeID = m.MakeID) 
where (ft.FuelTypeName = N'GAS') 


--  Problem 11: Get Total Makes that runs with GAS

select count(*) As TotalMakesRunOnGAS
from 
(
	select distinct m.Make ,ft.FuelTypeName
	from VehicleDetails v
	join FuelTypes ft 
	on (v.FuelTypeID = ft.FuelTypeID)
	join Makes m
	on (v.MakeID = m.MakeID) 
	where (ft.FuelTypeName = N'GAS')
) R1 ;


--  Problem 12: Count Vehicles by make and order them by NumberOfVehicles from high to low.

select m.Make , count(*) as NumberOfVehicles
from VehicleDetails v
join Makes m
on v.MakeID = m.MakeID 
group by m.Make 

order by NumberOfVehicles DESC ;


--  Problem 13: Get all Makes/Count Of Vehicles that manufactures more than 20K Vehicles
select m.Make , count(*) as NumberOfVehicles
from VehicleDetails v
join Makes m
on v.MakeID = m.MakeID 
group by m.Make 
having count(*) > 20000
order by NumberOfVehicles DESC ;

-- another way without Having
select * from 
(
select m.Make , count(*) as NumberOfVehicles
from VehicleDetails v
join Makes m
on v.MakeID = m.MakeID 
group by m.Make 
) R1
where R1.NumberOfVehicles >20000
order by NumberOfVehicles DESC ;


