using ESProMeter.IVews;
using System;
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
        public byte IsActive
        {
            get;
            set;
        } = 1;
        public byte IsSysAdmin
        {
            get;
            set;
        } =0;
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
