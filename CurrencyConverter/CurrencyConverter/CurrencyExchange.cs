using CurrencyConverter;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;

namespace CurrencyExchange
{
    public class Exchange
    {
        public List<Currency> currencies = new List<Currency>()
        {
            new Currency("polski złoty", "PLN", 1.00),
            new Currency("euro", "EUR", 4.19),
            new Currency("dolar amerykański", "USD", 3.62),
            new Currency("frank szwajcarski", "CHF", 4.55)
        };

        public Exchange()
        {
            GetFromAPI();
        }

        public double ToPLN(double amount, Currency from)
        {
            return amount * from.Rate;
        }

        public Currency? GetFromCode(string code)
        {
            Currency? currency = currencies.Find(c => c.Code == code);
            if (currency == null) throw new Exception("Nie znaleziono waluty o podanym kodzie");
            return currency;
        }

        public void GetFromAPI()
        {
            string json;
            using (HttpClient client = new HttpClient())
            {
                json = client.GetStringAsync("https://api.nbp.pl/api/exchangerates/tables/A/").Result;
            }
            APIResponse response = JsonConvert.DeserializeObject<APIResponse[]>(json)[0];

            foreach (Rate rate in response.rates)
            {
                Currency? currency = currencies.Find(c => c.Code == rate.code);
                if (currency != null)
                {
                    currency.Rate = rate.mid;
                }
                else
                {
                    currencies.Add(new Currency(rate.currency, rate.code, rate.mid));
                }
            }
        }
    }
}