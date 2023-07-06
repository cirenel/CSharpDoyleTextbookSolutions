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
    public partial class Ch9Pro8 : Form
    {
        public Ch9Pro8()
        {
            InitializeComponent();
        }

        private void compBtn_Click(object sender, EventArgs e)
        {
            //set background colors to standard 
            speedTxt.BackColor = SystemColors.Window;
            timeTxt.BackColor = SystemColors.Window;
            distanceTxt.BackColor = SystemColors.Window;


            //declare time speed and dist vars 
            double speed, time, dist; 
            //try to parse in the strings and save resulting bools to figrue which we need to complete 
            bool speedB = double.TryParse(speedTxt.Text, out speed);
            bool timeB = double.TryParse(timeTxt.Text, out time);
            bool distB = double.TryParse(distanceTxt.Text, out dist);

            if(!speedB && timeB && distB) //if speed not set but time and dist set
            {
                speedTxt.Text = $"{(dist/time):f2}";  //compute speed and place in textbox 
                speedTxt.BackColor = Color.Aquamarine; //color textbox to highligth change 
            } else if (speedB && !timeB && distB) //otherwise if time is not set but speed and dist are 
            {
                timeTxt.Text = $"{(dist / speed):f2}"; //compute time and place in textbox 
                timeTxt.BackColor = Color.Aquamarine;//color textbox to highlight change 
            }
            else if (speedB && timeB && !distB) //otherwise if speed and time are set but distance is not 
            {
                distanceTxt.Text = $"{(speed * time):f2}"; //calculate distance and place in textbox 
                distanceTxt.BackColor = Color.Aquamarine; //color textbox to highlight change 
            } else //otherwise 
            {
                MessageBox.Show("Please enter 2 values. "); //present error message in message box 
            }

        }
    }
}
