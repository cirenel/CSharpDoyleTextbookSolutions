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
    class Chapter6 : Chapter
    {
        Random random = new Random();


        public override void RunProblem(int num)
        {
            base.RunProblem(num);
        }


        public override void Problem1()
        {
            int[] nums = new int[] { random.Next(1, 101), random.Next(1, 101), random.Next(1, 101), random.Next(1, 101), random.Next(1, 101), random.Next(1, 101), random.Next(1, 101), random.Next(1, 101), random.Next(1, 101), random.Next(1, 101) };
            Console.WriteLine("Array Generated.... ");
            int choice;
            string message = "Select what to do with the array:\n" +
                             "[1] view array forward\n" +
                             "[2] view array backward\n" +
                             "[3] select and view element of array\n" +
                             "[4] EXIT";
            string input = "";
            do
            {
                Console.WriteLine(message);
                input = Console.ReadLine();
                if(int.TryParse(input, out choice))
                {
                    if(choice == 1)
                    {
                        Console.WriteLine("\nPrint index ascending: ");
                        for( int k = 0; k < nums.Length; k++)
                        {
                            Console.WriteLine(k+" : "+nums[k]);
                        }
                    } else if (choice == 2)
                    {
                        Console.WriteLine("\nPrint index descending: ");
                        for (int k = nums.Length-1; k >=0; k--)
                        {
                            Console.WriteLine(k + " : " + nums[k]);
                        }
                    } else if (choice == 3)
                    {
                        Console.Write("\nWhat index do you want to view: ");
                        input = Console.ReadLine();
                        if (int.TryParse(input, out choice))
                        {
                            if(choice < 0 || choice > nums.Length)
                            {
                                Console.WriteLine("\nThis index is out of range.\n");
                            } else
                            {
                                Console.WriteLine($"\nIndex {choice} : {nums[choice]}\n");
                            }
                        } else
                        {
                            Console.WriteLine("\nNumber required. try again.\n");
                        }
                    } else if (choice == 4)
                    {
                        input = "EXIT";
                    }
                    else
                    {
                        Console.WriteLine("\nInvalid Choice. Reselect.\n");
                    }

                } else
                {
                    Console.WriteLine("\nInvalid Choice. Type a *number*.\n");
                }
            } while (input!="EXIT");

        }

         public override void Problem2()
        {
            double[] scores = new double[8];
            double sum = 0; 

            for(int i = 0; i < scores.Length; i++)
            {
                Console.Write("Give me a score: ");
                scores[i] = double.Parse(Console.ReadLine());
                sum += scores[i]; 
            }
            double avg = sum / scores.Length;

            string output = $"\nAverage score: {avg:f3}\n";
            output += $"{"score",8} : {"variance",-8}\n";
            foreach (double score in scores)
            {
                output += $"{score, 8:f1} : {score-avg, 5:f1}\n";
            }
            Console.WriteLine(output)
;
        }

        public override void Problem3()
        {
            throw new NotImplementedException();

        }

        public override void Problem4()
        {
            string[] zipCodes = new string[] {"70808", "70809", "70769", "70806", "70810", "70817",
                                              "70836", "70780", "70726", "70819", "70801", "70802"};
            Console.WriteLine("Enter a zip code to check if it is shippable. ");
            string input = Console.ReadLine();

            bool found = false; 
            foreach(string s in zipCodes)
            {
                if(s == input)
                {
                    found = true; 
                }
            }

            if (found)
            {
                Console.WriteLine($"{input} is in our shipping range!");
            } else
            {
                Console.WriteLine("We cannot ship there. sorry");
            }

        }

        public override void Problem5()
        {
            string[] zipCodes = new string[] {"70808", "70809", "70769", "70806", "70810", "70817",
                                              "70836", "70780", "70726", "70819", "70801", "70802"};
            double[] prices = new double[] {10.4, 2.32, 43.2, 10,3.33, 4.32,
                                             8.65, 10.3, 4.35, 32.3, 5.33, 1.20};
            Console.WriteLine("Enter a zip code to check if it is shippable. ");
            string input = Console.ReadLine();

            bool found = false;
            for(int p = 0; p < zipCodes.Length; p++)
            {
                string s = zipCodes[p];
                if (s == input)
                {
                    found = true;
                    Console.WriteLine($"{input} is in our shipping range!\n It will be {prices[p]:c2}.");
                }
            }

            if (!found)
            {
                Console.WriteLine("We cannot ship there. sorry");
            }

        }

        public override void Problem6()
        {
            string[] areaCodes = new string[] { "262", "414", "608", "715","815","920" };
            double[] rates = new double[] { .07, .1, .05, .16, .24, .14};

            Console.WriteLine("How many minutes was the call? ");
            int min = int.Parse(Console.ReadLine());
            Console.WriteLine("To which area code was the call ");
            string areaCode = Console.ReadLine();

            double result = 0; 
            for(int b = 0;  b< areaCodes.Length; b++)
            {
                if (areaCodes[b] == areaCode)
                {
                    result = min * rates[b];
                }
            }
            string msg = $"Your {min} minute call to area code {areaCode} will be billed {result:c2}";
            Console.WriteLine(msg);
        }

        public override void Problem7()
        {
            Console.Write("How many words per minute does the studnet type? ");
            int numWords = int.Parse(Console.ReadLine());
            if(numWords <= 15)
            {
                Console.WriteLine("This is an F");
            } else if (numWords <= 30)
            {
                Console.WriteLine("This is a D");
            }
            else if (numWords <= 50)
            {
                Console.WriteLine("This is a C");
            }
            else if (numWords <= 75)
            {
                Console.WriteLine("This is a B");
            }
            else
            {
                Console.WriteLine("This is an A");
            }
        }

        public override void Problem8()
        {
            int[] rates = new int[] { 200, 200, 180, 180, 160, 160, 160, 145 };
            Console.WriteLine("How many nights will you be staying? ");
            int numDays = int.Parse(Console.ReadLine());
            int rate = 0; 
            int price = 0; 
            if(numDays <= 8 && numDays >= 0)
            {
                rate = rates[numDays - 1];
                price = numDays * rate;
                
            } else if (numDays > 8)
            {
                rate = rates[rates.Length - 1];
                price = numDays * rate;
            }
            Console.WriteLine($"The total price of {numDays} at {rate:c0} per night will be {price:c0}");
        }

        public override void Problem9()
        {
            throw new NotImplementedException();
        }

        public override void Problem10()
        {

            throw new NotImplementedException();
        }

        public override void Problem11()
        {

            throw new NotImplementedException();
        }
        public override void Problem12()
        {

            throw new NotImplementedException();
        }
        public override void Problem13()
        {

            throw new NotImplementedException();
        }
        public override void Problem14()
        {

            throw new NotImplementedException();
        }
        public override void Problem15()
        {

            throw new NotImplementedException();
        }
        public override void Problem16()
        {

            throw new NotImplementedException();
        }
        public override void Problem17()
        {

            throw new NotImplementedException();
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
