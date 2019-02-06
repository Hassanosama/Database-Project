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
--** The following procedures are for uploading an item(movie,tv series, game or song)
--** I'm assuming that ids for these items are auto-incremented and constraints are ckecked by GUI.

CREATE PROCEDURE upload_movie
	-- Add the parameters for the stored procedure here
	--@type int,			
	@Name varchar(50),		-- Add to items
	@Price int,				-- Add to items
	@Year int,				-- Add to items
	@UploaderID int,		-- Add to items
	@Poster_Url image,-- Add to items
	
	@Duration float,		-- Add to Movies
	@ID_Director int,		-- Add to Movies
	@ID_Game int,			-- Add to Movies

	@Genre varchar(50)		-- Add to Genre

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	DECLARE @ItemID int;	--This variable will hold the current item id.
	   
	insert into item(Name,Price,Year,Rate,#Purchase,Type,Uploader_ID,Poster)
	values(@Name,@Price,@Year,5,0,1,@UploaderID,@Poster_Url)
	-- type : 1 = movie, 2 = tv series, 3 = game, 4 = song
	-- initially the rate = 5, #purchases = 0

	SET @ItemID = (SELECT MAX(ID) FROM Item);	-- Now @ItemID has the current item id.

	insert into Movies(ID,Duration,ID_Director,ID_Game)
	values(@ItemID,@Duration,@ID_Director,@ID_Game)

	insert into Genre(ID_Item,Genre,Type)
	values(@ItemID,@Genre,1)

END
GO

--***************************************************************************************

CREATE PROCEDURE upload_series
	-- Add the parameters for the stored procedure here
	--@type int,			
	@Name varchar(50),		-- Add to items
	@Price int,				-- Add to items
	@Year int,				-- Add to items
	@UploaderID int,		-- Add to items
	@Poster_Url image,		-- Add to items
	
	@#Seasons float,		-- Add to TV_Series
	@ID_Director int,		-- Add to TV_Series

	@Genre varchar(50)		-- Add to Genre

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	DECLARE @ItemID int;	--This variable will hold the current item id.
	   
	insert into item(Name,Price,Year,Rate,#Purchase,Type,Uploader_ID,Poster)
	values(@Name,@Price,@Year,5,0,2,@UploaderID,@Poster_Url)
	-- type : 1 = movie, 2 = tv series, 3 = game, 4 = song
	-- initially the rate = 5, #purchases = 0

	SET @ItemID = (SELECT MAX(ID) FROM Item);	-- Now @ItemID has the current item id.

	insert into TV_Series(ID,#Seasons,ID_Director)
	values(@ItemID,@#Seasons,@ID_Director)

	insert into Genre(ID_Item,Genre,Type)
	values(@ItemID,@Genre,2)

END
GO

--***************************************************************************************

CREATE PROCEDURE upload_game
	-- Add the parameters for the stored procedure here
	--@type int,			
	@Name varchar(50),		-- Add to items
	@Price int,				-- Add to items
	@Year int,				-- Add to items
	@UploaderID int,		-- Add to items
	@Poster_Url image,		-- Add to items
	
	@Studio	varchar(50),	-- Add to Games

	@Genre varchar(50)		-- Add to Genre

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	DECLARE @ItemID int;	--This variable will hold the current item id.
	   
	insert into item(Name,Price,Year,Rate,#Purchase,Type,Uploader_ID,Poster)
	values(@Name,@Price,@Year,5,0,3,@UploaderID,@Poster_Url)
	-- type : 1 = movie, 2 = tv series, 3 = game, 4 = song
	-- initially the rate = 5, #purchases = 0

	SET @ItemID = (SELECT MAX(ID) FROM Item);	-- Now @ItemID has the current item id.

	insert into Games(ID,Studio)
	values(@ItemID,@Studio)

	insert into Genre(ID_Item,Genre,Type)
	values(@ItemID,@Genre,3)

END
GO

--***************************************************************************************

CREATE PROCEDURE upload_song
	-- Add the parameters for the stored procedure here
	--@type int,			
	@Name varchar(50),		-- Add to items
	@Price int,				-- Add to items
	@Year int,				-- Add to items
	@UploaderID int,		-- Add to items
	@Poster_Url image,		-- Add to items
	
	@ID_Singer int,	    -- Add to Songs
	@Album varchar(50), -- Add to Songs
	@Duration float,	-- Add to Songs

	@Genre varchar(50)		-- Add to Genre

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	DECLARE @ItemID int;	--This variable will hold the current item id.
	   
	insert into item(Name,Price,Year,Rate,#Purchase,Type,Uploader_ID,Poster)
	values(@Name,@Price,@Year,5,0,4,@UploaderID,@Poster_Url)
	-- type : 1 = movie, 2 = tv series, 3 = game, 4 = song
	-- initially the rate = 5, #purchases = 0

	SET @ItemID = (SELECT MAX(ID) FROM Item);	-- Now @ItemID has the current item id.

	insert into Songs(ID,ID_Singer,Album,Duration)
	values(@ItemID,@ID_Singer,@Album,@Duration)

	insert into Genre(ID_Item,Genre,Type)
	values(@ItemID,@Genre,4)

END
GO