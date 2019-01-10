use PizzaStoreDB;
go

--view
create view vw_GetCrusts with SCHEMABINDING
as
( 
    select Name 
    from PizzaStore.Crust as c
    inner join PizzaStore.Size as s on s.SizeId = c.CrustId
);
go 

select * from vw_GetCrusts;
go 

--function 
create function fn_CountCrusts(@countId int)
returns int 
as 
begin 
    declare @counter int;

    select @counter = count(*)
    from PizzaStore.Crust
    where CrustId <= @countId

    return @counter
end;
go

select * from PizzaStore.Crust where CrustId = dbo.fn_CountCrusts(1); --dbo is database owner
go 

create function fn_CountCrusts2(@countId int)
returns table  
as 
    return 
    select Name
    from PizzaStore.Crust
    where CrustId >= @id
go

select * from fn_CountCrusts2(2);
go 

--stored procedures
create PROCEDURE pr_SetUser(@name nvarchar(50), @street nvarchar(200), @city nvarchar(50), @addressId int output)
as 
begin
    declare @addressId int;

    select @addressId = AddressId
    from PizzaStore.Address
    where Street = @street, City = @city;

    begin TRANSACTION
        BEGIN try 
            if(@addressId > 0)
            begin 
                insert into PizzaStore.[User][Name], (AddressId)
                values (@name, @addressId)
            end 
            else 
            begin 
                insert into PizzaStore.[Address]([City], [Street])
                output @addressId = inserted[AddressId]
                values(@city, @street)


                insert into PizzaStore.[User](Name)
                values (@name, @addressId)
            end 

            raiserror (5000, 1, 1, 'this is an error')
            throw('this is another error', 5000)

            commit TRANSACTION
        end try
        begin catch 
            rollback transaction 
            print error_severity();
            print error_message();
        end catch 
end; 
go

declare @id int;
execute dbo.pr_SetUser 'fred', 'fowler', 'tampa bay', @id output;