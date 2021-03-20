using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanqueAPP
{
    class Operation
    {
        private int numO;
        private static int cpt;
       private DateTime dte;
        private MAD montant;
        private string libelle;
       /* static Operation()
        {
            cpt = 0;
        }*/
       /* public Operation()
        {

        }*/
public Operation(string lb,MAD mt)
        {
            this.numO = cpt++;
            dte = DateTime.Now;
            this.libelle = lb;
            this.montant = mt;

        }
        public void afficher()
        {
            Console.Write(this.libelle+"||"+this.dte + "|n°"+this.numO+"||");
            this.montant.afficher();
        }
    }
}
