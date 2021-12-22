using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace SHOP.Models
{
    public class ShopCart
    {

        private readonly AppDbContent appDbContent;

        public ShopCart(AppDbContent appDbContent)
        {
            this.appDbContent = appDbContent;
        }

        public string ShopCartId { get; set; }
        public List<ShopCartItem> listShopItems { get; set; }

        public static ShopCart GetCart(IServiceProvider services)
        {
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;
            var context = services.GetService<AppDbContent>();
            string shopCartId = session.GetString("CartId") ?? Guid.NewGuid().ToString();

            session.SetString("CartId", shopCartId);

            return new ShopCart(context) { ShopCartId = shopCartId };
        }
        public void AddToCart(game games)
        {
            appDbContent.ShopCartItem.Add(new ShopCartItem
            {ShopCartId = ShopCartId,
            games = games,
            price = games.price
            });
            appDbContent.SaveChanges();

        }

        public List<ShopCartItem> getShopItems()
        {
            return appDbContent.ShopCartItem.Where(c => c.ShopCartId == ShopCartId).Include(s => s.games).ToList();
        }

    }
}
