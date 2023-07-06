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
    public partial class Ch9Pro4 : Form
    {
        public Ch9Pro4()
        {
            InitializeComponent();
        }

        private void reposBtn_Click(object sender, EventArgs e)
        {
            //get the x and y input strings from the text box objects 
            string X = xText.Text;
            string Y = yText.Text;
            //declare numeric values to place in post-parse 
            int numX; int numY;

            //try to parse the strings from the collected text
            if (int.TryParse(X, out numX) && int.TryParse(Y, out numY))
            {
                //if the x and y values are within the borders of the string
                if ((numX >= 0 && numX <= Screen.PrimaryScreen.Bounds.Width) && 
                    (numY >= 0 && numY <= Screen.PrimaryScreen.Bounds.Height)) {
                    //set the location of the form to a new point set to the X-Y values we pulled 
                    this.Location = new Point(numX, numY);
                }
                else
                {
                    //otherwise present error for invalid coordinates 
                    MessageBox.Show($"Please enter valid coordinates:\nX: 0 - {Screen.PrimaryScreen.Bounds.Width}\nY: 0 - {Screen.PrimaryScreen.Bounds.Height}", 
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                //otherwise present error for entering numbers 
                MessageBox.Show("Please enter numbers. ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
