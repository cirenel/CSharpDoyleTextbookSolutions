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
    class Chapter4 : Chapter
    {
        


        public override void RunProblem(int num)
        {
            base.RunProblem(num);
        }


        public override void Problem1()
        {
            const double creditLimit = 8000;
            Console.Write("Please enter the amount : ");
            double price = double.Parse(Console.ReadLine());    

            if(price <= creditLimit)
            {
                Console.WriteLine("Approved.");
            } else
            {
                Console.WriteLine("ERROR: price exceeds credit limit. cannot purchase.");
            }

        }

         public override void Problem2()
        {
            Console.Write("Please enter your message: ");
            string message = Console.ReadLine();
            if(message.Length <= 140)
            {
                Console.WriteLine($"Message is approved.\nYou have {140-message.Length} chatacters remaining. ");
            } else
            {
                Console.WriteLine($"Message is too long!\n{message.Length - 140} excess characters. ");

            }
        }

        public override void Problem3()
        {
            Console.Write("Please enter the high school GPA : ");
            double gpa = double.Parse(Console.ReadLine());
            Console.Write("Please enter the admissions test score : ");
            double admissionsTest = double.Parse(Console.ReadLine());

            if(gpa>=3.0 && admissionsTest >= 60)
            {
                Console.WriteLine("Accept. ");
            } else if (admissionsTest >= 80)
            {
                Console.WriteLine("Accept. ");
            }
            else
            {
                Console.WriteLine("Reject.");
            }

        }

        public override void Problem4()
        {
            Console.Write("Please enter the windspeed: ");
            double windspeed = double.Parse(Console.ReadLine());

            if (windspeed >= 157)
            {
                Console.WriteLine("This is cat 5");
            } else if (windspeed >= 130)
            {
                Console.WriteLine("This is cat 4");
            }
            else if (windspeed >= 111)
            {
                Console.WriteLine("This is cat 3");
            }
            else if (windspeed >= 96)
            {
                Console.WriteLine("This is cat 2");
            }
            else if (windspeed >= 74)
            {
                Console.WriteLine("This is cat 1");
            }
            else
            {
                Console.WriteLine("this windspeed doesn't qualify this storm as a hurricane.");
            }
        }

        public override void Problem5()
        {
            //A
            Console.Write("What is your birth month number? ");
            int month = int.Parse(Console.ReadLine());
            string moName = "";
            switch(month){
                case 1:
                    moName = "January";
                    break;
                case 2:
                    moName = "February";
                    break;
                case 3:
                    moName = "March";
                    break;
                case 4:
                    moName = "April";
                    break;
                case 5:
                    moName = "May";
                    break;
                case 6:
                    moName = "June";
                    break;
                case 7:
                    moName = "July";
                    break;
                case 8:
                    moName = "August";
                    break;
                case 9:
                    moName = "September";
                    break;
                case 10:
                    moName = "October";
                    break;
                case 11:
                    moName = "November";
                    break;
                case 12:
                    moName = "December";
                    break;
                default:
                    moName = "Not a Month";
                    break;
            }

            //B
            Console.Write("What is your birth day number? ");
            int day = int.Parse(Console.ReadLine());
            string affirm = "";
            if ((day <=30 && day >= 1) && 
                ( 9 == month || 4 == month || 6 == month || 11 == month ))
            {
                affirm = "valid";
            } else if ((day <= 31 && day >= 1) && 
                ( 1 == month || 2 == month || 3 == month || 7 == month || 8 == month || 9 == month || 10 == month || 12 == month ))
            {
                affirm = "valid";
            }
            else if( day >= 1 && day <=29 && month ==2 )
            {
                affirm = "valid";
            }
            else
            {
                affirm = "invalid";
            }
            string output = $"{moName} {day} is a[n] {affirm} date.";
            Console.Write(output);

        }

        public override void Problem6()
        {
            Console.Write("give me a 4 digit checksum: ");
            int checkSum = int.Parse(Console.ReadLine());
            if(checkSum < 1000 || checkSum > 9999)
            {
                Console.WriteLine("INVALID INPUT DETECTED ");
            }
            else
            {
                int last = checkSum%10;
                int first = checkSum/10;
                if(first % 7 == last)
                {
                    Console.WriteLine("This is a valid checksum");
                } else
                {
                    Console.WriteLine("This is an invalid checksum");
                }
            }
        }

        public override void Problem7()
        {
            Random rand = new Random();
            int goal = rand.Next(1, 11);

            Console.Write("Guess a number: ");
            int guess = int.Parse(Console.ReadLine());
            if(guess == goal)
            {
                Console.WriteLine("You got it!!! ");
            } else if(guess < goal)
            {
                Console.WriteLine("Your guess is too low");
            } else if ( guess > goal)
            {
                Console.WriteLine("Your guess is too high");
            }
        }

        public override void Problem8()
        {
            Console.WriteLine("player 1 select:\n[1]ROCK\n[2]PAPER\n[3]SCISSORS");
            int player1 = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("player 2 select:\n[1]ROCK\n[2]PAPER\n[3]SCISSORS");
            int player2 = int.Parse(Console.ReadLine());
            Console.Clear();

            string player1Choice = "";
            string player2Choice = "";

            if (player1 == 1) player1Choice = "rock";
            else if (player1 == 2) player1Choice = "paper";
            else if (player1 == 3) player1Choice = "scissors";
            else player1Choice = "INVALID CHOICE";

            if (player2 == 1) player2Choice = "rock";
            else if (player2 == 2) player2Choice = "paper";
            else if (player2 == 3) player2Choice = "scissors";
            else player2Choice = "INVALID CHOICE";

            Console.WriteLine($"{"PLAYER 1",15} : {"PLAYER 2",-15}\n" +
                              $"{player1Choice,15} : {player2Choice,-15}");

            if (player1 == player2)
            {
                Console.WriteLine("You tied. better luck next time.");
            } else if(player1 == 1)
            {
                if(player2 == 2)
                {
                    Console.WriteLine("Player 2 won!");
                } else if (player2 == 3)
                {
                    Console.WriteLine("Player 1 won!");
                }
            }
            else if (player1 == 2)
            {
                if (player2 == 1)
                {
                    Console.WriteLine("Player 1 won!");
                }
                else if (player2 == 3)
                {
                    Console.WriteLine("Player 2 won!");
                }
            }
            else if (player1 == 3)
            {
                if (player2 == 1)
                {
                    Console.WriteLine("Player 2 won!");
                }
                else if (player2 == 2)
                {
                    Console.WriteLine("Player 1 won!");
                }
            }

        }

        public override void Problem9()
        {
            Console.WriteLine("Select a number from 1 - 9: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Select a number from 1 - 9: ");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Select a number from 1 - 9: ");
            int num3 = int.Parse(Console.ReadLine());
           

            Random r    = new Random();
            int goalNum1 = r.Next(1,10);
            int goalNum2 = r.Next(1, 10);
            int goalNum3 = r.Next(1, 10);
           

            int matches = 0;
            if (num1 == goalNum1 && num2 == goalNum2 && num3 == goalNum3  )
            {
                matches = 4;
            }
            else {
                if (num1 == goalNum1 || num1 == goalNum2 || num1 == goalNum3 )
                {
                    matches++;
                }
                if (num2 == goalNum1 || num2 == goalNum2 || num2 == goalNum3 )
                {
                    matches++;
                }
                if (num3 == goalNum1 || num3 == goalNum3 || num3 == goalNum3 )
                {
                    matches++;
                }
            }

            string output = $"{"Drawn",10} | {"Your choice",-20}\n" +
                            $"{goalNum1+""+ goalNum2 + ""+ goalNum3,10} | {num1 + "" + num2 + "" + num3, -20}\n";

            if (matches == 0)
            {
                output+=("No  matches. better luck next time.");
            } else if (matches == 1) 
            {
                output += ("You got one match! Have $10.");
            } else if (matches == 2)
            {
                output += ("You got two matches!! Have $100.");

            }
            else if (matches == 3)
            {
                output += ("You got three matches!!! Have $1000.");

            }
            else if (matches == 4)
            {
                output += ("You got all matches IN ORDER!!! Have $100000.");

            }
            Console.WriteLine(output);
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
