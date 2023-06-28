using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookExamples
{
    public class Date
    {
        private int year, month, day;
        private string monthName;
        public Date(int y, int m, int d)
        {
            year = y;
            month = m;
            day = d;
            //this is covered in chapter 5 that for some reason isnt first in the text 
            switch (m)
            {
                case 1:
                    monthName = "January";
                    break;
                case 2:
                    monthName = "February";
                    break;
                case 3:
                    monthName = "March";
                    break;
                case 4:
                    monthName = "April";
                    break;
                case 5:
                    monthName = "May";
                    break;
                case 6:
                    monthName = "June";
                    break;
                case 7:
                    monthName = "July";
                    break;
                case 8:
                    monthName = "August";
                    break;
                case 9:
                    monthName = "September";
                    break;
                case 10:
                    monthName = "October";
                    break;
                case 11:
                    monthName = "November";
                    break;
                case 12:
                    monthName = "December";
                    break;
            }
        }

        public string GetNumericDate()
        {
            string date = day + "/" + month + "/" + year;
            return date;
        }
        public string GetStringDate()
        {
            string date = monthName + " " + day + ", " + year;
            return date;
        }

        public override string ToString()
        {
            return GetNumericDate();
        }
        public override bool Equals(object obj)
        {
            Date test = obj as Date;
            if (test.day == day && test.year == year && test.month == month)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
