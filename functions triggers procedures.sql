use ecommerce 
-------------------------------------FUNCTIONS-------------------------------------------------------

CREATE FUNCTION UNIT_PRICE(@PRODUCT INT)
RETURNS FLOAT
AS
BEGIN
	DECLARE @PRICE FLOAT = (SELECT PRICE FROM PRODUCT WHERE ID = @PRODUCT)
	RETURN @PRICE
END

CREATE FUNCTION ORDER_PRICE(@QUANTITY INT,@PRODUCT INT)
RETURNS FLOAT
AS
BEGIN
	DECLARE @TOTAL FLOAT, @PRICE FLOAT = (SELECT DBO.UNIT_PRICE(@PRODUCT)) 
	SET @TOTAL = @PRICE*@QUANTITY
	RETURN @TOTAL
END

------------------------------------VIEW--------------------------------------------------------------------
create view view_invoice 
as 
select c.Name as [Customer Name] , p.name as [Product Name] , o.total_price as [Total Price], o.quantity as [Quantity] , i.pur_date as [Purchase Date]  from customer c,  Product p , order_ o , invoice i where c.ID = o.cus_ID and o.product_ID = p.ID and o.ID = i.order_ID

------------------------------------------------TRIGGERS------------------------------------------------------------

CREATE TRIGGER ORDERS_DETAIL
ON ORDER_
AFTER INSERT
AS
BEGIN
	DECLARE @QUANTITY INT = (SELECT quantity FROM inserted),
	@CUSTOMER INT = (SELECT cus_ID FROM inserted),
	@ORDER INT = (SELECT ID FROM inserted),
	@PRODUCT int = (SELECT product_ID FROM inserted)

	UPDATE order_ SET TOTAL_PRICE = (SELECT DBO.ORDER_PRICE(@QUANTITY,@PRODUCT))
	WHERE ID=@ORDER

	INSERT INTO INVOICE VALUES (@CUSTOMER,(SELECT DBO.ORDER_PRICE(@QUANTITY,@PRODUCT)),GETDATE(),@ORDER)
END
            
CREATE TRIGGER update_price
ON ORDER_
AFTER update
AS
BEGIN
	DECLARE @QUANTITY INT = (SELECT quantity FROM inserted),
	@CUSTOMER INT = (SELECT cus_ID FROM inserted),
	@ORDER INT = (SELECT ID FROM inserted),
	@PRODUCT int = (SELECT product_ID FROM inserted)

	UPDATE order_ SET TOTAL_PRICE = (SELECT DBO.ORDER_PRICE(@QUANTITY,@PRODUCT))
	WHERE ID=@ORDER

	update invoice SET total = (SELECT DBO.ORDER_PRICE(@QUANTITY,@PRODUCT)) WHERE order_ID=@ORDER
END

-------------------------------------------------PROCEDURES-------------------------------------------------------

create procedure delete_order (@order_id int)
as begin
delete from invoice where order_ID = @order_id
delete from order_ where ID = @order_id
end
-------------------PROCEDURE TO UPDATE QUANTITY FROM ORDER ---------------
create procedure update_order_qty (@order_id int , @qty int)
as begin
update order_ set quantity = @qty where ID = @order_id 
end

--------------Admin LOGIN PROCEDURE-------------
CREATE PROCEDURE loginadmin(@username nvarchar(50), @pass nvarchar(50))
AS
BEGIN
	select Name , pass from admin where name = @username and pass = @pass
END
--------------Vendor LOGIN PROCEDURE-------------
CREATE PROCEDURE loginvendor(@username nvarchar(50), @pass nvarchar(50))
AS
BEGIN
	select Name , pass from vendor where name = @username and pass = @pass
END
--------------Customer LOGIN PROCEDURE-------------
CREATE PROCEDURE logincustomer(@username nvarchar(50), @pass nvarchar(50))
AS
BEGIN
	select Name , pass from customer where name = @username and pass = @pass
END


-------------vendor Registration Procedure----------
CREATE PROCEDURE registervendor(@username nvarchar(50),@email nvarchar(50), @phone nvarchar(50),@address nvarchar(50), @pass nvarchar(50))
AS
BEGIN
	insert into vendor values(@username,@email,@phone,@address,@pass) 
END

-------------Customer Registration Procedure----------
CREATE PROCEDURE registercustomer(@username nvarchar(50),@email nvarchar(50), @phone nvarchar(50),@address nvarchar(50), @pass nvarchar(50))
AS
BEGIN
	insert into customer values(@username,@email,@phone,@address,@pass) 
END

