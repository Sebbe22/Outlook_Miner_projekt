namespace OutlookMiner.Forms
{
    partial class ManualConvertForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManualConvertForm));
            lbShowingStatus = new Label();
            pbLoadingGif = new PictureBox();
            lbFeedbackMessage = new Label();
            lbConvertFeedback = new Label();
            btnConvertFile = new Button();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pbLoadingGif).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lbShowingStatus
            // 
            lbShowingStatus.AutoSize = true;
            lbShowingStatus.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lbShowingStatus.Location = new Point(270, 313);
            lbShowingStatus.Name = "lbShowingStatus";
            lbShowingStatus.Size = new Size(121, 16);
            lbShowingStatus.TabIndex = 23;
            lbShowingStatus.Text = "Converting mails";
            // 
            // pbLoadingGif
            // 
            pbLoadingGif.Image = (Image)resources.GetObject("pbLoadingGif.Image");
            pbLoadingGif.Location = new Point(296, 159);
            pbLoadingGif.Margin = new Padding(3, 2, 3, 2);
            pbLoadingGif.Name = "pbLoadingGif";
            pbLoadingGif.Size = new Size(74, 136);
            pbLoadingGif.TabIndex = 22;
            pbLoadingGif.TabStop = false;
            // 
            // lbFeedbackMessage
            // 
            lbFeedbackMessage.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbFeedbackMessage.AutoSize = true;
            lbFeedbackMessage.BackColor = Color.Transparent;
            lbFeedbackMessage.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lbFeedbackMessage.Location = new Point(290, 134);
            lbFeedbackMessage.MaximumSize = new Size(219, 150);
            lbFeedbackMessage.MinimumSize = new Size(219, 15);
            lbFeedbackMessage.Name = "lbFeedbackMessage";
            lbFeedbackMessage.Size = new Size(219, 16);
            lbFeedbackMessage.TabIndex = 21;
            lbFeedbackMessage.Text = "File converted";
            // 
            // lbConvertFeedback
            // 
            lbConvertFeedback.AutoSize = true;
            lbConvertFeedback.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lbConvertFeedback.Location = new Point(290, 150);
            lbConvertFeedback.Name = "lbConvertFeedback";
            lbConvertFeedback.Size = new Size(0, 16);
            lbConvertFeedback.TabIndex = 20;
            // 
            // btnConvertFile
            // 
            btnConvertFile.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 1);
            btnConvertFile.FlatStyle = FlatStyle.Flat;
            btnConvertFile.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnConvertFile.ForeColor = Color.Black;
            btnConvertFile.Location = new Point(270, 84);
            btnConvertFile.Margin = new Padding(3, 2, 3, 2);
            btnConvertFile.Name = "btnConvertFile";
            btnConvertFile.Size = new Size(126, 25);
            btnConvertFile.TabIndex = 19;
            btnConvertFile.Text = "Convert";
            btnConvertFile.UseVisualStyleBackColor = true;
            btnConvertFile.Click += btnConvertFile_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnConvertFile);
            panel1.Controls.Add(lbShowingStatus);
            panel1.Controls.Add(lbFeedbackMessage);
            panel1.Controls.Add(pbLoadingGif);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(700, 338);
            panel1.TabIndex = 24;
            // 
            // ManualConvertForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(panel1);
            Controls.Add(lbConvertFeedback);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ManualConvertForm";
            Text = "ManualConvertForm";
            ((System.ComponentModel.ISupportInitialize)pbLoadingGif).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbShowingStatus;
        private PictureBox pbLoadingGif;
        public Label lbFeedbackMessage;
        private Label lbConvertFeedback;
        private Button btnConvertFile;
        private Panel panel1;
    }
}