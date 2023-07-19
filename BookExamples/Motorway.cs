using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookExamples
{
    enum Direction { N, NE, E, SE, S, SW, W, NW }
    enum Classification { highway, street, lane, drive, interstate}
    
    internal class Motorway
    {
        //attributes 
        private DateTime dateOfConstruction;        
        private DateTime dateOfLastMaintainence;
        private DateTime dateOfLastInspection;
        private string name, nickname;
        private Direction direction;
        private Classification classification;
        private List<Motorway> intersectingMotorways;
        private Dictionary<DateTime, string> inspections;
        private int numLanes;
        private bool oneway;

        //properties 
        public DateTime DateOfConstruction { get { return dateOfConstruction; } }
        public DateTime DateOfLastMaintainence { get { return dateOfLastMaintainence; } set {  dateOfLastMaintainence = value; } }
        public DateTime DateOfLastInspection { get { return dateOfLastInspection; } set { dateOfLastInspection = value; } }

        public string Name { get { return name; } }
        public Direction Direction { get { return direction; } }
        public string Nickname { get { return nickname; } set { nickname = value; } }


        //constructors 
        public Motorway(int numLanes, string name, Direction direction, string nickname = "", bool oneway = false)
        {
            intersectingMotorways = new List<Motorway>();
            inspections = new Dictionary<DateTime, string>();

            this.numLanes = numLanes;
            this.name = name;
            this.direction = direction; 
            this.nickname = nickname;
            this.oneway = oneway;
        }

        //methods 
        public void AddInspectionReport(string report)
        {
            DateTime currentTime = DateTime.Now;
            inspections.Add(currentTime, report);
            dateOfLastInspection = currentTime; 
        }

        public void AddIntersectingMotorway(Motorway m)
        {
            intersectingMotorways.Add(m);
        }

        public string GetInspectionRecord()
        {
            string ret = $"==================== Motorway Inspection Report ====================\n";
            ret += name + " " + direction;

            if (inspections.Count > 0)
            {
                ret += ": \n";

                foreach (DateTime dt in inspections.Keys)
                {
                    string report = inspections[dt];
                    ret += $"\t|--- {dt.Date} : {report}\n";
                }
            }
            else
            {
                ret += " does not have any inspections on file.\n";
            }

            ret += new string('=', 58);
            return ret;
        }

        public string GetReportofIntersections()
        {
            string ret = $"============= Motorway Intersection Report ==============\n";

            ret += name + " " + direction;
            if (intersectingMotorways.Count > 0)
            {
                ret+= " intersects: \n";

                foreach (Motorway m in intersectingMotorways)
                {
                    ret += $"\t|----- {m.Name, -15} {m.Direction,-3}\n";
                }
            } else
            {
                ret += " does not intersect any roads on file.\n";
            }

            ret += new string('=', 57);

            return ret;
        }


        ///overide methods
        public override string ToString()
        {
            string ret = $"==================== Motorway Report ====================\n";
            ret += $"{name,20} ";
            if(nickname!=null || nickname != "")
            {
                ret += $"{nickname,20} ";
            }
            ret+=$"{direction,3}\n";
            ret += $"\t{"Constructed",15}: {dateOfConstruction.Date}\n";
            ret += $"\t{"Inspected",15}: {dateOfLastInspection.Date}\n";
            ret += $"\t{"Maintained",15}: {dateOfLastMaintainence.Date}\n";
            ret += new string('=', 57);
            return ret;

        }


    }
}
