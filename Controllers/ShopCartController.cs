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
    public class ShopCartController: Controller
    {

        private Iallgames _gameRep;
        private readonly ShopCart _shopCart;

        public ShopCartController(Iallgames gameRep,ShopCart shopCart)
        {
            _gameRep = gameRep;
            _shopCart = shopCart;
        }

        public ViewResult Index()
        {
            var items = _shopCart.getShopItems();
            _shopCart.listShopItems = items;

            var obj = new ShopCartViewModel
            {
                shopCart = _shopCart
            };
            return View(obj);

        }

        public RedirectToActionResult addToCart(int id)
        {
            var item = _gameRep.Games.FirstOrDefault(i => i.id == id);
            if(item != null)
            {
                _shopCart.AddToCart(item);
            }
            return RedirectToAction("Index");
        }

    }
}
