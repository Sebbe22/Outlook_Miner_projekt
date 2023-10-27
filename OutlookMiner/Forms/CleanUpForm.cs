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
        public CleanUpForm()
        {
            InitializeComponent();
        }

        private void lbBack_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 back = new Form1();
            back.Show();
        }

        private void btNext_Click(object sender, EventArgs e)
        {
            ConvertForm convertForm = new ConvertForm();
            convertForm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConvertForm convertForm = new ConvertForm();
            convertForm.Show();
            this.Hide();
        }
    }
}
