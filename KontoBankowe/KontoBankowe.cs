using System;
using System.Collections.Generic;
using System.Text;

namespace KontoNaMonety
{
    internal class KontoBankowe
    {
        public static int licznikKont = 0;

        

        private decimal _saldo = 0m;
        private string _numer; //generuje sie automaycznie

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
            }
        }
    }
}