using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestsEquals
{
    class O1
    {
        private int unAttributO1;
        private O2 lienO2;

        public O1(int unAttributO1, O2 lienO2)
        {
            this.unAttributO1 = unAttributO1;
            this.lienO2 = lienO2;
        }

        public O2 getO2()
        {
            return lienO2;
        }

        public void donneAttribut()
        {
            Console.WriteLine("valeur attribut = " + unAttributO1);
        }

        public override bool Equals(Object unObjet)
        { /* redéfinition de la méthode Equals */
            //Même référent
            if (this == unObjet)
            {
                return true;
            }
            //Référents différents
            else
            {
                //Les deux lignes qui suivent permettent de tester si unObjet est instance de O1
                O1 unAutreO1 = unObjet as O1;
                if (unObjet != null)
                {
                    //Appel récursif de Equals pour l'objet inclu
                    if ((unAttributO1 == unAutreO1.unAttributO1)
                        &&(lienO2.Equals(unAutreO1.lienO2)))
                        return true;
                    else
                        return false;
                }
            }
            return false;
        }

        public O1 Clone()
        { //définition du clonage 
            O1 unNouveauO1 = (O1)this.MemberwiseClone();
            unNouveauO1.lienO2 = lienO2.Clone();
            return unNouveauO1;
        }
    }

}
