
using OutlookMiner;
using OutlookMiner.Services;
using OutlookMiner.Models;
using System.Reflection.Metadata;
using System.Windows.Forms.Design;
using OutlookMiner.Forms;

namespace OutlookMiner
{
    public partial class Form1 : Form
    {
        public static Form1 instance;
        private string selectedFilePathOutputFile = "";
        public Form1()
        {

            InitializeComponent();
            instance = this;
        }

        //private void chooseFile_Click(object sender, EventArgs e)
        //{
        //    LoadOutLookService _load = new LoadOutLookService();
        //    string path = tbPath.Text;
        //    List<string> mails = _load.ImportPST(path);
        //    string labelText = string.Join(Environment.NewLine, mails);
        //    lOutput.Text = labelText;
        //}


        private void ConvertToPDF_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.InitialDirectory = "C:\\"; // Set the initial directory
                saveFileDialog.Filter = "Text Files (*.pdf)|*.pdf|All Files (*.*)|*.*"; // Set the file filter
                saveFileDialog.DefaultExt = "pdf"; // Set the default file extension

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //LoadOutLookService _load = new LoadOutLookService();
                    ILoadService load = new LoadService();
                    IConvertService convert = new ConvertServicePDF();

                    string selectedFilePath = saveFileDialog.FileName; // Get the selected file path
                    lbSaveLocation.Text = selectedFilePath;

                    List<Text> mails = load.LoadMail(selectedFilePathOutputFile);
                    convert.Convert(selectedFilePath, mails);

                }
            }
        }

        private void btNext_Click(object sender, EventArgs e)
        {
            var newForm = new CleanUpForm();
            newForm.Show();
            this.Hide();

        }

        private void chooseFile_Click_1(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "C:\\"; // Set the initial directory
                openFileDialog.Filter = "All Files (*.*)|*.*"; // Set the file filter

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //LoadOutLookService _load = new LoadOutLookService();
                    selectedFilePathOutputFile = openFileDialog.FileName; // Get the selected file path
                    lbFileChosen.Text = openFileDialog.FileName;
                    //string labelText = string.Join(Environment.NewLine, _load.ImportPST(selectedFilePath));
                    //lOutput.Text = labelText;
                }
            }

        }
    }
}