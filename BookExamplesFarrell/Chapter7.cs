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



namespace BookExamples
{
    class Chapter7 : Chapter
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
            double len = GetDouble("What is the length of the room? ");
            double wid = GetDouble("What is the width of the room? ");
            double price = GetDouble("What is the price per square foot?");
            double totalPriceEstimate = CalcPaintingEst(len, wid, price);
            Console.WriteLine($"A {len}ft X {wid}ft X 9ft room at {price:c2}/sqft will be {totalPriceEstimate:c2}");
        }
        //methods for problem 3
        public static double CalcPaintingEst(double roomL, double roomW, double pricePerSqFt)
        {
            double surfaceArea = (CalcRectArea(roomL, 9) * 2) + (CalcRectArea(roomW, 9)* 2);
            return surfaceArea * pricePerSqFt;
        }
        public static double CalcRectArea(double Len, double Hei)
        {
            return Len * Hei;
        }

        public override void Problem4()
        {
            double numMi = GetDouble("How many miles should I convert? ");
            double numKm = ConvertMi2Km(numMi);

            Console.WriteLine($"{numMi} miles is {numKm} kilometers");

        }
        //methods for problem 4
        public static double ConvertMi2Km(double miles)
        {
            const double conversionFactor = 1.60934;
            return miles * conversionFactor;
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

            Console.Write("Give me a phrase please. ");
            string str = Console.ReadLine();

            int numVowel = CountVowels(str);

            Console.WriteLine($"'{str}' has {numVowel} vowels");
            //also valid 
            Console.WriteLine($"'{str}' has {CountVowels(str)} vowels");


        }
        //methods for problem 9
        //method taking a string and returning the number of vowels
        public int CountVowels(string s)
        {
            char[] vowels = new char[]
            {
                'a','e','i','o','u','A','E','I','O','U'
            };
            int count = 0;
            foreach(char v in vowels)
            {
                count += CountChar(v, s); //use CountChar method to count instances of vowel v
            }

            return count; 
        }
        //count the number of character c that occurs in string s
        public int CountChar(char c, string s)
        {
            int count = 0; 
            foreach (char ch in s) {
                if(ch == c)
                {
                    count++;
                }
            }

            return count;
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
