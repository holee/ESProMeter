-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SITE_sp_UPDATE] 
	-- Add the parameters for the stored procedure here
	@siteID bigint,
	@edSeq int,
	@siteName nvarchar(50),
	@siteDesc nvarchar(250),
	@addrID bigint,
	@custID bigint,
	@isAct tinyint
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	UPDATE TSITE SET
	EDSEQ=@edSeq +1,
	MDT =GETDATE(),
	SITENAME=@siteName,
	DESCRIPTION=@siteDesc,
	ADDRESSID=@addrID,
	CUSTOMERID=@custID,
	ISACTIVE=@isAct

	WHERE id=@siteID;
END
