USE [HBO]
GO
/****** Object:  StoredProcedure [dbo].[Upload_Song]    Script Date: 12/20/2017 00:38:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[Upload_Song]

	@Name varchar(50),		-- Add to items
	@Price int,				-- Add to items
	@Year int,				-- Add to items
	@Rate float,
	@UploaderUserName varchar(50),		-- Add to items (his id)
	@Poster_Url image,-- Add to items
	
	@Duration float,		
	@Singer varchar(50),
	@Album varchar(50)	

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	DECLARE @ItemID int;	--This variable will hold the current item id.
	DECLARE @UploaderID int;
	DECLARE @SingerID int;
	
	--Insertion In Item Table.
	set @UploaderID = (select ID from Users where Users.Users_name = @UploaderUserName);
	insert into Item(Name,Price,Year,Rate,#Purchase,Uploader_ID,Type,Poster)
	values(@Name,@Price,@Year,@Rate,0,@UploaderID,4,@Poster_Url);
	

	set @ItemID = (	select max(ID) from Item);	-- Now @ItemID has the current item id.
	SET @SingerID = (SELECT ID FROM Item where Name = @Singer);	-- Now @ItemID has the current item id.
	
	insert into Songs(ID,ID_Singer,Album,Duration)
	values(@ItemID,@SingerID,@Album,@Duration);
	
	
	select @ItemID;--Return The Item ID

	

END

