using OutlookMiner.Models;
using OutlookMiner.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OutlookMiner.Forms
{
    public partial class ConvertForm : Form
    {
       
       
        public ConvertForm()
        {
            InitializeComponent();

        }

        private void lbGoToStart_Click(object sender, EventArgs e)
        {
            this.Close();
            CleanUpForm.instance.Close();
            Form1 back = new Form1();
            back.Show();
        }

        private void btBack_Click(object sender, EventArgs e)
        {
            this.Close();
            CleanUpForm cleanUpForm = new CleanUpForm();
            cleanUpForm.Show();
        }

        private void btConvertFile_Click(object sender, EventArgs e)
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
                    ICleanService clean = new CleanService();
                    IConvertService convert = new ConvertServicePDF();

                    string selectedFilePath = saveFileDialog.FileName; // Get the selected file path
                  
                    string selectedFilePathInputFile = Form1.instance.lbFileChosen.Text;
                    List<Text> mails = load.LoadMail(selectedFilePathInputFile);
                    if (CleanUpForm.instance != null && CleanUpForm.instance.checkBox2.Checked)
                    {
                        mails = clean.RemoveLinksFromEmailString(mails);
                    }

                    convert.Convert(selectedFilePath, mails);

                }
            }
        }
    }
}
