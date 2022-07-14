﻿-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE BOQLINEQTY_sp_UPDATE
	-- Add the parameters for the stored procedure here
	@boqId bigint,
	@boqItemId bigint,
	@lineSeq int,
	@uId bigint,
	@qty decimal
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	UPDATE tempTBOQLINE SET BOQITEMQTY=@qty
	WHERE BOQID=@boqId and BOQITEMID=@boqItemId and LineSeq=@lineSeq and UID=@uId;

	UPDATE tempTBOQLINEDETAILS SET BOQITEMQTY=@qty
	WHERE BOQID=@boqId and BOQITEMID=@boqItemId and BOQLINELineSeq=@lineSeq and UID=@uId;
END