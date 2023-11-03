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
            lbSaveLocation = new Label();
            lbHeader = new Label();
            lbFileChosen = new Label();
            chooseFile = new Button();
            btNext = new Button();
            lbMailCount = new Label();
            SuspendLayout();
            // 
            // lbSaveLocation
            // 
            lbSaveLocation.AutoSize = true;
            lbSaveLocation.Location = new Point(24, 135);
            lbSaveLocation.Name = "lbSaveLocation";
            lbSaveLocation.Size = new Size(0, 15);
            lbSaveLocation.TabIndex = 6;
            // 
            // lbHeader
            // 
            lbHeader.AutoSize = true;
            lbHeader.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lbHeader.Location = new Point(15, 46);
            lbHeader.Name = "lbHeader";
            lbHeader.Size = new Size(196, 22);
            lbHeader.TabIndex = 10;
            lbHeader.Text = "Step 1. Choose a file";
            // 
            // lbFileChosen
            // 
            lbFileChosen.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbFileChosen.AutoSize = true;
            lbFileChosen.BackColor = SystemColors.AppWorkspace;
            lbFileChosen.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lbFileChosen.Location = new Point(109, 131);
            lbFileChosen.MaximumSize = new Size(219, 150);
            lbFileChosen.MinimumSize = new Size(219, 15);
            lbFileChosen.Name = "lbFileChosen";
            lbFileChosen.Size = new Size(219, 16);
            lbFileChosen.TabIndex = 11;
            lbFileChosen.Text = "File Name";
            // 
            // chooseFile
            // 
            chooseFile.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 1);
            chooseFile.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            chooseFile.ForeColor = Color.Black;
            chooseFile.Location = new Point(175, 195);
            chooseFile.Margin = new Padding(3, 2, 3, 2);
            chooseFile.Name = "chooseFile";
            chooseFile.Size = new Size(88, 22);
            chooseFile.TabIndex = 12;
            chooseFile.Text = "Choose file";
            chooseFile.UseVisualStyleBackColor = true;
            chooseFile.Click += chooseFile_Click_1;
            // 
            // btNext
            // 
            btNext.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btNext.FlatAppearance.BorderColor = Color.White;
            btNext.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btNext.ForeColor = Color.DarkOrange;
            btNext.Location = new Point(315, 304);
            btNext.Margin = new Padding(3, 2, 3, 2);
            btNext.Name = "btNext";
            btNext.Size = new Size(92, 27);
            btNext.TabIndex = 13;
            btNext.Text = "Next";
            btNext.UseVisualStyleBackColor = false;
            btNext.Click += btNext_Click;
            // 
            // lbMailCount
            // 
            lbMailCount.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbMailCount.AutoSize = true;
            lbMailCount.BackColor = Color.Transparent;
            lbMailCount.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lbMailCount.Location = new Point(109, 235);
            lbMailCount.MaximumSize = new Size(219, 150);
            lbMailCount.MinimumSize = new Size(219, 15);
            lbMailCount.Name = "lbMailCount";
            lbMailCount.Size = new Size(219, 16);
            lbMailCount.TabIndex = 15;
            lbMailCount.Click += lbMailCount_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(424, 346);
            Controls.Add(lbMailCount);
            Controls.Add(btNext);
            Controls.Add(chooseFile);
            Controls.Add(lbFileChosen);
            Controls.Add(lbHeader);
            Controls.Add(lbSaveLocation);
            Margin = new Padding(3, 2, 3, 2);
            MinimumSize = new Size(440, 385);
            Name = "Form1";
            Text = "OutLookMiner 1.0";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lbSaveLocation;
        private Label lbHeader;
        private Button chooseFile;
        private Button btNext;
        public Label lbFileChosen;
        public Label lbMailCount;
    }
}