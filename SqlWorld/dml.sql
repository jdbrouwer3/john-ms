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

select count(*), firstname, lastname
from SalesLT.Customer
where FirstName = 'john'
group by LastName, FirstName;

-- min, max, & average ID number of custumers ending with 'r':
select min(CustomerID), max(CustomerID), AVG(CustomerID)
from SalesLT.Customer
where FirstName like '%r' or MiddleName like '%r' or LastName like '%r';

-- count of person fn, ln, ln starting with 'k' or 'm'
select count(*) as Number, FirstName, LastName
from SalesLT.Customer
where LastName like '[km]%' 
group by FirstName, LastName
having count(*) < 2;

-- now with names in order
select count(*) as Number, FirstName as [Fn], LastName as "Ln"
from SalesLT.Customer
where LastName like '[km]%' 
group by FirstName, LastName
having count(*) < 2
order by Fn desc, Ln asc;

select CountryRegion
from SalesLT.Address

-- state in address table with city that contains 't'. Min and max in order
select count(*) as Number, StateProvince as [State]
from SalesLT.Address
where CountryRegion = 'United States' and City like '%t%'
group by StateProvince
order by Number desc;

-- any customer's first name is another one's last name
select firstname
from SalesLT.Customer
where FirstName inner JOIN lastname;

-- address of my customers
select count(*), slc.FirstName, sla.City, sla.StateProvince
from SalesLT.Customer as slc
left join SalesLT.CustomerAddress as slca on slca.CustomerID = slc.CustomerID
left join SalesLT.Address as sla on sla.AddressID = slca.AddressID
group by FirstName, sla.city, sla.StateProvince
having count(*) > 1;
