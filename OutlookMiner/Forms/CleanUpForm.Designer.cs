namespace OutlookMiner.Forms
{
    partial class CleanUpForm
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
            this.lbHeader = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.CBRemovePhoneNumbers = new System.Windows.Forms.CheckBox();
            this.CBRemoveAfterBestRegards = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lbBack = new System.Windows.Forms.Button();
            this.btContinueToLabeling = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbHeader
            // 
            this.lbHeader.AutoSize = true;
            this.lbHeader.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbHeader.Location = new System.Drawing.Point(14, 49);
            this.lbHeader.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbHeader.Name = "lbHeader";
            this.lbHeader.Size = new System.Drawing.Size(387, 27);
            this.lbHeader.TabIndex = 1;
            this.lbHeader.Text = "Step 2. Choose Cleaning Methods";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(36, 116);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(209, 24);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "Remove Names from body";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(36, 146);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(118, 24);
            this.checkBox2.TabIndex = 5;
            this.checkBox2.Text = "Remove links";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(36, 207);
            this.checkBox4.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(182, 24);
            this.checkBox4.TabIndex = 7;
            this.checkBox4.Text = "Remove Emailadresses";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // CBRemovePhoneNumbers
            // 
            this.CBRemovePhoneNumbers.AutoSize = true;
            this.CBRemovePhoneNumbers.Location = new System.Drawing.Point(36, 236);
            this.CBRemovePhoneNumbers.Name = "CBRemovePhoneNumbers";
            this.CBRemovePhoneNumbers.Size = new System.Drawing.Size(194, 24);
            this.CBRemovePhoneNumbers.TabIndex = 8;
            this.CBRemovePhoneNumbers.Text = "Remove Phone Numbers";
            this.CBRemovePhoneNumbers.UseVisualStyleBackColor = true;
            // 
            // CBRemoveAfterBestRegards
            // 
            this.CBRemoveAfterBestRegards.AutoSize = true;
            this.CBRemoveAfterBestRegards.Location = new System.Drawing.Point(36, 178);
            this.CBRemoveAfterBestRegards.Name = "CBRemoveAfterBestRegards";
            this.CBRemoveAfterBestRegards.Size = new System.Drawing.Size(292, 24);
            this.CBRemoveAfterBestRegards.TabIndex = 10;
            this.CBRemoveAfterBestRegards.Text = "Remove everything past \"Best Regards\"";
            this.CBRemoveAfterBestRegards.UseVisualStyleBackColor = true;
            this.CBRemoveAfterBestRegards.CheckedChanged += new System.EventHandler(this.CBRemoveAfterBestRegards_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.DarkOrange;
            this.button1.Location = new System.Drawing.Point(349, 381);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 31);
            this.button1.TabIndex = 11;
            this.button1.Text = "Next";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbBack
            // 
            this.lbBack.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbBack.ForeColor = System.Drawing.Color.DarkOrange;
            this.lbBack.Location = new System.Drawing.Point(242, 381);
            this.lbBack.Margin = new System.Windows.Forms.Padding(2);
            this.lbBack.Name = "lbBack";
            this.lbBack.Size = new System.Drawing.Size(78, 28);
            this.lbBack.TabIndex = 12;
            this.lbBack.Text = "Back";
            this.lbBack.UseVisualStyleBackColor = true;
            // 
            // btContinueToLabeling
            // 
            this.btContinueToLabeling.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btContinueToLabeling.ForeColor = System.Drawing.Color.DarkOrange;
            this.btContinueToLabeling.Location = new System.Drawing.Point(242, 326);
            this.btContinueToLabeling.Margin = new System.Windows.Forms.Padding(2);
            this.btContinueToLabeling.Name = "btContinueToLabeling";
            this.btContinueToLabeling.Size = new System.Drawing.Size(189, 31);
            this.btContinueToLabeling.TabIndex = 13;
            this.btContinueToLabeling.Text = "Continue to labeling";
            this.btContinueToLabeling.UseVisualStyleBackColor = true;
            this.btContinueToLabeling.Click += new System.EventHandler(this.btContinueToLabeling_Click);
            // 
            // CleanUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 453);
            this.Controls.Add(this.btContinueToLabeling);
            this.Controls.Add(this.lbBack);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CBRemoveAfterBestRegards);
            this.Controls.Add(this.CBRemovePhoneNumbers);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.lbHeader);
            this.Name = "CleanUpForm";
            this.Text = "CleanUpForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbHeader;
        private CheckBox checkBox1;
        public CheckBox checkBox4;
        private CheckBox CBRemovePhoneNumbers;
        private CheckBox CBRemoveAfterBestRegards;
        private Button button1;
        private Button lbBack;
        public CheckBox checkBox2;
        private Button btContinueToLabeling;
    }
}