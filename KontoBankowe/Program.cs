namespace KontoNaMonety
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Tworzenie konta
            KontoBankowe kontoBankowe = new KontoBankowe();

            //Console.WriteLine("Numer konta: " + kontoBankowe.Numer);

            // Tworzenie automatu do wpłat
            KontoBankowe konto1 = new KontoBankowe();
            Automat automat = new Automat();

            KontoBankowe konto2 = new KontoBankowe();
            KontoBankowe konto4 = new KontoBankowe();


            automat.Wrzucmonete("5", konto1);
            automat.Wrzucmonete("2", konto1);

            automat.Wrzucmonete("2", konto2);

            automat.Wrzucmonete("2", konto4);
            automat.Wrzucmonete("3", konto4);


            // Wyświetlamy stan konta (jeszcze nie zrobione)
            Console.WriteLine("Stan konta1: " + konto1.StanKonta() + " zł");
            Console.WriteLine("Stan konta2: " + konto2.StanKonta() + " zł");
            Console.WriteLine("Stan konta4: " + konto4.StanKonta() + " zł");
        }
    }
}
