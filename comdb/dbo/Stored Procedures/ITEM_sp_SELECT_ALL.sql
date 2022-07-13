-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[ITEM_sp_SELECT_ALL]
	-- Add the parameters for the stored procedure here
	@isAct tinyint
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	--SELECT * FROM VItem WHERE ISACTIVE >=@isAct;
		SELECT a.ITEMNAME, a.DESCRIPTION, a.ITEMTYPE, a.ISACTIVE, a.UOMNAME, a.UOM,
	IIF(a.ITEMTYPE='BillOfQuantity',(SELECT SUM(b.SUBCOST) FROM VBoqItemLine b WHERE a.ID=b.BOQITEMID),a.COST) as COST, a.ISRATE, a.ID, a.EDSEQ, a.UOMID
	FROM VItem a WHERE a.ISACTIVE >=@isAct;
END
