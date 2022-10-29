﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Matgr.ProductsAPI.Migrations
{
    public partial class AddSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ImagrUrl",
                table: "Products",
                newName: "ImageUrl");

            migrationBuilder.RenameColumn(
                name: "CatogryName",
                table: "Products",
                newName: "CategoryName");

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "CategoryName", "Description", "ImageUrl", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "Laptops", "MSI GF63 Thin Gaming Laptop - Intel Core I5 - 8GB RAM - 256GB SSD - 15.6-inch FHD - 4GB GPU - Windows 10 - Black (English Keyboard).", "/images/products/1.jpg", "MSI GF63 Thin Gaming Laptop", 7800.0 },
                    { 2, "Laptops", "DELL G3 15-3500 Gaming Laptop - Intel Core I5-10300H - 8GB RAM - 256GB SSD + 1TB HDD - 15.6-inch FHD - 4GB GTX 1650 GPU - Ubuntu - Black.", "/images/products/2.jpg", "DELL G3 15-3500 Gaming Laptop", 12400.0 },
                    { 3, "Televisions", "Samsung UA43T5300 - 43-inch Full HD Smart TV With Built-In Receiver.", "/images/products/3.jpg", "Samsung UA43T5300", 6500.0 },
                    { 4, "Televisions", "LG 43LM6370PVA - 43-inch Full HD Smart TV With Built-in Receiver.", "/images/products/4.jpg", "LG 43LM6370PVA", 6200.0 },
                    { 5, "Mobile Phones", "Samsung Galaxy A12 - 6.4-inch 128GB/4GB Dual SIM Mobile Phone - White.", "/images/products/5.jpg", "Samsung Galaxy A12", 2850.0 },
                    { 6, "Mobile Phones", "Apple iPhone 12 Pro Max Dual SIM with FaceTime - 256GB - Pacific Blue.", "/images/products/6.jpg", "Apple iPhone 12 Pro Max", 22500.0 },
                    { 7, "Mobile Accessories", "OPPO Realme 8 Pro Case, Dual Layer PC Back TPU Bumper Hybrid No-Slip Shockproof Cover For OPPO Realme 8 / Realme 8 Pro 4G.", "/images/products/7.jpg", "OPPO Realme 8 Pro Case", 115.0 },
                    { 8, "Mobile Accessories", "Galaxy Z Flip3 5G Case, Slim Luxury Electroplate Frame Crystal Clear Back Protective Case Cover For Samsung Galaxy Z Flip 3 5G Purple.", "/images/products/8.jpg", "Galaxy Z Flip3 5G Case", 250.0 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 8);

            migrationBuilder.RenameColumn(
                name: "ImageUrl",
                table: "Products",
                newName: "ImagrUrl");

            migrationBuilder.RenameColumn(
                name: "CategoryName",
                table: "Products",
                newName: "CatogryName");
        }
    }
}
