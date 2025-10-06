
Backup database DB1
To Disk = 'D:\DB1.bak' 
with differential ; -- this means only the new changes will be updated

Backup database DB2
To Disk = 'C:\DB2.bak' 
with differential ; -- this means only the new changes will be updated






Restore Database HR_Database
From Disk = 'D:\HR_Database.bak';







drop database DB2;

Restore Database myDB
From Disk = 'D:\DB1.bak';





