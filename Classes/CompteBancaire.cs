using System;

namespace Classes
{
    class CompteBancaire
    {

        private string _titulaire;
        private int _nombreCompte;
        private double _solde;
        private string _devise;

        public CompteBancaire(string titulaire, int nombreCompte, double solde, string devise)
        {
            this._titulaire = titulaire;
            this._nombreCompte = nombreCompte;
            this._solde = solde;
            this._devise = devise;
        }

        public string Titulaire { get => _titulaire; set => _titulaire = value; }
        public int NombreCompte { get => _nombreCompte; set => _nombreCompte = value; }
        public double Solde { get => _solde; set => _solde = value; }
        public string Devise { get => _devise; set => _devise = value; }


        public void Crediter(double montant)
        {
            this._solde += montant;
            Console.WriteLine("Instruction réussie, compte crédité de " + montant + this._devise + " !");


        }
        public void Debiter(double montant)
        {
            this._solde -= montant;
            Console.WriteLine("Instruction réussie, compte débité de " + montant + this._devise + " !");
        }

        public String Decrire()
        {
            return "Le compte appartient à " + this._titulaire + " et contient " + this._solde + " " + this._devise + " !";
        }
    }
}
