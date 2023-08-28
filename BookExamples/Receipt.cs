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
        private Dictionary<Item, int> items; //the item subclass is defined below
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

        //methods
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

            if(total == 0) CalcTotal(); //calcuate the total if it has not been calculated 
            
            //begin building the recipt with a header and the number 
            string ret = " =========================================== \n" +
                         "|                                           |\n" +
                        $"|             | RECEIPT {recNum,3} |               |\n" +
                         "|                                           |\n" +
                         " =========================================== \n" ; 

            //append the date 
            ret += $" {$"{orderTime.Date.Month}/{orderTime.Date.Day}/{orderTime.Date.Year}",-10}\n";
            //foreach item in the items dictionary: 
            foreach (Item i in items.Keys)
            {
                for (int j = 0; j < items[i]; j++) //grab
                {
                    ret += $"{i.description,15} ...................... {i.price,6:c2}\n";
                }
            }
            //append the subtotal, tax, and total to the end of the recipt 
            ret +=  "---------------------------------------------\n";
            ret += $" Subtotal ........................... {subtotal,8:c2}\n";
            ret += $" Tax      ........................... {saleTaxRate * subtotal,8:c2}\n";
            ret += $" Total    ........................... {total,8:c2}\n";
            ret += "\n=============================================\n";

            if (paid) //if the user has paid this recipt
            {
                //append the payment amount and change
                ret += $"Paid       .......................... {amountTended,8:c2}\n";
                ret += $"Change Due .......................... {amountTended-total,8:c2}\n";
            } else if(amountTended > 0)
            {
                //if the amount that has been tended is more than 0, append how much is still owed 
                ret += $"Paid ................................ {amountTended,8:c2}\n";
                ret += $"Due  .............................. {total-amountTended,8:c2}\n";
                ret +=  "  ADDITIONAL PAYMENT IS DUE. PLEASE PAY NOW.\n";
            }
            else
            {
                //append a message to pay now
                ret += "        PAYMENT IS DUE. PLEASE PAY NOW.\n";

            }
            //append a footer 
            ret += "=============================================\n";

            return ret; //return the string representing the recipt 
        }

        public int CompareTo(Receipt other)
        {
            return total.CompareTo(other.total); //recipts are compared and ordered by their total 
        }
    }

    class Item
    {
        //each recipt item is made up of the decription and price 
        public string description;
        public double price; 

        public Item(string description, double price)
        {
            this.description = description;
            this.price = price;
        }
    }
}
