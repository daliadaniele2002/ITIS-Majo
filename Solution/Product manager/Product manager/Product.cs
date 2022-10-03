using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product_manager
{
     abstract class Product
    {
        public string name { get; set; }
        public double price { get; set; }
        public int purchasedPieces { get; set; }

        public Product(string name, double price, int purchasedPieces)
        {
            this.name = name;
            this.price = price;
            this.purchasedPieces = purchasedPieces;
        }
    }
}
