namespace Lab4
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
            this.gpaLbl = new System.Windows.Forms.Label();
            this.scoreLbl = new System.Windows.Forms.Label();
            this.gpaTxt = new System.Windows.Forms.TextBox();
            this.scoreTxt = new System.Windows.Forms.TextBox();
            this.calcBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.acceptLbl = new System.Windows.Forms.Label();
            this.totalacceptLbl = new System.Windows.Forms.Label();
            this.rejectedLbl = new System.Windows.Forms.Label();
            this.totalrejectLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // gpaLbl
            // 
            this.gpaLbl.AutoSize = true;
            this.gpaLbl.Location = new System.Drawing.Point(96, 51);
            this.gpaLbl.Name = "gpaLbl";
            this.gpaLbl.Size = new System.Drawing.Size(117, 13);
            this.gpaLbl.TabIndex = 0;
            this.gpaLbl.Text = "Enter high school GPA:";
            // 
            // scoreLbl
            // 
            this.scoreLbl.AutoSize = true;
            this.scoreLbl.Location = new System.Drawing.Point(73, 90);
            this.scoreLbl.Name = "scoreLbl";
            this.scoreLbl.Size = new System.Drawing.Size(140, 13);
            this.scoreLbl.TabIndex = 1;
            this.scoreLbl.Text = "Enter Admission Test Score:";
            // 
            // gpaTxt
            // 
            this.gpaTxt.Location = new System.Drawing.Point(249, 48);
            this.gpaTxt.Name = "gpaTxt";
            this.gpaTxt.Size = new System.Drawing.Size(100, 20);
            this.gpaTxt.TabIndex = 2;
            // 
            // scoreTxt
            // 
            this.scoreTxt.Location = new System.Drawing.Point(249, 87);
            this.scoreTxt.Name = "scoreTxt";
            this.scoreTxt.Size = new System.Drawing.Size(100, 20);
            this.scoreTxt.TabIndex = 3;
            // 
            // calcBtn
            // 
            this.calcBtn.Location = new System.Drawing.Point(76, 173);
            this.calcBtn.Name = "calcBtn";
            this.calcBtn.Size = new System.Drawing.Size(75, 23);
            this.calcBtn.TabIndex = 4;
            this.calcBtn.Text = "Calculate";
            this.calcBtn.UseVisualStyleBackColor = true;
            this.calcBtn.Click += new System.EventHandler(this.calcBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.clearBtn.Location = new System.Drawing.Point(249, 173);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(75, 23);
            this.clearBtn.TabIndex = 5;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // acceptLbl
            // 
            this.acceptLbl.AutoSize = true;
            this.acceptLbl.Location = new System.Drawing.Point(76, 228);
            this.acceptLbl.Name = "acceptLbl";
            this.acceptLbl.Size = new System.Drawing.Size(83, 13);
            this.acceptLbl.TabIndex = 6;
            this.acceptLbl.Text = "Total Accepted:";
            // 
            // totalacceptLbl
            // 
            this.totalacceptLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalacceptLbl.Location = new System.Drawing.Point(76, 262);
            this.totalacceptLbl.Name = "totalacceptLbl";
            this.totalacceptLbl.Size = new System.Drawing.Size(100, 23);
            this.totalacceptLbl.TabIndex = 7;
            // 
            // rejectedLbl
            // 
            this.rejectedLbl.AutoSize = true;
            this.rejectedLbl.Location = new System.Drawing.Point(249, 228);
            this.rejectedLbl.Name = "rejectedLbl";
            this.rejectedLbl.Size = new System.Drawing.Size(80, 13);
            this.rejectedLbl.TabIndex = 8;
            this.rejectedLbl.Text = "Total Rejected:";
            // 
            // totalrejectLbl
            // 
            this.totalrejectLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalrejectLbl.Location = new System.Drawing.Point(252, 261);
            this.totalrejectLbl.Name = "totalrejectLbl";
            this.totalrejectLbl.Size = new System.Drawing.Size(100, 23);
            this.totalrejectLbl.TabIndex = 9;
            // 
            // Form1
            // 
            this.AcceptButton = this.calcBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.clearBtn;
            this.ClientSize = new System.Drawing.Size(409, 310);
            this.Controls.Add(this.totalrejectLbl);
            this.Controls.Add(this.rejectedLbl);
            this.Controls.Add(this.totalacceptLbl);
            this.Controls.Add(this.acceptLbl);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.calcBtn);
            this.Controls.Add(this.scoreTxt);
            this.Controls.Add(this.gpaTxt);
            this.Controls.Add(this.scoreLbl);
            this.Controls.Add(this.gpaLbl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label gpaLbl;
        private System.Windows.Forms.Label scoreLbl;
        private System.Windows.Forms.TextBox gpaTxt;
        private System.Windows.Forms.TextBox scoreTxt;
        private System.Windows.Forms.Button calcBtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Label acceptLbl;
        private System.Windows.Forms.Label totalacceptLbl;
        private System.Windows.Forms.Label rejectedLbl;
        private System.Windows.Forms.Label totalrejectLbl;
    }
}

