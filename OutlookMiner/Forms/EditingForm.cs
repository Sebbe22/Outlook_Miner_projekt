using iTextSharp.xmp.impl;
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
    public partial class EditingForm : Form
    {
        List<IndividualMailText> mails;
        IManualLabelService labelingService = ManualLabelService.GetInstance();
        List<String> ChoosenLabels = new List<string>();
        List<IndividualMailTextLabelingModel> LabeledMessages = new List<IndividualMailTextLabelingModel>();

        private int currentIndex = 0;


        public EditingForm(List<IndividualMailText> _mails)
        {
            InitializeComponent();
            mails = _mails;
            DisplayText();
            List<string> currentLabels = labelingService.Labels;
            DDLabels.Items.AddRange(currentLabels.ToArray());
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
                textBoxEditing.Text = mails[currentIndex].body;
            }

        }

        private void lbNextMail_Click(object sender, EventArgs e)
        {
            LabeledMessages = labelingService.AddMessageWithLabels(LabeledMessages,mails[currentIndex], ChoosenLabels);
            currentIndex = Math.Min(mails.Count - 1, currentIndex + 1);
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
            List <ThreadModel> MessagesSeperatedIntoThreads = labelingService.CreateThreads(LabeledMessages);
            ConvertForm formWithThreadModelList = ConvertForm.WithThreadModelList(pathUtilityService,MessagesSeperatedIntoThreads);
            formWithThreadModelList.Show();
            this.Hide();

        }
    }
}
