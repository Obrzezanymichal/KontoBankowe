using System;
using System.Collections.Generic;
using System.Text;

namespace KontoNaMonety
{
    internal class KontoBankowe
    {
        public static int licznikKont = 0;

        

        private decimal _saldo = 0m;
        private string _numer;

        private List<decimal> _historiaWplat = new List<decimal>();
        public string Numer
        {
            get { return _numer; }
        }
        public KontoBankowe()
        {
            licznikKont++;
            _numer = licznikKont.ToString();
        }


        public decimal StanKonta()
        {
            return _saldo;
        }

        public void Wplac(decimal kwota)
        {
            if (kwota > 0)
            {
                _saldo += kwota;
                _historiaWplat.Add(kwota);
            }
        }
        public void HistoriaWplat()
        {
            Console.WriteLine("Liczba wpłat: " + _historiaWplat.Count);

            foreach (decimal kwota in _historiaWplat)
            {
                Console.WriteLine("Wpłacono: " + kwota + " zł");
            }
        }
    }
}