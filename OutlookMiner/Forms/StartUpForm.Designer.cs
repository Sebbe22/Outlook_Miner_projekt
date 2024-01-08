namespace OutlookMiner.Forms
{
    partial class StartUpForm
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
            panel1 = new Panel();
            button3 = new Button();
            btnManualClean = new Button();
            btnAutoClean = new Button();
            PanelLogo = new Panel();
            btnCloseForms = new Button();
            PanelChildForm = new Panel();
            lbLabelManagementDescription = new Label();
            lbHeaderLabelManagement = new Label();
            lbManualCleanDescription = new Label();
            lbHeaderManualClean = new Label();
            lbAutoCleanDescription = new Label();
            lbAutomaticClean = new Label();
            label2 = new Label();
            panelHeader = new Panel();
            lbHeader = new Label();
            panel1.SuspendLayout();
            PanelLogo.SuspendLayout();
            PanelChildForm.SuspendLayout();
            panelHeader.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(51, 51, 76);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(btnManualClean);
            panel1.Controls.Add(btnAutoClean);
            panel1.Controls.Add(PanelLogo);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(175, 459);
            panel1.TabIndex = 0;
            // 
            // button3
            // 
            button3.Dock = DockStyle.Top;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = Color.Gainsboro;
            button3.Location = new Point(0, 150);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Padding = new Padding(10, 0, 0, 0);
            button3.Size = new Size(175, 45);
            button3.TabIndex = 3;
            button3.Text = "Label Management";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // btnManualClean
            // 
            btnManualClean.Dock = DockStyle.Top;
            btnManualClean.FlatAppearance.BorderSize = 0;
            btnManualClean.FlatStyle = FlatStyle.Flat;
            btnManualClean.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnManualClean.ForeColor = Color.Gainsboro;
            btnManualClean.Location = new Point(0, 105);
            btnManualClean.Margin = new Padding(3, 2, 3, 2);
            btnManualClean.Name = "btnManualClean";
            btnManualClean.Padding = new Padding(10, 0, 0, 0);
            btnManualClean.Size = new Size(175, 45);
            btnManualClean.TabIndex = 2;
            btnManualClean.Text = "Manual Clean";
            btnManualClean.UseVisualStyleBackColor = true;
            btnManualClean.Click += button2_Click;
            // 
            // btnAutoClean
            // 
            btnAutoClean.Dock = DockStyle.Top;
            btnAutoClean.FlatAppearance.BorderSize = 0;
            btnAutoClean.FlatStyle = FlatStyle.Flat;
            btnAutoClean.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAutoClean.ForeColor = Color.Gainsboro;
            btnAutoClean.Location = new Point(0, 60);
            btnAutoClean.Margin = new Padding(3, 2, 3, 2);
            btnAutoClean.Name = "btnAutoClean";
            btnAutoClean.Padding = new Padding(10, 0, 0, 0);
            btnAutoClean.Size = new Size(175, 45);
            btnAutoClean.TabIndex = 1;
            btnAutoClean.Text = "Auto Clean";
            btnAutoClean.UseVisualStyleBackColor = true;
            btnAutoClean.Click += button1_Click;
            // 
            // PanelLogo
            // 
            PanelLogo.BackColor = Color.FromArgb(39, 39, 58);
            PanelLogo.Controls.Add(btnCloseForms);
            PanelLogo.Dock = DockStyle.Top;
            PanelLogo.Location = new Point(0, 0);
            PanelLogo.Margin = new Padding(3, 2, 3, 2);
            PanelLogo.Name = "PanelLogo";
            PanelLogo.Size = new Size(175, 60);
            PanelLogo.TabIndex = 0;
            // 
            // btnCloseForms
            // 
            btnCloseForms.BackColor = Color.FromArgb(39, 39, 58);
            btnCloseForms.FlatAppearance.BorderSize = 0;
            btnCloseForms.FlatStyle = FlatStyle.Flat;
            btnCloseForms.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCloseForms.ForeColor = Color.Gainsboro;
            btnCloseForms.Location = new Point(17, 15);
            btnCloseForms.Name = "btnCloseForms";
            btnCloseForms.Size = new Size(128, 31);
            btnCloseForms.TabIndex = 0;
            btnCloseForms.Text = "Outlook Miner";
            btnCloseForms.UseVisualStyleBackColor = false;
            btnCloseForms.Click += btnCloseForms_Click;
            // 
            // PanelChildForm
            // 
            PanelChildForm.Controls.Add(lbLabelManagementDescription);
            PanelChildForm.Controls.Add(lbHeaderLabelManagement);
            PanelChildForm.Controls.Add(lbManualCleanDescription);
            PanelChildForm.Controls.Add(lbHeaderManualClean);
            PanelChildForm.Controls.Add(lbAutoCleanDescription);
            PanelChildForm.Controls.Add(lbAutomaticClean);
            PanelChildForm.Controls.Add(label2);
            PanelChildForm.Dock = DockStyle.Fill;
            PanelChildForm.Location = new Point(175, 0);
            PanelChildForm.Margin = new Padding(3, 2, 3, 2);
            PanelChildForm.Name = "PanelChildForm";
            PanelChildForm.Size = new Size(844, 459);
            PanelChildForm.TabIndex = 2;
            // 
            // lbLabelManagementDescription
            // 
            lbLabelManagementDescription.AutoSize = true;
            lbLabelManagementDescription.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbLabelManagementDescription.Location = new Point(35, 353);
            lbLabelManagementDescription.Name = "lbLabelManagementDescription";
            lbLabelManagementDescription.Size = new Size(699, 34);
            lbLabelManagementDescription.TabIndex = 6;
            lbLabelManagementDescription.Text = "Manage labels. \r\nAssign search words when adding labels and see them being used in the Auto labeling process.";
            // 
            // lbHeaderLabelManagement
            // 
            lbHeaderLabelManagement.AutoSize = true;
            lbHeaderLabelManagement.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbHeaderLabelManagement.ForeColor = Color.Black;
            lbHeaderLabelManagement.Location = new Point(35, 309);
            lbHeaderLabelManagement.Name = "lbHeaderLabelManagement";
            lbHeaderLabelManagement.Size = new Size(183, 22);
            lbHeaderLabelManagement.TabIndex = 5;
            lbHeaderLabelManagement.Text = "Label Management";
            // 
            // lbManualCleanDescription
            // 
            lbManualCleanDescription.AutoSize = true;
            lbManualCleanDescription.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbManualCleanDescription.Location = new Point(35, 264);
            lbManualCleanDescription.Name = "lbManualCleanDescription";
            lbManualCleanDescription.Size = new Size(704, 17);
            lbManualCleanDescription.TabIndex = 4;
            lbManualCleanDescription.Text = "Choose methods to clean mails and continue to the editing page to review each mail individually.";
            // 
            // lbHeaderManualClean
            // 
            lbHeaderManualClean.AutoSize = true;
            lbHeaderManualClean.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbHeaderManualClean.ForeColor = Color.Black;
            lbHeaderManualClean.Location = new Point(35, 218);
            lbHeaderManualClean.Name = "lbHeaderManualClean";
            lbHeaderManualClean.Size = new Size(132, 22);
            lbHeaderManualClean.TabIndex = 3;
            lbHeaderManualClean.Text = "Manual Clean";
            // 
            // lbAutoCleanDescription
            // 
            lbAutoCleanDescription.AutoSize = true;
            lbAutoCleanDescription.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbAutoCleanDescription.Location = new Point(35, 178);
            lbAutoCleanDescription.Name = "lbAutoCleanDescription";
            lbAutoCleanDescription.Size = new Size(369, 17);
            lbAutoCleanDescription.TabIndex = 2;
            lbAutoCleanDescription.Text = "Choose methods to clean mails and convert them.";
            lbAutoCleanDescription.Click += lbAutoCleanDescription_Click;
            // 
            // lbAutomaticClean
            // 
            lbAutomaticClean.AutoSize = true;
            lbAutomaticClean.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbAutomaticClean.ForeColor = Color.Black;
            lbAutomaticClean.Location = new Point(35, 138);
            lbAutomaticClean.Name = "lbAutomaticClean";
            lbAutomaticClean.Size = new Size(110, 22);
            lbAutomaticClean.TabIndex = 1;
            lbAutomaticClean.Text = "Auto Clean";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(382, 89);
            label2.Name = "label2";
            label2.Size = new Size(127, 28);
            label2.TabIndex = 0;
            label2.Text = "Welcome!";
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(0, 150, 136);
            panelHeader.Controls.Add(lbHeader);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(175, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(844, 60);
            panelHeader.TabIndex = 3;
            // 
            // lbHeader
            // 
            lbHeader.AutoSize = true;
            lbHeader.Font = new Font("Arial Rounded MT Bold", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbHeader.ForeColor = Color.White;
            lbHeader.Location = new Point(6, 14);
            lbHeader.Name = "lbHeader";
            lbHeader.Size = new Size(159, 32);
            lbHeader.TabIndex = 0;
            lbHeader.Text = "Dashboard";
            // 
            // StartUpForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1019, 459);
            Controls.Add(panelHeader);
            Controls.Add(PanelChildForm);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "StartUpForm";
            Text = "StartUpForm";
            panel1.ResumeLayout(false);
            PanelLogo.ResumeLayout(false);
            PanelChildForm.ResumeLayout(false);
            PanelChildForm.PerformLayout();
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button3;
        private Button btnManualClean;
        private Button btnAutoClean;
        private Panel PanelLogo;
        private Label label1;

        public Panel PanelChildForm;
        private Panel panelHeader;
        private Label lbHeader;
        private Label lbAutomaticClean;
        private Label label2;
        private Label lbLabelManagementDescription;
        private Label lbHeaderLabelManagement;
        private Label lbManualCleanDescription;
        private Label lbHeaderManualClean;
        private Label lbAutoCleanDescription;
        private Button btnCloseForms;
    }
}