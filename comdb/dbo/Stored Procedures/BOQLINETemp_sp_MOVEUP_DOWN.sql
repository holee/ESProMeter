-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[BOQLINETemp_sp_MOVEUP_DOWN]
	-- Add the parameters for the stored procedure here
	@boqId bigint,
	@boqItemId bigint,
	@lineSeq int,
	@moveStep int,
	@uID bigint
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	UPDATE tempTBOQLINE SET LineSeq=LineSeq - @moveStep WHERE BOQID=@boqId and LineSeq = @LineSeq+@moveStep and UID=@uId;
	UPDATE tempTBOQLINEDETAILS set BOQLINELineSeq = BOQLINELineSeq - @moveStep WHERE BOQID=@boqId and BOQLINELineSeq =@lineSeq + @moveStep and UID=@uID;

	UPDATE tempTBOQLINE SET LineSeq=LineSeq + @moveStep WHERE BOQID=@boqId and BOQITEMID =@boqItemId and LineSeq = @LineSeq and UID=@uId;
	UPDATE tempTBOQLINEDETAILS SET BOQLINELineSeq = BOQLINELineSeq + @moveStep WHERE BOQID=@boqId and BOQITEMID =@boqItemId and BOQLINELineSeq = @LineSeq and UID=@uId;
END
