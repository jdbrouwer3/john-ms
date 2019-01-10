use PizzaStoreDB;
go

-- alter table PizzaStore.[Order]
--   add constraint CK_Order_DateOrdered check(DateOrdered <= sysutcdatetime())
-- go

-- alter table PizzaStore.[Order]
-- drop constraint CK_Order_DateOrdered

alter table PizzaStore.[Order]
  add CONSTRAINT CK_Order_DateOrdered check(DateOrdered <= sysdatetime())
go 