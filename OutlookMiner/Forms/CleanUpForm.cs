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

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            CleanUpForm.instance = this;
            string targetName = "RemovePhoneNumbersFromEmail";

            _checkboxList.UpdateCheckBox(targetName, CleanUpForm.instance.checkBox3.Checked);
        }

        private void lbHeader_Click(object sender, EventArgs e)
        {

        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            CleanUpForm.instance = this;
            string targetName = "RemovePasswordAndUserNameFromEmail";
            _checkboxList.UpdateCheckBox(targetName, CleanUpForm.instance.checkBox6.Checked);
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            CleanUpForm.instance = this;
            foreach(CheckBoxModel checkBox in _checkboxList.GetCheckBoxes())
            {
                _checkboxList.UpdateCheckBox(checkBox.methodName, CleanUpForm.instance.checkBox8.Checked);
            }
        }
    }
}
