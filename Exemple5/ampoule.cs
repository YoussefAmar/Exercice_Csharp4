using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exemple4
{
    class ampoule
    {
        private string nom;
        private int watt;
        private string etat;
        private string onoff;

        public ampoule(string nom, int watt, string etat, string onoff)
        {
            this.nom = nom;
            this.watt = watt;
            this.etat = etat;
            this.onoff = onoff;
            Console.WriteLine("Dans ampoule, creation d'une ampoule : " + this.nom);

        }

        public void allume()
        {
            this.onoff = "on";
            Console.WriteLine("Ampoule on : " + this.nom);
        }

        public void eteint()
        {
            this.onoff = "off";
            Console.WriteLine("Ampoule off : " + this.nom);

        }
    }
}
