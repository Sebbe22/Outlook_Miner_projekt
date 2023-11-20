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
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(45, 145);
            checkBox1.Margin = new Padding(4, 4, 4, 4);
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
            checkBox2.Margin = new Padding(4, 4, 4, 4);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(142, 29);
            checkBox2.TabIndex = 5;
            checkBox2.Text = "Remove links";
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Location = new Point(45, 259);
            checkBox4.Margin = new Padding(2);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(217, 29);
            checkBox4.TabIndex = 7;
            checkBox4.Text = "Remove Emailadresses";
            checkBox4.UseVisualStyleBackColor = true;
            checkBox4.CheckedChanged += checkBox4_CheckedChanged;
            // 
            // checkBox5
            // 
            checkBox5.AutoSize = true;
            checkBox5.Location = new Point(45, 295);
            checkBox5.Margin = new Padding(4, 4, 4, 4);
            checkBox5.Name = "checkBox5";
            checkBox5.Size = new Size(360, 29);
            checkBox5.TabIndex = 8;
            checkBox5.Text = "Devide mails into questions and answers";
            checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox7
            // 
            checkBox7.AutoSize = true;
            checkBox7.Location = new Point(45, 222);
            checkBox7.Margin = new Padding(4, 4, 4, 4);
            checkBox7.Name = "checkBox7";
            checkBox7.Size = new Size(202, 29);
            checkBox7.TabIndex = 10;
            checkBox7.Text = "Add thread identifier";
            checkBox7.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.DarkOrange;
            button1.Location = new Point(436, 476);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(102, 39);
            button1.TabIndex = 11;
            button1.Text = "Next";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lbBack
            // 
            lbBack.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lbBack.ForeColor = Color.DarkOrange;
            lbBack.Location = new Point(302, 476);
            lbBack.Margin = new Padding(2);
            lbBack.Name = "lbBack";
            lbBack.Size = new Size(98, 35);
            lbBack.TabIndex = 12;
            lbBack.Text = "Back";
            lbBack.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(42, 341);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(121, 29);
            checkBox3.TabIndex = 13;
            checkBox3.Text = "checkBox3";
            checkBox3.UseVisualStyleBackColor = true;
            checkBox3.CheckedChanged += checkBox3_CheckedChanged;
            // 
            // CleanUpForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(602, 566);
            Controls.Add(checkBox3);
            Controls.Add(lbBack);
            Controls.Add(button1);
            Controls.Add(checkBox7);
            Controls.Add(checkBox5);
            Controls.Add(checkBox4);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(lbHeader);
            Margin = new Padding(4, 4, 4, 4);
            Name = "CleanUpForm";
            Text = "CleanUpForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbHeader;
        private CheckBox checkBox1;
        public CheckBox checkBox4;
        private CheckBox checkBox5;
        private CheckBox checkBox7;
        private Button button1;
        private Button lbBack;
        public CheckBox checkBox2;
        private CheckBox checkBox3;
    }
}