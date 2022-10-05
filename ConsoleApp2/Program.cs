using System;

namespace Uppgift_2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur lång är låten du vill spela? ");
            int minuter = int.Parse(Console.ReadLine());
            int sekunder = int.Parse(Console.ReadLine());
            sekunder = sekunder + minuter * 60;
            if (sekunder >= 165 & sekunder <= 240)
            {
                Console.WriteLine("Låten är i rätt tidsintervall ");
            }
            else
            {
                Console.WriteLine("Låten är i fel tidsintervall");
            }

        }
    }
}
