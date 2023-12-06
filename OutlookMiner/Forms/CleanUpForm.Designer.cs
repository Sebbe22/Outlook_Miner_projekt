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
            checkBox5 = new CheckBox();
            checkBox7 = new CheckBox();
            button1 = new Button();
            lbBack = new Button();
            checkBox3 = new CheckBox();
            checkBox6 = new CheckBox();
            checkBox8 = new CheckBox();
            SuspendLayout();
            // 
            // lbHeader
            // 
            lbHeader.AutoSize = true;
            lbHeader.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lbHeader.Location = new Point(18, 61);
            lbHeader.Margin = new Padding(2, 0, 2, 0);
            lbHeader.Name = "lbHeader";
            lbHeader.Size = new Size(476, 32);
            lbHeader.TabIndex = 1;
            lbHeader.Text = "Step 2. Choose Cleaning Methods";
            lbHeader.Click += lbHeader_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(45, 145);
            checkBox1.Margin = new Padding(4);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(253, 29);
            checkBox1.TabIndex = 4;
            checkBox1.Text = "Remove Names from body";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(45, 182);
            checkBox2.Margin = new Padding(4);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(142, 29);
            checkBox2.TabIndex = 5;
            checkBox2.Text = "Remove links";
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.CheckedChanged += checkBox2_CheckedChanged;
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
            checkBox5.AutoSize = true;
            checkBox5.Location = new Point(45, 295);
            checkBox5.Margin = new Padding(4);
            checkBox5.Name = "checkBox5";
            checkBox5.Size = new Size(360, 29);
            checkBox5.TabIndex = 8;
            checkBox5.Text = "Devide mails into questions and answers";
            checkBox5.UseVisualStyleBackColor = true;
            // 
            // CBRemoveAfterBestRegards
            // 
            checkBox7.AutoSize = true;
            checkBox7.Location = new Point(45, 222);
            checkBox7.Margin = new Padding(4);
            checkBox7.Name = "checkBox7";
            checkBox7.Size = new Size(202, 29);
            checkBox7.TabIndex = 10;
            checkBox7.Text = "Add thread identifier";
            checkBox7.UseVisualStyleBackColor = true;
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
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(42, 341);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(235, 29);
            checkBox3.TabIndex = 13;
            checkBox3.Text = "Remove Phone Numbers";
            checkBox3.UseVisualStyleBackColor = true;
            checkBox3.CheckedChanged += checkBox3_CheckedChanged;
            // 
            // checkBox6
            // 
            checkBox6.AutoSize = true;
            checkBox6.Location = new Point(41, 387);
            checkBox6.Name = "checkBox6";
            checkBox6.Size = new Size(279, 29);
            checkBox6.TabIndex = 14;
            checkBox6.Text = "Remove Password & Usernames";
            checkBox6.UseVisualStyleBackColor = true;
            checkBox6.CheckedChanged += checkBox6_CheckedChanged;
            // 
            // checkBox8
            // 
            checkBox8.AutoSize = true;
            checkBox8.Location = new Point(41, 431);
            checkBox8.Name = "checkBox8";
            checkBox8.Size = new Size(109, 29);
            checkBox8.TabIndex = 15;
            checkBox8.Text = "Select All";
            checkBox8.UseVisualStyleBackColor = true;
            checkBox8.CheckedChanged += checkBox8_CheckedChanged;
            // 
            // CleanUpForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(602, 566);
            Controls.Add(checkBox8);
            Controls.Add(checkBox6);
            Controls.Add(checkBox3);
            Controls.Add(lbBack);
            Controls.Add(button1);
            Controls.Add(checkBox7);
            Controls.Add(checkBox5);
            Controls.Add(checkBox4);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(lbHeader);
            Margin = new Padding(4);
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
    }
}