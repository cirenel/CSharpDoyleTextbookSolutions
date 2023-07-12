using System;
using System.Collections.Generic;
using System.Text;

namespace BookExamplesFarrell
{
    //chapter 9 problem 5
    internal class Car
    {
        enum Color
        {
            RED, BLUE, SILVER, BLACK, TAN, YELLOW
        }
        enum Drive
        {
            RWD, FWD, AWD
        }

        private double odometer, gasCapacity, currentGas, mpg;
        private string make, model, trim;
        private int year; 
        
        
        public double Odometer
        {
            get { return odometer; }
        }

        public Car(string make, string model, int year)
        {
            this.make = make; 
            this.model = model;
            this.year = year;
        }

        public void AddTrip(double miles)
        {
            odometer += miles; 
        }

        public void FuelUp(double gallons)
        {
            currentGas += Math.Min(gallons, gasCapacity);            
        }


    }
}
