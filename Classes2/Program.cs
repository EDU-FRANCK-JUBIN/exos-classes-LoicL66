using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes2
{
    class Program
    {
        private static int _indexCompte = 1;

        public static int IndexCompte
        {
            get { return _indexCompte; }
            set { _indexCompte = value; }
        }


        static void Main(string[] args)
        {
            Client client1 = new Client("61qsd16a8z4dqs", "Loïc", "LABEDE", "0600000001");
            Compte compte1 = new Compte(client1);
            Compte compte2 = new Compte(client1);
            
            //Créditer le compte 1 avec 750 euros
            compte1.Crediter(750);
            compte1.ObtenirInfosCompte();

            //Créditer le compte 2 avec 100 euros
            compte2.Crediter(100);
            compte2.ObtenirInfosCompte();

            //Prendre 100 euros du compte 1 pour créditer le compte 2
            compte2.Crediter(compte1, 100);
            compte1.ObtenirInfosCompte();
            compte2.ObtenirInfosCompte();

        }

    }
}
