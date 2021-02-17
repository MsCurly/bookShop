using bookShop.Models;
using bookShop.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace bookShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private IProductService service;
        public HomeController(ILogger<HomeController> logger, IProductService service )
        {            
            _logger = logger;
            this.service = service;
        }

        // int page ile linkten tıkladığımız sayfa buraya gelir, catid = 0 çünkü sayfa ilk açıldığı zaman kategori seçmemiş oluyoruz
        public IActionResult Index(int page=1, int catid=0)
        {
            var pageSize = 4;
            var products = catid == 0 ? service.GetProducts() : service.GetProductsByCategoryId(catid);
            var pagingProducts = products.OrderBy(p => p.Id)
                                         .Skip((page - 1) * pageSize)
                                         .Take(pageSize);

            //ViewBag, Controller'da oluşturulan bir yapıyı View kısmına taşımak için kullanılır.
            ViewBag.CatId = catid;

            var totalProduct = products.Count;         
            var totalPage = Math.Ceiling((decimal)totalProduct / pageSize);
            ViewBag.TotalPages = totalPage;
            return View(pagingProducts);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
