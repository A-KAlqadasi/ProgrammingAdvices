--Problem Solving ProgrammingAdvices.com

Use VehicleMakesDB;

--P1 - Create Master View

create view vwVehicleMasterDetails AS
select v.ID , v.MakeID , mks.Make, v.ModelID ,mkm.ModelName, v.SubModelID ,sm.SubModelName,
v.BodyID , b.BodyName ,v.Vehicle_Display_Name , v.Year ,v.DriveTypeID, dt.DriveTypeName,
v.Engine , v.Engine_CC , v.Engine_Cylinders , v.Engine_Liter_Display ,
v.FuelTypeID , ft.FuelTypeName , v.NumDoors

from VehicleDetails v
join Makes mks
on (v.MakeID = mks.MakeID)
join MakeModels mkm 
on (v.ModelID = mkm.ModelID)
join SubModels sm
on (v.SubModelID = sm.SubModelID)
join Bodies b
on (v.BodyID = b.BodyID)
join DriveTypes dt
on (v.DriveTypeID = dt.DriveTypeID)
join FuelTypes ft
on (v.FuelTypeID = ft.FuelTypeID)


select * from vwVehicleMasterDetails ;

-- P2- Get All Vehicles made between 1950 and 2000

select * from  VehicleDetails 
where Year between 1950 and 2000 ;


--P3 - Get number vehicles made between 1950 and 2000

select count(*) As NumberOfVehicles from VehicleDetails
where Year between 1950 and 2000 ;


--P4 -Get number vehicles made between 1950 and 2000 per make 
--and ordr them by number of vehivles descending

select m.Make , count(v.MakeID) As NumberOfVehicles
from VehicleDetails v
join Makes m
on v.MakeID = m.MakeID
where v.Year between 1950 and 2000
group by m.Make
order by NumberOfVehicles desc;

-- another way for solving but it didn't work
select Make, count(*) as NumberOfVehicles
from vwVehicleMasterDetails 
where Year between 1950 and 2000
group by Make 
order by NumberOfVehicles desc;


--P5 : Get All Makes that have manufactured more than 12000 Vehicles in years 1950 to 2000

select m.Make , NumberOfVehicles=count(*)

from VehicleDetails v
join Makes m
on (v.MakeID = m.MakeID)
where (v.Year between 1950 and 2000)
group by m.Make 
having  count(*)> 12000
order by NumberOfVehicles Desc


--- anthor way for sulotion without using Having
select * from 
(
	select m.Make , NumberOfVehicles=count(*)
	from VehicleDetails v
	join Makes m
	on (v.MakeID = m.MakeID)
	where (v.Year between 1950 and 2000)
	group by m.Make 

) As R1
where R1.NumberOfVehicles >12000
Order by NumberOfVehicles Desc 
;


--Problem 6: Get number of vehicles made between 1950 and 2000 per make 
--and add total vehicles column beside

select count(*) from VehicleDetails;

	select m.Make , count(*) NumberOfVehicles ,  (select count(*) from VehicleDetails) as TotalVehiclese
	from VehicleDetails v
	join Makes m
	on v.MakeID = m.MakeID
	where v.Year between 1950 and 2000
	group by m.Make
	order by NumberOfVehicles Desc 
	


--  Problem 7: Get number of vehicles made between 1950 and 2000 per make 
-- and add total vehicles column beside it, then calculate it's percentage

select * ,Perc=CAST(R1.NumberOfVehicles as float)/CAST(R1.TotalVehiclese as float) 
from 
(
	select m.Make , count(*) NumberOfVehicles ,  (select count(*) from VehicleDetails) as TotalVehiclese
	from VehicleDetails v
	join Makes m
	on v.MakeID = m.MakeID
	where v.Year between 1950 and 2000
	group by m.Make
) R1
	order by R1.NumberOfVehicles Desc 



