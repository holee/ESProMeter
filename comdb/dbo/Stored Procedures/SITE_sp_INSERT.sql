-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SITE_sp_INSERT]
	-- Add the parameters for the stored procedure here
	@udtNewSite udt_site_New readonly
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT INTO TSITE(SITENAME, DESCRIPTION, ADDRESSID, CUSTOMERID)
	SELECT * FROM @udtNewSite;
END
