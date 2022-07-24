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
                                        .InsertGetId<long,dynamic>(
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

        public static void GetAllCustomers(this Form form,string gridName)
        {
           if(AppService.CustomerInstance.ShowCustomerCenter("Customer",1,out var table))
            {
                var constainer = form.AsControl<DataGridView>(gridName);
                constainer.DataSource = table;
                
            }
        }
        public static void FillCustomerCmb(this Form form)
        {
            if (AppService.CustomerInstance.ShowCustomerCenter("Customer", 1, out var table))
            {
                var constainer = form.AsControl<ComboBox>("textCustomerID");
                constainer.DataSource = table;
                constainer.DisplayMember = "Name";
                constainer.ValueMember = "ID";
            }
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

