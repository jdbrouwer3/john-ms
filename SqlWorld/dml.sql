use adventureworks2019;
go

--select
select 1 + 1;
select 'John' + 1;
select 'John' + 'Brouwer';

select *
from SalesLT.Customer;

select FirstName, LastName
from SalesLT.Customer

select firstname, lastname, MiddleName
from SalesLT.Customer
where firstname = 'john';

select firstname, lastname, MiddleName
from SalesLT.Customer
where (firstname = 'john' or FirstName = 'james') and MiddleName is Null;

select firstname, lastname
from SalesLT.Customer
where FirstName = 'john' and lastname <> 'beaver'

select firstname, lastname
from SalesLT.Customer
where FirstName > 'a' and FirstName < 'b';

select firstname, lastname
from SalesLT.Customer
where FirstName like 'a%';

select firstname, lastname
from SalesLT.Customer
where LastName like '%ber%' 

-- second to last letter of lastname is 'e'
select firstname, lastname
from SalesLT.Customer
where LastName like '%e_'

-- isnull is strictly T SQL
select firstname + ' ' + ISNULL(MiddleName, '') + ' ' + lastname
from SalesLT.Customer

-- coalesce is SQL STD
select firstname + ' ' + coalesce(MiddleName, '') + ' ' + lastname
from SalesLT.Customer

-- shows null values for middlename as 'eric'
select firstname + ' ' + coalesce(MiddleName, null, 'eric') + ' ' + lastname
from SalesLT.Customer