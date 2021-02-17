using bookShop.Data;
using bookShop.Models;
using bookShop.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bookShop.Controllers
{
    [Authorize(Roles ="Admin, Editor")]

    public class ProductsController : Controller
    {
        private IProductService productService;
        private ICategoryService categoryService;
       

        public ProductsController(IProductService productService, ICategoryService categoryService)
        {
            this.productService = productService;
            this.categoryService = categoryService;
        }
        public IActionResult Index()
        {
            var products = productService.GetProducts();
            return View(products);
        }

        //Dropdown' u çağırıyoruz
        public IActionResult Create()
        {
            //Bu kategorileri SelectListItem  dönüştürüp IENumerable olarak döndürmem gerekiyor
            List<SelectListItem> selectListItems = getCategoriesForSelect();

            ViewBag.Items = selectListItems;

            return View();
        }
        
        [HttpPost]

        public IActionResult Create(Product product)
        {
            if (ModelState.IsValid)
            {
                productService.AddProduct(product);
                return RedirectToAction(nameof(Index));
            }

            List<SelectListItem> selectListItems = getCategoriesForSelect();
            ViewBag.Items = selectListItems;
            return View();
        }

         public IActionResult Edit(int id)
        {
            var existingProduct = productService.GetProductById(id);
            if (existingProduct == null)
            {
                return NotFound();
            }
            ViewBag.Items = getCategoriesForSelect();
            return View(existingProduct);
        }

        [HttpPost]
        public IActionResult Edit(Product product)
        {
            if (ModelState.IsValid)
            {
               int affectedRowsCount = productService.EditProduct(product);
               string message = affectedRowsCount > 0 ? $"{product.Name} isimli ürün güncellendi :)" : "Ne yazık ki bir problem oluştu :(";

                return Json(message);
            }
            ViewBag.Items = getCategoriesForSelect();
            return View();

        }

        //Dropdowna kategorileri yüklemek için bu metodu çaığırıyor, ilk önce categoryService kategorileri çekiyor, getcategories metodunu çağırıp her bir kategorinin tamamını select list iteme çeçvirip namei text id si value olacaka şekilde viewbaga aktarıyor. 
        private List<SelectListItem> getCategoriesForSelect()
        {
            var categories = categoryService.GetCategories();
            List<SelectListItem> selectListItems = new List<SelectListItem>();
            categories.ToList().ForEach(category => selectListItems.Add(new SelectListItem
            {
                Text = category.Name,
                Value = category.Id.ToString()
            }));
            return selectListItems;
        }

        public IActionResult Details(int id)
        {
            var existingProduct = productService.GetProductById(id);
            if (existingProduct == null)
            {
                return NotFound();
            }
            Product product = productService.GetProductById(id);
            if (product == null)
            {
                return NotFound();
            }

            ViewBag.Items = getCategoriesForSelect();
            return View(existingProduct);
        }

        public IActionResult Delete(int id)
        {
            var existingProduct = productService.GetProductById(id);
            if (existingProduct == null)
            {
                return NotFound();
            }
            Product product = productService.GetProductById(id);
            if (product == null)
            {
                return NotFound();
            }

            ViewBag.Items = getCategoriesForSelect();
            return View(existingProduct);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            Product product = productService.GetProductById(id);
            productService.RemoveProduct(product);
            return RedirectToAction(nameof(Index));

        }

    }
}

