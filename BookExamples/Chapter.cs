using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookExamples
{
    abstract class Chapter
    {
        public virtual void RunProblem(int num)
        {
            switch (num)
            {
                case 1:
                    Problem1();
                    break;
                case 2:
                    Problem2();
                    break;
                case 3:
                    Problem3();
                    break;
                case 4:
                    Problem4();
                    break;
                case 5:
                    Problem5();
                    break;
                case 6:
                    Problem6();
                    break;
                case 7:
                    Problem7();
                    break;
                case 8:
                    Problem8();
                    break;
                case 9:
                    Problem9();
                    break;
                case 10:
                    Problem10();
                    break;
                
            }
        }

        public abstract void Problem1();
        public abstract void Problem2();
        public abstract void Problem3();
        public abstract void Problem4();
        public abstract void Problem5();
        public abstract void Problem6();
        public abstract void Problem7();
        public abstract void Problem8();
        public abstract void Problem9();
        public abstract void Problem10();


        //methods used throughout
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
            if (lo == hi)
            {
                return GetInt(msg);
            }
            string input;
            int ret;
            do
            {
                Console.Write(msg);
                input = Console.ReadLine();
            } while (!int.TryParse(input, out ret) || (ret > hi || ret < lo));

            return ret;
        }
        public static double GetDouble(string msg = "Please enter a double")
        {
            string input;
            double ret;
            do
            {
                Console.Write(msg);
                input = Console.ReadLine();
            } while (!double.TryParse(input, out ret));

            return ret;
        }


    }
}
