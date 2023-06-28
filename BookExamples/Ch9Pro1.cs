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



        private void Ch9Pro1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            if (textBox1.Text != "")
            {
                MessageBox.Show($"Hello, {name}!");
            }
            else
            {
                MessageBox.Show("Please enter a name. ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
