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
        private string fName, lName;
        private DateTime dateOfHire;
        private Department dept;
        private Classification classification;
        private double monthlyPay;
        private double payRate;
        private int employeeID;
        private static int lastEmployeeID = 1000;

        //properties 



        //constructors 
        public Employee(string f, string l, Department d, Classification c, double pr)
        {
            fName = f;
            lName = l;
            dept = d;
            classification = c;
            payRate = pr;
            if (c == Classification.hourly)
            {
                monthlyPay = (40 * pr); //estimate 
            }
            else
            {
                monthlyPay = pr / 52;
            }
            employeeID = GenerateEmployeNum();
            dateOfHire = DateTime.Now;
        }

        //static method for generating sequntial student numbers 
        public int GenerateEmployeNum()
        {
            lastEmployeeID += 2;
            return lastEmployeeID;
        }
        //instance methods

        //override methods 
    }
}
