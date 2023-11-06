namespace OutlookMiner
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            lbSaveLocation = new Label();
            lbHeader = new Label();
            lbFileChosen = new Label();
            chooseFile = new Button();
            btNext = new Button();
            lbMailCount = new Label();
            pbLoadingGif = new PictureBox();
            lbShowingStatus = new Label();
            ((System.ComponentModel.ISupportInitialize)pbLoadingGif).BeginInit();
            SuspendLayout();
            // 
            // lbSaveLocation
            // 
            lbSaveLocation.AutoSize = true;
            lbSaveLocation.Location = new Point(34, 225);
            lbSaveLocation.Margin = new Padding(4, 0, 4, 0);
            lbSaveLocation.Name = "lbSaveLocation";
            lbSaveLocation.Size = new Size(0, 25);
            lbSaveLocation.TabIndex = 6;
            // 
            // lbHeader
            // 
            lbHeader.AutoSize = true;
            lbHeader.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lbHeader.Location = new Point(21, 76);
            lbHeader.Margin = new Padding(4, 0, 4, 0);
            lbHeader.Name = "lbHeader";
            lbHeader.Size = new Size(295, 32);
            lbHeader.TabIndex = 10;
            lbHeader.Text = "Step 1. Choose a file";
            // 
            // lbFileChosen
            // 
            lbFileChosen.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbFileChosen.AutoSize = true;
            lbFileChosen.BackColor = SystemColors.AppWorkspace;
            lbFileChosen.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lbFileChosen.Location = new Point(148, 140);
            lbFileChosen.Margin = new Padding(4, 0, 4, 0);
            lbFileChosen.MaximumSize = new Size(312, 250);
            lbFileChosen.MinimumSize = new Size(312, 25);
            lbFileChosen.Name = "lbFileChosen";
            lbFileChosen.Size = new Size(312, 25);
            lbFileChosen.TabIndex = 11;
            lbFileChosen.Text = "File Name";
            // 
            // chooseFile
            // 
            chooseFile.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 1);
            chooseFile.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            chooseFile.ForeColor = Color.Black;
            chooseFile.Location = new Point(240, 225);
            chooseFile.Margin = new Padding(4, 4, 4, 4);
            chooseFile.Name = "chooseFile";
            chooseFile.Size = new Size(126, 36);
            chooseFile.TabIndex = 12;
            chooseFile.Text = "Choose file";
            chooseFile.UseVisualStyleBackColor = true;
            chooseFile.Click += chooseFile_Click;
            // 
            // btNext
            // 
            this.btNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btNext.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btNext.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btNext.ForeColor = System.Drawing.Color.DarkOrange;
            this.btNext.Location = new System.Drawing.Point(360, 405);
            this.btNext.Name = "btNext";
            this.btNext.Size = new System.Drawing.Size(105, 36);
            this.btNext.TabIndex = 13;
            this.btNext.Text = "Next";
            this.btNext.UseVisualStyleBackColor = false;
            this.btNext.Click += new System.EventHandler(this.btNext_Click);
            // 
            // lbMailCount
            // 
            lbMailCount.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbMailCount.AutoSize = true;
            lbMailCount.BackColor = Color.Transparent;
            lbMailCount.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lbMailCount.Location = new Point(148, 276);
            lbMailCount.Margin = new Padding(4, 0, 4, 0);
            lbMailCount.MaximumSize = new Size(312, 250);
            lbMailCount.MinimumSize = new Size(312, 25);
            lbMailCount.Name = "lbMailCount";
            lbMailCount.Size = new Size(312, 25);
            lbMailCount.TabIndex = 15;
            lbMailCount.Click += lbMailCount_Click_1;
            // 
            // pbLoadingGif
            // 
            pbLoadingGif.Image = (Image)resources.GetObject("pbLoadingGif.Image");
            pbLoadingGif.Location = new Point(272, 330);
            pbLoadingGif.Margin = new Padding(4, 4, 4, 4);
            pbLoadingGif.Name = "pbLoadingGif";
            pbLoadingGif.Size = new Size(76, 171);
            pbLoadingGif.TabIndex = 16;
            pbLoadingGif.TabStop = false;
            // 
            // lbShowingStatus
            // 
            lbShowingStatus.AutoSize = true;
            lbShowingStatus.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lbShowingStatus.Location = new Point(229, 505);
            lbShowingStatus.Margin = new Padding(4, 0, 4, 0);
            lbShowingStatus.Name = "lbShowingStatus";
            lbShowingStatus.Size = new Size(156, 24);
            lbShowingStatus.TabIndex = 17;
            lbShowingStatus.Text = "Fetching Mails";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(606, 576);
            Controls.Add(lbShowingStatus);
            Controls.Add(pbLoadingGif);
            Controls.Add(chooseFile);
            Controls.Add(lbFileChosen);
            Controls.Add(lbMailCount);
            Controls.Add(btNext);
            Controls.Add(lbHeader);
            Controls.Add(lbSaveLocation);
            Margin = new Padding(4, 4, 4, 4);
            MinimumSize = new Size(620, 608);
            Name = "Form1";
            Text = "OutLookMiner 1.0";
            ((System.ComponentModel.ISupportInitialize)pbLoadingGif).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lbSaveLocation;
        private Label lbHeader;
        private Button chooseFile;
        private Button btNext;
        public Label lbFileChosen;
        public Label lbMailCount;
        private PictureBox pbLoadingGif;
        private Label lbShowingStatus;
    }
}