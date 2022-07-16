using ESProMeter.Extensions;
using ESProMeter.IVews;
using ESProMeter.Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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






    }
}
