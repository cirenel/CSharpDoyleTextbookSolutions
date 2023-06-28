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

namespace BookExamples
{
    //CHAPTER 5 NOTES
    // chapter 5 is all about 
    // Topics of focus:
    //  - conditional statements
    //  - booleans
    //  - if - else if - else
    //  - switch statements 
    // not in text but reccomended: 
    //  - 

    //Note: in past, this section was covered BEFORE chapters 3 and 4 [methods and classes]
    //thus, most of the solutions here do NOT use classes as they say to in the prompt
    //i do not know why the text chose this order but condtions and control flow are better
    //and easier to see the impact off to n00bs if we pull them FIRST 

    //Chapter 5 is covered in IT150

    class Chapter5 : Chapter
    {

        public override void RunProblem(int num)
        {
            base.RunProblem(num);
        }

        public override void Problem1()
        {
            //this could also be done using a switch statement 
            int goal = GetInt("Give me a number between 1 and 10: ", 1, 10);
            string romanNumeral = ""; 

            if(goal == 1)
            {
                romanNumeral = "I";
            } else if (goal == 2)
            {
                romanNumeral = "II";
            } else if (goal == 3)
            {
                romanNumeral = "III";
            } else if (goal == 4)
            {
                romanNumeral = "IV";
            } else if (goal == 5)
            {
                romanNumeral = "V";
            } else if (goal == 6)
            {
                romanNumeral = "VI";
            } else if (goal == 7)
            {
                romanNumeral = "VII";
            } else if (goal == 8)
            {
                romanNumeral = "VIII";
            } else if (goal == 9)
            {
                romanNumeral = "IX";
            } else if (goal == 10)
            {
                romanNumeral = "X";
            } else
            {
                romanNumeral = "BAD INPUT";
            }

            Console.WriteLine($"{goal} in roman numerals is {romanNumeral}");
        }

        public override void Problem2()
        {
            double pH = GetDouble("Please give me a PH value : ");
            string message = "";
            if(pH<0 || pH > 14)
            {
                message = "This pH is not in range. ";
            } else if ( 0 <= pH && pH < 7)
            {
                message = "This pH is acidic. ";
            } else if (7 <= pH && pH < 7.8)
            {
                message = "This pH is neutral. ";
            } else if (7 < pH && pH < 14)
            {
                message = "This pH is basic. ";
            } else
            {
                message = "ERROR BAD INPUT";
            }

            Console.WriteLine(message);

        }

        //ignoring "class" solution 
        //BMI MUST use kilograms and meters --> if statements to verify, converting if needed 
        public override void Problem3()
        {
            double height;
            double weight;
            double BMI;

            Console.Write("What unit will you input your weight? [E]nglish or [M]etric? ");
            string unit = Console.ReadLine();
            if(unit == "M")
            {
                weight = GetDouble("Give me your weight in KILOGRAMS ");
            } else if (unit == "E")
            {
                weight = LBtoKG(GetDouble("Give me your weight in POUNDS "));
            } else
            {
                Console.WriteLine("BAD INPUT. GOODBYE.");
                return;
            }

            Console.Write("What units will you input your height? [E]nglish or [M]etric? ");
             unit = Console.ReadLine();
            if (unit == "M")
            {
                height = GetDouble("Give me your height in METERS ");
            }
            else if (unit == "E")
            {
                Console.WriteLine("Give me your height in FEET and INCHES");
                double feet = GetDouble("FEET: ");
                double inches = GetDouble("INCHES: ");
                height = FItoM(feet, inches);
            }
            else
            {
                Console.WriteLine("BAD INPUT. GOODBYE.");
                return;
            }

            BMI = weight / Math.Pow(height, 2);

            string message = "";
            if(BMI < 18.5)
            {
                message = "Underweight";
            } else if ( 18.5<= BMI && BMI <25)
            {
                message = "Normal";
            }
            else if (25 <= BMI && BMI < 30)
            {
                message = "Overweight";
            } else if (30 <= BMI)
            {
                message = "Obese";
            } else
            {
                message = "BAD INPUT";
            }

            string output = $"A person {height:f1} m tall, weighing {weight:f1}kg has a BMI of {BMI:f1}. This is {message}.";
            Console.WriteLine(output);

        }
        //conversion methods 
        public double LBtoKG(double lb)
        {
            return lb * 0.453592;
        }
        public double FItoM(double f, double i)
        {
            double feet = f + (i / 12);
            return feet * 0.3048;
        }

        //ignore "object oriented" and "class" requests in prompt 
        public override void Problem4()
        {
            double retirement = 0.1;
            double fedTax = 0.18;
            double socialSec = 0.06;


            Console.Write("What is your first name ");
            string fName = Console.ReadLine();
            Console.Write("What is your last name ");
            string lName = Console.ReadLine();
            Console.Write("What is your clock code ");
            string clockCode = Console.ReadLine();
            Console.Write("Are you [H]ourly or [S]alary?");
            string payType = Console.ReadLine();

            double takeHome; //takehome pay for ONE WEEK
            double withholding; //amount witheld for ONE WEEK 
            double amount; //base pay for ONE WEEK

            if (payType == "H")
            {
                double payRate = GetDouble("What is your pay rate? ");
                double hours = GetDouble("How many hours did you work this week? ");
                if (hours <= 40)
                {
                    amount = (payRate * hours);
                    withholding =  amount * (retirement + fedTax + socialSec);
                    takeHome = amount - withholding; 
                } else {
                    amount = (payRate * 40) + ((hours - 40) * payRate * 1.5);
                    withholding = amount * (retirement + fedTax + socialSec);
                    takeHome = amount - withholding;
                }

            } else if (payType == "S")
            {
                 amount = GetDouble("Please enter your annual payRate : ") / 52; //annual salary rate divided by number of weeks in a year for a single week's base pay 
                withholding = amount * (retirement + fedTax + socialSec);
                takeHome = amount - withholding; 

            } else
            {
                Console.WriteLine("BAD INPUT. GOODBYE");
                return;
            }

            string output = $"\n{"Clock ID",10} : {"",9}Name{"",-9} : {"Base Pay",15} : {"Withholding", 15} : {"Takehome",15}\n" +
                $"{clockCode,10} : {lName,10}, {fName,-10} : {amount,15:c2} : {withholding,15:c2} : {takeHome,15:c2}\n";

            Console.Write(output);

        }

        public override void Problem5()
        {
            int numItems = GetInt("How many items are you shipping? ");
            int items = numItems;
            double price = 0;
            if (numItems == 1)
            {
                price += 2.99;

            } else if (2 <= numItems && numItems <= 5)
            {
                price += 2.99;
                numItems--;
                price += (numItems * 1.99);
            } else if (6 <= numItems && numItems < 15)
            {
                price += 2.99;
                numItems--;
                price += (4 * 1.99);
                numItems -= 4;
                price += (numItems * 1.49);
            }
            else if ( numItems >= 15)
            {
                price += 2.99;
                numItems--;
                price += (4 * 1.99);
                numItems -= 4;
                price += (10 * 1.49);
                numItems -= 10;
                price += (numItems * 0.99);
            }
            string output = $"{items} items will cost {price:c2} to ship ";
            Console.WriteLine(output);
        }


        public override void Problem6()
        {
            Console.WriteLine("What would you like to compute the area of? [C]ircle, [R]ectangle, c[Y]linder? ");
            string choice = Console.ReadLine();
            string output = "";
            if(choice == "C")
            {
                double rad = GetDouble("What is the radius? ");
                output = $"The area of a circle with radius {rad:f2} is {AreaCirc(rad):f2}";
                
            } else if (choice == "R")
            {
                double width = GetDouble("What is the width? ");
                double length = GetDouble("What is the length? ");
                output = $"The area of a rectangle with width {width:f2} and length {length:f2} is {AreaRect(length, width):f2}";

            } else if (choice == "Y")
            {
                double rad = GetDouble("What is the radius? ");
                double height = GetDouble("What is the height? ");
                output = $"The surface area of a cylinder with radius {rad:f2} and height {height:f2} is {SurfaceAreaCylinder(rad, height):f2}";

            } else
            {
                output = "BAD INPUT ";
            }

            Console.WriteLine(output);
        }
        public static double AreaCirc(double rad)
        {
            return Math.PI * Math.Pow(rad, 2);
        }
        public static double AreaRect(double len, double wid)
        {
            return len * wid; 
        }
        public static double Circumference(double rad)
        {
            return Math.PI * 2 * rad;
        }
        public static double SurfaceAreaCylinder(double rad, double height)
        {
            return (AreaCirc(rad) * 2) + AreaRect(Circumference(rad), height);
        }


        //no class here. nope. nada. see chapter 4 omnth example if you want to see this in class form 
        public override void Problem7()
        {
            int m = GetInt("Give me a month ", 1, 12);
            string monthName = "";
            switch (m)
            {
                case 1:
                    monthName = "January";
                    break;
                case 2:
                    monthName = "February";
                    break;
                case 3:
                    monthName = "March";
                    break;
                case 4:
                    monthName = "April";
                    break;
                case 5:
                    monthName = "May";
                    break;
                case 6:
                    monthName = "June";
                    break;
                case 7:
                    monthName = "July";
                    break;
                case 8:
                    monthName = "August";
                    break;
                case 9:
                    monthName = "September";
                    break;
                case 10:
                    monthName = "October";
                    break;
                case 11:
                    monthName = "November";
                    break;
                case 12:
                    monthName = "December";
                    break;
            }

            string output = $"Month number {m} is {monthName}";
            Console.WriteLine(output);

        }

        public override void Problem8()
        {
            throw new NotImplementedException();
        }

        public override void Problem9()
        {
            throw new NotImplementedException();

        }

        public override void Problem10()
        {
            throw new NotImplementedException();
        }

    }
}
