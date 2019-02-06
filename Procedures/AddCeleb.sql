SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE Add_Celeb @t int,@name varchar(50),@age int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    if(@t = 0) insert into Actors(Fname,Age) values (@name,@age);
    else if (@t = 1) insert into Director(Fname,Age) values (@name,@age);
    else insert into Singers(Name,Age) values (@name,@age);
END
GO
