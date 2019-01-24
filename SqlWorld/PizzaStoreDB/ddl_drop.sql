USE PizzaStoreDB;  
GO  

ALTER TABLE PizzaStore.[User]
DROP CONSTRAINT FK_User_AddressId; 
GO  

alter TABLE PizzaStore.[User]
DROP COLUMN AddressId;

alter table PizzaStore.[User]
Drop CONSTRAINT DF_User_Active;
go 

alter TABLE PizzaStore.[User]
DROP COLUMN Active;

alter table PizzaStore.[User]
drop column LastLocationId;

alter table PizzaStore.[User]
add [LastTime] as sysutcdatetime()

alter table PizzaStore.[User]
add [LastLocationId] int

alter table PizzaStore.[PizzaTopping]
Drop CONSTRAINT FK_PizzaTopping_ToppingId;
go 

drop table PizzaStore.[Address]

alter table PizzaStore.[Size]
Drop CONSTRAINT DF_Size_Active;
go 

alter TABLE PizzaStore.[Size]
DROP COLUMN Active;

alter table PizzaStore.[Size]
drop column DateModified;

alter table PizzaStore.[Address]
Drop CONSTRAINT DF_Address_Active;
go 

alter table PizzaStore.[Order]
Drop CONSTRAINT FK_Order_LocationId;
go 

alter table PizzaStore.[Crust]
drop column DateModified;

alter table PizzaStore.[Pizza]
add Name NVARCHAR(50)

alter table PizzaStore.[User]
add Password NVARCHAR(50)

TRUNCATE table PizzaStore.[Location]

INSERT into PizzaStore.Pizza(Name)
VALUES('Supreme')

INSERT into PizzaStore.[Location](Name)
values('Bruce B Downs Blvd')

update PizzaStore.Crust
set Name = 'Thick'
where CrustId = 2 