--create database CarRentalDB ;
use CarRentalDB;

--create table Customers (
--	CustomerID int identity (1,1) ,
--	FirstName nvarchar(50) not null,
--	LastName nvarchar(50) not null,
--	PhoneNumber nvarchar(20) null, 
--	BirthDate date null, 
--	DrivingLicenseNumber nvarchar(20) not null ,
--	constraint pk_Customer primary key (CustomerID) ,
--	constraint unq_Cutomers_PhoneNumber Unique (PhoneNumber) 

--);

--create table FuelTypes (
--	ID int not null identity(1,1) ,
--	FueltypeName nvarchar(50) not null,
--	constraint pk_fuelTypes primary key(ID) 
--);

--create table VehicleCategories (
--	CategoryID int identity (1,1) ,
--	CategoryName nvarchar(50) ,
--	constraint pk_VehicleCategories primary key (CategoryID) 
--);


--create table Vehicles (
--	VehicleID int identity (1,1) ,
--	Make nvarchar(50) not null,
--	Model nvarchar(50) not null,
--	Year int not null,
--	Mileage int not null ,
--	FuelTypeID int not null ,
--	PlateNumber nvarchar(20) not null,
--	CategoryID int not null,
--	RentalPricePerDay smallmoney not null,
--	IsAvailableForRent bit null ,
--	constraint pk_Vehicle primary key(VehicleID) ,
--	constraint fk_Vehicles_FuelTypeID foreign key (FuelTypeID)
--	references FuelTypes (ID) ,
--	constraint fk_Vehicles_CategoryID foreign key(CategoryID) 
--	references VehicleCategories (CategoryID) ,
--	constraint unq_Vehicles_PlateNumber unique(PlateNumber)
--);


--create table Maintenance (
--	MaintenanceID int identity(1,1) ,
--	VehicleID int not null, 
--	Descriptions nvarchar(200) not null,
--	MaintenanceDate date not null,
--	Cost decimal not null,
--	constraint pk_Maintenance primary key(MaintenanceID),
--	constraint fk_Maintenace_VehicleId foreign key (VehicleId) 
--	references Vehicles (VehicleID) 
--);

--create table RentalBooks
--(
--	BookID int identity (1,1) ,
--	CustomerID int not null, 
--	VehicleID int not null,
--	StartDate date not null,
--	EndDate date not null,
--	PickUpLocation nvarchar(100) not null,
--	DropOfLocaton nvarchar(100) not null,
--	RentalPricePerDay smallmoney not null ,
--	InitialRentalDays tinyint not null,
--	InitialTotalDueAmount smallmoney not null,
--	InitialCheckNotes nvarchar(500) not null,
--	constraint pk_RentalBooks primary key (BookID) ,
--	constraint fk_RentalBooks_CustomerID foreign key (CustomerID) references
--    Customers(CustomerID),
--	constraint fk_RentalBooks_VehicleID foreign key (VehicleID)
--	references Vehicles(VehicleID)

--);

--create table VehicleReturns (
--	ReturnId int identity(1,1) ,
--	ActualReturnDate date not null,
--	ActualRentalDays tinyint not null,
--	Mileage int not null,
--	UsedMileage int not null,
--	FinalCheckNotes nvarchar(500) not null,
--	AdditionalCharges smallmoney null,
--	ActualTotalDueAmount smallmoney not null,
--	constraint pk_VehicleReturns primary key(ReturnID)
--);


--create table RentalTransactions (
--	TransactionID int identity(1,1),
--	BookID int not null ,
--	ReturnID int null,
--	PaymentDetails nvarchar(200),
--	PaidInitialTotalDueAmount smallmoney not null,
--	ActualTotalDueAmount smallmoney null,
--	TotalRemaining smallmoney null,
--	TotalRefundedAmount smallmoney null,
--	TransactionDate date not null,
--	UpdateTransactionDate date null,
--	constraint pk_RentalTransactions primary key(TransactionId) ,
--	constraint fk_RentalTransactions_BookId foreign key (BookID) 
--	references RentalBooks(BookID) ,
--	constraint fk_RentalTransactions_ReturnID foreign key(ReturnID)
--	references VehicleReturns (ReturnID)
--);



