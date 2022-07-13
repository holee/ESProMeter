-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SPECIFICTYPE_sp_SELECT]
	-- Add the parameters for the stored procedure here
	@Tof [varchar](50) NULL
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT * FROM TTYPE WHERE TYPEOF = @Tof and isSysType =0;
END
