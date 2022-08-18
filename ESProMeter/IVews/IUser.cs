using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESProMeter.IVews
{
    public interface IUser
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public string Password { get; set; }
        public int EditSequense { get; set; }
        public byte IsActive { get; set; }
        public byte IsSysAdmin { get; set; }
        public DateTime CreatedTime { get; set; }
        public DateTime ModifiedTime { get; set; }
    }
}
