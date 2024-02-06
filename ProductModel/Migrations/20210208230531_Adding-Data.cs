using Microsoft.EntityFrameworkCore.Migrations;

namespace ProductModel.Migrations
{
    public partial class AddingData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ID", "Description", "ReorderLevel", "ReorderQuantity", "StockOnHand", "UnitPrice" },
                values: new object[,]
                {
                    { 1, "Chai", 10, 14, 9, 10.0 },
                    { 25, "Almonds", 5, 8, 5, 9.0 },
                    { 26, "Mustard", 15, 10, 3, 4.0 },
                    { 27, "Dried Plums", 50, 3, 3, 7.0 },
                    { 28, "Green Tea", 100, 2, 2, 3.0 },
                    { 29, "Granola", 20, 2, 2, 2.0 },
                    { 30, "Potato Chips", 30, 1, 3, 5.0 },
                    { 31, "Brownie Mix", 10, 9, 2, 8.0 },
                    { 32, "Cake Mix", 10, 11, 8, 7.0 },
                    { 33, "Tea", 20, 2, 3, 4.0 },
                    { 34, "Pears", 10, 1, 10, 1.0 },
                    { 35, "Peaches", 10, 1, 7, 7.0 },
                    { 36, "Pineapple", 10, 1, 1, 6.0 },
                    { 37, "Cherry Pie Filling", 10, 1, 10, 2.0 },
                    { 38, "Green Beans", 10, 1, 2, 9.0 },
                    { 39, "Corn", 10, 1, 3, 6.0 },
                    { 40, "Peas", 10, 1, 3, 6.0 },
                    { 41, "Tuna Fish", 30, 1, 8, 2.0 },
                    { 42, "Smoked Salmon", 30, 2, 9, 10.0 },
                    { 43, "Hot Cereal", 50, 3, 8, 6.0 },
                    { 24, "Mozzarella", 10, 26, 4, 9.0 },
                    { 44, "Vegetable Soup", 100, 1, 4, 9.0 },
                    { 23, "Tomato Sauce", 20, 13, 5, 9.0 },
                    { 21, "Ravioli", 20, 15, 7, 5.0 },
                    { 2, "Syrup", 25, 8, 10, 5.0 },
                    { 3, "Cajun Seasoning", 10, 17, 7, 7.0 },
                    { 4, "Olive Oil", 10, 16, 8, 8.0 },
                    { 5, "Boysenberry Spread", 25, 19, 5, 6.0 },
                    { 6, "Dried Pears", 10, 23, 7, 6.0 },
                    { 7, "Curry Sauce", 10, 30, 6, 9.0 },
                    { 8, "Walnuts", 10, 17, 1, 2.0 },
                    { 9, "Fruit Cocktail", 10, 29, 8, 7.0 },
                    { 10, "Chocolate Biscuits Mix", 5, 7, 1, 2.0 },
                    { 11, "Marmalade", 10, 61, 2, 10.0 },
                    { 12, "Scones", 5, 8, 5, 6.0 },
                    { 13, "Beer", 15, 11, 4, 7.0 },
                    { 14, "Crab Meat", 30, 14, 3, 2.0 },
                    { 15, "Clam Chowder", 10, 7, 6, 10.0 },
                    { 16, "Coffee", 25, 35, 1, 3.0 },
                    { 17, "Chocolate", 25, 10, 1, 10.0 },
                    { 18, "Dried Apples", 10, 40, 3, 1.0 },
                    { 19, "Long Grain Rice", 25, 5, 3, 7.0 }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ID", "Description", "ReorderLevel", "ReorderQuantity", "StockOnHand", "UnitPrice" },
                values: new object[] { 20, "Gnocchi", 30, 29, 3, 8.0 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ID", "Description", "ReorderLevel", "ReorderQuantity", "StockOnHand", "UnitPrice" },
                values: new object[] { 22, "Hot Pepper Sauce", 10, 16, 7, 6.0 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ID", "Description", "ReorderLevel", "ReorderQuantity", "StockOnHand", "UnitPrice" },
                values: new object[] { 45, "Chicken Soup", 100, 1, 2, 8.0 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 45);
        }
    }
}
