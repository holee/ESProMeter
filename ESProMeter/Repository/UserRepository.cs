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
                return DataUtility.GetInstance
                            .UseProcedure("USER_sp_Register")
                            .InsertOrUpdate<dynamic>(new
                            {
                                username = user.UserId,
                                password =SecurityService.TextEncrypt(user.Password),
                                isActive = user.IsActive,
                                isSysAdmin = user.IsSysAdmin,
                            }) > 0;
        }











        //private funciton

        private void Write(string a)
        {
            
        }




    }
}
