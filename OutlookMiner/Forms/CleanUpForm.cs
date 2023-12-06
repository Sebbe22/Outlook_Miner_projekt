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
    public partial class CleanUpForm : Form
    {
        public static CleanUpForm instance;
        private List<IndividualMailText> mails;
        private ICheckBoxService _checkboxList;

        public ICheckBoxService GetCheckBoxListModelInstance()
        {
            return _checkboxList;
        }

        public CleanUpForm(List<IndividualMailText> _mails)
        {
            InitializeComponent();
            instance = this;
            this.mails = _mails;
            this._checkboxList = CheckBoxService.Instance;
        }

        private void lbBack_Click(object sender, EventArgs e)
        {
            this.Close();
            // Form1 back = new Form1();
            Form1.instance.Show();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            IPathUtilityService pathUtilityService = new PathUtilityService();
            ConvertForm convertForm = ConvertForm.WithTextList(pathUtilityService, mails);
            convertForm.Show();
            this.Hide();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            CleanUpForm.instance = this;
            string targetName = "RemoveLinksFromEmailString";

            _checkboxList.UpdateCheckBox(targetName, CleanUpForm.instance.checkBox2.Checked);

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            CleanUpForm.instance = this;
            string targetName = "RemoveEmailsFromEmailString";

            _checkboxList.UpdateCheckBox(targetName, CleanUpForm.instance.checkBox4.Checked);

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            CleanUpForm.instance = this;
            string targetName = "RemoveSenderAndRecieverNameFromEmail";

            _checkboxList.UpdateCheckBox(targetName, CleanUpForm.instance.checkBox1.Checked);
        }

        private void CBRemovePhoneNumbers_CheckedChanged(object sender, EventArgs e)
        {
            CleanUpForm.instance = this;
            string targetName = "RemovePhoneNumbersFromEmail";

            _checkboxList.UpdateCheckBox(targetName, CleanUpForm.instance.CBRemovePhoneNumbers.Checked);
        }

        private void CBRemoveAfterBestRegards_CheckedChanged(object sender, EventArgs e)
        {
            CleanUpForm.instance = this;
            string targetName = "RemoveEverythingPastBestRegards";

            _checkboxList.UpdateCheckBox(targetName, CleanUpForm.instance.CBRemoveAfterBestRegards.Checked);

        }


        private void btContinueToLabeling_Click(object sender, EventArgs e)
        {
            EditingForm newForm = new EditingForm(mails);
            newForm.Show();
            this.Hide();
        }

        
    }
}
