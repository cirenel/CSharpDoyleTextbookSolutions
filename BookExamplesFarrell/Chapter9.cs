//Claire Luikart
//june 2023
//solutions to Microsoft Visual C# 2017 An Introduction to Object-Oriented Programming by Joynce Farrell 7th ed
//each method contents can be directly placed in main method instead of their individualized methods here 
//these are each only one possible solution to the given prompts 

using BookExamplesFarrell;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace BookExamples
{
    class Chapter9 : Chapter
    {
        


        public override void RunProblem(int num)
        {
            base.RunProblem(num);
        }


        public override void Problem1()
        {
            SoccerPlayer sp1 = new SoccerPlayer("Pele", 10);
            SoccerPlayer sp2 = new SoccerPlayer("Beckham", 7);
            SoccerPlayer sp3 = new SoccerPlayer("Messi", 10);
            SoccerPlayer sp4 = new SoccerPlayer("Ronaldo", 7);

            SoccerPlayer[] players = new SoccerPlayer[] {sp1, sp2, sp3, sp4};

            Random r = new Random();
            int num = r.Next(30, 50);
            for(int i = 0; i < num; i++)
            {
                int index = r.Next(0, 4);
                int roll = r.Next(0, 1001);
                if(roll % 2 == 0)
                {
                    players[index].GoalScored();
                } else
                {
                    players[index].GoalAssisted();
                }
            }
            Console.WriteLine($"{"Player",20} : {"#",2} : {"Goals",5} : {"Assist",6}");
            foreach(SoccerPlayer sp in players)
            {
                Console.WriteLine(sp);
            }

        }

        public override void Problem2()
        {
            ClassifiedAd ad1, ad2, ad3, ad4; 
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
