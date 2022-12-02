//C4517
//Lab2
//9/16/2018
//CIS 199-75
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // Event for finding tip rates 
        private void CalcBtn_Click(object sender, EventArgs e)
        {

            const double TIPRATE_LOW = 0.15;//Declares the low tip rate
            const double TIPRATE_MEDIUM = 0.18;//Declares the medium tip rate
            const double TIPRATE_HIGH = 0.20;//Declares the high tip rate 
            double enter;//The value that is entered by the user 
            double sum1;//value of enter * TIPRATE_LOW
            double sum2;//value of enter * TIPRATE_MEDIUM
            double sum3;//value of enter * TIPRATE_HIGH

            //Where user inputs variable 
            enter = double.Parse(enterTxt.Text); 

            //Where tip rates are determined
            sum1 = enter * TIPRATE_LOW;
            sum2 = enter * TIPRATE_MEDIUM;
            sum3 = enter * TIPRATE_HIGH;

            //Where the tip amount is displayed
            output1Lbl.Text = $"{sum1:C}";
            output2Lbl.Text = $"{sum2:C}";
            output3Lbl.Text = $"{sum3:C}";
        }
    }
}
