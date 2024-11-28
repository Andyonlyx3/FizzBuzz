using System.Security.Principal;

namespace FizzBuzz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Erstellen Sie einen Algorithmus der das Spiel FizzBuzz bis zur 100 durchführt.
            //Regeln siehe https://de.wikipedia.org/wiki/Fizz_buzz.

            //Modulo gibt uns den Rest einer Division als Ganzzahl zurück. Das Zeichen für den Operanten ist %
            //Beispiel: 4 % 2 = 0
            Console.ForegroundColor = ConsoleColor.Green;
            for (int i = 1; i <= 100; i++)
            {
                if (i % 15 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                    Thread.Sleep(1000);
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                    Thread.Sleep(1000);
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz"); 
                    Thread.Sleep(1000);
                }
                else
                {
                    Console.WriteLine(i);
                    Thread.Sleep(1000);
                }
            }
        }
    }
}
