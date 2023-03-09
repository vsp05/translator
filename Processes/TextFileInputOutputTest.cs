using translator.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using translator;
using System.Linq;

namespace translator.Processes
{
    public class TextFileInputOutputTest
    {
        private static List<String> lines = new List<string>();
        static string sFile = string.Empty;
        static bool bCalled = false;
        // private static string newline;

        public static string TempLine { get; set;}

        //public async static Task<string> API(string lang1, string lang2, string text)
        //public async static Task API(string lang1, string lang2, string text)
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

        public async static Task API(string lang1, string lang2, string text)
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
            // newline = obj["data"]["translatedText"].ToString();
            // Console.WriteLine(newline);
            Console.WriteLine(obj["data"]["translatedText"]);

            lines.Add(obj["data"]["translatedText"].ToString());

            //return obj["data"]["translatedText"].ToString();

        }

        public static async void ExportDataToTextFileAsync(List<String> data, string file, string inlang, string outlang)
        {
            try
            {
                sFile = file;

                List<string> lines = new List<string>();

                await Task.Run(() =>
                {
                    foreach (var d in data)
                    {
                        _ = API(inlang, outlang, d);
                    }
                    PerformExport();
                });

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                await Task.Run(() =>
                {
                });
            }

            //return true;
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
            }
        }


    }
}

//We want to 
//FileStream stream = File.OpenWrite(file);

/*foreach(var d in data)
{
    API(inlang, outlang, d).ContinueWith((newline) =>
    {
        byte[] bytes = Encoding.UTF8.GetBytes(newline.ToString());
        stream.Write(bytes, 0, bytes.Length);
    });
}*/



//new FileStream(file, FileMode.OpenOrCreate, FileAccess.Write);
//StreamWriter sr = new StreamWriter(stream);
//sr.WriteLine("coin");
//sr.WriteLine("dog");

/*using (StreamWriter writer = new StreamWriter(stream, Encoding.UTF8))
{
    foreach (var d in data)
    {
        API(inlang, outlang, d).ContinueWith((newline) =>
        {
            //writer.Flush();
            writer.WriteLine(newline);
        });
    }
}*/
/*
using (StreamWriter writer = File.AppendText(file))
{
    // writer.WriteLine("hello");
    foreach (var d in data)
    {
        string res = "";
        API(inlang, outlang, d).ContinueWith((newline) =>
        {
            Console.WriteLine(newline.Result.ToString());
            //writer.Flush();
            res = newline.Result.ToString();
            writer.WriteLine($"{res + "---"}");
        });
        JToken res = null;
        API(inlang, outlang, d).ContinueWith((newline) =>
        {
            //writer.Flush();
            res = newline.Result;
        });
        Console.WriteLine(res);
        Console.WriteLine(res);
        writer.WriteLine($"{res+"---"}");
    }
}*/

/*
API(inlang, outlang, d).ContinueWith((newline) =>
{
    //res = newline.Result.ToString();
    //lines.Add(res);
    if (bCalled == false)
    {
        PerformExport();
    }
    bCalled = true;
});
*/

/*
if (lines.Count > 0)
{
    Console.WriteLine(lines.ToString());
    using (StreamWriter writer = File.AppendText(file))
    {
        foreach (string l in lines)
        {
            Console.WriteLine(l);
            writer.WriteLine(l);
        }
    }
}
*/

/*
Console.WriteLine(lines.ToString());
using (StreamWriter writer = File.AppendText(file))
{
    foreach(string l in lines)
    {
        Console.WriteLine(l);
        writer.WriteLine(l);
    }
}
*/

//stream.Close();
