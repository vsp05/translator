using translator.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace translator.Processes
{
    public static class ConvertObjects
    {
        public static DataTable ConvertListToDataTable(List<string> list)
        {
            string tablename = "Export";

            //New DataTable
            DataTable table = new DataTable(tablename);
            //Create Column
            table.Columns.Add("DataValue");
            //Create Row
            DataRow row;

            //Add rows
            foreach (var l in list)
            {
                //Add A New Row
                row = table.NewRow();
                //Set value of New Row
                //row[0] = l.String;
                //Add Row to DataTable
                table.Rows.Add(row);
            }

            return table;
        }
    }
}