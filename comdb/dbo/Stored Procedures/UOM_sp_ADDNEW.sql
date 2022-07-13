-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[UOM_sp_ADDNEW]
	-- Add the parameters for the stored procedure here
	@uom udt_UOM_New readonly
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT INTO TUOM(UOMNAME, ABBREVIATION,[TYPE])
	SELECT * FROM @uom;

	SELECT SCOPE_IDENTITY();
END
