using ESProMeter.Extensions;
using ESProMeter.Services;
using System;
using System.Windows.Forms;
using ESProMeter.Enums;
using ESProMeter.Views.Customers;
using ESProMeter.IVews;

namespace ESProMeter.Controllers
{
  
    public static class NameController
    {
        public static bool CustomerCreateOrUpdate(this Form form,CustomerCreateFrm customer,ActionType actionType)
        {
            try
            {
                bool success = false;
                switch (actionType)
                {
                    case ActionType.CREATE:
                        success= AppService.GetNameInstance.CustomerCreate(customer)>0;
                        break;
                    case ActionType.EDIT:
                        success=AppService.GetNameInstance.CustomerUpdate(customer)>0;
                        break;
                    case ActionType.DELETE:
                        break;
                    default:
                        break;
                }
                return success;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
        public static void ShowCustomerCenter(this Form form,byte isActive=1)
        {
            try
            {
               if(AppService.GetNameInstance.CustomersCenter("Customer", isActive, out var table))
                {
                    var container = form.AsDataGrid("gridCustomer");
                    container.DataSource = table;
                    for (int i = 2; i < container.Columns.Count; i++)
                    {
                        container.Columns[i].Visible = false;
                    }
                }
                
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
        public static bool DeleteCustomer(this Form form,long id,long addressID)
        {
            try
            {
                return AppService.GetNameInstance.CustomerDelete(id, addressID) >0;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            
        }
        public static void ShowCustomerById(this Form form,CustomerCreateFrm customer, long id)
        { 
            
            try
            {
                AppService.GetNameInstance.GetAllCustomerById(customer, id, 1);                                }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        public static void GetCustomerDetails(this Form form, CustomerDetailFrm customer, long id)
        {
            try
            {
                AppService.GetNameInstance.GetAllCustomerById(customer, id, 1);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

    }
}

//if(cust != null)
//{
//    customer.ID=cust.CustID;
//    customer.LASTNAME = cust.Name;
//    customer.FIRSTNAME = cust.FirstName;
//    customer.NAME = cust.LastName;
//    customer.CREDITLIMIT = cust.CreditLimit;
//    customer.EMAIL = cust.Email;
//    customer.FAX = cust.Fax;
//    customer.ALTPHONE = cust.AlternatePhone;
//    customer.MAINPHONE = cust.MainPhone;
//    customer.ADDRESS =cust.AddressInfo.Address;
//    customer.PROVINCE = cust.AddressInfo.Province;
//    customer.COUNTRY = cust.AddressInfo.Country;
//    customer.ADDRESSID= cust.AddressInfo.AddrID;
//    customer.EDSEQ = cust.EditSequense;
//    customer.SALUTATION = cust.Salutation;
//    customer.ISACTIVE = !cust.IsActive;
//    customer.JOBTITLE = cust.JobTitle;
//    customer.WEBSITE = cust.WebSite;
//}