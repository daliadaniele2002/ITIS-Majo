using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product_manager
{
    class Software : Product
    {
        public Software(string name, double price, int purchasedPieces) : base(name, price, purchasedPieces)
        {

        }
    }
}
