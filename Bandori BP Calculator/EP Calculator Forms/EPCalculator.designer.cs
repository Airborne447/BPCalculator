namespace Bandori_EP_BP_Calculator
{
    partial class EPCalculator
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
            this.eventType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.roomScore = new System.Windows.Forms.TextBox();
            this.ownScore = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.outputLabel = new System.Windows.Forms.Label();
            this.calButton = new System.Windows.Forms.Button();
            this.returnButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.boost = new System.Windows.Forms.TextBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.flames = new System.Windows.Forms.TextBox();
            this.pos = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // eventType
            // 
            this.eventType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.eventType.FormattingEnabled = true;
            this.eventType.Items.AddRange(new object[] {
            "Normal",
            "Challenge Live",
            "Band Battle"});
            this.eventType.Location = new System.Drawing.Point(100, 18);
            this.eventType.Name = "eventType";
            this.eventType.Size = new System.Drawing.Size(121, 21);
            this.eventType.TabIndex = 1;
            this.eventType.SelectedIndexChanged += new System.EventHandler(this.eventType_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 43;
            this.label2.Text = "Type Of Event:";
            // 
            // roomScore
            // 
            this.roomScore.Location = new System.Drawing.Point(100, 88);
            this.roomScore.Name = "roomScore";
            this.roomScore.Size = new System.Drawing.Size(100, 20);
            this.roomScore.TabIndex = 3;
            // 
            // ownScore
            // 
            this.ownScore.Location = new System.Drawing.Point(100, 50);
            this.ownScore.Name = "ownScore";
            this.ownScore.Size = new System.Drawing.Size(100, 20);
            this.ownScore.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 46;
            this.label4.Text = "Personal Score:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 47;
            this.label1.Text = "Room Score:";
            // 
            // outputLabel
            // 
            this.outputLabel.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.outputLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.outputLabel.Font = new System.Drawing.Font("Imprint MT Shadow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLabel.Location = new System.Drawing.Point(12, 173);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(439, 84);
            this.outputLabel.TabIndex = 48;
            this.outputLabel.Visible = false;
            // 
            // calButton
            // 
            this.calButton.Location = new System.Drawing.Point(314, 277);
            this.calButton.Name = "calButton";
            this.calButton.Size = new System.Drawing.Size(75, 23);
            this.calButton.TabIndex = 6;
            this.calButton.Text = "Calculate";
            this.calButton.UseVisualStyleBackColor = true;
            this.calButton.Click += new System.EventHandler(this.calButton_Click);
            // 
            // returnButton
            // 
            this.returnButton.Location = new System.Drawing.Point(28, 277);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(75, 23);
            this.returnButton.TabIndex = 8;
            this.returnButton.Text = "Return";
            this.returnButton.UseVisualStyleBackColor = true;
            this.returnButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(233, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 51;
            this.label3.Text = "Boost Percentage:";
            // 
            // boost
            // 
            this.boost.Location = new System.Drawing.Point(334, 54);
            this.boost.Name = "boost";
            this.boost.Size = new System.Drawing.Size(55, 20);
            this.boost.TabIndex = 4;
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(172, 277);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 7;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(226, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 13);
            this.label5.TabIndex = 54;
            this.label5.Text = "No. Of Flames Used";
            // 
            // flames
            // 
            this.flames.Location = new System.Drawing.Point(334, 88);
            this.flames.Name = "flames";
            this.flames.Size = new System.Drawing.Size(55, 20);
            this.flames.TabIndex = 5;
            // 
            // pos
            // 
            this.pos.Location = new System.Drawing.Point(100, 88);
            this.pos.Name = "pos";
            this.pos.Size = new System.Drawing.Size(43, 20);
            this.pos.TabIndex = 55;
            this.pos.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 13);
            this.label6.TabIndex = 56;
            this.label6.Text = "Position in Room:";
            this.label6.Visible = false;
            // 
            // EPCalculator
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(463, 312);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pos);
            this.Controls.Add(this.flames);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.boost);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.returnButton);
            this.Controls.Add(this.calButton);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ownScore);
            this.Controls.Add(this.roomScore);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.eventType);
            this.Name = "EPCalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bandori EP Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox eventType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox roomScore;
        private System.Windows.Forms.TextBox ownScore;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Button calButton;
        private System.Windows.Forms.Button returnButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox boost;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox flames;
        private System.Windows.Forms.TextBox pos;
        private System.Windows.Forms.Label label6;
    }
}

