SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE Get_Reports 
AS
BEGIN
	SET NOCOUNT ON;
	select Users_name,Name,Comment 
	from Users as U,Item as I,Reports as R where R.ID_Users = U.ID and R.ID_Item = I.ID;
    
END
GO
