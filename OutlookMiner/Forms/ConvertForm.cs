using ceTe.DynamicPDF.Text;
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

namespace OutlookMiner.Forms
{
    public partial class ConvertForm : Form
    {
       private IPathUtilityService _pathUtilityService;
        public static ConvertForm instance;
        private List<Text> mails;

        public ConvertForm(IPathUtilityService pathUtilityService, List<Text> _mails)
        {
            InitializeComponent();
            _pathUtilityService = pathUtilityService;
            this.mails = _mails;
            instance = this;
        }

        private void lbGoToStart_Click(object sender, EventArgs e)
        {
            this.Close();
            CleanUpForm.instance.Close();
            //Form1 back = new Form1();
            Form1.instance.Show();
        }

        private void btBack_Click(object sender, EventArgs e)
        {
            this.Close();
            CleanUpForm cleanUpForm = new CleanUpForm(mails);
            cleanUpForm.Show();
        }

        private void btConvertFile_Click(object sender, EventArgs e)
        {
            ILoadService load = new LoadService();
            ICleanService clean = new CleanService();
            IConvertService convert = new ConvertServicePDF();

            List<CheckBoxModel> listOfCheckBoxes = new List<CheckBoxModel>()
            {
                new CheckBoxModel("RemoveLinksFromEmailString", CleanUpForm.instance.checkBox2.Checked),
                new CheckBoxModel("RemoveEmailsFromEmailString", CleanUpForm.instance.checkBox4.Checked),
            };


            foreach (var checkbox in listOfCheckBoxes)
            {
                Type type = typeof(CleanService);
                MethodInfo methodInfo = type.GetMethod(checkbox.methodName);
                if (methodInfo != null)
                {
                    object instance = Activator.CreateInstance(type);

                    if (checkbox.isChecked)
                    {
                        object[] parameters = new object[] { mails };
                        mails = (List<Text>?)methodInfo.Invoke(instance, parameters);
                    }
                }
            }

            string selectedFilePathInputFile = Form1.instance.lbFileChosen.Text;
            string selectedFilePath = _pathUtilityService.SavePath("pdf");
            convert.Convert(selectedFilePath, mails);            
        }
    }
}
