namespace OutlookMiner.Forms
{
    partial class ManualCleanupForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManualCleanupForm));
            panel1 = new Panel();
            lbHeader = new Label();
            checkBox5 = new CheckBox();
            checkBox8 = new CheckBox();
            checkBox6 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox4 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox1 = new CheckBox();
            lbFileChosen = new Label();
            panel2 = new Panel();
            btnGoToEditor = new Button();
            lbMailCount = new Label();
            lbShowingStatus = new Label();
            pbLoadingGif = new PictureBox();
            btnChooseFile = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbLoadingGif).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(lbHeader);
            panel1.Controls.Add(checkBox5);
            panel1.Controls.Add(checkBox8);
            panel1.Controls.Add(checkBox6);
            panel1.Controls.Add(checkBox3);
            panel1.Controls.Add(checkBox4);
            panel1.Controls.Add(checkBox2);
            panel1.Controls.Add(checkBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(457, 413);
            panel1.TabIndex = 0;
            // 
            // lbHeader
            // 
            lbHeader.AutoSize = true;
            lbHeader.Font = new Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            lbHeader.Location = new Point(22, 85);
            lbHeader.Name = "lbHeader";
            lbHeader.Size = new Size(308, 26);
            lbHeader.TabIndex = 20;
            lbHeader.Text = "Available Cleaning Methods";
            // 
            // checkBox5
            // 
            checkBox5.AutoSize = true;
            checkBox5.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox5.Location = new Point(48, 233);
            checkBox5.Margin = new Padding(2);
            checkBox5.Name = "checkBox5";
            checkBox5.Size = new Size(282, 20);
            checkBox5.TabIndex = 25;
            checkBox5.Text = "Remove everything past best regards";
            checkBox5.UseVisualStyleBackColor = true;
            checkBox5.CheckedChanged += checkBox5_CheckedChanged;
            // 
            // checkBox8
            // 
            checkBox8.AutoSize = true;
            checkBox8.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox8.Location = new Point(48, 257);
            checkBox8.Margin = new Padding(2);
            checkBox8.Name = "checkBox8";
            checkBox8.Size = new Size(90, 20);
            checkBox8.TabIndex = 24;
            checkBox8.Text = "Select All";
            checkBox8.UseVisualStyleBackColor = true;
            checkBox8.CheckedChanged += checkBox8_CheckedChanged;
            // 
            // checkBox6
            // 
            checkBox6.AutoSize = true;
            checkBox6.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox6.Location = new Point(48, 211);
            checkBox6.Margin = new Padding(2);
            checkBox6.Name = "checkBox6";
            checkBox6.Size = new Size(261, 20);
            checkBox6.TabIndex = 23;
            checkBox6.Text = "Remove Password and Usernames";
            checkBox6.UseVisualStyleBackColor = true;
            checkBox6.CheckedChanged += checkBox6_CheckedChanged;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox3.Location = new Point(48, 190);
            checkBox3.Margin = new Padding(2);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(191, 20);
            checkBox3.TabIndex = 22;
            checkBox3.Text = "Remove Phone Numbers";
            checkBox3.UseVisualStyleBackColor = true;
            checkBox3.CheckedChanged += checkBox3_CheckedChanged;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox4.Location = new Point(48, 169);
            checkBox4.Margin = new Padding(2);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(184, 20);
            checkBox4.TabIndex = 21;
            checkBox4.Text = "Remove Emailadresses";
            checkBox4.UseVisualStyleBackColor = true;
            checkBox4.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox2.Location = new Point(48, 148);
            checkBox2.Margin = new Padding(3, 2, 3, 2);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(116, 20);
            checkBox2.TabIndex = 20;
            checkBox2.Text = "Remove links";
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox1.Location = new Point(48, 125);
            checkBox1.Margin = new Padding(3, 2, 3, 2);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(204, 20);
            checkBox1.TabIndex = 19;
            checkBox1.Text = "Remove Names from body";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // lbFileChosen
            // 
            lbFileChosen.Anchor = AnchorStyles.Top;
            lbFileChosen.AutoSize = true;
            lbFileChosen.BackColor = SystemColors.AppWorkspace;
            lbFileChosen.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lbFileChosen.Location = new Point(134, 85);
            lbFileChosen.Margin = new Padding(4, 0, 4, 0);
            lbFileChosen.MaximumSize = new Size(273, 188);
            lbFileChosen.MinimumSize = new Size(273, 19);
            lbFileChosen.Name = "lbFileChosen";
            lbFileChosen.Size = new Size(273, 19);
            lbFileChosen.TabIndex = 18;
            lbFileChosen.Text = "File Name";
            // 
            // panel2
            // 
            panel2.Controls.Add(btnGoToEditor);
            panel2.Controls.Add(lbMailCount);
            panel2.Controls.Add(lbShowingStatus);
            panel2.Controls.Add(pbLoadingGif);
            panel2.Controls.Add(btnChooseFile);
            panel2.Controls.Add(lbFileChosen);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(462, 0);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(494, 413);
            panel2.TabIndex = 19;
            // 
            // btnGoToEditor
            // 
            btnGoToEditor.Anchor = AnchorStyles.Bottom;
            btnGoToEditor.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 1);
            btnGoToEditor.FlatStyle = FlatStyle.Flat;
            btnGoToEditor.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnGoToEditor.ForeColor = Color.Black;
            btnGoToEditor.Location = new Point(196, 374);
            btnGoToEditor.Margin = new Padding(4, 3, 4, 3);
            btnGoToEditor.Name = "btnGoToEditor";
            btnGoToEditor.Size = new Size(148, 27);
            btnGoToEditor.TabIndex = 23;
            btnGoToEditor.Text = "Go to Editor";
            btnGoToEditor.UseVisualStyleBackColor = true;
            btnGoToEditor.Click += btnGoToEditor_Click;
            // 
            // lbMailCount
            // 
            lbMailCount.Anchor = AnchorStyles.Top;
            lbMailCount.AutoSize = true;
            lbMailCount.BackColor = Color.Transparent;
            lbMailCount.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lbMailCount.Location = new Point(161, 126);
            lbMailCount.MaximumSize = new Size(219, 150);
            lbMailCount.MinimumSize = new Size(219, 15);
            lbMailCount.Name = "lbMailCount";
            lbMailCount.Size = new Size(219, 16);
            lbMailCount.TabIndex = 22;
            // 
            // lbShowingStatus
            // 
            lbShowingStatus.Anchor = AnchorStyles.Top;
            lbShowingStatus.AutoSize = true;
            lbShowingStatus.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lbShowingStatus.Location = new Point(218, 346);
            lbShowingStatus.Margin = new Padding(4, 0, 4, 0);
            lbShowingStatus.Name = "lbShowingStatus";
            lbShowingStatus.Size = new Size(105, 16);
            lbShowingStatus.TabIndex = 21;
            lbShowingStatus.Text = "Fetching Mails";
            // 
            // pbLoadingGif
            // 
            pbLoadingGif.Anchor = AnchorStyles.Top;
            pbLoadingGif.Image = (Image)resources.GetObject("pbLoadingGif.Image");
            pbLoadingGif.Location = new Point(236, 198);
            pbLoadingGif.Margin = new Padding(4, 3, 4, 3);
            pbLoadingGif.Name = "pbLoadingGif";
            pbLoadingGif.Size = new Size(68, 139);
            pbLoadingGif.TabIndex = 20;
            pbLoadingGif.TabStop = false;
            // 
            // btnChooseFile
            // 
            btnChooseFile.Anchor = AnchorStyles.Top;
            btnChooseFile.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 1);
            btnChooseFile.FlatStyle = FlatStyle.Flat;
            btnChooseFile.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnChooseFile.ForeColor = Color.Black;
            btnChooseFile.Location = new Point(213, 165);
            btnChooseFile.Margin = new Padding(4, 3, 4, 3);
            btnChooseFile.Name = "btnChooseFile";
            btnChooseFile.Size = new Size(110, 27);
            btnChooseFile.TabIndex = 19;
            btnChooseFile.Text = "Choose file";
            btnChooseFile.UseVisualStyleBackColor = true;
            btnChooseFile.Click += btnChooseFile_Click;
            // 
            // ManualCleanupForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(956, 413);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ManualCleanupForm";
            Text = "ManualCleanupForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbLoadingGif).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private CheckBox checkBox5;
        private CheckBox checkBox8;
        private CheckBox checkBox6;
        private CheckBox checkBox3;
        public CheckBox checkBox4;
        public CheckBox checkBox2;
        private CheckBox checkBox1;
        public Label lbFileChosen;
        private Panel panel2;
        private Button chooseFile;
        private Label lbHeader;
        private Button btnChooseFile;
        private Label lbShowingStatus;
        private PictureBox pbLoadingGif;
        public Label lbMailCount;
        private Button btnGoToEditor;
    }
}