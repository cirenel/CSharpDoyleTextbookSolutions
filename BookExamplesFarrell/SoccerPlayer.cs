using System;
using System.Collections.Generic;
using System.Text;

namespace BookExamplesFarrell
{
    //chapter 9 problem 1
    internal class SoccerPlayer
    {
        //attributes
        private string name;
        private int jerseyNum;
        private int goalsScored;
        private int assists; 

        //properties
        public string Name { 
            get { return name; } 
        }
        public int JerseyNum { 
            get { return jerseyNum; } 
        }
        public int GoalsScored { 
            get { return goalsScored; } 
            set { goalsScored = value; } 
        }
        public int Assists { 
            get { return assists; } 
            set{ assists = value; } 
        }

        //constructors 
        public SoccerPlayer(string name, int jerseynumber)
        {
            this.name = name;
            this.jerseyNum = jerseynumber;
            this.assists = 0;
            this.goalsScored = 0;
        }

        //methods

        public void GoalScored()
        {
            goalsScored++;
        }

        public void GoalAssisted()
        {
            assists++;
        }

        //overrides 
        public override string ToString()
        {
            return $"{name,20} : {jerseyNum,2} : {goalsScored,5} : {assists,6}";
        }

    }
}
