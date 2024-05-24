using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace AutoPersonGewicht
{
    public class Person
    {
        private double gewicht;
        private int fuehrerscheinID;

        public Person()
        {
            
        }

        public Person(double pGewicht):this(pGewicht, 247864)
        {
            gewicht = pGewicht;
        }
        public Person(double pGewicht, int pFuehrerscheinID) //Superkonstruktor
        {
            gewicht = pGewicht;
            fuehrerscheinID = pFuehrerscheinID;
        }

        public double GetGewicht()
        {
            return gewicht;
        }

        public double Gewicht  // Property
        {
            get { return gewicht; }   // get method
            set { gewicht = value; }  // set method
        }
    }
}