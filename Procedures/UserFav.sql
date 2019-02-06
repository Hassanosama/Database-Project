
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE UserFav @username varchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	
	select I.Name,I.Type,I.Poster,I.ID 
	from Item as I where I.ID in 
	(select Favorites.ID_Item from Favorites where Favorites.ID_Users = (select U.ID from Users as U where @username = U.Users_name));
    
END
GO
