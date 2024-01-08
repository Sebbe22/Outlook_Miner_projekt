using ceTe.DynamicPDF.PageElements.Forms;
using iTextSharp.xmp.impl;
using Microsoft.Office.Interop.Outlook;
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
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Action = System.Action;
using Button = System.Windows.Forms.Button;
using ComboBox = System.Windows.Forms.ComboBox;

namespace OutlookMiner.Forms
{
    public partial class ManualEditingForm : Form
    {
        private StartUpForm startUpForm;
        public static ManualCleanupForm instance;
        private List<IndividualMailText> individualMails;
        private ICheckBoxService _checkboxList;
        private Form ActiveForm;
        IManualLabelService labelingService = new ManualLabelService();
        ICleanManualService cleanService = new CleanManualService();
        List<String> ChoosenLabels = new List<string>();
        List<LabelModel> labelModels;
        ILabelService labelService;
        List<IndividualMailTextLabelingModel> LabeledMessages = new List<IndividualMailTextLabelingModel>();
        IEmailBasicInfoService emailBasicInfoService = new EmailBasicInfoService();

        private int currentIndex = 0;
        private bool commited = false;

        public ManualEditingForm(List<IndividualMailText> mails, StartUpForm startUpForm)
        {
            labelService = new LabelService();
            InitializeComponent();
            individualMails = mails;
            LoadTheme();
            ShowList(ChoosenLabels);
            UpdateMailCounter();
            this.startUpForm = startUpForm;

            LabelingPanel.Visible = false;
            TextPanel.Visible = false;
            TextPanel.AutoScroll = true;

            pbLoadingGif.Visible = true;
            lbShowingStatus.Visible = true;

            BackgroundWorker backgroundWorker = new BackgroundWorker();
            backgroundWorker.DoWork += (sender, eArgs) =>
            {
                this._checkboxList = CheckBoxService.Instance;

                individualMails = mails;
                labelModels = new List<LabelModel>(labelService.GetLabels());

                List<CheckBoxModel> checkBoxes = _checkboxList.GetCheckBoxes();
                foreach (var checkbox in checkBoxes)
                {
                    Type type = typeof(CleanManualService);
                    MethodInfo methodInfo = type.GetMethod(checkbox.methodName);
                    if (methodInfo != null)
                    {
                        object instance = Activator.CreateInstance(type);
                        if (checkbox.isChecked)
                        {
                            object[] parameters = new object[] { mails };
                            mails = (List<IndividualMailText>?)methodInfo.Invoke(instance, parameters);
                        }
                    }

                }


                eArgs.Result = new
                {

                };

            };

            backgroundWorker.RunWorkerCompleted += (sender, eArgs) =>
            {

                var result = (dynamic)eArgs.Result;

 
                LabelingPanel.Visible = true;
                TextPanel.Visible = true;

                pbLoadingGif.Visible = false;
                lbShowingStatus.Visible = false;
                DisplayText();


                DDLabels.DataSource = labelModels.Select(l => l.LabelName).Distinct().ToList();
            };

            backgroundWorker.RunWorkerAsync();
        }
        private void LoadTheme()
        {
            foreach (Control btns in LabelingPanel.Controls)
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
            lbLabelsAdded.ForeColor = ThemeColor.SecondaryColor;
            listViewLabels.BackColor = ThemeColor.SecondaryColor;
            listViewLabels.ForeColor = Color.White;


        }
        private void ShowList(List<String> choosenLabels)
        {
            listViewLabels.Clear();
            foreach (string item in choosenLabels)
            {
                listViewLabels.Items.Add(item);
            }
        }
        private void DisplayText()
        {
            if (individualMails.Count > 0 && currentIndex >= 0 && currentIndex < individualMails.Count)
            {
                if (commited == false)
                {
                    ShowMatches(individualMails[currentIndex].body);
                }
                else
                {
                    textBoxEditing.Text = individualMails[currentIndex].body;
                }

            }
        }
        private void ShowMatches(string mailBody)
        {


            if (textBoxEditing.InvokeRequired)
            {
                textBoxEditing.Invoke(new Action(() =>
                {
                    ShowMatches(mailBody); 
                }));
            }
            else
            {

                textBoxEditing.Text = mailBody; 
                List<RemovedContentModel> position = cleanService.FindSubstrings(textBoxEditing.Text);

                foreach (RemovedContentModel p in position)
                {
                    textBoxEditing.Select(p.OriginalStartIndex, p.OriginalEndIndex - p.OriginalStartIndex);
                    textBoxEditing.SelectionBackColor = Color.DarkGray;
                    textBoxEditing.SelectionColor = Color.White;

                }

            }
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

        private void UpdateMailCounter()
        {
            int mailCount = emailBasicInfoService.CountMessages(individualMails);
            int specificMailCount = currentIndex + 1;
            lbMailCounter.Text = specificMailCount + "/" + mailCount + " Mails";

        }

        private void ManualEditingForm_Resize(object sender, EventArgs e)
        {
            TextPanel.Width = this.Width - TextPanel.Left - SystemInformation.VerticalScrollBarWidth;
            TextPanel.Height = this.Height - TextPanel.Top - SystemInformation.HorizontalScrollBarHeight;

            listViewLabels.Height = this.Height - listViewLabels.Top - SystemInformation.HorizontalScrollBarHeight;
        }

        private void btnAddLabel_Click(object sender, EventArgs e)
        {
            string selectedValue = DDLabels.SelectedItem?.ToString();

            if (ChoosenLabels.Count > 5)
            {
                MessageBox.Show("Label limit reached.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (!string.IsNullOrEmpty(selectedValue))
                {
                    if (!ChoosenLabels.Contains(selectedValue))
                    {
                        ChoosenLabels.Add(selectedValue);
                        ShowList(ChoosenLabels);

                    }
                    else
                    {
                        MessageBox.Show("Can't add same Label twice", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }


                }
            }

        }

        private void btnNextMail_Click(object sender, EventArgs e)
        {
            if (commited)
            {
                var copiedLabels = new List<string>(ChoosenLabels);
                LabeledMessages.Add(labelingService.AddMessageWithLabels(individualMails[currentIndex], copiedLabels));
                ChoosenLabels.Clear();
                individualMails[currentIndex].body = textBoxEditing.Text;
                currentIndex = Math.Min(individualMails.Count - 1, currentIndex + 1);
                commited = false;
                DisplayText();
                UpdateMailCounter();
                ShowList(ChoosenLabels);
            }
            else
            {

                MessageBox.Show("Please commit changes before continuing", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnCommit_Click(object sender, EventArgs e)
        {
            List<RemovedContentModel> _deleteList = new List<RemovedContentModel>();
            List<RemovedContentModel> substrings = cleanService.FindSubstrings(textBoxEditing.Text);
            foreach (RemovedContentModel substring in substrings)
            {
                textBoxEditing.Select(substring.OriginalStartIndex, substring.OriginalEndIndex - substring.OriginalStartIndex);
                if (textBoxEditing.SelectionBackColor == Color.DarkGray)
                {
                    _deleteList.Add(new RemovedContentModel(substring.Content, substring.OriginalStartIndex, substring.OriginalEndIndex));
                }

            }
            individualMails[currentIndex].body = cleanService.DeleteStringsFromText(textBoxEditing.Text, _deleteList);
            commited = true;
            DisplayText();
            textBoxEditing.ReadOnly = false;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if(currentIndex +1 == individualMails.Count)
            {
                List<ThreadModel> MessagesSeperatedIntoThreads = labelingService.CreateThreads(LabeledMessages);
                ManualConvertForm convert = new ManualConvertForm(MessagesSeperatedIntoThreads);
                OpenChildForm(convert, this);

            }
            else
            {
                MessageBox.Show("Finish all mails before continuing", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        private void btnBackMail_Click(object sender, EventArgs e)
        {
            currentIndex = Math.Max(0, currentIndex - 1);
            UpdateMailCounter();
            DisplayText();
        }

        private void textBoxEditing_MouseUp(object sender, MouseEventArgs e)
        {
            if (commited == false)
            {


                RichTextBox richTextBox = (RichTextBox)sender;

                int clickedIndex = richTextBox.GetCharIndexFromPosition(e.Location);

                string text = richTextBox.Text;
                List<RemovedContentModel> substrings = cleanService.FindSubstrings(text);

                bool foundSubstring = false;

                foreach (var substring in substrings)
                {
                    if (clickedIndex >= substring.OriginalStartIndex && clickedIndex <= substring.OriginalEndIndex)
                    {
                        richTextBox.Select(substring.OriginalStartIndex, substring.OriginalEndIndex - substring.OriginalStartIndex);
                        if (richTextBox.SelectionBackColor == Color.Gray)
                        {
                            richTextBox.SelectionBackColor = Color.DarkGray;
                        }
                        else
                        {
                            richTextBox.SelectionBackColor = Color.Gray;
                        }
                        richTextBox.DeselectAll();
                        foundSubstring = true;
                        break;
                    }
                }

                if (!foundSubstring)
                {
                    richTextBox.DeselectAll();
                }
            }
        }


    }
}
