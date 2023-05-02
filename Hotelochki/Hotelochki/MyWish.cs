using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotelochki
{
    [Serializable]
    internal class MyWish
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public Bitmap Picture { get; set; }
        public int Price { get; set; }

        public MyWish() { }
        public MyWish(string name, string description, int price)
        {
            Name = name;
            Description = description;
            Price = price;
        }

        public override string ToString()
        {
            return $"{Name} - {Description} ({Price})";
        }
    }
}
