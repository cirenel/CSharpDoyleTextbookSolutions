//Claire Luikart
//june 2023
//solutions to Microsoft Visual C# 2017 An Introduction to Object-Oriented Programming by Joynce Farrell 7th ed
//each method contents can be directly placed in main method instead of their individualized methods here 
//these are each only one possible solution to the given prompts 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;



namespace BookExamples
{
    class Chapter5 : Chapter
    {
        


        public override void RunProblem(int num)
        {
            base.RunProblem(num);
        }


        public override void Problem1()
        {
            string inputInt = "";
            int sum = 0; 
            for(int i = 0; i < 5; i++)
            {
                Console.Write("Please give me an int: ");
                inputInt = Console.ReadLine();
                int value = int.Parse(inputInt);
                sum += value;
            }
            Console.WriteLine($"These numbers sum to: {sum}");
        }

         public override void Problem2()
        {
            Console.WriteLine("Enter 999 to stop running sum and see result. ");
            string inputInt = "";
            int sum = 0;
            int value = 0;
            while (value != 999)
            {
                Console.Write("Please give me an int: ");
                inputInt = Console.ReadLine();
                value = int.Parse(inputInt);
                if (value != 999)
                {
                    sum += value;
                }
            }
            Console.WriteLine($"These numbers sum to: {sum}");
        }

        public override void Problem3()
        {
            Console.WriteLine("Enter characters.Type ! to end.");

            char input ;

            do
            {
                Console.Write("Enter a character: ");
                input = Console.ReadKey().KeyChar;
                if(65 <= input && input <= 90)
                {
                    Console.WriteLine("OK");
                } else
                {
                    Console.WriteLine("Not an uppercase character.");
                }
            } while (input != '!');

            Console.WriteLine("Ending prompt.... ");

        }

        public override void Problem4()
        {
            Console.WriteLine("Enter a series of tempretures. Type STOP to end and display average.");
            string input = "";
            double sum = 0;
            int count = 0;
            double temp; 
            
            do
            {
                Console.Write("Give me a temp: ");
                input = Console.ReadLine();
                if(double.TryParse(input, out temp))
                {
                    if(-20 <= temp && temp <= 130)
                    {
                        count++;
                        sum += temp; 
                    } else
                    {
                        Console.WriteLine("Entered temp is outside of acceptable range: -20 - 130.");
                    }
                }

            } while (input != "STOP");
        }

        public override void Problem5()
        {
            throw new NotImplementedException();

        }

        public override void Problem6()
        {
            string output = "";
            for(int i = 1; i <= 10; i++)
            {

                for(int j = 1; j <=10; j++)
                {
                    output += $"{i*j,4} ";
                }
                output += "\n";
            }
            Console.WriteLine(output);

        }

        public override void Problem7()
        {
            int low, high;
            Console.WriteLine("Give me a low number: ");
            low = int.Parse(Console.ReadLine());
            Console.WriteLine("Give me a high number: ");
            high = int.Parse(Console.ReadLine());

            string output = "";
            for (int i = low; i <= high; i++)
            {

                for (int j = low; j <= high; j++)
                {
                    output += $"{i} X {j} = {i * j,4} ";
                }
                output += "\n";
            }
            Console.WriteLine(output);
        }

        public override void Problem8()
        {
            for(int a = 1; a < 100; a++)
            {
                if(a%2 == 1)
                {
                    Console.Write($"{a,3}");
                }
            }
        }

        public override void Problem9()
        {
            int sum = 0; 
            for(int m = 1; m <200; m++)
            {
                sum += m; 
                if(m == 100)
                {
                    Console.WriteLine($"1/2 marker: {sum}");
                }
            }
            Console.WriteLine("The sum is " + sum);
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
            //solution 1
            Console.WriteLine("Give me a phrase ");
            string input = Console.ReadLine();
            int count = 0;
            for(int n = 0; n < input.Length; n++)
            {
                if (input[n] == 'a' || input[n] == 'e' || input[n] == 'i' || input[n] == 'o' || input[n] == 'u' || input[n] == 'A' || input[n] == 'E' || input[n] == 'I' || input[n] == 'O' || input[n] == 'U')
                {
                    count++;
                }

            }
            Console.WriteLine($"'{input}' has {count} vowels.");


            //solution 2
            char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'A','E','I','O','U' };
            Console.WriteLine("Give me a phrase ");
            input = Console.ReadLine();
            count = 0;
            for (int n = 0; n < input.Length; n++)
            {
                foreach(char v in vowels)
                {
                    if (input[n] == v)
                    {
                        count++;
                        break;
                    }
                }
            }
            Console.WriteLine($"'{input}' has {count} vowels.");


        }
        public override void Problem14()
        {

            Random rand = new Random();
            int goal = rand.Next(1, 11);
            int guess;
            int numGuess = 0; 
            do
            {
                Console.Write("Guess a number: ");
                guess = int.Parse(Console.ReadLine());
                numGuess++;
                if (guess == goal)
                {
                    Console.WriteLine("You got it!!! ");
                }
                else if (guess < goal)
                {
                    Console.WriteLine("Your guess is too low.");
                }
                else if (guess > goal)
                {
                    Console.WriteLine("Your guess is too high.");
                }
                Console.WriteLine($"You have guessed {numGuess} times.");
            } while (guess != goal);
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
