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
            //grab ALL of the controls on the form
            foreach (Control c in Controls)  //for each individual control 
            {
                if(c.GetType() == typeof(TextBox)) //if that control is a textbox 
                {
                    c.ResetText(); //reset the text in the textbox 
                }
            }
        }

        private void calcBtn_Click(object sender, EventArgs e)
        {
            //pull all values from text boxes and into their appropriate previously declared variables 
            //try parse to determin which text boxes need to be popuated and thus which values need to be computed 
            double mpg,  totalCost, costPer, gallons, miles;
            int numPeople; 
            bool mpgB = double.TryParse(mpgTxt.Text, out mpg);
            bool numPeopleB = int.TryParse(numPeopleTxt.Text, out numPeople);
            bool totalCostB = double.TryParse(totalCostTxt.Text, out totalCost);
            bool costPerB = double.TryParse(costPerTxt.Text, out costPer);
            bool gallonsB = double.TryParse(totalGalTxt.Text, out gallons);
            bool milesB = double.TryParse(milesTxt.Text, out miles);

            bool toggle = true;
            while (toggle)
            {

                toggle = false;
                if (!mpgB && milesB && gallonsB)
                {
                    mpg = miles / gallons;
                    mpgB = true;
                    toggle = true; 
                }
                if (!numPeopleB && totalCostB && costPerB)
                {
                    numPeople = (int)Math.Ceiling(totalCost / costPer);
                    toggle = true; 
                    numPeopleB = true;
                }
                if (!totalCostB && numPeopleB && costPerB)
                {
                    totalCost = costPer * numPeople;
                    toggle = true; 
                    totalCostB = true;
                }
                if (!costPerB && numPeopleB && totalCostB)
                {
                    costPer = totalCost / numPeople;
                    toggle = true; 
                    costPerB = true;
                }
                if (!gallonsB && mpgB && milesB)
                {
                    gallons = mpg * miles;
                    toggle = true; 
                    gallonsB = true;
                }
                if (!milesB && gallonsB && mpgB)
                {
                    miles = gallons * mpg;
                    toggle = true; 
                    milesB = true;
                }

            }
            mpgTxt.Text = $"{mpg:f2}";
            numPeopleTxt.Text = $"{(int)numPeople}";
            totalCostTxt.Text = $"{totalCost:f2}";
            costPerTxt.Text = $"{costPer:f2}";
            totalGalTxt.Text = $"{gallons:f2}";
            milesTxt.Text = $"{miles:f2}";


            if (!(mpgB && numPeopleB && totalCostB && costPerB && gallonsB && milesB))
            {
                MessageBox.Show("More data needed for full computation.");
            }
        }
    }
}
