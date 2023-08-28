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

//CHAPTER 1 NOTES
// chapter 1 is all about getting the students comfortable writing code,
// getting input from the user, and giving the user output
// Topics of focus:
//  - Write v. WriteLine
//  - string basics and escape characters 
//  - console coloring 
//  - console clearing 
// not in text but reccomended: 
//  - introduction of the $"{var name}" for string interpolation 

//Chapter 1 is covered in IT150

namespace BookExamples
{
    class Chapter1 : Chapter
    {
        public override void RunProblem(int num)
        {
            base.RunProblem(num);
        }


        public override void Problem1()
        {
            //set console colors as described in the text 
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;

            //ask user for their name 
            Console.WriteLine("What is your name? ");
            string input = Console.ReadLine();

            //print message with custom input 
            Console.WriteLine($"Hello World! This is {input}");

        }

         public override void Problem2()
        {   
            //ask user for their name 
            Console.WriteLine("What is your name? ");
            string name = Console.ReadLine();

            //ask user for the date
            Console.WriteLine("What is the date? ");
            string date = Console.ReadLine();

            //ask user for the assignment 
            Console.WriteLine("What is the assignment? ");
            string assignment = Console.ReadLine();

            //build final string based on these inputs and using string interpolation and formatting 
            string combined = $"********************************************\n" +
                              $"** Name: {name, -32} **\n" +
                              $"** Date: {date, -32} **\n" +
                              $"** Task: {assignment, -32} **\n" + 
                              $"********************************************\n";

            Console.WriteLine(combined);
        }

        public override void Problem3()
        {
            //printing the required shape using individual writelines 
            Console.WriteLine("##                                   ##");
            Console.WriteLine("  ##                               ##");
            Console.WriteLine("    ##                           ##"); 
            Console.WriteLine("      ##                       ##");
            Console.WriteLine("        ##                   ##");
            Console.WriteLine("          ##               ##");
            Console.WriteLine("            ##           ##");
            Console.WriteLine("              ##       ##");
            Console.WriteLine("                ##   ##");
            Console.WriteLine("                  ###");
            Console.WriteLine("                ##   ##");
            Console.WriteLine("              ##       ##");
            Console.WriteLine("            ##           ##");
            Console.WriteLine("          ##               ##");
            Console.WriteLine("        ##                   ##");
            Console.WriteLine("      ##                       ##");
            Console.WriteLine("    ##                           ##");
            Console.WriteLine("  ##                               ##");
            Console.WriteLine("##                                   ##");

        }

        public override void Problem4()
        {
            //printing the required shape by creating a single string 
            string output = $" CCCCCCCCC                  ##      ##     \n" +
                            $" CCCCCCCCC                 ##      ##      \n" +
                            $" CC                    ################    \n" +
                            $" CC                       ##      ##       \n" +
                            $" CC                      ##      ##        \n" +
                            $" CC                  ################      \n" +
                            $" CCCCCCCCC             ##      ##          \n" +
                            $" CCCCCCCCC            ##      ##           \n" ;
            //then printing out the string in a single writeline 
            Console.WriteLine(output);
        }

        public override void Problem5()
        {
            //set console colors as described in the text 
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            //printing the required shape by creating a single string 
            string american = "_____________________________________________________________________\n" +
                              "* * * * * * * * * *  ________________________________________________\n" +
                              " * * * * * * * * * * ________________________________________________\n" +
                              "* * * * * * * * * *  ________________________________________________\n" +
                              " * * * * * * * * * * ________________________________________________\n" +
                              "* * * * * * * * * *  ________________________________________________\n" +
                              "_____________________________________________________________________\n" +
                              "_____________________________________________________________________\n" +
                              "_____________________________________________________________________\n" +
                              "_____________________________________________________________________\n" +
                              "_____________________________________________________________________\n" +
                              "_____________________________________________________________________\n" +
                              "_____________________________________________________________________\n" +
                              "_____________________________________________________________________\n";
            //then printing out the string in a single writeline 
            Console.WriteLine(american);

            
        }

        public override void Problem6()
        {
            //creating a series of strings using the litnary against fear from dune 
            //these strings will be our sayings in the code 
            string s1 = "I must not fear.";
            string s2 = "Fear is the mind - killer.";
            string s3 = "Fear is the little - death that brings total obliteration.";
            string s4 = "I will face my fear.";

            //output one is all write
            Console.WriteLine("\nOutput #1 : ");
            Console.Write(s1);
            Console.Write(s2);
            Console.Write(s3);
            Console.Write(s4);

            //outut2 is a single writeline where the strings are concatenated togetehr 
            Console.WriteLine("\nOutput #2 : ");
            Console.WriteLine(s1 + " " + s2 + " " + s3 + " " + s4);

            //output 3 using only writelines 
            Console.WriteLine("\nOutput #3 : ");
            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.WriteLine(s3);
            Console.WriteLine(s4);

            //output 4  uses a single writeline where the strigns are concatenated together using newline escape characters 
            Console.WriteLine("\nOutput #4 : ");
            Console.WriteLine(s1 + "\n" + s2 + "\n" + s3 + "\n" + s4);

            //output 5 uses string interpolation to achive the sae as output 4
            Console.WriteLine("\nOutput #5 : ");
            Console.WriteLine($"{s1}\n{s2}\n{s3}\n{s4}");


        }

        public override void Problem7()
        {
            throw new NotImplementedException();
        }

        public override void Problem8()
        {
            //we create a dude using string concatenation and the newline escape character 
            string dude = "   0   \n" +
                          "  /M\\  \n" +
                          "   H   \n" +
                          "  / \\   ";
            Console.WriteLine(dude);
        }

        public override void Problem9()
        {
            //set console colors as described in the text 
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;

            //we create a single string holding the three shapes and the newline escape characters 
            string shapes = "      **********              *                     *          \n" +
                            "      **********             ***                   ***         \n" +
                            "      **********            *****                 *****        \n" +
                            "      **********           *******               *******       \n" +
                            "      **********          *********             *********      \n" +
                            "      **********         ***********            *********      \n" +
                            "      **********        *************            *******       \n" +
                            "      **********       ***************            *****        \n" +
                            "      **********      *****************            ***         \n" +
                            "      **********     *******************            *          \n" +
                            "";

            Console.WriteLine(shapes);
        }

        public override void Problem10()
        {
            
            string output = "                                               \n" +
                            "   IIIIIIIIII     TTTTTTTTTT      IIIIIIIIII   \n" +
                            "   IIIIIIIIII     TTTTTTTTTT      IIIIIIIIII   \n" +
                            "       II             TT              II       \n" +
                            "       II             TT              II       \n" +
                            "       II             TT              II       \n" +
                            "       II             TT              II       \n" +
                            "       II             TT              II       \n" +
                            "       II             TT              II       \n" +
                            "       II             TT              II       \n" +
                            "       II             TT              II       \n" +
                            "   IIIIIIIIII         TT          IIIIIIIIII   \n" +
                            "   IIIIIIIIII         TT          IIIIIIIIII   \n" +
                            "                                               \n"
                            ;

            //set console colors as described in the text 
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine(output);
        }
    }
}
