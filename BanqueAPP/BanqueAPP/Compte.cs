using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanqueAPP
{
    class Compte
    {
        private  readonly int numc;
        private static int cpt;
        private  readonly Client titulaire;
        protected MAD solde;
        protected  static MAD plafond;
        private Operation[] op;
       // List<Operation> op = new List<Operation>();
         static Compte()
        {
            cpt = 0;
            plafond = new MAD(3000);

        }
        public Compte(Client t, MAD s)
        {
            this.numc = ++cpt;
            this.titulaire = t;
            this.solde = s;
            op = new Operation[2];
        }
       /* public Compte()
        {

        }*/
        public void consulter()
        {
            int j;
            Console.WriteLine("le numero est :" + this.numc);
            this.titulaire.afficher();
            this.solde.afficher();
            /*for(j=0;j<op.Length;j++)
            {if(op[j]!=null)
               op[j].afficher();
            }*/
        }
       int i = 0;
        public  virtual bool crediter(MAD s)
        {
            
            MAD val = new MAD(0);
            if (s > val)
            {
                this.solde += s;
                
                Operation o = new Operation("crediter", s);
                op[i] = o;
                //op[i].afficher();
                i++;
                return true;
            }
            return false;
        }

        public virtual bool debiter(MAD s)
        {
            MAD val = new MAD(0);
            if (s > val)
            {
                if(plafond > s)
                {
                    if(this.solde > s)
                    { 
                       
                           this.solde -= s;
                        Operation o = new Operation("debiter", s);
                        op[i] = o;
                       // op[i].afficher();
                        i++;
                        return true; 
                    }
                    else {
                        Console.WriteLine("la somme est supérieur  ");
                        return false;
                    }
                }
                    else
                    {
                        Console.WriteLine("la somme est >plafond ");
                        return false;

                    }
            }
            else
                    {
                        Console.WriteLine("  invalide ");
                        return false;
                    }

        }

        public bool verser(Compte c, MAD s)
        {
            if (this.debiter(s))
            {
                c.crediter(s);
                return true;
            }
            return false;


        }






    }
}





