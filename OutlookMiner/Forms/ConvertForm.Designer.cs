namespace OutlookMiner.Forms
{
    partial class ConvertForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConvertForm));
            this.lbHeader = new System.Windows.Forms.Label();
            this.btConvertFile = new System.Windows.Forms.Button();
            this.btBack = new System.Windows.Forms.Button();
            this.lbGoToStart = new System.Windows.Forms.Button();
            this.lbConvertFeedback = new System.Windows.Forms.Label();
            this.lbFeedbackMessage = new System.Windows.Forms.Label();
            this.pbLoadingGif = new System.Windows.Forms.PictureBox();
            this.lbShowingStatus = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbLoadingGif)).BeginInit();
            this.SuspendLayout();
            // 
            // lbHeader
            // 
            this.lbHeader.AutoSize = true;
            this.lbHeader.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbHeader.Location = new System.Drawing.Point(17, 61);
            this.lbHeader.Name = "lbHeader";
            this.lbHeader.Size = new System.Drawing.Size(185, 27);
            this.lbHeader.TabIndex = 2;
            this.lbHeader.Text = "Step 3. Convert";
            // 
            // btConvertFile
            // 
            this.btConvertFile.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.btConvertFile.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btConvertFile.ForeColor = System.Drawing.Color.Black;
            this.btConvertFile.Location = new System.Drawing.Point(198, 130);
            this.btConvertFile.Name = "btConvertFile";
            this.btConvertFile.Size = new System.Drawing.Size(100, 29);
            this.btConvertFile.TabIndex = 6;
            this.btConvertFile.Text = "Convert";
            this.btConvertFile.UseVisualStyleBackColor = true;
            this.btConvertFile.Click += new System.EventHandler(this.btConvertFile_Click);
            // 
            // btBack
            // 
            this.btBack.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btBack.ForeColor = System.Drawing.Color.DarkOrange;
            this.btBack.Location = new System.Drawing.Point(236, 406);
            this.btBack.Name = "btBack";
            this.btBack.Size = new System.Drawing.Size(94, 29);
            this.btBack.TabIndex = 8;
            this.btBack.Text = "Back";
            this.btBack.UseVisualStyleBackColor = true;
            this.btBack.Click += new System.EventHandler(this.btBack_Click);
            // 
            // lbGoToStart
            // 
            this.lbGoToStart.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbGoToStart.ForeColor = System.Drawing.Color.DarkOrange;
            this.lbGoToStart.Location = new System.Drawing.Point(360, 406);
            this.lbGoToStart.Name = "lbGoToStart";
            this.lbGoToStart.Size = new System.Drawing.Size(94, 29);
            this.lbGoToStart.TabIndex = 9;
            this.lbGoToStart.Text = "Start";
            this.lbGoToStart.UseVisualStyleBackColor = true;
            this.lbGoToStart.Click += new System.EventHandler(this.lbGoToStart_Click);
            // 
            // lbConvertFeedback
            // 
            this.lbConvertFeedback.AutoSize = true;
            this.lbConvertFeedback.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbConvertFeedback.Location = new System.Drawing.Point(236, 232);
            this.lbConvertFeedback.Name = "lbConvertFeedback";
            this.lbConvertFeedback.Size = new System.Drawing.Size(0, 20);
            this.lbConvertFeedback.TabIndex = 10;
            // 
            // lbFeedbackMessage
            // 
            this.lbFeedbackMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbFeedbackMessage.AutoSize = true;
            this.lbFeedbackMessage.BackColor = System.Drawing.Color.Transparent;
            this.lbFeedbackMessage.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbFeedbackMessage.Location = new System.Drawing.Point(189, 180);
            this.lbFeedbackMessage.MaximumSize = new System.Drawing.Size(250, 200);
            this.lbFeedbackMessage.MinimumSize = new System.Drawing.Size(250, 20);
            this.lbFeedbackMessage.Name = "lbFeedbackMessage";
            this.lbFeedbackMessage.Size = new System.Drawing.Size(250, 20);
            this.lbFeedbackMessage.TabIndex = 16;
            this.lbFeedbackMessage.Text = "File converted";
            // 
            // pbLoadingGif
            // 
            this.pbLoadingGif.Image = ((System.Drawing.Image)(resources.GetObject("pbLoadingGif.Image")));
            this.pbLoadingGif.Location = new System.Drawing.Point(216, 212);
            this.pbLoadingGif.Name = "pbLoadingGif";
            this.pbLoadingGif.Size = new System.Drawing.Size(61, 137);
            this.pbLoadingGif.TabIndex = 17;
            this.pbLoadingGif.TabStop = false;
            // 
            // lbShowingStatus
            // 
            this.lbShowingStatus.AutoSize = true;
            this.lbShowingStatus.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbShowingStatus.Location = new System.Drawing.Point(169, 364);
            this.lbShowingStatus.Name = "lbShowingStatus";
            this.lbShowingStatus.Size = new System.Drawing.Size(148, 20);
            this.lbShowingStatus.TabIndex = 18;
            this.lbShowingStatus.Text = "Converting mails";
            // 
            // ConvertForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 453);
            this.Controls.Add(this.lbShowingStatus);
            this.Controls.Add(this.pbLoadingGif);
            this.Controls.Add(this.lbFeedbackMessage);
            this.Controls.Add(this.lbConvertFeedback);
            this.Controls.Add(this.lbGoToStart);
            this.Controls.Add(this.btBack);
            this.Controls.Add(this.btConvertFile);
            this.Controls.Add(this.lbHeader);
            this.Name = "ConvertForm";
            this.Text = "ConvertForm";
            this.Load += new System.EventHandler(this.ConvertForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbLoadingGif)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbHeader;
        private Button btConvertFile;
        private Button btBack;
        private Button lbGoToStart;
        private Label lbConvertFeedback;
        public Label lbFeedbackMessage;
        private PictureBox pbLoadingGif;
        private Label lbShowingStatus;
    }
}