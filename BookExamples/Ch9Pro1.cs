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
    public partial class Ch9Pro1 : Form
    {
        public Ch9Pro1()
        {
            InitializeComponent();
        }




        //this method is connected to the button1 object's click event 
        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text; //retrive the text from the text box 
            if (textBox1.Text != "") //is there some text that we pulled or no? 
            {
                MessageBox.Show($"Hello, {name}!"); //pop up a message box greeting the name 
            }
            else
            {
                //if no text was entered, we produce an error 
                MessageBox.Show("Please enter a name. ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
