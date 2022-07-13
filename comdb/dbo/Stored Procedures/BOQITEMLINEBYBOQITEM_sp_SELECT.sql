-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE BOQITEMLINEBYBOQITEM_sp_SELECT
	-- Add the parameters for the stored procedure here
	@boqItemID bigint
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT * FROM VBoqItemLine WHERE BOQITEMID = @boqItemID;
END
