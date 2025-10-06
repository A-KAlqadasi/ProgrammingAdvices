--create database OnlineStoreDB ;

use OnlineStoreDB;

--create table ProductCategories (
--	CategoryID int identity (1,1) ,
--	CategoryName nvarchar(100) not null,
--	constraint pk_ProductCategories primary key(CategoryID) 

--);

--create table ProductCatalogs (
--	ProductID int identity (1,1) ,
--	ProductName nvarchar(100) not null,
--	Description nvarchar(500) not null,
--	Price smallmoney not null,
--	QuantityInStock int not null,
--	CategoryID int not null,
--	constraint pk_ProductCatalogs primary key(ProductID) ,
--	constraint fk_ProductCatalogs_categoryId foreign key (CategoryID) 
--	references productCategories(categoryId) 
--);

--create table ProdutImages (
--	ImageID int identity(1,1) ,
--	ImageURL nvarchar(400) not null,
--	ProductID int not null,
--	ImageOrder smallint ,
--	constraint pk_ProdutImages primary key(ImageID),
--	constraint fk_ProdutImages_ProductID foreign key (ProductId)
--	references ProductCatalogs (ProductID)
--);

--create table Customers (
--	CustomerID int identity (1,1) ,
--	FirstName nvarchar(50) not null,
--	LastName nvarchar(50) not null,
--	Phone nvarchar(20) null,
--	Email nvarchar(100) not null,
--	Address nvarchar(200) not null,
--	UsreName nvarchar(100) not null,
--	Password nvarchar(100) not null
--  constraint pk_Customers primary key(CustomerID) 
--);


--create table Reviews (
--	ReviewID int identity (1,1) ,
--	ProductID int not null, 
--	CustomerID int not null,
--	ReviewText nvarchar(500) null,
--	Rating decimal null,
--	ReviewDate date default(GETDATE()) ,
--	constraint pk_Reviews primary key (ReviewID) ,
--	constraint fk_Reviews_ProductID foreign key (ProductID)
--	references ProductCatalogs (ProductID),
--	constraint fk_Reviews_CustomerId foreign key(CustomerID)
--	references Customers(CustomerID)
--);

--create table OrderStatuses (
--	ID int identity(1,1),
--	StatusName nvarchar(50) not null,
--	constraint pk_OrderStatuses primary key(ID)
--);


--CREATE table Orders (
--	OrderID int identity (1,1) ,
--	CustomerID int not null,
--	OrderDate datetime default(GetDate()),
--	TotalAmount smallmoney not null,
--	OrderStatusID int not null,
--	constraint pk_Orders primary key(OrderID) ,
--	constraint fk_Orders_CustomerId foreign key (CustomerID) 
--	references Customers(CustomerID) ,
--	constraint fk_Orders_OrderStatusID foreign key(OrderStatusID)
--	references Orderstatuses(ID)
--);

--create table Payments (
--	PaymentID int identity(1,1) ,
--	OrderID int not null ,
--	Amount smallmoney not null,
--	PaymentMethod nvarchar(50) not null,
--	TransactionDate datetime not null
--	constraint pk_Payments primary key(PaymentID),
--	constraint fk_Payments_OrderID foreign key(OrderID) 
--	references Orders(OrderID)
--);


--create table OrderItems (
--	OrderItemId int identity (1,1) ,
--	OrderId int not null, 
--	ProductId int not null, 
--	Quantity int not null ,
--	Price smallmoney not null, 
--	TotalItemsPrice smallmoney not null,
--	constraint pk_OrderItems primary key(OrderItemId) ,
--	constraint fk_OrderItems_OrderID foreign key(OrderID) 
--	references Orders(OrderID),
--	constraint fk_OrderItems_ProductID foreign key(ProductId)
--	references ProductCatalogs(ProductId)

--);

--create table ShippingStatuses (
--	ID int identity(1,1),
--	StatusName nvarchar(50) not null,
--	constraint pk_ShippingStatuses primary key(ID)
--);



--create table Shippings(
--	ShippingID int identity(1,1) ,
--	OrderID int not null,
--	CarrierName nvarchar(100) not null,
--	TrackingNumber nvarchar(50) not null  ,
--	ShippingStatusID int not null,
--	EstimatedDeliveryDate date not null,
--	ActualDeliveryDate date not null,
--	constraint pk_Shippings primary key(ShippingID) ,
--	constraint fk_Shippings_OrderID foreign key (OrderID) 
--	references Orders(OrderID) ,
--	constraint fk_Shippings_ShippingStatusID foreign key(ShippingStatusId)
--	references ShippingStatuses(Id) 
--);

