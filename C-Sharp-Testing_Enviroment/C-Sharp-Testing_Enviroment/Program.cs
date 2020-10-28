using System;

namespace C_Sharp_Testing_Enviroment
{
    class Program
    {
        static void Main()
        {
            int x = 5;
            while (x == 5)
            {
                Alterseingabe();
            }
            Console.ReadKey();

        }
        static void Alterseingabe()
        {
                string alter;
                Console.Write("Bitte gib dein Alter ein: ");
                alter = Console.ReadLine();
                Console.WriteLine("Du bist " + alter + " Jahre alt.");
                
        }


    }


}
