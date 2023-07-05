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
    //CHAPTER 7 NOTES
    // chapter 7 is all about 
    // Topics of focus:
    //  - array creation options
    //  - array access
    //  - array indexing 
    //  - the introduction of the foreach loop 
    //  -
    // not in text but reccomended: 
    //  - 
    

    //Chapter 7 is covered in IT150, IT151, and IT152

    class Chapter7 : Chapter
    {

        public override void RunProblem(int num)
        {
            base.RunProblem(num);
        }

        public override void Problem1()
        {
            string[] months = { "Jan", "Feb", "Mar", 
                                "Apr", "May", "Jun",
                                "Jul", "Aug", "Sep",
                                "Oct", "Nov", "Dec"};
            double[] rainFall = new double[12];

            for(int i = 0; i < 12; i++)
            {
                double rainfallM = GetDouble($"What was the rainfall avg for {months[i]}? ");
                rainFall[i] = rainfallM;
            }

            double avg = 0; 
            Console.WriteLine($"{"Month",13} : {"Rainfall Avg",13}");
            for (int i = 0; i < 12; i++)
            {
                avg += rainFall[i]; 
                Console.WriteLine($"{months[i],13} : {rainFall[i],13:f2}");
            }
            avg /= 12;
            Console.WriteLine($"{"Annual Avg",13} : {avg,13:f2}");
        }

        public override void Problem2()
        {
            int numNames = GetInt("How many names will you input? ");
            string[] names = new string[numNames];


            Console.WriteLine("Input the names in the format LASTNAME, FIRSTNAME");

            for ( int i = 0; i < numNames; i++)
            {
                Console.Write("Enter a name : ");
                names[i] = Console.ReadLine();
            }

            Console.WriteLine("\nSORTING YOUR ARRAY...\n");
            Array.Sort(names);
            foreach(string n in names)
            {
                Console.WriteLine(n);
            }

        }

        public override void Problem3()
        {
            throw new NotImplementedException();


        }

        public override void Problem4()
        {
            //doing this without user input 
            Random r = new Random(); //create randomizer object 
            int[] stats = new int[11]; //create an array indexed 0 to 10

            for (int i = 0; i < 200; i++) //repeat 200 times 
            {
                stats[r.Next(0, 11)]++; 
                //roll a random number from 0 to 10.
                //access that array element.
                //increase it by 1
            }

            //print headers --> interpolation, spacing, and formatting keep alignment 
            Console.WriteLine($"{"Num",5}:{"Occurances",40}:{"Count",7}");

            for (int j = 0; j < stats.Length; j++) //this loop will visit every index in the stats array 
            {
                string str = ""; //create a string 

                for(int k = 0; k < stats[j]; k++) //for each instance we have seen, 
                {
                    str += "#"; //add a symbol to the string 
                }

                Console.WriteLine($"{j,5}:{str,40}:{stats[j],7}"); //place string for this index on console using interpolation, spacing, and formatting to keep alignment 
            }
        }
        public override void Problem5()
        {
            throw new NotImplementedException();
        }

        public override void Problem6()
        {
            //create string to hold strings with day names 
            string[] days = { "Mon", "Tue", "Wed", "Thu", "Fri", "Sat", "Sun" };
            //create empty double arrays to hold high and low temps 
            double[] hi = new double[7];
            double[] lo = new double[7];

            //create avg hi and avg lo vars to fill later 
            double avgHi = 0;
            double avgLo = 0; 

            //for 7 days 
            for(int i = 0; i < days.Length; i++)
            {
                //prompt for high temp and save to array at day index 
                hi[i] = GetDouble($"Please give me {days[i]}'s hi temp.");
                //prompt for low temp and save to array at day index 
                lo[i] = GetDouble($"Please give me {days[i]}'s lo temp.");

                //increase avghi and avglo
                avgHi += hi[i];
                avgLo += lo[i];
            }
            //divide avg values by 7 
            avgHi /= 7;
            avgLo /= 7;

            //print col headers using string interpolation and spacing 
            Console.WriteLine($"{"Day",5} : {"Hi",6} : {"Lo",6}");
            for(int j = 0; j < days.Length; j++)
            {
                //print temp values using string interpolation, formatting, and spacing 
                Console.WriteLine($"{days[j],5} : {hi[j],6:f2}° : {lo[j],6:f2}°");
            }
            //print avg hi and avg lo for string interpolation, formatting, and spacing  
            Console.WriteLine($"{"Avg",5} : {avgHi,6:f2}° : {avgLo,6:f2}°");
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
            Problem4();

        }

        public override void Problem10()
        {
            throw new NotImplementedException();
        }

    }
}
