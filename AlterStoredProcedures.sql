USE [TSQLFundamentals2008]
GO
/****** Object:  StoredProcedure [dbo].[LoadOrders]    Script Date: 11/24/2016 14:36:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
--ALTER PROCEDURE  [dbo].[SearchOrders] (
--	-- Add the parameters for the stored procedure here
--		@searchByOrderDate bit,
--		@minOrderDate datetime,
--		@maxOrderDate datetime,
		
--		@searchByRequiredDate bit,
--		@minRequiredDate datetime,
--		@maxRequiredDate datetime,
		
--		@searchByShippedDate bit,
--		@minShippedDate datetime,
--		@maxShippedDate datetime,
		
--		@searchByCustName bit,
--		@custName nvarchar(30),
		
--		@searchByOrderTotalPrice bit,
--		@minTotalPrice money,
--		@maxTotalPrice money
--	)	
--AS
--BEGIN
--	-- SET NOCOUNT ON added to prevent extra result sets from
--	-- interfering with SELECT statements.
--	SET NOCOUNT ON;

--    -- Insert statements for procedure hereSELECT [orderid]
    
--    -- select all
--    (SELECT [orderid]
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
--  FROM [TSQLFundamentals2008].[Sales].[Orders])
  
--  INTERSECT
  
--  -- search by order date
--  (SELECT [orderid]
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
--  WHERE @searchByOrderDate=1 AND orderdate between @minOrderDate and @maxOrderDate
--  )
  
--  INTERSECT
  
--  -- search by required date
--  (SELECT [orderid]
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
--  WHERE @searchByOrderDate=1 AND orderdate between @minOrderDate and @maxOrderDate
--  )
  
--END


--CREATE PROCEDURE  [dbo].[LoadOrderDetailsByOrderID] (
--	-- Add the parameters for the stored procedure here
--		@orderid int
--	)	
--AS
--BEGIN
--	-- SET NOCOUNT ON added to prevent extra result sets from
--	-- interfering with SELECT statements.
--	SET NOCOUNT ON;

--	SELECT [orderid]
--      ,[productid]
--      ,[unitprice]
--      ,[qty]
--      ,[discount]
--  FROM [TSQLFundamentals2008].[Sales].[OrderDetails]
--  WHERE [orderid] = @orderid

--END

--GO

--ALTER PROCEDURE  [dbo].[SearchOrderItemByProductName] (
--	-- Add the parameters for the stored procedure here
--		@orderid int,
--		@productname nvarchar(40)
--	)	
--AS
--BEGIN
--	-- SET NOCOUNT ON added to prevent extra result sets from
--	-- interfering with SELECT statements.
--	SET NOCOUNT ON;

--	SELECT [orderid]
--      ,[productid]
--      ,[unitprice]
--      ,[qty]
--      ,[discount]
--  FROM [TSQLFundamentals2008].[Sales].[OrderDetails]
--  WHERE [orderid] = 10251 AND [productid] in
--	  (
--		  SELECT [productid] 
--		  FROM [TSQLFundamentals2008].[Production].[Products]
--		  WHERE [productname] LIKE '%' + @productname + '%'
--	  )

--END
