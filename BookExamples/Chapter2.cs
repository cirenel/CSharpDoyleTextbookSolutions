﻿//Claire Luikart
//june 2023
//solutions to C# Programing From Problem Analysis to Program Design 5th Ed by Barbara Doyle 
//each method contents can be directly placed in main method instead of their individualized methods here 
//these are each only one possible solution to the given prompts 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//CHAPTER 2 NOTES
// chapter 2 is all about 
// Topics of focus:
//  - 
// not in text but reccomended: 
//  - 

//Chapter 2 is covered in IT150

namespace BookExamples
{
    class Chapter2 : Chapter
    {
        public override void RunProblem(int num)
        {
            base.RunProblem(num);
        }

        public override void Problem1()
        {
            float tempC = 32f;
            float tempF = (tempC * (9.0f/5.0f))+32;
            //COMMON ERRORS TO NOTE
            //(tempC * (9/5))+32; --> THIS WILL RESULT IN THE WRONG VALUE as 9/5 is an integer division 
            //tempC * 9.0f/5.0f + 32; --> THIS WILL RESULT IN THE WRONG VALUE as order of opreations works left to right

            Console.WriteLine($"{tempC}°C --> {tempF:f1}°F\n");

        }

        public override void Problem2()
        {
            double miles = 4.5;
            const double mileToFt = 5280;
            const double mileToKm = 1.60934;

            double feet = miles * mileToFt;
            double km = miles * mileToKm;

            //refer to page 110 in text for string formatting information 
            string output = $"{miles:f2} miles is :\n\t{km,6:f2} kilometers\n\t{feet,6:f0} feet";
            Console.WriteLine(output);

        }

        public override void Problem3()
        {
            //COMMON ERROR:
            //using ints for exam grades --> will not result in fractional values 
            float exam1 = 100f;
            float exam2 = 92.6f;
            float exam3 = 85.3f;
            float exam4 = 64.7f;
            float exam5 = 90.6f;

            //COMMON ERROR:
            //float avg = exam1 + exam2 + exam3 + exam4 + exam5 / 5; --> order of operations will do the division FIRST 
            float avg = (exam1 + exam2 + exam3 + exam4 + exam5) / 5;
            

            string output = $"exam1: {exam1,6:f2}\n"+
                            $"exam2: {exam2,6:f2}\n" +
                            $"exam3: {exam3,6:f2}\n"+
                            $"exam4: {exam4,6:f2}\n" +
                            $"exam5: {exam5,6:f2}\n" +
                            $"avger: {avg,6:f2}\n";
            Console.WriteLine(output);


        }

        public override void Problem4()
        {
            int numCents = 92;
            int startingChange = numCents;

            int numQ = (numCents - (numCents % 25)) / 25;
            numCents = numCents - (numQ * 25);
            int numD = (numCents - (numCents % 10) ) / 10;
            numCents = numCents - (numD * 10);
            int numN = (numCents - (numCents % 5)) / 5;
            numCents = numCents - (numN * 5);
            int numP = numCents ;


            string output = $"{startingChange} cents is:\n" +
                            $"  -{numQ,2} quarters\n" +
                            $"  -{numD,2} dimes\n" +
                            $"  -{numN,2} nickles\n" +
                            $"  -{numP,2} pennies\n";

            Console.WriteLine(output);

        }

        public override void Problem5()
        {
            string label = "Open Collar Running Shirt";
            double price = 41;
            double saleMarkdown = 0.15; 
            double salePrice = price - (price * saleMarkdown) ;
            string output = $"{"Item", -30}  {"Price",-10}        Sale {saleMarkdown:p0}  \n" +
                            $"{label, -30}  {price,-10:c2}       {salePrice:c2}";
            Console.WriteLine(output);
        }

        public override void Problem6()
        {
            //USING DECIMAL DOES ODD THINGS WITH THIS VERSION OF .NET
            string employeeName = "Joshua Mountain";
            double salesComissionRate = 0.07;
            double socialSecurityRate = 0.06;
            double taxRate = 0.18;
            double retirementRate = 0.1;

            double monthlySale = 161432;
            double comission = monthlySale * salesComissionRate;
            double withholding = (socialSecurityRate + taxRate + retirementRate) * comission;
            double takehome = comission - withholding;

            string output = $"{"Employee",20} : {"Sales",14} : {"Comission",14} : {"Withholding",14} : {"Takehome",14}\n" +
                            $"{employeeName,20} : {monthlySale,14:c2} : {comission,14:c2} : {withholding,14:c2} : {takehome,14:c2}";
            Console.WriteLine(output);
        }

        public override void Problem7()
        {
            //POSSIBLE ERROR: on runtime, if an amount that is NOT a numeric value is entered, will cause a runtime error 
            Console.Write("Please enter the bill amount : ");
            string input = Console.ReadLine();
            double amount = double.Parse(input);

            string output = $"{"Amount", 10} : {"5%", 10} : {"10%",10} : {"15%",10} : {"20%",10} : {"25%",10}\n" +
                            $"{amount,10:c2} : {(amount*0.05),10:c2} : {(amount * 0.1),10:c2} : {(amount * 0.15),10:c2} : {(amount * 0.2),10:c2} : {(amount * 0.25),10:c2}\n" +
                            $"{"Added",10} : {(amount * 1.05),10:c2} : {(amount * 1.1),10:c2} : {(amount * 1.15),10:c2} : {(amount * 1.2),10:c2} : {(amount * 1.25),10:c2}\n";
            Console.WriteLine(output);
            
        }

        public override void Problem8()
        {
            //declare grade values 
            double homeworkGrade = 97;
            double projectGrade = 82;
            double quizGrade = 60;
            double examGrade = 75;
            double finalExamGrade = 80;

            //declare weight values 
            double hwWeight = 0.1;
            double proWeight = 0.25;
            double quizWeight = 0.1;
            double examWeight = 0.3;
            double finalWeight = 0.15; 

            double weightedAvg = (homeworkGrade * hwWeight) + 
                                 (projectGrade * proWeight) + 
                                 (quizGrade * quizWeight) + 
                                 (examGrade * examWeight) + 
                                 (finalExamGrade * finalWeight); //this is one line of code over multiple lines 

            string output = $">>>>>>>>>>>> FINAL GRADE CALCULATION <<<<<<<<<<<<\n" +
                            $"\t   {"Category",10} : {"Grade",6} @ {"Weight",6} : {"Included"}\n" + 
                            $"\t   {"Homework", 10} : {homeworkGrade,6} @ {hwWeight,6:p0} : {(homeworkGrade * hwWeight):f2}\n" +
                            $"\t + {"Projects", 10} : {projectGrade,6} @ {proWeight,6:p0} : {(projectGrade * proWeight):f2}\n" +
                            $"\t + {"Quizzes", 10} : {quizGrade,6} @ {quizWeight,6:p0} : {(quizGrade * quizWeight):f2}\n" +
                            $"\t + {"Exams",10} : {examGrade,6} @ {examWeight,6:p0} : {(examGrade * examWeight):f2}\n" +
                            $"\t + {"Final Exam",10} : {finalExamGrade,6} @ {finalWeight,6:p0} : {(finalExamGrade * finalWeight):f2}\n" +
                            $"FINAL GRADE . . . . . . . . . . . . . . . {weightedAvg:f2} \n";

            Console.WriteLine(output);
        }

        public override void Problem9()
        {
            int casesSold = 29;
            int barPerCase = 100;
            double pricePerCase = 100; 
            double sellPricePerBar = 1.5;
            double buyPricePerBar = pricePerCase / barPerCase;
            double profitPerBar = sellPricePerBar - buyPricePerBar;
            double studentOrgWitholding = 0.1;

            double totalProfit = (casesSold * barPerCase) * profitPerBar;
            double withholdingAmount = (totalProfit * studentOrgWitholding);
            double takeHome = totalProfit - withholdingAmount;

            string output = $"{"Bar/Case",8} : {"$ / case",10} : {"Sale $/Bar", 15} - {"Purchase $/Bar", 15} = {"Profit/Bar",15}\n" +
                            $"{barPerCase+" bars",8} : {pricePerCase,10:c2} : {sellPricePerBar,15:c2} - {buyPricePerBar,15:c2} = {profitPerBar,15:c2}\n" +
                            $"Cases Sold: {casesSold} \n" +
                            $"{"Total Profit", 15} :   {totalProfit,10:c2}\n" +
                            $"{"Witholding",15} : - {withholdingAmount,10:c2}\n" +
                            $"{"Club Take", 15} :   {takeHome,10:c2}";
            Console.WriteLine(output);

        }

        public override void Problem10()
        {
            throw new NotImplementedException();
        }

    }
}