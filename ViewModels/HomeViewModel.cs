using SHOP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SHOP.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<game> favGames { get; set; }
    }
}
