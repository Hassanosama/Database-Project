
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE Login @username varchar(50),@password varchar(50)

AS
BEGIN
	
	SET NOCOUNT ON;

    SELECT privilege from Users where Users_name = @username and Password = @password; 
END
GO
