namespace OutlookMiner.Forms
{
    partial class AddLabelForm
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

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            cbCategory = new ComboBox();
            lbCategory = new Label();
            textboxLabelName = new TextBox();
            cbSearchWords = new ComboBox();
            lbLabelName = new Label();
            lbSearchWords = new Label();
            btnAddLabel = new Button();
            lbHeader = new Label();
            SuspendLayout();
            // 
            // cbCategory
            // 
            cbCategory.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cbCategory.DrawMode = DrawMode.OwnerDrawVariable;
            cbCategory.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cbCategory.FormattingEnabled = true;
            cbCategory.Location = new Point(23, 145);
            cbCategory.Name = "cbCategory";
            cbCategory.Size = new Size(231, 26);
            cbCategory.TabIndex = 0;
            cbCategory.DrawItem += cbCategory_DrawItem;

            // 
            // lbCategory
            // 
            lbCategory.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbCategory.AutoSize = true;
            lbCategory.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lbCategory.Location = new Point(23, 103);
            lbCategory.Name = "lbCategory";
            lbCategory.Size = new Size(85, 20);
            lbCategory.TabIndex = 1;
            lbCategory.Text = "Category";
            // 
            // textboxLabelName
            // 
            textboxLabelName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textboxLabelName.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textboxLabelName.Location = new Point(281, 145);
            textboxLabelName.Name = "textboxLabelName";
            textboxLabelName.Size = new Size(231, 25);
            textboxLabelName.TabIndex = 2;
            // 
            // cbSearchWords
            // 
            cbSearchWords.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cbSearchWords.DrawMode = DrawMode.OwnerDrawVariable;
            cbSearchWords.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cbSearchWords.FormattingEnabled = true;
            cbSearchWords.Location = new Point(549, 144);
            cbSearchWords.Name = "cbSearchWords";
            cbSearchWords.Size = new Size(231, 26);
            cbSearchWords.TabIndex = 3;
            cbSearchWords.DrawItem += cbSearchWords_DrawItem;
            // 
            // lbLabelName
            // 
            lbLabelName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbLabelName.AutoSize = true;
            lbLabelName.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lbLabelName.Location = new Point(281, 103);
            lbLabelName.Name = "lbLabelName";
            lbLabelName.Size = new Size(107, 20);
            lbLabelName.TabIndex = 4;
            lbLabelName.Text = "Label Name";
            // 
            // lbSearchWords
            // 
            lbSearchWords.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbSearchWords.AutoSize = true;
            lbSearchWords.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lbSearchWords.Location = new Point(549, 103);
            lbSearchWords.Name = "lbSearchWords";
            lbSearchWords.Size = new Size(315, 20);
            lbSearchWords.TabIndex = 5;
            lbSearchWords.Text = "Search Words for Automatic Labeling";
            // 
            // btnAddLabel
            // 
            btnAddLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAddLabel.FlatStyle = FlatStyle.Flat;
            btnAddLabel.Location = new Point(671, 227);
            btnAddLabel.Name = "btnAddLabel";
            btnAddLabel.Size = new Size(160, 37);
            btnAddLabel.TabIndex = 6;
            btnAddLabel.Text = "Create Label";
            btnAddLabel.UseVisualStyleBackColor = true;
            btnAddLabel.Click += btnAddLabel_Click;
            // 
            // lbHeader
            // 
            lbHeader.AutoSize = true;
            lbHeader.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbHeader.Location = new Point(26, 35);
            lbHeader.Name = "lbHeader";
            lbHeader.Size = new Size(209, 23);
            lbHeader.TabIndex = 7;
            lbHeader.Text = "Label Creation Form";
            // 
            // AddLabelForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(875, 276);
            Controls.Add(lbHeader);
            Controls.Add(btnAddLabel);
            Controls.Add(lbSearchWords);
            Controls.Add(lbLabelName);
            Controls.Add(cbSearchWords);
            Controls.Add(textboxLabelName);
            Controls.Add(lbCategory);
            Controls.Add(cbCategory);
            Name = "AddLabelForm";
            Text = "e";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbCategory;
        private Label lbCategory;
        private TextBox textboxLabelName;
        private ComboBox cbSearchWords;
        private Label lbLabelName;
        private Label lbSearchWords;
        private Button btnAddLabel;
        private Label lbHeader;
    }
}