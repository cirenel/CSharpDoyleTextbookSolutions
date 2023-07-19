using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookExamples
{
    internal class Receipt : IComparable<Receipt> //see CH 11 for information on interfaces 
    {
        //attributes
        private DateTime orderTime;
        private Dictionary<Item, int> items;
        private double total, subtotal;
        private const double saleTaxRate = 0.095;
        private double amountTended;
        private bool paid; 
        private static int lastRecNum = 1;
        private int recNum;

        //properties
        public double Total 
        { 
            get 
            { 
                if(total == 0) { CalcTotal(); }
                return total; 
            } 
        }

        //constructor
        public Receipt()
        {
            orderTime = DateTime.Now;
            items = new Dictionary<Item, int>();
            total = 0;
            subtotal = 0;
            recNum = lastRecNum++;
        }

        public void AddItem(Item i)
        {
            subtotal+=i.price;
            if (items.ContainsKey(i)) //items.TryGetValue(i, out quantity)
            {
                items[i]++;
            } else
            {
                items.Add(i, 1);
            }
        }

        private void CalcTotal()
        {
            total = Math.Round(subtotal + (subtotal * saleTaxRate), 2);
        }

        public void Pay(double amt)
        {
            if(total == 0) CalcTotal();
            if(amt >= total)
            {
                paid = true; 
                amountTended = amt;
            } else
            {
                paid = false;
                amountTended = amt;
            }
        }

        public string GetReceipt()
        { 
            if(total == 0) CalcTotal();
            string ret = " =========================================== \n" +
                         "|                                           |\n" +
                         $"|             | RECEIPT {recNum,3} |               |\n" +
                         "|                                           |\n" +
                         " =========================================== \n" ;
            ret += $" {$"{orderTime.Date.Month}/{orderTime.Date.Day}/{orderTime.Date.Year}",-10}\n";
            foreach (Item i in items.Keys)
            {
                for (int j = 0; j < items[i]; j++)
                {
                    ret += $"{i.description,15} ...................... {i.price,6:c2}\n";
                }
            }
            ret +=  "---------------------------------------------\n";
            ret += $" Subtotal ........................... {subtotal,8:c2}\n";
            ret += $" Tax      ........................... {saleTaxRate * subtotal,8:c2}\n";
            ret += $" Total    ........................... {total,8:c2}\n";
            ret += "\n=============================================\n";

            if (paid)
            {
                ret += $"Paid       .......................... {amountTended,8:c2}\n";
                ret += $"Change Due .......................... {amountTended-total,8:c2}\n";
            } else if(amountTended > 0)
            {
                ret += $"Paid ................................ {amountTended,8:c2}\n";
                ret += $"Due  .............................. {total-amountTended,8:c2}\n";
                ret +=  "  ADDITIONAL PAYMENT IS DUE. PLEASE PAY NOW.\n";
            }
            else
            {
                ret += "        PAYMENT IS DUE. PLEASE PAY NOW.\n";

            }
            ret += "=============================================\n";

            return ret;
        }

        public int CompareTo(Receipt other)
        {
            return total.CompareTo(other.total);
        }
    }

    class Item
    {
        public string description;
        public double price; 

        public Item(string description, double price)
        {
            this.description = description;
            this.price = price;
        }
    }
}
