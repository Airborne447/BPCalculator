namespace Bandori_EP_BP_Calculator
{
    partial class Member1
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
            this.mem1TextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mem1Story1 = new System.Windows.Forms.CheckBox();
            this.mem1Story2 = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.mem1Stars = new System.Windows.Forms.ComboBox();
            this.mem1Band = new System.Windows.Forms.ComboBox();
            this.mem1Attr = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.returnButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mem1TextBox
            // 
            this.mem1TextBox.Location = new System.Drawing.Point(83, 22);
            this.mem1TextBox.Name = "mem1TextBox";
            this.mem1TextBox.Size = new System.Drawing.Size(100, 20);
            this.mem1TextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "1st Member:";
            // 
            // mem1Story1
            // 
            this.mem1Story1.AutoSize = true;
            this.mem1Story1.Location = new System.Drawing.Point(195, 24);
            this.mem1Story1.Name = "mem1Story1";
            this.mem1Story1.Size = new System.Drawing.Size(101, 17);
            this.mem1Story1.TabIndex = 10;
            this.mem1Story1.Text = "Read First Story";
            this.mem1Story1.UseVisualStyleBackColor = true;
            // 
            // mem1Story2
            // 
            this.mem1Story2.AutoSize = true;
            this.mem1Story2.Location = new System.Drawing.Point(302, 24);
            this.mem1Story2.Name = "mem1Story2";
            this.mem1Story2.Size = new System.Drawing.Size(119, 17);
            this.mem1Story2.TabIndex = 11;
            this.mem1Story2.Text = "Read Second Story";
            this.mem1Story2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.mem1Stars);
            this.groupBox1.Controls.Add(this.mem1Band);
            this.groupBox1.Controls.Add(this.mem1Story2);
            this.groupBox1.Controls.Add(this.mem1Attr);
            this.groupBox1.Controls.Add(this.mem1Story1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.mem1TextBox);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(428, 169);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "1st Member Band Power Values";
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
            // mem1Stars
            // 
            this.mem1Stars.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.mem1Stars.FormattingEnabled = true;
            this.mem1Stars.Items.AddRange(new object[] {
            "4",
            "3",
            "2"});
            this.mem1Stars.Location = new System.Drawing.Point(83, 52);
            this.mem1Stars.Name = "mem1Stars";
            this.mem1Stars.Size = new System.Drawing.Size(56, 21);
            this.mem1Stars.TabIndex = 41;
            // 
            // mem1Band
            // 
            this.mem1Band.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.mem1Band.FormattingEnabled = true;
            this.mem1Band.Items.AddRange(new object[] {
            "Poppin\' Party",
            "Afterglow",
            "Pastel*Palettes",
            "Roselia",
            "Hello, Happy World!"});
            this.mem1Band.Location = new System.Drawing.Point(83, 106);
            this.mem1Band.Name = "mem1Band";
            this.mem1Band.Size = new System.Drawing.Size(173, 21);
            this.mem1Band.TabIndex = 39;
            // 
            // mem1Attr
            // 
            this.mem1Attr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.mem1Attr.FormattingEnabled = true;
            this.mem1Attr.Items.AddRange(new object[] {
            "Pure",
            "Power",
            "Happy",
            "Cool"});
            this.mem1Attr.Location = new System.Drawing.Point(83, 79);
            this.mem1Attr.Name = "mem1Attr";
            this.mem1Attr.Size = new System.Drawing.Size(121, 21);
            this.mem1Attr.TabIndex = 40;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(234, 277);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Next";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // returnButton
            // 
            this.returnButton.Location = new System.Drawing.Point(96, 277);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(75, 23);
            this.returnButton.TabIndex = 5;
            this.returnButton.Text = "Return";
            this.returnButton.UseVisualStyleBackColor = true;
            this.returnButton.Click += new System.EventHandler(this.returnButton_Click);
            // 
            // Member1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 312);
            this.Controls.Add(this.returnButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Member1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bandori BP Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox mem1TextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox mem1Story1;
        private System.Windows.Forms.CheckBox mem1Story2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox mem1Stars;
        private System.Windows.Forms.ComboBox mem1Band;
        private System.Windows.Forms.ComboBox mem1Attr;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button returnButton;
    }
}

