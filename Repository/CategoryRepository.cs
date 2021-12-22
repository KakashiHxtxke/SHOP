using SHOP.interfaces;
using SHOP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace SHOP.Repository
{
    public class CategoryRepository : IgamesCategory
    {

        private readonly AppDbContent appDbContent;

        public CategoryRepository(AppDbContent appDbContent)
        {
            this.appDbContent = appDbContent;
        }








        public IEnumerable<Category> ALLcategories => appDbContent.Category;
    }
}
