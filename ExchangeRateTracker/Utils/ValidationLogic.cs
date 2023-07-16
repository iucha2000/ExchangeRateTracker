using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExchangeRateTracker.Enums;

namespace ExchangeRateTracker.Utils
{
    public class ValidationLogic
    {
        public static string ValidateCurrency()
        {
            string? currency = Console.ReadLine();
            while (!Enum.IsDefined(typeof(Currencies), currency))
            {
                Console.Write("Please enter a valid currency code: ");
                currency = Console.ReadLine();
            }
            return currency;
        }
    }
}
