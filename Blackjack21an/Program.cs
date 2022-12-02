using System;

namespace blackjack21an
{
    class Program
    {
        static void Main(string[] args)
        {
          
            Console.WriteLine("Välkommen till menyn! Välj ett av följande alternativ");
            Console.WriteLine("1. Spela Blackjack");
            Console.WriteLine("2. ");

            int meny = int.Parse(Console.ReadLine());

            switch (meny)
            {
                case 1:
                    Random slump = new Random();
                    int spelarenspoäng = 0;
                    int Datornspoäng = 0;   


                    Console.WriteLine("Huset dra ett kort till dig och ett till sig själv");
                    Console.WriteLine("\nDitt kort är värt " + (spelarenspoäng += slump.Next(1, 11)));
                    Console.WriteLine("\nDatorn kort är värt " + (Datornspoäng += slump.Next(1, 11)));

                    Console.WriteLine("\nSpelarens poäng: " + spelarenspoäng);
                    Console.WriteLine("Datorns poäng: " + Datornspoäng);
                    break; 

                    





            }


        }
    }
}