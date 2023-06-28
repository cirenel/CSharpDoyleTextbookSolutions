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
    public partial class Ch9Pro6 : Form
    {
        public Ch9Pro6()
        {
            InitializeComponent();
        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            if(pwTxt1.Text != "")
            {

                label2.Visible = true;
                pwText2.Visible = true;
                compareBtn.Visible = true; 
            }
            else
            {
                MessageBox.Show("Please enter a new  password. ", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void compareBtn_Click(object sender, EventArgs e)
        {
            if (pwText2.Text != "" && pwText2.Text == pwTxt1.Text)
            {
                changeBtn.Visible = true;
              //  MessageBox.Show("match");
            } else if(pwText2.Text != pwTxt1.Text)
            {
                MessageBox.Show("Please enter a *matching* password ", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else
            {
                MessageBox.Show("Please enter a new  password. ", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void changeBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank you for updating your password.");
            label2.Visible = false;
            pwText2.Visible = false;
            compareBtn.Visible = false;
            changeBtn.Visible = false;
            pwTxt1.ResetText();
            pwText2.ResetText();

        }
    }
}
