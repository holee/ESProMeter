-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[UOM_sp_UPDATE]
	-- Add the parameters for the stored procedure here
	@uomID bigint,
	@uomEdSeq int,
	@uomName varchar(50),
	@uomAbb varchar(5),
	@uomIsAct tinyint
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	UPDATE TUOM SET 
	EDSEQ=@uomEdSeq+1, 
	MDT=GETDATE(),
	UOMNAME=@uomName, 
	ABBREVIATION=@uomAbb, 
	[ISACTIVE]=@uomIsAct
	WHERE ID=@uomID;
END
