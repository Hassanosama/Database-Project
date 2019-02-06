SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE GetShows 
         @Cname varchar(50)

AS
BEGIN

          Select Name
          from Item
          where Item.ID IN (Select ID_Movie 
                            from Show 
                            where Show.ID_Cinema = (select ID
                                                    from Cinemas
                                                    where Cinemas.Name = @Cname
                                                    )
                            );

END
GO
