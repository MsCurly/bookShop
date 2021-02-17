using bookShop.Data;
using bookShop.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bookShop.Services
{
    public class CategoryService : ICategoryService
    {
        private bookShopDbContext dbContext;

        public CategoryService(bookShopDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public IList<Category> GetCategories()
        {
            return dbContext.Categories.AsNoTracking().ToList();
        }
    }
}
