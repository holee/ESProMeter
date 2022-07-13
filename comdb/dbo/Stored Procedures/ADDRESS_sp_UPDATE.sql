-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[ADDRESS_sp_UPDATE] 
	-- Add the parameters for the stored procedure here
	@ID int,
	@Address nvarchar(500) NULL,
	@Prov nvarchar(50) NULL,
	@Cntry nvarchar(50) NULL

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	UPDATE TADDRESSINFO SET
	ADDRESS=@Address,
	PROVINCE=@Prov,
	COUNTRY =@Cntry

	WHERE ID=@ID
END
