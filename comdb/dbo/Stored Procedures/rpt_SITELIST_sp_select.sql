-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE rpt_SITELIST_sp_select
	-- Add the parameters for the stored procedure here
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT a.SITENAME, a.DESCRIPTION, a.CUSTOMERNAME, a.ADDRESS, a.PROVINCE, a.COUNTRY FROM VSiteList a

END
