using System.Data;
using System.Windows.Forms;

namespace ESProMeter.Extensions
{
    public static class DataTableExtension
    {
        public static void AddValues(this DataTable table, int insertRow, params object[] values)
        {
            DataRow drow = table.NewRow();
            if (values != null && values.Length > 0)
            {
                for (int i = 0; i < values.Length; i++)
                {
                    drow[i] = values[i];
                }
            }
            table.Rows.InsertAt(drow, insertRow);
        }

        public static DataTable? ToTable(this DataGridView grid, params string[] columns)
        {
            try
            {
                if (columns.Length > 0)
                {
                    return CreateATableFromColumns(grid, columns);
                }
                else
                {
                    return CreateATableFromGrid(grid);
                }
            }
            catch
            {
                return default(DataTable);
            }

        }
        private static DataTable? CreateATableFromGrid(this DataGridView grid)
        {
            DataTable table = CreateTableFromGrid(grid);
            foreach (DataGridViewRow rows in grid.Rows)
            {
                DataRow dRow = table.NewRow();
                if (rows.IsNewRow) continue;
                foreach (DataGridViewCell cell in rows.Cells)
                {
                    dRow[cell.ColumnIndex] = cell.Value;
                }
                table.Rows.Add(dRow);
            }
            return table;
        }

        private static DataTable? CreateATableFromColumns(DataGridView grid, params string[] columns)
        {
            DataTable table = CreateTableFromColumns(columns);
            foreach (DataGridViewRow row in grid.Rows)
            {
                DataRow dRow = table.NewRow();
                if (row.IsNewRow) continue;
                foreach (var column in columns)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        if (grid.Columns[cell.ColumnIndex].Name.ToLower() == column.ToLower())
                        {
                            dRow[column] = cell.Value;
                        }
                        else
                            continue;
                    }
                }

                table.Rows.Add(dRow);
            }
            return table;


        }
        private static DataTable CreateTableFromGrid(DataGridView grid)
        {
            DataTable table = new DataTable();
            foreach (DataGridViewColumn col in grid.Columns)
            {
                table.Columns.Add(col.Name, typeof(object));
            }
            return table;
        }
        private static DataTable CreateTableFromColumns(params string[] columns)
        {
            DataTable table = new DataTable();
            if (columns.Length > 0)
            {
                foreach (var column in columns)
                {
                    table.Columns.Add(column, typeof(object));
                }
            }
            return table;
        }



    }
}
