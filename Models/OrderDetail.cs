using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SHOP.Models
{
    public class OrderDetail
    {

        public int id { get; set; }

        public int orderID { get; set; }


        public int GameID { get; set; }


        public uint price { get; set; }


        public virtual game game { get; set; }


        public virtual Order order { get; set; }


      



    }
}
