-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[temp_BOQLINE_sp_INSERT]
	-- Add the parameters for the stored procedure here
	@lineSeq int,
	@uId bigint,
	@boqLineData udt_tempNewBOQLINE readonly
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	UPDATE tempTBOQLINE SET LineSeq=LineSeq +1 WHERE LineSeq >=@lineSeq and UID=@uId;
	INSERT INTO tempTBOQLINE
	SELECT * FROM @boqLineData;
END
