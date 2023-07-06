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
    public partial class Ch9Pro2 : Form
    {
        public Ch9Pro2()
        {
            InitializeComponent();
        }

        private void colorBtn_Click(object sender, EventArgs e)
        {
            Random r = new Random(); //create randomizer 
            int R = r.Next(0, 256) ; //generate a red value 
            int G = r.Next(0, 256) ; //generate a green value 
            int B = r.Next(0, 256) ; //generate a blue value 

            this.BackColor = Color.FromArgb(R, G, B); //take those three values, create a color, then set it 
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            this.BackColor = SystemColors.Window; //reset the background color of the form to the system color 
        }
    }
}
