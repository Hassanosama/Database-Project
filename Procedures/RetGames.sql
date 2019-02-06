SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE RetGames 

AS
BEGIN
	
	select Name,Type,Poster
	from Item
	where Item.Type = 3

END
GO
