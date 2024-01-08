using ceTe.DynamicPDF.Forms;
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
using Form = System.Windows.Forms.Form;

namespace OutlookMiner.Forms
{
    public partial class LabelForm : Form
    {
        private ILabelService labelService;
        private List<LabelModel> labels;


        public LabelForm(StartUpForm startUp)
        {

            this.SuspendLayout(); 
            InitializeComponent();
            labelService = new LabelService();
            PopulateDataGrid();
            LoadTheme();
            this.DoubleBuffered = true;
            this.ResumeLayout();
            btnRefresh.BackgroundImageLayout = ImageLayout.Zoom;


        }
        private void PopulateDataGrid()
        {
            
            labels = new List<LabelModel>(labelService.GetLabels()); 

            dataGridLabels.DataSource = labels;
            dataGridLabels.Dock = DockStyle.Fill;
            this.dataGridLabels.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridLabels.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridLabels.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridLabels.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

        }

        private void LoadTheme()
        {

            
            foreach (Control ctrl in panelButtons.Controls)
            {
                if (ctrl is Button)
                {
                    Button btn = (Button)ctrl;
                    btn.BackColor = ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                }
            }
            btnRefresh.BackColor = Color.Transparent;

            dataGridLabels.BackgroundColor = ThemeColor.ChangeColorBrightness(ThemeColor.PrimaryColor, +1);
            dataGridLabels.EnableHeadersVisualStyles = false;
            dataGridLabels.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridLabels.ColumnHeadersDefaultCellStyle.ForeColor = Color.White; // Change the font color
            dataGridLabels.ColumnHeadersDefaultCellStyle.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.PrimaryColor, +0.5); // Change the background color
            dataGridLabels.RowHeadersDefaultCellStyle.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.PrimaryColor, +0.5);
            dataGridLabels.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridLabels.GridColor = ThemeColor.ChangeColorBrightness(ThemeColor.SecondaryColor, +0.3);
            dataGridLabels.DefaultCellStyle.ForeColor = ThemeColor.SecondaryColor;
            dataGridLabels.ColumnHeadersDefaultCellStyle.SelectionBackColor = ThemeColor.ChangeColorBrightness(ThemeColor.PrimaryColor, +0.5);
            dataGridLabels.RowHeadersDefaultCellStyle.SelectionBackColor = ThemeColor.ChangeColorBrightness(ThemeColor.PrimaryColor, +0.5);
            dataGridLabels.DefaultCellStyle.SelectionBackColor = ThemeColor.ChangeColorBrightness(ThemeColor.PrimaryColor, +0.1);
            dataGridLabels.DefaultCellStyle.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        
            dataGridLabels.RowPrePaint += (sender, e) =>
            {
                if (e.RowIndex % 2 == 0)
                {
                    
                    dataGridLabels.Rows[e.RowIndex].DefaultCellStyle.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.PrimaryColor, +0.9);
                }
                else
                {
                    
                    dataGridLabels.Rows[e.RowIndex].DefaultCellStyle.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.PrimaryColor, +1);
                }


            };



        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            int selectedID;
            string selectedCategory;
            string selectedLabelName;
            string selectedLabelSearchWords = "";
            if (dataGridLabels.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this item?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    DataGridViewRow selectedRow = dataGridLabels.SelectedRows[0];

                    selectedID = Convert.ToInt32(selectedRow.Cells[0].Value);
                    selectedCategory = selectedRow.Cells[1].Value.ToString();
                    selectedLabelName = selectedRow.Cells[2].Value.ToString();
                    if (selectedRow.Cells[3].Value.ToString() != null)
                    {
                        selectedLabelSearchWords = selectedRow.Cells[3].Value.ToString();
                    }





                    LabelModel labelToDelete = new LabelModel(selectedID, selectedCategory, selectedLabelName, selectedLabelSearchWords);

                    bool success = labelService.DeleteLabel(labelToDelete);

                    PopulateDataGrid();
                    if (success)
                    {
                        
                        PopulateDataGrid();

                    }
                    else
                    {
                        MessageBox.Show("Failed to delete the item.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.");
            }
        }
        private void AddLabelFormClosed(object sender, FormClosedEventArgs e)
        {
            PopulateDataGrid();
        }

        private void btnAddLabel_Click(object sender, EventArgs e)
        {
            AddLabelForm addLabel = new AddLabelForm();
            addLabel.Show();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            PopulateDataGrid();
        }
    }

}
