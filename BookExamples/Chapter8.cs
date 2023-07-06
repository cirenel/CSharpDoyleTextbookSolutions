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
    //CHAPTER 8 NOTES
    // chapter 8 is all about 
    // Topics of focus:
    //  - multi dimensional array creation, access, use 
    //  - collections : 
    //          - 
    // not in text but reccomended: 
    //  - 


    //Chapter 8 is covered in IT150, IT151, and IT152

    class Chapter8 : Chapter
    {
        Random r = new Random();
        public override void RunProblem(int num)
        {
            base.RunProblem(num);
        }

        public override void Problem1()
        {
            
            //prompt and read in number of rows and cols
            int row = GetInt("how many rows? "); 
            int col = GetInt("how many cols? ");

            //create 2D array using this information 
            int[,] values = new int[row, col];

            //generate 2D array 
            for(int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    values[i, j] = r.Next(0, 101); //pull random number 
                }
            }

            //print 2D array 
            Console.WriteLine("This is the array in 2D: ");
            for (int i = 0; i < row; i++)
            {
                string v = ""; //v is a single row
                for (int j = 0; j < col; j++)
                {
                    v += $"{values[i, j],5}" ; //add to this row using string interpolation 
                }
                Console.WriteLine(v); //at the end of a single row, print the row
            }
            Console.WriteLine();

            //convert to 1D
            int[] flat = new int[row*col]; //init blank array with enough spaces for all of the 2D values
            int count = 0; 
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    flat[count] = values[i, j];
                    count++;
                }
            }

            //print 1D
            Console.WriteLine("\nThis is the array in 1D: ");
            string str = "";
            for(int k = 0; k < flat.Length; k++)
            {
                str += $"{flat[k],5}";
            }
            Console.WriteLine(str);

        }

        public override void Problem2()
        {
            throw new NotImplementedException();
        }

        public override void Problem3()
        {
            throw new NotImplementedException();


        }

        public override void Problem4()
        {
            throw new NotImplementedException();

        }

        public override void Problem5()
        {
            throw new NotImplementedException();
        }

        public override void Problem6()
        {
            //prompt and read in number of rows and cols
            int row = GetInt("how many rows? ");
            int col = GetInt("how many cols? ");

            int[,] values = new int[row, col];

            //generate 2D array and find hi and lo
            int hi = int.MinValue;
            int lo = int.MaxValue;
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    values[i, j] = r.Next(-100, 101); //generate random number and store 
                    //determin if is new hi
                    if(values[i, j] > hi)
                    {
                        hi = values[i, j]; 
                    }
                    //determin if is new lo
                    if (values[i, j] < lo)
                    {
                        lo = values[i, j]; 
                    }
                }
            }

            //print 2D array 
            Console.WriteLine("This is the array in 2D: ");
            for (int i = 0; i < row; i++)
            {
                string v = "";
                for (int j = 0; j < col; j++)
                {
                    v += $"{values[i, j],5}";
                }
                Console.WriteLine(v);
            }
            Console.WriteLine($"The highest value:{hi,5}\nThe lowest  value:{lo,5}");
            Console.WriteLine();
        }

        public override void Problem7()
        {
            int[,] nums = new int[10, 2];

            //build array 
            for(int t = 0; t < nums.GetLength(0); t++)
            {
                nums[t,0] = r.Next(0,101); //generate number 
                nums[t, 1] = (int)Math.Pow(nums[t, 0], 2); //raise this number to a power and store 
            }

            //build display string 
            string display = $"{"Number",8} : {"Squared",-8}\n"; //col headers 
            for(int t = 0; t < nums.GetLength(0); t++)
            {
                display += $"{nums[t, 0],8} : {nums[t,1],-8}\n"; //add single row 
            }
            //print to screen 
            Console.Write(display);

        }

        public override void Problem8()
        {
            Console.WriteLine("Give me a phrase to convert to pig latin: "); //prompt for input 
            string input = Console.ReadLine(); //read input and save as a var 

            //split the input string on the spaces. will result in an array 
            string[] words = input.Split(' '); 
            //create output string 
            string output = "";
            foreach(string word in words) //for each string in the array of strings 
            {
                if (word.Length > 1)
                {
                    output += word.Substring(1) + word[0] + "ay "; //take the second part of the word, add the first character of the word, then the phrase ay to the output string 
                }
                else
                {
                    output += word+"ay ";
                }
            }

            //display the output string 
            Console.WriteLine(output);
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
