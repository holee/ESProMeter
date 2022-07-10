//using ESProMeter.Services;
//using ESProMeter.Extensions;
//using System;
//using System.Data;
//using System.Data.SqlClient;
//using System.Linq;
//using System.Windows.Forms;

//namespace ESProMeter.Controllers
//{
//    public static class CompanyController
//    {
//        public static void UpdateCompany(this Form form)
//        {
//			var CompanyName= form.AsTextBox("CompanyName").Text;
//			var LegalCompanyName = form.AsTextBox("LegalCompanyName").Text;
//			var AltLegalCompanyName= form.AsTextBox("AltLegalCompanyName").Text;
//			var Address = form.AsTextBox("Address").Text;
//			var Country = form.AsTextBox("Country").Text;
//			var Province = form.AsTextBox("Province").Text;
//			var MainPhone = form.AsTextBox("MainPhone").Text;
//			var AltPhone = form.AsTextBox("AltPhone").Text;
//			var Fax = form.AsTextBox("AltPhone").Text;
//			var Email = form.AsTextBox("Email").Text;
//			var WebSite = form.AsTextBox("WebSite").Text;
//			//==================================================================================
//			var LegalAddress = form.AsTextBox("LegalAddress").Text;
//			var LegalCountry = form.AsTextBox("LegalCountry").Text;
//			var LegalProvince = form.AsTextBox("LegalProvince").Text;

//			//var ContAddressRefId = ((TextBox)form.Controls.Find("textbox1", true).First()).Text;
//			var LogoFilePath = form.AsTextBox("LegalProvince").Text;
//			SqlConnection connection = (SqlConnection)ConnectionService.Connection;
//			SqlTransaction transaction = connection.BeginTransaction();
//			try
//            {
//				if(!CompanyService.CompanyExist(connection,out int row,transaction))
//                {
//					var ContAddressRefId = AddressService.CreateNewAddress(connection, LegalAddress, LegalProvince, LegalCountry, LegalProvince, transaction);
//					var AddrRefID = AddressService.CreateNewAddress(connection, Address, Province, Country, Province, transaction);
//					CompanyService.CreateCompanyInformation(connection, CompanyName, LegalCompanyName, AltLegalCompanyName,
//															AddrRefID,ContAddressRefId,MainPhone, AltPhone, Fax, Email, WebSite, LogoFilePath, transaction);
//				}
//                else
//                {
//					var ContAddressRefId =Convert.ToInt64(form.AsLabel("LegCompAddrID").Text);
//					var AddrRefID = Convert.ToInt64(form.AsLabel("AddrID").Text);
//					var comEdit = form.AsLabel("comEditSequese").AsNumber<int>();
//					var contEdit=form.AsLabel("legalEditSequense").AsNumber<int>();
//					AddressService.UpdateAddress(connection, AddrRefID,comEdit, Address, Province, Country, Province, transaction);
//					AddressService.UpdateAddress(connection, ContAddressRefId,contEdit, LegalAddress, Country, LegalCountry, LegalProvince, transaction);
//					CompanyService.UpdateCompanyInformation(connection, CompanyName, LegalCompanyName, AltLegalCompanyName,
//															MainPhone, AltPhone, Fax, Email, WebSite, LogoFilePath, transaction);
//				}
				
//				transaction.Commit();
				
//			}catch (Exception ex)
//            {
//				transaction.Rollback();
//				throw new Exception(ex.Message);
//            }
//		}

//		public static void ShowCompanyInformation(this Form form)
//        {
//			SqlConnection connection = (SqlConnection)ConnectionService.Connection;
//			if (CompanyService.GetCompanyInformation(connection,out DataTable data))
//            {
//					DataRow r = data.Rows[0];
//					form.AsTextBox("CompanyName").Text = r.Field<string>("CompanyName");
//					form.AsTextBox("LegalCompanyName").Text = r.Field<string>("LegalCompanyName");
//					form.AsTextBox("AltLegalCompanyName").Text = r.Field<string>("AltLegalCompanyName");
//					form.AsTextBox("Address").Text = r.Field<string>("Address");
//					form.AsTextBox("Country").Text = r.Field<string>("Country");
//					form.AsTextBox("AltPhone").Text = r.Field<string>("AltPhone");
//					form.AsTextBox("MainPhone").Text = r.Field<string>("MainPhone");
//					form.AsTextBox("Province").Text = r.Field<string>("Province");
//					form.AsTextBox("Email").Text = r.Field<string>("Email");
//					form.AsTextBox("WebSite").Text = r.Field<string>("WebSite");
//					form.AsTextBox("Fax").Text = r.Field<string>("Fax");
//					form.AsTextBox("LegalAddress").Text = r.Field<string>("LegalAddress");
//					form.AsTextBox("LegalCountry").Text = r.Field<string>("LegalCountry");
//					form.AsTextBox("LegalProvince").Text = r.Field<string>("LegalProvince");
//					form.AsTextBox("LegalProvince").Text = r.Field<string>("LegalCity");
//					form.AsLabel("LegCompAddrID").Text = r.Field<long>("ContAddressRefId").ToString();
//					form.AsLabel("AddrID").Text = r.Field<long>("AddrRefID").ToString();
//					form.AsLabel("comEditSequese").Text = r.Field<int>("comEditSequense").ToString();
//					form.AsLabel("legalEditSequense").Text = r.Field<int>("legalEditSequense").ToString();

//			}
//        }




//    }
//}
