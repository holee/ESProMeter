-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[BOQDATA_sp_DELETE_Temp]
	-- Add the parameters for the stored procedure here
	@UID bigint
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	DELETE FROM tempTBOQ WHERE UID=@UID;

	DELETE FROM tempTBOQLINE WHERE UID=@UID;

	DELETE FROM tempTBOQLINEDETAILS WHERE UID=@UID;
END
