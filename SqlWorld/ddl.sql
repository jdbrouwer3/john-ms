use PizzaStoreDB
go

--create database
create database PizzaStoreDB;

-- schema
create schema PizzaStore;
GO  

-- tables
create table PizzaStore.[Address]
(
    AddressId int not null identity(1,1)
    ,Street nvarchar(100) not null 
    ,City nvarchar(50) not null
    ,StateProvince nvarchar(50) not null
    ,PostalCode nchar(5) not null
    ,ModifiedDate datetime2(0) not null  
    ,Active bit not null 
);

create table PizzaStore.[Location]
(
    LocationID tinyint not null primary key identity(1,1)
    ,AddressId int foreign key references PizzaStore.[Address](AddressID)
    ,ModifiedDate DATETIME2(0) not null
    ,Active bit not null default(1)
);

create table PizzaStore.[Order]
(
    OrderID int not null primary key identity(1,1)
    ,LocationId tinyint not null 
    ,UserId smallint not null 
    ,Date datetime2(0) not null 
    ,Total numeric(5,2) not null 
    ,ModifiedDate DATETIME2(0) not null
    ,Active bit not null default(1)
);

create table PizzaStore.[Pizza]
(
    PizzaID bigint not null primary key identity(1,1)
    ,SizeId tinyint not null 
    ,OrderId int not null 
    ,Price numeric(3,2) not null 
    ,ModifiedDate DATETIME2(0) not null
    ,Active bit not null default(1)
);

create table PizzaStore.[Size]
(
    SizeId tinyint not null primary key identity(1,1)
    ,Name nvarchar(50) not null 
    ,ModifiedDate Datetime2(0) not null 
    ,Active bit not null default(1)
);

create table PizzaStore.[Topping]
(
    ToppingId tinyint not null primary key identity(1,1)
    ,Name NVARCHAR(50) not null
    ,ModifiedDate Datetime2(0) not null 
    ,Active bit not null default(1)
);

create table PizzaStore.[User]
(
    UserID smallint not null primary key identity(1,1)
    ,AddressId int 
    ,Name nvarchar(50) not null 
    ,ModifiedDate DATETIME2(0) not null
    ,Active bit not null default(1)
);

create table PizzaStore.[LocationOrder]
(
    LocationUserID int primary key identity(1,1)
    ,LocationID tinyint foreign key references PizzaStore.[Location](LocationID)
    ,OrderID int foreign key references PizzaStore.[Order](OrderID)
);

create table PizzaStore.[LocationPizza]
(
    LocationUserID int primary key identity(1,1)
    ,LocationID tinyint foreign key references PizzaStore.[Location](LocationID)
    ,PizzaID bigint foreign key references PizzaStore.[Pizza](PizzaID)
);

create table PizzaStore.[LocationUser]
(
    LocationUserID int primary key identity(1,1)
    ,LocationID tinyint foreign key references PizzaStore.[Location](LocationID)
    ,UserID smallint foreign key references PizzaStore.[User](UserID)
);






-- alter
alter table PizzaStore.[Address]
    add constraint PK_Address_AddressID primary key (AddressID);
go 

alter table PizzaStore.[Address]
    alter column StateProvince nvarchar(100) not null 
go

alter table PizzaStore.[Address]
    alter column City nvarchar(50) not null 
go 

alter table PizzaStore.[Order]
    add constraint CK_Order_ModifiedDate check (ModifiedDate = getdate())
go  

alter table PizzaStore.[Address]
    add constraint DF_Address_PostalCode default('00000') for PostalCode
go 

-- --drop 
-- drop table PizzaStore.Location;
-- drop database PizzaStoreDB;

-- -- truncate 
-- truncate table PizzaStor --don't do this. deleted forever.

drop table PizzaStore.Address;

alter table PizzaStore.Address
drop constraint 