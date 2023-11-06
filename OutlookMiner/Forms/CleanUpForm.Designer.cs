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
            checkBox3 = new CheckBox();
            checkBox4 = new CheckBox();
            checkBox5 = new CheckBox();
            checkBox6 = new CheckBox();
            checkBox7 = new CheckBox();
            button1 = new Button();
            lbBack = new Button();
            SuspendLayout();
            // 
            // lbHeader
            // 
            lbHeader.AutoSize = true;
            lbHeader.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lbHeader.Location = new Point(21, 76);
            lbHeader.Margin = new Padding(4, 0, 4, 0);
            lbHeader.Name = "lbHeader";
            lbHeader.Size = new Size(476, 32);
            lbHeader.TabIndex = 1;
            lbHeader.Text = "Step 2. Choose Cleaning Methods";
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
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(45, 220);
            checkBox3.Margin = new Padding(4);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(168, 29);
            checkBox3.TabIndex = 6;
            checkBox3.Text = "Remove Pictures";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Location = new Point(45, 258);
            checkBox4.Margin = new Padding(4);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(217, 29);
            checkBox4.TabIndex = 7;
            checkBox4.Text = "Remove Emailadresses";
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox5
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
            // checkBox6
            // 
            checkBox6.AutoSize = true;
            checkBox6.Location = new Point(45, 332);
            checkBox6.Margin = new Padding(4);
            checkBox6.Name = "checkBox6";
            checkBox6.Size = new Size(199, 29);
            checkBox6.TabIndex = 9;
            checkBox6.Text = "Remove mail header";
            checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox7
            // 
            checkBox7.AutoSize = true;
            checkBox7.Location = new Point(45, 370);
            checkBox7.Margin = new Padding(4);
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
            button1.Location = new Point(360, 406);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 11;
            button1.Text = "Next";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lbBack
            // 
            lbBack.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lbBack.ForeColor = Color.DarkOrange;
            lbBack.Location = new Point(236, 406);
            lbBack.Name = "lbBack";
            lbBack.Size = new Size(94, 29);
            lbBack.TabIndex = 12;
            lbBack.Text = "Back";
            lbBack.UseVisualStyleBackColor = true;
            lbBack.Click += lbBack_Click;
            // 
            // CleanUpForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(602, 566);
            Controls.Add(lbBack);
            Controls.Add(button1);
            Controls.Add(checkBox7);
            Controls.Add(checkBox6);
            Controls.Add(checkBox5);
            Controls.Add(checkBox4);
            Controls.Add(checkBox3);
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
        private CheckBox checkBox3;
        public CheckBox checkBox4;
        private CheckBox checkBox5;
        private CheckBox checkBox6;
        private CheckBox checkBox7;
        private Button button1;
        private Button lbBack;
        public CheckBox checkBox2;
    }
}