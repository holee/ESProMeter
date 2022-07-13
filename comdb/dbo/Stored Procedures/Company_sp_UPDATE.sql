-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE Company_sp_UPDATE
	-- Add the parameters for the stored procedure here
	@CompanyName [nvarchar](50) NULL,
	@LegalCompanyName [nvarchar](50)  NULL,
	@AltLegalCompanyName [nvarchar](50)  NULL,
	@MainPhone [varchar](50) NULL,
	@AltPhone [varchar](50) NULL,
	@Fax [varchar](50) NULL,
	@Email [varchar](max) NULL,
	@WebSite [varchar](max) NULL,
	@LogoFilePath [varchar](max) NULL
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	UPDATE TCOMPANYINFO
	SET
		MDT = getdate(),
		EDSEQ = EDSEQ +1,
		COMPANYNAME =@CompanyName,
		LEGALCOMPANYNAME = @LegalCompanyName,
		ALTLEGALCOMPANYNAME = @AltLegalCompanyName,
		MAINPHONE =@MainPhone,
		ALTPHONE = @AltPhone,
		FAX = @Fax,
		EMAIL = @Email,
		WEBSITE = @WebSite,
		LOGOFILEPATH = @LogoFilePath
END
