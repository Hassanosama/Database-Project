USE [HBO]
GO
/****** Object:  StoredProcedure [dbo].[Buy]    Script Date: 12/18/2017 11:01:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
ALTER PROCEDURE [dbo].[Buy] 
         @username varchar(50),
         @itemname varchar(50)
AS
BEGIN
		 insert into Purchase (ID_Item,ID_Users,Type)
		 select I.ID , U.ID , Type
		 from Item as I , Users as U
		 where I.Name = @itemname AND U.Users_name = @username;
		 
		 update Item set #Purchase = #Purchase + 1 where Item.ID = (select ID from Item where @itemname = Item.Name);
		 

END
