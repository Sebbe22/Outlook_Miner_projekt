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
            this.lbSaveLocation = new System.Windows.Forms.Label();
            this.lbHeader = new System.Windows.Forms.Label();
            this.lbFileChosen = new System.Windows.Forms.Label();
            this.chooseFile = new System.Windows.Forms.Button();
            this.btNext = new System.Windows.Forms.Button();
            this.lbMailCount = new System.Windows.Forms.Label();
            this.pbLoadingGif = new System.Windows.Forms.PictureBox();
            this.lbShowingStatus = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbLoadingGif)).BeginInit();
            this.SuspendLayout();
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
            this.lbMailCount.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbMailCount.AutoSize = true;
            this.lbMailCount.BackColor = System.Drawing.Color.Transparent;
            this.lbMailCount.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbMailCount.Location = new System.Drawing.Point(118, 221);
            this.lbMailCount.MaximumSize = new System.Drawing.Size(250, 200);
            this.lbMailCount.MinimumSize = new System.Drawing.Size(250, 20);
            this.lbMailCount.Name = "lbMailCount";
            this.lbMailCount.Size = new System.Drawing.Size(250, 20);
            this.lbMailCount.TabIndex = 15;
 
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(364, 339);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 18;
            this.button1.Text = "To labeling";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 461);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbShowingStatus);
            this.Controls.Add(this.pbLoadingGif);
            this.Controls.Add(this.chooseFile);
            this.Controls.Add(this.lbFileChosen);
            this.Controls.Add(this.lbMailCount);
            this.Controls.Add(this.btNext);
            this.Controls.Add(this.lbHeader);
            this.Controls.Add(this.lbSaveLocation);
            this.MinimumSize = new System.Drawing.Size(500, 498);
            this.Name = "Form1";
            this.Text = "OutLookMiner 1.0";
            ((System.ComponentModel.ISupportInitialize)(this.pbLoadingGif)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private Button button1;
    }
}