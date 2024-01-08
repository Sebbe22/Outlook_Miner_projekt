namespace OutlookMiner.Forms
{
    partial class ManualEditingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManualEditingForm));
            TextPanel = new Panel();
            pbLoadingGif = new PictureBox();
            textBoxEditing = new RichTextBox();
            panelHeadline = new Panel();
            lbMailCounter = new Label();
            lbHeader = new Label();
            LabelingPanel = new Panel();
            listViewLabels = new ListView();
            lbShowingStatus = new Label();
            btnNext = new Button();
            btnNextMail = new Button();
            btnBackMail = new Button();
            btnCommit = new Button();
            lbLabelsAdded = new Label();
            btnAddLabel = new Button();
            DDLabels = new ComboBox();
            TextPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbLoadingGif).BeginInit();
            panelHeadline.SuspendLayout();
            LabelingPanel.SuspendLayout();
            SuspendLayout();
            // 
            // TextPanel
            // 
            TextPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            TextPanel.BackColor = Color.Transparent;
            TextPanel.Controls.Add(pbLoadingGif);
            TextPanel.Controls.Add(textBoxEditing);
            TextPanel.Controls.Add(panelHeadline);
            TextPanel.ForeColor = Color.Black;
            TextPanel.Location = new Point(0, 0);
            TextPanel.Margin = new Padding(3, 2, 3, 2);
            TextPanel.Name = "TextPanel";
            TextPanel.Size = new Size(485, 431);
            TextPanel.TabIndex = 0;
            // 
            // pbLoadingGif
            // 
            pbLoadingGif.Anchor = AnchorStyles.Bottom;
            pbLoadingGif.Image = (Image)resources.GetObject("pbLoadingGif.Image");
            pbLoadingGif.Location = new Point(456, 121);
            pbLoadingGif.Margin = new Padding(4, 3, 4, 3);
            pbLoadingGif.Name = "pbLoadingGif";
            pbLoadingGif.Size = new Size(68, 161);
            pbLoadingGif.TabIndex = 28;
            pbLoadingGif.TabStop = false;
            // 
            // textBoxEditing
            // 
            textBoxEditing.BackColor = Color.Gainsboro;
            textBoxEditing.BorderStyle = BorderStyle.FixedSingle;
            textBoxEditing.Dock = DockStyle.Fill;
            textBoxEditing.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxEditing.Location = new Point(0, 116);
            textBoxEditing.Margin = new Padding(3, 2, 3, 2);
            textBoxEditing.Name = "textBoxEditing";
            textBoxEditing.ReadOnly = true;
            textBoxEditing.ShortcutsEnabled = false;
            textBoxEditing.Size = new Size(485, 315);
            textBoxEditing.TabIndex = 20;
            textBoxEditing.Text = "";
            textBoxEditing.MouseUp += textBoxEditing_MouseUp;
            // 
            // panelHeadline
            // 
            panelHeadline.Controls.Add(lbMailCounter);
            panelHeadline.Controls.Add(lbHeader);
            panelHeadline.Dock = DockStyle.Top;
            panelHeadline.Location = new Point(0, 0);
            panelHeadline.Margin = new Padding(3, 2, 3, 2);
            panelHeadline.Name = "panelHeadline";
            panelHeadline.Size = new Size(485, 116);
            panelHeadline.TabIndex = 0;
            // 
            // lbMailCounter
            // 
            lbMailCounter.AutoSize = true;
            lbMailCounter.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbMailCounter.Location = new Point(215, 80);
            lbMailCounter.Name = "lbMailCounter";
            lbMailCounter.Size = new Size(85, 17);
            lbMailCounter.TabIndex = 22;
            lbMailCounter.Text = "Mail Editor";
            // 
            // lbHeader
            // 
            lbHeader.AutoSize = true;
            lbHeader.Font = new Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            lbHeader.Location = new Point(12, 73);
            lbHeader.Name = "lbHeader";
            lbHeader.Size = new Size(127, 26);
            lbHeader.TabIndex = 21;
            lbHeader.Text = "Mail Editor";
            // 
            // LabelingPanel
            // 
            LabelingPanel.Controls.Add(listViewLabels);
            LabelingPanel.Controls.Add(lbShowingStatus);
            LabelingPanel.Controls.Add(btnNext);
            LabelingPanel.Controls.Add(btnNextMail);
            LabelingPanel.Controls.Add(btnBackMail);
            LabelingPanel.Controls.Add(btnCommit);
            LabelingPanel.Controls.Add(lbLabelsAdded);
            LabelingPanel.Controls.Add(btnAddLabel);
            LabelingPanel.Controls.Add(DDLabels);
            LabelingPanel.Dock = DockStyle.Right;
            LabelingPanel.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            LabelingPanel.Location = new Point(481, 0);
            LabelingPanel.Margin = new Padding(3, 2, 3, 2);
            LabelingPanel.Name = "LabelingPanel";
            LabelingPanel.Size = new Size(538, 490);
            LabelingPanel.TabIndex = 1;
            // 
            // listViewLabels
            // 
            listViewLabels.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            listViewLabels.Location = new Point(286, 148);
            listViewLabels.Margin = new Padding(3, 2, 3, 2);
            listViewLabels.Name = "listViewLabels";
            listViewLabels.Size = new Size(133, 247);
            listViewLabels.TabIndex = 29;
            listViewLabels.UseCompatibleStateImageBehavior = false;
            // 
            // lbShowingStatus
            // 
            lbShowingStatus.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lbShowingStatus.AutoSize = true;
            lbShowingStatus.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lbShowingStatus.Location = new Point(-27, 285);
            lbShowingStatus.Margin = new Padding(4, 0, 4, 0);
            lbShowingStatus.Name = "lbShowingStatus";
            lbShowingStatus.Size = new Size(106, 16);
            lbShowingStatus.TabIndex = 28;
            lbShowingStatus.Text = "Cleaning Mails";
            // 
            // btnNext
            // 
            btnNext.Anchor = AnchorStyles.Bottom;
            btnNext.FlatStyle = FlatStyle.Flat;
            btnNext.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnNext.ForeColor = Color.Black;
            btnNext.Location = new Point(444, 415);
            btnNext.Margin = new Padding(3, 2, 3, 2);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(82, 28);
            btnNext.TabIndex = 27;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // btnNextMail
            // 
            btnNextMail.Anchor = AnchorStyles.Bottom;
            btnNextMail.FlatStyle = FlatStyle.Flat;
            btnNextMail.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnNextMail.ForeColor = Color.DarkOrange;
            btnNextMail.Location = new Point(139, 415);
            btnNextMail.Margin = new Padding(3, 2, 3, 2);
            btnNextMail.Name = "btnNextMail";
            btnNextMail.Size = new Size(107, 28);
            btnNextMail.TabIndex = 26;
            btnNextMail.Text = "Next Mail";
            btnNextMail.UseVisualStyleBackColor = true;
            btnNextMail.Click += btnNextMail_Click;
            // 
            // btnBackMail
            // 
            btnBackMail.Anchor = AnchorStyles.Bottom;
            btnBackMail.FlatStyle = FlatStyle.Flat;
            btnBackMail.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnBackMail.ForeColor = Color.DarkOrange;
            btnBackMail.Location = new Point(6, 415);
            btnBackMail.Margin = new Padding(3, 2, 3, 2);
            btnBackMail.Name = "btnBackMail";
            btnBackMail.Size = new Size(102, 28);
            btnBackMail.TabIndex = 25;
            btnBackMail.Text = "Previous mail";
            btnBackMail.UseVisualStyleBackColor = true;
            btnBackMail.Click += btnBackMail_Click;
            // 
            // btnCommit
            // 
            btnCommit.Anchor = AnchorStyles.Bottom;
            btnCommit.FlatStyle = FlatStyle.Flat;
            btnCommit.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnCommit.ForeColor = Color.DarkOrange;
            btnCommit.Location = new Point(6, 370);
            btnCommit.Margin = new Padding(3, 2, 3, 2);
            btnCommit.Name = "btnCommit";
            btnCommit.Size = new Size(102, 25);
            btnCommit.TabIndex = 24;
            btnCommit.Text = "Commit";
            btnCommit.UseVisualStyleBackColor = true;
            btnCommit.Click += btnCommit_Click;
            // 
            // lbLabelsAdded
            // 
            lbLabelsAdded.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lbLabelsAdded.AutoSize = true;
            lbLabelsAdded.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbLabelsAdded.Location = new Point(286, 121);
            lbLabelsAdded.Name = "lbLabelsAdded";
            lbLabelsAdded.Size = new Size(115, 18);
            lbLabelsAdded.TabIndex = 22;
            lbLabelsAdded.Text = "Labels added";
            // 
            // btnAddLabel
            // 
            btnAddLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAddLabel.FlatStyle = FlatStyle.Flat;
            btnAddLabel.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddLabel.ForeColor = Color.Black;
            btnAddLabel.Location = new Point(286, 77);
            btnAddLabel.Margin = new Padding(3, 2, 3, 2);
            btnAddLabel.Name = "btnAddLabel";
            btnAddLabel.Size = new Size(130, 24);
            btnAddLabel.TabIndex = 13;
            btnAddLabel.Text = "Add Label";
            btnAddLabel.UseVisualStyleBackColor = true;
            btnAddLabel.Click += btnAddLabel_Click;
            // 
            // DDLabels
            // 
            DDLabels.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            DDLabels.FormattingEnabled = true;
            DDLabels.Location = new Point(53, 77);
            DDLabels.Margin = new Padding(3, 2, 3, 2);
            DDLabels.Name = "DDLabels";
            DDLabels.Size = new Size(193, 24);
            DDLabels.TabIndex = 12;
            // 
            // ManualEditingForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1019, 490);
            Controls.Add(LabelingPanel);
            Controls.Add(TextPanel);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ManualEditingForm";
            Text = "ManualEditingForm";
            Resize += ManualEditingForm_Resize;
            TextPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbLoadingGif).EndInit();
            panelHeadline.ResumeLayout(false);
            panelHeadline.PerformLayout();
            LabelingPanel.ResumeLayout(false);
            LabelingPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel TextPanel;
        private Panel panelHeadline;
        private Panel LabelingPanel;
        private RichTextBox textBoxEditing;
        private Label lbHeader;
        private ComboBox DDLabels;
        private Label lbLabelsAdded;
        private Button btnAddLabel;
        private Button btnCommit;
        private Button btnBackMail;
        private Button btnNextMail;
        private Button btnNext;
        private PictureBox pbLoadingGif;
        private Label lbShowingStatus;
        private ListView listViewLabels;
        private Label lbMailCounter;
    }
}