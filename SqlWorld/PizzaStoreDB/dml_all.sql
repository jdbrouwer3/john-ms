use PizzaStoreDB
go 

--simple insert
insert into PizzaStore.Crust()
values('ThinCrust');

--use this one most of the time!
insert into PizzaStore.Crust([Name])
values('PanCrust')

insert into PizzaStore.Crust([Name]) --insert data from another table. like a copy & paste
select [Name]
from PizzaStore.Size;

bulk insert PizzaStore.Crust from 'crustvalues.csv' with (fieldterminator=',', rowterminator='\n')

-- simple update. Updates the entire table to 'TampaStyle'. Dont.
update PizzaStore.Crust
set Name = 'TampaStyle';

--update this way.
update t 
set Name = 'StPeteStyle'
from PizzaStore.Crust as t 
where Name = 'TampaStyle';

--delete everything inside table
-- delete from PizzaStore.Crust;

-- delete t
-- from PizzaStore.Crust as t
-- where CrustId < 10;




---------------------------------------------------------------------------------------------------------
-- insert into PizzaStore.Address([Street], [City], [State])
-- values('12702 Bruce Blvd', 'Tampa', 'FL');

-- insert into PizzaStore.Address([Street], [City], [State])
-- values('2307 Flecter Ave', 'Tampa', 'FL');

-- insert into PizzaStore.Address([Street], [City], [State])
-- values('11754 Fowler', 'Tampa', 'FL');

-- insert into PizzaStore.Crust([Name])
-- values('ThinCrust')

-- insert into PizzaStore.Crust([Name])
-- values('PanCrust')

-- insert into PizzaStore.Location([AddressId], [Name])
-- values(1, 'IQ')

-- insert into PizzaStore.Location([AddressId], [Name])
-- values(2, 'USF')

-- insert into PizzaStore.Location([AddressId], [Name])
-- values(3, 'University')






select LocationId, Name
from PizzaStore.[Location]

select * from PizzaStore.[User]

select * from PizzaStore.[Order]

select * from PizzaStore.[Pizza]

select *
from PizzaStore.Size

SELECT *
from PizzaStore.Crust

select *
from PizzaStore.Topping

delete from PizzaStore.Topping
where Name = 'MozzCheese';

select *
from PizzaStore.[User]

select * from PizzaStore.[Crust]

select * from PizzaStore.[Location]

select *
from PizzaStore.Address

alter table PizzaStore.[User]
drop COLUMN AddressId







-----
-- insert into PizzaStore.[Order](LocationId, UserId, Total, DateOrdered)
-- values(4, 1, 8.99, GETDATE())

select OrderId, LocationId, UserId, total
from PizzaStore.[Order]

-- insert into PizzaStore.Pizza([CrustId], [OrderId], [SizeId], [Price])
-- values(1, 8, 1, 5.55)

insert into PizzaStore.PizzaToppping([PizzaToppingId], [PizzaId], [ToppingId])
values(1, 1, 1)

-- insert PizzaStore.Size([Name])
-- values('Small')

-- insert PizzaStore.Size([Name])
-- values('Medium')

-- insert PizzaStore.Size([Name])
-- values('Large')

-- insert PizzaStore.Topping([Name])
-- values ('PizzaSause')

-- insert PizzaStore.Topping([Name])
-- values ('MozzCheese')

-- insert PizzaStore.Topping([Name])
-- values ('CheddarCheese')

-- insert PizzaStore.Topping([Name])
-- values ('Pepporoni')

-- insert PizzaStore.Topping([Name])
-- values ('Sausage')

-- insert PizzaStore.Topping([Name])
-- values ('Ham')

-- insert PizzaStore.Topping([Name])
-- values ('Pineapple')

-- insert PizzaStore.[User](AddressId, Name)
-- values(1, 'Alan Jackon')

select Name
from PizzaStore.Location

insert PizzaStore.[User](AddressId, Name)
values(2, 'John Brouwer')