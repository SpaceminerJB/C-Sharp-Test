using System;

namespace Vending_Machine
{
    class Program
    {
        static void Main(string[] args)
        {
            //Array mit Fülltypen + Preise
            string[,] Inhalt = new string[3, 2]
            {
                {"1: Cola","1,20 Euro"},
                {"2: Fanta","1,20 Euro"},
                {"3: Wasser","1,00 Euro"}
            };


            double PreisC = 1.2;
            double PreisF = 1.2;
            double PreisW = 1;

            //Verkaufangebot projezieren
            foreach (string i in Inhalt)
            {
                Console.WriteLine(i);

            }
            Console.WriteLine("\nBitte wählen sie eine Nummer");
            int Eingabe = Convert.ToInt32(Console.ReadLine());

            
            Console.ReadKey();
            //Bezahlvorgang
        }
    }
}
