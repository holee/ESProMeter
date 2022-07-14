using ESProMeter.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESProMeter.Services
{
    public class UserService
    {
        private static UserRepository? userRepository=null;

        public static UserRepository GetUserInstance
        {
            get
            {
                if(userRepository == null)
                {
                    userRepository = new UserRepository();
                }

                return userRepository;
            }
        }

    }
}
