using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Stock_Management_Dev.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    CustomerID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.CustomerID);
                });

            migrationBuilder.CreateTable(
                name: "Suppliers",
                columns: table => new
                {
                    SupplierID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Suppliers", x => x.SupplierID);
                });

            migrationBuilder.CreateTable(
                name: "CustomerBills",
                columns: table => new
                {
                    CustomerBillID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BillDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TotalAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CustomerID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerBills", x => x.CustomerBillID);
                    table.ForeignKey(
                        name: "FK_CustomerBills_Customers_CustomerID",
                        column: x => x.CustomerID,
                        principalTable: "Customers",
                        principalColumn: "CustomerID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    QuantityInStock = table.Column<int>(type: "int", nullable: false),
                    UnitPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SupplierID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductID);
                    table.ForeignKey(
                        name: "FK_Products_Suppliers_SupplierID",
                        column: x => x.SupplierID,
                        principalTable: "Suppliers",
                        principalColumn: "SupplierID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SupplierBills",
                columns: table => new
                {
                    SupplierBillID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SupplierID = table.Column<int>(type: "int", nullable: false),
                    BillDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TotalAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PaidAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SupplierBills", x => x.SupplierBillID);
                    table.ForeignKey(
                        name: "FK_SupplierBills_Suppliers_SupplierID",
                        column: x => x.SupplierID,
                        principalTable: "Suppliers",
                        principalColumn: "SupplierID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CustomerBillItems",
                columns: table => new
                {
                    CustomerBillItemID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerBillID = table.Column<int>(type: "int", nullable: false),
                    ProductID = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    UnitPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TotalPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerBillItems", x => x.CustomerBillItemID);
                    table.ForeignKey(
                        name: "FK_CustomerBillItems_CustomerBills_CustomerBillID",
                        column: x => x.CustomerBillID,
                        principalTable: "CustomerBills",
                        principalColumn: "CustomerBillID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CustomerBillItems_Products_ProductID",
                        column: x => x.ProductID,
                        principalTable: "Products",
                        principalColumn: "ProductID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SupplierBillItems",
                columns: table => new
                {
                    SupplierBillItemID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SupplierBillID = table.Column<int>(type: "int", nullable: false),
                    ProductID = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    UnitPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TotalPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SupplierBillItems", x => x.SupplierBillItemID);
                    table.ForeignKey(
                        name: "FK_SupplierBillItems_Products_ProductID",
                        column: x => x.ProductID,
                        principalTable: "Products",
                        principalColumn: "ProductID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SupplierBillItems_SupplierBills_SupplierBillID",
                        column: x => x.SupplierBillID,
                        principalTable: "SupplierBills",
                        principalColumn: "SupplierBillID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerID", "Address", "Email", "Name", "Phone" },
                values: new object[,]
                {
                    { 1, null, null, "Customer 1", "1234567891" },
                    { 2, null, null, "Customer 2", "1234567892" },
                    { 3, null, null, "Customer 3", "1234567893" },
                    { 4, null, null, "Customer 4", "1234567894" },
                    { 5, null, null, "Customer 5", "1234567895" },
                    { 6, null, null, "Customer 6", "1234567896" },
                    { 7, null, null, "Customer 7", "1234567897" },
                    { 8, null, null, "Customer 8", "1234567898" },
                    { 9, null, null, "Customer 9", "1234567899" },
                    { 10, null, null, "Customer 10", "12345678910" }
                });

            migrationBuilder.InsertData(
                table: "Suppliers",
                columns: new[] { "SupplierID", "Address", "CompanyName", "Description", "Email", "Name", "Phone" },
                values: new object[,]
                {
                    { 1, null, null, null, null, "Supplier 1", "9876543211" },
                    { 2, null, null, null, null, "Supplier 2", "9876543212" },
                    { 3, null, null, null, null, "Supplier 3", "9876543213" },
                    { 4, null, null, null, null, "Supplier 4", "9876543214" },
                    { 5, null, null, null, null, "Supplier 5", "9876543215" },
                    { 6, null, null, null, null, "Supplier 6", "9876543216" },
                    { 7, null, null, null, null, "Supplier 7", "9876543217" },
                    { 8, null, null, null, null, "Supplier 8", "9876543218" },
                    { 9, null, null, null, null, "Supplier 9", "9876543219" },
                    { 10, null, null, null, null, "Supplier 10", "98765432110" }
                });

            migrationBuilder.InsertData(
                table: "CustomerBills",
                columns: new[] { "CustomerBillID", "BillDate", "CustomerID", "TotalAmount" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 5, 30, 17, 24, 25, 313, DateTimeKind.Local).AddTicks(7024), 1, 0m },
                    { 2, new DateTime(2025, 5, 29, 17, 24, 25, 313, DateTimeKind.Local).AddTicks(8167), 2, 0m },
                    { 3, new DateTime(2025, 5, 28, 17, 24, 25, 313, DateTimeKind.Local).AddTicks(8176), 3, 0m },
                    { 4, new DateTime(2025, 5, 27, 17, 24, 25, 313, DateTimeKind.Local).AddTicks(8181), 4, 0m },
                    { 5, new DateTime(2025, 5, 26, 17, 24, 25, 313, DateTimeKind.Local).AddTicks(8187), 5, 0m },
                    { 6, new DateTime(2025, 5, 25, 17, 24, 25, 313, DateTimeKind.Local).AddTicks(8199), 6, 0m },
                    { 7, new DateTime(2025, 5, 24, 17, 24, 25, 313, DateTimeKind.Local).AddTicks(8204), 7, 0m },
                    { 8, new DateTime(2025, 5, 23, 17, 24, 25, 313, DateTimeKind.Local).AddTicks(8210), 8, 0m },
                    { 9, new DateTime(2025, 5, 22, 17, 24, 25, 313, DateTimeKind.Local).AddTicks(8215), 9, 0m },
                    { 10, new DateTime(2025, 5, 21, 17, 24, 25, 313, DateTimeKind.Local).AddTicks(8223), 10, 0m }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductID", "Description", "Name", "QuantityInStock", "SupplierID", "UnitPrice" },
                values: new object[,]
                {
                    { 1, null, "Product 1", 50, 1, 20m },
                    { 2, null, "Product 2", 50, 2, 30m },
                    { 3, null, "Product 3", 50, 3, 40m },
                    { 4, null, "Product 4", 50, 4, 50m },
                    { 5, null, "Product 5", 50, 5, 60m },
                    { 6, null, "Product 6", 50, 6, 70m },
                    { 7, null, "Product 7", 50, 7, 80m },
                    { 8, null, "Product 8", 50, 8, 90m },
                    { 9, null, "Product 9", 50, 9, 100m },
                    { 10, null, "Product 10", 50, 10, 110m }
                });

            migrationBuilder.InsertData(
                table: "SupplierBills",
                columns: new[] { "SupplierBillID", "BillDate", "PaidAmount", "SupplierID", "TotalAmount" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 5, 30, 17, 24, 25, 309, DateTimeKind.Local).AddTicks(2616), 0m, 1, 0m },
                    { 2, new DateTime(2025, 5, 29, 17, 24, 25, 313, DateTimeKind.Local).AddTicks(2095), 0m, 2, 0m },
                    { 3, new DateTime(2025, 5, 28, 17, 24, 25, 313, DateTimeKind.Local).AddTicks(2156), 0m, 3, 0m },
                    { 4, new DateTime(2025, 5, 27, 17, 24, 25, 313, DateTimeKind.Local).AddTicks(2162), 0m, 4, 0m },
                    { 5, new DateTime(2025, 5, 26, 17, 24, 25, 313, DateTimeKind.Local).AddTicks(2166), 0m, 5, 0m },
                    { 6, new DateTime(2025, 5, 25, 17, 24, 25, 313, DateTimeKind.Local).AddTicks(2178), 0m, 6, 0m },
                    { 7, new DateTime(2025, 5, 24, 17, 24, 25, 313, DateTimeKind.Local).AddTicks(2183), 0m, 7, 0m },
                    { 8, new DateTime(2025, 5, 23, 17, 24, 25, 313, DateTimeKind.Local).AddTicks(2187), 0m, 8, 0m },
                    { 9, new DateTime(2025, 5, 22, 17, 24, 25, 313, DateTimeKind.Local).AddTicks(2191), 0m, 9, 0m },
                    { 10, new DateTime(2025, 5, 21, 17, 24, 25, 313, DateTimeKind.Local).AddTicks(2196), 0m, 10, 0m }
                });

            migrationBuilder.InsertData(
                table: "CustomerBillItems",
                columns: new[] { "CustomerBillItemID", "CustomerBillID", "ProductID", "Quantity", "TotalPrice", "UnitPrice" },
                values: new object[,]
                {
                    { 1, 1, 2, 3, 0m, 110m },
                    { 2, 2, 3, 3, 0m, 120m },
                    { 3, 3, 4, 3, 0m, 130m },
                    { 4, 4, 5, 3, 0m, 140m },
                    { 5, 5, 6, 3, 0m, 150m },
                    { 6, 6, 7, 3, 0m, 160m },
                    { 7, 7, 8, 3, 0m, 170m },
                    { 8, 8, 9, 3, 0m, 180m },
                    { 9, 9, 10, 3, 0m, 190m },
                    { 10, 10, 1, 3, 0m, 100m }
                });

            migrationBuilder.InsertData(
                table: "SupplierBillItems",
                columns: new[] { "SupplierBillItemID", "ProductID", "Quantity", "SupplierBillID", "TotalPrice", "UnitPrice" },
                values: new object[,]
                {
                    { 1, 2, 5, 1, 0m, 110m },
                    { 2, 3, 5, 2, 0m, 120m },
                    { 3, 4, 5, 3, 0m, 130m },
                    { 4, 5, 5, 4, 0m, 140m },
                    { 5, 6, 5, 5, 0m, 150m },
                    { 6, 7, 5, 6, 0m, 160m },
                    { 7, 8, 5, 7, 0m, 170m },
                    { 8, 9, 5, 8, 0m, 180m },
                    { 9, 10, 5, 9, 0m, 190m },
                    { 10, 1, 5, 10, 0m, 100m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CustomerBillItems_CustomerBillID",
                table: "CustomerBillItems",
                column: "CustomerBillID");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerBillItems_ProductID",
                table: "CustomerBillItems",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerBills_CustomerID",
                table: "CustomerBills",
                column: "CustomerID");

            migrationBuilder.CreateIndex(
                name: "IX_Products_SupplierID",
                table: "Products",
                column: "SupplierID");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierBillItems_ProductID",
                table: "SupplierBillItems",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierBillItems_SupplierBillID",
                table: "SupplierBillItems",
                column: "SupplierBillID");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierBills_SupplierID",
                table: "SupplierBills",
                column: "SupplierID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CustomerBillItems");

            migrationBuilder.DropTable(
                name: "SupplierBillItems");

            migrationBuilder.DropTable(
                name: "CustomerBills");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "SupplierBills");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Suppliers");
        }
    }
}
