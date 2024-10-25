using AppPaiements;

internal class Program
{
    private static void Main(string[] args)
    {
       CarteCredit credit1 = new CarteCredit(" ttc" ,3.50 ,023876541 );
       CarteCredit credit2 = new CarteCredit(" macdoc", 10.90, 9865570);
       CarteCredit credit3 = new CarteCredit(" pizza", 45.28, 5097640);

        credit1.AfficherDetails();
        credit2.AfficherDetails();
        credit3.AfficherDetails();
    }
}