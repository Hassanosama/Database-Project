SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE AddHistory  
         @username varchar(50),
         @itemname varchar(50)
         
AS
BEGIN

		insert into History(ID_Item,ID_Users,Type)
		select I.ID, U.ID ,Type
		from Item as I, Users as U
		where I.Name = @itemname AND U.Users_name = @username;

END
GO
