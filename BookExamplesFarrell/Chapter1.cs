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
            throw new NotImplementedException();

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
            Console.WriteLine("Name : Smith, Susan\n" +
                              "Birthdate : July 20, 1945\n" +
                              "Cell Phone: 232-323-4213\n" +
                              "Home Phone: 683-423-7543\n");
        }

        public override void Problem5()
        {
            Console.WriteLine("♫~A long long time ago~♫");
            Console.WriteLine("♫~I can still remember~♫");
            Console.WriteLine("♫~How the music used to make me smile~♫");
            Console.WriteLine("♫~and I knew if I had my chance~♫");
            Console.WriteLine("♫~that I could make those people dance~♫");
            Console.WriteLine("♫~and maybe they'd be happy for awhile~♫");

        }

        public override void Problem6()
        {
            //this line is a commented line
            Console.WriteLine("This is a string that is a parameter ");

            /* This is a block of comments
             * it takes up several lines
             * and will NOT be compiled as part of the program 
             * Cosnole.WriteLine("this is not printed");
             */

        }

        public override void Problem7()
        {
            string output = "                       \n" +
                            "          ####         \n" +
                            "         #    #        \n" +
                            "        #      #       \n" +
                            "        # STOP #       \n"+ 
                            "        #      #       \n" +
                            "         #    #        \n" +
                            "          ####         \n" +
                            "           ||          \n" +
                            "           ||          \n" +
                            "           ||          \n" +
                            "           ||          \n" +
                            "           ||          \n" +
                            "           ||          \n" +
                            "           ||          \n" +
                            "           ||          \n" +
                            "           ||          \n" +
                            "                       ";
            Console.WriteLine(output);
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
