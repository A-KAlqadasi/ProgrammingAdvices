
Use SmallLibraryDB;


--create table Books(
--	BookID int not null,
--	Title nvarchar(255) not null,
--	ISBN nvarchar(50) not null,
--	Genre nvarchar(50) not null,
--	PublicationDate date not null,
--	AdditionalNotes nvarchar(max),
--	Constraint pk_Book primary key(BookID),
--	Constraint unq_Book_ISBN unique(ISBN) ,

--);


--create table Authers (
--	AutherID int not null,
--	FirstName nvarchar(50) not null,
--	LastName nvarchar(50) null,
--	Constraint pk_Auther primary key (AutherID)

--);

--create table BookAuthers(
--	ID int primary key identity (1,1),
--	AutherID int not null ,
--	BookID int not null,
--	Constraint fk_BookAuther_AutherID foreign key(AutherID) 
--	references Authers(AutherID) ,
--	Constraint fk_BookAuther_BookID foreign key(BookID) 
--	references Books(BookID) 

--);

--create table BookCopies (
--	BookCopyID int not null ,
--	BookID int not null,
--	AvilabilityStatus bit not null,
--	constraint pk_BookCopy primary key(BookCopyID) ,
--	constraint fk_BookCopy_BookID foreign key(BookID) references Books(BookID) 
--);

--create table Cards(
--	ID int not null identity(1,1),
--	CardNumber int not null,
--	ExpDate date not null,
--	constraint pk_Card  primary key(ID),
--	constraint unq_CardNumber unique(CardNumber) 

--);

--create table Users(
--	UserID int not null identity(1,1),
--	FirstName nvarchar(50) not null,
--	LastName nvarchar(50) not null,
--	PhoneNumber varchar(20) ,
--	CardID int not null,
--	constraint pk_User primary key(UserID) ,
--	constraint fk_User_CardID foreign key(CardID) references Cards(ID)

--);


--create table BorrowingRecords (
--	BorrowRecordID int not null identity(1,1),
--	BookCopyID int not null,
--	UserID int not null,
--	BorrowDate date not null,
--	DueDate date not null,
--	ActualReturnDate date null,
--	constraint pk_BorrwingRecord primary key(BorrowRecordID),
--	constraint fk_BorrowingRecord_BookCopyID foreign key(BookCopyID) 
--	references BookCopies(BookCopyID),
--	constraint fk_BorrowingRecord_UserID foreign key(UserID) 
--	references Users(UserID)
--);

--create table Reservations(
--	ReserveID int not null identity(1,1),
--	BookCopyID int not null,
--	UserID int not null,
--	ReservationDate date not null ,
--	constraint pk_Reservation primary key(ReserveID),
--	constraint fk_Reservation_BookCopyID foreign key(BookCopyID) 
--	references BookCopies(BookCopyID),
--	constraint fk_Reservation_UserID foreign key(UserID) 
--	references Users(UserID)
--);


--create table Fines(
--	FineID int not null identity(1,1),
--	UserID int not null,
--	BorrowRecordID int not null,
--	NumberOfLateDays smallint not null,
--	FineAmount decimal not null , 
--	PaymentStatus bit not null,
--	constraint pk_Fines primary key(FineID) ,
--	constraint fk_Fine_UserID foreign key(UserID) 
--	references Users(UserID)
--	constraint fk_Fine_BorrowRecordID foreign key(BorrowRecordID) references
--	BorrowingRecords(BorrowRecordID)
--);


--create table Settings(
--	SettingID int not null identity(1,1) ,
--	DefultBorrowDays smallint not null,
--	FineAmountPerDay decimal not null
--);
