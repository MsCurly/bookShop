using bookShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bookShop.Services
{
    public interface ICategoryService
    {
        IList<Category> GetCategories();
    }
}
