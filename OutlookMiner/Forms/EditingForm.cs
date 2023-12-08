using iTextSharp.xmp.impl;
using OutlookMiner.Models;
using OutlookMiner.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace OutlookMiner.Forms
{
    public partial class EditingForm : Form
    {
        List<IndividualMailText> mails;
        IManualLabelService labelingService = ManualLabelService.GetInstance();
        ICleanManualService cleanService = new CleanManualService();
        List<String> ChoosenLabels = new List<string>();
        List<IndividualMailTextLabelingModel> LabeledMessages = new List<IndividualMailTextLabelingModel>();
        private ICheckBoxService _checkboxList;

        private int currentIndex = 0;
        private bool commited = false;
        public ICheckBoxService GetCheckBoxListModelInstance()
        {
            return _checkboxList;
        }

        public EditingForm(List<IndividualMailText> _mails)
        {
            InitializeComponent();
            textBoxEditing.SelectionProtected = true;
            textBoxEditing.Visible = false;
            btAddLabel.Visible = false;
            DDLabels.Visible = false;

            pbLoadingGif.Visible = true;
            lbShowingStatus.Visible = true;

            BackgroundWorker backgroundWorker = new BackgroundWorker();
            backgroundWorker.DoWork += (sender, eArgs) =>
            {
                this._checkboxList = CheckBoxService.Instance;

                mails = _mails;

                List<string> currentLabels = labelingService.Labels;
                DDLabels.Items.AddRange(currentLabels.ToArray());

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

                // Pass the results to the RunWorkerCompleted event
                eArgs.Result = new
                {

                };

            };
            // Handle the completion of the work
            backgroundWorker.RunWorkerCompleted += (sender, eArgs) =>
            {
                // Retrieve the results from the DoWork event
                var result = (dynamic)eArgs.Result;

                //Show the editing software
                textBoxEditing.Visible = true;
                btAddLabel.Visible = true;
                DDLabels.Visible = true;
                // Hide the loading GIF
                pbLoadingGif.Visible = false;
                lbShowingStatus.Visible = false;
                DisplayText();
            };
            // Start the background worker
            backgroundWorker.RunWorkerAsync();

        }

        private void btBackMail_Click(object sender, EventArgs e)
        {
            currentIndex = Math.Max(0, currentIndex - 1);
            DisplayText();
        }

        private void DisplayText()
        {
            if (mails.Count > 0 && currentIndex >= 0 && currentIndex < mails.Count)
            {
                if (commited == false)
                {
                    ShowMatches(mails[currentIndex].body);
                }
                else
                {
                    textBoxEditing.Text = mails[currentIndex].body;
                }

            }
        }

        private void lbNextMail_Click(object sender, EventArgs e)
        {
            var copiedLabels = new List<string>(ChoosenLabels);
            LabeledMessages.Add(labelingService.AddMessageWithLabels(mails[currentIndex], copiedLabels));
            ChoosenLabels.Clear();
            mails[currentIndex].body = textBoxEditing.Text;
            currentIndex = Math.Min(mails.Count - 1, currentIndex + 1);
            commited = false;
            DisplayText();
        }



        private void btAddLabel_Click(object sender, EventArgs e)
        {
            string selectedValue = DDLabels.SelectedItem?.ToString();

            if (!string.IsNullOrEmpty(selectedValue))
            {

                ChoosenLabels.Add(selectedValue);
            }
        }

        private void btNext_Click(object sender, EventArgs e)
        {
            IPathUtilityService pathUtilityService = new PathUtilityService();
            List<ThreadModel> MessagesSeperatedIntoThreads = labelingService.CreateThreads(LabeledMessages);
            ConvertForm formWithThreadModelList = ConvertForm.WithThreadModelList(pathUtilityService, MessagesSeperatedIntoThreads);
            formWithThreadModelList.Show();
            this.Hide();

        }


        private void ShowMatches(string mailBody)
        {


            if (textBoxEditing.InvokeRequired)
            {
                textBoxEditing.Invoke(new Action(() =>
                {
                    ShowMatches(mailBody); // Invoke this method on the UI thread
                }));
            }
            else
            {

                textBoxEditing.Text = mailBody; // Set the entire text first
                List<RemovedContentModel> position = cleanService.FindSubstrings(textBoxEditing.Text);

                foreach (RemovedContentModel p in position)
                {
                    textBoxEditing.Select(p.OriginalStartIndex, p.OriginalEndIndex - p.OriginalStartIndex);
                    textBoxEditing.SelectionBackColor = Color.DarkGray;
                    textBoxEditing.SelectionColor = Color.White;

                }

            }
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

        private void button1_Click(object sender, EventArgs e)
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
            mails[currentIndex].body = cleanService.DeleteStringsFromText(textBoxEditing.Text, _deleteList);
            commited = true;
            DisplayText();
            textBoxEditing.ReadOnly = false;

        }

    
    }

}


