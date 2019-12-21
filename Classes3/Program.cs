using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes3
{
    class Program
    {
        private const int _tauxTVA = 20;
        public static int TauxTVA
        {
            get { return _tauxTVA; }
        }

        static void Main(string[] args)
        {
            Article article1 = new Article();
            Article article2 = new Article("RF002", "cadeau");
            Article article3 = new Article("RF002", "Bûche de noël", 25);
            Article article4 = new Article("RF003", "Sapin", 80);
            Article article5 = new Article(article3);

            article1.AfficherArticle();
            article2.AfficherArticle();
            article3.AfficherArticle();
            article4.AfficherArticle();
            article5.AfficherArticle();
            Console.ReadLine();
        }
    }
}
