using System;

namespace Rekurencja
{
    class Rekurencja
    {
        public static bool CheckIfNumberIsPrimeNumber(int number)
        {
            int i = 3;
            i += 2;
            if (number == 0) return false;
            if (number == 1) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;
            if (number % 3 == 0) return false;
            if (number % i == 0) return false;

            var squareRoot = Math.Sqrt(number);
            
            if (i <= squareRoot) return false;

            return true;  
        }
        static void Main(string[] args)
        {
            start:
            string retry = "n";
            
            Console.Clear();
            Console.WriteLine("Podaj liczbę do spradzenia");
            int operation = int.Parse(Console.ReadLine());

            if (CheckIfNumberIsPrimeNumber(operation))
            Console.WriteLine("Prawda");
            else
            Console.WriteLine("Fałsz");

            Console.WriteLine("Uruchomić program ponownie? t/n");
            retry = Console.ReadLine();
            if (retry == "t")
            {
                goto start;
            }
            Console.ReadKey();
        }
    }
}