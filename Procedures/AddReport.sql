SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE AddReport 
		@username varchar(50),
		@itemname varchar(50),
		@comment varchar(50)
AS
BEGIN

DECLARE @userid int
DECLARE @itemid int

		select @itemid = I.ID ,@userid = U.ID
		from Item as I , Users as U
		where I.Name = @itemname AND U.Users_name = @username;
		
		insert into Reports(ID_Item,ID_Users,Comment)
		values(@itemid,@userid,@comment);	

END
GO
