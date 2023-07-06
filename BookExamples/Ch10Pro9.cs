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
    public partial class Ch10Pro9 : Form
    {
       

        public Ch10Pro9()
        {
            InitializeComponent();
            //this is done here to prevent it from being cleared out in the auto-generated code should changes be made 
            this.hardwoodList.Items.AddRange(new object[] {
            $"{"Cherry ".PadRight(40,'.')} {40.50:c2}",
            $"{"Oak ".PadRight(40,'.')} {20.45:c2}",
            $"{"Pine ".PadRight(40,'.')} {15.40:c2}",
            $"{"Maple ".PadRight(40,'.')} {40.32:c2}",
            $"{"Walnut ".PadRight(40,'.')} {34.95:c2}"});
            this.carpetList.Items.AddRange(new object[] {
            $"{"Berber ".PadRight(40,'.')} {80.50:c2}",
            $"{"Wool ".PadRight(40,'.')} {63.45:c2}",
            $"{"Skating Rink ".PadRight(40,'.')} {15.40:c2}",
            $"{"Nylon ".PadRight(40,'.')} {17.32:c2}",
            $"{"Polyester ".PadRight(40,'.')} {21.95:c2}"});
            this.laminateList.Items.AddRange(new object[] {
            $"{"Imitation Marble ".PadRight(40,'.')} {29.50:c2}",
            $"{"Imitation Stone ".PadRight(40,'.')} {12.25:c2}",
            $"{"Imitation Wood ".PadRight(40,'.')} {15.40:c2}",
            $"{"Classic Brick ".PadRight(40,'.')} {20.32:c2}"});
            this.tileList.Items.AddRange(new object[] {
            $"{"Marble ".PadRight(40,'.')} {50.50:c2}",
            $"{"Granite ".PadRight(40,'.')} {30.45:c2}",
            $"{"Ceramic ".PadRight(40,'.')} {25.40:c2}",
            $"{"Imitation Brick ".PadRight(40,'.')} {14.32:c2}"});
        }

       

        private void computeBtn_Click(object sender, EventArgs e)
        {
            //grab selected tab from tab control 
            TabPage selected = tabControl1.SelectedTab;

            ListBox lb; //declare a listbox for future use
            //based on the selected tab's name, see which listbox we're going to connect it to 
            if (selected == hardwoodTab)
            {
                lb = hardwoodList;
            }
            else if (selected == carpetTab)
            {
                lb = carpetList;
            }
            else if (selected == laminateTab)
            {
                lb = laminateList;
            }
            else
            {
                lb = tileList;
            }

            //if any of our inputs are NOT populated, present error message and end method call 
            if (widFtTxt.Text == "" || widInTxt.Text == "" || lenFtTxt.Text == "" || lenInTxt.Text == "" || lb.SelectedIndex<0)
            {
                MessageBox.Show("Error: enter footage and select a flooring type please", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            double w, l, sqYrd, price; //declare initial doubles 

            w = (double.Parse(widFtTxt.Text) + (double.Parse(widInTxt.Text) / 12))/3; //parse width values and compute width in yards 
            l = (double.Parse(lenFtTxt.Text) + (double.Parse(lenInTxt.Text) / 12))/3;//parse length values and compute width in yards 
            sqYrd = l * w; //compute total square yards             

            string[] values = lb.SelectedItem.ToString().Split('.'); //taking the selected value from the listbox, split to remove periods and dollars 
            string up = $"{values[values.Length - 2].Substring(2)}.{ values[values.Length - 1]}"; //build a string containaing the price 
            double unitprice = double.Parse(up); //parse the price to a double 
            price = unitprice * sqYrd; //figure the price for total quard yards 

            //build result string using string interpolation, spacing, and formatting 
            string result = 
                $"Your {w:f2} X {l:f2} room will \n" +
                $"cost {price:c2} to cover with\n" +
                $"{values[0]}{selected.Text.ToLower()} at {unitprice:c2}/sqyd";
            //            MessageBox.Show(result);
            //display this result string in the appropriate control 
            displayLabel.Text = result; 

        }

        //this method is attached to the keypress evnt for the text boxes
        private void intText_KeyPress(object sender, KeyPressEventArgs e)
        {
            //MessageBox.Show(e.KeyChar+" "+char.IsDigit(e.KeyChar)+" "+e.Handled);
            if(!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; //by changing the event handled flag to true, the textbox will NOT include the character that was typed 
            } 
        }
    }
}
