use PizzaStoreDB;
go

alter table PizzaStore.[Location]
  add constraint FK_Location_AddressId foreign key (AddressId) references PizzaStore.[Address](AddressId)
go

alter table PizzaStore.[Order]
  add constraint FK_Order_LocationId foreign key (LocationId) references PizzaStore.Location(LocationId)
go

alter table PizzaStore.[Order]
  add constraint FK_Order_UserId foreign key (UserId) references PizzaStore.[User](UserId)
go

alter table PizzaStore.[Pizza]
  add constraint FK_Pizza_CrustId foreign key (CrustId) references PizzaStore.Crust(CrustId)
go

alter table PizzaStore.[Pizza]
  add constraint FK_Pizza_OrderId foreign key (OrderId) references PizzaStore.[Order](OrderId)
go

alter table PizzaStore.[Pizza]
  add constraint FK_Pizza_SizeId foreign key (SizeId) references PizzaStore.[Size](SizeId)
go

alter table PizzaStore.[PizzaTopping]
  add constraint FK_PizzaTopping_PizzaId foreign key (PizzaId) references PizzaStore.[Pizza](PizzaId)
go

alter table PizzaStore.[PizzaTopping]
  add constraint FK_PizzaTopping_ToppingId foreign key (ToppingId) references PizzaStore.[Topping](ToppingId)
go

alter table PizzaStore.[User]
  add constraint FK_User_AddressId foreign key (AddressId) references PizzaStore.[Address](AddressId)
go