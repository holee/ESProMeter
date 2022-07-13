-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Division_sp_ADDNEW] 
	-- Add the parameters for the stored procedure here
	@udtParam udt_Division readonly
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT INTO TDIVISION (DIVNAME, DESCRIPTION,ISACTIVE)
	SELECT * FROM @udtParam;
END
