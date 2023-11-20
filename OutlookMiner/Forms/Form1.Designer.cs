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
            this.lbSaveLocation.AutoSize = true;
            this.lbSaveLocation.Location = new System.Drawing.Point(34, 225);
            this.lbSaveLocation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbSaveLocation.Name = "lbSaveLocation";
            this.lbSaveLocation.Size = new System.Drawing.Size(0, 20);
            this.lbSaveLocation.TabIndex = 6;
            // 
            // lbHeader
            // 
            this.lbHeader.AutoSize = true;
            this.lbHeader.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbHeader.Location = new System.Drawing.Point(34, 77);
            this.lbHeader.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbHeader.Name = "lbHeader";
            this.lbHeader.Size = new System.Drawing.Size(241, 27);
            this.lbHeader.TabIndex = 10;
            this.lbHeader.Text = "Step 1. Choose a file";
            // 
            // lbFileChosen
            // 
            this.lbFileChosen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbFileChosen.AutoSize = true;
            this.lbFileChosen.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lbFileChosen.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbFileChosen.Location = new System.Drawing.Point(153, 144);
            this.lbFileChosen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbFileChosen.MaximumSize = new System.Drawing.Size(312, 250);
            this.lbFileChosen.MinimumSize = new System.Drawing.Size(312, 25);
            this.lbFileChosen.Name = "lbFileChosen";
            this.lbFileChosen.Size = new System.Drawing.Size(312, 25);
            this.lbFileChosen.TabIndex = 11;
            this.lbFileChosen.Text = "File Name";
            // 
            // chooseFile
            // 
            this.chooseFile.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.chooseFile.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chooseFile.ForeColor = System.Drawing.Color.Black;
            this.chooseFile.Location = new System.Drawing.Point(252, 245);
            this.chooseFile.Margin = new System.Windows.Forms.Padding(4);
            this.chooseFile.Name = "chooseFile";
            this.chooseFile.Size = new System.Drawing.Size(126, 36);
            this.chooseFile.TabIndex = 12;
            this.chooseFile.Text = "Choose file";
            this.chooseFile.UseVisualStyleBackColor = true;
            this.chooseFile.Click += new System.EventHandler(this.chooseFile_Click);
            // 
            // btNext
            // 
            this.btNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btNext.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btNext.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btNext.ForeColor = System.Drawing.Color.DarkOrange;
            this.btNext.Location = new System.Drawing.Point(569, 510);
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
            this.lbMailCount.Location = new System.Drawing.Point(174, 193);
            this.lbMailCount.MaximumSize = new System.Drawing.Size(250, 200);
            this.lbMailCount.MinimumSize = new System.Drawing.Size(250, 20);
            this.lbMailCount.Name = "lbMailCount";
            this.lbMailCount.Size = new System.Drawing.Size(250, 20);
            this.lbMailCount.TabIndex = 15;
            // 
            // pbLoadingGif
            // 
            this.pbLoadingGif.Image = ((System.Drawing.Image)(resources.GetObject("pbLoadingGif.Image")));
            this.pbLoadingGif.Location = new System.Drawing.Point(283, 301);
            this.pbLoadingGif.Margin = new System.Windows.Forms.Padding(4);
            this.pbLoadingGif.Name = "pbLoadingGif";
            this.pbLoadingGif.Size = new System.Drawing.Size(60, 171);
            this.pbLoadingGif.TabIndex = 16;
            this.pbLoadingGif.TabStop = false;
            // 
            // lbShowingStatus
            // 
            this.lbShowingStatus.AutoSize = true;
            this.lbShowingStatus.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbShowingStatus.Location = new System.Drawing.Point(252, 476);
            this.lbShowingStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbShowingStatus.Name = "lbShowingStatus";
            this.lbShowingStatus.Size = new System.Drawing.Size(128, 20);
            this.lbShowingStatus.TabIndex = 17;
            this.lbShowingStatus.Text = "Fetching Mails";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(544, 388);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 18;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 566);
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