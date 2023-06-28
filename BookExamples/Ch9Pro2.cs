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
    public partial class Ch9Pro2 : Form
    {
        public Ch9Pro2()
        {
            InitializeComponent();
        }

        private void colorBtn_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            int R = r.Next(0, 256);
            int G = r.Next(0, 256);
            int B = r.Next(0, 256);

            this.BackColor = Color.FromArgb(R, G, B);

        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            this.BackColor = SystemColors.Window;
        }
    }
}
