using ESProMeter.Extensions;
using ESProMeter.IVews;
using ESProMeter.Models;
using ESProMeter.Services;
using System.Data;
namespace ESProMeter.Repository
{
    public class UserRepository
    {
        public bool Authenticated(string username, string password)
        {
            if (DataUtility.GetInstance
                       .UseProcedure("USER_sp_LOGIN")
                       .FindOne(new { UID = username}, out DataRow row))
            {
                Properties.Settings.Default.curLoggedUID = row.GetValue<int>("ID");
                return SecurityService.Verify(password, row.GetValue<string>("PASSWORD"));
            }
            return false;
        }
        public bool Authenticated(string username, string password,bool remember)
        {
            if (DataUtility.GetInstance
                       .UseProcedure("USER_sp_LOGIN")
                       .FindOne<dynamic>(new { UID = username }, out DataRow row))
            {
                
                if(SecurityService.Verify(password, row.GetValue<string>("PASSWORD")))
                {
                    if (remember)
                    {
                        Properties.Settings.Default.userLoginUserName = row.GetValue<string>("UERID");
                        Properties.Settings.Default.userLoginPassword = row.GetValue<string>("PASSWORD");
                    }
                    return true;
                }
            }
            return false;
        }
        public bool Authenticated(LoginModel model)
        {
            if (DataUtility.GetInstance
                       .UseProcedure("USER_sp_LOGIN")
                       .FindOne(new { 
                           UID = model.UserName
                       }, out DataRow row))
            {
                
                if(SecurityService.Verify(model.Password, row.GetValue<string>("PASSWORD")))
                {
                    if (model.RememberMe)
                    {
                        Properties.Settings.Default.userLoginUserName = row.GetValue<string>("UERID");
                        Properties.Settings.Default.userLoginPassword = row.GetValue<string>("PASSWORD");
                    }
                    return true;
                }
            }
            return false;
        }
        public bool Register(IUser user)
        {       
            return AppService.SqlGetInstance
            //return DataUtility.GetInstance
                            .UseProcedure("USER_sp_Register")
                            .InsertOrUpdate<dynamic>(new
                            {
                                username = user.UserId,
                                password =SecurityService.TextEncrypt(user.Password),
                                isActive = user.IsActive,
                                NameRefId=0,
                                isSysAdmin = user.IsSysAdmin,
                            }) > 0;
        }

        //public bool Delete(int uid)
        //{
        //    //return AppService.SqlGetInstance
        //    //    .UseProcedure()
        //    //    .Delete<dynamic>(new
        //    //    {

        //    //    }
        //}

        public bool ChangePassword(IChangePassword pwd)
        {
            return AppService.SqlGetInstance
                .UseProcedure("USERPASSWORD_sp_UPDATE")
                .InsertOrUpdate(new
                {
                    username = Properties.Settings.Default.ULOGID,
                    oldPassword = SecurityService.TextEncrypt(pwd.oldPassword),
                    newPassword = SecurityService.TextEncrypt(pwd.newPassword)
                }) >0;
        }

        public bool GetAllUserList(byte includeInactive, out DataTable table)
        {
            return AppService.SqlGetInstance
                .UseProcedure("USERLIST_sp_SELECT")
                .SelectAsTable<dynamic>(new
                {
                    @isAct = includeInactive
                }, out table);
        }

        public bool userLoggedIn(int uID)
        {
            return AppService.SqlGetInstance
                .UseProcedure("USERLOGIN_sp_INSERT")
                .InsertOrUpdate(new { UID = uID })>0;
        }

        public bool userLoggedStateChange(int uID, byte logState)
        {
            return AppService.SqlGetInstance
                .UseProcedure("USERLOGIN_sp_UPDATE")
                .InsertOrUpdate(new { UID = uID,
                logout = logState}) > 0;
        }




        //private funciton

        private void Write(string a)
        {
            
        }




    }
}
