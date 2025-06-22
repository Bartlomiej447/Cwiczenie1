// See https://aka.ms/new-console-template for more information
using System;

namespace AplikacjaKonsolowa
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dane = { 1, 2, 3, 4, 5 };
            double srednia = ObliczSrednia(dane);
            Console.WriteLine("Średnia: " + srednia);
        }

        public static double ObliczSrednia(int[] liczby)
        {
            if (liczby == null || liczby.Length == 0)
                return 0;

            double suma = 0;
            foreach (int liczba in liczby)
            {
                suma += liczba;
            }

            return suma / liczby.Length;
        }
    }
}