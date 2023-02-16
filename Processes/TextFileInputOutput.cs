using translator.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using translator;

namespace translator.Processes
{
    public class TextFileInputOutput
    {
        private static List<String> lines;

        public static string TempLine { get; set;}

        public static List<String> GetData(string file, string inlang, string outlang)
        {
            lines = new List<String>();
            string line = ""; 

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
                            //FIGURE OUT HOW TO CALL API
                           //lines.Add(translatedLine);
                            //TempLine = translatedLine;
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
