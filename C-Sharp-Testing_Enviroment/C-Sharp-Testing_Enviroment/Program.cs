using System;


namespace C_Sharp_Testing_Enviroment
{
    class Program
    {
        static void Main()
        {
            int Eingabe = 0;
            while (Eingabe != 21)
            {
                Eingabe = AltersEingabe();
            }

            Console.WriteLine("Glückwunsch, du hast mein Alter erraten");
            Console.ReadKey();
           

        }
        static int AltersEingabe()       //Methode zur Alterseingabe
        {
                
                Console.Write("Wie alt bin ich? ");
                int alter = Convert.ToInt32(Console.ReadLine());
            
                return alter;
            
        }


    }


}
