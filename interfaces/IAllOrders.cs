using SHOP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SHOP.interfaces
{
   public interface IAllOrders
    {
        void createOrder(Order order);
    }
}
