using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookExamples
{
    public class Employee
    {
        //support enums for this class
        public enum Department
        {
            HR,
            IT,
            Sales,
            Marketing,
            RandD
        }
        public enum Classification
        {
            hourly,
            salary
        }

        //attributes 
        //declaration of the instance variables 
        private string fName, lName; 
        private DateTime dateOfHire;
        private Department dept;
        private Classification classification;
        private double monthlyPay;
        private double payRate;
        private int employeeID;
        private static int lastEmployeeID = 1000; //static meaning this is the one 

        //properties 
        //no properties present in this example


        //constructors 
        public Employee(string f, string l, Department d, Classification c, double pr)
        {
            fName = f; //assign the instance variable fName the value from parameter f
            lName = l;//assign the instance variable lName the value from parameter l
            dept = d; //assign the instance variable dept the value from parameter d
            classification = c; //assign the instance variable classificaiton the value from parameter c
            payRate = pr; //assign the instance variable payRate the value from parameter pr
            if (c == Classification.hourly)
            {
                monthlyPay = (40 * pr); //estimate 
            }
            else
            {
                monthlyPay = pr / 52;
            }
            employeeID = GenerateEmployeNum(); //generate employee number using the static variable 
            dateOfHire = DateTime.Now;
        }

        //static method for generating sequntial employee numbers 
        public int GenerateEmployeNum()
        {
            lastEmployeeID += 2;
            return lastEmployeeID;
        }
        //instance methods
        public double GetWeeklyPay(double hours = 40) //
        {
            double takehome; //create takehome variable to return later 

            if(classification == Classification.hourly) //if the classificaiton of this object is hourly 
            {
                if(hours > 40) //and if the hours are over 40
                {
                    takehome = (40 * payRate) + ((hours - 40) * 1.5 * payRate); //compute takehome's value based on the overtime rates  
                } else //otherwise
                {
                    takehome = hours * payRate; //compute takehome based on the normal rate
                }
            } else //otherwise [ if the player is not hourly ]
            {
                takehome = payRate / 52; //compute weekly pay for one week 
            }

            return takehome; //return the calculated takehome 
        }


        //override methods 
        public override string ToString()
        {
            return $"{employeeID,6} : {fName,10}, {lName,-10} : {dept, -10} : {classification.ToString().ToUpper()[0],5} : "; 
        }
    }
}
