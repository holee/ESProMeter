using ESProMeter.Extensions;
using ESProMeter.IVews;
using ESProMeter.Services;
using System;
namespace ESProMeter.Repository
{
    public class CompanyRepository
    {
        public bool IsCompanyExist()
        {
            return AppService.SqlGetInstance
                         .UseProcedure("[VCompany]")
                             .Count<int, dynamic>(null) > 0;
        }
        public void UpdateCompany(ITCOMPANYINFO com)
        {

            try
            {
                AppService.SqlGetInstance.StartTransaction();
                if (IsCompanyExist())
                {
                    AppService.AddressGetInstance.AddressUpdate(new Models.TAddressInfo
                    {
                        ID=com.CONTADDRESSID,
                        COUNTRY=com.COUNTRY,
                        PROVINCE=com.PROVINCE,
                        ADDRESS=com.ADDRESS
                    });
                    //Update Comanpy
                    AppService.SqlGetInstance
                                .UseProcedure("Company_sp_UPDATE")
                                    .InsertOrUpdate<dynamic>(new
                                    {
                                        @ID=com.ID,
                                        @EDSEQ=com.EDSEQ,
                                        @CompanyName =com.COMPANYNAME,
                                        @LegalCompanyName=com.LEGALCOMPANYNAME,
                                        @AltLegalCompanyName=com.ALTLEGALCOMPANYNAME,
                                        @MainPhone=com.MAINPHONE,
                                        @AltPhone=com.ALTPHONE,
                                        @Fax=com.FAX,
                                        @Email=com.EMAIL,
                                        @WebSite=com.WEBSITE,
                                        @LogoFilePath=com.LOGOFILEPATH
                                    });
                }
                else
                {
                    //Create Address
                   var id=AppService.AddressGetInstance.AddressCreate(new Models.TAddressInfo
                    {
                        COUNTRY = com.COUNTRY,
                        PROVINCE = com.PROVINCE,
                        ADDRESS = com.ADDRESS
                    });
                    //create new company
                    AppService.SqlGetInstance
                                .UseProcedure("Company_sp_CREATE")
                                    .InsertOrUpdate<dynamic>(new
                                    {
                                        @CompanyName = com.COMPANYNAME,
                                        @LegalCompanyName = com.LEGALCOMPANYNAME,
                                        @AltLegalCompanyName = com.ALTLEGALCOMPANYNAME,
                                        @MainPhone = com.MAINPHONE,
                                        @AltPhone = com.ALTPHONE,
                                        @Fax = com.FAX,
                                        @Email = com.EMAIL,
                                        @WebSite = com.WEBSITE,
                                        @LogoFilePath = com.LOGOFILEPATH
                                    });
                }

                AppService.SqlGetInstance.ComitTransaction();
            }
            catch (Exception ex)
            {
                AppService.SqlGetInstance.RollbackTransaction();
                throw new Exception(ex.Message);
            }
        }

        public void ShowCompanyInformation(ITCOMPANYINFO com)
        {
            if (AppService.SqlGetInstance
                            .UseProcedure("[Company_sp_SELECT]")
                                .FindOne<dynamic>(null, out var row))
            {
                com.COMPANYNAME = row.GetValue<string>("CompanyName");
                com.LEGALCOMPANYNAME = row.GetValue<string>("LegalCompanyName");
                com.ALTLEGALCOMPANYNAME = row.GetValue<string>("AltLegalCompanyName");
                com.ADDRESS = row.GetValue<string>("Address");
                com.COUNTRY = row.GetValue<string>("Country");
                com.ALTPHONE = row.GetValue<string>("AltPhone");
                com.MAINPHONE = row.GetValue<string>("MainPhone");
                com.PROVINCE = row.GetValue<string>("Province");
                com.EMAIL = row.GetValue<string>("Email");
                com.WEBSITE = row.GetValue<string>("WebSite");
                com.FAX = row.GetValue<string>("FAX");
                com.CDT = row.GetValue<DateTime>("CDT"); ;
                com.MDT = row.GetValue<DateTime>("MDT");
                com.CONTADDRESSID = row.GetValue<int>("CONTADDRESSID");
                com.LEGALADDRESSID = row.GetValue<int>("LEGALADDRESSID");
                com.ID = row.GetValue<int>("ID");
                com.EDSEQ = row.GetValue<int>("EDSEQ");
            }
        }


    }
}

