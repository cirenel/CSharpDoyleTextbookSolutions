//Claire Luikart
//june 2023
//solutions to Microsoft Visual C# 2017 An Introduction to Object-Oriented Programming by Joynce Farrell 7th ed
//each method contents can be directly placed in main method instead of their individualized methods here 
//these are each only one possible solution to the given prompts 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



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
            Console.WriteLine($"A: 2 + 5 * 3 = { 2 + 5 * 3 }");
            Console.WriteLine($"B: 9 / 4 + 10 = { 9 / 4 + 10 }");
            Console.WriteLine($"C: 10 / 3 = { 10 / 3 }");
            Console.WriteLine($"D: 21 % 10 = { 21 % 10 }");
            Console.WriteLine($"E: ( 5 - 1 ) * 3 = { ( 5 - 1 ) * 3 }");
            Console.WriteLine($"F: 37 / 5 = { 37 / 5 }");
            Console.WriteLine($"G: 64 % 8 = { 64 % 8 }");
            Console.WriteLine($"H: 5 + 2 * 4 - 3 * 4 = { 5 + 2 * 4 - 3 * 4 }");
            Console.WriteLine($"I: 3 * (2 + 5 ) / 5 = { 3 * (2 + 5 ) / 5 }");
            Console.WriteLine($"J: 28 % 5 - 2 = { 28 % 5 - 2 }");
            Console.WriteLine($"K: 19 / 2 / 2 = { 19 / 2 / 2 }");
            Console.WriteLine($"L: 28 / ( 2 - 4 ) = { 28 / ( 2 - 4 ) }");


        }

        public override void Problem2()
        {
            Console.WriteLine($"A: 5 > 4 : {5 > 4}");
            Console.WriteLine($"B: 3 <= 3 : {3 <= 3}");
            Console.WriteLine($"C: 2 + 4 > 5 : {2 + 4 > 5}");
            Console.WriteLine($"D: 6 == 7 : {6 == 7}");
            Console.WriteLine($"E: 2 + 4 <= 6 : {2 + 4 <= 6}");
            Console.WriteLine($"F: 3 + 4 == 4 + 3 : {3 + 4 == 4 + 3}");
            Console.WriteLine($"G: 1 != 2 : {1 != 2}");
            Console.WriteLine($"H: 2 != 2 : {2 != 2}");
            Console.WriteLine($"I: -5 == 7 - 2 : {-5 == 7 - 2}");
            Console.WriteLine($"J: 3 + 9 <= 0 : {3 + 9 <= 0}");

        }

        public override void Problem3()
        {
            throw new NotImplementedException();

        }

        public override void Problem4()
        {
            double value1 = 10.5;
            //decimal value2 = 10.5; ///INCORRECT SYNTAX 
            decimal value2 = 10.5m;

            Console.WriteLine($"{"Double",20} : {"Decimal",20}\n" +
                              $"{value1,20} : {value2,20}");

        }

        public override void Problem5()
        {
            const double In2Cm = 2.54;

            
            double inputNumeric = 10.5;
            double centimeters = inputNumeric * In2Cm;

            Console.WriteLine($"{inputNumeric} inches is {centimeters:f2} centimeters.");

        }

        public override void Problem6()
        {
            const double In2Cm = 2.54;

            Console.Write("Please give me the number of inches: ");
            string inputString = Console.ReadLine();
            double inches = double.Parse(inputString);
            double centimeters = inches * In2Cm;

            Console.WriteLine($"{inches} inches is {centimeters:f2} centimeters.");

        }

        public override void Problem7()
        {
            const double raiseAmnt = 0.04;
            double sal1 = 15000;
            double sal2 = 25000;
            double sal3 = 45000;

            string output = $"{"Employee",10} : {"Before", 10} : {"After",10}\n" +
                            $"{1,10} : {sal1,10:c2} : {sal1*(1+raiseAmnt),10:c2}\n" +
                            $"{2,10} : {sal2,10:c2} : {sal2*(1+raiseAmnt),10:c2}\n" +
                            $"{3,10} : {sal3,10:c2} : {sal3*(1+raiseAmnt),10:c2}\n" +
                            $"";
            Console.WriteLine(output);
        }

        public override void Problem8()
        {
            const double raiseAmnt = 0.04;
            Console.WriteLine("Please enter your current payrate: ");
            string inputString = Console.ReadLine();
            double salary = double.Parse(inputString);
            string output = $"{"Employee",10} : {"Before",10} : {"After",10}\n" +
                            $"{1,10} : {salary,10:c2} : {salary * (1 + raiseAmnt),10:c2}\n";
            Console.WriteLine(output);

        }

        public override void Problem9()
        {
            const double baseRate = 200;
            const double perHour = 150;
            const double perMile = 2; 

            Console.WriteLine("Please enter the number of hours: ");
            string inputString = Console.ReadLine();
            double hours = double.Parse(inputString);
            Console.WriteLine("Please enter the number of miles: ");
            inputString = Console.ReadLine();
            double miles = double.Parse(inputString);

            double estimate = baseRate + (perMile * miles) + (perHour * hours);
            string output = $"Your estimated fee will be {estimate:c2}.";
            Console.WriteLine(output);
        }

        public override void Problem10()
        {
            Console.Write("Give me the number of minutes : ");
            int minutes = int.Parse(Console.ReadLine());
            int hours = minutes / 60;
            minutes = minutes - (60 * hours);
            Console.WriteLine($"Your entered value is : {hours} hr and {minutes} min.");
        }

        public override void Problem11()
        {
            int egg1 = 100;
            int egg2 = 20; 
            int egg3 = 30;
            int egg4 = 2;
            int totalEggs = egg1 + egg2 + egg3 + egg4;

            int numDozen = totalEggs / 12;
            int numSpares = totalEggs - ( numDozen * 12);
            Console.WriteLine($"For chickens 1 - 4: {totalEggs} were produced\n" +
                              $"This is {numDozen} dozen and {numSpares} single eggs. ");
            
        }
        public override void Problem12()
        {
            Console.Write("How many eggs did chicken 1 [Henrietta] produce? ");
            string inputString = Console.ReadLine();
            int egg1 = int.Parse(inputString);
            Console.Write("How many eggs did chicken 2 [Bernice] produce? ");
             inputString = Console.ReadLine();
            int egg2 = int.Parse(inputString);
            Console.Write("How many eggs did chicken 3 [Camilla] produce? ");
             inputString = Console.ReadLine();
            int egg3 = int.Parse(inputString);
            Console.Write("How many eggs did chicken 4 [Margaret] produce? ");
             inputString = Console.ReadLine();
            int egg4 = int.Parse(inputString);

            int totalEggs = egg1 + egg2 + egg3 + egg4;

            int numDozen = totalEggs / 12;
            int numSpares = totalEggs - (numDozen * 12);
            Console.WriteLine($"For chickens 1 - 4: {totalEggs} were produced\n" +
                              $"This is {numDozen} dozen and {numSpares} single eggs. ");
        }
        public override void Problem13()
        {
            int num100, num50, num20, num10, num5, num1, numQ, numD, numN, numP; 

            Console.Write("Please give me the amount to make change for: ");
            double totalAmount = double.Parse(Console.ReadLine());
            int numDollar = (int)totalAmount; 
            int numCent = (int)((totalAmount - numDollar)*100);

            num100 = numDollar / 100;
            numDollar = numDollar - (100 * num100);
            num50 = numDollar / 50;
            numDollar = numDollar - (50 * num50);
            num20 = numDollar / 20;
            numDollar = numDollar - (20 * num20);
            num10 = numDollar / 10;
            numDollar = numDollar - (10 * num10);
            num5 = numDollar / 5;
            numDollar = numDollar - (5 * num5);
            num1 = numDollar;

            numQ = numCent / 25;
            numCent = numCent - (25 * numQ);
            numD = numCent / 10;
            numCent = numCent - (10 * numD);
            numN = numCent / 5;
            numCent = numCent - (5 * numN);
            numP = numCent;

            string output = $"{totalAmount:c2} is best made to change with: \n" +
                            $"\t100 : {num100}\n" +
                            $"\t 50 : {num50}\n" +
                            $"\t 20 : {num20}\n" +
                            $"\t 10 : {num10}\n" +
                            $"\t  5 : {num5}\n" +
                            $"\t  1 : {num1}\n" +
                            $"\t  Q : {numQ}\n" +
                            $"\t  D : {numD}\n" +
                            $"\t  N : {numN}\n" +
                            $"\t  P : {numP}\n"
                            ;
            Console.WriteLine(output);

        }
        public override void Problem14()
        {
            double test1, test2, test3, test4, test5, test6, test7, test8;
            string inputString;

            Console.Write("Input test 1: ");
            inputString = Console.ReadLine();
            test1 = double.Parse(inputString);
            Console.Write("Input test 2: ");
            inputString = Console.ReadLine();
            test2 = double.Parse(inputString);
            Console.Write("Input test 3: ");
            inputString = Console.ReadLine();
            test3 = double.Parse(inputString);
            Console.Write("Input test 4: ");
            inputString = Console.ReadLine();
            test4 = double.Parse(inputString);
            Console.Write("Input test 5: ");
            inputString = Console.ReadLine();
            test5 = double.Parse(inputString);
            Console.Write("Input test 6: ");
            inputString = Console.ReadLine();
            test6 = double.Parse(inputString);
            Console.Write("Input test 7: ");
            inputString = Console.ReadLine();
            test7 = double.Parse(inputString);
            Console.Write("Input test 8: ");
            inputString = Console.ReadLine();
            test8 = double.Parse(inputString);

            double avg = (test1 + test2 + test3 + test4 + test5 + test6 + test7 + test8) / 8;
            Console.Write($"The average of these tests is {avg:f2}");

        }
        public override void Problem15()
        {

            Console.Write("What is the tempreture in F: ");
            double tempF = double.Parse(Console.ReadLine());
            double tempC = (32 - tempF) * (9.0 / 5.0);
            Console.WriteLine($"{tempF:f1}°F is {tempC:f1}°C");
        }
        public override void Problem16()
        {
            Console.Write("Give me a numeric month: ");
            int month = int.Parse(Console.ReadLine());
            string monthName;
            switch (month)
            {
                case 1:
                    monthName = "JANUARY";
                    break;
                case 2:
                    monthName = "FEBERARY";
                    break;
                case 3:
                    monthName = "MARCH";
                    break;
                case 4:
                    monthName = "APRIL";
                    break;
                case 5:
                    monthName = "MAY";
                    break;
                case 6:
                    monthName = "JUNE";
                    break;
                case 7:
                    monthName = "JULY";
                    break;
                case 8:
                    monthName = "AUGUST";
                    break;
                case 9:
                    monthName = "SEPTEMBER";
                    break;
                case 10:
                    monthName = "OCTOBER";
                    break;
                case 11:
                    monthName = "NOVEMBER";
                    break;
                case 12:
                    monthName = "DECEMBER";
                    break;
                default:
                    monthName = "INVALID";
                    break;
            }
            Console.WriteLine($"{month} is {monthName}");
        }
        public override void Problem17()
        {

            Console.Write("Give me a planet position: ");
            int position = int.Parse(Console.ReadLine());
            string planet;
            if( position == 1)
            {
                planet = "MERCUERY";
            } else if (position == 2)
            {
                planet = "VENUS";
            }
            else if (position == 3)
            {
                planet = "EARTH";
            }
            else if (position == 4)
            {
                planet = "MARS";
            }
            else if (position == 5)
            {
                planet = "JUPITER";
            }
            else if (position == 6)
            {
                planet = "SATURN";
            }
            else if (position == 7)
            {
                planet = "URANUS";
            }
            else if (position == 8)
            {
                planet = "NEPTUNE";
            }
            else if (position == 9)
            {
                planet = "[not] PLUTO";
            }
            else
            {
                planet = "INVALID";
            }
            Console.WriteLine($"{planet} is in position {position}");
        }
        public override void Problem18()
        {

            throw new NotImplementedException();
        }
        public override void Problem19()
        {

            throw new NotImplementedException();
        }
        public override void Problem20()
        {

            throw new NotImplementedException();
        }
    }
}
