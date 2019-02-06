SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE BookShow 
       @username varchar(50),
       @cinemaname varchar(50),
       @moviename varchar(50)
       
AS
BEGIN
       
DECLARE @userid int
DECLARE @cinemaid int
       
       select @userid = ID
       from Users
       where Users.Users_name = @username;
       
       select @cinemaid = ID
       from Cinemas
       where Cinemas.Name = @cinemaname;
       
       insert into Book_Cinema(ID_Users,ID_Cinema,Movie_Name)
       values(@userid,@cinemaid,@moviename); 
  
END
GO
