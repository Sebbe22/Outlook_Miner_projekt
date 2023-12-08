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
            this.button1 = new System.Windows.Forms.Button();
            this.lbBack = new System.Windows.Forms.Button();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            this.btGoToEditor = new System.Windows.Forms.Button();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
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
            this.checkBox1.Location = new System.Drawing.Point(37, 116);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(209, 24);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "Remove Names from body";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(37, 147);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(118, 24);
            this.checkBox2.TabIndex = 5;
            this.checkBox2.Text = "Remove links";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(37, 175);
            this.checkBox4.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(182, 24);
            this.checkBox4.TabIndex = 7;
            this.checkBox4.Text = "Remove Emailadresses";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.DarkOrange;
            this.button1.Location = new System.Drawing.Point(365, 405);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 36);
            this.button1.TabIndex = 11;
            this.button1.Text = "Next";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbBack
            // 
            this.lbBack.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbBack.ForeColor = System.Drawing.Color.DarkOrange;
            this.lbBack.Location = new System.Drawing.Point(253, 405);
            this.lbBack.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.lbBack.Name = "lbBack";
            this.lbBack.Size = new System.Drawing.Size(83, 36);
            this.lbBack.TabIndex = 12;
            this.lbBack.Text = "Back";
            this.lbBack.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(37, 203);
            this.checkBox3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(194, 24);
            this.checkBox3.TabIndex = 13;
            this.checkBox3.Text = "Remove Phone Numbers";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(37, 231);
            this.checkBox6.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(255, 24);
            this.checkBox6.TabIndex = 14;
            this.checkBox6.Text = "Remove Password and Usernames";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox8
            // 
            this.checkBox8.AutoSize = true;
            this.checkBox8.Location = new System.Drawing.Point(37, 324);
            this.checkBox8.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(93, 24);
            this.checkBox8.TabIndex = 15;
            this.checkBox8.Text = "Select All";
            this.checkBox8.UseVisualStyleBackColor = true;
            // 
            // btGoToEditor
            // 
            this.btGoToEditor.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btGoToEditor.ForeColor = System.Drawing.Color.DarkOrange;
            this.btGoToEditor.Location = new System.Drawing.Point(253, 342);
            this.btGoToEditor.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btGoToEditor.Name = "btGoToEditor";
            this.btGoToEditor.Size = new System.Drawing.Size(178, 36);
            this.btGoToEditor.TabIndex = 16;
            this.btGoToEditor.Text = "Go to editor";
            this.btGoToEditor.UseVisualStyleBackColor = true;
            this.btGoToEditor.Click += new System.EventHandler(this.btGoToEditor_Click);
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(37, 261);
            this.checkBox5.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(276, 24);
            this.checkBox5.TabIndex = 17;
            this.checkBox5.Text = "Remove everything past best regards";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.Location = new System.Drawing.Point(37, 294);
            this.checkBox7.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(188, 24);
            this.checkBox7.TabIndex = 18;
            this.checkBox7.Text = "Add automatic labeling";
            this.checkBox7.UseVisualStyleBackColor = true;
            this.checkBox7.CheckedChanged += new System.EventHandler(this.checkBox7_CheckedChanged);
            // 
            // CleanUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 453);
            this.Controls.Add(this.checkBox7);
            this.Controls.Add(this.checkBox5);
            this.Controls.Add(this.btGoToEditor);
            this.Controls.Add(this.checkBox8);
            this.Controls.Add(this.checkBox6);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.lbBack);
            this.Controls.Add(this.button1);
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
        private CheckBox checkBox3;
        private CheckBox checkBox6;
        private CheckBox checkBox8;
        private Button btGoToEditor;
        private CheckBox checkBox5;
        private CheckBox checkBox7;
    }
}