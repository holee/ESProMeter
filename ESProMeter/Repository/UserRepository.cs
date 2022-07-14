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
                       .UseProcedure("USER_sp_SELECT")
                       .FindOne(new { UID = username, PWD = password }, out DataRow row))
            {
                return true;
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
                                password = user.Password,
                                isActive = user.IsActive,
                                isSysAdmin = user.IsSysAdmin,
                            }) > 0;
        }
    }
}
