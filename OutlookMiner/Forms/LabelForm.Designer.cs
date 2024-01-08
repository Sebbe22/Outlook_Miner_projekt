namespace OutlookMiner.Forms
{
    partial class LabelForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LabelForm));
            panelButtons = new Panel();
            btnRefresh = new Button();
            btnAddLabel = new Button();
            btnDelete = new Button();
            panelLabelOversight = new Panel();
            dataGridLabels = new DataGridView();
            panelButtons.SuspendLayout();
            panelLabelOversight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridLabels).BeginInit();
            SuspendLayout();
            // 
            // panelButtons
            // 
            panelButtons.Controls.Add(btnRefresh);
            panelButtons.Controls.Add(btnAddLabel);
            panelButtons.Controls.Add(btnDelete);
            panelButtons.Dock = DockStyle.Top;
            panelButtons.Location = new Point(0, 0);
            panelButtons.Name = "panelButtons";
            panelButtons.Size = new Size(866, 125);
            panelButtons.TabIndex = 0;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.Transparent;
            btnRefresh.BackgroundImage = (Image)resources.GetObject("btnRefresh.BackgroundImage");
            btnRefresh.BackgroundImageLayout = ImageLayout.Zoom;
            btnRefresh.FlatAppearance.BorderSize = 0;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Location = new Point(30, 82);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(47, 37);
            btnRefresh.TabIndex = 2;
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnAddLabel
            // 
            btnAddLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAddLabel.FlatStyle = FlatStyle.Flat;
            btnAddLabel.Location = new Point(425, 82);
            btnAddLabel.Name = "btnAddLabel";
            btnAddLabel.Size = new Size(175, 37);
            btnAddLabel.TabIndex = 1;
            btnAddLabel.Text = "Add Label";
            btnAddLabel.UseVisualStyleBackColor = true;
            btnAddLabel.Click += btnAddLabel_Click;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Location = new Point(630, 82);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(174, 37);
            btnDelete.TabIndex = 0;
            btnDelete.Text = "Delete Label";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // panelLabelOversight
            // 
            panelLabelOversight.Controls.Add(dataGridLabels);
            panelLabelOversight.Dock = DockStyle.Fill;
            panelLabelOversight.Location = new Point(0, 125);
            panelLabelOversight.Name = "panelLabelOversight";
            panelLabelOversight.Size = new Size(866, 456);
            panelLabelOversight.TabIndex = 1;
            // 
            // dataGridLabels
            // 
            dataGridLabels.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridLabels.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridLabels.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridLabels.Dock = DockStyle.Fill;
            dataGridLabels.Location = new Point(0, 0);
            dataGridLabels.Name = "dataGridLabels";
            dataGridLabels.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridLabels.RowHeadersWidth = 51;
            dataGridLabels.RowTemplate.Height = 29;
            dataGridLabels.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridLabels.Size = new Size(866, 456);
            dataGridLabels.TabIndex = 0;
            // 
            // LabelForm
            // 
            ClientSize = new Size(866, 581);
            Controls.Add(panelLabelOversight);
            Controls.Add(panelButtons);
            Name = "LabelForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Label Management";
            panelButtons.ResumeLayout(false);
            panelLabelOversight.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridLabels).EndInit();
            ResumeLayout(false);
        }
        #endregion

        private Panel panelButtons;
        private Panel panelLabelOversight;
        private DataGridView dataGridLabels;
        private Button btnDelete;
        private Button btnAddLabel;
        private Button btnRefresh;
    }

}



