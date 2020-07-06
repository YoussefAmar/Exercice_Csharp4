using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestsEquals
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Equals
            O2 UnObjetO2 = new O2(3);
            O1 UnObjetO1 = new O1(10, UnObjetO2);
            
            O2 AutreObjetO2 = new O2(3);
            O1 EncoreObjetO1 = new O1(10, AutreObjetO2);

            O1 AutreObjetO1 = UnObjetO1;

            //TestsEquals de la méthode Equals
            /*Console.WriteLine("Test de == ---------------------------------------");
            //A conserver pour le test des référents

            Console.WriteLine("== - Tests de 2 objets qui occupent la même zone mémoire");
            Console.WriteLine(AutreObjetO1 == UnObjetO1);

            Console.WriteLine("== - Tests de 2 objets qui occupent des zones mémoire différentes mais ont les mêmes données");
            Console.WriteLine(AutreObjetO1 == EncoreObjetO1);

            Console.WriteLine("Test de Equals ---------------------------------------");

            Console.WriteLine("Equals - Tests de 2 objets qui occupent la même zone mémoire");
            Console.WriteLine(AutreObjetO1.Equals(UnObjetO1));

            Console.WriteLine("Equals - Tests de 2 objets qui occupent des zones mémoire différentes mais ont les mêmes données");
            Console.WriteLine(AutreObjetO1.Equals(EncoreObjetO1));

            O2 EncoreObjetO2 = new O2(7);
            O1 LastObjetO1 = new O1(10, EncoreObjetO2);

            Console.WriteLine("Equals - Tests de 2 objets différents");
            Console.WriteLine(LastObjetO1.Equals(EncoreObjetO1));*/

            #endregion

            #region clonage
            O2 unQuatriemeO2 = null;
            unQuatriemeO2 = (O2)AutreObjetO2.Clone();
            Console.WriteLine("Clonage O2");
            Console.WriteLine(AutreObjetO2.getAttribut() + " =? " + unQuatriemeO2.getAttribut());

            O1 unTroisiemeO1 = null;
            unTroisiemeO1 = (O1)AutreObjetO1.Clone();
            Console.WriteLine("Clonage O1");
            if (AutreObjetO1.Equals(unTroisiemeO1))
                Console.WriteLine("unTroisiemeO1 et AutreObjetO1 ont le même état");
            else
                Console.WriteLine("unTroisiemeO1 et AutreObjetO1 pas le même état");
            #endregion
            Console.ReadLine();
        }
    }
}
