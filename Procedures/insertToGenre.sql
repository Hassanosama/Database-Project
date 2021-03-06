USE [HBO]
GO
/****** Object:  StoredProcedure [dbo].[insertGenre]    Script Date: 18/12/2017 04:57:06 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [insertGenre]
	-- Add the parameters for the stored procedure here
	@itemID varchar(50),
	@Genre varchar(50),		-- Add to Genre
	@Type int			-- Add to Genre
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
   	
	insert into Genre(Genre,ID_Item,Type)
	values(@Genre,@ItemID,@Type)

END
