using bookShop.Data;
using bookShop.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bookShop.Services
{
    public class ProductService : IProductService
    {
        private bookShopDbContext dbContext;

        public ProductService(bookShopDbContext dbContext )
        {
            this.dbContext = dbContext;
        }

        public void AddProduct(Product product)
        {
            dbContext.Products.Add(product);
            dbContext.SaveChanges();
        }

        public int EditProduct(Product product)
        {
            dbContext.Entry(product).State = EntityState.Modified;
            return dbContext.SaveChanges();
        }

       

        public Product GetProductById(int id)
        {
            return dbContext.Products.AsNoTracking().Include(x=>x.Category).FirstOrDefault(x => x.Id == id);
        }

        public List<Product> GetProducts()
        {
            var products = dbContext.Products.AsNoTracking().ToList();
            return products;
        }
            
        public List<Product> GetProductsByCategoryId(int categoryId)
        {
            return dbContext.Products.AsNoTracking().Where(p => p.CategoryId == categoryId).ToList();
        }

        public int RemoveProduct(Product product)
        {
            dbContext.Products.Remove(product);
            return dbContext.SaveChanges();

        }
    }
}
