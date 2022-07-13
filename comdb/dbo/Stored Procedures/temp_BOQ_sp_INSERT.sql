-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[temp_BOQ_sp_INSERT]
	-- Add the parameters for the stored procedure here
	@boqID bigint,
	@boqref nvarchar(50),
	@boqTitle nvarchar(50),
	@boqDesc nvarchar(500),
	@custID bigint,
	@boqDate date,
	@boqValidDate date,
	@siteID bigint,
	@terms nvarchar(Max),
	@uId bigint
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT INTO tempTBOQ(ID,REFNUMBER,BOQTITLE, BOQDESC, CUSTOMERID,BOQDATE, VALIDDATE,SITEID,TERMSCONDITION,UID) 
	VALUES(@boqID,@boqref,@boqTitle, @boqDesc, @custID, @boqDate, @boqValidDate, @siteID, @terms ,@uid);
	SELECT SCOPE_IDENTITY();
END
