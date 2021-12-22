using Microsoft.EntityFrameworkCore;
using SHOP.interfaces;
using SHOP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SHOP.Repository
{
    public class GameRepository : Iallgames
    {

        private readonly AppDbContent appDbContent;

        public GameRepository(AppDbContent appDbContent)
        {
            this.appDbContent = appDbContent;
        }






        public IEnumerable<game> Games => appDbContent.game.Include(c => c.Category);

        public IEnumerable<game> getFavgames => appDbContent.game.Where(p => p.isFavourite).Include(c => c.Category);

        public game getObjectGame(int gameid) => appDbContent.game.FirstOrDefault(p => p.id == gameid);
        
    }




}
