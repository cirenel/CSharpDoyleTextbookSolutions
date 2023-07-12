using System;
using System.Collections.Generic;
using System.Text;

namespace BookExamplesFarrell
{
    //chapter 9 problem 2
    internal class ClassifiedAd
    {
        //supporting enum
        public enum Category
        {
            AUTOMOTIVE, 
            PETS, 
            SERVICES, 
            GARAGESALE,
            HELPWANTED,
            LOST,
            FOUND,
            GENERAL
        }

        //attributes 
        private Category category;
        private string contactName;
        private string header;
        private string body;
        private long phoneNumber;
        private string email;
        private double price;
        private bool paid; 

        //properties 
        public double Price
        {
            get { return price; }
        }
        public bool Paid
        {
            get { return paid; }
        }

        public Category AdCategory
        {
            get { return category; }
            set { category = value; }
        }

        //constructors
        public ClassifiedAd(string name, string header, string description, long phoneNumber)
        {
            this.category = Category.GENERAL;
            this.contactName = name;
            this.header = header;
            this.body = description;
            this.phoneNumber = phoneNumber;
            this.price = CalcPrice();
            this.paid = false; 
        }
        public ClassifiedAd(string name, string header, string description, string email)
        {
            this.category = Category.GENERAL;
            this.contactName = name;
            this.header = header;
            this.body = description;
            this.email = email;
            this.price = CalcPrice();
            this.paid = false;

        }

        public ClassifiedAd(string name, string header, string description, long phoneNumber, string email)
        {
            this.category = Category.GENERAL;
            this.contactName = name;
            this.header = header;
            this.body = description;
            this.phoneNumber = phoneNumber;
            this.email = email;
            this.price = CalcPrice();
            this.paid = false;

        }
        //methods

        private double CalcPrice()
        {
            return 0.09 * (body.Split(" ").Length);
        }

        public void Pay(double amount)
        {
            if(amount >= price)
            {
                price = 0;
                paid = true;
            }
            else if (price < amount) //partial payment 
            {
                price -= amount;
            }
        }

        //overrides 
        public override string ToString()
        {
            string ret = "";
            ret +=$"######## {header.ToUpper(),20} ########\n";
            ret += $" {body}\n";
            if (email != null) {
                ret += $"E-mail: {email,15} ";
            }
            if (phoneNumber != null) {
                ret += $"Phone: {phoneNumber,15} ";
            }
            return ret;
        }

    }
}
