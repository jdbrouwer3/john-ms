use adventureworks2019;
go

select count(*), slc.FirstName, sla.City, sla.StateProvince
from SalesLT.Customer as slc
left join SalesLT.CustomerAddress as slca on slca.CustomerID = slc.CustomerID
left join SalesLT.Address as sla on sla.AddressID = slca.AddressID
group by FirstName, sla.city, sla.StateProvince
having count(*) > 1;

select *
from SalesLT.Customer as slc
left join SalesLT.CustomerAddress as slca on slca.CustomerID = slc.CustomerID
where slca.AddressID is null;

-- all the orders by any of my customers. Which of my customers bought anything
select slc.CustomerID, slc.LastName
from SalesLT.Customer as slc
inner join SalesLT.SalesOrderHeader as slsoh on slsoh.CustomerID = slc.CustomerID

-- product names bought by customers
select slc.CustomerID, slc.LastName
from SalesLT.Customer as slc
inner join SalesLT.SalesOrderHeader as slsoh on slsoh.CustomerID = slc.CustomerID
left join SalesLT.SalesOrderDetail as slsod on slsod.SalesOrderID = slsoh.SalesOrderID
left join SalesLT.Product as slp on slp.ProductID = slsod.ProductID;

-- all product bought by customers if firstname is 'james' & cost > $100 & product includes 'touring'
select slc.CustomerID, slc.FirstName, slc.LastName, slp.Name, slsoh.TotalDue
from SalesLT.Customer as slc
inner join SalesLT.SalesOrderHeader as slsoh on slsoh.CustomerID = slc.CustomerID
left join SalesLT.SalesOrderDetail as slsod on slsod.SalesOrderID = slsoh.SalesOrderID
left join SalesLT.Product as slp on slp.ProductID = slsod.ProductID
where slc.FirstName like 'J%' and slsoh.TotalDue > 100 and slp.Name like '%touring%'

-- using sub queries 
select slc.CustomerID, slc.FirstName, slc.LastName, slp.Name, slsoh.TotalDue
from SalesLT.Customer as slc
inner join
(
    select customerid, totaldue, salesorderid
    from SalesLT.SalesOrderHeader
    where TotalDue > 100
) as slsoh on slsoh.CustomerID = slc.CustomerID
left join SalesLT.SalesOrderDetail as slsod on slsod.SalesOrderID = slsoh.SalesOrderID
inner join 
(
    select productid, name
    from SalesLT.Product
    where name like '%touring%'    
) as slp on slp.ProductID = slsod.ProductID
where slc.FirstName like 'J%';

-- adding only bought 1
select slc.CustomerID, slc.FirstName, slc.LastName, slp.Name, slsoh.TotalDue
from SalesLT.Customer as slc
inner join SalesLT.SalesOrderHeader as slsoh on slsoh.CustomerID = slc.CustomerID
left join SalesLT.SalesOrderDetail as slsod on slsod.SalesOrderID = slsoh.SalesOrderID
left join SalesLT.Product as slp on slp.ProductID = slsod.ProductID
where slc.FirstName like 'J%' and slsoh.TotalDue > 100 and slp.Name like '%touring%'

-- using sub queries 
select slc.CustomerID, slc.FirstName, slc.LastName, slp.Name, slsoh.TotalDue
from SalesLT.Customer as slc
inner join
(
    select customerid, totaldue, salesorderid
    from SalesLT.SalesOrderHeader
    where TotalDue > 100
) as slsoh on slsoh.CustomerID = slc.CustomerID
inner join 
(
    select SalesOrderID, productid, orderqty
    from SalesLT.SalesOrderDetail
    where OrderQty = 1
) as slsod on slsod.SalesOrderID = slsoh.SalesOrderID
inner join 
(
    select productid, name
    from SalesLT.Product
    where name like '%touring%'    
) as slp on slp.ProductID = slsod.ProductID
where slc.FirstName like 'J%';

with orders as 
(
    select customerid, totaldue, salesorderid
    from SalesLT.SalesOrderHeader
    where TotalDue > 100
), details as 
(
    select SalesOrderID, productid, orderqty
    from SalesLT.SalesOrderDetail
    where OrderQty = 1
), products as 
(
    select productid, name
    from SalesLT.Product
    where name like '%touring%'  
)
select slc.customerid, slc.lastname, slp.name, slsoh.totaldue 
from SalesLT.Customer as slc 
inner join orders on orders.customerId = slc.customerId 
inner join details on details.salesorderid = orders.SalesOrderID 
inner join products on products.ProductID = details.ProductID
where slc.FirstName = 'j%'



-- all customers and their address that bought a product with a price > $10 in July
select slc.customerid, slc.firstname, slc.lastname, sla.AddressLine1, sla.AddressLine2, sla.city, sla.StateProvince
from SalesLT.Customer as slc 

inner join
(
    select customerid, totaldue, salesorderid
    from SalesLT.SalesOrderHeader
    where TotalDue > 10
) as slsoh on slsoh.CustomerID = slc.CustomerID

inner join 
(
    select customerId, AddressID
    from SalesLT.CustomerAddress

) as slca on slca.CustomerID = slc.CustomerID
inner join 
(
    select addressid, AddressLine1, AddressLine2, city, StateProvince
    from SalesLT.Address
) as sla on sla.AddressID = slca.AddressID

-- all customers whose first name is another customer's last name
select c.firstname
from SalesLT.Customer c
inner join SalesLT.Customer as slc on slc.lastname = c.firstname
order by c.FirstName

-- using set 
select firstname
from SalesLT.Customer
union 
select lastname
from SalesLT.Customer;

select firstname
from SalesLT.Customer
union all
select lastname
from SalesLT.Customer;

select firstname
from SalesLT.Customer
except 
select lastname
from SalesLT.Customer;

select firstname
from SalesLT.Customer
intersect 
select lastname
from SalesLT.Customer;

-- first names that are last names
select firstname 
from SalesLT.Customer
where FirstName in 
(
    select LastName
    from SalesLT.Customer
);

-- something I missed

select totaldue, ModifiedDate
from SalesLT.SalesOrderHeader as slsoh 
where ModifiedDate between '2008-06-08 00:00:00:001' and getdate();