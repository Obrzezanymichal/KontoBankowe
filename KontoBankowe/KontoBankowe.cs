using System;
using System.Collections.Generic;
using System.Text;

namespace KontoBankowe
{
    internal class KontoBankowe
    {
        private decimal _saldo = 0;
        private string _numer;

        public decimal Saldo
        {
            get { return _saldo; }
            set { _saldo = value; }
        }

        public KontoBankowe(string numer)
        {
            _numer = numer;
        }

        public void WrzucMonete(decimal kwota)
        {
            _saldo += kwota;
        }
    }
}
