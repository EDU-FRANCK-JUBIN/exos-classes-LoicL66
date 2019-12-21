using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes2
{
    class Client
    {
        private string _cni;
        private string _nom;
        private string _prenom;
        private string _tel;

        public Client(string cni, string nom, string prenom, string tel)
        {
            this._cni = cni;
            this._nom = nom;
            this._prenom = prenom;
            this._tel = tel;
        }

        public Client(string cni, string nom, string prenom)
        {
            this._cni = cni;
            this._nom = nom;
            this._prenom = prenom;
        }

        public string Tel
        {
            get { return _tel; }
            set { _tel = value; }
        }


        public string Prenom
        {
            get { return  _prenom; }
            set {  _prenom = value; }
        }

        public string Nom
        {
            get { return _nom; }
            set { _nom = value; }
        }


        public string Cni
        {
            get { return _cni; }
            set { _cni = value; }
        }

        public string Afficher()
        {
            return ToString();
        }

    }
}
