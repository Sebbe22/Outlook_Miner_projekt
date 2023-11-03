
using OutlookMiner;
using OutlookMiner.Services;
using OutlookMiner.Models;
using System.Reflection.Metadata;
using System.Windows.Forms.Design;
using OutlookMiner.Forms;
using System.Net.Mail;

namespace OutlookMiner
{
    public partial class Form1 : Form
    {
        public static Form1 instance;
        private string selectedFilePathOutputFile = "";
        private IPathUtilityService pathUtilityService;
        private ILoadService loadService;
        private List<Text> mails;
        public Form1(IPathUtilityService pathUtilityService, ILoadService loadService)
        {

            InitializeComponent();
            instance = this;
            this.pathUtilityService = pathUtilityService;
            this.loadService = loadService;
            pbLoadingGif.Hide();
        }

        private void btNext_Click(object sender, EventArgs e)
        {
            var newForm = new CleanUpForm(mails);
            newForm.Show();
            this.Hide();

        }



        private void lbMailCount_Click(object sender, EventArgs e)
        {

        }

        private void lbMailCount_Click_1(object sender, EventArgs e)
        {

        }

        private void chooseFile_Click(object sender, EventArgs e)
        {
            IEmailBasicInfoService emailBasicInfoService = new EmailBasicInfoService();
            string selectedPath = pathUtilityService.LoadPath();
            pbLoadingGif.Show();
            mails = loadService.LoadMail(selectedPath);
            int threadCount = emailBasicInfoService.CountThreads(mails);
            List<IndividualMailText> individualMails = emailBasicInfoService.SeparateThreadsIntoMails(mails);
            int mailCount = emailBasicInfoService.CountMessages(individualMails);
            lbFileChosen.Text = selectedPath;
            pbLoadingGif.Hide();
            lbMailCount.Text = "Threads: " + threadCount + "\nIndividual messages: " + mailCount;


        }
    }
}