use PizzaStoreDB;
go

alter table PizzaStore.[Address]
  add constraint PK_Address_AddressId primary key (AddressId)
go

alter table PizzaStore.[Crust]
  add constraint PK_Crust_CrustId primary key (CrustId)
go

alter table PizzaStore.[Location]
  add constraint PK_Location_LocationId primary key (LocationId)
go

alter table PizzaStore.[Order]
  add constraint PK_Order_OrderId primary key (OrderId)
go

alter table PizzaStore.[Pizza]
  add constraint PK_Pizza_PizzaId primary key (PizzaId)
go

alter table PizzaStore.[PizzaTopping]
  add constraint PK_PizzaTopping_PizzaToppingId primary key (PizzaToppingId)
go

alter table PizzaStore.[Size]
  add constraint PK_Size_SizeId primary key (SizeId)
go

alter table PizzaStore.[Topping]
  add constraint PK_Topping_ToppingId primary key (ToppingId)
go

alter table PizzaStore.[User]
  add constraint PK_User_UserId primary key (UserId)
go