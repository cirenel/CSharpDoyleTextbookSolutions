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
//  - parameters
//  - parameter modifiers 
//  - optional parameters 
//  - method overloading 
// not in text but reccomended: 
//  - visit this chapter AFTER discussing control flow, conditions, and arrays 

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
            string name = GetString("Please enter your name : "); //calling the GetString method 
            string saying = GetString("Please enter a saying : "); //calling the GetString method 
            PrintFormatted(name, saying); //calling the PrintFormatted method 
        }
        //methods for problem 1
        //this is the method header for the GetString method 
        private static string GetString(string msg) 
        {
            string ret = ""; //prepare return string 
            Console.Write(msg); //print message to screen 
            ret = Console.ReadLine(); //store user input in variable 
            return ret; //return stored string 
        }

        //this is the method header for the PrintFormatted method 
        private static void PrintFormatted(string n, string s)
        {
            //creation of the output string using interpolation, spacing, and formatting 
            string output = $"><><><><><><><><><><><><><><><><><><><><><><><><><><><><\n" +
                            $" {n} \n" +
                            $" {s} \n" +
                            $"><><><><><><><><><><><><><><><><><><><><><><><><><><><><";
            //print output string to screen 
            Console.WriteLine(output);
        }


        //Problem 2 begin 
        public override void Problem2()
        {
            Console.WriteLine(GetAstrisks()); //calling the GetAstrisks method then the WriteLine method with the result
            Console.WriteLine(GetSchoolInfo()); //calling the GetSchoolInfo method then the WriteLine method with the result
            Console.WriteLine(GetAstrisks()); //calling the GetAstrisks method then the WriteLine method with the result
        }
        //methods for problem 2 
        //this is the method header for the GetSchoolInfo method 
        private static string GetSchoolInfo()
        {
            //build and return the info string 
            string ret = "ITI Technical College\nFounded: 1973\nMotto: For a better Life\nColors: blue and grey";
            return ret; 
        }
        //this is the method header for the GetAstrisks method 
        private static string GetAstrisks()
        {
            //build and return the astrisks string
            string ret = "*********************************";
            return ret;
        }


        //Problem 3 begin
        public override void Problem3()
        {
            int height = GetInt("Please enter the height: "); //calling getint method [in the chapter class]
            int width = GetInt("Please enter the width: "); //calling getint method [in the chapter class]
            int perimeter = CalcPerimeter(h: height, w: width); //call the CalPerimeter method 

            //build the output string using string interpolation, formatting, and spacing 
            string output = $"The perimeter of a {height} X {width} rectangle is {perimeter}";
            //print output to the screen 
            Console.WriteLine(output);
        }
        //methods for problem 3
        //method declaration for CalcPerimeter method 
        private static int CalcPerimeter(int h, int w)
        {
            int ret = (2 * h) + (2 * w); //compute the perimeter using the standard perimeter format 
            return ret; //return the computed value 
        }

        //Problem 4 begin
        public override void Problem4()
        {
            int initSeconds = GetInt("Please enter the number of seconds : ");//calling getint method [in the chapter class]
            int hr = SecondToHour(initSeconds); //calling the SecondToHour method and saving the result in the hr variable 
            int min = SecondToMinute(initSeconds - (60 * 60 * hr));//calling the SecondToMinute method and saving the result in the min variable 
            int secLeft = initSeconds - (60 * 60 * hr) - (60 * min);

            //build the output string using string interpolation, formatting, and spacing 
            string output = $"{initSeconds} seconds is : {hr}hr {min}min and {secLeft}sec";
            //outputting output string 
            Console.WriteLine(output);
        }
        //methods for problem 4 
        //this is the method header for the SecondToMinute method 
        private static int SecondToMinute(int sec)
        {
            //take the input seconds value and divide by 60 [60 seconds in 1 min]
            int ret = sec / 60;
            return ret; 
        }
        //this is the method header for the SecondToHour method 
        private static int SecondToHour(int sec)
        {
            int ret = SecondToMinute(sec); //make use of the SecondToMinute method to find the number of minutes 
            ret = ret / 60; //then divide the result by 60 to find the number of hours [60 minutes in 1 hour] 
            return ret; 
        }

        //Problem 5 begin 
        public override void Problem5()
        {
            double degreeF = GetDouble("Please give me the temp in °F : "); //
            double degreeC = FtoC(degreeF);
            //build the output string using string interpolation, formatting, and spacing 
            string output = $"{degreeF,6:f2}°F\n" +
                            $"{degreeC,6:f2}°C";
            //print output to screen 
            Console.WriteLine(output);
        }
        private static double FtoC(double F)
        {
            double ret = (F - 32) * (5.0 / 9.0);
            return ret; 
        }

        //Problem 6 begin 
        public override void Problem6()
        {
            double meters = GetDouble("How many meters? ");
            int numFeet = ConvertMtoF(meters); //method call
            int numInch = ConvertMtoI(meters); //method call 
            Console.WriteLine($"{meters} m is {numFeet} ft and {numInch} in\n");
        }
        static int ConvertMtoF(double m)
        {
            double ftFractional = m * 3.28084;
            return Convert.ToInt32(ftFractional);
        }
        static int ConvertMtoI(double m)
        {
            double ftFrctionalLessWhole = (m * 3.28084) - ConvertMtoF(m);
            double inchesFraction = 12 * ftFrctionalLessWhole;
            return Convert.ToInt32(inchesFraction);
        }

        //Problem 7 begin 
        public override void Problem7()
        {
            double bill = GetDouble("How much is the bill? "); //use get double method specified in chapter class
            double tip5 = CalcTip(5, bill); //call the calc tip method for 5% and save result as variable 
            double tip10 = CalcTip(10, bill); //call the calc tip method for 10% and save result as variable 
            double tip15 = CalcTip(15, bill); //call the calc tip method for 15% and save result as variable 
            double tip20 = CalcTip(20, bill); //call the calc tip method for 20% and save result as variable 
            double taxAmnt = CalcTax(9, bill); //call the calc tax method and save result as variable 
            //build the output string using string interpolation, formatting, and spacing 
            string output = 
            $"\n{"Tip Percent", 15} : {"Tip Amount",15} : {"Subtotal",10}\n" +
            $"{0.05,15:p0} : {tip5,15:c2} : {tip5 + bill,10:c2}\n"+
            $"{0.1,15:p0} : {tip10,15:c2} : {tip10 + bill,10:c2}\n"+
            $"{0.15,15:p0} : {tip15,15:c2} : {tip15 + bill,10:c2}\n"+
            $"{0.20,15:p0} : {tip20,15:c2} : {tip20 + bill,10:c2}\n"+
            $"\n\t\tTax: {taxAmnt:c2}\n";
            //print output to screen 
            Console.WriteLine(output);

            double tipChoice = GetDouble("What percentage do you want to tip? "); //prompt the user for what precentage they wish to tip and save this value  
            double finalTip = CalcTip(tipChoice, bill); //use this value to compute the final tip 
            double total = taxAmnt + finalTip + bill; //use this final tip value to compute the total 
            //build the output string using string interpolation, formatting, and spacing 
            output = 
                $"\n{"Subtotal",9} : {bill,8:c2}\n" +
                $"{"Tip",9} : {finalTip,8:c2}\n" +
                $"{"Tax",9} : {taxAmnt,8:c2}\n" +
                $"{"Total",9} : {total,8:c2}";
            //print output to screen 
            Console.WriteLine(output);
        }
        //methods for problem 7
        //this is the method declaration for the calc tip method 
        private static double CalcTip(double tipPercent, double amount)
        {
            //using the tip precentage and amount, compute the tip, store it as a variable then return it 
            double ret = (tipPercent/100) * amount;
            return ret;
        }
        private static double CalcTax(double taxPercent, double amount)
        {
            //using the tax precentage and amount, compute the tax, store it as a variable then return it 
            double ret = (taxPercent / 100) * amount;
            return ret;
        }

        //Problem 8 begin 
        //again.... not sure why this is here with methods? 
        //this is a revisit of a chapter 2 problem --> however now we are making a method to read the amounts in for our various variables 
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

            //build the output string using string interpolation, spacing, and formatting 
            string output = 
    $"{"Bar/Case",8} : {"$ / case",10} : {"Sale $/Bar",15} - {"Purchase $/Bar",15} = {"Profit/Bar",15}\n" +
    $"{barPerCase + " bars",8} : {pricePerCase,10:c2} : {sellPricePerBar,15:c2} - {buyPricePerBar,15:c2} = {profitPerBar,15:c2}\n" +
    $"Cases Sold: {casesSold} \n" +
    $"{"Total Profit",15} :   {totalProfit,10:c2}\n" +
    $"{"Witholding",15} : - {withholdingAmount,10:c2}\n" +
    $"{"Club Take",15} :   {takeHome,10:c2}";
            //print the output string to the screen 
            Console.WriteLine(output);
        }

        //Problem 9 begin 
        //again.... not sure why this is here with methods? 
        //this is a rehash of a chapter 2 problem 
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

        //Problem 10 begin 
        public override void Problem10()
        {
            throw new NotImplementedException();
        }



    }
}
