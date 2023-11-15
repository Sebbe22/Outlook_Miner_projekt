
using OutlookMiner;
using OutlookMiner.Services;
using OutlookMiner.Models;
using System.Reflection.Metadata;
using System.Windows.Forms.Design;
using OutlookMiner.Forms;
using System.Net.Mail;
using System.ComponentModel;

namespace OutlookMiner
{
    public partial class Form1 : Form
    {
        public static Form1 instance;
        private string selectedFilePathOutputFile = "";
        private IPathUtilityService pathUtilityService;
        private ILoadService loadService;
        private List<Text> mails;
        private List<IndividualMailText> individualMails;
        public Form1(IPathUtilityService pathUtilityService, ILoadService loadService)
        {

            InitializeComponent();
            instance = this;
            this.pathUtilityService = pathUtilityService;
            this.loadService = loadService;
            // Hide the PictureBox on the UI thread
            pbLoadingGif.Hide();
            lbShowingStatus.Hide();
        }

        private void btNext_Click(object sender, EventArgs e)
        {
            var newForm = new CleanUpForm(individualMails);
            newForm.Show();
            this.Hide();

        }


        private void chooseFile_Click(object sender, EventArgs e)
        {
            // Start showing the loading GIF

            IEmailBasicInfoService emailBasicInfoService = new EmailBasicInfoService();
            string selectedPath = pathUtilityService.LoadPath();
            pbLoadingGif.Visible = true;
            lbShowingStatus.Visible = true;
            // Create a BackgroundWorker instance
            BackgroundWorker backgroundWorker = new BackgroundWorker();

            // Do the work in a separate thread
            backgroundWorker.DoWork += (sender, eArgs) =>
            {
                mails = loadService.LoadMail(selectedPath);
                mails = emailBasicInfoService.RemoveDuplicateThreads(mails);
                int threadCount = emailBasicInfoService.CountThreads(mails);
                individualMails = emailBasicInfoService.SeparateThreadsIntoMails(mails);
                int mailCount = emailBasicInfoService.CountMessages(individualMails);

                // Pass the results to the RunWorkerCompleted event
                eArgs.Result = new
                {
                    SelectedPath = selectedPath,
                    ThreadCount = threadCount,
                    MailCount = mailCount,
                    IndividualMailList = individualMails
                };
            };

            // Handle the completion of the work
            backgroundWorker.RunWorkerCompleted += (sender, eArgs) =>
            {
                // Retrieve the results from the DoWork event
                var result = (dynamic)eArgs.Result;

                // Update the UI with the results
                lbFileChosen.Text = result.SelectedPath;
                if(result.MailCount> 0)
                {
                    lbMailCount.Text = "Threads: " + result.ThreadCount + "\nIndividual messages: " + result.MailCount;
                }
                else
                {
                    lbMailCount.Text = "No mails were found";
                }
               
                individualMails = result.IndividualMailList;
                // Hide the loading GIF
                pbLoadingGif.Visible = false;
                lbShowingStatus.Visible = false;
            };

            // Start the background worker
            backgroundWorker.RunWorkerAsync();


        }

      
    }
}