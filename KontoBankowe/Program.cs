namespace KontoNaMonety
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Tworzenie konta
            KontoBankowe kontoBankowe = new KontoBankowe();

            // Tworzenie automatu do wpłat
            KontoBankowe konto = new KontoBankowe();
            Automat automat = new Automat();

            automat.Wrzucmonete("5", konto);
            automat.Wrzucmonete("2", konto);


            // Wyświetlamy stan konta (jeszcze nie zrobione)
            Console.WriteLine("Stan konta: " + konto.StanKonta() + " zł");
        }
    }
}
