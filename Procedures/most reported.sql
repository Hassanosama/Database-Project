USE [HBO]
GO
/****** Object:  StoredProcedure [dbo].[most_reported_items]    Script Date: 12/20/2017 17:46:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



ALTER proc [dbo].[most_reported_items]
as
begin 
select ID_Item ,COUNT(*) as #Reports
from Reports 
group by ID_Item
order by COUNT(*) DESC
end