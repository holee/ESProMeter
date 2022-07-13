-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[ITEMbyType_sp_SELECT]
	-- Add the parameters for the stored procedure here
	@isAct tinyint,
	@itemType nvarchar(50)

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT a.ITEMNAME, a.DESCRIPTION, a.ITEMTYPE, a.ISACTIVE, a.UOMNAME, a.UOM,
	IIF(a.ITEMTYPE='BillOfQuantity',(SELECT SUM(b.SUBCOST) FROM VBoqItemLine b WHERE a.ID=b.BOQITEMID),a.COST) as COST, a.ISRATE, a.ID, a.EDSEQ, a.UOMID
	FROM VItem a
	WHERE a.ISACTIVE >=@isAct and a.ITEMTYPE =@itemType;
END
