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
    //CHAPTER 9 NOTES
    // chapter 9 is all about 
    // Topics of focus:
    //  - introduction to using forms and forms projects 
    //  - basics of controls, properties, events
    //  - sensible naming conventions for on forms controls 
    // not in text but reccomended: 
    //  - microsoft c# documentation for form creation and use of visual studio 

    //see Ch9Pro1, Ch9Pro2, Ch9Pro3, Ch9Pro4, Ch9Pro5, Ch9Pro6, Ch9Pro8, Ch9Pro10 files for additional comments 

    //Chapter 9 is covered in IT151, and IT152

    class Chapter9 : Chapter
    {

        public override void RunProblem(int num)
        {
            base.RunProblem(num);
        }

        public override void Problem1()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Ch9Pro1()); //this is the secret sauce for kicking off a form from within code 
        }

        public override void Problem2()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Ch9Pro2());
        }

        public override void Problem3()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Ch9Pro3());
        }

        public override void Problem4()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Ch9Pro4());
        }

        public override void Problem5()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Ch9Pro5());
        }

        public override void Problem6()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Ch9Pro6());
        }

        public override void Problem7()
        {
            throw new NotImplementedException();
        }

        public override void Problem8()
        {
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Ch9Pro8());
        }

        public override void Problem9()
        {
            throw new NotImplementedException();

        }

        public override void Problem10()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Ch9Pro10());
        }

    }
}
