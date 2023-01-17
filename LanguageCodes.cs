using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace translator
{
    public partial class LanguageCodes : Form
    {
        public LanguageCodes()
        {
            InitializeComponent();
        }

        private void TopBox_Click(object sender, EventArgs e)
        {

        }

        private void ISOLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.loc.gov/standards/iso639-2/php/code_list.php");
        }

        private void HomeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread t = new Thread(new ThreadStart(ThreadHomePage));
            t.Start();
        }

        private void ThreadHomePage()
        {
            //RUNs a NEW application with the desired form
            Application.Run(new Home());

        }
    }
}
