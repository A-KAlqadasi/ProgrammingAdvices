USE SmallClinicDB;


SELECT * FROM Persons;
select   *FROM Paitents;

select Paitents.PaitentID , Persons.PersonID,Persons.FirstName ,Persons.LastName 
from Paitents 
inner join Persons 
on (Paitents.PersonID = Persons.PersonID);
