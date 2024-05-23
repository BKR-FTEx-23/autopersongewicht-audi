using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AutoPersonGewicht
{
    public class Auto
    {
        private double gesamtgewicht;
        private double fahrzeuggewicht;
        private int anzahlPassagiere;
        List<Person> person = new List<Person>();

        public Auto()
        {

        }
        public Auto(double pFahrzeuggewicht)
        {
            fahrzeuggewicht = pFahrzeuggewicht;
            gesamtgewicht = fahrzeuggewicht;
        }

        public double GetGesamtgewicht(double pFahrzeuggewicht, Person pPerson)
        {
            gesamtgewicht = pFahrzeuggewicht + pPerson.GetGewicht();
            return gesamtgewicht;
        }

        public void Einsteigen(Person pPerson)
        {
            person.Add(pPerson);
        }

        public void Aussteigen(Person pPerson)
        {
            person.Remove(pPerson);
        }


        public int GetAnzahl()
        {
            return anzahlPassagiere;
        }
    }
}