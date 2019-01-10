use PizzaStoreDB
go 

--simple insert
insert into PizzaStore.Crust()
values('ThinCrust');

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
delete from PizzaStore.Crust;

delete t
from PizzaStore.Crust as t
where CrustId < 10;





