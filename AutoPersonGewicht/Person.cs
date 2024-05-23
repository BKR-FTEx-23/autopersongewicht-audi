using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AutoPersonGewicht
{
    public class Person
    {
        private double gewicht;

        public Person()
        {
            
        }
        public Person(double pGewicht)
        {
            gewicht = pGewicht;
        }

        public double GetGewicht()
        {
            return gewicht;
        }
    }
}