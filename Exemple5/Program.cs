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
            Lampe salon = new Lampe("Salon","eteint");

            Lampe cuisine = new Lampe("Cuisine","eteint");

            Interrupteur intersalon = new Interrupteur(salon);

            intersalon.on();
            //intersalon.off();

            Console.ReadLine();
        }
    }
}
