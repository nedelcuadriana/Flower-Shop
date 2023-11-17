﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProiectAe.Data;

#nullable disable

namespace ProiectAe.Migrations
{
    [DbContext(typeof(FlowerShopDbContext))]
    [Migration("20231115150552_SeedProductsTable")]
    partial class SeedProductsTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.25")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ProiectAe.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Detail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsTrendingProduct")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Detail = "Un buchet de hortensii are o semnificatie speciala. Pe langa dragoste, florile sunt un simbol al recunostintei. La solicitare, aranjamentul poate fi insotit de o felicitare Gratuita.",
                            ImageUrl = "https://okflora.r.worldssl.net/files/getfilecdn/17068/whatsapp-image-2020-06-18-at-19.30.36.1-w445-h445.webp",
                            IsTrendingProduct = true,
                            Name = "Buchet din Hortensii (5 fire)",
                            Price = 295m
                        },
                        new
                        {
                            Id = 2,
                            Detail = "Buchet din 15 trandafiri albi poate fi surpriza care sa incante persoana draga. Compus din 15 trandafiri Olanda Ecuador de culoare alba cu dimensiune 40-60 cm, ambalat cu hartie neagra cartonata si decorat cu panglica de satin alba.",
                            ImageUrl = "https://okflora.r.worldssl.net/files/getfilecdn/10465/img_5756-w445-h445.jpeg",
                            IsTrendingProduct = true,
                            Name = "Buchet din Trandafiri Albi (15 fire)",
                            Price = 255m
                        },
                        new
                        {
                            Id = 3,
                            Detail = "Daruieste-i flori cu ocazie sau fara, si nu te va uita niciodata.La solicitare, aranjamentul poate fi insotit de o felicitare Gratuita.",
                            ImageUrl = "https://okflora.r.worldssl.net/files/getfilecdn/9112/3945-w445-h445.jpeg",
                            IsTrendingProduct = true,
                            Name = "Buchet din Lalele Albe (25 fire)",
                            Price = 350m
                        },
                        new
                        {
                            Id = 4,
                            Detail = "Buchetul va contine 9 lisianthus roz, hartie roz alba si panglica de satin. Comanda online buchete lisianthus cu livrare gratuita in Bucuresti.",
                            ImageUrl = "https://okflora.r.worldssl.net/files/getfilecdn/13216/img_4591-w445-h445.jpeg",
                            IsTrendingProduct = true,
                            Name = "Buchet din Lisianthus Roz (9 fire)",
                            Price = 216m
                        },
                        new
                        {
                            Id = 5,
                            Detail = "La solicitare, aranjamentul poate fi insotit de o felicitare Gratuita.",
                            ImageUrl = "https://okflora.r.worldssl.net/files/getfilecdn/9532/4389-w445-h445.jpeg",
                            IsTrendingProduct = true,
                            Name = "Buchet din Irisi (25 fire)",
                            Price = 250m
                        },
                        new
                        {
                            Id = 6,
                            Detail = "Buchetul din imagine conține 51 garoafe roz ambalat în hârtie coreeană roz, tish verde și decorat cu panglică de satin verde crem.",
                            ImageUrl = "https://okflora.r.worldssl.net/files/getfilecdn/25814/garoafe-roz-49-2-w445-h445.jpeg",
                            IsTrendingProduct = true,
                            Name = "Buchet din garoafe roz (51 fire)",
                            Price = 459m
                        },
                        new
                        {
                            Id = 7,
                            Detail = "Buchet din 9 Floarea Soarelui - amintirea unei zile perfecte de vara. Buchetul este format din floarea soarelui, hartie decorativa si panglica de satin.",
                            ImageUrl = "https://okflora.r.worldssl.net/files/getfilecdn/24338/e7983ab8-a75c-4eb0-9c9d-ec9944893bc3-w445-h445.jpeg",
                            IsTrendingProduct = true,
                            Name = "Buchet din Floarea Soarelui (9 fire)",
                            Price = 126m
                        },
                        new
                        {
                            Id = 8,
                            Detail = "Acest Buchet din Dalii Galbene poate fi surpriza care să încânte persoana dragă. Buchetul este compus din 19 dalii galbene, ambalat în hârtie coreeană crem și decorat cu panglică de satin crem.",
                            ImageUrl = "https://okflora.r.worldssl.net/files/getfilecdn/28002/19-belo-zheltyh-georgin-v-bukete_5-w445-h445.jpeg",
                            IsTrendingProduct = true,
                            Name = "Buchet din Dalii Galbene",
                            Price = 247m
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
