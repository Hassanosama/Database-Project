USE [HBO]
GO
/****** Object:  StoredProcedure [dbo].[UpdateItem]    Script Date: 12/20/2017 20:25:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
ALTER PROCEDURE [dbo].[UpdateItem] 
       @itemid int,
       @itemname varchar(50),
       @itemrate int,
       @price int,
       @itemposter Image
      
       
AS
BEGIN
		
	   update Item
	   set Name = @itemname,
	       Rate = @itemrate,
	       Poster = CONVERT(VarBinary(MAX),@itemposter)
	   where Item.ID = @itemid;    
	       	
END
