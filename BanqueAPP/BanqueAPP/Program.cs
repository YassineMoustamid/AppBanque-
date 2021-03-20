using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanqueAPP
{
    class Program
    {
        static void Main(string[] args)
        {
           // string nom = Console.ReadLine();
            Client c1 = new Client("moustamid","yassine","oulfa casa ");
            Client c2 = new Client("mouad", "zaghloul", "oulfa casa ");
            MAD s1 = new MAD(8000);
            MAD s2 = new MAD(100);
            s1.afficher();
            Compte cc1 = new Compte(c2, s1);
            cc1.crediter(s1);
            cc1.debiter(s2);
            cc1.consulter();
            Compte_Epargne cpt = new Compte_Epargne(c1, s1,50);
            cpt.calculeinteret();
            
            cpt.consulter();
           
            Console.ReadKey();


        }
    }
}
