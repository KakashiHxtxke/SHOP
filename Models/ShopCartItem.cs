using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SHOP.Models
{
    public class ShopCartItem
    {
        public int id { get; set; }
        public game games { get; set; }
        public int price { get; set; }
        public string ShopCartId { get; set; }

    }
}
