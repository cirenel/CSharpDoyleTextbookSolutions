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
    public partial class Ch10Pro2 : Form
    {
        Dictionary<string, int> numShirts;
        Dictionary<string, string> orders; 

        public Ch10Pro2()
        {
            InitializeComponent();
            numShirts = new Dictionary<string, int>();
            orders = new Dictionary<string, string>();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            string name = nameText.Text;
            string size = sizeCombo.SelectedItem.ToString();
            string color = colorCombo.SelectedItem.ToString();

            if (name == "" || size == "" || color == "")
            {
                MessageBox.Show("Error: enter your name and select your size and color", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; 
            }

            string key = size + " " + color; 
            if(numShirts.ContainsKey(key))
            {
                numShirts[key]++;
            }
            else
            {
                numShirts.Add(key, 1);
            }

            if (orders.ContainsKey(name))
            {
                orders[name] += "\n" + key;
            } else
            {
                orders.Add(name, key);
            }


        }

        private void displayOrder_Click(object sender, EventArgs e)
        {
            string allOrder = "";
            foreach(object o in colorCombo.Items)
            {
                string color = o.ToString();
                allOrder += $"{color}\n";
                foreach(object oo in sizeCombo.Items)
                {
                    string size = oo.ToString();
                    string k = size+" "+color;
                    int amt = 0;
                    numShirts.TryGetValue(k, out amt);
                    allOrder += $"\t{size} : {amt}\n";
                }
            }
            MessageBox.Show(allOrder, "Order Information");
        }
    }
}
