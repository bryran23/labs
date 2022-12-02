namespace Lab2
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
            this.EnterLbl = new System.Windows.Forms.Label();
            this.enterTxt = new System.Windows.Forms.TextBox();
            this.lowLbl = new System.Windows.Forms.Label();
            this.mediumLbl = new System.Windows.Forms.Label();
            this.highLbl = new System.Windows.Forms.Label();
            this.CalcBtn = new System.Windows.Forms.Button();
            this.output1Lbl = new System.Windows.Forms.Label();
            this.output2Lbl = new System.Windows.Forms.Label();
            this.output3Lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // EnterLbl
            // 
            this.EnterLbl.AutoSize = true;
            this.EnterLbl.Location = new System.Drawing.Point(47, 36);
            this.EnterLbl.Name = "EnterLbl";
            this.EnterLbl.Size = new System.Drawing.Size(98, 13);
            this.EnterLbl.TabIndex = 0;
            this.EnterLbl.Text = "Enter price of meal:";
            // 
            // enterTxt
            // 
            this.enterTxt.Location = new System.Drawing.Point(152, 36);
            this.enterTxt.Name = "enterTxt";
            this.enterTxt.Size = new System.Drawing.Size(100, 20);
            this.enterTxt.TabIndex = 1;
            // 
            // lowLbl
            // 
            this.lowLbl.AutoSize = true;
            this.lowLbl.Location = new System.Drawing.Point(109, 77);
            this.lowLbl.Name = "lowLbl";
            this.lowLbl.Size = new System.Drawing.Size(27, 13);
            this.lowLbl.TabIndex = 2;
            this.lowLbl.Text = "15%";
            // 
            // mediumLbl
            // 
            this.mediumLbl.AutoSize = true;
            this.mediumLbl.Location = new System.Drawing.Point(109, 116);
            this.mediumLbl.Name = "mediumLbl";
            this.mediumLbl.Size = new System.Drawing.Size(27, 13);
            this.mediumLbl.TabIndex = 4;
            this.mediumLbl.Text = "18%";
            // 
            // highLbl
            // 
            this.highLbl.AutoSize = true;
            this.highLbl.Location = new System.Drawing.Point(109, 156);
            this.highLbl.Name = "highLbl";
            this.highLbl.Size = new System.Drawing.Size(27, 13);
            this.highLbl.TabIndex = 6;
            this.highLbl.Text = "20%";
            // 
            // CalcBtn
            // 
            this.CalcBtn.Location = new System.Drawing.Point(104, 203);
            this.CalcBtn.Name = "CalcBtn";
            this.CalcBtn.Size = new System.Drawing.Size(84, 23);
            this.CalcBtn.TabIndex = 8;
            this.CalcBtn.Text = "Calculate Tip";
            this.CalcBtn.UseVisualStyleBackColor = true;
            this.CalcBtn.Click += new System.EventHandler(this.CalcBtn_Click);
            // 
            // output1Lbl
            // 
            this.output1Lbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.output1Lbl.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.output1Lbl.Location = new System.Drawing.Point(152, 77);
            this.output1Lbl.Name = "output1Lbl";
            this.output1Lbl.Size = new System.Drawing.Size(100, 23);
            this.output1Lbl.TabIndex = 9;
            // 
            // output2Lbl
            // 
            this.output2Lbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.output2Lbl.Location = new System.Drawing.Point(152, 116);
            this.output2Lbl.Name = "output2Lbl";
            this.output2Lbl.Size = new System.Drawing.Size(100, 23);
            this.output2Lbl.TabIndex = 10;
            // 
            // output3Lbl
            // 
            this.output3Lbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.output3Lbl.Location = new System.Drawing.Point(152, 156);
            this.output3Lbl.Name = "output3Lbl";
            this.output3Lbl.Size = new System.Drawing.Size(100, 23);
            this.output3Lbl.TabIndex = 11;
            // 
            // Form1
            // 
            this.AcceptButton = this.CalcBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 260);
            this.Controls.Add(this.output3Lbl);
            this.Controls.Add(this.output2Lbl);
            this.Controls.Add(this.output1Lbl);
            this.Controls.Add(this.CalcBtn);
            this.Controls.Add(this.highLbl);
            this.Controls.Add(this.mediumLbl);
            this.Controls.Add(this.lowLbl);
            this.Controls.Add(this.enterTxt);
            this.Controls.Add(this.EnterLbl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label EnterLbl;
        private System.Windows.Forms.TextBox enterTxt;
        private System.Windows.Forms.Label lowLbl;
        private System.Windows.Forms.Label mediumLbl;
        private System.Windows.Forms.Label highLbl;
        private System.Windows.Forms.Button CalcBtn;
        private System.Windows.Forms.Label output1Lbl;
        private System.Windows.Forms.Label output2Lbl;
        private System.Windows.Forms.Label output3Lbl;
    }
}

