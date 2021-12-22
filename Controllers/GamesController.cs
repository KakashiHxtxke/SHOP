using Microsoft.AspNetCore.Mvc;
using SHOP.interfaces;
using SHOP.Models;
using SHOP.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SHOP.Controllers
{
    public class GamesController : Controller
    {
        private readonly Iallgames _allGames;
        private readonly IgamesCategory _allCategories;

        public GamesController(Iallgames iAllGames, IgamesCategory igamesCat)
        {
            _allGames = iAllGames;
            _allCategories = igamesCat;
        }

        [Route("Games/List")]
        [Route("Games/List/{category}")]
        public ViewResult List(string category)
        {
            string _category = category;
            IEnumerable<game> games = null;
            string gameCategory = "";
            if (string.IsNullOrEmpty(category))
            {
                games = _allGames.Games.OrderBy(i => i.id);
            }
            else
            {
                if (string.Equals("Online", category, StringComparison.OrdinalIgnoreCase))
                {
                    games = _allGames.Games.Where(i => i.Category.categoryName.Equals("Онлайн")).OrderBy(i => i.id);
                } else if (string.Equals("Offline", category, StringComparison.OrdinalIgnoreCase))
                {
                    games = _allGames.Games.Where(i => i.Category.categoryName.Equals("Офлайн")).OrderBy(i => i.id);
                }

                gameCategory = _category;


            }

            var gameObj = new GamesListVIewModel
            {
                allGames = games,
            gameCategory = gameCategory
            };

            ViewBag.Title = "Страница с играми";
           
            return View(gameObj);
        }


    }
}
