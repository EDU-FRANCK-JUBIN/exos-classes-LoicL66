using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes3
{
    public class Article
    {
        private string _reference;
        private string _designation;
        private double _prixHT;

        public string Reference
        {
            get { return _reference; }
            set { _reference = value; }
        }

        public string Designation
        {
            get { return _designation; }
            set { _designation = value; }
        }

        public double PrixHT
        {
            get { return _prixHT; }
            set { _prixHT = value; }
        }


        public Article() { }

        public Article(string reference, string designation, double prixHT)
        {
            this.Reference = reference;
            this.Designation = designation;
            this.PrixHT = prixHT;
        }

        public Article(string reference, string designation)
        {
            this.Reference = reference;
            this.Designation = designation;
        }

        public Article(Article articleToCopy)
        {
            this.Reference = articleToCopy.Reference;
            this.Designation = articleToCopy.Designation;
            this.PrixHT = articleToCopy.PrixHT;
        }


        public double CalculerPrixTTC()
        {
            double prixTTC = this.PrixHT + (this.PrixHT * Program.TauxTVA / 100);
            return prixTTC;
        }


        public void AfficherArticle()
        {
            Console.WriteLine("=-=-=-=-=-=-=-= Article =-=-=-=-=-=-=-=");
            Console.WriteLine("Référence : " + this.Reference);
            Console.WriteLine("Nom : " + this.Designation);
            Console.WriteLine("Prix HT : " + this.PrixHT);
            Console.WriteLine("TVA : " + Program.TauxTVA);
            Console.WriteLine("Prix TTC : " + this.CalculerPrixTTC());
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
        }
    }
}
