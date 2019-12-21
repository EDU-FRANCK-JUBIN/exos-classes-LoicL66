using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes2
{
    class Compte
    {

        private int _codeCompte;
        private double _solde;
        private Client _proprietaire;

        public Compte(Client proprietaire)
        {
            this._codeCompte = Program.IndexCompte;
            Program.IndexCompte++;
            this._solde = 0;
            this._proprietaire = proprietaire;
        }

        public Client Proprietaire
        {
            get { return _proprietaire; }
            set { _proprietaire = value; }
        }

        public double Solde
        {
            get { return _solde; }
            set { _solde = value; }
        }

        public int CodeCompte
        {
            get { return _codeCompte; }
            set { _codeCompte = value; }
        }

        public void Crediter(double montant)
        {
            this._solde += montant;
        }

        public void Crediter(Compte compte, double montant)
        {
            compte.Debiter(montant);
            this._solde += montant;
        }
        public void Debiter(double montant)
        {
            this._solde -= montant;
        }
        public void Debiter(Compte compte, double montant)
        {
            compte.Crediter(montant);
            this._solde -= montant;
        }

        public void ObtenirInfosCompte()
        {
            Console.WriteLine("=-=-=-=-= Compte n°"+ this._codeCompte +" =-=-=-=-=");
            Console.WriteLine("Solde actuel : " + this.Solde);
            Console.WriteLine("Propriétaire : " + this._proprietaire.Prenom + " " + this._proprietaire.Prenom);
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            Console.ReadLine();
        }

        public int ObtenirNombreTotalCompte()
        {
            return Program.IndexCompte;
        }

    }
}
