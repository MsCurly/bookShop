using bookShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bookShop.Services
{
    public class FakeCategoryService : ICategoryService
    {
        public IList<Category> GetCategories()
        {
            return new List<Category>
            {
                new Category{Id = 1, Name = "Edebiyat"},
                new Category{Id = 2, Name = "Polisiye"},
            };
        }        
    }
}
