-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[EditingBOQLINE_sp_SELECT]
	-- Add the parameters for the stored procedure here
	@BOQID bigint,
	@uId bigint
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT a.NO, 
	a.ITEMNAME, 
	a.BOQITEMDESC, 
	a.BOQITEMQTY, 
	a.UOM, 
	a.REMARKS, 
	a.BOQID, 
	a.BOQITEMID, 
	a.BOQITEMUOMID, 
	a.LineSeq,
	coalesce((select sum(b.BOQITEMQTY * b.BOQITEMITEMLINEQTY * b.AMOUNT) FROM VBOQLINEDETAILS_temp b WHERE b.BOQID = a.BOQID and b.BOQITEMID = a.BOQITEMID and b.BOQLINELineSeq = a.LineSeq and (b.BOQITEMITEMLINETYPE ='Labour' or b.BOQITEMITEMLINETYPE ='Machinery' or b.BOQITEMITEMLINETYPE ='Material')),0) as estCost, 
	coalesce((select sum(b.BOQITEMQTY * b.BOQITEMITEMLINEQTY * b.AMOUNT) FROM tempTBOQLINEDETAILS b WHERE b.BOQID = a.BOQID and b.BOQITEMID = a.BOQITEMID and b.BOQLINELineSeq = a.LineSeq and  (b.BOQITEMITEMLINETYPE ='AdditionalCost' or b.BOQITEMITEMLINETYPE ='Margin' or b.BOQITEMITEMLINETYPE ='Inflation')),0) as AdditionalCost, 
	coalesce((select sum(b.BOQITEMQTY * b.BOQITEMITEMLINEQTY * b.AMOUNT) FROM VBOQLINEDETAILS_temp b WHERE b.BOQID = a.BOQID and b.BOQITEMID = a.BOQITEMID and b.BOQLINELineSeq = a.LineSeq and  (b.BOQITEMITEMLINETYPE ='Labour' or b.BOQITEMITEMLINETYPE ='Machinery' or b.BOQITEMITEMLINETYPE ='Material')),0)+
	coalesce((select sum(b.BOQITEMQTY * b.BOQITEMITEMLINEQTY * b.AMOUNT) FROM tempTBOQLINEDETAILS b WHERE b.BOQID = a.BOQID and b.BOQITEMID = a.BOQITEMID and b.BOQLINELineSeq = a.LineSeq and  (b.BOQITEMITEMLINETYPE ='AdditionalCost' or b.BOQITEMITEMLINETYPE ='Margin' or b.BOQITEMITEMLINETYPE ='Inflation')),0) as SalesPrice
	
	FROM VBOQLINE_temp a 
	WHERE a.BOQID=@BOQID and a.UID=@uId
	ORDER BY a.lineSeq;
END
