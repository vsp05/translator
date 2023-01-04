using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

var client = new RestClient("https://text-translator2.p.rapidapi.com/translate");
var request = new RestRequest(Method.POST);
request.AddHeader("content-type", "application/x-www-form-urlencoded");
request.AddHeader("X-RapidAPI-Key", "113a32bba8msh01a2e5808733a20p1a28d1jsn1c402fdabd00");
request.AddHeader("X-RapidAPI-Host", "text-translator2.p.rapidapi.com");
request.AddParameter("application/x-www-form-urlencoded", "source_language=en&target_language=id&text=poop", ParameterType.RequestBody);
IRestResponse response = client.Execute(request);

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
        }

    }
}
