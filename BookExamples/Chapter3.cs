//Claire Luikart
//june 2023
//solutions to C# Programing From Problem Analysis to Program Design 5th Ed by Barbara Doyle 
//each method contents can be directly placed in main method instead of their individualized methods here 
//these are each only one possible solution to the given prompts 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//CHAPTER 3 NOTES
// chapter 3 is all about 
// Topics of focus:
//  - methods
//  - returning different types
//  - static keyword
//  - repeating code 
// not in text but reccomended: 
//  - 

//NOTE: i have traditionally NOT covered this chapter until AFTER the IT150  midterm exam
//in this file, additional comments are used to mark where and what methods are asssociated with which problems 

//Chapter 3 is covered in IT150 [after midterms]

namespace BookExamples
{
    class Chapter3 : Chapter
    {

        public override void RunProblem(int num)
        {
            base.RunProblem(num);
        }


        //Problem 1 begin 
        public override void Problem1()
        {
            string name = GetString("Please enter your name : ");
            string saying = GetString("Please enter a saying : ");
            PrintFormatted(name, saying);
        }
        //methods for problem 1
        private static string GetString(string msg)
        {
            string ret = "";
            Console.Write(msg);
            ret = Console.ReadLine();
            return ret; 
        }
        private static void PrintFormatted(string n, string s)
        {
            string output = $"><><><><><><><><><><><><><><><><><><><><><><><><><><><><\n" +
                            $" {n} \n" +
                            $" {s} \n" +
                            $"><><><><><><><><><><><><><><><><><><><><><><><><><><><><";
            Console.WriteLine(output);
        }


        //Problem 2 begin 
        public override void Problem2()
        {
            Console.WriteLine(GetAstrisks());
            Console.WriteLine(GetSchoolInfo());
            Console.WriteLine(GetAstrisks());
        }
        //methods for problem 2 
        private static string GetSchoolInfo()
        {
            string ret = "ITI Technical College\nFounded: 1973\nMotto: For a better Life\nColors: blue and grey";
            return ret; 
        }
        private static string GetAstrisks()
        {
            string ret = "*********************************";
            return ret;
        }


        //Problem 3 begin
        public override void Problem3()
        {
            int height = GetInt("Please enter the height: ");
            int width = GetInt("Please enter the width: ");
            int perimeter = CalcPerimeter(h: height, w: width);
            string output = $"The perimeter of a {height} X {width} rectangle is {perimeter}";
            Console.WriteLine(output);
        }
        //methods for problem 3
        private static int CalcPerimeter(int h, int w)
        {
            int ret = (2 * h) + (2 * w);
            return ret; 
        }

        //Problem 4 begin
        public override void Problem4()
        {
            int initSeconds = GetInt("Please enter the number of seconds : ");
            int hr = SecondToHour(initSeconds);
            int min = SecondToMinute(initSeconds - (60 * 60 * hr));
            int secLeft = initSeconds - (60 * 60 * hr) - (60 * min);

            string output = $"{initSeconds} seconds is : {hr}hr {min}min and {secLeft}sec";
            Console.WriteLine(output);
        }
        //methods for problem 4 
        private static int SecondToMinute(int sec)
        {
            int ret = sec / 60;
            return ret; 
        }
        private static int SecondToHour(int sec)
        {
            int ret = SecondToMinute(sec);
            ret = ret / 60;
            return ret; 
        }

        //Problem 5 begin 
        public override void Problem5()
        {
            double degreeF = GetDouble("Please give me the temp in °F : ");
            double degreeC = FtoC(degreeF);
            string output = $"{degreeF,6:f2}°F\n" +
                            $"{degreeC,6:f2}°C";
            Console.WriteLine(output);
        }
        private static double FtoC(double F)
        {
            double ret = (F - 32) * (5.0 / 9.0);
            return ret; 
        }

        //Problem 6 begin 
        //i dont know why this is in methods. 
        public override void Problem6()
        {
            double meterToFt = 3.28084;
            double meterToIn = 39.37008;

            double meters = GetDouble("Please give me a number of meters : ");
            double feet = meters * meterToFt;
            double inches = meters * meterToIn;

            int ftInt = (int) feet;
            //OR 
            //int f = feet as int;
            int inInt = (int) ((feet - ftInt) * 12);
            string intMeasure = $"{ ftInt }'{inInt}\"";

            string output = $"  {meters:f2} m is :\n" +
                            $"\t{feet,8:f2} ft\n" +
                            $"\t{inches,8:f2} in\n" +
                            $"\tOR\n" +
                            $"\t{intMeasure,8}";
            Console.WriteLine(output);

        }

        //Problem 7 begin 
        public override void Problem7()
        {
            double bill = GetDouble("How much is the bill? ");
            double tip5 = CalcTip(5, bill);
            double tip10 = CalcTip(10, bill);
            double tip15 = CalcTip(15, bill);
            double tip20 = CalcTip(20, bill);
            double taxAmnt = CalcTax(9, bill);
            string output = 
            $"\n{"Tip Percent", 15} : {"Tip Amount",15} : {"Subtotal",10}\n" +
            $"{0.05,15:p0} : {tip5,15:c2} : {tip5 + bill,10:c2}\n"+
            $"{0.1,15:p0} : {tip10,15:c2} : {tip10 + bill,10:c2}\n"+
            $"{0.15,15:p0} : {tip15,15:c2} : {tip15 + bill,10:c2}\n"+
            $"{0.20,15:p0} : {tip20,15:c2} : {tip20 + bill,10:c2}\n"+
            $"\n\t\tTax: {taxAmnt:c2}\n";
            Console.WriteLine(output);

            double tipChoice = GetDouble("What percentage do you want to tip? ");
            double finalTip = CalcTip(tipChoice, bill);
            double total = taxAmnt + finalTip + bill;
            output = 
                $"\n{"Subtotal",9} : {bill,8:c2}\n" +
                $"{"Tip",9} : {finalTip,8:c2}\n" +
                $"{"Tax",9} : {taxAmnt,8:c2}\n" +
                $"{"Total",9} : {total,8:c2}";
            Console.WriteLine(output);
        }
        //methods for problem 7
        private static double CalcTip(double tipPercent, double amount)
        {
            double ret = (tipPercent/100) * amount;
            return ret;
        }
        private static double CalcTax(double taxPercent, double amount)
        {
            double ret = (taxPercent / 100) * amount;
            return ret;
        }

        //Problem 8 begin 
        //again.... not sure why this is here with methods? 
        public override void Problem8()
        {
            int casesSold = GetInt("How many cases were sold? ");
            int barPerCase = GetInt("How many bars are in one case? ");
            double pricePerCase = GetDouble("How much does one case cost? ");
            double sellPricePerBar = GetDouble("How much are you charging for one bar? ");
            double buyPricePerBar = pricePerCase / barPerCase;
            double profitPerBar = sellPricePerBar - buyPricePerBar;
            double studentOrgWitholding = 0.1;

            double totalProfit = (casesSold * barPerCase) * profitPerBar;
            double withholdingAmount = (totalProfit * studentOrgWitholding);
            double takeHome = totalProfit - withholdingAmount;

            string output = 
    $"{"Bar/Case",8} : {"$ / case",10} : {"Sale $/Bar",15} - {"Purchase $/Bar",15} = {"Profit/Bar",15}\n" +
    $"{barPerCase + " bars",8} : {pricePerCase,10:c2} : {sellPricePerBar,15:c2} - {buyPricePerBar,15:c2} = {profitPerBar,15:c2}\n" +
    $"Cases Sold: {casesSold} \n" +
    $"{"Total Profit",15} :   {totalProfit,10:c2}\n" +
    $"{"Witholding",15} : - {withholdingAmount,10:c2}\n" +
    $"{"Club Take",15} :   {takeHome,10:c2}";
            Console.WriteLine(output);
        }

        //Problem 9 begin 
        //again.... not sure why this is here with methods? 
        public override void Problem9()
        {
            Console.Write("What is the employee name? ");
            string employeeName = Console.ReadLine();
            double salesComissionRate = 0.07;
            double socialSecurityRate = 0.06;
            double taxRate = 0.18;
            double retirementRate = 0.15;

            double monthlySale = GetDouble("What was this employee's total sales this month? ");
            double comission = monthlySale * salesComissionRate;
            double withholding = (socialSecurityRate + taxRate + retirementRate) * comission;
            double takehome = comission - withholding;

            string output = $"{"Employee",20} : {"Sales",14} : {"Comission",14} : {"Withholding",14} : {"Takehome",14}\n" +
                $"{employeeName,20} : {monthlySale,14:c2} : {comission,14:c2} : {withholding,14:c2} : {takehome,14:c2}";
            Console.WriteLine(output);
        }

        //Problem 9 begin 
        public override void Problem10()
        {
            throw new NotImplementedException();
        }



    }
}
