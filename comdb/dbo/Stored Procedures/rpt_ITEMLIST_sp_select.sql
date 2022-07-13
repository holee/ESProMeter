-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[rpt_ITEMLIST_sp_select] 
	-- Add the parameters for the stored procedure here
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT a.ITEMNAME, a.DESCRIPTION, a.ITEMTYPE, (select b.ABBREVIATION from TUOM b where a.UOMID=b.ID) as UOM, 
	IIF(a.ITEMTYPE='BillOfQuantity',coalesce((select sum(b.SUBCOST) FROM VBOQITEMLINE b WHERE b.BOQITEMID = a.ID),0),a.COST) as COST
	FROM TITEM a
	ORDER BY a.ITEMTYPE DESC
END
