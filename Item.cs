using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stalcraft_observer
{
    internal class Item
    {
        public string id { get; set; }
        public string name { get; set; }
        public string Class { get; set; }

        public Item(string id, string name, string Class)
        {
            this.name = name;
            this.id = id;   
            this.Class = Class;
        }
    }
}
