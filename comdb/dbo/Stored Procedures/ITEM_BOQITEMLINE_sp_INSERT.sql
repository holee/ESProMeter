-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[ITEM_BOQITEMLINE_sp_INSERT]
	-- Add the parameters for the stored procedure here
	@udtBoqItemLineNew udt_BOQItemLine_New readonly
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT INTO TBOQITEMLINE(BOQITEMID, BOQITEMLINEID, BOQITEMLINESEQ, BOQITEMLINEUOMID, BOQITEMLINEQTY)
	SELECT * FROM @udtBoqItemLineNew
END
