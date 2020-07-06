using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exemple4
{
    class Program
    {
        static void Main(string[] args)
        {
            Lampe salon = new Lampe();

            Lampe cuisine = new Lampe("allumé");

            Interrupteur intersalon = new Interrupteur(salon);

            intersalon.on();
            intersalon.off();

            Console.ReadLine();
        }
    }
}
