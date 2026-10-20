using System.Runtime.InteropServices;

namespace KontoBankowe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //tworzenie konta
            KontoBankowe kontoBankowe = new KontoBankowe();

            //tworzenie automatu do wplat
            Automat automat = new Automat();

            automat.WrzucMonete(kontoBankowe, "0.5");

            Console.WriteLine(kontoBankowe.StanKonta());
        }
    }
}
