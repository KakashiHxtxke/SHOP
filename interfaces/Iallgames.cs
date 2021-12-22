using SHOP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SHOP.interfaces
{
    public interface Iallgames
    {
        IEnumerable<game> Games { get; }

        IEnumerable<game> getFavgames { get; }

        game getObjectGame(int gameid);



    }
}
