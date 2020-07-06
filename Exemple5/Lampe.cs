using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exemple4
{
    class Lampe
    {
        string nom = "";
        string etat = "";
        static int nblampes;
        ampoule ampoule1;
        ampoule ampoule2;
        ampoule ampoule3;

        public Lampe()
        {
            nblampes++;
            this.nom = "défaut";
            this.etat = "éteints";
            this.ampoule1 = new ampoule("ampoule1", 40, "bon", "off");
            this.ampoule2 = new ampoule("ampoule2", 40, "bon", "off");
            this.ampoule3 = new ampoule("ampoule3", 40, "bon", "off");

            Console.WriteLine("Lampe numero " + nblampes.ToString()+" : ");

            Console.WriteLine("La lampe est " + etat +" nom : "+this.nom);

            
        }

        public Lampe(string nom,string etat)
        {


            this.nom = nom;
            this.etat = etat;
            this.ampoule1 = new ampoule("ampoule1", 40, "bon", "off");
            this.ampoule2 = new ampoule("ampoule2", 40, "bon", "off");
            this.ampoule3 = new ampoule("ampoule3", 40, "bon", "off");
            nblampes++;
            Console.WriteLine("Lampe numero " + nblampes.ToString()+" : ");

            Console.WriteLine("La lampe est " + etat +" nom : "+this.nom);

        }

        public void allume()
        {
            this.ampoule1.allume();
            this.ampoule2.allume();
            this.ampoule3.allume();

            this.etat = "allumé";

            Console.WriteLine("La lampe est " + etat);

        }

        public void eteint()
        {
            this.ampoule1.eteint();
            this.ampoule2.eteint();
            this.ampoule3.eteint();

            this.etat = "éteints";

            Console.WriteLine("La lampe est " + etat);

        }
    }
}
