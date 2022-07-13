-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE Company_sp_CREATE 
	-- Add the parameters for the stored procedure here
	@CompanyName [nvarchar](50) NULL,
	@LegalCompanyName [nvarchar](50)  NULL,
	@AltLegalCompanyName [nvarchar](50)  NULL,
	@ContAddrId [int] NULL,
	@AltAddrID [int] NULL,
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
	INSERT INTO TCOMPANYINFO(
	COMPANYNAME,
	LEGALCOMPANYNAME,
	ALTLEGALCOMPANYNAME,
	CONTADDRESSID,
	LEGALADDRESSID,
	MAINPHONE,
	ALTPHONE,
	FAX,
	EMAIL,
	WEBSITE,
	LOGOFILEPATH
	)
	VALUES(
	@CompanyName,
	@LegalCompanyName,
	@AltLegalCompanyName,
	@ContAddrId,
	@AltAddrID,
	@MainPhone,
	@AltPhone,
	@Fax,
	@Email,
	@WebSite,
	@LogoFilePath
	);
END
