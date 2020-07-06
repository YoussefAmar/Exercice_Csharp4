using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exemple4
{
    class Interrupteur
    {
        Lampe MaLampe;

        string OnOff;

        public Interrupteur(Lampe MaLampe)
        {
            this.MaLampe = MaLampe;
            OnOff = "off";
            Console.WriteLine("Creation inter: etat : " + this.OnOff);
        }

        public void on()
        {
            OnOff = "on";
            Console.WriteLine("Dans interrupteur, je mets on");
            this.MaLampe.allume();
        }

        public void off()
        {
            OnOff = "off";
            Console.WriteLine("Dans interrupteur, je mets off");
            this.MaLampe.eteint();

        }

    }
}
