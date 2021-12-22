using SHOP.interfaces;
using SHOP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SHOP.Repository
{
    public class OrdersRepository : IAllOrders
    {
        private readonly AppDbContent appDBContent;
        private readonly ShopCart shopCart;


        public OrdersRepository(AppDbContent appDBContent, ShopCart shopCart)
        {
            this.appDBContent = appDBContent;
            this.shopCart = shopCart;
        }



        public void createOrder(Order order)
        {
            order.orderTime = DateTime.Now;
            appDBContent.Order.Add(order);
            

            var items = shopCart.listShopItems;

            foreach(var el in items)
            {
                var orderDetail = new OrderDetail()
                {
                    GameID = el.games.id, 
                    orderID = order.id,
                    price = el.games.price,
                };
                appDBContent.OrderDetail.Add(orderDetail);
            }
            
        }
    }
}
