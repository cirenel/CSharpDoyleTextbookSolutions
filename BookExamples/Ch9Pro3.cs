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

        private void addBtn_Click(object sender, EventArgs e)
        {
            string num1Str = num1Txt.Text;
            string num2Str = num2Txt.Text;
            double num1; double num2; 
            if(double.TryParse(num1Str, out num1) && double.TryParse(num2Str, out num2))
            {
                ansTxt.Text = (num1+num2).ToString();
            } else
            {
                MessageBox.Show("Please enter valid numbers. ","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void mulBtn_Click(object sender, EventArgs e)
        {
            string num1Str = num1Txt.Text;
            string num2Str = num2Txt.Text;
            double num1; double num2;
            if (double.TryParse(num1Str, out num1) && double.TryParse(num2Str, out num2))
            {
                ansTxt.Text = (num1 * num2).ToString();
            }
            else
            {
                MessageBox.Show("Please enter valid numbers. ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            num1Txt.Clear();
            num2Txt.Clear();
            ansTxt.Clear();
        }
    }
}
