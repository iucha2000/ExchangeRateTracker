using ExchangeRateTracker.Models;
using Newtonsoft.Json;

namespace ExchangeRateTracker
{

    public class HttpRequestClass
    {
        private static readonly string apiKey = "cur_live_gVmeTxdtxzLspQsIyLLfqkCmekuRa9iqthuf9GA9";

        public static async Task<ResponseModel> SendHttpRequest(string fromCurrency, string toCurrency)
        {
            try
            {
                string url = $"https://api.currencyapi.com/v3/latest?apikey={apiKey}&currencies={toCurrency}&base_currency={fromCurrency}";
                using var client = new HttpClient();
                HttpResponseMessage response = await client.GetAsync(url);
                response.EnsureSuccessStatusCode();

                var content = await response.Content.ReadAsStringAsync();
                ResponseModel? responseModel = JsonConvert.DeserializeObject<ResponseModel>(content);
                return responseModel;
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine("\nException Caught!");
                Console.WriteLine("Message :{0} ", e.Message);
                return null;
            }
        }
    }
}
