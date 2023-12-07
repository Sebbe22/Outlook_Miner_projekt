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
            lbHeader = new Label();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox4 = new CheckBox();
            button1 = new Button();
            lbBack = new Button();
            checkBox3 = new CheckBox();
            checkBox6 = new CheckBox();
            checkBox8 = new CheckBox();
            btGoToEditor = new Button();
            checkBox5 = new CheckBox();
            SuspendLayout();
            // 
            // lbHeader
            // 
            lbHeader.AutoSize = true;
            lbHeader.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lbHeader.Location = new Point(12, 37);
            lbHeader.Margin = new Padding(2, 0, 2, 0);
            lbHeader.Name = "lbHeader";
            lbHeader.Size = new Size(316, 22);
            lbHeader.TabIndex = 1;
            lbHeader.Text = "Step 2. Choose Cleaning Methods";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(32, 87);
            checkBox1.Margin = new Padding(3, 2, 3, 2);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(168, 19);
            checkBox1.TabIndex = 4;
            checkBox1.Text = "Remove Names from body";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(32, 110);
            checkBox2.Margin = new Padding(3, 2, 3, 2);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(96, 19);
            checkBox2.TabIndex = 5;
            checkBox2.Text = "Remove links";
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Location = new Point(32, 131);
            checkBox4.Margin = new Padding(2);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(145, 19);
            checkBox4.TabIndex = 7;
            checkBox4.Text = "Remove Emailadresses";
            checkBox4.UseVisualStyleBackColor = true;
            checkBox4.CheckedChanged += checkBox4_CheckedChanged;
            // 
            // button1
            // 
            button1.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.DarkOrange;
            button1.Location = new Point(317, 272);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(58, 27);
            button1.TabIndex = 11;
            button1.Text = "Next";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lbBack
            // 
            lbBack.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lbBack.ForeColor = Color.DarkOrange;
            lbBack.Location = new Point(241, 272);
            lbBack.Margin = new Padding(2);
            lbBack.Name = "lbBack";
            lbBack.Size = new Size(54, 27);
            lbBack.TabIndex = 12;
            lbBack.Text = "Back";
            lbBack.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(32, 152);
            checkBox3.Margin = new Padding(2);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(158, 19);
            checkBox3.TabIndex = 13;
            checkBox3.Text = "Remove Phone Numbers";
            checkBox3.UseVisualStyleBackColor = true;
            checkBox3.CheckedChanged += checkBox3_CheckedChanged;
            // 
            // checkBox6
            // 
            checkBox6.AutoSize = true;
            checkBox6.Location = new Point(32, 173);
            checkBox6.Margin = new Padding(2);
            checkBox6.Name = "checkBox6";
            checkBox6.Size = new Size(206, 19);
            checkBox6.TabIndex = 14;
            checkBox6.Text = "Remove Password and Usernames";
            checkBox6.UseVisualStyleBackColor = true;
            checkBox6.CheckedChanged += checkBox6_CheckedChanged;
            // 
            // checkBox8
            // 
            checkBox8.AutoSize = true;
            checkBox8.Location = new Point(32, 219);
            checkBox8.Margin = new Padding(2);
            checkBox8.Name = "checkBox8";
            checkBox8.Size = new Size(74, 19);
            checkBox8.TabIndex = 15;
            checkBox8.Text = "Select All";
            checkBox8.UseVisualStyleBackColor = true;
            // 
            // btGoToEditor
            // 
            btGoToEditor.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btGoToEditor.ForeColor = Color.DarkOrange;
            btGoToEditor.Location = new Point(241, 236);
            btGoToEditor.Margin = new Padding(2);
            btGoToEditor.Name = "btGoToEditor";
            btGoToEditor.Size = new Size(134, 23);
            btGoToEditor.TabIndex = 16;
            btGoToEditor.Text = "Go to editor";
            btGoToEditor.UseVisualStyleBackColor = true;
            btGoToEditor.Click += btGoToEditor_Click;
            // 
            // checkBox5
            // 
            checkBox5.AutoSize = true;
            checkBox5.Location = new Point(32, 196);
            checkBox5.Margin = new Padding(2);
            checkBox5.Name = "checkBox5";
            checkBox5.Size = new Size(220, 19);
            checkBox5.TabIndex = 17;
            checkBox5.Text = "Remove everything past best regards";
            checkBox5.UseVisualStyleBackColor = true;
            // 
            // CleanUpForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(422, 340);
            Controls.Add(checkBox5);
            Controls.Add(btGoToEditor);
            Controls.Add(checkBox8);
            Controls.Add(checkBox6);
            Controls.Add(checkBox3);
            Controls.Add(lbBack);
            Controls.Add(button1);
            Controls.Add(checkBox4);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(lbHeader);
            Margin = new Padding(3, 2, 3, 2);
            Name = "CleanUpForm";
            Text = "CleanUpForm";
            ResumeLayout(false);
            PerformLayout();
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
    }
}