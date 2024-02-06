﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProductModel;

namespace ProductModel.Migrations
{
    [DbContext(typeof(ProductDBContext))]
    [Migration("20210208230531_Adding-Data")]
    partial class AddingData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("ProductModel.Product", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ReorderLevel")
                        .HasColumnType("int");

                    b.Property<int>("ReorderQuantity")
                        .HasColumnType("int");

                    b.Property<int>("StockOnHand")
                        .HasColumnType("int");

                    b.Property<double>("UnitPrice")
                        .HasColumnType("float");

                    b.HasKey("ID");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Description = "Chai",
                            ReorderLevel = 10,
                            ReorderQuantity = 14,
                            StockOnHand = 9,
                            UnitPrice = 10.0
                        },
                        new
                        {
                            ID = 2,
                            Description = "Syrup",
                            ReorderLevel = 25,
                            ReorderQuantity = 8,
                            StockOnHand = 10,
                            UnitPrice = 5.0
                        },
                        new
                        {
                            ID = 3,
                            Description = "Cajun Seasoning",
                            ReorderLevel = 10,
                            ReorderQuantity = 17,
                            StockOnHand = 7,
                            UnitPrice = 7.0
                        },
                        new
                        {
                            ID = 4,
                            Description = "Olive Oil",
                            ReorderLevel = 10,
                            ReorderQuantity = 16,
                            StockOnHand = 8,
                            UnitPrice = 8.0
                        },
                        new
                        {
                            ID = 5,
                            Description = "Boysenberry Spread",
                            ReorderLevel = 25,
                            ReorderQuantity = 19,
                            StockOnHand = 5,
                            UnitPrice = 6.0
                        },
                        new
                        {
                            ID = 6,
                            Description = "Dried Pears",
                            ReorderLevel = 10,
                            ReorderQuantity = 23,
                            StockOnHand = 7,
                            UnitPrice = 6.0
                        },
                        new
                        {
                            ID = 7,
                            Description = "Curry Sauce",
                            ReorderLevel = 10,
                            ReorderQuantity = 30,
                            StockOnHand = 6,
                            UnitPrice = 9.0
                        },
                        new
                        {
                            ID = 8,
                            Description = "Walnuts",
                            ReorderLevel = 10,
                            ReorderQuantity = 17,
                            StockOnHand = 1,
                            UnitPrice = 2.0
                        },
                        new
                        {
                            ID = 9,
                            Description = "Fruit Cocktail",
                            ReorderLevel = 10,
                            ReorderQuantity = 29,
                            StockOnHand = 8,
                            UnitPrice = 7.0
                        },
                        new
                        {
                            ID = 10,
                            Description = "Chocolate Biscuits Mix",
                            ReorderLevel = 5,
                            ReorderQuantity = 7,
                            StockOnHand = 1,
                            UnitPrice = 2.0
                        },
                        new
                        {
                            ID = 11,
                            Description = "Marmalade",
                            ReorderLevel = 10,
                            ReorderQuantity = 61,
                            StockOnHand = 2,
                            UnitPrice = 10.0
                        },
                        new
                        {
                            ID = 12,
                            Description = "Scones",
                            ReorderLevel = 5,
                            ReorderQuantity = 8,
                            StockOnHand = 5,
                            UnitPrice = 6.0
                        },
                        new
                        {
                            ID = 13,
                            Description = "Beer",
                            ReorderLevel = 15,
                            ReorderQuantity = 11,
                            StockOnHand = 4,
                            UnitPrice = 7.0
                        },
                        new
                        {
                            ID = 14,
                            Description = "Crab Meat",
                            ReorderLevel = 30,
                            ReorderQuantity = 14,
                            StockOnHand = 3,
                            UnitPrice = 2.0
                        },
                        new
                        {
                            ID = 15,
                            Description = "Clam Chowder",
                            ReorderLevel = 10,
                            ReorderQuantity = 7,
                            StockOnHand = 6,
                            UnitPrice = 10.0
                        },
                        new
                        {
                            ID = 16,
                            Description = "Coffee",
                            ReorderLevel = 25,
                            ReorderQuantity = 35,
                            StockOnHand = 1,
                            UnitPrice = 3.0
                        },
                        new
                        {
                            ID = 17,
                            Description = "Chocolate",
                            ReorderLevel = 25,
                            ReorderQuantity = 10,
                            StockOnHand = 1,
                            UnitPrice = 10.0
                        },
                        new
                        {
                            ID = 18,
                            Description = "Dried Apples",
                            ReorderLevel = 10,
                            ReorderQuantity = 40,
                            StockOnHand = 3,
                            UnitPrice = 1.0
                        },
                        new
                        {
                            ID = 19,
                            Description = "Long Grain Rice",
                            ReorderLevel = 25,
                            ReorderQuantity = 5,
                            StockOnHand = 3,
                            UnitPrice = 7.0
                        },
                        new
                        {
                            ID = 20,
                            Description = "Gnocchi",
                            ReorderLevel = 30,
                            ReorderQuantity = 29,
                            StockOnHand = 3,
                            UnitPrice = 8.0
                        },
                        new
                        {
                            ID = 21,
                            Description = "Ravioli",
                            ReorderLevel = 20,
                            ReorderQuantity = 15,
                            StockOnHand = 7,
                            UnitPrice = 5.0
                        },
                        new
                        {
                            ID = 22,
                            Description = "Hot Pepper Sauce",
                            ReorderLevel = 10,
                            ReorderQuantity = 16,
                            StockOnHand = 7,
                            UnitPrice = 6.0
                        },
                        new
                        {
                            ID = 23,
                            Description = "Tomato Sauce",
                            ReorderLevel = 20,
                            ReorderQuantity = 13,
                            StockOnHand = 5,
                            UnitPrice = 9.0
                        },
                        new
                        {
                            ID = 24,
                            Description = "Mozzarella",
                            ReorderLevel = 10,
                            ReorderQuantity = 26,
                            StockOnHand = 4,
                            UnitPrice = 9.0
                        },
                        new
                        {
                            ID = 25,
                            Description = "Almonds",
                            ReorderLevel = 5,
                            ReorderQuantity = 8,
                            StockOnHand = 5,
                            UnitPrice = 9.0
                        },
                        new
                        {
                            ID = 26,
                            Description = "Mustard",
                            ReorderLevel = 15,
                            ReorderQuantity = 10,
                            StockOnHand = 3,
                            UnitPrice = 4.0
                        },
                        new
                        {
                            ID = 27,
                            Description = "Dried Plums",
                            ReorderLevel = 50,
                            ReorderQuantity = 3,
                            StockOnHand = 3,
                            UnitPrice = 7.0
                        },
                        new
                        {
                            ID = 28,
                            Description = "Green Tea",
                            ReorderLevel = 100,
                            ReorderQuantity = 2,
                            StockOnHand = 2,
                            UnitPrice = 3.0
                        },
                        new
                        {
                            ID = 29,
                            Description = "Granola",
                            ReorderLevel = 20,
                            ReorderQuantity = 2,
                            StockOnHand = 2,
                            UnitPrice = 2.0
                        },
                        new
                        {
                            ID = 30,
                            Description = "Potato Chips",
                            ReorderLevel = 30,
                            ReorderQuantity = 1,
                            StockOnHand = 3,
                            UnitPrice = 5.0
                        },
                        new
                        {
                            ID = 31,
                            Description = "Brownie Mix",
                            ReorderLevel = 10,
                            ReorderQuantity = 9,
                            StockOnHand = 2,
                            UnitPrice = 8.0
                        },
                        new
                        {
                            ID = 32,
                            Description = "Cake Mix",
                            ReorderLevel = 10,
                            ReorderQuantity = 11,
                            StockOnHand = 8,
                            UnitPrice = 7.0
                        },
                        new
                        {
                            ID = 33,
                            Description = "Tea",
                            ReorderLevel = 20,
                            ReorderQuantity = 2,
                            StockOnHand = 3,
                            UnitPrice = 4.0
                        },
                        new
                        {
                            ID = 34,
                            Description = "Pears",
                            ReorderLevel = 10,
                            ReorderQuantity = 1,
                            StockOnHand = 10,
                            UnitPrice = 1.0
                        },
                        new
                        {
                            ID = 35,
                            Description = "Peaches",
                            ReorderLevel = 10,
                            ReorderQuantity = 1,
                            StockOnHand = 7,
                            UnitPrice = 7.0
                        },
                        new
                        {
                            ID = 36,
                            Description = "Pineapple",
                            ReorderLevel = 10,
                            ReorderQuantity = 1,
                            StockOnHand = 1,
                            UnitPrice = 6.0
                        },
                        new
                        {
                            ID = 37,
                            Description = "Cherry Pie Filling",
                            ReorderLevel = 10,
                            ReorderQuantity = 1,
                            StockOnHand = 10,
                            UnitPrice = 2.0
                        },
                        new
                        {
                            ID = 38,
                            Description = "Green Beans",
                            ReorderLevel = 10,
                            ReorderQuantity = 1,
                            StockOnHand = 2,
                            UnitPrice = 9.0
                        },
                        new
                        {
                            ID = 39,
                            Description = "Corn",
                            ReorderLevel = 10,
                            ReorderQuantity = 1,
                            StockOnHand = 3,
                            UnitPrice = 6.0
                        },
                        new
                        {
                            ID = 40,
                            Description = "Peas",
                            ReorderLevel = 10,
                            ReorderQuantity = 1,
                            StockOnHand = 3,
                            UnitPrice = 6.0
                        },
                        new
                        {
                            ID = 41,
                            Description = "Tuna Fish",
                            ReorderLevel = 30,
                            ReorderQuantity = 1,
                            StockOnHand = 8,
                            UnitPrice = 2.0
                        },
                        new
                        {
                            ID = 42,
                            Description = "Smoked Salmon",
                            ReorderLevel = 30,
                            ReorderQuantity = 2,
                            StockOnHand = 9,
                            UnitPrice = 10.0
                        },
                        new
                        {
                            ID = 43,
                            Description = "Hot Cereal",
                            ReorderLevel = 50,
                            ReorderQuantity = 3,
                            StockOnHand = 8,
                            UnitPrice = 6.0
                        },
                        new
                        {
                            ID = 44,
                            Description = "Vegetable Soup",
                            ReorderLevel = 100,
                            ReorderQuantity = 1,
                            StockOnHand = 4,
                            UnitPrice = 9.0
                        },
                        new
                        {
                            ID = 45,
                            Description = "Chicken Soup",
                            ReorderLevel = 100,
                            ReorderQuantity = 1,
                            StockOnHand = 2,
                            UnitPrice = 8.0
                        });
                });
#pragma warning restore 612, 618
        }
    }
}