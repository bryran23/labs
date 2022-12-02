//Grading ID: C4517
//Lab Number 4
//Due Date: 10/3/2018
//CIS 199-75
//This Lab is disgned to determine if a high school student will be accepted or rejected to a college and keep a running total of each. 
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4
{
    public partial class Form1 : Form
    {
        private int total1 = 0;//makes the first total 0
        private int total2 = 0;//makes the second total 0
        private int accept = 1;//assigns the value of each success to be counted by 1 
        private int reject = 1;//assigns the value of each rejected to be counted by 1

        public Form1()
        {
            InitializeComponent();
        }

        private void calcBtn_Click(object sender, EventArgs e)
        {
            const double INVALID = 0;//This is used to determine the invalid gpa and test score 
            const double GPALOW = 3.0;//This declares the lowest possible GPA to be accepted
            const double TESTLOW = 60;//This declares the lowest test score accepted
            const double TESTHIGH = 80;//This delcares test score needed if GPA is lower that 3.0
            float gpa;//declares the GPA variable 
            double score;//declares the test core variable
            double.TryParse(scoreTxt.Text, out score);//this is what transformers the GPA to another value
            float.TryParse(gpaTxt.Text, out gpa);//this is what transformers the test score to another value

            //This is where the true and false statements are determined
            if (gpa >= GPALOW && score >= TESTLOW)//tests the parameters of the if statement
            {
                MessageBox.Show("Accept");//displays the message box for true parameters.
                total1 += accept;//declares accept to be running total
                totalacceptLbl.Text = $"{total1}";//total accepted inputs displayed by this.
                gpaTxt.Focus();//puts the cursor back on GPA textbox 
                gpaTxt.Clear();//clears the GPA textbox after message box is displayed
                scoreTxt.Clear();//clears the test score textbox
            }
            else if (gpa < GPALOW && score >= TESTHIGH)//determines if true or false based on the parameters
            {
                MessageBox.Show("Accept");//shows Accept if the entered value is true
                total1 += accept;//declares accept to be running total
                totalacceptLbl.Text = $"{total1}";//total accepted inputs displayed by this.
                gpaTxt.Focus();//puts the cursor back on GPA textbox 
                gpaTxt.Clear();//clears the GPA textbox after message box is displayed
                scoreTxt.Clear();//clears the test score textbox
            }

            else if (gpa > INVALID && score > INVALID)//determines if the GPA and test score is valid
            {
                MessageBox.Show("Reject");//Shows the message box reject if the two parameters before this one is false.
                total2 += reject;//counts the total of rejects 
                totalrejectLbl.Text = $"{total2}";//displays the total rejected in the totalreject label 
                gpaTxt.Focus();//puts the cursor back on the GPA textbox
                gpaTxt.Clear();//clears the gpa textbox
                scoreTxt.Clear();//clears the score textbox

            }
            else if (gpa < INVALID)//determines is the GPA and test score are invalid 
            {
                MessageBox.Show("Enter valid GPA");//This will show if the GPA isn't valid 
            }
            else
            {
                MessageBox.Show("Enter a valid test score");//This will display if the test score is invalid
            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            total1 = 0;//declares the total accepted as 0
            total2 = 0;//declares the total rejected as 0
            totalacceptLbl.Text = "";//makes the text of total accepted label blank
            totalrejectLbl.Text = "";//makes the text of total rejected label blank
            gpaTxt.Clear();//clears the GPA textbox
            scoreTxt.Clear();//clears the test score textbox 
            gpaTxt.Focus();//puts the cursor back onto the GPA textbox
        }
    }
}
