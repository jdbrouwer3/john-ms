use PizzaStoreDB;
go

create table PizzaStore.[Address]
(
  [AddressId] int not null identity(1,1)
  ,[Street] nvarchar(200) not null
  ,[City] nvarchar(100) not null
  ,[State] nvarchar(100) not null
  ,[DateModified] as sysutcdatetime()
  ,[Active] bit not null
);

create table PizzaStore.[Crust]
(
  [CrustId] int not null identity(1,1)
  ,[Name] nvarchar(50) not null
  ,[DateModified] as sysutcdatetime()
  ,[Active] bit not null
);

create table PizzaStore.[Location]
(
  [LocationId] int not null identity(1,1)
  ,[AddressId] int not null
  ,[Name] nvarchar(50) not null
  ,[DateModified] as sysutcdatetime()
  ,[Active] bit not null
);

create table PizzaStore.[Order]
(
  [OrderId] int not null identity(1,1)
  ,[LocationId] int not null
  ,[UserId] int not null
  ,[Total] numeric(6,2) not null
  ,[DateOrdered] datetime2(0) not null
  ,[DateModified] as sysutcdatetime()
  ,[Active] bit not null
);

create table PizzaStore.[Pizza]
(
  [PizzaId] int not null identity(1,1)
  ,[CrustId] int not null
  ,[OrderId] int not null
  ,[SizeId] int not null
  ,[Price] numeric(4,2) not null
  ,[DateModified] as sysutcdatetime()
  ,[Active] bit not null
);

create table PizzaStore.[PizzaTopping]
(
  [PizzaToppingId] int not null identity(1,1)
  ,[PizzaId] int not null
  ,[ToppingId] int not null
  ,[DateModified] as sysutcdatetime()
  ,[Active] bit not null
);

create table PizzaStore.[Size]
(
  [SizeId] int not null identity(1,1)
  ,[Name] nvarchar(50) not null
  ,[DateModified] as sysutcdatetime()
  ,[Active] bit not null
);

create table PizzaStore.[Topping]
(
  [ToppingId] int not null identity(1,1)
  ,[Name] nvarchar(50) not null
  ,[DateModified] as sysutcdatetime()
  ,[Active] bit not null
)

create table PizzaStore.[User]
(
  [UserId] int not null identity(1,1)
  ,[AddressId] int not null
  ,[Name] nvarchar(100) not null
  ,[DateModified] as sysutcdatetime()
  ,[Active] bit not null
);