using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESProMeter.Extensions
{
    public static class DataTableExtension
    {
        public static void AddExtraValue<T>(this DataTable table,int insertRow,string colName,T value)
        {
            table.Columns.Add(colName,typeof(T));
            table.Rows[insertRow][colName] = value;
        }
       
    }
}
