﻿using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace translator
{
    public partial class FileTranslator : Form
    {


        public string inLang { get; set; }
        public string outLang { get; set; }
        public string text { get; set; }



        public FileTranslator()
        {
            InitializeComponent();
        }

        private void ImportBtn_Click(object sender, EventArgs e)
        {
            //finish this next block -- see HowTo for insipration
        }

        private async void API(string lang1, string lang2, string text)
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
            response.EnsureSuccessStatusCode();
            string body = await response.Content.ReadAsStringAsync();
            JObject obj = JObject.Parse(body);
            translatedTxt.Text = (obj["data"]["translatedText"]).ToString();
        }

        private void inputLangInputTxt_TextChanged(object sender, EventArgs e)
        {
            inLang = this.inputLangInputTxt.Text;
        }

        private void OutputLangInputTxt_TextChanged(object sender, EventArgs e)
        {
            outLang = this.OutputLangInputTxt.Text;
        }
    }
}
