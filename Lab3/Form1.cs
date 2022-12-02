//Grading ID: C4517
//Lab #: Lab 3
//Due Date: 9/23/18
//Class: CIS 199-75
//This lab has the user input the radius, it will then display the diameter, surface area, and the volume.
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //This is the event that calculate the diameter, surface area, and volume entered. 
        private void calcBtn_Click(object sender, EventArgs e)
        {
            double radius; //This value marks the name of the user input.

            //Allows the user to input a value in the textbox.
            radius = double.Parse(enterTxt.Text);

            double diameter = 2 * radius; //This is a variable that helps get the diameter.
            double surface = 4 * Math.PI * Math.Pow(radius, 2); //This variable helps determine the surface area. 
            double volume = 4 * Math.PI * Math.Pow(radius, 3) / 3; //This variable helps determines the volume.


            sum1Lbl.Text = $"{diameter:F2}"; //This is where the solution for diameter is displayed.
            sum2Lbl.Text = $"{surface:F2}"; //This is where the solution for surface area is displayed. 
            sum3Lbl.Text = $"{volume:F2}"; //This is where the solution for volume is displayed. 
        }
    }
}
