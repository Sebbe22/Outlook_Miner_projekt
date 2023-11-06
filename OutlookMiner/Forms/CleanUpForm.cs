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
        private List<Text> mails;


        public CleanUpForm(List<Text> _mails)
        {
            InitializeComponent();
            instance = this;
            this.mails = _mails;
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
            ConvertForm convertForm = new ConvertForm(pathUtilityService, mails);
            convertForm.Show();
            this.Hide();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            CleanUpForm.instance = this;
            bool hello = CleanUpForm.instance.checkBox2.Checked;

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            CleanUpForm.instance = this;
            bool removeMails = CleanUpForm.instance.checkBox4.Checked;
        }

        
    }
}
