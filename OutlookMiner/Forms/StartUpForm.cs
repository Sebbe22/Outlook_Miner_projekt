using OutlookMiner.Models;
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
    public partial class StartUpForm : Form
    {
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form ActiveForm;
        List<IndividualMailText> mails = new List<IndividualMailText>();
        public StartUpForm()
        {
            InitializeComponent();
            random = new Random();
            this.DoubleBuffered = true;
        }


        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while (tempIndex == index)
            {
                index = random.Next(ThemeColor.ColorList.Count);

            }
            tempIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);

        }

        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                    panelHeader.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    ThemeColor.PrimaryColor = color;
                    ThemeColor.SecondaryColor = ThemeColor.ChangeColorBrightness(color, -0.3);

                }
            }

        }
        private void DisableButton()
        {
            foreach (Control previousBtn in panel1.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                }
            }


        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (ActiveForm != null)
            {
                ActiveForm.Close();
            }
            ActivateButton(btnSender);
            ActiveForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.PanelChildForm.Controls.Add(childForm);
            this.PanelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.SuspendLayout(); 
            ActivateButton(sender);
            OpenChildForm(new Forms.AutomaticCleanupForm(this), sender);
            lbHeader.Text = "Automatic Clean up";
            this.ResumeLayout();




        }

        private void button2_Click(object sender, EventArgs e)
        {

            ActivateButton(sender);
            OpenChildForm(new Forms.ManualCleanupForm(this), sender);
            lbHeader.Text = "Manual Clean up";


        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.SuspendLayout(); 
            ActivateButton(sender);
            OpenChildForm(new Forms.LabelForm(this), sender);
            this.ResumeLayout(); 
            lbHeader.Text = "Label Management";

        }

        private void btnCloseForms_Click(object sender, EventArgs e)
        {
            if (ActiveForm != null)
            {
                ActiveForm.Close();
                ActiveForm = null; 
                DisableButton();
                panelHeader.BackColor = Color.FromArgb(0, 150, 136);
                lbHeader.Text = "Dashboard";
            }
        }

        private void lbAutoCleanDescription_Click(object sender, EventArgs e)
        {

        }
    }
}
