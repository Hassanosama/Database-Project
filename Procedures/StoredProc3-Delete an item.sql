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

--***************************************************************************************
--** The following procedures are for Deleting an item(movie,tv series, game or song)
--** I'm assuming that all constraints are ckecked by GUI.
--** the order of deletion matters because of referential constraints.


CREATE PROCEDURE delete_movie
	-- Add the parameters for the stored procedure here
	--@type int,	
	@ItemID int	

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here

	
	Delete from Genre 
				where ID_Item = @ItemID

	Delete from Movies 
				where ID = @ItemID

	Delete from Item 
				where ID = @ItemID



END
GO

--***************************************************************************************

CREATE PROCEDURE delete_series
	-- Add the parameters for the stored procedure here
	--@type int,	
	@ItemID int		

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here

	
	Delete from Genre 
				where ID_Item = @ItemID

	Delete from TV_Series 
				where ID = @ItemID

	Delete from Item 
				where ID = @ItemID



END
GO


--***************************************************************************************
CREATE PROCEDURE delete_game
	-- Add the parameters for the stored procedure here
	--@type int,	
	@ItemID int	

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here

	
	Delete from Genre 
				where ID_Item = @ItemID

	Delete from Games 
				where ID = @ItemID

	Delete from Item 
				where ID = @ItemID



END
GO


--***************************************************************************************
CREATE PROCEDURE delete_song
	-- Add the parameters for the stored procedure here
	--@type int,	
	@ItemID int		

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here

	
	Delete from Genre 
				where ID_Item = @ItemID

	Delete from Songs 
				where ID = @ItemID

	Delete from Item 
				where ID = @ItemID



END
GO
