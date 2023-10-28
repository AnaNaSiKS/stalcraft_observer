using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace stalcraft_observer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private async void ButtonGetHistory_Click(object sender, RoutedEventArgs e)
        {
            List<Prices> Prices = new List<Prices>();
            string  body = await HTTPrequest.get("y1q9");
            var pricesListing = JsonConvert.DeserializeObject<PricesListing>(body);

            foreach (Prices prices in pricesListing.prices)
            {
                Prices.Add(prices);
            }

            ShowRequest showRequest = new ShowRequest(Prices);
            showRequest.Show();
        }
    }
}
