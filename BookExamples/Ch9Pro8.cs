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
            speedTxt.BackColor = SystemColors.Control;
            timeTxt.BackColor = SystemColors.Control;
            distanceTxt.BackColor = SystemColors.Control;


            double speed, time, dist; 
            bool speedB = double.TryParse(speedTxt.Text, out speed);
            bool timeB = double.TryParse(timeTxt.Text, out time);
            bool distB = double.TryParse(distanceTxt.Text, out dist);

            if(!speedB && timeB && distB)
            {
                speedTxt.Text = (dist/time).ToString();
                speedTxt.BackColor = Color.Aquamarine;
            } else if (speedB && !timeB && distB)
            {
                timeTxt.Text = (dist/speed).ToString();
                timeTxt.BackColor = Color.Aquamarine;
            }
            else if (speedB && timeB && !distB)
            {
                distanceTxt.Text = (time * speed).ToString();
                distanceTxt.BackColor = Color.Aquamarine;
            } else
            {
                MessageBox.Show("Please enter 2 values. ");
            }

        }
    }
}
