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
    //CHAPTER 6 NOTES
    // chapter 6 is all about 
    // Topics of focus:
    //  - repeating code
    //  - pretest v. posttest 
    //  - for 
    //  - while
    //  - do-while 
    //  - continue and break in loops 
    //  - scope of variable creation and use with loops 
    //  - try parse methods in conjunction with loops
    //          [see the getint and getdouble methods within chapter.cs]
    // not in text but reccomended: 
    //  - 

    //Note: in past, this section was covered BEFORE chapters 3 and 4 [methods and classes]
    //thus, most of the solutions here do NOT use classes as they say to in the prompt
    //i do not know why the text chose this order but condtions and control flow are better
    //and easier to see the impact off to n00bs if we pull them FIRST 

    //Chapter 6 is covered in IT150

    class Chapter6 : Chapter
    {

        public override void RunProblem(int num)
        {
            base.RunProblem(num);
        }

        //this problem prompt in the text is frankly dumb and confusing so i have modified it some 
        public override void Problem1()
        {
            int validCount = 0; //creation of counter for valid entries 
            int invalidCount = 0; //creation of counter for invalid entries 
            for(int i = 0; i < 10; i++) //COULD go to 100 but oof. --> repeat body of loop 10 times 
            {
                int val = GetInt("Give me a number... "); //prompt user for a number 
                if(1 <= val && val <= 100) //is the number in the 1-100 range? 
                {
                    validCount++; //if so, add to valid counter 
                } else //otehrwise, 
                {
                    invalidCount++; //add to invalid counter 
                }
            }
            //build output string using string interpolation 
            string output = $"You entered {validCount} valid values and {invalidCount} invalid values";
            //print output string to console 
            Console.WriteLine(output);
        }

        public override void Problem2()
        {
            double price = GetDouble("Enter the wholesale price please "); //prompt for price 

            Console.WriteLine($"\nBase price: {price:c2}"); //display price 
            Console.WriteLine($"{"%",5} : {"price",10}"); //display col headers 

            //for all of our possible markups: 0.05 --> 0.2
            //the noteworthy thing here: for loops are *not* locked to only work with integers and single increment/decrement 
            for(double markup = 0.05; markup <= 0.20; markup += 0.01)
            {
                double markedUpPrice = price * (1 + markup); //compute markup at this precentage 
                Console.WriteLine($"{markup,5:p0} : {markedUpPrice,10:c2}"); //write this markup at this percentage using string interpolation to ensure tabluar format 
            }
        }

        public override void Problem3()
        {
            Random r = new Random(); //create randomizer object 
            int hi = 100000; //set high value 
            int lo = 0; //set low value 

            int lowest = int.MaxValue; //lowest value starting value 
            int highest = int.MinValue; //highest value staritng value 
            //BUT: why is the lowest set to max and the higehst set to min? --> so we can try to ensure that lowest and highest WILL in fact change  
            int oddCount = 0;  //initiate the odd counter to 0 
            double sum = 0; //initiat the sum 
 
            for(int i = 0; i < 1000; i++) //create a loop tht will repeat 100 times 
            {
                int randomNum = r.Next(lo, hi + 1); //that +1 is important: read the documentation --> the high value in this method is non-inclusive of the range 
                if(randomNum > highest) //is this new number higher than the highest number we have seen so far? 
                {
                    highest = randomNum; //if so, it is our new highest number 
                }
                if (randomNum < lowest)//is this new number lower than the lowest number we have seen so far? 
                {
                    lowest = randomNum;//if so, it is our new lowest number 
                }
                if(randomNum % 2 == 1) //does this number divided by 2 leave a remainder? [is this number divisible by 2? ]
                {
                    oddCount++; //if so it is odd and we need to increase our counter 
                }

                sum = sum + randomNum;  //add this new number to our running sum
            }
            //AFTER the loop complete, compute the average 
            double avg = sum / 1000.0;

            //build our output string using string interpolation, formatting and spacing 
            string output = $"I drew 1000 numbers between {lo} and {hi}\n" +
                              $"\ttheir avg is: {avg}\n" +
                              $"\tthe lowest was: {lowest}\n" +
                              $"\tthe highest was: {highest}\n" +
                              $"\tthere were {oddCount} odd numbers\n";
            //print the output string to the console 
            Console.WriteLine(output);

        }

        public override void Problem4()
        {
            Console.WriteLine("Please enter grades. Enter AVG to average the grades and exit."); //inform user as to HOW this program will work and what it expects from them 
            double sum = 0; //initilize sum variable 
            bool parsed; //set up parsed variable 
            double grade; //set up grade variable 
            int numGrades = 0;  //create number of grades input counter 
            string input = "";

            while (input != "AVG")
            {
                do
                {
                    Console.Write("Enter a grade : "); //prompt user for  grade 
                    input = Console.ReadLine(); //read in this input 
                    parsed = double.TryParse(input, out grade); //try to parse this input. if sucessful, save the input numeric parse into the grade variable 
                } while (!parsed && input != "AVG"); //repeat this loop until there is a sucessful parse and the input is NOT avg
                if (input != "AVG")
                {
                    numGrades++; //increase counter 
                    sum += grade; //add grade to the running sum 
                }
            }

            double avg = sum / numGrades; //compute the avgerage from the running sum and the count of grades 
            char letterGrade; //create a variable to store the letter grade in 
            //using an if-else if chain, determine what the letter grade character should be set to 
            if(avg >= 90)
            {
                letterGrade = 'A';
            } else if ( 80<= avg && avg < 90)
            {
                letterGrade = 'B';
            }
            else if (70 <= avg && avg < 80)
            {
                letterGrade = 'C';
            }
            else if (60 <= avg && avg < 70)
            {
                letterGrade = 'D';
            }
            else
            {
                letterGrade = 'F';
            }

            //using string interpolation, create the output string 
            string output = $"The final GPA is a {avg} {letterGrade}";
            //print the output string to the console 
            Console.WriteLine(output);
        }

        public override void Problem5()
        {
            throw new NotImplementedException();
        }

        public override void Problem6()
        {
            throw new NotImplementedException();
        }

        public override void Problem7()
        {
            //variable declaration --->
            //why before? we need to make this variables before for the sake of scope.
            //if we try to create them IN the loops, they will only exist IN the loops 
            string input;
            bool parsed;
            int lo;
            int hi; 

            do
            {
                Console.Write("Enter a lower boundary : "); //prompt user for input 
                input = Console.ReadLine(); //read input in 
                parsed = int.TryParse(input, out lo); //try to parse input into lo  var 
            } while (!parsed); //repeat if the input was unparsable 

            do
            {
                Console.Write($"Enter an upper boundary (greater than {lo}) : ");//prompt user for input 
                input = Console.ReadLine();//read input in 
                parsed = int.TryParse(input, out hi);//try to parse input into hi  var 
            } while (!parsed && lo > hi);//repeat if the input was unparsable  OR in conflict with the lower boundary 

            string output = $"The times table for {lo} X {hi} : \n"; //begin building output string 
            for(int row = lo; row <= hi; row++) //rows will run from low --> hi
            {
                string rowStr = ""; //create a string for asingle row 
                for(int col = lo; col <= hi; col++) //cols will run from low --> hi
                {
                    int product = (row * col); //compute the product of the 'cell' we are at 
                    rowStr += $"{product,5}"; //add this to the row string using string interpolation to keep tabular formatting 
                } 
                //at the end of a row of cols, add a newline to the row 
                rowStr += "\n";
                output += rowStr; //add the row string to the output string 
            }
            //print the output to the console 
            Console.WriteLine(output);

        }

        public override void Problem8()
        {
            //prompt explaining user what to expect from the program 
            Console.WriteLine("Let's make some triangles!\nEnter the 3 sides of a triangle. The code will repeat until you type EXIT");

            
            string input= ""; 
            
            while (input != "EXIT")
            {
                double side1 = -1, side2 = -1, side3 = -1;
                bool parsed;
                int numSides = 0;
                do
                {
                    Console.Write($"What is the length of side {numSides + 1}? ");
                    input = Console.ReadLine();

                    if (numSides == 0)
                    {
                        parsed = double.TryParse(input, out side1);
                    }
                    else if (numSides == 1)
                    {
                        parsed = double.TryParse(input, out side2);
                    }
                    else if (numSides == 2)
                    {
                        parsed = double.TryParse(input, out side3);
                    }
                    else
                    {
                        parsed = false;
                        continue;
                    }
                    if (parsed)
                    {
                        numSides++;
                    }
                } while (numSides < 3 || !parsed && input != "EXIT");

                if (side1 + side2 > side3 && side2 + side3 > side1 && side3 + side1 > side2)
                {
                    Console.WriteLine($"{side1}, {side2}, and {side3} can make a triangle.");
                }
                else
                {
                    Console.WriteLine("These cannot make a triangle. ");
                }
                Console.Write("Another triangle or EXIT? ---> ");
                input = Console.ReadLine();
            }
        }

        public override void Problem9()
        {
            Console.Write("Give me a single symbol to print: ");
            char single = Console.ReadLine()[0];
            int rep = 0;
            bool parsed; 
            do
            {
                Console.Write("give me a number between 1 and 20. ");
                parsed = int.TryParse(Console.ReadLine(), out rep);
            } while (!parsed || (rep <=0 || rep>20));

            Console.WriteLine();

            for(int i = 0; i < rep; i++)
            {
                for(int j = 0; j <= i; j++)
                {
                    Console.Write(single);
                }
                Console.WriteLine();
            }
            for (int i = rep; i>=0; i--)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(single);
                }
                Console.WriteLine();
            }

        }

        public override void Problem10()
        {
            throw new NotImplementedException();
        }

    }
}
