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
using System.Windows.Forms;


namespace BookExamples
{
    //CHAPTER 10 NOTES
    // chapter 10 is all about 
    // Topics of focus:
    //  - working with more controls
    //  - working with more complex events 
    // not in text but reccomended: 
    //  - 

    //Chapter 10 is covered in IT151, and IT152

    class Chapter10 : Chapter
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
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Ch10Pro2());
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
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Ch10Pro9());
        }

        public override void Problem10()
        {
            throw new NotImplementedException();
        }

    }
}