using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SHOP.interfaces;
using SHOP.Models;
using SHOP.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace SHOP.Controllers
{
    public class HomeController: Controller
    {
        private Iallgames _gameRep;
        

        public HomeController(Iallgames gameRep)
        {
            _gameRep = gameRep;
            
        }

        public ViewResult Index()
        {
            var homeGames = new HomeViewModel
            {
                favGames = _gameRep.getFavgames
            };
            return View(homeGames);
        }

    }
}
