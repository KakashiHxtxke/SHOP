using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SHOP.Models
{
    public class game
    {
        public int id { set; get; }


        public string name { set; get; }



        public string shortDesc { set; get; }



        public string longdesc{ set; get; }


        public string img { set; get; }


        public ushort price { set; get; }



        public bool isFavourite { set; get; }


        public bool avaible { set; get; }


        public int categoryid{ set; get; }


        public virtual Category Category { set; get; }



    }
}
