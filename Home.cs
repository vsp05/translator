using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace translator
{

    public partial class Home : Form
    {

        public string inLang { get; set; }
        public string outLang { get; set; }
        public string text { get; set; }



        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            this.SetControls();
        }

        private void SetControls()
        {
            //Form
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private void inputLangInputTxt_TextChanged(object sender, EventArgs e)
        {
            inLang = this.inputLangInputTxt.Text;
        }

        private void OutputLangInputTxt_TextChanged(object sender, EventArgs e)
        {
            outLang = this.OutputLangInputTxt.Text;
        }

        private void TextInputTxt_TextChanged(object sender, EventArgs e)
        {
            text = this.TextInputTxt.Text;
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

        private void translateBtn_Click(object sender, EventArgs e)
        {

            API(inLang, outLang, text);

        }

        private void LanguagesBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread t = new Thread(new ThreadStart(ThreadLanguagesPage));
            t.Start();
        }

        private void ThreadLanguagesPage()
        {
            //RUNs a NEW application with the desired form
            Application.Run(new LanguageCodes());

        }

        private void DocumentBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread t = new Thread(new ThreadStart(ThreadFileTranslator));
            t.Start();
        }

        private void ThreadFileTranslator()
        {
            //RUNs a NEW application with the desired form
            Application.Run(new FileTranslator());

        }
    }
}
