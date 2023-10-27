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
            this.lbHeader = new System.Windows.Forms.Label();
            this.btConvertFile = new System.Windows.Forms.Button();
            this.btBack = new System.Windows.Forms.Button();
            this.lbGoToStart = new System.Windows.Forms.Button();
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
            this.btConvertFile.Location = new System.Drawing.Point(200, 200);
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
            // ConvertForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 453);
            this.Controls.Add(this.lbGoToStart);
            this.Controls.Add(this.btBack);
            this.Controls.Add(this.btConvertFile);
            this.Controls.Add(this.lbHeader);
            this.Name = "ConvertForm";
            this.Text = "ConvertForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbHeader;
        private Button btConvertFile;
        private Button btBack;
        private Button lbGoToStart;
    }
}