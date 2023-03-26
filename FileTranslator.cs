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
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using translator.Models;
using translator.Processes;

namespace translator
{  
    public partial class FileTranslator : Form
    {


        public string inLang { get; set; }
        public string outLang { get; set; }
        public List<string> text { get; set; }

        string selectedfile = string.Empty;

        bool success = false;


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
            text = TextFileInputOutput.GetData(selectedfile);

            //Use LINQ to get customers from the CustomersModel
            //var theguardians = (from c in text
            //                    select c.Person).ToList();

            //Set the DataSource of the listbox to the customers collection
            //this.lstCharacters.DataSource = theguardians;
        }

        private void inputLangInputTxt_TextChanged(object sender, EventArgs e)
        {
            inLang = this.inputLangInputTxt.Text;
        }

        private void OutputLangInputTxt_TextChanged(object sender, EventArgs e)
        {
            outLang = this.OutputLangInputTxt.Text;
        }

        private void FileTranslator_Load(object sender, EventArgs e)
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

        private void OutputDirectoryBtn_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.SelectedPath = CurrentPath.GetDbasePath();

            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                this.txtLocation.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void exportBtn_Click(object sender, EventArgs e)
        {
            if (!ValidateForm())
                return;

            this.PerformExport();

            success = true;
        }

        private bool ValidateForm()
        {
            if (this.txtLocation.Text.Trim() == string.Empty)
            {
                MessageBox.Show(this, "Directory must be selected!", TitlesModel.MessageBoxTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (this.txtFileName.Text.Trim() == string.Empty)
            {
                MessageBox.Show(this, "FileName cannot be empty!", TitlesModel.MessageBoxTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void PerformExport()
        {

            string file = this.txtLocation.Text.Trim() + "\\" + this.txtFileName.Text.Trim();

            if (this.rbText.Checked)
            {
                file = file + ".txt";
                //var task = TextFileInputOutputTest.ExportDataToTextFileAsync(text, file, inLang, outLang);
                TextFileInputOutput.ExportDataToTextFileAsync(text, file, inLang, outLang);
                string s = string.Empty;
            }
            else if (this.rbXML.Checked)
            {
                file = file + ".xml";
                success = ExportXML.ExportXMLData(ConvertObjects.ConvertListToDataTable(text), file);
            }
            if (success)
                MessageBox.Show(this, "Export of " + file + " was SUCCESSFUL.", TitlesModel.MessageBoxTitle,
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show(this, "Export of " + file + " was SUCCESSFUL!", TitlesModel.MessageBoxTitle,
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }
}
