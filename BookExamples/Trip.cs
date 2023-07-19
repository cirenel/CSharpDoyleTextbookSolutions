using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookExamples
{
    internal class Trip
    {
        private double gallons, totalCost, distance;
        private int numPeople;
        private string destination;

        public Trip() { }
        public Trip( double totalCost, string dest, int numPeople)
        {
            this.destination = dest;
            this.numPeople = numPeople;
            this.totalCost = totalCost;

        }
        public Trip(double gallons, double totalCost, double distance)
        {
            this.totalCost = totalCost;
            this.gallons = gallons;
            this.distance = distance;
        }
        public Trip(double gallons, double totalCost, double distance, string dest, int numPeople)
        {
            this.destination = dest;
            this.numPeople = numPeople;
            this.totalCost = totalCost;
            this.gallons = gallons;
            this.distance = distance;
        }

        public double getMPG()
        {
            if(gallons > 0 && distance > 0)
            {
                return gallons / distance;
            } else
            {
                return -1; 
            }
        }

        public double getPricePer()
        {
            if(numPeople>0 && totalCost > 0)
            {
                return totalCost / numPeople;
            } else
            {
                return -1;
            }
        }

        public double getPricePerMile()
        {
            if(totalCost > 0 && distance > 0)
            {
                return totalCost / distance;
            }  else
            {
                return -1;
            }
        }


        public override string ToString()
        {
            string ret = "\nTRIP STATS\n";
            if(destination != "")
            {
                ret += destination + " : ";
            } 
            if(distance > 0)
            {
                ret += distance + " miles\n";
            }
            if(gallons > 0)
            {
                ret += gallons + " gallons ";
            }
            if(totalCost > 0)
            {
                ret += $"at {totalCost:c2} ";
            }
            if(numPeople > 0)
            {
                ret += $"split betewen {numPeople}\n";
            }
            if (getMPG() >= 0)
            {
                ret += $"MPG: {getMPG(),2:f2}\n";
            }
            if (getPricePer() >= 0)
            {
                ret += $"Price per person: {getPricePer(),8:c2}\n";
            }
            if (getPricePerMile() >= 0)
            {
                ret += $"Price per mile: {getPricePerMile(),8:c2}\n";
            }

            return ret;
        }

    }
}
