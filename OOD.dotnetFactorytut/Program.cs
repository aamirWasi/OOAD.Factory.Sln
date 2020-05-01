using System;

namespace OOD.dotnetFactorytut
{
    public abstract class CreditCard
    {
        public string CardType { get; set; }
        public int CardLimit { get; set; }
        public int AnnualCharge { get; set; }
        public abstract void CreditDetails();
    }
    public class Platinum : CreditCard
    {
        public override void CreditDetails()
        {
            Console.WriteLine($"CardType : {CardType}\nCardLimit : {CardLimit}\nAnnualCharge : {AnnualCharge}");
        }
    }
    public class Titanium : CreditCard
    {
        public override void CreditDetails()
        {
            Console.WriteLine($"CardType : {CardType}\nCardLimit : {CardLimit}\nAnnualCharge : {AnnualCharge}");
        }
    }
    public class MoneyBack : CreditCard
    {
        public override void CreditDetails()
        {
            Console.WriteLine($"CardType : {CardType}\nCardLimit : {CardLimit}\nAnnualCharge : {AnnualCharge}");
        }
    }

    public static class CreditCardFactory
    {
        public static CreditCard CreditCard(string selection)
        {
            var cardType = Type.GetType("OOD.dotnetFactorytut." + selection);
            var constructor = cardType.GetConstructor(new Type[] { });
            var creditCard = (CreditCard)constructor.Invoke(new object[] { });
            creditCard.CardType = Console.ReadLine();
            creditCard.CardLimit = int.Parse(Console.ReadLine());
            creditCard.AnnualCharge = int.Parse(Console.ReadLine());
            return creditCard;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine();
                Console.WriteLine("Platinum");
                Console.WriteLine("Titanium");
                Console.WriteLine("MoneyBack");
                Console.WriteLine("Exit");
                Console.WriteLine();
                Console.Write("Select demo: ");
                string choice = Console.ReadLine();
                if (choice == "Exit")
                    exit = true;
                else
                {
                    var credit = CreditCardFactory.CreditCard(choice);
                    credit.CreditDetails();
                }
                Console.WriteLine();
                Console.WriteLine("Press 'Enter' for menu");
                Console.ReadLine();
                Console.Clear();
            }
        }
    }
}
