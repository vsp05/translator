using translator.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace translator.Processes
{
    public static class TextFileInputOutput
    {
        private static List<String> lines;

        public static string TempLine { get; set;}

        public static List<String> GetData(string file)
        {
            lines = new List<String>();
            string line = string.Empty;

            try
            {
                //Check if the file exists
                if (File.Exists(file))
                {
                    //Create a Stream Reader
                    using (StreamReader rdr = new StreamReader(file))
                    {
                        //Read the data in the file
                        while ((line = rdr.ReadLine()) != null)
                        {
                            //Add data to the Customers Model
                            lines.Add(line);
                            TempLine = line;
                        }
                    }
                }
                else
                {
                    throw new Exception("File Not Found!");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return lines;
        }

        public static bool ExportDataToTextFile(List<String> data, string file)
        {
            try
            {
                //We want to 
                FileStream stream = new FileStream(file, FileMode.OpenOrCreate, FileAccess.Write);

                using (StreamWriter writer = new StreamWriter(stream, Encoding.UTF8))
                {
                    foreach (var d in data)
                    {
                        writer.WriteLine(d.ToString());
                    }
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }

            return true;
        }
    }
}
