using Microsoft.EntityFrameworkCore.Migrations;

namespace Ecommerce.Migrations
{
    public partial class SeedingData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    CustomerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustomerEmail = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.CustomerId);
                });

            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    OrderId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    DirId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.OrderId);
                    table.ForeignKey(
                        name: "FK_Order_Customer_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customer",
                        principalColumn: "CustomerId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderItem",
                columns: table => new
                {
                    ItemId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OrderId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderItem", x => x.ItemId);
                    table.ForeignKey(
                        name: "FK_OrderItem_Order_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Order",
                        principalColumn: "OrderId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Delivery",
                columns: table => new
                {
                    ItemId = table.Column<int>(type: "int", nullable: false),
                    From = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    To = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Delivery", x => x.ItemId);
                    table.ForeignKey(
                        name: "FK_Delivery_OrderItem_ItemId",
                        column: x => x.ItemId,
                        principalTable: "OrderItem",
                        principalColumn: "ItemId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Customer",
                columns: new[] { "CustomerId", "CustomerEmail", "CustomerName" },
                values: new object[,]
                {
                    { 1111, "alluarjun@gmail.com", "Allu Arjun" },
                    { 2222, "saipallavi@gmail.com", "Sai Pallavi" },
                    { 3333, "keertysuresh@gmail.com", "Keerty Suresh" },
                    { 4444, "dhanush@gmail.com", "Dhanush" }
                });

            migrationBuilder.InsertData(
                table: "Order",
                columns: new[] { "OrderId", "CustomerId", "DirId" },
                values: new object[,]
                {
                    { 111, 1111, 0 },
                    { 222, 2222, 0 },
                    { 333, 3333, 0 },
                    { 444, 4444, 0 }
                });

            migrationBuilder.InsertData(
                table: "OrderItem",
                columns: new[] { "ItemId", "Amount", "OrderId", "Status" },
                values: new object[,]
                {
                    { 9999, 1928, 111, "InTransit" },
                    { 8888, 6453, 111, "InTransit" },
                    { 7777, 333, 111, "InTransit" },
                    { 6666, 1111, 111, "InTransit" },
                    { 1232, 8765, 222, "InTransit" },
                    { 8764, 1111, 222, "InTransit" },
                    { 3745, 3425, 333, "InTransit" },
                    { 9837, 1234, 333, "InTransit" },
                    { 1836, 2121, 333, "InTransit" },
                    { 3646, 1456, 333, "InTransit" },
                    { 7645, 7677, 444, "InTransit" },
                    { 9721, 5674, 444, "InTransit" },
                    { 7878, 5547, 444, "InTransit" }
                });

            migrationBuilder.InsertData(
                table: "Delivery",
                columns: new[] { "ItemId", "From", "To" },
                values: new object[,]
                {
                    { 9999, "20-sep", "25-sep" },
                    { 8888, "20-sep", "25-sep" },
                    { 7777, "20-sep", "25-sep" },
                    { 6666, "20-sep", "25-sep" },
                    { 1232, "22-sep", "26-sep" },
                    { 8764, "22-sep", "26-sep" },
                    { 3745, "23-sep", "28-sep" },
                    { 9837, "23-sep", "28-sep" },
                    { 1836, "23-sep", "28-sep" },
                    { 3646, "23-sep", "28-sep" },
                    { 7645, "24-sep", "29-sep" },
                    { 9721, "24-sep", "29-sep" },
                    { 7878, "24-sep", "29-sep" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Order_CustomerId",
                table: "Order",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItem_OrderId",
                table: "OrderItem",
                column: "OrderId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Delivery");

            migrationBuilder.DropTable(
                name: "OrderItem");

            migrationBuilder.DropTable(
                name: "Order");

            migrationBuilder.DropTable(
                name: "Customer");
        }
    }
}
