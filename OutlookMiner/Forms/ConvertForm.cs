﻿using ceTe.DynamicPDF.Text;
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
       
        private ICheckBoxService _checkboxList;

        public ICheckBoxService GetCheckBoxListModelInstance()
        {
            return _checkboxList;
        }


        public ConvertForm(IPathUtilityService pathUtilityService, List<Text> _mails)
        {
            InitializeComponent();
            _pathUtilityService = pathUtilityService;
            this.mails = _mails;
            this._checkboxList = CheckBoxService.Instance;

            instance = this;
            lbFeedbackMessage.Hide();
            pbLoadingGif.Hide();
            lbShowingStatus.Hide();
            
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
            string selectedFilePathInputFile = Form1.instance.lbFileChosen.Text;
            string selectedFilePath = _pathUtilityService.SavePath("pdf");
            pbLoadingGif.Visible = true;
            lbShowingStatus.Visible = true;
            BackgroundWorker backgroundWorker = new BackgroundWorker();
            backgroundWorker.DoWork += (sender, eArgs) =>
            {
                List<CheckBoxModel> checkBoxes = _checkboxList.GetCheckBoxes(); 
                foreach(var checkbox in checkBoxes)
                {
                    Type type = typeof(CleanService);
                    MethodInfo methodInfo = type.GetMethod(checkbox.methodName);
                    if(methodInfo != null)
                    {
                        object instance = Activator.CreateInstance(type);
                        if (checkbox.isChecked)
                        {
                            object[] parameters = new object[] { mails };
                            mails = (List<Text>?)methodInfo.Invoke(instance, parameters);
                        }
                    }

                }

                convert.Convert(selectedFilePath, mails);

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

                lbFeedbackMessage.Show();
                // Hide the loading GIF
                pbLoadingGif.Visible = false;
                lbShowingStatus.Visible = false;


            };

            // Start the background worker
            backgroundWorker.RunWorkerAsync();

                 
        }

        private void ConvertForm_Load(object sender, EventArgs e)
        {

        }


    }
}
