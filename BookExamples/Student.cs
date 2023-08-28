using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookExamples
{
    public class Student
    {
        //ignore this line. is literally just here to give us a randomizer 
        private Random r = new Random();
        public enum Major
        {
            PTech, //0
            IT, //1
            HVAC, //2
            CM, //3
            CAD, //4
            Undecided //5 
        }

        //attributes aka fields begin here 
        private string fName, lName;
        private double gpa;
        private Major field;
        private int term;
        private int studentID;
        private static int lastStudentId = 10000;

        //properties begin here 
        public string FirstName
        {
            get { return fName; }
            set { fName = value; }
        }
        public string LastName
        {
            get { return lName; }
            set { lName = value; }
        }
        public double GPA
        {
            get { return gpa; }
            set { gpa = value; }
        }
        public int StudentID
        {
            get { return studentID; }
        }
        public Major Field
        {
            get { return field; }
            set { field = value; }
        }
        public int Term
        {
            get { return term; }
            set { term = value; }
        }

        //constructor methods begin here 
        public Student(string f, string l)
        {
            fName = f;
            lName = l;
            term = 1;
            field = Major.Undecided;
            gpa = 0;
            studentID = GenerateStudentNum();
        }

        public Student(string f, string l, Major m)
        {
            fName = f;
            lName = l;
            term = 1;
            field = m;
            gpa = 0;
            studentID = GenerateStudentNum();
        }

        //static method for generating sequntial student numbers 
        public int GenerateStudentNum()
        {
            lastStudentId = lastStudentId + r.Next(10, 1001);
            return lastStudentId;
        }

        //misc instance methods 
        public bool CanGrad()
        {
            if (term >= 8 && gpa >= 1.25) //check that the term and gpa are high enough 
            {
                return true; //if so return true, the student can graduate 
            }
            else //otherwise 
            {
                return false; //return false, the student cannot graduate 
            }
        }

        public bool AdvanceTerm()
        {
            if (gpa >= 1)
            {
                term++;
                return true;
            }
            else
            {
                return false;
            }
        }

        //override methods 
        public override string ToString()
        {
            
            string ret =
                $"{studentID,20} : {lName,10}, {fName,-10} : {gpa,6:f2} : {term,5} : {field,11}";

            return ret;
        }
    }
}
