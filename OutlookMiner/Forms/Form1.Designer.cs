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
            this.lbSaveLocation = new System.Windows.Forms.Label();
            this.lbHeader = new System.Windows.Forms.Label();
            this.lbFileChosen = new System.Windows.Forms.Label();
            this.chooseFile = new System.Windows.Forms.Button();
            this.btNext = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbSaveLocation
            // 
            this.lbSaveLocation.AutoSize = true;
            this.lbSaveLocation.Location = new System.Drawing.Point(27, 180);
            this.lbSaveLocation.Name = "lbSaveLocation";
            this.lbSaveLocation.Size = new System.Drawing.Size(0, 20);
            this.lbSaveLocation.TabIndex = 6;
            // 
            // lbHeader
            // 
            this.lbHeader.AutoSize = true;
            this.lbHeader.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbHeader.Location = new System.Drawing.Point(17, 61);
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
            this.lbFileChosen.Location = new System.Drawing.Point(125, 175);
            this.lbFileChosen.MaximumSize = new System.Drawing.Size(250, 200);
            this.lbFileChosen.MinimumSize = new System.Drawing.Size(250, 20);
            this.lbFileChosen.Name = "lbFileChosen";
            this.lbFileChosen.Size = new System.Drawing.Size(250, 20);
            this.lbFileChosen.TabIndex = 11;
            this.lbFileChosen.Text = "File Name";
            // 
            // chooseFile
            // 
            this.chooseFile.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.chooseFile.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chooseFile.ForeColor = System.Drawing.Color.Black;
            this.chooseFile.Location = new System.Drawing.Point(200, 260);
            this.chooseFile.Name = "chooseFile";
            this.chooseFile.Size = new System.Drawing.Size(100, 29);
            this.chooseFile.TabIndex = 12;
            this.chooseFile.Text = "Choose file";
            this.chooseFile.UseVisualStyleBackColor = true;
            this.chooseFile.Click += new System.EventHandler(this.chooseFile_Click_1);
            // 
            // btNext
            // 
            this.btNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btNext.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btNext.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btNext.ForeColor = System.Drawing.Color.DarkOrange;
            this.btNext.Location = new System.Drawing.Point(360, 406);
            this.btNext.Name = "btNext";
            this.btNext.Size = new System.Drawing.Size(105, 36);
            this.btNext.TabIndex = 13;
            this.btNext.Text = "Next";
            this.btNext.UseVisualStyleBackColor = false;
            this.btNext.Click += new System.EventHandler(this.btNext_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 453);
            this.Controls.Add(this.btNext);
            this.Controls.Add(this.chooseFile);
            this.Controls.Add(this.lbFileChosen);
            this.Controls.Add(this.lbHeader);
            this.Controls.Add(this.lbSaveLocation);
            this.MinimumSize = new System.Drawing.Size(500, 500);
            this.Name = "Form1";
            this.Text = "OutLookMiner 1.0";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label lbSaveLocation;
        private Label lbHeader;
        private Button chooseFile;
        private Button btNext;
        public Label lbFileChosen;
    }
}