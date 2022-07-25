using ESProMeter.Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESProMeter.Repository
{
    public class CustomerRepository
    {

        public  bool ShowCustomerCenter(string name,byte isActive,out DataTable table)
        {
            try
            {
                return AppService.SqlGetInstance
                                     .UseProcedure("NAME_sp_SELECT")
                                     .FindAsTable<dynamic>(new
                                     {
                                         @NAMETYPE=name,
                                         @ISACTIVE=isActive
                                     }, out table);
            }
            catch
            {
                throw;
            }
        }



    }
}
