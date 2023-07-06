//Claire Luikart
//june 2023
//solutions to C# Programing From Problem Analysis to Program Design 5th Ed by Barbara Doyle 
//each method contents can be directly placed in main method instead of their individualized methods here 
//these are each only one possible solution to the given prompts 

using System;
using System.IO;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookExamples
{
    //CHAPTER 13 NOTES
    // chapter 13 is all about 
    // Topics of focus:
    //  - file writing
    //  - file reading
    //  - stream writing and reading
    //  - append v. overwrite 
    //  - importance of flush 
    //  - relative v. absolute file paths 

    // not in text but reccomended: 
    //  - seralization and deseralization via JSON [see https://learn.microsoft.com/en-us/dotnet/standard/serialization/system-text-json/how-to?pivots=dotnet-8-0 ]

    //Chapter 13 is covered in IT151, and IT152

    class Chapter13 : Chapter
    {

        public override void RunProblem(int num)
        {
            base.RunProblem(num);
        }

        //this is a utility method for when we need to create a file quickly to use 
        private void createLocalFile(string filePath = "file.txt")
        {
            Random r = new Random();
            string s = "";
            int num = r.Next(10, 1001);
            for( int i = 0; i < num; i++)
            {
                s += r.Next(0, 101) + "\n";
            }
            File.WriteAllText(filePath, s);

        }

        public override void Problem1()
        {
            throw new NotImplementedException();
        }

        public override void Problem2()
        { 
            createLocalFile();
            //declare and initilize sum, count, min, max, and the string to store individual lines from the file  
            double sum = 0;
            int count = 0;
            double max = double.MinValue;
            double min = double.MaxValue;
            string s = "";

            //create the streamreader 
            using (StreamReader sr = new StreamReader("file.txt"))
            {
                while ((s = sr.ReadLine()) != null) //while reading in a file does not result in null
                {
                    double num = double.Parse(s); //parse the line
                    sum += num; //add it to the sum
                    //change min and max if needed 
                    max = Math.Max(num, max);
                    min = Math.Min(num, min);
                    //increase the count of numbers we have read in 
                    count++;
                }
            }
            //using string interpolation, spacing, adn formatting, print the resulting stats to the console 
            Console.WriteLine($"{count} numbers read.\nAvg: {sum / count}\nMin:{min}\nMax:{max}");
        }

        public override void Problem3()
        {
            throw new NotImplementedException();


        }

        public override void Problem4()
        {
            Random r = new Random(); //create randomizer 
            StreamWriter sw = new StreamWriter("Ch13Pr4.txt"); //create a new streamwriter 
            for(int i = 0; i < 10; i++) //set up the number of rows 
            {
                string line = ""; //make a string to be an individual line
                for(int j = 0; j < 5; j++) //set up number of cols 
                {
                    line += $"{r.Next(0,1001),5}"; //generate a random number, space it with interpolation, concatenate to the indivisual line 
                } //end of col loop 
                sw.Write(line + "\n"); //place the line in the file stream 
                sw.Flush(); //flush the stream 
            }
            //after the col loop completes 

            //display the location of the filestream to the console  
            Console.WriteLine($"Opening file now.\nYou file can be found here:\n{((FileStream)(sw.BaseStream)).Name}");
            //open the file in notepad.exe 
            Process.Start("notepad.exe", ((FileStream)(sw.BaseStream)).Name);
            //close the stream 
            sw.Close();

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
            throw new NotImplementedException();

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
