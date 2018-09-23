namespace Bandori_BP_Calculator
{
    partial class Member2
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
            this.nextButton2 = new System.Windows.Forms.Button();
            this.mem2Story2 = new System.Windows.Forms.CheckBox();
            this.mem2Story1 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mem2TextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.mem2Stars = new System.Windows.Forms.ComboBox();
            this.mem2Band = new System.Windows.Forms.ComboBox();
            this.mem2Attr = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // nextButton2
            // 
            this.nextButton2.Location = new System.Drawing.Point(193, 277);
            this.nextButton2.Name = "nextButton2";
            this.nextButton2.Size = new System.Drawing.Size(75, 23);
            this.nextButton2.TabIndex = 3;
            this.nextButton2.Text = "Next";
            this.nextButton2.UseVisualStyleBackColor = true;
            this.nextButton2.Click += new System.EventHandler(this.button1_Click);
            // 
            // mem2Story2
            // 
            this.mem2Story2.AutoSize = true;
            this.mem2Story2.Location = new System.Drawing.Point(302, 24);
            this.mem2Story2.Name = "mem2Story2";
            this.mem2Story2.Size = new System.Drawing.Size(119, 17);
            this.mem2Story2.TabIndex = 11;
            this.mem2Story2.Text = "Read Second Story";
            this.mem2Story2.UseVisualStyleBackColor = true;
            // 
            // mem2Story1
            // 
            this.mem2Story1.AutoSize = true;
            this.mem2Story1.Location = new System.Drawing.Point(195, 24);
            this.mem2Story1.Name = "mem2Story1";
            this.mem2Story1.Size = new System.Drawing.Size(101, 17);
            this.mem2Story1.TabIndex = 10;
            this.mem2Story1.Text = "Read First Story";
            this.mem2Story1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "First Member:";
            // 
            // mem2TextBox
            // 
            this.mem2TextBox.Location = new System.Drawing.Point(83, 22);
            this.mem2TextBox.Name = "mem2TextBox";
            this.mem2TextBox.Size = new System.Drawing.Size(100, 20);
            this.mem2TextBox.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.mem2Stars);
            this.groupBox1.Controls.Add(this.mem2Band);
            this.groupBox1.Controls.Add(this.mem2Story2);
            this.groupBox1.Controls.Add(this.mem2Attr);
            this.groupBox1.Controls.Add(this.mem2Story1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.mem2TextBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(428, 169);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "2nd Member Band Power Values";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 42;
            this.label2.Text = "Attribute:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 43;
            this.label3.Text = "Band:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 44;
            this.label4.Text = "Stars";
            // 
            // mem2Stars
            // 
            this.mem2Stars.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.mem2Stars.FormattingEnabled = true;
            this.mem2Stars.Items.AddRange(new object[] {
            "4",
            "3",
            "2"});
            this.mem2Stars.Location = new System.Drawing.Point(83, 52);
            this.mem2Stars.Name = "mem2Stars";
            this.mem2Stars.Size = new System.Drawing.Size(56, 21);
            this.mem2Stars.TabIndex = 41;
            // 
            // mem2Band
            // 
            this.mem2Band.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.mem2Band.FormattingEnabled = true;
            this.mem2Band.Items.AddRange(new object[] {
            "Poppin\' Party",
            "Afterglow",
            "Pastel*Palettes",
            "Roselia",
            "Hello, Happy World!"});
            this.mem2Band.Location = new System.Drawing.Point(83, 106);
            this.mem2Band.Name = "mem2Band";
            this.mem2Band.Size = new System.Drawing.Size(173, 21);
            this.mem2Band.TabIndex = 39;
            // 
            // mem2Attr
            // 
            this.mem2Attr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.mem2Attr.FormattingEnabled = true;
            this.mem2Attr.Items.AddRange(new object[] {
            "Pure",
            "Power",
            "Happy",
            "Cool"});
            this.mem2Attr.Location = new System.Drawing.Point(83, 79);
            this.mem2Attr.Name = "mem2Attr";
            this.mem2Attr.Size = new System.Drawing.Size(121, 21);
            this.mem2Attr.TabIndex = 40;
            // 
            // Member2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 312);
            this.Controls.Add(this.nextButton2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Member2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Member 2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button nextButton2;
        private System.Windows.Forms.CheckBox mem2Story2;
        private System.Windows.Forms.CheckBox mem2Story1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox mem2TextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox mem2Stars;
        private System.Windows.Forms.ComboBox mem2Band;
        private System.Windows.Forms.ComboBox mem2Attr;
    }
}