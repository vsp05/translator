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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace translator
{

    public partial class Home : Form
    {

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
            API();
        }

        private async void API()
        {
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
                    { "source_language", "en" },
                    { "target_language", "id" },
                    { "text", "chicken" },
                }),
            };

            var response = await client.SendAsync(request);
            response.EnsureSuccessStatusCode();
            var body = await response.Content.ReadAsStringAsync();
            Console.WriteLine(body);
        }

    }
}
