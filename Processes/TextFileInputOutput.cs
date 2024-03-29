﻿using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace translator.Processes
{
    public class TextFileInputOutput
    {
        private static List<String> lines = new List<string>();
        static string sFile = string.Empty;
        static bool bCalled = false;
        // private static string newline;

        public static string TempLine { get; set;}

        public static List<String> GetData(string file)
        {
            List<String> ilines = new List<String>();
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
                            ilines.Add(line);
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

            return ilines;
        }

        public async static Task<string> API(string lang1, string lang2, string text)
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
            string body = await response.Content.ReadAsStringAsync();
            JObject obj = JObject.Parse(body);
            return obj["data"]["translatedText"].ToString();
        }

        public static async void ExportDataToTextFileAsync(List<String> data, string file, string inlang, string outlang)
        {
            try
            {
                sFile = file;


                foreach (var d in data)
                {
                    var result = await API(inlang, outlang, d);
                    lines.Add($"{result}");

                }


                PerformExport();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private static void PerformExport()
        {
            if (lines != null && lines.Count > 0)
            {
                var result = (from l in lines
                              select l).Distinct();

                //Console.WriteLine(lines.ToString());

                FileStream stream = new FileStream(sFile, FileMode.CreateNew);

                using (StreamWriter writer = new StreamWriter(stream, Encoding.UTF8))
                {
                    foreach (string r in result)
                    {
                        Console.WriteLine(r);
                        writer.WriteLine(r);
                    }
                }

                lines.Clear();
            }
        }


    }
}
