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
            this.textBoxEditing = new System.Windows.Forms.TextBox();
            this.btBackMail = new System.Windows.Forms.Button();
            this.lbNextMail = new System.Windows.Forms.Button();
            this.DDLabels = new System.Windows.Forms.ComboBox();
            this.btAddLabel = new System.Windows.Forms.Button();
            this.btNext = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxEditing
            // 
            this.textBoxEditing.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxEditing.Location = new System.Drawing.Point(24, 33);
            this.textBoxEditing.Multiline = true;
            this.textBoxEditing.Name = "textBoxEditing";
            this.textBoxEditing.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxEditing.Size = new System.Drawing.Size(421, 369);
            this.textBoxEditing.TabIndex = 0;
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
            // EditingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btNext);
            this.Controls.Add(this.btAddLabel);
            this.Controls.Add(this.DDLabels);
            this.Controls.Add(this.lbNextMail);
            this.Controls.Add(this.btBackMail);
            this.Controls.Add(this.textBoxEditing);
            this.Name = "EditingForm";
            this.Text = "EditingForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBoxEditing;
        private Button btBackMail;
        private Button lbNextMail;
        private ComboBox DDLabels;
        private Button btAddLabel;
        private Button btNext;
    }
}