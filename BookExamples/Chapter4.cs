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

//CHAPTER 4 NOTES
// chapter 4 is all about classes. 
// Topics of focus:
//  - creation of objects
//  - specificaiton of classes
//  - instance methods v. static methods
//  - constructors
//  - accessors
//  - mutators
//  - override methods
// not in text but reccomended: 
//  - 
//NOTE: i have traditionally NOT covered this chapter until AFTER the IT150  midterm exam
//in this file, I have created the classes specifed by the prompt as SUBCLASSES of this Chapter4 class.
//These subclasses could be easily peeled into their own stand alone .cs files
//additional class files for these problems can be found in this solution file 

//Chapter 4 is covered in IT150 [after midterms]

namespace BookExamples
{
    class Chapter4 : Chapter
    {

        public override void RunProblem(int num)
        {
            base.RunProblem(num);
        }

        //begin Problem 1
        //creating instances of the date class 
        public override void Problem1()
        {
            int month = GetInt("Please enter the month: ", 1, 12);
            int year = GetInt("Please enter the year: ");
            int day = GetInt("Please enter the day: ", 1, 31);
            Date d1 = new Date(year, month, day);
            

             month = GetInt("Please enter the month: ", 1, 12);
             year = GetInt("Please enter the year: ");
             day = GetInt("Please enter the day: ", 1, 31);
            Date d2 = new Date(year, month, day);

            Console.WriteLine();
            Console.WriteLine($"You entered the date {d1.GetStringDate()}");
            Console.WriteLine($"You entered the date {d2.GetStringDate()}");

            Console.WriteLine($"{d1} and {d2} are{((d1.Equals(d2) == true) ? "" : "n't")} the same date!");
        }
        


        //begin Problem 2
        //creating instances of the student class 
        public override void Problem2()
        {
            //prompt user for information
            Console.WriteLine("What is your first name? ");
            string fName = Console.ReadLine();
            Console.WriteLine("What is your last name? ");
            string lName = Console.ReadLine();
            Student.Major m = (Student.Major)GetInt("Pick an int from 0 to 5 ", 0, 5);
            Student s1 = new Student(f: fName, l: lName, m: m);
            s1.GPA = GetDouble("What is your GPA? ");
            s1.Term = GetInt("What term are you in? ", 1, 8);

            //prompt user for information
            Console.WriteLine("What is your first name? ");
             fName = Console.ReadLine();
            Console.WriteLine("What is your last name? ");
             lName = Console.ReadLine();
             m = (Student.Major)GetInt("Pick an int from 0 to 5 ", 0, 5);
            Student s2 = new Student(f: fName, l: lName, m: m);
            s2.GPA = GetDouble("What is your GPA? ");
            s2.Term = GetInt("What term are you in? ", 1, 8);

            //prompt user for information
            Console.WriteLine("What is your first name? ");
            fName = Console.ReadLine();
            Console.WriteLine("What is your last name? ");
            lName = Console.ReadLine();
            m = (Student.Major)GetInt("Pick an int from 0 to 5 ", 0, 5);
            Student s3 = new Student(f: fName, l: lName, m: m);
            s3.GPA = GetDouble("What is your GPA? ");
            s3.Term = GetInt("What term are you in? ", 1, 8);

            //prompt user for information
            Console.WriteLine("What is your first name? ");
            fName = Console.ReadLine();
            Console.WriteLine("What is your last name? ");
            lName = Console.ReadLine();
            m = (Student.Major)GetInt("Pick an int from 0 to 5 ", 0, 5);
            Student s4 = new Student(f: fName, l: lName, m: m);
            s4.GPA = GetDouble("What is your GPA? ");
            s4.Term = GetInt("What term are you in? ", 1, 8);

            //prompt user for information
            Console.WriteLine("What is your first name? ");
            fName = Console.ReadLine();
            Console.WriteLine("What is your last name? ");
            lName = Console.ReadLine();
            m = (Student.Major)GetInt("Pick an int from 0 to 5 ", 0, 5);
            Student s5 = new Student(f: fName, l: lName, m: m);
            s5.GPA = GetDouble("What is your GPA? ");
            s5.Term = GetInt("What term are you in? ", 1, 8);

            //take the created student objects and print their contents to the screen 
            string output = $"{"Student ID",20} : {"",9}Name{"",-9} : {"GPA",6} : {"Term",5} : {"Major",11}\n" +
                $"{s1}\n" + $"{s2}\n" + $"{s3}\n" + $"{s4}\n" + $"{s5}\n";
            Console.WriteLine(output);
        }

        

        //begin Problem 3
        public override void Problem3()
        {
            //create motorways with various constructor options 
            Motorway m1, m2, m3, m4;
            m1 = new Motorway(name:"Highway 42", direction: Direction.W, numLanes:4);
            m2 = new Motorway(6, "Highway 61", Direction.N, "Airline Highway");
            m3 = new Motorway(2, "Highway 44", Direction.S);
            m4 = new Motorway(10, "I-10", Direction.W);

            //connect intersecting motorways 
            m1.AddIntersectingMotorway(m2);
            m2.AddIntersectingMotorway(m1);
            m1.AddIntersectingMotorway(m3);
            m3.AddIntersectingMotorway(m1);
            m3.AddIntersectingMotorway(m4);
            m4.AddIntersectingMotorway(m3);
            m1.AddIntersectingMotorway(m4);
            m4.AddIntersectingMotorway(m1);

            //print report of each highway 
            Console.WriteLine("\n=================== Motorway Reports ====================");
            Console.WriteLine(m1);
            Console.WriteLine(m2);
            Console.WriteLine(m3);
            Console.WriteLine(m4);

            Console.WriteLine("\n================== Intersection Reports =================");
            Console.WriteLine(m1.GetReportofIntersections());
            Console.WriteLine(m2.GetReportofIntersections());
            Console.WriteLine(m3.GetReportofIntersections());
            Console.WriteLine(m4.GetReportofIntersections());


        }


        //begin Problem 4
        //employees are not loaded in from user reuqest but rather created 
        public override void Problem4()
        {
            Employee e1, e2, e3, e4, e5, e6, e7, e8, e9, e10;
            // public Employee(string f, string l, Department d, Classification c, double pr)
            e1 = new Employee("Susan", "Smith", Employee.Department.HR, Employee.Classification.hourly, 25.60);
            e2 = new Employee("Janice", "Field", Employee.Department.Marketing, Employee.Classification.salary, 52000);
            e3 = new Employee("Frank", "Herbet", Employee.Department.RandD, Employee.Classification.salary, 100000);
            e4 = new Employee("Susan", "Bedford", Employee.Department.Sales, Employee.Classification.hourly, 36.50);
            e5 = new Employee("Mark", "Bedford", Employee.Department.IT, Employee.Classification.hourly, 20.45);
            e6 = new Employee("Alice", "Walker", Employee.Department.Marketing, Employee.Classification.hourly, 15.67);
            e7 = new Employee("Amy", "Davis", Employee.Department.IT, Employee.Classification.hourly, 25.12);
            e8 = new Employee("Evan", "Dennis", Employee.Department.Sales, Employee.Classification.salary, 67300);
            e9 = new Employee("Tyrie", "Martens", Employee.Department.Sales, Employee.Classification.salary, 90000);
            e10 = new Employee("Branden", "Sanders", Employee.Department.RandD, Employee.Classification.hourly, 27.84);

            Employee[] staff = new Employee[] { e1, e2, e3, e4, e5, e6, e7, e8, e9, e10 };

            string output = $"{"ID", 6} : {"",9}{"Name",4}{"",9} : {"Department",10} : {"Class",5} : \n";

            foreach (Employee e in staff)
            {
                output += e + "\n";
            }
            Console.WriteLine(output);

        }



        public override void Problem5()
        {
            List<Receipt> all = new List<Receipt>();
            bool multiple = false; 

            do
            {
                Console.Clear();
                Console.WriteLine("Enter the items you are adding to the bill. type EXIT when done");
                Receipt r = new Receipt();

                string input = "";
                string description = "";
                double price;
                do
                {
                    Console.Write("\nItem name: ");
                    description = Console.ReadLine();
                    if (description == "EXIT") { continue; }
                    do
                    {
                        Console.Write("Item price: ");
                        input = Console.ReadLine();
                    } while (!double.TryParse(input, out price) && input != "EXIT");

                    if (input == "EXIT") { continue; }

                    r.AddItem(new Item(description, price));

                } while (input != "EXIT" && description != "EXIT");

                Console.WriteLine("\n your receipt: ");
                Console.WriteLine(r.GetReceipt());

                Console.WriteLine($"You owe {r.Total}");

                double amtpaid = GetDouble("How much are you paying for this? ");
                r.Pay(amtpaid);
                all.Add(r); //add this recipt to the list of ALL recipts 
                Console.WriteLine("Thank you come again!! ");
                Console.Write("Are there more? Y/N ---> ");
                input = Console.ReadLine();
                multiple = (input == "Yes") || (input == "Y") || (input == "yes") || (input == "y")  ;
                Console.WriteLine();
            } while (multiple);

            all.Sort(); //sort --> will use the compareto method in the recipt class [bases this information on the total]

            Console.WriteLine("\nHere are all of the recipts from this session: ");
            foreach(Receipt r in all)
            {
                Console.WriteLine(r.GetReceipt()+"\n");
            }

        }

        public override void Problem6()
        {
            string dest = Console.ReadLine();
            double distance = GetDouble("How many miles did you travel? ");
            double gallons = GetDouble("How many gallons did you use? ");
            double price = GetDouble("How much did you spend on gas?");
            int num = GetInt("How many people are splitting the bill? ");

            Trip t = new Trip(gallons, price, distance, dest, num);
            Console.WriteLine(t);

        }

        public override void Problem7()
        {
            throw new NotImplementedException(); //this one is just... idk i dont like it 
        }

        public override void Problem8()
        {
            
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
