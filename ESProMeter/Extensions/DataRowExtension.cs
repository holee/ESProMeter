using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace ESProMeter.Extensions
{
    public static class DataRowExtension
    {
        public static bool Exist(this DataRow source,int index,object value)
        {

            if(source?.ItemArray?.Length>0)
            {
                if (source[index].Equals(value))
                    return true;
            }

            return false;
        }
        public static bool Any(this DataTable source, int index, object value)
        {
            bool result = false;
            if (source.Rows.Count > 0)
            {
                foreach (DataRow row in source.Rows)
                {
                    if (row[index].Equals(value))
                    {
                        result=true;
                        break;
                    }
                }    
            }
            return result;
        }
        public static bool Any<T>(this DataTable source, int index, object value)
        {
            var result = source.AsEnumerable().Where(x=>x.Field<T>(index).Equals(value)).ToList();  
            return result.Count>0;
        }
        public static (List<DataRow> result,bool exist) HasAny<T>(this DataTable source, int index, object value)
        {
            var result = source.AsEnumerable().Where(x => x.Field<T>(index).Equals(value)).ToList();
            return (result,result.Count>0);
        }
        public static (List<DataRow> result, bool exist) NotAny<T>(this DataTable source, int index, object value)
        {
            var result = source.AsEnumerable().Where(x => !x.Field<T>(index).Equals(value)).ToList();
            return (result, result.Count > 0);
        }


        public static T GetValue<T>(this DataRow row, string colName)
        {
            if (!row.IsNull(colName))
                return ChangeType<T>(row[colName]);
            else
                return default(T);
        }


        public static void AsCombox(this DataTable table,ComboBox combo,string valueMember,string displayMember)
        {
            if (((DataTable)combo.DataSource).Rows.Count > 0)
            {
                ((DataTable)combo.DataSource).Rows.Clear();
            }
            combo.DataSource = table;
            combo.DisplayMember = displayMember;
            combo.ValueMember = valueMember;
        }


        public static T GetValue<T>(this DataRow row, int colIndex)
        {
            if (!row.IsNull(colIndex))
                return ChangeType<T>(row[colIndex]);
            else
                return default(T);
        }
        private static T ChangeType<T>(object value)
        {
            if (value == null)
                return default(T);
            else
            {
                return (T)Convert.ChangeType(value, typeof(T));
            }
        }
    }
}
