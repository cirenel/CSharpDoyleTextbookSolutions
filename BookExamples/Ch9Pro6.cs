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
            //if there is a password entered in the text box 
            if(pwTxt1.Text != "")
            {
                //unveil the other controls for the second password enter 
                label2.Visible = true;
                pwText2.Visible = true;
                compareBtn.Visible = true; 
            }
            else //otherwise present an error 
            {
                MessageBox.Show("Please enter a new  password. ", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void compareBtn_Click(object sender, EventArgs e)
        {
            //if there is a second password in the textbox AND it matches the first 
            if (pwText2.Text != "" && pwText2.Text == pwTxt1.Text)
            {
                //unveil the final controls 
                changeBtn.Visible = true;
              //  MessageBox.Show("match");
            } else if(pwText2.Text != pwTxt1.Text)
            { //otherwise, if the newly entered password does not match, present the appropriate error 
                MessageBox.Show("Please enter a *matching* password ", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else
            {
                //otherwise, present an error to enter a second password 
                MessageBox.Show("Please enter a new  password. ", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void changeBtn_Click(object sender, EventArgs e)
        {
            //if all controls have been unveiled, the idea is that this button will trigger an actual password change and reset the form 
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
