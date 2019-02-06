
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE SearchItems @type int,@genre varchar(50),@name varchar(50)
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	if @type = 0 and @genre = 'All' 
	select Name,Type,Poster,ID from Item where Name like '%'+@name+'%';

	else if @type = 0 and @genre <> 'All' 
	Select Name,I.Type,Poster,I.ID from Item as I,Genre where I.ID = Genre.ID_Item AND Genre.Genre = @genre and Name like '%'+@name+'%';
	
	else if @type <> 0 and @genre = 'All' 
	select Name,Type,Poster,ID from Item where Type = @type and Name like '%'+@name+'%';
	
	else
	Select Name,I.Type,Poster,I.ID from Item as I,Genre where I.ID = Genre.ID_Item AND Genre.Genre = @genre and I.Type = @type and Name like '%'+@name+'%';	
    
END
GO
