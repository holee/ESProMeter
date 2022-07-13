-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[BOQLINETemp_sp_DELETE]
	-- Add the parameters for the stored procedure here
	@boqId bigint,
	@boqItemId bigint,
	@lineSeq int,
	@uID bigint
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	
	DELETE FROM tempTBOQLINE WHERE BOQID=@boqId and BOQITEMID =@boqItemID and LineSeq =@LineSeq and UID = @uId;
	DELETE FROM tempTBOQLINEDETAILS WHERE BOQID=@boqID and BOQITEMID=@boqItemID and BOQLINELineSeq=@lineSeq and UID=@uId;

	UPDATE tempTBOQLINE SET lineSeq=LineSeq-1 WHERE BOQID = @boqId and LineSeq >@lineSeq and UID=@uId;
	Update tempTBOQLINEDETAILS SET BOQLINELineSeq=BOQLINELineSeq -1 WHERE BOQID = @boqId and BOQLINELineSeq >@lineSeq and UID=@uId;
END
