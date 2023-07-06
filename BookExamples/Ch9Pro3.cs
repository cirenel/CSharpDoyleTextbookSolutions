using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookExamples
{
    public partial class Ch9Pro3 : Form
    {
        public Ch9Pro3()
        {
            InitializeComponent();
        }

        //this is the method connected to the add button click event 
        private void addBtn_Click(object sender, EventArgs e)
        {
            //pull in text from input text boxes 
            string num1Str = num1Txt.Text;
            string num2Str = num2Txt.Text;
            //declare values to store parsed numbers in 
            double num1; double num2; 
            //try to parse both input strings 
            if(double.TryParse(num1Str, out num1) && double.TryParse(num2Str, out num2))
            {
                //if sucessful, add the results together, convert to string, and place in text box 
                ansTxt.Text = (num1+num2).ToString();
            } else
            {
                //otherwise, present error 
                MessageBox.Show("Please enter valid numbers. ","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        //this is the method connected to the multiply button click event 
        private void mulBtn_Click(object sender, EventArgs e)
        {
            //pull in text from input text boxes 
            string num1Str = num1Txt.Text;
            string num2Str = num2Txt.Text;
            //declare values to store parsed numbers in 
            double num1; double num2;
            //try to parse both input strings 
            if (double.TryParse(num1Str, out num1) && double.TryParse(num2Str, out num2))
            {
                //if sucessful, multiply the results together, convert to string, and place in text box 
                ansTxt.Text = (num1 * num2).ToString();
            }
            else
            {
                //otherwise, present error 
                MessageBox.Show("Please enter valid numbers. ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //this is the method connected to the reset button click event 
        private void resetBtn_Click(object sender, EventArgs e)
        {
            //clear all text boxes 
            num1Txt.Clear();
            num2Txt.Clear();
            ansTxt.Clear();
        }
    }
}
