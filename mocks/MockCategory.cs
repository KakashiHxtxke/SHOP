using SHOP.interfaces;
using SHOP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SHOP.mocks
{
    public class MockCategory : IgamesCategory { 
    
        public IEnumerable<Category> ALLcategories { 
            get
            {
                return new List<Category>
                {
                    new Category {categoryName = "Онлайн", desc = "Компьютерная игра, использующая постоянное соединение с Интернетом"},
                    new Category {categoryName = "Офлайн", desc = "компьютерная игра, не требующая постоянное соединение с Интернетом"}
                };
            }

        }
    }
    

    
}
