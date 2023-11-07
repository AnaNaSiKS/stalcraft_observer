using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace stalcraft_observer
{
    class ItemsHelper
    {
        public static PricesListing? DeserializePricesListing(string body) {
            var pricesListing = JsonConvert.DeserializeObject<PricesListing>(body);
            return pricesListing;
        }

        public static List<Prices>? GetPricesFromPricesListing(PricesListing listing){
            List<Prices> Prices = new List<Prices>();
            
            foreach (Prices prices in listing.prices)
            {
                Prices.Add(prices);
            }
            
            return Prices;
        }

        public static async void ShowPrices(string name) {
            try
            {
                List<Prices>? Prices = new List<Prices>();
                string body = await HTTPrequest.get(name);
                var pricesListing = ItemsHelper.DeserializePricesListing(body);

                Prices = ItemsHelper.GetPricesFromPricesListing(pricesListing);

                ShowRequest showRequest = new ShowRequest(Prices);
                showRequest.Show();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
