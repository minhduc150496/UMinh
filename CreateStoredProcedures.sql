-- ================================================
-- Template generated from Template Explorer using:
-- Create Procedure (New Menu).SQL
--
-- Use the Specify Values for Template Parameters 
-- command (Ctrl-Shift-M) to fill in the parameter 
-- values below.
--
-- This block of comments will not be included in
-- the definition of the procedure.
-- ================================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
--CREATE PROCEDURE  LoadOrders
--	-- Add the parameters for the stored procedure here
	
--AS
--BEGIN
--	-- SET NOCOUNT ON added to prevent extra result sets from
--	-- interfering with SELECT statements.
--	SET NOCOUNT ON;

--    -- Insert statements for procedure hereSELECT [orderid]
--    SELECT [orderid]
--      ,[custid]
--      ,[empid]
--      ,[orderdate]
--      ,[requireddate]
--      ,[shippeddate]
--      ,[shipperid]
--      ,[freight]
--      ,[shipname]
--      ,[shipaddress]
--      ,[shipcity]
--      ,[shipregion]
--      ,[shippostalcode]
--      ,[shipcountry]
--  FROM [TSQLFundamentals2008].[Sales].[Orders]
--END
--GO

--ALTER PROCEDURE  [dbo].[InsertOrder](
--	-- Add the parameters for the stored procedure here
--			@custid int
--           ,@empid int
--           ,@orderdate datetime
--           ,@requireddate datetime
--           ,@shippeddate datetime
           
--           ,@shipperid int
--           ,@freight money
--           ,@shipname nvarchar(40)
--           ,@shipaddress nvarchar(60)
--           ,@shipcity nvarchar(15)
           
--           ,@shipregion nvarchar(15)
--           ,@shippostalcode nvarchar(10)
--           ,@shipcountry nvarchar(15)

--	)
--AS
--BEGIN
--	-- SET NOCOUNT ON added to prevent extra result sets from
--	-- interfering with SELECT statements.
--	SET NOCOUNT ON;

--    -- Insert statements for procedure hereSELECT [orderid]
--    INSERT INTO [TSQLFundamentals2008].[Sales].[Orders]
--           ([custid]
--           ,[empid]
--           ,[orderdate]
--           ,[requireddate]
--           ,[shippeddate]
--           ,[shipperid]
--           ,[freight]
--           ,[shipname]
--           ,[shipaddress]
--           ,[shipcity]
--           ,[shipregion]
--           ,[shippostalcode]
--           ,[shipcountry])
--     VALUES
--           (@custid
--           ,@empid
--           ,@orderdate
--           ,@requireddate
--           ,@shippeddate
--           ,@shipperid
--           ,@freight
--           ,@shipname
--           ,@shipaddress
--           ,@shipcity
--           ,@shipregion
--           ,@shippostalcode
--           ,@shipcountry)
--END


--CREATE PROCEDURE  UpdateOrder(
--	-- Add the parameters for the stored procedure here
--			@orderid int
--		   ,@custid int
--           ,@empid int
--           ,@orderdate datetime
--           ,@requireddate datetime
--           ,@shippeddate datetime
--           ,@shipperid int
--           ,@freight money
--           ,@shipname nvarchar(40)
--           ,@shipaddress nvarchar(60)
--           ,@shipcity nvarchar(15)
--           ,@shipregion nvarchar(15)
--           ,@shippostalcode nvarchar(10)
--           ,@shipcountry nvarchar(15)
--	)
--AS
--BEGIN
--	-- SET NOCOUNT ON added to prevent extra result sets from
--	-- interfering with SELECT statements.
--	SET NOCOUNT ON;
		
--    -- Insert statements for procedure hereSELECT [orderid]
--    UPDATE [TSQLFundamentals2008].[Sales].[Orders]
--   SET [custid] =		@custid
--	  ,[empid] =		@empid
--	  ,[orderdate] =	@orderdate
--	  ,[requireddate] = @requireddate
--	  ,[shippeddate] =	@shippeddate
--	  ,[shipperid] =	@shipperid
--	  ,[freight] =		@freight
--	  ,[shipname] =		@shipname
--	  ,[shipaddress] =	@shipaddress
--	  ,[shipcity] =		@shipcity
--	  ,[shipregion] =	@shipregion
--	  ,[shippostalcode] = @shippostalcode
--	  ,[shipcountry] =	@shipcountry
-- WHERE [orderid] = @orderid
--END
--GO


--CREATE PROCEDURE  DeleteOrder(
--	-- Add the parameters for the stored procedure here
--			@orderid int
--	)
--AS
--BEGIN
--	-- SET NOCOUNT ON added to prevent extra result sets from
--	-- interfering with SELECT statements.
--	SET NOCOUNT ON;
		
--    -- Insert statements for procedure hereSELECT [orderid]
--    DELETE FROM [TSQLFundamentals2008].[Sales].[Orders]
--      WHERE [orderid] = @orderid
--END
--GO



--CREATE PROCEDURE  LoadOrderDetails(
--	-- Add the parameters for the stored procedure here
--			@orderid int,
--			@productid int,
--			@uniprice money,
--			@qty smallint,
--			@discount numeric(4,3)
--	)
--AS
--BEGIN
--	-- SET NOCOUNT ON added to prevent extra result sets from
--	-- interfering with SELECT statements.
--	SET NOCOUNT ON;
		
--    -- Insert statements for procedure hereSELECT [orderid]
--    SELECT [orderid]
--      ,[productid]
--      ,[unitprice]
--      ,[qty]
--      ,[discount]
--	FROM [TSQLFundamentals2008].[Sales].[OrderDetails]
--END
--GO


--CREATE PROCEDURE  InsertOrderDetails(
--	-- Add the parameters for the stored procedure here
--			@orderid int,
--			@productid int,
--			@unitprice money,
--			@qty smallint,
--			@discount numeric(4,3)
--	)
--AS
--BEGIN
--	-- SET NOCOUNT ON added to prevent extra result sets from
--	-- interfering with SELECT statements.
--	SET NOCOUNT ON;
		
--    -- Insert statements for procedure hereSELECT [orderid]
--    INSERT INTO [TSQLFundamentals2008].[Sales].[OrderDetails]
--           ([orderid]
--           ,[productid]
--           ,[unitprice]
--           ,[qty]
--           ,[discount])
--     VALUES
--           (@orderid,
--           @productid,
--           @unitprice,
--           @qty,
--           @discount)

--END
--GO


--CREATE PROCEDURE  UpdateOrderDetails(
--	-- Add the parameters for the stored procedure here
--			@orderid int,
--			@productid int,
--			@unitprice money,
--			@qty smallint,
--			@discount numeric(4,3)
--	)
--AS
--BEGIN
--	-- SET NOCOUNT ON added to prevent extra result sets from
--	-- interfering with SELECT statements.
--	SET NOCOUNT ON;
		
--    -- Insert statements for procedure hereSELECT [orderid]
--    UPDATE [TSQLFundamentals2008].[Sales].[OrderDetails]
--	   SET [unitprice] = @unitprice,
--		  [qty] = @qty,
--		  [discount] = @discount
--	 WHERE [orderid] = @orderid

--END
--GO


--CREATE PROCEDURE  DeleteOrderDetails(
--	-- Add the parameters for the stored procedure here
--			@orderid int,
--			@productid int
--	)
--AS
--BEGIN
--	-- SET NOCOUNT ON added to prevent extra result sets from
--	-- interfering with SELECT statements.
--	SET NOCOUNT ON;
		
--    -- Insert statements for procedure hereSELECT [orderid]
--    DELETE FROM [TSQLFundamentals2008].[Sales].[OrderDetails]
--      WHERE [orderid] = @orderid AND [productid] = @productid

--END
--GO


CREATE PROCEDURE  SearchOrdersByProductName(
	-- Add the parameters for the stored procedure here
			@productname nvarchar(40)
	)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
		
    -- Insert statements for procedure hereSELECT [orderid]
select * from Sales.OrderDetails
where productid in (

SELECT productid
  FROM [TSQLFundamentals2008].[Production].Products
  WHERE productname LIKE '%' + @productname + '%'
  )
END
GO