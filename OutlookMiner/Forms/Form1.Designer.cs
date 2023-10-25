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
            this.chooseFile = new System.Windows.Forms.Button();
            this.lOutput = new System.Windows.Forms.Label();
            this.lbFileChosen = new System.Windows.Forms.Label();
            this.ConvertToPDF = new System.Windows.Forms.Button();
            this.lbSaveLocation = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // chooseFile
            // 
            this.chooseFile.Location = new System.Drawing.Point(12, 50);
            this.chooseFile.Name = "chooseFile";
            this.chooseFile.Size = new System.Drawing.Size(94, 29);
            this.chooseFile.TabIndex = 2;
            this.chooseFile.Text = "Choose file";
            this.chooseFile.UseVisualStyleBackColor = true;
            this.chooseFile.Click += new System.EventHandler(this.chooseFile_Click);
            // 
            // lOutput
            // 
            this.lOutput.AutoSize = true;
            this.lOutput.Location = new System.Drawing.Point(12, 98);
            this.lOutput.Name = "lOutput";
            this.lOutput.Size = new System.Drawing.Size(51, 20);
            this.lOutput.TabIndex = 3;
            this.lOutput.Text = "empty";
            // 
            // lbFileChosen
            // 
            this.lbFileChosen.AutoSize = true;
            this.lbFileChosen.Location = new System.Drawing.Point(15, 17);
            this.lbFileChosen.Name = "lbFileChosen";
            this.lbFileChosen.Size = new System.Drawing.Size(91, 20);
            this.lbFileChosen.TabIndex = 4;
            this.lbFileChosen.Text = "File Chosen: ";
            // 
            // ConvertToPDF
            // 
            this.ConvertToPDF.Location = new System.Drawing.Point(22, 135);
            this.ConvertToPDF.Name = "ConvertToPDF";
            this.ConvertToPDF.Size = new System.Drawing.Size(135, 29);
            this.ConvertToPDF.TabIndex = 5;
            this.ConvertToPDF.Text = "ConvertToPDF";
            this.ConvertToPDF.UseVisualStyleBackColor = true;
            this.ConvertToPDF.Click += new System.EventHandler(this.ConvertToPDF_Click);
            // 
            // lbSaveLocation
            // 
            this.lbSaveLocation.AutoSize = true;
            this.lbSaveLocation.Location = new System.Drawing.Point(27, 180);
            this.lbSaveLocation.Name = "lbSaveLocation";
            this.lbSaveLocation.Size = new System.Drawing.Size(0, 20);
            this.lbSaveLocation.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 450);
            this.Controls.Add(this.lbSaveLocation);
            this.Controls.Add(this.ConvertToPDF);
            this.Controls.Add(this.lbFileChosen);
            this.Controls.Add(this.lOutput);
            this.Controls.Add(this.chooseFile);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button chooseFile;
        private Label lOutput;
        private Label lbFileChosen;
        private Button ConvertToPDF;
        private Label lbSaveLocation;
    }
}