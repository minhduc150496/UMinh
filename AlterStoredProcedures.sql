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
ALTER PROCEDURE  [dbo].[SearchOrders] (
	-- Add the parameters for the stored procedure here
		@searchByOrderDate bit,
		@minOrderDate datetime,
		@maxOrderDate datetime,
		
		@searchByRequiredDate bit,
		@minRequiredDate datetime,
		@maxRequiredDate datetime,
		
		@searchByShippedDate bit,
		@minShippedDate datetime,
		@maxShippedDate datetime,
		
		@searchByCustName bit,
		@custName nvarchar(30),
		
		@searchByOrderTotalPrice bit,
		@minTotalPrice money,
		@maxTotalPrice money
	)	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure hereSELECT [orderid]
    
    -- select all
    (SELECT [orderid]
      ,[custid]
      ,[empid]
      ,[orderdate]
      ,[requireddate]
      ,[shippeddate]
      ,[shipperid]
      ,[freight]
      ,[shipname]
      ,[shipaddress]
      ,[shipcity]
      ,[shipregion]
      ,[shippostalcode]
      ,[shipcountry]
  FROM [TSQLFundamentals2008].[Sales].[Orders])
  
  INTERSECT
  
  -- search by order date
  (SELECT [orderid]
      ,[custid]
      ,[empid]
      ,[orderdate]
      ,[requireddate]
      ,[shippeddate]
      ,[shipperid]
      ,[freight]
      ,[shipname]
      ,[shipaddress]
      ,[shipcity]
      ,[shipregion]
      ,[shippostalcode]
      ,[shipcountry]
  FROM [TSQLFundamentals2008].[Sales].[Orders]
  WHERE @searchByOrderDate=1 AND orderdate between @minOrderDate and @maxOrderDate
  )
  
  INTERSECT
  
  -- search by required date
  (SELECT [orderid]
      ,[custid]
      ,[empid]
      ,[orderdate]
      ,[requireddate]
      ,[shippeddate]
      ,[shipperid]
      ,[freight]
      ,[shipname]
      ,[shipaddress]
      ,[shipcity]
      ,[shipregion]
      ,[shippostalcode]
      ,[shipcountry]
  FROM [TSQLFundamentals2008].[Sales].[Orders]
  WHERE @searchByOrderDate=1 AND orderdate between @minOrderDate and @maxOrderDate
  )
  
END
