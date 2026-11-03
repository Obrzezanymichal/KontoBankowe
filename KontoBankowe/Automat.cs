using System;
using System.Globalization;
using KontoNaMonety;

namespace KontoNaMonety
{
    internal class Automat
    {
        private readonly decimal[] PrzyjmowaneMonety = { 0.5m, 1m, 2m, 5m, 0.20m, 0.10m };
        private int _iloscMonet;

        public void Wrzucmonete(string wartoscMonety, KontoBankowe konto)
        {
            bool czyPoprawna = decimal.TryParse(
                wartoscMonety,
                CultureInfo.InvariantCulture,
                out decimal wartosc
            );

            // Sprawdzamy, czy tekst jest liczbą
            if (!czyPoprawna)
            {
                Console.WriteLine("Nieudany odczyt.");
                return;
            }

            // Sprawdzamy, czy automat przyjmuje taki nominał
            foreach (decimal nominal in PrzyjmowaneMonety)
            {
                if (wartosc == nominal)
                {
                    konto.Wplac(nominal);
                    _iloscMonet++;

                    Console.WriteLine("Moneta przyjęta: " + nominal + " zł");
                    return;
                }
            }

            Console.WriteLine("Zła moneta.");
        }
    }
}