SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE RetMovies 

AS
BEGIN
	
	select Name,Type,Poster
	from Item
	Where Item.Type = 1

END
GO
