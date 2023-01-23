using Newtonsoft.Json;
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
using translator.Models;

namespace translator
{  
    public partial class FileTranslator : Form
    {


        public string inLang { get; set; }
        public string outLang { get; set; }
        public string text { get; set; }

        string selectedfile = string.Empty;


        public FileTranslator()
        {
            InitializeComponent();
        }

        private void ImportBtn_Click(object sender, EventArgs e)
        {
            this.OpenFileDialogWindow();
            this.ImportData();
        }

        private void OpenFileDialogWindow()
        {
            string dbasepath = CurrentPath.GetDbasePath();

            OpenFileDialog openDialog = new OpenFileDialog();

            //Set Title of OpenFileDialog
            openDialog.Title = "Select A Text File";
            //Set directory path
            openDialog.InitialDirectory = dbasepath;

            //Set the File Filter of OpenFileDialog
            openDialog.Filter = "Text (*.txt)|*.txt" + "|" +
                                "CSV (*.csv)|*.csv" + "|" +
                                "All Files (*.*)|*.*";

            //Get the OK press of the Dialog Box
            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                //Get Selected File
                selectedfile = openDialog.FileName;
            }
        }

        private void ImportData()
        {
            //Get Guaridan of the Galaxy Characters from text file
            text = TexFiletInputOutput.GetGuardiansData(selectedfile);

            //Use LINQ to get customers from the CustomersModel
            var theguardians = (from c in characters
                                select c.Person).ToList();

            //Set the DataSource of the listbox to the customers collection
            this.lstCharacters.DataSource = theguardians;
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
