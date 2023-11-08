namespace OutlookMiner.Forms
{
    partial class ManuelLabelingForm
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
            this.tbMail = new System.Windows.Forms.TextBox();
            this.lbHeader = new System.Windows.Forms.Label();
            this.btNextMail = new System.Windows.Forms.Button();
            this.cbLabels = new System.Windows.Forms.ComboBox();
            this.btAddLabel = new System.Windows.Forms.Button();
            this.lbHeader2 = new System.Windows.Forms.Label();
            this.lbChoosenLabels = new System.Windows.Forms.ListBox();
            this.btNext = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbMail
            // 
            this.tbMail.Location = new System.Drawing.Point(12, 95);
            this.tbMail.Multiline = true;
            this.tbMail.Name = "tbMail";
            this.tbMail.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbMail.Size = new System.Drawing.Size(608, 478);
            this.tbMail.TabIndex = 0;
            // 
            // lbHeader
            // 
            this.lbHeader.AutoSize = true;
            this.lbHeader.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbHeader.Location = new System.Drawing.Point(25, 33);
            this.lbHeader.Name = "lbHeader";
            this.lbHeader.Size = new System.Drawing.Size(108, 27);
            this.lbHeader.TabIndex = 1;
            this.lbHeader.Text = "Labeling";
            // 
            // btNextMail
            // 
            this.btNextMail.Location = new System.Drawing.Point(641, 545);
            this.btNextMail.Name = "btNextMail";
            this.btNextMail.Size = new System.Drawing.Size(94, 29);
            this.btNextMail.TabIndex = 2;
            this.btNextMail.Text = "Next Mail";
            this.btNextMail.UseVisualStyleBackColor = true;
            this.btNextMail.Click += new System.EventHandler(this.btNextMail_Click);
            // 
            // cbLabels
            // 
            this.cbLabels.FormattingEnabled = true;
            this.cbLabels.Location = new System.Drawing.Point(671, 95);
            this.cbLabels.Name = "cbLabels";
            this.cbLabels.Size = new System.Drawing.Size(151, 28);
            this.cbLabels.TabIndex = 3;
            // 
            // btAddLabel
            // 
            this.btAddLabel.Location = new System.Drawing.Point(852, 94);
            this.btAddLabel.Name = "btAddLabel";
            this.btAddLabel.Size = new System.Drawing.Size(94, 29);
            this.btAddLabel.TabIndex = 4;
            this.btAddLabel.Text = "Add Label";
            this.btAddLabel.UseVisualStyleBackColor = true;
            this.btAddLabel.Click += new System.EventHandler(this.btAddLabel_Click);
            // 
            // lbHeader2
            // 
            this.lbHeader2.AutoSize = true;
            this.lbHeader2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbHeader2.Location = new System.Drawing.Point(668, 160);
            this.lbHeader2.Name = "lbHeader2";
            this.lbHeader2.Size = new System.Drawing.Size(135, 20);
            this.lbHeader2.TabIndex = 5;
            this.lbHeader2.Text = "Choosen labels";
            // 
            // lbChoosenLabels
            // 
            this.lbChoosenLabels.FormattingEnabled = true;
            this.lbChoosenLabels.ItemHeight = 20;
            this.lbChoosenLabels.Location = new System.Drawing.Point(674, 190);
            this.lbChoosenLabels.Name = "lbChoosenLabels";
            this.lbChoosenLabels.Size = new System.Drawing.Size(148, 304);
            this.lbChoosenLabels.TabIndex = 6;
            // 
            // btNext
            // 
            this.btNext.Location = new System.Drawing.Point(1113, 542);
            this.btNext.Name = "btNext";
            this.btNext.Size = new System.Drawing.Size(94, 29);
            this.btNext.TabIndex = 7;
            this.btNext.Text = "Next step";
            this.btNext.UseVisualStyleBackColor = true;
            this.btNext.Click += new System.EventHandler(this.btNext_Click);
            // 
            // ManuelLabelingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1226, 585);
            this.Controls.Add(this.btNext);
            this.Controls.Add(this.lbChoosenLabels);
            this.Controls.Add(this.lbHeader2);
            this.Controls.Add(this.btAddLabel);
            this.Controls.Add(this.cbLabels);
            this.Controls.Add(this.btNextMail);
            this.Controls.Add(this.lbHeader);
            this.Controls.Add(this.tbMail);
            this.Name = "ManuelLabelingForm";
            this.Text = "ManuelLabelingForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tbMail;
        private Label lbHeader;
        private Button btNextMail;
        private ComboBox cbLabels;
        private Button btAddLabel;
        private Label lbHeader2;
        private ListBox lbChoosenLabels;
        private Button btNext;
    }
}