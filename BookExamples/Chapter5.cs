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
    //  - comparison operators 
    //  - logical operators 
    //  - variable scope 
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

            //create a series of if - else if conditional statements to try and exactly match the user input with it's corresponding output 
            //for larger numbers, this is ineffective but here it is sufficent 
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

            //print the resulting output string using string itnerpoation to format 
            Console.WriteLine($"{goal} in roman numerals is {romanNumeral}");
        }

        public override void Problem2()
        {
            double pH = GetDouble("Please give me a PH value : "); //retrive the ph value from the user 
            string message = ""; //create the message string that will act as our output 
            if(pH<0 || pH > 14) //is the pH is out of the acceptable range?
            {
                message = "This pH is not in range. "; //set message to appropriate message
            } else if ( 0 <= pH && pH < 7) //is the ph in the acidic range 
            {
                message = "This pH is acidic. ";//set message to appropriate message
            } else if (7 <= pH && pH < 7.8) //is the ph in the neutral range 
            {
                message = "This pH is neutral. ";//set message to appropriate message
            } else if (7 < pH && pH < 14) //is the ph in the basic range 
            {
                message = "This pH is basic. ";//set message to appropriate message
            } else //we sshould never arrive in this else 
            {
                message = "ERROR BAD INPUT";
            }

            Console.WriteLine(message); //print the message set by the if - else if blocks 

        }

        //ignoring "class" based solution 
        //BMI MUST use kilograms and meters --> if statements to verify, converting if needed 
        public override void Problem3()
        {
            //declare all required variable 
            double height;
            double weight;
            double BMI;

            //prompt user to enter weight units 
            Console.Write("What unit will you input your weight? [E]nglish or [M]etric? ");
            //read in weight units and store 
            string unit = Console.ReadLine();
            if(unit == "M") //if units are metric.... 
            {
                //get the weight as a metric value and store in the appropriate variable 
                weight = GetDouble("Give me your weight in KILOGRAMS ");
            } else if (unit == "E") //otherwise, if the units are english.... 
            {
                //get the weight in pounds, THEN convert and store in the appropriate variable 
                weight = LBtoKG(GetDouble("Give me your weight in POUNDS "));
            } else //otherwise 
            {
                Console.WriteLine("BAD INPUT. GOODBYE.");
                return; //premature return will end this method call 
            }

            //prompt user to enter height units 
            Console.Write("What units will you input your height? [E]nglish or [M]etric? ");
            //read in height units and store 
            unit = Console.ReadLine();
            if (unit == "M") //if units are metric.... 
            {
                //get the height as a metric value and store in the appropriate variable 
                height = GetDouble("Give me your height in METERS ");
            }
            else if (unit == "E") //otherwise, if the units are english... 
            {
                //get the height in feet and inches, THEN convert and store in the appropriate variable 
                Console.WriteLine("Give me your height in FEET and INCHES");
                double feet = GetDouble("FEET: ");
                double inches = GetDouble("INCHES: ");
                height = FItoM(feet, inches);
            }
            else //otherwise 
            {
                Console.WriteLine("BAD INPUT. GOODBYE.");
                return;//premature return will end this method call
            }

            //compute BMI based on formula 
            BMI = weight / Math.Pow(height, 2);

            string message = ""; //create message string for later use 
            if(BMI < 18.5) //test if BMI is under 
            {
                message = "Underweight"; //set appropriate message
            } else if ( 18.5<= BMI && BMI <25)//test if BMI is in normal range 
            {
                message = "Normal";//set appropriate message
            }
            else if (25 <= BMI && BMI < 30)//test if BMI is in over range 
            {
                message = "Overweight";//set appropriate message
            } else if (30 <= BMI) //test if BMI is in obese  
            {
                message = "Obese";//set appropriate message
            } else
            {
                message = "BAD INPUT";
            }

            //build output string using string interpolation, formatting, and spacing 
            string output = $"A person {height:f1} m tall, weighing {weight:f1}kg has a BMI of {BMI:f1}. This is {message}.";
            //print this output string to the console 
            Console.WriteLine(output);

        }
        //conversion methods 
        //method producing a conversion to kiliograms from pounds 
        public double LBtoKG(double lb)
        {
            return lb * 0.453592;
        }
        //method producing a conversion to meters from inches and feet 
        public double FItoM(double f, double i)
        {
            double feet = f + (i / 12);
            return feet * 0.3048;
        }

        //ignore "object oriented" and "class" requests in prompt 
        public override void Problem4()
        {
            //set  rates here 
            double retirement = 0.1;
            double fedTax = 0.18;
            double socialSec = 0.06;

            //read in personal information of employee 
            Console.Write("What is your first name ");
            string fName = Console.ReadLine();
            Console.Write("What is your last name ");
            string lName = Console.ReadLine();
            Console.Write("What is your clock code ");
            string clockCode = Console.ReadLine();

            //read in H, S, or other as payType of employee 
            Console.Write("Are you [H]ourly or [S]alary?");
            string payType = Console.ReadLine();

            //NOTE:
            //Why are these variables are created here?
            //these variables will be used in the final report of this code regardless of which control flow branch our program takes. because of this, we are concerned with the *scope* of the variables [aka where are the variables created, set, and able to be accessed] 
            double takeHome; //takehome pay for ONE WEEK
            double withholding; //amount witheld for ONE WEEK 
            double amount; //base pay for ONE WEEK

            if (payType == "H") //is the pay type hourly?
            {
                double payRate = GetDouble("What is your pay rate? "); //prompt user for pay rate 
                double hours = GetDouble("How many hours did you work this week? "); //prompt user for number of hours 
                if (hours <= 40) //is the number of hours worked less than 40? 
                {
                    //computation of take home at standard rate
                    amount = (payRate * hours);
                    withholding =  amount * (retirement + fedTax + socialSec);
                    takeHome = amount - withholding; 
                } else  //otherwise.... 
                {
                    //computation of take home with 1.5 pay rate for hours over 40
                    amount = (payRate * 40) + ((hours - 40) * payRate * 1.5);
                    withholding = amount * (retirement + fedTax + socialSec);
                    takeHome = amount - withholding;
                }

            } else if (payType == "S") //otherwise, is the pay type salaried? 
            {
                 amount = GetDouble("Please enter your annual payRate : ") / 52; //annual salary rate divided by number of weeks in a year for a single week's base pay 
                //computation of takehome pay 
                withholding = amount * (retirement + fedTax + socialSec);
                takeHome = amount - withholding; 

            } else //otherwise.... 
            {
                Console.WriteLine("BAD INPUT. GOODBYE");
                return;
            }

            //produce output string using stirng interpolation, spacing, and formatting 
            string output = $"\n{"Clock ID",10} : {"",9}Name{"",-9} : {"Base Pay",15} : {"Withholding", 15} : {"Takehome",15}\n" +
                $"{clockCode,10} : {lName,10}, {fName,-10} : {amount,15:c2} : {withholding,15:c2} : {takeHome,15:c2}\n";
            //print output string to console 
            Console.Write(output);

        }

        public override void Problem5()
        {
            int numItems = GetInt("How many items are you shipping? "); //prompt user for input 
            int items = numItems; //store number of items as another variable for manipulation 
            double price = 0;
            if (numItems == 1) //if the number of items is within the first price bracket 
            {
                price += 2.99;

            } else if (2 <= numItems && numItems <= 5)//otherwise if the number of items is within the second price bracket 
            {
                price += 2.99;
                numItems--;
                price += (numItems * 1.99);
            } else if (6 <= numItems && numItems < 15)//otherwise if the number of items is within the third price bracket 
            {
                price += 2.99;
                numItems--;
                price += (4 * 1.99);
                numItems -= 4;
                price += (numItems * 1.49);
            }
            else if ( numItems >= 15) //otherwise if the number of items is within the last price bracket 
            {
                price += 2.99;
                numItems--;
                price += (4 * 1.99);
                numItems -= 4;
                price += (10 * 1.49);
                numItems -= 10;
                price += (numItems * 0.99);
            }
            //build the output string using string interpolation, formatting, and spacing 
            string output = $"{items} items will cost {price:c2} to ship ";
            //print output string to console 
            Console.WriteLine(output);
        }


        public override void Problem6()
        {
            //prompt user for selection 
            Console.WriteLine("What would you like to compute the area of? [C]ircle, [R]ectangle, c[Y]linder? ");
            //read in and save selection as a avriable 
            string choice = Console.ReadLine();
            string output = ""; //create output string for later use
            if(choice == "C") //if the choice is C
            {
                double rad = GetDouble("What is the radius? "); //prompt the user for the radius 
                output = $"The area of a circle with radius {rad:f2} is {AreaCirc(rad):f2}"; //compute the area of a circle using the method below and directly plug in the solutuion to a string using string interpolation, formatting, and spacing 
                
            } else if (choice == "R")//otherwise if the choice is R
            {
                double width = GetDouble("What is the width? ");//prompt the user for the width 
                double length = GetDouble("What is the length? "); //prompt the user for the length
                output = $"The area of a rectangle with width {width:f2} and length {length:f2} is {AreaRect(length, width):f2}";//compute the area of a rectangle using the method below and directly plug in the solutuion to a string using string interpolation, formatting, and spacing 

            } else if (choice == "Y")//otherwise if the choice is Y
            {
                double rad = GetDouble("What is the radius? ");//prompt the user for the radius 
                double height = GetDouble("What is the height? ");//prompt the user for the height 
                output = $"The surface area of a cylinder with radius {rad:f2} and height {height:f2} is {SurfaceAreaCylinder(rad, height):f2}"; //compute the area of a cylinder using the method below and directly plug in the solutuion to a string using string interpolation, formatting, and spacing 

            } else// otherwise if the choice is ANYTHIGN else 
            {
                output = "BAD INPUT ";
            }

            //print the selected output string 
            Console.WriteLine(output);
        }
        //method for computing the area of a circle based on the radius 
        public static double AreaCirc(double rad)
        {
            return Math.PI * Math.Pow(rad, 2);
        }
        //method for computing the area of a rectangle based on the length and width  
        public static double AreaRect(double len, double wid)
        {
            return len * wid; 
        }
        //method for computing the circumference of a circle based on the radius 
        public static double Circumference(double rad)
        {
            return Math.PI * 2 * rad;
        }
        //method for computing the area of a cylinder based on the radius and height
        //makes use of the area circle, area rect, and circumference methods above 
        public static double SurfaceAreaCylinder(double rad, double height)
        {
            return (AreaCirc(rad) * 2) + AreaRect(Circumference(rad), height);
        }


        //no class here. nope. nada. see chapter 4 month example if you want to see this in class form 
        public override void Problem7()
        {
            //prompt user to enter month number
            int m = GetInt("Give me a month ", 1, 12);
            string monthName = "";
            //using a switch statement in place of a chain of if-else if statements 
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
