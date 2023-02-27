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
        private static string newline;

        public static string TempLine { get; set;}

        public async static void API(string lang1, string lang2, string text)
        {

            string inputLang = lang1;
            string outputLang = lang2;
            string inputText = text;

            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri("https://text-translator2.p.rapidapi.com/translate"),
                Headers =
                {
                    { "X-RapidAPI-Key", "113a32bba8msh01a2e5808733a20p1a28d1jsn1c402fdabd00" },
                    { "X-RapidAPI-Host", "text-translator2.p.rapidapi.com" },
                },
                Content = new FormUrlEncodedContent(new Dictionary<string, string>
                {
                    { "source_language", inputLang },
                    { "target_language", outputLang },
                    { "text", inputText },
                }),
            };

            var response = await client.SendAsync(request);
            //response.EnsureSuccessStatusCode();
            string body = await response.Content.ReadAsStringAsync();
            JObject obj = JObject.Parse(body);
            //newline = ((obj["data"]["translatedText"]).ToString());
            newline = (string)obj["data"]["translatedText"];

        }

        public static List<String> GetData(string file)
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

        public static bool ExportDataToTextFile(List<String> data, string file, string inlang, string outlang)
        {
            try
            {
                //We want to 
                FileStream stream = new FileStream(file, FileMode.OpenOrCreate, FileAccess.Write);

                using (StreamWriter writer = new StreamWriter(stream, Encoding.UTF8))
                {
                    foreach (var d in data)
                    {
                        API(d, inlang, outlang);
                        writer.WriteLine(newline);
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
