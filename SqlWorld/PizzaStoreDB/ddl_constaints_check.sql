use PizzaStoreDB;
go

alter table PizzaStore.[Order]
  add constraint CK_Order_DateOrdered check(DateOrdered <= sysutcdatetime())
go