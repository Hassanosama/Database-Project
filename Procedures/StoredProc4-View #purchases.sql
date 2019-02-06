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

CREATE PROCEDURE TotalPurchases
	-- Add the parameters for the stored procedure here
	--@type int,	
	@UploaderID int,

	@Total int OUTPUT	-- Returns the value in this variable.

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	
	Select @Total = SUM(#Purchase)
				from Item
				where Uploader_ID = @UploaderID


END
GO

--***************************************************************************************

CREATE PROCEDURE ItemPurchases
	-- Add the parameters for the stored procedure here
	--@type int,	
	@ItemID int,

	@ItemPurchases int OUTPUT	-- Returns the value in this variable.

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	
	Select @ItemPurchases = SUM(#Purchase)
				from Item
				where ID = @ItemID


END
GO
