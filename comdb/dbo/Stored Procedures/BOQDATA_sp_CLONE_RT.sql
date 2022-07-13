-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[BOQDATA_sp_CLONE_RT]
	-- Add the parameters for the stored procedure here
	@BOQID bigint,
	@UID bigint
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT INTO tempTBOQ
	SELECT * FROM TBOQ WHERE ID=@BOQID;

	INSERT INTO tempTBOQLINE
	SELECT * FROM TBOQLINE WHERE BOQID = @BOQID;

	INSERT INTO tempTBOQLINEDETAILS
	SELECT * FROM TBOQLINEDETAILS WHERE BOQID = @BOQID;

	UPDATE tempTBOQ SET UID=@UID WHERE ID=@BOQID;

	UPDATE tempTBOQLINE SET UID=@UID WHERE BOQID=@BOQID;

	UPDATE tempTBOQLINEDETAILS SET UID=@UID WHERE BOQID=@BOQID;
END
