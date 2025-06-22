// See https://aka.ms/new-console-template for more information
using System;

namespace AplikacjaKonsolowa
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dane = { 1, 5, 3, 9, 2 };

            double srednia = ObliczSrednia(dane);
            Console.WriteLine("Średnia: " + srednia);

            int maksimum = ZnajdzMaksimum(dane);
            Console.WriteLine("Maksimum: " + maksimum);
        }

        public static double ObliczSrednia(int[] liczby)
        {
            if (liczby == null || liczby.Length == 0)
                return 0;

            double suma = 0;
            foreach (int liczba in liczby)
            {
                suma += number;
            }

            return suma / liczby.Length;
        }

        public static int ZnajdzMaksimum(int[] liczby)
        {
            if (liczby == null || liczby.Length == 0)
                throw new ArgumentException("Tablica nie może być pusta.");

            int maks = liczby[0];
            foreach (int liczba in liczby)
            {
                if (liczba > maks)
                    maks = liczba;
            }

            return maks;
        }
    }
}