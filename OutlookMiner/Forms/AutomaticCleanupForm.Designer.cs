namespace OutlookMiner.Forms
{
    partial class AutomaticCleanupForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AutomaticCleanupForm));
            lbHeader = new Label();
            checkBox7 = new CheckBox();
            checkBox5 = new CheckBox();
            checkBox8 = new CheckBox();
            checkBox6 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox4 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox1 = new CheckBox();
            panelCleaningMethods = new Panel();
            panelButton = new Panel();
            lbMailCount = new Label();
            lbShowingStatus = new Label();
            pbLoadingGif = new PictureBox();
            btnChooseFile = new Button();
            btnConvert = new Button();
            lbFileChosen = new Label();
            panelCleaningMethods.SuspendLayout();
            panelButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbLoadingGif).BeginInit();
            SuspendLayout();
            // 
            // lbHeader
            // 
            lbHeader.AutoSize = true;
            lbHeader.Font = new Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            lbHeader.Location = new Point(23, 89);
            lbHeader.Name = "lbHeader";
            lbHeader.Size = new Size(308, 26);
            lbHeader.TabIndex = 28;
            lbHeader.Text = "Available Cleaning Methods";
            // 
            // checkBox7
            // 
            checkBox7.AutoSize = true;
            checkBox7.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox7.Location = new Point(23, 262);
            checkBox7.Margin = new Padding(2);
            checkBox7.Name = "checkBox7";
            checkBox7.Size = new Size(182, 20);
            checkBox7.TabIndex = 35;
            checkBox7.Text = "Add automatic labeling";
            checkBox7.UseVisualStyleBackColor = true;
            checkBox7.CheckedChanged += checkBox7_CheckedChanged;
            // 
            // checkBox5
            // 
            checkBox5.AutoSize = true;
            checkBox5.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox5.Location = new Point(23, 237);
            checkBox5.Margin = new Padding(2);
            checkBox5.Name = "checkBox5";
            checkBox5.Size = new Size(282, 20);
            checkBox5.TabIndex = 34;
            checkBox5.Text = "Remove everything past best regards";
            checkBox5.UseVisualStyleBackColor = true;
            checkBox5.CheckedChanged += checkBox5_CheckedChanged;
            // 
            // checkBox8
            // 
            checkBox8.AutoSize = true;
            checkBox8.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox8.Location = new Point(23, 284);
            checkBox8.Margin = new Padding(2);
            checkBox8.Name = "checkBox8";
            checkBox8.Size = new Size(90, 20);
            checkBox8.TabIndex = 33;
            checkBox8.Text = "Select All";
            checkBox8.UseVisualStyleBackColor = true;
            checkBox8.CheckedChanged += checkBox8_CheckedChanged;
            // 
            // checkBox6
            // 
            checkBox6.AutoSize = true;
            checkBox6.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox6.Location = new Point(23, 214);
            checkBox6.Margin = new Padding(2);
            checkBox6.Name = "checkBox6";
            checkBox6.Size = new Size(261, 20);
            checkBox6.TabIndex = 32;
            checkBox6.Text = "Remove Password and Usernames";
            checkBox6.UseVisualStyleBackColor = true;
            checkBox6.CheckedChanged += checkBox6_CheckedChanged;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox3.Location = new Point(23, 194);
            checkBox3.Margin = new Padding(2);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(191, 20);
            checkBox3.TabIndex = 31;
            checkBox3.Text = "Remove Phone Numbers";
            checkBox3.UseVisualStyleBackColor = true;
            checkBox3.CheckedChanged += checkBox3_CheckedChanged;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox4.Location = new Point(23, 172);
            checkBox4.Margin = new Padding(2);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(184, 20);
            checkBox4.TabIndex = 30;
            checkBox4.Text = "Remove Emailadresses";
            checkBox4.UseVisualStyleBackColor = true;
            checkBox4.CheckedChanged += checkBox4_CheckedChanged;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox2.Location = new Point(23, 152);
            checkBox2.Margin = new Padding(3, 2, 3, 2);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(116, 20);
            checkBox2.TabIndex = 29;
            checkBox2.Text = "Remove links";
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox1.Location = new Point(23, 128);
            checkBox1.Margin = new Padding(3, 2, 3, 2);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(204, 20);
            checkBox1.TabIndex = 27;
            checkBox1.Text = "Remove Names from body";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // panelCleaningMethods
            // 
            panelCleaningMethods.Controls.Add(lbHeader);
            panelCleaningMethods.Controls.Add(checkBox1);
            panelCleaningMethods.Controls.Add(checkBox7);
            panelCleaningMethods.Controls.Add(checkBox2);
            panelCleaningMethods.Controls.Add(checkBox5);
            panelCleaningMethods.Controls.Add(checkBox4);
            panelCleaningMethods.Controls.Add(checkBox8);
            panelCleaningMethods.Controls.Add(checkBox3);
            panelCleaningMethods.Controls.Add(checkBox6);
            panelCleaningMethods.Dock = DockStyle.Left;
            panelCleaningMethods.Location = new Point(0, 0);
            panelCleaningMethods.Margin = new Padding(3, 2, 3, 2);
            panelCleaningMethods.Name = "panelCleaningMethods";
            panelCleaningMethods.Size = new Size(450, 440);
            panelCleaningMethods.TabIndex = 36;
            // 
            // panelButton
            // 
            panelButton.Controls.Add(lbMailCount);
            panelButton.Controls.Add(lbShowingStatus);
            panelButton.Controls.Add(pbLoadingGif);
            panelButton.Controls.Add(btnChooseFile);
            panelButton.Controls.Add(btnConvert);
            panelButton.Controls.Add(lbFileChosen);
            panelButton.Dock = DockStyle.Right;
            panelButton.Location = new Point(456, 0);
            panelButton.Name = "panelButton";
            panelButton.Size = new Size(440, 440);
            panelButton.TabIndex = 37;
            // 
            // lbMailCount
            // 
            lbMailCount.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbMailCount.AutoSize = true;
            lbMailCount.BackColor = Color.Transparent;
            lbMailCount.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lbMailCount.Location = new Point(110, 128);
            lbMailCount.MaximumSize = new Size(219, 150);
            lbMailCount.MinimumSize = new Size(219, 15);
            lbMailCount.Name = "lbMailCount";
            lbMailCount.Size = new Size(219, 16);
            lbMailCount.TabIndex = 48;
            // 
            // lbShowingStatus
            // 
            lbShowingStatus.Anchor = AnchorStyles.Top;
            lbShowingStatus.AutoSize = true;
            lbShowingStatus.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lbShowingStatus.Location = new Point(169, 353);
            lbShowingStatus.Margin = new Padding(4, 0, 4, 0);
            lbShowingStatus.Name = "lbShowingStatus";
            lbShowingStatus.Size = new Size(105, 16);
            lbShowingStatus.TabIndex = 47;
            lbShowingStatus.Text = "Fetching Mails";
            // 
            // pbLoadingGif
            // 
            pbLoadingGif.Anchor = AnchorStyles.Top;
            pbLoadingGif.Image = (Image)resources.GetObject("pbLoadingGif.Image");
            pbLoadingGif.Location = new Point(185, 202);
            pbLoadingGif.Margin = new Padding(4, 3, 4, 3);
            pbLoadingGif.Name = "pbLoadingGif";
            pbLoadingGif.Size = new Size(75, 148);
            pbLoadingGif.TabIndex = 46;
            pbLoadingGif.TabStop = false;
            // 
            // btnChooseFile
            // 
            btnChooseFile.Anchor = AnchorStyles.Top;
            btnChooseFile.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 1);
            btnChooseFile.FlatStyle = FlatStyle.Flat;
            btnChooseFile.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnChooseFile.ForeColor = Color.Black;
            btnChooseFile.Location = new Point(164, 165);
            btnChooseFile.Margin = new Padding(4, 3, 4, 3);
            btnChooseFile.Name = "btnChooseFile";
            btnChooseFile.Size = new Size(110, 27);
            btnChooseFile.TabIndex = 45;
            btnChooseFile.Text = "Choose file";
            btnChooseFile.UseVisualStyleBackColor = true;
            btnChooseFile.Click += btnChooseFile_Click;
            // 
            // btnConvert
            // 
            btnConvert.Anchor = AnchorStyles.Bottom;
            btnConvert.FlatStyle = FlatStyle.Flat;
            btnConvert.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnConvert.ForeColor = Color.DarkOrange;
            btnConvert.Location = new Point(144, 392);
            btnConvert.Margin = new Padding(2);
            btnConvert.Name = "btnConvert";
            btnConvert.Size = new Size(163, 27);
            btnConvert.TabIndex = 43;
            btnConvert.Text = "Convert";
            btnConvert.UseVisualStyleBackColor = true;
            btnConvert.Click += btnConvert_Click;
            // 
            // lbFileChosen
            // 
            lbFileChosen.Anchor = AnchorStyles.Top;
            lbFileChosen.AutoSize = true;
            lbFileChosen.BackColor = SystemColors.AppWorkspace;
            lbFileChosen.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lbFileChosen.Location = new Point(78, 87);
            lbFileChosen.Margin = new Padding(4, 0, 4, 0);
            lbFileChosen.MaximumSize = new Size(273, 188);
            lbFileChosen.MinimumSize = new Size(273, 19);
            lbFileChosen.Name = "lbFileChosen";
            lbFileChosen.Size = new Size(273, 19);
            lbFileChosen.TabIndex = 44;
            lbFileChosen.Text = "File Name";
            // 
            // AutomaticCleanupForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(896, 440);
            Controls.Add(panelButton);
            Controls.Add(panelCleaningMethods);
            Margin = new Padding(3, 2, 3, 2);
            Name = "AutomaticCleanupForm";
            Text = "AutomaticCleanupForm";
            panelCleaningMethods.ResumeLayout(false);
            panelCleaningMethods.PerformLayout();
            panelButton.ResumeLayout(false);
            panelButton.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbLoadingGif).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lbHeader;
        private CheckBox checkBox7;
        private CheckBox checkBox5;
        private CheckBox checkBox8;
        private CheckBox checkBox6;
        private CheckBox checkBox3;
        public CheckBox checkBox4;
        public CheckBox checkBox2;
        private CheckBox checkBox1;
        private Panel panelCleaningMethods;
        private Panel panelButton;
        public Label lbMailCount;
        private Label lbShowingStatus;
        private PictureBox pbLoadingGif;
        private Button btnChooseFile;
        private Button btnConvert;
        public Label lbFileChosen;
    }
}