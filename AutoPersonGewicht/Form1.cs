using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoPersonGewicht
{
    public partial class Form1 : Form
    {
        Auto myCar = new Auto(1000, 4);
        Random random = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEinsteigen_Click(object sender, EventArgs e)
        {
            if (myCar.GetAnzahlSitze() > myCar.GetAnzahlPassagiere())
            {
                Person person1 = new Person(random.Next(10, 150));
                myCar.Einsteigen(person1);
                txtAusgabe.Text = $"Maximale Sitzplätze : {myCar.GetAnzahlSitze()} \r\n";
                txtAusgabe.Text += $"Anzahl Passagiere : {myCar.GetAnzahlPassagiere()} \r\n";
                txtAusgabe.Text += $"Gesamtgewicht : {myCar.Gesamtgewicht} \r\n";
            }
            
        }

        private void btnAussteigen_Click(object sender, EventArgs e)
        {
            if (myCar.GetAnzahlPassagiere() > 0)
            {
                myCar.Aussteigen(myCar.GetPassagiere().Count-1);
                txtAusgabe.Text = $"Maximale Sitzplätze : {myCar.GetAnzahlSitze()} \r\n";
                txtAusgabe.Text += $"Anzahl Passagiere : {myCar.GetAnzahlPassagiere()} \r\n";
                txtAusgabe.Text += $"Gesamtgewicht : {myCar.Gesamtgewicht}\r\n";
            }
        }
    }
}
