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
    public partial class ManuelLabelingForm : Form
    {
        private int currentMessageIndex = 0;
        private List<IndividualMailText> mails;
        private List<String> selectedLabels = new List<string>();
        private List<IndividualMailTextLabelingModel> labeledMails = new List<IndividualMailTextLabelingModel>();
        IManualLabelingService labelingService;


        public ManuelLabelingForm(List<IndividualMailText> _mails)
        {
            InitializeComponent();
            mails = _mails;
            DisplayCurrentMessage();

            labelingService = ManualLabelingService.GetInstance();
            foreach (string label in labelingService.Labels)
            {
                cbLabels.Items.Add(label);
            }
        }
        private void DisplayCurrentMessage()
        {
            if (currentMessageIndex >= 0 && currentMessageIndex < mails.Count)
            {
                tbMail.Text = mails[currentMessageIndex].body;
            }
        }

        private void btNextMail_Click(object sender, EventArgs e)
        {
            if (currentMessageIndex < mails.Count - 1)
            {
                currentMessageIndex++;
                DisplayCurrentMessage();
            }
            labeledMails.Add(labelingService.AddMessageWithLabels(mails[currentMessageIndex], selectedLabels));
            if(currentMessageIndex < mails.Count - 1 == false)
            {
                btNextMail.Enabled = false;
                btNext.Enabled = true;

            }
            lbChoosenLabels.ClearSelected();
            

            selectedLabels.Clear();
        }

        private void btAddLabel_Click(object sender, EventArgs e)
        {
            // Check if an item is selected
            if (cbLabels.SelectedItem != null)
            {
                // Get the selected item as a string
                string selectedItem = cbLabels.SelectedItem.ToString();

                // Add the selected item to the list
                selectedLabels.Add(selectedItem);

               
                lbChoosenLabels.Items.Add(selectedItem);
            }
        }

        private void btNext_Click(object sender, EventArgs e)
        {
            labeledMails.Add(labelingService.AddMessageWithLabels(mails[currentMessageIndex], selectedLabels));
            List<ThreadModel> threads = labelingService.CreateThreads(labeledMails);
            string LabeledEmailsJsonFormat = labelingService.ConvertToJson(threads);
            IPathUtilityService pathUtilityService = new PathUtilityService();
            ConvertForm convertForm = new ConvertForm(pathUtilityService, LabeledEmailsJsonFormat);
            convertForm.Show();
            this.Hide();
        }
    }
}
