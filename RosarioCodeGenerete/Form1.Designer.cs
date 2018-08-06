namespace RosarioCodeGenerete
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.EdtPath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.EdtCorrelatorNumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnGenerate = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.EdtCardNumber = new System.Windows.Forms.TextBox();
            this.EdtTotCards = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.ProgressBar = new System.Windows.Forms.ProgressBar();
            this.label6 = new System.Windows.Forms.Label();
            this.BtnGetPath = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.EdtTotCards)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Path";
            // 
            // EdtPath
            // 
            this.EdtPath.Location = new System.Drawing.Point(143, 87);
            this.EdtPath.Name = "EdtPath";
            this.EdtPath.Size = new System.Drawing.Size(292, 20);
            this.EdtPath.TabIndex = 1;
            this.EdtPath.Text = "C:\\Users\\macedofl\\Desktop\\testeeRosario\\teste.txt";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Correlator Number";
            // 
            // EdtCorrelatorNumber
            // 
            this.EdtCorrelatorNumber.Location = new System.Drawing.Point(143, 175);
            this.EdtCorrelatorNumber.MaxLength = 8;
            this.EdtCorrelatorNumber.Name = "EdtCorrelatorNumber";
            this.EdtCorrelatorNumber.Size = new System.Drawing.Size(324, 20);
            this.EdtCorrelatorNumber.TabIndex = 3;
            this.EdtCorrelatorNumber.Text = "03000001";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Total Cards";
            // 
            // BtnGenerate
            // 
            this.BtnGenerate.Location = new System.Drawing.Point(143, 266);
            this.BtnGenerate.Name = "BtnGenerate";
            this.BtnGenerate.Size = new System.Drawing.Size(324, 35);
            this.BtnGenerate.TabIndex = 6;
            this.BtnGenerate.Text = "Generate";
            this.BtnGenerate.UseVisualStyleBackColor = true;
            this.BtnGenerate.Click += new System.EventHandler(this.BtnGenerate_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Card Number";
            // 
            // EdtCardNumber
            // 
            this.EdtCardNumber.Location = new System.Drawing.Point(143, 130);
            this.EdtCardNumber.MaxLength = 8;
            this.EdtCardNumber.Name = "EdtCardNumber";
            this.EdtCardNumber.Size = new System.Drawing.Size(324, 20);
            this.EdtCardNumber.TabIndex = 8;
            this.EdtCardNumber.Text = "42410201";
            // 
            // EdtTotCards
            // 
            this.EdtTotCards.Location = new System.Drawing.Point(143, 219);
            this.EdtTotCards.Maximum = new decimal(new int[] {
            99999998,
            0,
            0,
            0});
            this.EdtTotCards.Name = "EdtTotCards";
            this.EdtTotCards.Size = new System.Drawing.Size(120, 20);
            this.EdtTotCards.TabIndex = 9;
            this.EdtTotCards.Value = new decimal(new int[] {
            11,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(381, 381);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Status:";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(427, 381);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(61, 13);
            this.lblStatus.TabIndex = 11;
            this.lblStatus.Text = "_________";
            // 
            // ProgressBar
            // 
            this.ProgressBar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ProgressBar.Location = new System.Drawing.Point(28, 346);
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Size = new System.Drawing.Size(403, 23);
            this.ProgressBar.TabIndex = 100;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(207, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(321, 31);
            this.label6.TabIndex = 101;
            this.label6.Text = "Rosario Code Generate";
            // 
            // BtnGetPath
            // 
            this.BtnGetPath.Location = new System.Drawing.Point(441, 86);
            this.BtnGetPath.Name = "BtnGetPath";
            this.BtnGetPath.Size = new System.Drawing.Size(26, 20);
            this.BtnGetPath.TabIndex = 102;
            this.BtnGetPath.Text = "...";
            this.BtnGetPath.UseVisualStyleBackColor = true;
            this.BtnGetPath.Click += new System.EventHandler(this.BtnGetPath_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(162, 79);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 103;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 416);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BtnGetPath);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ProgressBar);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.EdtTotCards);
            this.Controls.Add(this.EdtCardNumber);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BtnGenerate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.EdtCorrelatorNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.EdtPath);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.EdtTotCards)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox EdtPath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox EdtCorrelatorNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnGenerate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox EdtCardNumber;
        private System.Windows.Forms.NumericUpDown EdtTotCards;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ProgressBar ProgressBar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BtnGetPath;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

