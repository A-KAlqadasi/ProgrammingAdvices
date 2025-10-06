
-- when i try to make database Diagram
-- Solving the error-> Cannot execute as the database principal
--because the principal "dbo" does not exist, 
--this type of principal cannot be impersonated, 
--or you do not have permission. (Microsoft SQL Server, Error: 15517)
use VehicleMakesDB EXEC sp_changedbowner 'sa'