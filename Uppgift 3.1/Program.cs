using System;
namespace Uppgift3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur gammal är du?");
            int ålder = int.Parse(Console.ReadLine());

            if (ålder >= 16 && ålder <= 19)
            {
                Console.WriteLine("Du får delta i tävlingen.");
            }
            else if (ålder > 19)
            {
                Console.WriteLine("Du är för gammal för att delta.");
            }
            else
            {
                Console.WriteLine("Du är för ung för att delta.");
            }
            Console.ReadKey();

        }
    }
}