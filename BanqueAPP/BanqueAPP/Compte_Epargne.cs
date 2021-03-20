using System;

namespace BanqueAPP
{
    class Compte_Epargne : Compte
    {
        private double taux_interet;

  
        public Compte_Epargne(Client t, MAD s, double tI)
            : base(t, s)
        {

            while (this.taux_interet < 0 || this.taux_interet > 100)
            {
                Console.WriteLine("le taux Interet invalide ");
            }
            this.taux_interet = tI;
        }

        public void calculeinteret()
        {
            this.solde = this.solde * (1 + this.taux_interet / 100);
        }

    }
}
