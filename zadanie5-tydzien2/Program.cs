using System;

namespace zadanie5_tydzien2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadanie 5, tydzień 2.");
            Console.WriteLine("Proszę, podaj swoje imię:");
            string imię = Console.ReadLine();
          
            Console.WriteLine("Podaj swoje nazwisko");
            string nazwisko = Console.ReadLine();
            Console.WriteLine("Podaj swój wiek");
            byte wiek = byte.Parse(Console.ReadLine());
            Console.WriteLine("Podaj swój numer PESEL");
            long pesel = long.Parse(Console.ReadLine());
            Console.WriteLine("Napisz swoją wagę - w kg");
            double waga = double.Parse(Console.ReadLine());
            Console.WriteLine("Napisz, ile masz cm wzrostu");
            byte wzrost = byte.Parse(Console.ReadLine());
            Console.WriteLine("Podaj płeć - M lub K");
            char płeć = char.Parse(Console.ReadLine());
            Console.WriteLine("Podaj adres email");
            string email = Console.ReadLine();
            Console.WriteLine("Napisz miejscowość zamieszkania");
            string miejscowość = Console.ReadLine();

            




            

        }
    }
}
