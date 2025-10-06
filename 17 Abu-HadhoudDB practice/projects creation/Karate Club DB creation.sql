
use Karateclubdb;
---- this is the creation of karate club database


--create table Persons(
--	PersonID int identity(1,1) ,
--	FirstName nvarchar(50) not null,
--	LastName nvarchar(50) not null,
--	Birthdate date not null,
--	AddressInfo nvarchar(100) null ,
--	Phone nvarchar(20) null ,
--	constraint pk_Person primary key(PersonID)
--);

--create table Instructors(
--	InstructorID int identity(1,1) , 
--	PersonID int not null ,
--	Qualifications nvarchar(100) not null,
--	constraint pk_Instructor primary key(InstructorID) ,
--	constraint fk_PersonID foreign key (PersonID)  references Persons(PersonID)
--);

--create table BeltRanks(
--	BeltRankID int identity (1,1) ,
--	RankName nvarchar(50) not null,
--	TestFee smallmoney not null,
--	constraint pk_BeltRank primary key (BeltRankID) 
--);

--create table Members(
--	MemberID int not null  identity(1,1) ,
--	PersonID int not null ,
--	BeltRankID int not null ,
--	EmergencyContact nvarchar(50) not null,
--	IsActive bit null  ,
--	constraint pk_Member primary key(MemberID) ,
--	constraint fk_BeltRankID foreign key(BeltRankID) references BeltRanks(BeltRankID)
--);


--create table MemberInstructors(
--	ID int not null identity (1,1) ,
--	MemberID int not null, 
--	InstructorID int not null,
--	AnyNotes nvarchar(100) null,
--	constraint pk_MemberInstructor primary key(ID) ,
--	constraint fk_MemberInstructors_MemberID foreign key(MemberID)
--	references Members(MemberID) ,
--	constraint fk_MemberInstructors_InstructorID foreign key(InstructorID)
--	references Instructors(InstructorID)

--);


--create table Payments(
--	PaymentID int not null identity(1,1),
--	Amount smallmoney not null ,
--	AtDate date default(GetDate()),
--	MemberID int not null ,
--	constraint pk_Payment primary key(PaymentID) ,
--	constraint fk_MemberID foreign key(MemberID) references Members(MemberID)
--);

--create table Subscriptions (
--	SubscriptionID int identity(1,1) , 
--	MemberID int not null,
--	StartDate date not null,
--	EndDate date not null, 
--	Fee smallmoney not null,
--	PaymentID int not null,
--	constraint pk_Subscription primary key(SubscriptionID),
--	constraint fk_PaymentID foreign key(PaymentID) references Payments(PaymentID) 

--);

--create table BeltTests(
--	BeltTestID int not null identity(1,1),
--	MemberID int not null ,
--	BeltRankID int not null ,
--	InstructorID int not null,
--	TestDate date not null,
--	Result bit null,
--	PaymentID int not null, 
--	constraint pk_BeltTest primary key(BeltTestID),
--	constraint fk_BeltTests_MemberID foreign key(MemberID) 
--	references Members(MemberID),
--	constraint fk_BeltTests_BeltRankID foreign key(BeltRankID) 
--	references BeltRanks(BeltRankID),
--	constraint fk_BeltTests_InstructorID foreign key(InstructorID) 
--	references Instructors(InstructorID),
--);

