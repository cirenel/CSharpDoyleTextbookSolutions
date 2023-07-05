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
    //  - 
    // not in text but reccomended: 
    //  - 

    //Chapter 13 is covered in IT151, and IT152

    class Chapter13 : Chapter
    {

        public override void RunProblem(int num)
        {
            base.RunProblem(num);
        }

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
            double sum = 0;
            int count = 0;
            double max = double.MinValue;
            double min = double.MaxValue;
            string s = "";
            using (StreamReader sr = new StreamReader("file.txt"))
            {
                while ((s = sr.ReadLine()) != null)
                {
                    double num = double.Parse(s);
                    sum += num;
                    max = Math.Max(num, max);
                    min = Math.Min(num, min);
                    count++;
                }
            }
            Console.WriteLine($"{count} numbers read.\nAvg: {sum / count}\nMin:{min}\nMax:{max}");
        }

        public override void Problem3()
        {
            throw new NotImplementedException();


        }

        public override void Problem4()
        {
            Random r = new Random();
            StreamWriter sw = new StreamWriter("Ch13Pr4.txt");
            for(int i = 0; i < 10; i++)
            {
                string line = "";
                for(int j = 0; j < 5; j++)
                {
                    line += $"{r.Next(0,1001),5}";
                }
                sw.Write(line + "\n");
                sw.Flush();
            }
            
            Console.WriteLine($"Opening file now.\nYou file can be found here:\n{((FileStream)(sw.BaseStream)).Name}");

            Process.Start("notepad.exe", ((FileStream)(sw.BaseStream)).Name);

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
