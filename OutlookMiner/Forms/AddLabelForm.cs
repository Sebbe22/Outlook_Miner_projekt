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
    public partial class AddLabelForm : Form
    {
        ILabelService labelService;
        List<string> searchWords = new List<String>();
        public AddLabelForm()
        {
            labelService = new LabelService();
            InitializeComponent();
            PopulateCategories();
            PopulateSearchWords(searchWords);
            LoadTheme();
            cbCategory.DropDownStyle = ComboBoxStyle.DropDown;
            cbCategory.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbCategory.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbCategory.KeyDown += cbCategory_KeyDown;
            cbSearchWords.KeyDown += cbSearchWords_KeyDown;
        }

        private void LoadTheme()
        {
            foreach (Control btns in Controls)
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
            lbHeader.ForeColor = ThemeColor.ChangeColorBrightness(ThemeColor.SecondaryColor, -0.1);
            lbCategory.ForeColor = ThemeColor.ChangeColorBrightness(ThemeColor.SecondaryColor, -0.1);
            lbLabelName.ForeColor = ThemeColor.ChangeColorBrightness(ThemeColor.SecondaryColor, -0.1);
            lbSearchWords.ForeColor = ThemeColor.ChangeColorBrightness(ThemeColor.SecondaryColor, -0.1);


        }

        private void PopulateSearchWords(List<string> searchWords)
        {


            foreach (string searchWord in searchWords)
            {
                cbSearchWords.Items.Add(searchWord);
            }

            cbSearchWords.Items.Add("+ Add new Search Word");


            cbSearchWords.SelectedIndex = 0;
        }

        private void PopulateCategories()
        {
            List<Models.LabelModel> categoryList = new List<Models.LabelModel>(labelService.GetLabels());

            foreach (Models.LabelModel category in categoryList)
            {

                if (!cbCategory.Items.Contains(category.Category))
                {
                    cbCategory.Items.Add(category.Category);
                }

            }


            cbCategory.Items.Add("+ Add new Category");

            cbCategory.SelectedIndex = 0;
        }
        private void cbCategory_DrawItem(object sender, DrawItemEventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            if (e.Index >= 0)
            {
                Brush brush;
                if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
                {
                    brush = SystemBrushes.HighlightText;
                }
                else
                {
                    brush = SystemBrushes.WindowText;
                }

                string itemText = comboBox.Items[e.Index].ToString();


                if (e.Index == comboBox.Items.Count - 1)
                {
                    brush = Brushes.Red;
                }

                e.DrawBackground();
                e.Graphics.DrawString(itemText, e.Font, brush, e.Bounds);
                e.DrawFocusRectangle();
            }


        }

        private void cbSearchWords_DrawItem(object sender, DrawItemEventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            if (e.Index >= 0)
            {
                Brush brush;
                if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
                {
                    brush = SystemBrushes.HighlightText;
                }
                else
                {
                    brush = SystemBrushes.WindowText;
                }

                string itemText = comboBox.Items[e.Index].ToString();


                if (e.Index == comboBox.Items.Count - 1)
                {
                    brush = Brushes.Red;
                }

                e.DrawBackground();
                e.Graphics.DrawString(itemText, e.Font, brush, e.Bounds);
                e.DrawFocusRectangle();
            }


        }



        private void cbCategory_KeyDown(object sender, KeyEventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;

            if (comboBox.Text == "+ Add new Category" && e.KeyCode == Keys.Enter)
            {

                comboBox.Text = "";
                e.SuppressKeyPress = true;
                return;
            }

            if (e.KeyCode == Keys.Enter && !comboBox.Items.Contains(comboBox.Text) && comboBox.Text != "")
            {
                comboBox.Items.Insert(comboBox.Items.Count - 1, comboBox.Text);
                comboBox.SelectedIndex = comboBox.Items.Count - 2;
                comboBox.Text = "";
                e.SuppressKeyPress = true;
            }
        }

        private void cbSearchWords_KeyDown(object sender, KeyEventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;

            if (comboBox.Text == "+ Add new Search Word" && e.KeyCode == Keys.Enter)
            {

                comboBox.Text = "";
                e.SuppressKeyPress = true;
                return;
            }

            if (e.KeyCode == Keys.Enter && !comboBox.Items.Contains(comboBox.Text) && comboBox.Text != "")
            {
                comboBox.Items.Insert(comboBox.Items.Count - 1, comboBox.Text);
                comboBox.SelectedIndex = comboBox.Items.Count - 2;
                comboBox.Text = "";
                e.SuppressKeyPress = true;
            }
        }

        private void btnAddLabel_Click(object sender, EventArgs e)
        {
            string labelText = textboxLabelName.Text;
            string selectedCategory = cbCategory.SelectedItem.ToString();
            List<String> searchWords = new List<String>();
            foreach (var item in cbSearchWords.Items)
            {
                if (item.ToString() != "+ Add new Search Word")
                {
                    searchWords.Add(item.ToString());
                }

            }
            if (searchWords.Count < 1) { MessageBox.Show("No search words were entered ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            else if (selectedCategory == null) { MessageBox.Show("No category was assigned ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            else
            {
                foreach (string searchWord in searchWords)
                {
                    Models.LabelModel label = new Models.LabelModel(selectedCategory, labelText, searchWord);
                    labelService.InsertLabel(label);

                }

                this.Close();
            }


        }

     
    }
}
