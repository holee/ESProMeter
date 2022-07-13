-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[ADDRESS_sp_INSERT]
	-- Add the parameters for the stored procedure here
	@udtAddrNew udt_Address_New readonly
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT INTO TADDRESSINFO(ADDRESS,PROVINCE,COUNTRY)
	SELECT * FROM @udtAddrNew;

	SELECT SCOPE_IDENTITY();
END
