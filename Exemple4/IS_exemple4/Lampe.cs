using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exemple4
{
    class Lampe
    {
        string etat = "";
        static int nblampes;

        public Lampe()
        {
            nblampes++;

            this.etat = "éteints";

            Console.WriteLine("Lampe numero " + nblampes.ToString()+" : ");

            Console.WriteLine("La lampe est " + etat);

            
        }

        public Lampe(string etat)
        {

            nblampes++;

            Console.WriteLine("Lampe numero " + nblampes.ToString()+" : ");

            Console.WriteLine("La lampe est " + etat);

        }

        public void allume()
        {
            this.etat = "allumé";

            Console.WriteLine("La lampe est " + etat);

        }

        public void eteint()
        {
            this.etat = "éteints";

            Console.WriteLine("La lampe est " + etat);

        }
    }
}
