using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESProMeter.Extensions
{
    public static class Utility
    {
        public static string NumberString(object value=null, string formatter = "N5")
        {
            return string.Format($"{{0:{formatter}}}",value);
        }
        public static T RemoveThousand<T>(object value) where T : struct,IConvertible
        {
            if(value== null)
            {
                return default(T);
            }
            return ((T)Convert.ChangeType(value, typeof(T)));    
        }
    }
}
