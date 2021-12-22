using System.Collections.Generic;
using SHOP.Models;

namespace SHOP.ViewModels
{
    public class GamesListVIewModel
    {
        public IEnumerable<game> allGames { get; set; }

        public string gameCategory { get; set; }
    }
}
