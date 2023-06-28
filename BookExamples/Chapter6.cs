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

        public override void Problem1()
        {
            int validCount = 0;
            int invalidCount = 0; 
            for(int i = 0; i < 10; i++) //COULD go to 100 but oof.
            {
                int val = GetInt("Give me a number... ");
                if(1 <= val && val <= 100)
                {
                    validCount++;
                } else
                {
                    invalidCount++;
                }
            }
            string output = $"You entered {validCount} valid values and {invalidCount} invalid values";
            Console.WriteLine(output);
        }

        public override void Problem2()
        {
            double price = GetDouble("Enter the wholesale price please ");
            Console.WriteLine($"\nBase price: {price:c2}");
            Console.WriteLine($"{"%",5} : {"price",10}");
            for(double markup = 0.05; markup <= 0.20; markup += 0.01)
            {
                double markedUpPrice = price * (1 + markup);
                Console.WriteLine($"{markup,5:p0} : {markedUpPrice,10:c2}");
            }
        }

        public override void Problem3()
        {
            Random r = new Random();
            int hi = 100000;
            int lo = 0;

            int lowest = int.MaxValue;
            int highest = int.MinValue;
            int oddCount = 0; 


            double sum = 0; 
            for(int i = 0; i < 1000; i++)
            {
                int randomNum = r.Next(lo, hi + 1); //that +1 is important: read the doc
                if(randomNum > highest)
                {
                    highest = randomNum;
                }
                if (randomNum < lowest)
                {
                    lowest = randomNum;
                }
                if(randomNum % 2 == 1)
                {
                    oddCount++;
                }

                sum = sum + randomNum; 
            }
            double avg = sum / 1000.0;
            string output = $"I drew 1000 numbers between {lo} and {hi}\n" +
                              $"\ttheir avg is: {avg}\n" +
                              $"\tthe lowest was: {lowest}\n" +
                              $"\tthe highest was: {highest}\n" +
                              $"\tthere were {oddCount} odd numbers\n";
            Console.WriteLine(output);

        }

        public override void Problem4()
        {
            Console.WriteLine("Please enter grades. Enter AVG to average the grades and exit.");
            double sum = 0;
            bool parsed;
            double grade;
            int numGrades = 0; 
            string input = "";

            while (input != "AVG")
            {
                do
                {
                    Console.Write("Enter a grade : ");
                    input = Console.ReadLine();
                    parsed = double.TryParse(input, out grade);
                } while (!parsed && input != "AVG");
                if (input != "AVG")
                {
                    numGrades++;
                    sum += grade;
                }
            }

            double avg = sum / numGrades;
            char letterGrade; 
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

            string output = $"The final GPA is a {avg} {letterGrade}";
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
            string input;
            bool parsed;
            int lo;
            int hi; 

            do
            {
                Console.Write("Enter a lower boundary : ");
                input = Console.ReadLine();
                parsed = int.TryParse(input, out lo);
            } while (!parsed);

            do
            {
                Console.Write($"Enter an upper boundary (greater than {lo}) : ");
                input = Console.ReadLine();
                parsed = int.TryParse(input, out hi);
            } while (!parsed && lo > hi);

            string output = $"The times table for {lo} X {hi} : \n";
            for(int row = lo; row <= hi; row++)
            {
                string rowStr = "";
                for(int col = lo; col <= hi; col++)
                {
                    int product = (row * col); 
                    rowStr += $"{product,5}";
                }
                rowStr += "\n";
                output += rowStr;
            }
            Console.WriteLine(output);

        }

        public override void Problem8()
        {
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
