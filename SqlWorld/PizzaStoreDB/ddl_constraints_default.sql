use PizzaStoreDB;
go

alter table PizzaStore.[Address]
  add constraint DF_Address_Active default(1) for Active
go

alter table PizzaStore.[Crust]
  add constraint DF_Crust_Active default(1) for Active
go

alter table PizzaStore.[Location]
  add constraint DF_Location_Active default(1) for Active
go

alter table PizzaStore.[Order]
  add constraint DF_Order_Active default(1) for Active
go

alter table PizzaStore.[Pizza]
  add constraint DF_Pizza_Active default(1) for Active
go

alter table PizzaStore.[PizzaTopping]
  add constraint DF_PizzaTopping_Active default(1) for Active
go

alter table PizzaStore.[Size]
  add constraint DF_Size_Active default(1) for Active
go

alter table PizzaStore.[Topping]
  add constraint DF_Topping_Active default(1) for Active
go

alter table PizzaStore.[User]
  add constraint DF_User_Active default(1) for Active
go