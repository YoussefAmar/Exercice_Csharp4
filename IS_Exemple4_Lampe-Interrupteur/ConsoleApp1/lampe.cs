using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class lampe
    {
        string etat;
        static int nblampes;

        public lampe()
        {
            this.etat = "eteint";
            nblampes++;
            Console.WriteLine("NbLampes : " + nblampes);
            Console.WriteLine("Creation lampe (constr1) : etat :" + this.etat);
        }

        public lampe(string etat)
        {
            this.etat = etat;
            nblampes++;
            Console.WriteLine("NbLampes : " + nblampes);
            Console.WriteLine("Creation lampe (constr2): etat :" + this.etat);
        }

        public void allume()
        {
            this.etat = "allume";
            Console.WriteLine("j'allume la lampe ");
        }

        public void eteint()
        {
            this.etat = "eteint";
            Console.WriteLine("j'eteins la lampe ");
        }
    }
}
