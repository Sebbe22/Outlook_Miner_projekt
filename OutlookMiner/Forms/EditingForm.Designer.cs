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
            this.btBackMail = new System.Windows.Forms.Button();
            this.lbNextMail = new System.Windows.Forms.Button();
            this.DDLabels = new System.Windows.Forms.ComboBox();
            this.btAddLabel = new System.Windows.Forms.Button();
            this.btNext = new System.Windows.Forms.Button();
            this.pbLoadingGif = new System.Windows.Forms.PictureBox();
            this.lbShowingStatus = new System.Windows.Forms.Label();
            this.textBoxEditing = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbLoadingGif)).BeginInit();
            this.SuspendLayout();
            // 
            // btBackMail
            // 
            this.btBackMail.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btBackMail.ForeColor = System.Drawing.Color.DarkOrange;
            this.btBackMail.Location = new System.Drawing.Point(449, 409);
            this.btBackMail.Name = "btBackMail";
            this.btBackMail.Size = new System.Drawing.Size(94, 29);
            this.btBackMail.TabIndex = 9;
            this.btBackMail.Text = "Previous mail";
            this.btBackMail.UseVisualStyleBackColor = true;
            this.btBackMail.Click += new System.EventHandler(this.btBackMail_Click);
            // 
            // lbNextMail
            // 
            this.lbNextMail.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbNextMail.ForeColor = System.Drawing.Color.DarkOrange;
            this.lbNextMail.Location = new System.Drawing.Point(568, 409);
            this.lbNextMail.Name = "lbNextMail";
            this.lbNextMail.Size = new System.Drawing.Size(94, 29);
            this.lbNextMail.TabIndex = 10;
            this.lbNextMail.Text = "Next Mail";
            this.lbNextMail.UseVisualStyleBackColor = true;
            this.lbNextMail.Click += new System.EventHandler(this.lbNextMail_Click);
            // 
            // DDLabels
            // 
            this.DDLabels.FormattingEnabled = true;
            this.DDLabels.Location = new System.Drawing.Point(468, 78);
            this.DDLabels.Name = "DDLabels";
            this.DDLabels.Size = new System.Drawing.Size(151, 28);
            this.DDLabels.TabIndex = 11;
            // 
            // btAddLabel
            // 
            this.btAddLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btAddLabel.ForeColor = System.Drawing.Color.Black;
            this.btAddLabel.Location = new System.Drawing.Point(658, 78);
            this.btAddLabel.Name = "btAddLabel";
            this.btAddLabel.Size = new System.Drawing.Size(94, 29);
            this.btAddLabel.TabIndex = 12;
            this.btAddLabel.Text = "Add Label";
            this.btAddLabel.UseVisualStyleBackColor = true;
            this.btAddLabel.Click += new System.EventHandler(this.btAddLabel_Click);
            // 
            // btNext
            // 
            this.btNext.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btNext.ForeColor = System.Drawing.Color.Black;
            this.btNext.Location = new System.Drawing.Point(694, 409);
            this.btNext.Name = "btNext";
            this.btNext.Size = new System.Drawing.Size(94, 29);
            this.btNext.TabIndex = 13;
            this.btNext.Text = "Next";
            this.btNext.UseVisualStyleBackColor = true;
            this.btNext.Click += new System.EventHandler(this.btNext_Click);
            // 
            // pbLoadingGif
            // 
            this.pbLoadingGif.Image = ((System.Drawing.Image)(resources.GetObject("pbLoadingGif.Image")));
            this.pbLoadingGif.Location = new System.Drawing.Point(400, 120);
            this.pbLoadingGif.Margin = new System.Windows.Forms.Padding(4);
            this.pbLoadingGif.Name = "pbLoadingGif";
            this.pbLoadingGif.Size = new System.Drawing.Size(60, 171);
            this.pbLoadingGif.TabIndex = 17;
            this.pbLoadingGif.TabStop = false;
            // 
            // lbShowingStatus
            // 
            this.lbShowingStatus.AutoSize = true;
            this.lbShowingStatus.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbShowingStatus.Location = new System.Drawing.Point(378, 308);
            this.lbShowingStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbShowingStatus.Name = "lbShowingStatus";
            this.lbShowingStatus.Size = new System.Drawing.Size(130, 20);
            this.lbShowingStatus.TabIndex = 18;
            this.lbShowingStatus.Text = "Cleaning Mails";
            // 
            // textBoxEditing
            // 
            this.textBoxEditing.Location = new System.Drawing.Point(23, 54);
            this.textBoxEditing.Name = "textBoxEditing";
            this.textBoxEditing.ReadOnly = true;
            this.textBoxEditing.Size = new System.Drawing.Size(404, 369);
            this.textBoxEditing.TabIndex = 19;
            this.textBoxEditing.Text = "";
            this.textBoxEditing.MouseUp += new System.Windows.Forms.MouseEventHandler(this.textBoxEditing_MouseUp);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.DarkOrange;
            this.button1.Location = new System.Drawing.Point(449, 363);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 20;
            this.button1.Text = "Commit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // EditingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxEditing);
            this.Controls.Add(this.lbShowingStatus);
            this.Controls.Add(this.pbLoadingGif);
            this.Controls.Add(this.btNext);
            this.Controls.Add(this.btAddLabel);
            this.Controls.Add(this.DDLabels);
            this.Controls.Add(this.lbNextMail);
            this.Controls.Add(this.btBackMail);
            this.Name = "EditingForm";
            this.Text = "EditingForm";
            ((System.ComponentModel.ISupportInitialize)(this.pbLoadingGif)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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