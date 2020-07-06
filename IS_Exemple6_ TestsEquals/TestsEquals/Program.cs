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
            O2 UnObjetO2 = new O2(3);
            O1 UnObjetO1 = new O1(10, UnObjetO2);
            
            O2 AutreObjetO2 = new O2(3);
            O1 EncoreObjetO1 = new O1(10, AutreObjetO2);

            O1 AutreObjetO1 = UnObjetO1;

            Console.WriteLine("Test de == ---------------------------------------");
            //A conserver pour le test des référents

            Console.WriteLine("== - Tests de 2 objets qui occupent la même zone mémoire");
            Console.WriteLine(AutreObjetO1 == UnObjetO1);

            Console.WriteLine("== - Tests de 2 objets qui occupent des zones mémoire différentes mais ont " +
                "les mêmes données");
            Console.WriteLine(AutreObjetO1 == EncoreObjetO1);

            Console.WriteLine("Test de Equal pour O2 ---------------------------------------");

            O2 Monique = new O2(7);

            Console.WriteLine("Tests de 2 objets qui sont les memes mais avec des zones memoires distinctes");
            Console.WriteLine(UnObjetO2.Equals(AutreObjetO2));
            Console.WriteLine("Tests de 2 objets qui sont différents");
            Console.WriteLine(UnObjetO2.Equals(Monique));

            Console.WriteLine("Test de Equal pour O1 ---------------------------------------");

            Console.WriteLine("Equals - Tests de 2 objets qui occupent la même zone mémoire");
            Console.WriteLine(AutreObjetO1.Equals(UnObjetO1));

            Console.WriteLine("Equals - Tests de 2 objets qui occupent des zones mémoire différentes mais ont " +
                "les mêmes données");
            Console.WriteLine(AutreObjetO1.Equals(EncoreObjetO1));

            Console.WriteLine("Equals - Tests de 2 objets qui ont des attributs différents ");
            O1 Simone = new O1(10, Monique);
            Console.WriteLine(AutreObjetO1.Equals(Simone));


            /*O2 EncoreObjetO2 = new O2(7);
            O1 LastObjetO1 = new O1(10, EncoreObjetO2);

            Console.WriteLine("Equals - Tests de 2 objets différents");
            Console.WriteLine(LastObjetO1.Equals(EncoreObjetO1));*/

            Console.ReadLine();
        }
    }
}
