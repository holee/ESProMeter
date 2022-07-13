-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[tempBOQLINEDETAILS_sp_INSERT] 
	-- Add the parameters for the stored procedure here
	@LineSeq int,
	@uID bigint,
	@udttempNewBOQLINEDetails udt_tempNewBOQLINEDetails readonly
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	UPDATE tempTBOQLINEDETAILS SET BOQLINELineSeq=BOQLINELineSeq +1 WHERE BOQLINELineSeq >=@lineSeq and UID=@uID;

	INSERT INTO tempTBOQLINEDETAILS
	SELECT * FROM @udttempNewBOQLINEDetails;
END
