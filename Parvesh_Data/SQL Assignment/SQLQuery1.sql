USE AdventureWorks2008R2;

1. SELECT COUNT(BusinessEntityID) FROM Sales.SalesPerson;

2. SELECT FirstName,LastName FROM Person.Person where FirstName LIKE '%B';

3 .
 
 SELECT FirstName,LastName,JobTitle  
 from person.person right join HumanResources.Employee
 on person.person.BusinessEntityID = HumanResources.Employee.BusinessEntityID
 where JobTitle = 'Design Engineer' or JobTitle =  'Tool Designer' or JobTitle = 'Marketing Assistant';


4 SELECT Name,Color,
	(SELECT max(Weight) from Production.Product )
	FROM Production.Product

	

5.  SELECT Description,ISNULL(MaxQty,0) from Sales.SpecialOffer;

6.  select * from sales.CurrencyRate;

  select AVG(AverageRate) as Average from Sales.CurrencyRate
  where sales.CurrencyRate.FromCurrencyCode = 'USD' and sales.CurrencyRate.ToCurrencyCode = 'GBP' and Year(CurrencyRatedate) = 2005;
  

7. select ROW_NUMBER() OVER(order by Firstname) AS RowNumber,FirstName,LastName  from person.Person where FirstName like '%ss%';

8. select * from Sales.SalesPerson

	select Sales.SalesPerson.BusinessEntityID as SalesPersonID,Sales.SalesPerson.CommissionPct, 
		Case
			WHEN Sales.SalesPerson.CommissionPct = 0.00 Then 'Band 0'
			WHEN sales.SalesPerson.CommissionPct > 0.00 and sales.SalesPerson.CommissionPct < 0.01 Then 'Band 1'
			WHEN sales.SalesPerson.CommissionPct > 0.01 and sales.SalesPerson.CommissionPct < 0.015 Then 'Band 2'
			ELSE  'Band 3'
		END As Commission_Band
		from Sales.SalesPerson;
9.

	select * from person.Person;
	declare @bid int;
	select @bid = BusinessEntityID from person.person where FirstName = 'RUTH' and LastName = 'Ellerbrock' and PersonType = 'EM'

	ExEC dbo.uspGetEmployeeManagers @BusinessEntityID = @bid

10. 
	select * from production.ProductInventory;

	select max(dbo.ufnGetStock(ProductID)) from Production.ProductInventory;

	select ProductID from Production.ProductInventory where Quantity = (select max(dbo.ufnGetStock(ProductID)) from Production.ProductInventory)


11.(Exercise 2)
	
	select * from Sales.SalesOrderHeader
	  
	Using Join
	 
	select * from Sales.Customer
	left outer join Sales.SalesOrderHeader
	on Sales.Customer.CustomerID = Sales.SalesOrderHeader.CustomerID
	where SalesOrderID IS null

	
	Using Subquery:
	Select * from Sales.Customer
	where CustomerID  NOT In (Select CustomerID from sales.SalesOrderHeader );

	Using CTE:

	WITH s AS
	(   SELECT CustomerID
		FROM Sales.SalesOrderHeader
	)
	SELECT *
	FROM Sales.Customer c
	LEFT OUTER JOIN s ON c.CustomerID = s.CustomerID
	WHERE s.CustomerID IS NULL

	Using exists:

	SELECT * from Sales.Customer
	WHERE  EXISTS (
	 select * from Sales.Customer
	left outer join Sales.SalesOrderHeader
	on Sales.Customer.CustomerID = Sales.SalesOrderHeader.CustomerID
	where SalesOrderID IS null
	 );

12.(Exercise 3)

   select top(5)  * from Sales.SalesOrderHeader where TotalDue > 70000;


13.(Exercise 4)

select * from sales.SalesOrderDetail;
select * from sales.CurrencyRate

GO
  create function getSalesOrderDetails(@salesOrderid int,@currencyCode varchar(10),@date date)
  returns @SalesOrderDetails Table  (Quantity int,productid int,unitprice int,targetcurreny int)
  as
	begin
		declare @ConvertedMoney int;
		select @ConvertedMoney = 	 EndOfDayRate from Sales.CurrencyRate where sales.CurrencyRate.CurrencyRateDate = @date and
																					sales.CurrencyRate.ToCurrencyCode = @currencyCode;
		insert @SalesOrderdetails SELECT 
									 OrderQty,
									 ProductID,
									 UnitPrice,
									 UnitPrice * @ConvertedMoney
									 FROM Sales.SalesOrderDetail
									 WHERE SalesOrderID = @salesOrderid
									 return;
	end
GO

select * from getSalesOrderDetails(43659,'EUR','2005-07-05 00:00:00.000');
		

14.(Exercise 5)
select * from person.person
GO
    create procedure proc_SupplyName(@firstName varchar(10))
	as
	Begin
		select FirstName,MiddleName,LastName from Person.Person
			where FirstName = @firstName;
	End;

	Execute proc_Supplyname @firstname = 'Ken';

GO
	create procedure proc_SupplyName1(@firstName varchar(10))
	as
	declare @default varchar(10) = 'Terri';
	Begin
	if(@firstName = 'null')
		select FirstName,MiddleName,LastName from Person.Person
			where FirstName = @default;
	else
		select FirstName,MiddleName,LastName from Person.Person
			where FirstName = @firstName;
	End;

		Execute proc_Supplyname1 @firstname = 'null';

15.(Exercise 6)
select * from Production.Product;


Create TRIGGER tr_listPriceCheck
on Production.Product 
 After Update
AS
	BEGIN
		if EXISTS(select * from deleted ) and exists(select * from inserted)
			DECLARE @listprice as int;
			DECLARE @id  as int;
			select @listprice =  ListPrice from inserted;
			select @id =  ProductID from inserted;
			
			if @listprice >= (0.15 * (select ListPrice from deleted))
			BEGIN
				print 'listprice cant be increased upto 15 percent in a single change';
			END;
	END;

Create TRIGGER tr_listPriceCheckAfterUpdate
on Production.Product 
After Update
AS
	BEGIN
		if EXISTS(select * from deleted ) and exists(select * from inserted)
			DECLARE @oldlistprice as int;
			DECLARE @newListPrice  as int;
			select @oldlistprice =  ListPrice from deleted;
			select @newListPrice =  ListPrice from inserted;
			
			if @oldlistprice != @newListPrice
				Begin
					print'Price is  updated '
				End;
			else
				BEGIN
					print 'listprice is not updated';
				END;
	END;

create trigger tr_onUpdate
on Production.Product
After update
As
	Begin
	print'i am updated'
	End;

UPDATE  Production.Product SET Product.ListPrice = 18 where ProductId = 1;

		

