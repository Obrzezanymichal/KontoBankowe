using System;
using System.Collections.Generic;
using System.Text;

namespace KontoBankowe
{
    internal class Automat
    {
        private int _iloscMonet;
        private readonly decimal[] _przyjmowaneMonety = new decimal[] { 5, 2, 1, 0.5m, 0.2m, 0.1m };

        public void WrzucMonete(KontoBankowe konto, string wartoscMonety)
        {
            //sprawdzamy czy monetete da sie wogole sparsowac na jakis decimal
            bool czyUdanyParse = decimal.TryParse(wartoscMonety, out decimal wartosc);

            if (!czyUdanyParse)
            {
                Console.WriteLine("Wrzucono niepoprwna monete.");
                return;
            }
            //srprwadz czy monety sa z zakresu -przyjmowaneMonety

            foreach (decimal nominal in _przyjmowaneMonety)
            {
                //jezeli tak, to zw9eksz saldo konta 
                if (wartoscMonety == nominal)
                {
                    konto.Saldo += nominal;
                    _iloscMonet++;
                }
            }
        





            //Console.WriteLine("wrzucono monete o wartosci: " + wartosc);
            //dodaj kwote do konta
            //konto.Saldo += wartoscMonety;
        }
    }
}
