--Problem Solving ProgrammingAdvices.com

Use VehicleMakesDB;

select distinct NumDoors 

from VehicleDetails;

--  Problem 30: Get all Vehicle_Display_Name, NumDoors and add extra column
-- to describe number of doors by words, and if door is null display 'Not Set'

select Vehicle_Display_Name , NumDoors ,
CASE
	when NumDoors = 1 then 'Zero Door'
	when NumDoors = 1 then 'One Door'
	when NumDoors = 2 then 'Two Doors'
	when NumDoors = 3 then 'Three Doors'
	when NumDoors = 4 then 'Four Doors' 
	when NumDoors = 5 then 'Five Doors'
	when NumDoors = 6 then 'Six Doors'
	when NumDoors = 8 then 'Eight Doors'
	when NumDoors is null then 'Not Set'
	else 
		'Unknown'

END as DoorDescription

from VehicleDetails 
where NumDoors is null;


--Problem 31: Get all Vehicle_Display_Name, year and add extra column 
--to calculate the age of the car then sort the results by age desc.

-- Note that YEAR in capital Letters is built in function in SQL Server that will give you the year of the given date :-) , 
-- and the year in small letters is the column name


select Vehicle_Display_Name, Year ,CarAge=YEAR(GETDATE())-VehicleDetails.year

from VehicleDetails

where Vehicle_Display_Name = 'AC Shelby Cobra 1964 Base'


--  Problem 32: Get all Vehicle_Display_Name, year, Age for vehicles that their age between 15 and 25 years old

select * from 
(
	select Vehicle_Display_Name , year , CarAge=YEAR(GETDATE()) - VehicleDetails.Year

	from VehicleDetails
) R1 
where R1.CarAge between 15 and 25


--  Problem 33: Get Minimum Engine CC , Maximum Engine CC , and Average Engine CC of all Vehicles

select MIN(Engine_CC) As 'Minimum Engine_CC ' , MAX (Engine_CC) AS 'Maximum Engine CC',
AVG(Engine_CC) 'Average Engine CC'
from VehicleDetails ;


--  Problem 34: Get all vehicles that have the minimum Engine_CC

select * from VehicleDetails 
where VehicleDetails.Engine_CC = (select MIN(Engine_CC) as MinimumEngineCC from VehicleDetails)


--  Problem 35: Get all vehicles that have the Maximum Engine_CC
select * from VehicleDetails 
where Engine_CC = (select MAX(Engine_CC) as MaximumEngineCC from VehicleDetails) ;


--  Problem 36: Get all vehicles that have Engin_CC below average
select * from VehicleDetails 
where Engine_CC < (select AVG(Engine_CC) as AverageEngineCC from VehicleDetails) ;


--  Problem 37: Get total vehicles that have Engin_CC above average
select count (*) as NumberOfVehiclesAboveAverageEngineCC 
from 
(
select * from VehicleDetails 
where Engine_CC > (select AVG(Engine_CC) as AverageEngineCC from VehicleDetails)
) R1  


--  Problem 38: Get all unique Engin_CC and sort them Desc

select distinct Engine_CC

from VehicleDetails 
order by Engine_CC desc


--  Problem 39: Get the maximum 3 Engine CC
select distinct top 3  Engine_CC 
from VehicleDetails 
order by Engine_CC desc;


--  Problem 40: Get all vehicles that has one of the Max 3 Engine CC
-- This way can be used to get the top 10 successful students in exams 
select  * from VehicleDetails 
where Engine_CC in (select distinct top 3  Engine_CC 
					from VehicleDetails 
					order by Engine_CC desc )


--  Problem 41: Get all Makes that manufactures one of the Max 3 Engine CC

select distinct m.Make , v.Engine_CC

from VehicleDetails v
join Makes m
on (v.MakeID = m.MakeID)
where v.Engine_CC IN (
					select distinct top 3 Engine_CC 
					from VehicleDetails 
					order by Engine_CC DESC
					)
order by m.Make 


--  Problem 42: Get a table of unique Engine_CC and calculate tax per Engine CC

-- Get a table of unique Engine_CC and calculate tax per Engine CC as follows:
	-- 0 to 1000    Tax = 100
	-- 1001 to 2000 Tax = 200
	-- 2001 to 4000 Tax = 300
	-- 4001 to 6000 Tax = 400
	-- 6001 to 8000 Tax = 500
	-- Above 8000   Tax = 600
	-- Otherwise    Tax = 0

select distinct Engine_CC,
CASE 
	when Engine_CC between 0 and 1000 then 100
	when Engine_CC between 1001 and 2000 then 200
	when Engine_CC between 2001 and 4000 then 300 
	when Engine_CC between 4001 and 6000 then 400
	when Engine_CC between 6001 and 8000 then 500
	when Engine_CC >8000 then 600
	else 
	 0
End as TacPerEngine

from VehicleDetails 
order by Engine_CC 

-- another way for solution
select Engine_CC,

	CASE
		WHEN Engine_CC between 0 and 1000 THEN 100
		 WHEN Engine_CC between 1001 and 2000 THEN 200
		 WHEN Engine_CC between 2001 and 4000 THEN 300
		 WHEN Engine_CC between 4001 and 6000 THEN 400
		 WHEN Engine_CC between 6001 and 8000 THEN 500
		 WHEN Engine_CC > 8000 THEN 600	
		ELSE 0

	END as Tax

from 
(
	select distinct Engine_CC from VehicleDetails
	
) R1
order by Engine_CC


--  Problem 43: Get Make and Total Number Of Doors Manufactured Per Make

select m.Make, sum(v.NumDoors) TotalOfDoorsPerMake

from VehicleDetails v
JOIN Makes m
on (v.MakeID = m.MakeID)
group by m.Make
order by TotalOfDoorsPerMake desc


--  Problem 44: Get Total Number Of Doors Manufactured by 'Ford'
select m.Make, sum(v.NumDoors) TotalOfDoorsPerMake

from VehicleDetails v
JOIN Makes m
on (v.MakeID = m.MakeID)
group by m.Make
having m.Make = 'Ford'


--  Problem 45: Get Number of Models Per Make
select m.Make,count(mkm.MakeID) NumberOfModelsPerMake

from Makes m
join MakeModels mkm
on (m.MakeID = mkm.MakeID)
group by m.Make 
order by NumberOfModelsPerMake desc

-- anothe way could be 
SELECT        Makes.Make, COUNT(*) AS NumberOfModels
FROM            Makes INNER JOIN
                         MakeModels ON Makes.MakeID = MakeModels.MakeID
GROUP BY Makes.Make
Order By NumberOfModels Desc


--   Problem 46: Get the highest 3 manufacturers that make the highest number of models
select top(3) m.Make,count(mkm.MakeID) NumberOfModelsPerMake

from Makes m
join MakeModels mkm
on (m.MakeID = mkm.MakeID)
group by m.Make 
order by NumberOfModelsPerMake desc


--   Problem 47: Get the highest number of models manufactured
select MAX(R1.NumberOfModelsPerMake) as MaxNumberOfModels

from 
(
	select m.Make,count(mkm.MakeID) NumberOfModelsPerMake
	from Makes m
	join MakeModels mkm
	on (m.MakeID = mkm.MakeID)
	group by m.Make 

)R1 


-- another way solution
select top(1) count(mkm.MakeID) MaxNumberOfModels
from Makes m
join MakeModels mkm
on (m.MakeID = mkm.MakeID)
group by m.Make 
order by MaxNumberOfModels desc


--  Problem 48: Get the highest Manufacturers manufactured the highest number of models
select m.Make ,count(*) NumberOfModels

from Makes m
join MakeModels mkm
on (m.MakeID = mkm.MakeID)
group by m.Make 
having count(*) = (
	select MAX(R1.NumberOfModelsPerMake) as MaxNumberOfModels

		from 
		(
			select m.Make,count(mkm.MakeID) NumberOfModelsPerMake
			from Makes m
			join MakeModels mkm
			on (m.MakeID = mkm.MakeID)
			group by m.Make 

		)R1 
)


--  Problem 49: Get the Lowest Manufacturers manufactured the lowest number of models
-- there are maybe many manufacturers have the lowest number of models  
select m.Make , count(*) NumberOfModels

from Makes m
join MakeModels mkm
on (m.MakeID = mkm.MakeID)
group by m.Make 
having count(*) =
(
	select MIN(R1.NumberOfModels) as LowestModel
	from 
	(
		select count(*) NumberOfModels
		from Makes m
		join MakeModels mkm
		on (m.MakeID = mkm.MakeID)
		group by m.Make 

	) R1
)


--  Problem 50: Get all Fuel Types , each time the result should be showed in random order
-- Note that the NewID() function will generate GUID for each row 

select * from FuelTypes 
order by NewID();



