using ESProMeter.IVews;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESProMeter.Models
{
    public class UserModel:IUser
    {
        public int Id
        {
            get;
            set;
        }
        public string UserId
        {
            get;
            set;
        } = string.Empty;
        public string Password
        {
            get;
            set;
        } = string.Empty;
        public int EditSequense
        {
            get;
            set;
        }
        public bool IsActive
        {
            get;
            set;
        } = true;
        public bool IsSysAdmin
        {
            get;
            set;
        }
        public DateTime CreatedTime
        {
            get;
            set;
        } = DateTime.UtcNow;
        public DateTime ModifiedTime
        {
            get;
            set;
        } = DateTime.UtcNow;
    }
}
