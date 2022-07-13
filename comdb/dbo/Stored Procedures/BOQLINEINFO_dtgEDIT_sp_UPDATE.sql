-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE BOQLINEINFO_dtgEDIT_sp_UPDATE
	-- Add the parameters for the stored procedure here
	@boqId bigint,
	@boqItemId bigint,
	@lineSeq int,
	@uId bigint,
	@no nvarchar(50),
	@boqDesc nvarchar(500),
	@boqRemark nvarchar(max)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	UPDATE tempTBOQLINE SET [NO]= @no, BOQITEMDESC=@boqDesc, REMARKS=@boqRemark
	WHERE BOQID=@boqId and BOQITEMID=@boqItemId and LineSeq=@lineSeq and UID=@uId;
END
