namespace Localization
{
    partial class Form1
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
            this.btnDosyaSec = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.txtBoxFont = new System.Windows.Forms.TextBox();
            this.LblFont = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxVersion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxRatio = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxLeftToRight = new System.Windows.Forms.ComboBox();
            this.listBox = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDosyaSec
            // 
            this.btnDosyaSec.Location = new System.Drawing.Point(19, 226);
            this.btnDosyaSec.Name = "btnDosyaSec";
            this.btnDosyaSec.Size = new System.Drawing.Size(136, 23);
            this.btnDosyaSec.TabIndex = 0;
            this.btnDosyaSec.Text = "oldJson To newJson";
            this.btnDosyaSec.UseVisualStyleBackColor = true;
            this.btnDosyaSec.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // txtBoxFont
            // 
            this.txtBoxFont.Location = new System.Drawing.Point(55, 50);
            this.txtBoxFont.Name = "txtBoxFont";
            this.txtBoxFont.Size = new System.Drawing.Size(100, 20);
            this.txtBoxFont.TabIndex = 1;
            // 
            // LblFont
            // 
            this.LblFont.AutoSize = true;
            this.LblFont.Location = new System.Drawing.Point(52, 34);
            this.LblFont.Name = "LblFont";
            this.LblFont.Size = new System.Drawing.Size(28, 13);
            this.LblFont.TabIndex = 2;
            this.LblFont.Text = "Font";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "LeftToRight\r\n";
            // 
            // txtBoxVersion
            // 
            this.txtBoxVersion.Location = new System.Drawing.Point(55, 130);
            this.txtBoxVersion.Name = "txtBoxVersion";
            this.txtBoxVersion.Size = new System.Drawing.Size(100, 20);
            this.txtBoxVersion.TabIndex = 1;
            this.txtBoxVersion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxVersion_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Version";
            // 
            // txtBoxRatio
            // 
            this.txtBoxRatio.Location = new System.Drawing.Point(55, 171);
            this.txtBoxRatio.Name = "txtBoxRatio";
            this.txtBoxRatio.Size = new System.Drawing.Size(100, 20);
            this.txtBoxRatio.TabIndex = 1;
            this.txtBoxRatio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxRatio_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ratio";
            // 
            // comboBoxLeftToRight
            // 
            this.comboBoxLeftToRight.FormattingEnabled = true;
            this.comboBoxLeftToRight.Items.AddRange(new object[] {
            "True",
            "False"});
            this.comboBoxLeftToRight.Location = new System.Drawing.Point(55, 90);
            this.comboBoxLeftToRight.Name = "comboBoxLeftToRight";
            this.comboBoxLeftToRight.Size = new System.Drawing.Size(100, 21);
            this.comboBoxLeftToRight.TabIndex = 3;
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.Location = new System.Drawing.Point(368, 30);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(424, 316);
            this.listBox.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.comboBoxLeftToRight);
            this.groupBox1.Controls.Add(this.btnConvert);
            this.groupBox1.Controls.Add(this.btnDosyaSec);
            this.groupBox1.Controls.Add(this.txtBoxFont);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtBoxVersion);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtBoxRatio);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.LblFont);
            this.groupBox1.Location = new System.Drawing.Point(12, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(335, 325);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(196, 226);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(75, 23);
            this.btnConvert.TabIndex = 0;
            this.btnConvert.Text = "Xml To Json";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Bilgiler girilmezse boş bırakılır!\r\n";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 368);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Localization";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDosyaSec;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox txtBoxFont;
        private System.Windows.Forms.Label LblFont;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxVersion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxRatio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxLeftToRight;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Label label4;
    }
}

