-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[NAME_sp_SELECT]
	-- Add the parameters for the stored procedure here
	@nameType nvarchar(50),
	@isAct tinyint
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT * FROM VNAME WHERE NAMETYPE=@nameType and ISACTIVE>=@isAct;
END
