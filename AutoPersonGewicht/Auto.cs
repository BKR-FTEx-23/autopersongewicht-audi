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
        private int anzahlSitze;
        List<Person> passagiere = new List<Person>();

        public Auto()
        {

        }
        public Auto(double pFahrzeuggewicht, int pAnzahlSitze)
        {
            anzahlSitze = pAnzahlSitze;
            fahrzeuggewicht = pFahrzeuggewicht;
            gesamtgewicht = fahrzeuggewicht;
        }

        public double Gesamtgewicht
        {
            get
            {
                gesamtgewicht = fahrzeuggewicht;

                foreach(var person in passagiere)
                {
                    gesamtgewicht += person.Gewicht;
                }
                return gesamtgewicht;
            }
        }

        //public double GetGesamtgewicht(double pFahrzeuggewicht, List<Person> pPerson)
        //{
        //    gesamtgewicht = pFahrzeuggewicht;

        //    foreach (var person in pPerson)
        //    {
        //        gesamtgewicht += person.Gewicht;
        //    }

        //    return gesamtgewicht;
        //}



        public void Einsteigen(Person pPerson)
        {
            if (passagiere.Count < anzahlSitze)
            {
                passagiere.Add(pPerson);
            }
        }

        public void Aussteigen(int pPerson)
        {
            if (passagiere.Count > 0)
            {
                passagiere.RemoveAt(pPerson);
            }
        }


        public int GetAnzahlPassagiere()
        {
            anzahlPassagiere = passagiere.Count;
            return anzahlPassagiere;
        }

        public int GetAnzahlSitze()
        {
            return anzahlSitze;
        }

        public double GetFahrzeuggewicht()
        {
            return fahrzeuggewicht;
        }

        public List<Person> GetPassagiere()
        {
            return passagiere;
        }
    }
}