
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
        private IPathUtilityService pathUtilityService; 
        public Form1(IPathUtilityService pathUtilityService)
        {

            InitializeComponent();
            instance = this;
            this.pathUtilityService = pathUtilityService;
        }

        private void btNext_Click(object sender, EventArgs e)
        {
            var newForm = new CleanUpForm();
            newForm.Show();
            this.Hide();

        }

        private void chooseFile_Click_1(object sender, EventArgs e)
        {
            string selectedPath = pathUtilityService.LoadPath();
            lbFileChosen.Text = selectedPath;


        }
    }
}