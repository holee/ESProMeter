-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[ITEM_sp_INSERT]
	-- Add the parameters for the stored procedure here
	@udtItemNew udt_Item_New readonly
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT INTO TITEM(ITEMNAME, DESCRIPTION, ITEMTYPE,UOMID,COST,ISRATE)
	SELECT * FROM @udtItemNew;
	SELECT SCOPE_IDENTITY();
END
