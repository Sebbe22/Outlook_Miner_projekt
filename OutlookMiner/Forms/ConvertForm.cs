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
       private IPathUtilityService _pathUtilityService;
        public static ConvertForm instance;
        private List<Text> mails;

        public ConvertForm(IPathUtilityService pathUtilityService, List<Text> _mails)
        {
            InitializeComponent();
            _pathUtilityService = pathUtilityService;
            this.mails = _mails;
            instance = this;
        }

        private void lbGoToStart_Click(object sender, EventArgs e)
        {
            this.Close();
            CleanUpForm.instance.Close();
            //Form1 back = new Form1();
            Form1.instance.Show();
        }

        private void btBack_Click(object sender, EventArgs e)
        {
            this.Close();
            CleanUpForm cleanUpForm = new CleanUpForm(mails);
            cleanUpForm.Show();
        }

        private void btConvertFile_Click(object sender, EventArgs e)
        {
            ILoadService load = new LoadService();
            ICleanService clean = new CleanService();
            IConvertService convert = new ConvertServicePDF();

            
            string selectedFilePathInputFile = Form1.instance.lbFileChosen.Text;
            mails = clean.RemoveLinksFromEmailString(mails);
            string selectedFilePath = _pathUtilityService.SavePath("pdf");
            convert.Convert(selectedFilePath, mails);            
        }
    }
}
