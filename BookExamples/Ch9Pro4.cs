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
            string X = xText.Text;
            string Y = yText.Text;
            int numX; int numY;
            if (int.TryParse(X, out numX) && int.TryParse(Y, out numY))
            {
                if ((numX >= 0 && numX <= Screen.PrimaryScreen.Bounds.Width) && 
                    (numY >= 0 && numY <= Screen.PrimaryScreen.Bounds.Height)) {
                    this.Location = new Point(numX, numY);
                }
                else
                {
                    MessageBox.Show($"Please enter valid coordinates:\nX: 0 - {Screen.PrimaryScreen.Bounds.Width}\nY: 0 - {Screen.PrimaryScreen.Bounds.Height}", 
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please enter numbers. ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
