--create database SmallClinicDB;

Use SmallClinicDB;

--create table Persons
--(
--	PersonID int primary key,
--	FirstName nvarchar(50) not null,
--	LastName nvarchar(50) not null,
--	Birthdate date not null,
--	Gender nvarchar(1) not null,
--	Address nvarchar(200) null,
--	PhoneNumber nvarchar(20) null,
--	Email nvarchar(100) ,
--	Constraint chk_Person_Gender check(Gender in ('M','F'))  

--);

--create table Paitents
--(
--	PaitentID int not null ,
--	PersonID int not null,
--	Constraint pk_paitent primary key(PaitentID) ,
--	Constraint fk_Paitent foreign key(PersonID) references Persons(PersonID)

--);

--create table Doctors
--(
--	DoctorID int not null ,
--	PersonID int not null,
--	Specialization nvarchar(100),
--	Constraint pk_doctor primary key(DoctorID) ,
--	Constraint fk_doctor foreign key(PersonID) references Persons(PersonID)

--);


--create table MedicalRecords 
--(
--	RecordID int primary key identity(1,1),
--	Description nvarchar(200) not null,
--	Diagnosis nvarchar(200) not null,
--	AdditionalNotes nvarchar(200) null

--);

--create table Payments
--(
--	PaymentID int primary key identity(1,1),
--	PaymentDate date not null,
--	PaymentMethod nvarchar(50) not null,
--	AmountPaid decimal not null,
--	AdditionalNotes nvarchar(200) null 
--);

--create table Appointments
--(
--	AppointmentID int not null primary key identity(1,2),
--	PaitentID int not null references Paitents(PaitentID),
--	DoctorID int not null references Doctors(DoctorID),
--	AppointmentDateTime datetime not null,
--	AppointmentStatus tinyint not null,
--	MedicalRecordID int null references MedicalRecords(RecordID),
--	PaymentID int null ,
--	Constraint fk_Appointment_Payment foreign key(PaymentID) references Payments(PaymentID)

--);


--create table Prescriptions
--(
--	ID int not null primary key identity(1,1),
--	MedicalRecordID int not null ,
--	MedicationName nvarchar(100) not null,
--	Dosage nvarchar(50) not null,
--	Frequency nvarchar(50) not null ,
--	StartDate date not null,
--	EndDate date not null,
--	SpecialInstuctions nvarchar(200) not null,
--	Constraint fk_Prescription_MedicalRecord foreign key(MedicalRecordID) 
--	references MedicalRecords(RecordID)

	
--);


Alter table Appointments
Add constraint chk_Appointment_Status check(AppointmentStatus in (1,2,3,4,5,6));

