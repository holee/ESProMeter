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
                         .UseProcedure("[COMPANY_sp_EXIST]")
                             .Count<int, dynamic>(null) > 0;
        }
        public void UpdateCompany(ITCOMPANYINFO com)
        {

            try
            {
                AppService.SqlGetInstance.StartTransaction();
                if (IsCompanyExist())
                {
                    if (com.CONTADDRESSID == 0)
                    {
                      com.CONTADDRESSID=AppService.AddressGetInstance.AddressCreate(new Models.TAddressInfo
                        {
                            COUNTRY = com.COUNTRY,
                            PROVINCE = com.PROVINCE,
                            ADDRESS = com.ADDRESS
                        });
                    }
                    else
                    {
                        AppService.AddressGetInstance.AddressUpdate(new Models.TAddressInfo
                        {
                            ID = com.CONTADDRESSID,
                            COUNTRY = com.COUNTRY,
                            PROVINCE = com.PROVINCE,
                            ADDRESS = com.ADDRESS
                        });

                    }
                    if (com.LEGALADDRESSID == 0)
                    {
                      com.LEGALADDRESSID= AppService.AddressGetInstance.AddressCreate(new Models.TAddressInfo
                        {
                            COUNTRY = com.COUNTRY,
                            PROVINCE = com.PROVINCE,
                            ADDRESS = com.ADDRESS
                        });
                    }
                    else
                    {
                        AppService.AddressGetInstance.AddressUpdate(new Models.TAddressInfo
                        {
                            ID = com.CONTADDRESSID,
                            COUNTRY = com.COUNTRY,
                            PROVINCE = com.PROVINCE,
                            ADDRESS = com.ADDRESS
                        });
                    }

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
                                        @LogoFilePath=com.LOGOFILEPATH,
                                        @LegalAddressId=com.LEGALADDRESSID,
                                        @ContactAddressId=com.CONTADDRESSID
                                    });
                }
                else
                {
                    //Create Address
                   var contactAddressId=AppService.AddressGetInstance.AddressCreate(new Models.TAddressInfo
                    {
                        COUNTRY = com.COUNTRY,
                        PROVINCE = com.PROVINCE,
                        ADDRESS = com.ADDRESS
                    });
                    var legalAddressId = AppService.AddressGetInstance.AddressCreate(new Models.TAddressInfo
                    {
                        COUNTRY = com.LEGALCOUNTRY,
                        PROVINCE = com.LEGALPROVINCE,
                        ADDRESS = com.LEGALCOUNTRY

                    });
                    //create new company
                    com.LEGALADDRESSID = (int)legalAddressId;
                    com.CONTADDRESSID = (int)contactAddressId;
                    AppService.SqlGetInstance
                                .UseProcedure("Company_sp_CREATE")
                                    .InsertOrUpdate<dynamic>(new
                                    {
                                        com.COMPANYNAME,
                                        com.LEGALCOMPANYNAME,
                                        com.ALTLEGALCOMPANYNAME,
                                        com.MAINPHONE,
                                        com.ALTPHONE,
                                        com.FAX,
                                        com.EMAIL,
                                        com.WEBSITE,
                                        com.LOGOFILEPATH,
                                        com.LEGALADDRESSID,
                                        com.CONTADDRESSID
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
                            .UseProcedure("[CompanyWithAddress_sp_SELECT]")
                                .FindOne<dynamic>(null, out var row))
            {
                com.COMPANYNAME = row.GetValue<string>("CompanyName");
                com.LEGALCOMPANYNAME = row.GetValue<string>("LegalCompanyName");
                com.ALTLEGALCOMPANYNAME = row.GetValue<string>("AltLegalCompanyName");
                com.ADDRESS = row.GetValue<string>("ContactAddress");
                com.COUNTRY = row.GetValue<string>("ContactCountry");
                com.ALTPHONE = row.GetValue<string>("AltPhone");
                com.MAINPHONE = row.GetValue<string>("MainPhone");
                com.PROVINCE = row.GetValue<string>("ContactProvince");
                com.EMAIL = row.GetValue<string>("Email");
                com.WEBSITE = row.GetValue<string>("WebSite");
                com.FAX = row.GetValue<string>("FAX");
                com.CDT = row.GetValue<DateTime>("CDT"); ;
                com.MDT = row.GetValue<DateTime>("MDT");
                com.CONTADDRESSID = row.GetValue<int>("CONTADDRESSID");
                com.LEGALADDRESSID = row.GetValue<int>("LEGALADDRESSID");
                com.LEGALCOUNTRY = row.GetValue<string>("LegalCountry");
                com.LEGALPROVINCE = row.GetValue<string>("LegalProvince");
                com.LEGALADDRESS = row.GetValue<string>("LegalAddress");
                com.ID = row.GetValue<int>("ID");
                com.EDSEQ = row.GetValue<int>("EDSEQ");
            }
        }

        public (string cn,string lcn) ShowCompanyInformation()
        {
            if (AppService.SqlGetInstance
                            .UseProcedure("[CompanyWithAddress_sp_SELECT]")
                                .FindOne<dynamic>(null, out var row))
            {
                var cn = row.GetValue<string>("CompanyName");
                var lcn = row.GetValue<string>("LegalCompanyName");
                return (cn, lcn);
            }
            return(null, null);
        }
        
        public bool CreateCompanyFileBackup(string dbName, string fileName)
        {
            return AppService.SqlGetInstance
                .UseProcedure("COMPANYFILE_sp_BACKUP")
                .InsertOrUpdate<dynamic>(new
                {
                    @dbName = dbName,
                    @fileName = fileName
                }) > 0;

        }

        public bool RestoreCompanyFile(string dbName, string fileName)
        {
            return AppService.SqlGetInstance
                .UseProcedure("COMPANYFILE_sp_RESTORE")
                .InsertOrUpdate<dynamic>(new
                {
                    @dbName = dbName,
                    @fileName = fileName
                }) > 0;
        }
    }
}

