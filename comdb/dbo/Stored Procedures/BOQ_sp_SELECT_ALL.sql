-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[BOQ_sp_SELECT_ALL]
	-- Add the parameters for the stored procedure here
	@isAct tinyint,
	@Status int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT * FROM VBOQ WHERE ISACTIVE >= @isAct AND STATUS >= @status;
END
