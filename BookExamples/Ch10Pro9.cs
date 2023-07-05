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

        }

       

        private void computeBtn_Click(object sender, EventArgs e)
        {
            TabPage selected = tabControl1.SelectedTab;
            ListBox lb;
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

            if (widFtTxt.Text == "" || widInTxt.Text == "" || lenFtTxt.Text == "" || lenInTxt.Text == "" || lb.SelectedIndex<0)
            {
                MessageBox.Show("Error: enter footage and select a flooring type please", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            double w, l, sqYrd, price;

            w = (double.Parse(widFtTxt.Text) + (double.Parse(widInTxt.Text) / 12))/3;
            l = (double.Parse(lenFtTxt.Text) + (double.Parse(lenInTxt.Text) / 12))/3;
            sqYrd = l * w;

            

            string[] values = lb.SelectedItem.ToString().Split('.');
            string up = $"{values[values.Length - 2].Substring(2)}.{ values[values.Length - 1]}"; 
            double unitprice = double.Parse(up);
            price = unitprice * w * l; 
            string result = 
                $"Your {w:f2} X {l:f2} room will \n" +
                $"cost {price:c2} to cover with\n" +
                $"{values[0]}{selected.Text.ToLower()} at {unitprice:c2}/sqyd";
            //            MessageBox.Show(result);
            displayLabel.Text = result; 

        }

        private void intText_KeyPress(object sender, KeyPressEventArgs e)
        {
            //MessageBox.Show(e.KeyChar+" "+char.IsDigit(e.KeyChar)+" "+e.Handled);
            if(!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; 
            } 
        }
    }
}
