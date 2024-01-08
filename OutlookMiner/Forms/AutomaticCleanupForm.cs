using OutlookMiner.Models;
using OutlookMiner.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OutlookMiner.Forms
{
    public partial class AutomaticCleanupForm : Form
    {
        private StartUpForm startUpForm;
        public static AutomaticCleanupForm instance;
        private string selectedFilePathOutputFile = "";
        private IPathUtilityService pathUtilityService;
        private ILoadService loadService;
        private List<Text> mails;
        private List<IndividualMailText> individualMails;
        private ICheckBoxService _checkboxList;
        private Form ActiveForm;
        private List<ThreadModel> threads = new List<ThreadModel>();
        IManualLabelService labelingService = new ManualLabelService();
        private IAutomaticLabelingService _automaticLabelingService = new AutomaticLabelingService();
        private static bool cleaned = false;

        public ICheckBoxService GetCheckBoxListModelInstance()
        {
            return _checkboxList;
        }

        public AutomaticCleanupForm(StartUpForm startUpForm)
        {
            InitializeComponent();
            LoadTheme();
            instance = this;
            pathUtilityService = new PathUtilityService();
            loadService = new LoadService();
          
            pbLoadingGif.Hide();
            lbShowingStatus.Hide();
            this.startUpForm = startUpForm;

            this._checkboxList = CheckBoxService.Instance;
        }
        private void LoadTheme()
        {
            foreach (Control btns in panelButton.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btns.BackColor = ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                }
            }
            lbHeader.ForeColor = ThemeColor.SecondaryColor;
            lbFileChosen.BackColor = ThemeColor.SecondaryColor;
            lbFileChosen.ForeColor = Color.White;


        }
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (ActiveForm != null)
            {
                ActiveForm.Close();
            }

            ActiveForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            startUpForm.PanelChildForm.Controls.Add(childForm);
            startUpForm.PanelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }



        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            AutomaticCleanupForm.instance = this;
            string targetName = "RemoveLinksFromEmailString";

            _checkboxList.UpdateCheckBox(targetName, AutomaticCleanupForm.instance.checkBox2.Checked);

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            AutomaticCleanupForm.instance = this;
            string targetName = "RemoveEmailsFromEmailString";

            _checkboxList.UpdateCheckBox(targetName, AutomaticCleanupForm.instance.checkBox4.Checked);

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            AutomaticCleanupForm.instance = this;
            string targetName = "RemoveSenderAndRecieverNameFromEmail";

            _checkboxList.UpdateCheckBox(targetName, AutomaticCleanupForm.instance.checkBox1.Checked);
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            AutomaticCleanupForm.instance = this;
            string targetName = "RemoveEverythingPastBestRegards";

            _checkboxList.UpdateCheckBox(targetName, AutomaticCleanupForm.instance.checkBox3.Checked);

        }


        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            AutomaticCleanupForm.instance = this;
            string targetName = "RemovePasswordAndUserNameFromEmail";
            _checkboxList.UpdateCheckBox(targetName, AutomaticCleanupForm.instance.checkBox6.Checked);
        }
        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            AutomaticCleanupForm.instance = this;
            foreach (CheckBoxModel checkBox in _checkboxList.GetCheckBoxes())
            {
                _checkboxList.UpdateCheckBox(checkBox.methodName, AutomaticCleanupForm.instance.checkBox8.Checked);
            }
        }
        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            AutomaticCleanupForm.instance = this;
            string targetName = "RemoveEverythingPastBestRegards";

            _checkboxList.UpdateCheckBox(targetName, AutomaticCleanupForm.instance.checkBox5.Checked);

        }
        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            AutomaticCleanupForm.instance = this;
            string targetName = "CheckForSystems";

            _checkboxList.UpdateCheckBox(targetName, AutomaticCleanupForm.instance.checkBox7.Checked);
        }

        private void btnChooseFile_Click(object sender, EventArgs e)
        {
           

            IEmailBasicInfoService emailBasicInfoService = new EmailBasicInfoService();
            string selectedPath = pathUtilityService.LoadPath();
            if(selectedPath != null)
            {
                pbLoadingGif.Visible = true;
                lbShowingStatus.Visible = true;
               
                BackgroundWorker backgroundWorker = new BackgroundWorker();

                backgroundWorker.DoWork += (sender, eArgs) =>
                {
                    mails = loadService.LoadMail(selectedPath);
                    mails = emailBasicInfoService.RemoveDuplicateThreads(mails);
                    int threadCount = emailBasicInfoService.CountThreads(mails);
                    individualMails = emailBasicInfoService.SeparateThreadsIntoMails(mails);
                    int mailCount = emailBasicInfoService.CountMessages(individualMails);

                    eArgs.Result = new
                    {
                        SelectedPath = selectedPath,
                        ThreadCount = threadCount,
                        MailCount = mailCount,
                        IndividualMailList = individualMails
                    };
                };

 
                backgroundWorker.RunWorkerCompleted += (sender, eArgs) =>
                {
                 
                    var result = (dynamic)eArgs.Result;

               
                    lbFileChosen.Text = result.SelectedPath;
                    if (result.MailCount > 0)
                    {
                        lbMailCount.Text = "Threads: " + result.ThreadCount + "\nIndividual messages: " + result.MailCount;
                    }
                    else
                    {
                        lbMailCount.Text = "No mails were found";
                    }

                    individualMails = result.IndividualMailList;
                
                    pbLoadingGif.Visible = false;
                    lbShowingStatus.Visible = false;
                };

             
                backgroundWorker.RunWorkerAsync();

            }
            

        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            if(individualMails != null)
            {
                ILoadService load = new LoadService();
                ICleanService clean = new CleanService();
                IConvertService convert = new ConvertServicePDF();
                string selectedFilePath = pathUtilityService.SavePath("pdf");
                pbLoadingGif.Visible = true;
                lbShowingStatus.Visible = true;
                BackgroundWorker backgroundWorker = new BackgroundWorker();
                backgroundWorker.DoWork += (sender, eArgs) =>
                {

                    List<CheckBoxModel> checkBoxes = _checkboxList.GetCheckBoxes();
                    foreach (var checkbox in checkBoxes)
                    {
                        if (checkbox.methodName == "CheckForSystems")
                        {
                            if (checkbox.isChecked)
                            {
                                threads = labelingService.CreateThreads(_automaticLabelingService.CheckForSystems(individualMails));
                                individualMails = null;
                            }

                        }
                        else
                        {
                            Type type = typeof(CleanService);
                            MethodInfo methodInfo = type.GetMethod(checkbox.methodName);
                            if (methodInfo != null)
                            {
                                object instance = Activator.CreateInstance(type);
                                if (checkbox.isChecked)
                                {
                                    object[] parameters = new object[] { individualMails };
                                    individualMails = (List<IndividualMailText>?)methodInfo.Invoke(instance, parameters);
                                }
                            }
                        }


                    }
                    if (individualMails != null)
                    {
                        convert.ConvertIndividualText(selectedFilePath, individualMails);
                    }
                    if (threads != null)
                    {
                        convert.ConvertThreads(selectedFilePath, threads);
                    }


                 
                    eArgs.Result = new
                    {

                    };

                };
            
                backgroundWorker.RunWorkerCompleted += (sender, eArgs) =>
                {
               
                    var result = (dynamic)eArgs.Result;

            
                    pbLoadingGif.Visible = false;
                    lbShowingStatus.Text = "File converted";

                };

                backgroundWorker.RunWorkerAsync();

            }
            else
            {
                MessageBox.Show("No file was loaded. Cannot Convert", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

        }

    }

}

