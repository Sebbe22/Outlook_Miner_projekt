namespace OutlookMiner.Forms
{
    partial class EditingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditingForm));
            btBackMail = new Button();
            lbNextMail = new Button();
            DDLabels = new ComboBox();
            btAddLabel = new Button();
            btNext = new Button();
            pbLoadingGif = new PictureBox();
            lbShowingStatus = new Label();
            textBoxEditing = new RichTextBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pbLoadingGif).BeginInit();
            SuspendLayout();
            // 
            // btBackMail
            // 
            btBackMail.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btBackMail.ForeColor = Color.DarkOrange;
            btBackMail.Location = new Point(561, 512);
            btBackMail.Margin = new Padding(4, 3, 4, 3);
            btBackMail.Name = "btBackMail";
            btBackMail.Size = new Size(117, 37);
            btBackMail.TabIndex = 9;
            btBackMail.Text = "Previous mail";
            btBackMail.UseVisualStyleBackColor = true;
            btBackMail.Click += btBackMail_Click;
            // 
            // lbNextMail
            // 
            lbNextMail.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lbNextMail.ForeColor = Color.DarkOrange;
            lbNextMail.Location = new Point(710, 512);
            lbNextMail.Margin = new Padding(4, 3, 4, 3);
            lbNextMail.Name = "lbNextMail";
            lbNextMail.Size = new Size(117, 37);
            lbNextMail.TabIndex = 10;
            lbNextMail.Text = "Next Mail";
            lbNextMail.UseVisualStyleBackColor = true;
            lbNextMail.Click += lbNextMail_Click;
            // 
            // DDLabels
            // 
            DDLabels.FormattingEnabled = true;
            DDLabels.Location = new Point(586, 97);
            DDLabels.Margin = new Padding(4, 3, 4, 3);
            DDLabels.Name = "DDLabels";
            DDLabels.Size = new Size(188, 33);
            DDLabels.TabIndex = 11;
            DDLabels.SelectedIndexChanged += DDLabels_SelectedIndexChanged;
            // 
            // btAddLabel
            // 
            btAddLabel.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btAddLabel.ForeColor = Color.Black;
            btAddLabel.Location = new Point(823, 97);
            btAddLabel.Margin = new Padding(4, 3, 4, 3);
            btAddLabel.Name = "btAddLabel";
            btAddLabel.Size = new Size(117, 37);
            btAddLabel.TabIndex = 12;
            btAddLabel.Text = "Add Label";
            btAddLabel.UseVisualStyleBackColor = true;
            btAddLabel.Click += btAddLabel_Click;
            // 
            // btNext
            // 
            btNext.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btNext.ForeColor = Color.Black;
            btNext.Location = new Point(867, 512);
            btNext.Margin = new Padding(4, 3, 4, 3);
            btNext.Name = "btNext";
            btNext.Size = new Size(117, 37);
            btNext.TabIndex = 13;
            btNext.Text = "Next";
            btNext.UseVisualStyleBackColor = true;
            btNext.Click += btNext_Click;
            // 
            // pbLoadingGif
            // 
            pbLoadingGif.Image = (Image)resources.GetObject("pbLoadingGif.Image");
            pbLoadingGif.Location = new Point(500, 150);
            pbLoadingGif.Margin = new Padding(6, 5, 6, 5);
            pbLoadingGif.Name = "pbLoadingGif";
            pbLoadingGif.Size = new Size(74, 213);
            pbLoadingGif.TabIndex = 17;
            pbLoadingGif.TabStop = false;
            // 
            // lbShowingStatus
            // 
            lbShowingStatus.AutoSize = true;
            lbShowingStatus.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lbShowingStatus.Location = new Point(473, 385);
            lbShowingStatus.Margin = new Padding(6, 0, 6, 0);
            lbShowingStatus.Name = "lbShowingStatus";
            lbShowingStatus.Size = new Size(158, 24);
            lbShowingStatus.TabIndex = 18;
            lbShowingStatus.Text = "Cleaning Mails";
            // 
            // textBoxEditing
            // 
            textBoxEditing.Location = new Point(29, 67);
            textBoxEditing.Margin = new Padding(4, 3, 4, 3);
            textBoxEditing.Name = "textBoxEditing";
            textBoxEditing.ReadOnly = true;
            textBoxEditing.Size = new Size(504, 461);
            textBoxEditing.TabIndex = 19;
            textBoxEditing.Text = "";
            textBoxEditing.MouseUp += textBoxEditing_MouseUp;
            // 
            // button1
            // 
            button1.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.DarkOrange;
            button1.Location = new Point(561, 453);
            button1.Margin = new Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new Size(117, 37);
            button1.TabIndex = 20;
            button1.Text = "Commit";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // EditingForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 563);
            Controls.Add(button1);
            Controls.Add(textBoxEditing);
            Controls.Add(lbShowingStatus);
            Controls.Add(pbLoadingGif);
            Controls.Add(btNext);
            Controls.Add(btAddLabel);
            Controls.Add(DDLabels);
            Controls.Add(lbNextMail);
            Controls.Add(btBackMail);
            Margin = new Padding(4, 3, 4, 3);
            Name = "EditingForm";
            Text = "EditingForm";
            ((System.ComponentModel.ISupportInitialize)pbLoadingGif).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btBackMail;
        private Button lbNextMail;
        private ComboBox DDLabels;
        private Button btAddLabel;
        private Button btNext;
        private PictureBox pbLoadingGif;
        private Label lbShowingStatus;
        private RichTextBox textBoxEditing;
        private Button button1;
    }
}