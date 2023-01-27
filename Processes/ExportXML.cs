using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using translator.Models;
using System.Threading.Tasks;

namespace translator.Processes
{
    public class ExportXML
    {
        public static bool ExportXMLData(DataTable data, string file)
        {
            //Write DataTable as XML
            data.WriteXml(file);

            //Export was successful
            return true;
        }
    }
}
