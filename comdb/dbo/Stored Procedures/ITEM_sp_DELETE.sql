-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE ITEM_sp_DELETE 
	-- Add the parameters for the stored procedure here
	@itemID bigint
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	DELETE FROM TITEM WHERE ID=@itemID;
	DELETE FROM TBOQITEMLINE WHERE BOQITEMID=@itemID;
END
