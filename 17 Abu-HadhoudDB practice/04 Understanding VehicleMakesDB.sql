

SELECT VehicleDetails.ID, VehicleDetails.MakeID, VehicleDetails.ModelID, MakeModels.ModelName
FROM     VehicleDetails INNER JOIN
                  MakeModels ON VehicleDetails.ModelID = MakeModels.ModelID
				  
				  
---------
SELECT VehicleDetails.ID, VehicleDetails.MakeID, Makes.Make, VehicleDetails.ModelID, MakeModels.ModelName
FROM     VehicleDetails INNER JOIN
                  Makes ON VehicleDetails.MakeID = Makes.MakeID INNER JOIN
                  MakeModels ON Makes.MakeID = MakeModels.MakeID



SELECT top 2 VehicleDetails.ID, VehicleDetails.MakeID, Makes.Make, VehicleDetails.ModelID, MakeModels.ModelName, VehicleDetails.SubModelID, SubModels.SubModelName
FROM     VehicleDetails INNER JOIN
                  SubModels ON VehicleDetails.SubModelID = SubModels.SubModelID INNER JOIN
                  Makes ON VehicleDetails.MakeID = Makes.MakeID INNER JOIN
                  MakeModels ON SubModels.ModelID = MakeModels.ModelID AND Makes.MakeID = MakeModels.MakeID



select top(1) * From VehicleDetails;


select top(1) * From MakeModels;

select top(1) * from SubModels ;

select top(1) * from Makes;

select top 2 V.ID , V.MakeID, M.Make ,V.ModelID,Ms.ModelName , V.SubModelID , S.SubModelName

From VehicleDetails V
Inner join 
SubModels S on (V.SubModelID = S.SubModelID) 
inner join
Makes M on (V.MakeID = M.MakeID)
inner join 
MakeModels Ms on (V.ModelID = Ms.ModelID) ;



select * from VehicleMakesDB.dbo.Bodies ;

select * from VehicleMakesDB.dbo.DriveTypes ;

select * from VehicleMakesDB.dbo.FuelTypes ;

select * from VehicleMakesDB.dbo.MakeModels;

select * from VehicleMakesDB.dbo.SubModels ;

select * from VehicleMakesDB.dbo.Makes ;

select * from VehicleDetails;


