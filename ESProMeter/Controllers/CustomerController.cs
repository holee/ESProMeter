using ESProMeter.Extensions;
using ESProMeter.Services;
using ESProMeter.IViews;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Linq;
using ESProMeter.DataAccess;
using ESProMeter.Models;

namespace ESProMeter.Controllers
{
  
    public static class CustomerController
    {
        private static readonly SqlAccess instance = DataUtility.GetInstance;
        public static bool CreateOrUpdateCustomer(this Form form,ICustomer customer)
        {
            try
            {
                if (customer.CustID == 0 && customer.AddressRefId==0)
                {
                    return CreateNewCustomer(customer);
                }
                else
                {
                    return UpdateCustomer(customer);
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        private static bool CreateNewCustomer(ICustomer c)
        {
            try
            {
                instance.StartTransaction();
                var createdAddress = instance.UseProcedure("AddressCreate")
                                        .InserGetId<long,dynamic>(
                                        new { 
                                            c.Address,
                                            c.City,
                                            c.Province,
                                            c.Country
                                        });
                instance.UseProcedure("CustomerCreateNew")
                    .InsertOrUpdate<dynamic>(new {
                        Name=c.CustomerName,
                        Salutation=c.Salutation,
                        FirstName=c.FirstName,
                        MiddleName=c.MiddleName,
                        LastName=c.LastName,
                        JobTitle=c.JobTitle,
                        AddrRefID=createdAddress,
                        MainPhone=c.MainPhone,
                        AltPhone=c.AltPhone,
                        Fax=c.Fax,
                        Email=c.Email,
                        Website=c.WebSite,
                        CreditLimit=c.CreditLimit
                    });
                instance.ComitTransaction();
                return true;
            }
            catch
            {
                instance.RollbackTransaction();
                return false;
            }

        }

        private static bool UpdateCustomer(ICustomer c) 
        {
            try
            {
                instance.StartTransaction();
                instance.UseProcedure("AddressUpdate")
                                        .InsertOrUpdate<dynamic>(
                                        new
                                        {
                                            c.AddrID,
                                            c.Address,
                                            c.City,
                                            c.Province,
                                            c.Country,
                                            EditSequense = c.AddressEditSequense
                                        });
                instance.UseProcedure("CustomerUpdate")
                    .InsertOrUpdate<dynamic>(new
                    {
                        c.CustID,
                        Name = c.CustomerName,
                        c.Salutation,
                        c.FirstName,
                        c.MiddleName,
                        c.LastName,
                        c.JobTitle,
                        c.MainPhone,
                        c.AltPhone,
                        c.Fax,
                        c.Email,
                        c.WebSite,
                        c.CreditLimit,
                        c.EditSequense
                    });
                instance.ComitTransaction();
                return true;
            }
            catch
            {
                instance.RollbackTransaction();
                return false;
            }

        }
        public static void ShowCustomerCenter(this Form form,string name)
        {
            try
            {
                var query= instance.UseProcedure("CustomerSelectAll")
                                   .FindAsTable<dynamic>(new { Name=name });
                form.AsDataGrid("gridCustomer").DataSource = query;
            }
            catch
            {
                throw;
            }
        }

        public static bool GetAllCustomers(out DataTable table,params string[] columns)
        {
            string sql = columns.Length == 0 ? "*" : string.Join(",", columns);
            var sql1 = $"SELECT {sql} FROM [dbo].[Customer];";
            table = instance.UseSql(sql1).FindAsTable<dynamic>(null);
            if (table.Rows.Count == 0)
            {
                return false;
            }
            return true;
        }
        public static bool DeleteCustomer(this Form form,long id)
        {
            try
            {
                return instance.UseProcedure("CustomerDelete")
                        .Delete<dynamic>(new { CustID = id })>0;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            
        }
        public static void ShowCustomer(this Form form, ICustomer customer, long id)
        {
            
            try
            {
                var cust =instance.UseProcedure("CustomerSelectForUpdate")
                                   .Select<Customer,AddressInfo,Customer,dynamic>((c,a)=>{
                                       c.AddressInfo =a;
                                       return c;
                                    },new { CustID=id }, "AddrID").FirstOrDefault();                    
                                  
                if(cust != null)
                {
                    customer.CustID=cust.CustID;
                    customer.CustomerName = cust.Name;
                    customer.FirstName = cust.FirstName;
                    customer.LastName = cust.LastName;
                    customer.CreditLimit = cust.CreditLimit;
                    customer.Email = cust.Email;
                    customer.Fax = cust.Fax;
                    customer.AltPhone = cust.AlternatePhone;
                    customer.MainPhone = cust.MainPhone;
                    customer.Address =cust.AddressInfo.Address;
                    customer.City = cust.AddressInfo.City;
                    customer.Province = cust.AddressInfo.Province;
                    customer.Country = cust.AddressInfo.Country;
                    customer.AddrID= cust.AddressInfo.AddrID;
                    customer.AddressEditSequense = cust.AddressInfo.AddressEditSequense;
                    customer.EditSequense = cust.EditSequense;
                    customer.Salutation = cust.Salutation;
                    customer.CustID = cust.CustID;
                    customer.IsActive = !cust.IsActive;
                    customer.JobTitle = cust.JobTitle;
                    customer.WebSite = cust.WebSite;
                }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}


//try
//{
//    if (CustomerService.GetInstance
//                       .UseProcedure("CustomerSelectForUpdate")
//                       .Find<dynamic>(new { CustID = id }, out DataRow row))
//    {
//        form.AsTextBox("textName").Text = row.Field<string>("Name");
//        form.AsTextBox("textLastName").Text = row.Field<string>("LastName");
//        form.AsTextBox("textSalutation").Text = row.Field<string>("Salutation");
//        form.AsTextBox("textAddress").Text = row.Field<string>("Address");
//        form.AsTextBox("textCountry").Text = row.Field<string>("Country");
//        form.AsTextBox("textProvince").Text = row.Field<string>("Province");
//        form.AsTextBox("textMainPhone").Text = row.Field<string>("MainPhone");
//        form.AsTextBox("textAltPhone").Text = row.Field<string>("AltPhone");
//        form.AsTextBox("textFax").Text = row.Field<string>("Fax");
//        form.AsTextBox("textEmail").Text = row.Field<string>("Email");
//        form.AsTextBox("textWebsite").Text = row.Field<string>("Website");
//        form.AsTextBox("textFirstName").Text = row.Field<string>("FirstName");
//        form.AsTextBox("textMiddleName").Text = row.Field<string>("MiddleName");
//        form.AsTextBox("textJobTitle").Text = row.Field<string>("JobTitle");
//        form.AsTextBox("textCreditLimit").Text = row.Field<decimal>("CreditLimit").ToString();
//        form.AsLabel("CustEditSequense").Text = row.Field<int>("EditSequense").ToString();
//        form.AsLabel("lblAddrID").Text = row.Field<long>("AddrrefId").ToString();
//        form.AsLabel("lblCustID").Text = row.Field<long>("CustID").ToString();
//        form.AsLabel("AddrEditSequense").Text = row.Field<int>("AddrEditSequense").ToString();
//    }

//}
//catch (Exception ex)
//{
//    MessageBox.Show(ex.Message);
//}