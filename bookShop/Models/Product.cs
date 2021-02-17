using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace bookShop.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "İsim kısmını boş bırakamazsınız")]
        [Display(Name = "Ürün Adı")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Yazar kısmını boş bırakamazsınız")]
        public string Yazar { get; set; }
        
        public string Çevirmen { get; set; }

        [Required(ErrorMessage = "Yayınevi kısmını boş bırakamazsınız")]
        public string Yayınevi { get; set; }

        [Display(Name = "Ürün Açıklaması")]
        public string Description { get; set; }

        [Display(Name = "Puan")]
        public double Rating { get; set; }

        [Required(ErrorMessage = "Fiyat kısmını boş bırakamazsınız")]
        [Display(Name = "Fiyat")]
        public decimal Price { get; set; }

        [Display(Name = "İndirim")]
        public double Discount { get; set; }

        [Display(Name = "Fotoğraf Uzantısı")]
        public string ImageUrl { get; set; }

        [Display(Name = "Kategori Seç")]
        public int  CategoryId { get; set; }
        public Category Category { get; set; }

    }
}
