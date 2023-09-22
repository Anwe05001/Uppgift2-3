using System;

namespace Uppgift3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hej, hur långt ska du åka?");
            string Sträcka = Console.ReadLine();
            Console.WriteLine("Okej hur länge ska ni ha bilen?");
            string Tid = Console.ReadLine();
            int dagar = int.Parse(Tid);
            int Kilometer = int.Parse(Sträcka);
            int dagspris = (dagar - 1) * 500;
            int köpavgift = +300;
            int Total = dagspris + köpavgift + Kilometer;
            Console.WriteLine("Då blir det " + Total + " kronor, låter det bra?");
        }
    }
}