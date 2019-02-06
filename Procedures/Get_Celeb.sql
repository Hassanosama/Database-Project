SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE Get_Celeb @t int
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	if(@t = 0) select Fname from Actors; --WILL BE CHANGED
	else if (@t = 1) select Fname from Director;  --WILL BE CHANGED
	else select Name from Singers;
    
END
GO
