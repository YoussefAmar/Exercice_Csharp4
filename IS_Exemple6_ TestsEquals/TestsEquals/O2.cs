using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestsEquals
{
    class O2
    {
        private int unAttributO2;

        public O2(int unAttributO2)
        {
            this.unAttributO2 = unAttributO2;
        }

        public int getAttribut()
        {
            return unAttributO2;
        }

        public void setAttribut(int nouvelleValeur)
        {
            unAttributO2 = nouvelleValeur;
        }

        public override bool Equals(Object unObjet)
        { /* redéfinition de la méthode Equals */
            if (this == unObjet)
            {
                return true;
            }
            else
            {
                //Les deux lignes qui suivent permettent de tester si unObjet est instance de O2
                O2 unAutreO2 = unObjet as O2;
                if (unObjet != null)
                {
                    if (this.unAttributO2 == unAutreO2.unAttributO2)
                        return true;
                    else
                        return false;
                }
            }
            return false;
        }

        /*public O2 Clone()
        {
            return ((O2)MemberwiseClone());
        }*/
    }
}

    
