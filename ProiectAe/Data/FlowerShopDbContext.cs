using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ProiectAe.Models;

namespace ProiectAe.Data
{
    public class FlowerShopDbContext : IdentityDbContext
    {
        public FlowerShopDbContext(DbContextOptions<FlowerShopDbContext>options) : base(options)
        {

        }

        public DbSet<Product> Products { get; set; }
        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Product>().HasData(

                new Product { Id = 1, Name = "Buchet din Hortensii (5 fire)", Detail = "Un buchet de hortensii are o semnificatie speciala. Pe langa dragoste, florile sunt un simbol al recunostintei. La solicitare, aranjamentul poate fi insotit de o felicitare Gratuita.", Price = 295, IsTrendingProduct = true, ImageUrl = "https://okflora.r.worldssl.net/files/getfilecdn/17068/whatsapp-image-2020-06-18-at-19.30.36.1-w445-h445.webp" },
                new Product { Id = 2, Name = "Buchet din Trandafiri Albi (15 fire)", Detail = "Buchet din 15 trandafiri albi poate fi surpriza care sa incante persoana draga. Compus din 15 trandafiri Olanda Ecuador de culoare alba cu dimensiune 40-60 cm, ambalat cu hartie neagra cartonata si decorat cu panglica de satin alba.", Price = 255, IsTrendingProduct = true, ImageUrl = "https://okflora.r.worldssl.net/files/getfilecdn/10465/img_5756-w445-h445.jpeg" },
                new Product { Id = 3, Name = "Buchet din Lalele Albe (25 fire)", Detail = "Daruieste-i flori cu ocazie sau fara, si nu te va uita niciodata.La solicitare, aranjamentul poate fi insotit de o felicitare Gratuita.", Price = 350, IsTrendingProduct = true, ImageUrl = "https://okflora.r.worldssl.net/files/getfilecdn/9112/3945-w445-h445.jpeg" },
                new Product { Id = 4, Name = "Buchet din Lisianthus Roz (9 fire)", Detail = "Buchetul va contine 9 lisianthus roz, hartie roz alba si panglica de satin. Comanda online buchete lisianthus cu livrare gratuita in Bucuresti.", Price = 216, IsTrendingProduct = true, ImageUrl = "https://okflora.r.worldssl.net/files/getfilecdn/13216/img_4591-w445-h445.jpeg" },
                new Product { Id = 5, Name = "Buchet din Irisi (25 fire)", Detail = "La solicitare, aranjamentul poate fi insotit de o felicitare Gratuita.", Price = 250, IsTrendingProduct = true, ImageUrl = "https://okflora.r.worldssl.net/files/getfilecdn/9532/4389-w445-h445.jpeg" },
                new Product { Id = 6, Name = "Buchet din garoafe roz (51 fire)", Detail = "Buchetul din imagine conține 51 garoafe roz ambalat în hârtie coreeană roz, tish verde și decorat cu panglică de satin verde crem.", Price = 459, IsTrendingProduct = true, ImageUrl = "https://okflora.r.worldssl.net/files/getfilecdn/25814/garoafe-roz-49-2-w445-h445.jpeg" },
                new Product { Id = 7, Name = "Buchet din Floarea Soarelui (9 fire)", Detail = "Buchet din 9 Floarea Soarelui - amintirea unei zile perfecte de vara. Buchetul este format din floarea soarelui, hartie decorativa si panglica de satin.", Price = 126, IsTrendingProduct = true, ImageUrl = "https://okflora.r.worldssl.net/files/getfilecdn/24338/e7983ab8-a75c-4eb0-9c9d-ec9944893bc3-w445-h445.jpeg" },
                new Product { Id = 8, Name = "Buchet din Dalii Galbene", Detail = "Acest Buchet din Dalii Galbene poate fi surpriza care să încânte persoana dragă. Buchetul este compus din 19 dalii galbene, ambalat în hârtie coreeană crem și decorat cu panglică de satin crem.", Price = 247, IsTrendingProduct = true, ImageUrl = "https://okflora.r.worldssl.net/files/getfilecdn/28002/19-belo-zheltyh-georgin-v-bukete_5-w445-h445.jpeg" }

                );
        }
    }
}
