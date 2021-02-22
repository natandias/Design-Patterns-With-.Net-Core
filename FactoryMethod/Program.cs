using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using FactoryMethod.Creator;
using FactoryMethod.ConcreteCreator;
using FactoryMethod.Product;

namespace FactoryMethod
{
    public class Program
    {
        public static void Main(string[] args)
        {
           CardFactory cardFactory = null;
           Console.Write("Type desired card type: ");

           string console = Console.ReadLine();
           
           switch(console.ToLower()) {
               default:
                break;
               case "gold":
                cardFactory = new GoldCardFactory(1000, 15);
                break;
               case "platinum":
                cardFactory = new PlatinumCardFactory(3000, 50);
                break;
           }

           CreditCard creditCard = cardFactory.SearchCreditCard();
           Console.WriteLine("\nYour new card details: \n");
           Console.WriteLine("Card type: {0}\n Card limit: {1}\n Annual Fee: {2}",
                creditCard.CardType, creditCard.CardLimit, creditCard.AnnualFee
           );
           Console.ReadKey();
        }

    }
}
