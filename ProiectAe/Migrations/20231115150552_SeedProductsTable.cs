using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProiectAe.Migrations
{
    public partial class SeedProductsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Detail", "ImageUrl", "IsTrendingProduct", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "Un buchet de hortensii are o semnificatie speciala. Pe langa dragoste, florile sunt un simbol al recunostintei. La solicitare, aranjamentul poate fi insotit de o felicitare Gratuita.", "https://okflora.r.worldssl.net/files/getfilecdn/17068/whatsapp-image-2020-06-18-at-19.30.36.1-w445-h445.webp", true, "Buchet din Hortensii (5 fire)", 295m },
                    { 2, "Buchet din 15 trandafiri albi poate fi surpriza care sa incante persoana draga. Compus din 15 trandafiri Olanda Ecuador de culoare alba cu dimensiune 40-60 cm, ambalat cu hartie neagra cartonata si decorat cu panglica de satin alba.", "https://okflora.r.worldssl.net/files/getfilecdn/10465/img_5756-w445-h445.jpeg", true, "Buchet din Trandafiri Albi (15 fire)", 255m },
                    { 3, "Daruieste-i flori cu ocazie sau fara, si nu te va uita niciodata.La solicitare, aranjamentul poate fi insotit de o felicitare Gratuita.", "https://okflora.r.worldssl.net/files/getfilecdn/9112/3945-w445-h445.jpeg", true, "Buchet din Lalele Albe (25 fire)", 350m },
                    { 4, "Buchetul va contine 9 lisianthus roz, hartie roz alba si panglica de satin. Comanda online buchete lisianthus cu livrare gratuita in Bucuresti.", "https://okflora.r.worldssl.net/files/getfilecdn/13216/img_4591-w445-h445.jpeg", true, "Buchet din Lisianthus Roz (9 fire)", 216m },
                    { 5, "La solicitare, aranjamentul poate fi insotit de o felicitare Gratuita.", "https://okflora.r.worldssl.net/files/getfilecdn/9532/4389-w445-h445.jpeg", true, "Buchet din Irisi (25 fire)", 250m },
                    { 6, "Buchetul din imagine conține 51 garoafe roz ambalat în hârtie coreeană roz, tish verde și decorat cu panglică de satin verde crem.", "https://okflora.r.worldssl.net/files/getfilecdn/25814/garoafe-roz-49-2-w445-h445.jpeg", true, "Buchet din garoafe roz (51 fire)", 459m },
                    { 7, "Buchet din 9 Floarea Soarelui - amintirea unei zile perfecte de vara. Buchetul este format din floarea soarelui, hartie decorativa si panglica de satin.", "https://okflora.r.worldssl.net/files/getfilecdn/24338/e7983ab8-a75c-4eb0-9c9d-ec9944893bc3-w445-h445.jpeg", true, "Buchet din Floarea Soarelui (9 fire)", 126m },
                    { 8, "Acest Buchet din Dalii Galbene poate fi surpriza care să încânte persoana dragă. Buchetul este compus din 19 dalii galbene, ambalat în hârtie coreeană crem și decorat cu panglică de satin crem.", "https://okflora.r.worldssl.net/files/getfilecdn/28002/19-belo-zheltyh-georgin-v-bukete_5-w445-h445.jpeg", true, "Buchet din Dalii Galbene", 247m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);
        }
    }
}
