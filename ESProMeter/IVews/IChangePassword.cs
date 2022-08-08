using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESProMeter.IVews
{
	public interface IChangePassword
	{
		string oldPassword { get; set; }
		string newPassword { get; set; }
		string confirmPassword { get; set; }
	}
}
