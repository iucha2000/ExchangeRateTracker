using System.Net.Http.Json;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using ExchangeRateTracker.Models;
using ExchangeRateTracker.Utils;

namespace ExchangeRateTracker
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Welcome to exchange rate tracker!");
            Console.WriteLine("Choose any currency and get the latest exchange rate real time");

            Console.Write("Convert from: ");
            string fromCurrency = ValidationLogic.ValidateCurrency();

            Console.Write("Convert to: ");
            string toCurrency = ValidationLogic.ValidateCurrency();

            ResponseModel rate = await HttpRequestClass.SendHttpRequest(fromCurrency,toCurrency);
            await Console.Out.WriteLineAsync($"1 {fromCurrency} = {rate.Data[toCurrency].Value} {toCurrency}");
        }
    }
}