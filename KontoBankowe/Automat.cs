using System;
using System.Globalization;

namespace KontoNaMonety
{
    internal class Automat
    {
        private readonly decimal[] PrzyjmowaneMonety =
            { 0.5m, 1m, 2m, 5m, 0.20m, 0.10m };

        private readonly int[] MaksymalnaPojemnosc =
            { 3, 3, 3, 3, 3, 3 };

        private readonly int[] AktualnaIloscMonet =
            { 0, 0, 0, 0, 0, 0 };

        private int _iloscMonet;

        public bool Wrzucmonete(string wartoscMonety, KontoBankowe konto)
        {
            bool czyPoprawna = decimal.TryParse(
                wartoscMonety,
                CultureInfo.InvariantCulture,
                out decimal wartosc
            );

            if (!czyPoprawna)
            {
                Console.WriteLine("Nieudany odczyt.");
                return false;
            }

            for (int i = 0; i < PrzyjmowaneMonety.Length; i++)
            {
                if (wartosc == PrzyjmowaneMonety[i])
                {
                    if (AktualnaIloscMonet[i] >= MaksymalnaPojemnosc[i])
                    {
                        Console.WriteLine("Brak miejsca na monetę " + wartosc + " zł.");
                        return false;
                    }

                    konto.Wplac(wartosc);

                    AktualnaIloscMonet[i]++;
                    _iloscMonet++;

                    Console.WriteLine("Moneta przyjęta: " + wartosc + " zł");
                    return true;
                }
            }

            Console.WriteLine("Zła moneta.");
            return false;
        }

        public void WrzucMonety(string wartosciMonet, KontoBankowe konto)
        {
            string[] monety = wartosciMonet.Split(' ');

            int przyjete = 0;
            int zwrocone = 0;

            foreach (string moneta in monety)
            {
                bool wynik = Wrzucmonete(moneta, konto);

                if (wynik)
                {
                    przyjete++;
                }
                else
                {
                    zwrocone++;
                }
            }

            Console.WriteLine("Monety przyjęte: " + przyjete);
            Console.WriteLine("Monety zwrócone: " + zwrocone);

        }
    }
}