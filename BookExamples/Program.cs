using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookExamples
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;

            
            do
            {
                Console.Title = $"Textbook Examples: C# Text by Barbra Doyle";

                //choose chapter and problem
                int chapter = GetInt("Please select the chapter. ", 1, 14);
                int problem = GetInt("Please select the problem. ", 1, 10);
                Console.Clear();

                Chapter c = null;
                //execute chapter and problem 
                switch (chapter)
                {
                    case 1:
                        c = new Chapter1();
                        break;
                    case 2:
                        c = new Chapter2();
                        break;
                    case 3:
                        c = new Chapter3();
                        break;
                    case 4:
                        c = new Chapter4();
                        break;
                    case 5:
                        c = new Chapter5();
                        break;
                    case 6:
                        c = new Chapter6();
                        break;
                    case 7:
                        c = new Chapter7();
                        break;
                    case 8:
                        c = new Chapter8();
                        break;
                    case 9:
                        c = new Chapter9();
                        break;
                    case 10:
                        c = new Chapter10();
                        break;
                    case 11:
                        c = new Chapter11();
                        break;
                    case 12:
                        c = new Chapter12();
                        break;
                    case 13:
                        c = new Chapter13();
                        break;
                    case 14:
                        c = new Chapter14();
                        break;
                    default:
                        throw new Exception("Error: Chapter not found!");

                }
                Console.Title = $"Executing {chapter}.{problem}.....";
                try
                {
                    Console.WriteLine($"Executing {chapter}.{problem}.....\n");
                    c.RunProblem(problem);
                } catch (NotImplementedException e)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine($"******************************\n**** {chapter}.{problem} not impelmented ****\n******************************");
                }

                //pause for user to see output
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\nPress any key to return to selection. ");
                Console.ReadKey();
                //clean up Console
                Console.Clear();

            } while (true);

        }


        

        public static int GetInt(string msg = "Please enter an int")
        {
            string input; 
            int ret;
            do
            {
                Console.Write(msg);
                input = Console.ReadLine();
            } while (!int.TryParse(input, out ret));

            return ret;
        }

        public static int GetInt(string msg = "Please enter an int", int lo = 0, int hi = 0)
        {
            int ret;
            bool parsed;
            string input; 
            do
            {
                Console.Write($"{msg} [Your input must be between {lo} and {hi}] : ");
                input = Console.ReadLine();
                parsed = int.TryParse(input, out ret);

            } while (!parsed || !(lo<=ret && ret <=hi));

            return ret;
        }
    }
}
