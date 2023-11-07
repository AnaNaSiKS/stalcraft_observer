using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stalcraft_observer
{
    public class Prices
    {
        public int Amount { get; set; }
        public long Price { get; set; }
        public DateTime Time { get; set; }
        public object? Additional { get; set; }

        public override string ToString()
        {
            return "Кол-во: " + Amount.ToString() + " Цена: " + Price.ToString() + " Время продажи: " + Time.ToString();
        }
    }
}
