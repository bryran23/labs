namespace Lab3
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
            this.radiusBox1 = new System.Windows.Forms.PictureBox();
            this.radiusBox2 = new System.Windows.Forms.PictureBox();
            this.radiusLbl = new System.Windows.Forms.Label();
            this.enterTxt = new System.Windows.Forms.TextBox();
            this.calcBtn = new System.Windows.Forms.Button();
            this.diameterLbl = new System.Windows.Forms.Label();
            this.sum1Lbl = new System.Windows.Forms.Label();
            this.surfLbl = new System.Windows.Forms.Label();
            this.sum2Lbl = new System.Windows.Forms.Label();
            this.volLbl = new System.Windows.Forms.Label();
            this.sum3Lbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.radiusBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radiusBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // radiusBox1
            // 
            this.radiusBox1.Image = ((System.Drawing.Image)(resources.GetObject("radiusBox1.Image")));
            this.radiusBox1.Location = new System.Drawing.Point(12, 29);
            this.radiusBox1.Name = "radiusBox1";
            this.radiusBox1.Size = new System.Drawing.Size(150, 150);
            this.radiusBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.radiusBox1.TabIndex = 0;
            this.radiusBox1.TabStop = false;
            // 
            // radiusBox2
            // 
            this.radiusBox2.Image = ((System.Drawing.Image)(resources.GetObject("radiusBox2.Image")));
            this.radiusBox2.Location = new System.Drawing.Point(221, 199);
            this.radiusBox2.Name = "radiusBox2";
            this.radiusBox2.Size = new System.Drawing.Size(150, 150);
            this.radiusBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.radiusBox2.TabIndex = 1;
            this.radiusBox2.TabStop = false;
            // 
            // radiusLbl
            // 
            this.radiusLbl.AutoSize = true;
            this.radiusLbl.Location = new System.Drawing.Point(168, 55);
            this.radiusLbl.Name = "radiusLbl";
            this.radiusLbl.Size = new System.Drawing.Size(90, 13);
            this.radiusLbl.TabIndex = 2;
            this.radiusLbl.Text = "Radius of sphere:";
            // 
            // enterTxt
            // 
            this.enterTxt.Location = new System.Drawing.Point(264, 52);
            this.enterTxt.Name = "enterTxt";
            this.enterTxt.Size = new System.Drawing.Size(100, 20);
            this.enterTxt.TabIndex = 3;
            // 
            // calcBtn
            // 
            this.calcBtn.Location = new System.Drawing.Point(275, 90);
            this.calcBtn.Name = "calcBtn";
            this.calcBtn.Size = new System.Drawing.Size(75, 23);
            this.calcBtn.TabIndex = 4;
            this.calcBtn.Text = "Calculate";
            this.calcBtn.UseVisualStyleBackColor = true;
            this.calcBtn.Click += new System.EventHandler(this.calcBtn_Click);
            // 
            // diameterLbl
            // 
            this.diameterLbl.AutoSize = true;
            this.diameterLbl.Location = new System.Drawing.Point(29, 208);
            this.diameterLbl.Name = "diameterLbl";
            this.diameterLbl.Size = new System.Drawing.Size(49, 13);
            this.diameterLbl.TabIndex = 5;
            this.diameterLbl.Text = "Diameter";
            // 
            // sum1Lbl
            // 
            this.sum1Lbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sum1Lbl.Location = new System.Drawing.Point(88, 207);
            this.sum1Lbl.Name = "sum1Lbl";
            this.sum1Lbl.Size = new System.Drawing.Size(100, 23);
            this.sum1Lbl.TabIndex = 6;
            this.sum1Lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // surfLbl
            // 
            this.surfLbl.AutoSize = true;
            this.surfLbl.Location = new System.Drawing.Point(12, 260);
            this.surfLbl.Name = "surfLbl";
            this.surfLbl.Size = new System.Drawing.Size(69, 13);
            this.surfLbl.TabIndex = 7;
            this.surfLbl.Text = "Surface Area";
            // 
            // sum2Lbl
            // 
            this.sum2Lbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sum2Lbl.Location = new System.Drawing.Point(88, 259);
            this.sum2Lbl.Name = "sum2Lbl";
            this.sum2Lbl.Size = new System.Drawing.Size(100, 23);
            this.sum2Lbl.TabIndex = 8;
            this.sum2Lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // volLbl
            // 
            this.volLbl.AutoSize = true;
            this.volLbl.Location = new System.Drawing.Point(40, 308);
            this.volLbl.Name = "volLbl";
            this.volLbl.Size = new System.Drawing.Size(42, 13);
            this.volLbl.TabIndex = 9;
            this.volLbl.Text = "Volume";
            // 
            // sum3Lbl
            // 
            this.sum3Lbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sum3Lbl.Location = new System.Drawing.Point(88, 307);
            this.sum3Lbl.Name = "sum3Lbl";
            this.sum3Lbl.Size = new System.Drawing.Size(100, 23);
            this.sum3Lbl.TabIndex = 10;
            this.sum3Lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            this.AcceptButton = this.calcBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.sum3Lbl);
            this.Controls.Add(this.volLbl);
            this.Controls.Add(this.sum2Lbl);
            this.Controls.Add(this.surfLbl);
            this.Controls.Add(this.sum1Lbl);
            this.Controls.Add(this.diameterLbl);
            this.Controls.Add(this.calcBtn);
            this.Controls.Add(this.enterTxt);
            this.Controls.Add(this.radiusLbl);
            this.Controls.Add(this.radiusBox2);
            this.Controls.Add(this.radiusBox1);
            this.Name = "Form1";
            this.Text = "Lab 3";
            ((System.ComponentModel.ISupportInitialize)(this.radiusBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radiusBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox radiusBox1;
        private System.Windows.Forms.PictureBox radiusBox2;
        private System.Windows.Forms.Label radiusLbl;
        private System.Windows.Forms.TextBox enterTxt;
        private System.Windows.Forms.Button calcBtn;
        private System.Windows.Forms.Label diameterLbl;
        private System.Windows.Forms.Label sum1Lbl;
        private System.Windows.Forms.Label surfLbl;
        private System.Windows.Forms.Label sum2Lbl;
        private System.Windows.Forms.Label volLbl;
        private System.Windows.Forms.Label sum3Lbl;
    }
}

