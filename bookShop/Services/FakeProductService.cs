using bookShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bookShop.Services
{
    public class FakeProductService : IProductService
    {
        public void AddProduct(Product product)
        {
            throw new NotImplementedException();
        }

        public int EditProduct(Product product)
        {
            throw new NotImplementedException();
        }

        public Product GetProductById(int id)
        {
            throw new NotImplementedException();
        }
        public int RemoveProduct(Product product)
        {
            throw new NotImplementedException();
        }

        //Veri tabanından verileri çekecek metodu oluşturdum.
        public List<Product> GetProducts()
        {
            return new List<Product>
            {
                new Product{ Id = 1, Name = "Dünyaya Yön Veren Kadınlar", ImageUrl="https://i.dr.com.tr/cache/136x136-0/originals/0001904358001-1.jpg", Yazar = "Julia Pierpont", Çevirmen = "Senem İnal", Yayınevi = "İndigo Kitap",
                    Description = "Geçmişten günümüze, yaşam öyküleriyle en çarpıcı kadınları onurlandıran bu resimlendirilmiş derleme, hem kadınlara hem de erkeklere ilham verecek. ",
                    Price = 29.25M , Discount = 0.35 , Rating = 4.8 },

                new Product { Id = 2, Name = "Empedokles’in Dostları", ImageUrl="https://cdn.bkmkitap.com/empedoklesin-dostlari-7521080-51-K.jpg",Yazar = "Amin Maalouf", Çevirmen = "Ali Berktay", Yayınevi = "Yapı Kredi Yayınları",
                    Description = "Maalouf, Empedokles’in Dostları’nda bu kez geleceğe yönelik bir kurguyla dönüş yapıyor. Platon’un mağarasından çıkıp Empedokles’in Dostları’yla tanışmaya davet ediyor bizi. ",
                    Price = 19.60M, Discount = 0.30, Rating = 4.00 },

                new Product { Id = 3, Name = "Fahrennheit 451",ImageUrl="https://cdn.bkmkitap.com/fahrenheit-289854-6753245-28-K.jpg", Yazar = "Ray Bradbury", Çevirmen = "Senem İnal", Yayınevi = "İttihaki Yayınları",
                    Description = "Kitapların yakıldığı bir dünyayı hayal etmek bile istmezsiniz!",
                    Price = 29.25M, Discount = 0.35, Rating = 4.5 },

                new Product { Id = 4, Name = "Cesur Yeni Dünya",ImageUrl="https://cdn.bkmkitap.com/cesur-yeni-dunya-3776397-31-K.jpg", Yazar = "Aldous Huxley", Çevirmen = "Senem İnal", Yayınevi = "İttihaki Yayınları",
                    Description = "Distopik olan bu kitap acı gerçekleri yüzünüze vuruyor. ",
                    Price = 29.25M, Discount = 0.35, Rating = 4.8 },

                new Product { Id = 5, Name = "Şeker Portakalı",ImageUrl="https://cdn.bkmkitap.com/seker-portakali-346759-6430435-34-K.jpg", Yazar = "José Mauro de Vasconcelos", Çevirmen = "Senem İnal", Yayınevi = "Can Yayınları",
                    Description = "Geçmişten günümüze, yaşam öyküleriyle en çarpıcı kadınları onurlandıran bu resimlendirilmiş derleme, hem kadınlara hem de erkeklere ilham verecek. ",
                    Price = 29.25M, Discount = 0.35, Rating = 4.8 },

                new Product { Id = 6, Name = "Empati",ImageUrl="https://cdn.bkmkitap.com/empati-160644-6751706-16-K.jpg", Yazar = "Julia Pierpont", Çevirmen = "Senem İnal", Yayınevi = "April Yayıncılık",
                    Description = "Olasılızsızın yazarından efsane bir kitap daha. ",
                    Price = 39.25M, Discount = 0.5, Rating = 4.3 },

                new Product { Id = 7, Name = "Arsen Lüpen",ImageUrl="https://cdn.bkmkitap.com/ucurtma-avcisi-midi-boy-3842327-22-K.jpg", Yazar = "Khalid Huseini", Çevirmen = "Senem İnal", Yayınevi = "Everest Yayınları",
                    Description = "Hayatınızda çok fazla şey değiştirecek. ",
                    Price = 24.25M, Discount = 0.25, Rating = 4.8 },

                new Product { Id = 8, Name = "Uçurtma Avcısı",ImageUrl="https://i.dr.com.tr/cache/136x136-0/originals/0001904358001-1.jpg", Yazar = "Julia Pierpont", Çevirmen = "Senem İnal", Yayınevi = "İndigo Kitap",
                    Description = "Geçmişten günümüze, yaşam öyküleriyle en çarpıcı kadınları onurlandıran bu resimlendirilmiş derleme, hem kadınlara hem de erkeklere ilham verecek. ",
                    Price = 29.25M, Discount = 0.35, Rating = 4.8 },

                new Product{ Id = 9, Name = "Masumiyet Müzesi",ImageUrl="https://cdn.bkmkitap.com/masumiyet-muzesi-7524371-57-K.jpg", Yazar = "Orhan Pamuk", Çevirmen = "", Yayınevi = "Yapı Kredi Yayınları",
                    Description = "Geçmişten günümüze herkese ilhan verecek. ",
                    Price = 34.25M , Discount = 0.35 , Rating = 4.8 },

                new Product { Id = 8, Name = "Altıncı Koğuş",ImageUrl="https://cdn.bkmkitap.com/altinci-kogus-261867-7473395-26-K.jpg", Yazar = "Anton Çehov", Çevirmen = "Senem İnal", Yayınevi = "İş Bankası Kültür Yayınları",
                    Description = "Tek solukta okuyacaksınız. ",
                    Price = 29.25M, Discount = 0.35, Rating = 4.8 },
                new Product { Id = 8, Name = "Vezir Gambiti",ImageUrl="https://cdn.bkmkitap.com/vezir-gambiti-6437796-51-K.jpg", Yazar = "Julia Pierpont", Çevirmen = "Senem İnal", Yayınevi = "İndigo Kitap",
                    Description = "Geçmişten günümüze, yaşam öyküleriyle en çarpıcı kadınları onurlandıran bu resimlendirilmiş derleme, hem kadınlara hem de erkeklere ilham verecek. ",
                    Price = 29.25M, Discount = 0.35, Rating = 4.8 },
                new Product { Id = 8, Name = "Bilinmeyen Bir Kadının Mektubu",ImageUrl="https://cdn.bkmkitap.com/bilinmeyen-bir-kadinin-mektubu-stefan-zweig-7463156-38-K.jpg", Yazar = "Stephan Zweig", Çevirmen = "Senem İnal", Yayınevi = "İndigo Kitap",
                    Description = "Hayran kalacaksınız",
                    Price = 12.25M, Discount = 0.2, Rating = 4.2 },
                new Product { Id = 8, Name = "Dünyaya Yön Veren Kadınlar",ImageUrl="https://i.dr.com.tr/cache/136x136-0/originals/0001904358001-1.jpg", Yazar = "Julia Pierpont", Çevirmen = "Senem İnal", Yayınevi = "İndigo Kitap",
                    Description = "Geçmişten günümüze, yaşam öyküleriyle en çarpıcı kadınları onurlandıran bu resimlendirilmiş derleme, hem kadınlara hem de erkeklere ilham verecek. ",
                    Price = 29.25M, Discount = 0.35, Rating = 4.8 },
                new Product { Id = 8, Name = "Dünyaya Yön Veren Kadınlar",ImageUrl="https://i.dr.com.tr/cache/136x136-0/originals/0001904358001-1.jpg", Yazar = "Julia Pierpont", Çevirmen = "Senem İnal", Yayınevi = "İndigo Kitap",
                    Description = "Geçmişten günümüze, yaşam öyküleriyle en çarpıcı kadınları onurlandıran bu resimlendirilmiş derleme, hem kadınlara hem de erkeklere ilham verecek. ",
                    Price = 29.25M, Discount = 0.35, Rating = 4.8 },
                new Product { Id = 8, Name = "Dünyaya Yön Veren Kadınlar",ImageUrl="https://i.dr.com.tr/cache/136x136-0/originals/0001904358001-1.jpg", Yazar = "Julia Pierpont", Çevirmen = "Senem İnal", Yayınevi = "İndigo Kitap",
                    Description = "Geçmişten günümüze, yaşam öyküleriyle en çarpıcı kadınları onurlandıran bu resimlendirilmiş derleme, hem kadınlara hem de erkeklere ilham verecek. ",
                    Price = 29.25M, Discount = 0.35, Rating = 4.8 },new Product { Id = 8, Name = "Dünyaya Yön Veren Kadınlar",ImageUrl="https://i.dr.com.tr/cache/136x136-0/originals/0001904358001-1.jpg", Yazar = "Julia Pierpont", Çevirmen = "Senem İnal", Yayınevi = "İndigo Kitap",
                    Description = "Geçmişten günümüze, yaşam öyküleriyle en çarpıcı kadınları onurlandıran bu resimlendirilmiş derleme, hem kadınlara hem de erkeklere ilham verecek. ",
                    Price = 29.25M, Discount = 0.35, Rating = 4.8 },new Product { Id = 8, Name = "Dünyaya Yön Veren Kadınlar",ImageUrl="https://i.dr.com.tr/cache/136x136-0/originals/0001904358001-1.jpg", Yazar = "Julia Pierpont", Çevirmen = "Senem İnal", Yayınevi = "İndigo Kitap",
                    Description = "Geçmişten günümüze, yaşam öyküleriyle en çarpıcı kadınları onurlandıran bu resimlendirilmiş derleme, hem kadınlara hem de erkeklere ilham verecek. ",
                    Price = 29.25M, Discount = 0.35, Rating = 4.8 },
                new Product { Id = 8, Name = "Dünyaya Yön Veren Kadınlar",ImageUrl="https://i.dr.com.tr/cache/136x136-0/originals/0001904358001-1.jpg", Yazar = "Julia Pierpont", Çevirmen = "Senem İnal", Yayınevi = "İndigo Kitap",
                    Description = "Geçmişten günümüze, yaşam öyküleriyle en çarpıcı kadınları onurlandıran bu resimlendirilmiş derleme, hem kadınlara hem de erkeklere ilham verecek. ",
                    Price = 29.25M, Discount = 0.35, Rating = 4.8 },
                new Product { Id = 8, Name = "Dünyaya Yön Veren Kadınlar",ImageUrl="https://i.dr.com.tr/cache/136x136-0/originals/0001904358001-1.jpg", Yazar = "Julia Pierpont", Çevirmen = "Senem İnal", Yayınevi = "İndigo Kitap",
                    Description = "Geçmişten günümüze, yaşam öyküleriyle en çarpıcı kadınları onurlandıran bu resimlendirilmiş derleme, hem kadınlara hem de erkeklere ilham verecek. ",
                    Price = 29.25M, Discount = 0.35, Rating = 4.8 },
                
               
            };
        }

        public List<Product> GetProductsByCategoryId(int categoryId)
        {
            throw new NotImplementedException();
        }

        
    }
}
