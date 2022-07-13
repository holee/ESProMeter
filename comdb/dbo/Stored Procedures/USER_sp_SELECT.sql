-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE USER_sp_SELECT
	-- Add the parameters for the stored procedure here
	@UID varchar(50) NULL,
	@PWD varchar(50) NULL
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT * FROM TUSERS WHERE USERID = @UID and PASSWORD = @PWD and ISACTIVE=1;
END
