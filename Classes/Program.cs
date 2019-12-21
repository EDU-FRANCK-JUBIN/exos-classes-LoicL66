using System;

namespace Classes
{
    class Program
    {
        public static void Main()
        {
            var compte = new CompteBancaire("Bob", 1, 753.35, "euro.s");
            Console.WriteLine(compte.Decrire());
            Console.ReadLine();

            compte.Crediter(50);
            Console.ReadLine();

            compte.Debiter(25);
            Console.ReadLine();
        }
    }
}
