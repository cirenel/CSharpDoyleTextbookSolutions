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
    public partial class Ch9Pro5 : Form
    {
        public Ch9Pro5()
        {
            InitializeComponent();
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            foreach(Control c in Controls)
            {
                if(c.GetType() == typeof(TextBox))
                {
                    c.ResetText();
                }
            }
        }

        private void calcBtn_Click(object sender, EventArgs e)
        {
            double mpg, numPeople, totalCost, costPer, gallons, miles;
            bool mpgB = double.TryParse(mpgTxt.Text, out mpg);
            bool numPeopleB = double.TryParse(numPeopleTxt.Text, out numPeople);
            bool totalCostB = double.TryParse(totalCostTxt.Text, out totalCost);
            bool costPerB = double.TryParse(costPerTxt.Text, out costPer);
            bool gallonsB = double.TryParse(costPerTxt.Text, out gallons);
            bool milesB = double.TryParse(costPerTxt.Text, out miles);




        }
    }
}
