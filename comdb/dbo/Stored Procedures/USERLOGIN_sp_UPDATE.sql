-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[USERLOGIN_sp_UPDATE] 
	-- Add the parameters for the stored procedure here
	@logout tinyint,
	@UID bigint
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	UPDATE TULOG SET LastTime =GETDATE(), logout =@logout
	WHERE UID=@UID and logout=0;
END
