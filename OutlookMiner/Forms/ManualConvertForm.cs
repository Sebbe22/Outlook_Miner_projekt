
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
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OutlookMiner.Forms
{
    public partial class ManualConvertForm : Form
    {
        private IPathUtilityService _pathUtilityService;
        public static ManualConvertForm instance;
        private List<IndividualMailText> mails;
        private List<ThreadModel> threads;
        IManualLabelService labelingService = new ManualLabelService();
        private IAutomaticLabelingService _automaticLabelingService;
        private ICheckBoxService _checkboxList;
        IConvertService convert = new ConvertServicePDF();

        public ICheckBoxService GetCheckBoxListModelInstance()
        {
            return _checkboxList;
        }
        public ManualConvertForm(List<ThreadModel> _threads)
        {
            InitializeComponent();
            threads = _threads;
            _pathUtilityService = new PathUtilityService();
            LoadTheme();

            this._checkboxList = CheckBoxService.Instance;
            instance = this;
            lbFeedbackMessage.Hide();
            pbLoadingGif.Hide();
            lbShowingStatus.Hide();

        }
        private void LoadTheme()
        {
            foreach (Control btns in panel1.Controls)
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
            lbFeedbackMessage.ForeColor = ThemeColor.SecondaryColor;
            lbShowingStatus.ForeColor = ThemeColor.SecondaryColor;
        }
        private void btnConvertFile_Click(object sender, EventArgs e)
        {


            string selectedFilePath = _pathUtilityService.SavePath("pdf");
            pbLoadingGif.Visible = true;
            lbShowingStatus.Visible = true;
            BackgroundWorker backgroundWorker = new BackgroundWorker();
            backgroundWorker.DoWork += (sender, eArgs) =>
            {
                if (threads != null)
                {
                    string mailsJsonFormat = JsonSerializer.Serialize(threads);
                    convert.ConvertThreads(selectedFilePath, threads);
                }

                eArgs.Result = new
                {

                };

            };

            backgroundWorker.RunWorkerCompleted += (sender, eArgs) =>
            {

                var result = (dynamic)eArgs.Result;

                lbFeedbackMessage.Show();

                pbLoadingGif.Visible = false;
                lbShowingStatus.Visible = false;

            };


            backgroundWorker.RunWorkerAsync();
        }


    }


}
