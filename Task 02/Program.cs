using System;
namespace OnlineStoreDiscounts
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter product price: ");
            double price = Convert.ToDouble(Console.ReadLine());

            List<Discount> discounts = new List<Discount>();
            discounts.Add(new StudentDiscount());
            discounts.Add(new SeasonalDiscount());
            discounts.Add(new PremiumMemberDiscount());

            Console.WriteLine("\n--- Discount Calculations ---");
            foreach (Discount d in discounts)
            {
                double finalPrice = d.CalculateDiscount(price);
                Console.WriteLine("Discount Type: " + d.GetType().Name);
                Console.WriteLine("Original Price: " + price + " | Final Price: " + finalPrice);
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }

    public class Discount
    {
        public virtual double CalculateDiscount(double price)
        {
            return price;
        }
    }

    public class StudentDiscount : Discount
    {
        public override double CalculateDiscount(double price)
        {
            return price * 0.90;
        }
    }

    public class SeasonalDiscount : Discount
    {
        public override double CalculateDiscount(double price)
        {
            return price * 0.85;
        }
    }

    public class PremiumMemberDiscount : Discount
    {
        public override double CalculateDiscount(double price)
        {
            return (price * 0.80) - 5.0;
        }
    }
}
