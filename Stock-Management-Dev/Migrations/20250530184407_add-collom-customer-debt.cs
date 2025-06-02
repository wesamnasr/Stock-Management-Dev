using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StockManagementDev_Dev.Migrations
{
    /// <inheritdoc />
    public partial class addcollomcustomerdebt : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Debt",
                table: "Customers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "CustomerBills",
                keyColumn: "CustomerBillID",
                keyValue: 1,
                column: "BillDate",
                value: new DateTime(2025, 5, 29, 21, 44, 4, 272, DateTimeKind.Local).AddTicks(8219));

            migrationBuilder.UpdateData(
                table: "CustomerBills",
                keyColumn: "CustomerBillID",
                keyValue: 2,
                column: "BillDate",
                value: new DateTime(2025, 5, 28, 21, 44, 4, 272, DateTimeKind.Local).AddTicks(8282));

            migrationBuilder.UpdateData(
                table: "CustomerBills",
                keyColumn: "CustomerBillID",
                keyValue: 3,
                column: "BillDate",
                value: new DateTime(2025, 5, 27, 21, 44, 4, 272, DateTimeKind.Local).AddTicks(8302));

            migrationBuilder.UpdateData(
                table: "CustomerBills",
                keyColumn: "CustomerBillID",
                keyValue: 4,
                column: "BillDate",
                value: new DateTime(2025, 5, 26, 21, 44, 4, 272, DateTimeKind.Local).AddTicks(8318));

            migrationBuilder.UpdateData(
                table: "CustomerBills",
                keyColumn: "CustomerBillID",
                keyValue: 5,
                column: "BillDate",
                value: new DateTime(2025, 5, 25, 21, 44, 4, 272, DateTimeKind.Local).AddTicks(8334));

            migrationBuilder.UpdateData(
                table: "CustomerBills",
                keyColumn: "CustomerBillID",
                keyValue: 6,
                column: "BillDate",
                value: new DateTime(2025, 5, 24, 21, 44, 4, 272, DateTimeKind.Local).AddTicks(8356));

            migrationBuilder.UpdateData(
                table: "CustomerBills",
                keyColumn: "CustomerBillID",
                keyValue: 7,
                column: "BillDate",
                value: new DateTime(2025, 5, 23, 21, 44, 4, 272, DateTimeKind.Local).AddTicks(8372));

            migrationBuilder.UpdateData(
                table: "CustomerBills",
                keyColumn: "CustomerBillID",
                keyValue: 8,
                column: "BillDate",
                value: new DateTime(2025, 5, 22, 21, 44, 4, 272, DateTimeKind.Local).AddTicks(8387));

            migrationBuilder.UpdateData(
                table: "CustomerBills",
                keyColumn: "CustomerBillID",
                keyValue: 9,
                column: "BillDate",
                value: new DateTime(2025, 5, 21, 21, 44, 4, 272, DateTimeKind.Local).AddTicks(8401));

            migrationBuilder.UpdateData(
                table: "CustomerBills",
                keyColumn: "CustomerBillID",
                keyValue: 10,
                column: "BillDate",
                value: new DateTime(2025, 5, 20, 21, 44, 4, 272, DateTimeKind.Local).AddTicks(8423));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 1,
                column: "Debt",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 2,
                column: "Debt",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 3,
                column: "Debt",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 4,
                column: "Debt",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 5,
                column: "Debt",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 6,
                column: "Debt",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 7,
                column: "Debt",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 8,
                column: "Debt",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 9,
                column: "Debt",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 10,
                column: "Debt",
                value: 0);

            migrationBuilder.UpdateData(
                table: "SupplierBills",
                keyColumn: "SupplierBillID",
                keyValue: 1,
                column: "BillDate",
                value: new DateTime(2025, 5, 29, 21, 44, 4, 272, DateTimeKind.Local).AddTicks(7832));

            migrationBuilder.UpdateData(
                table: "SupplierBills",
                keyColumn: "SupplierBillID",
                keyValue: 2,
                column: "BillDate",
                value: new DateTime(2025, 5, 28, 21, 44, 4, 272, DateTimeKind.Local).AddTicks(7962));

            migrationBuilder.UpdateData(
                table: "SupplierBills",
                keyColumn: "SupplierBillID",
                keyValue: 3,
                column: "BillDate",
                value: new DateTime(2025, 5, 27, 21, 44, 4, 272, DateTimeKind.Local).AddTicks(7975));

            migrationBuilder.UpdateData(
                table: "SupplierBills",
                keyColumn: "SupplierBillID",
                keyValue: 4,
                column: "BillDate",
                value: new DateTime(2025, 5, 26, 21, 44, 4, 272, DateTimeKind.Local).AddTicks(7986));

            migrationBuilder.UpdateData(
                table: "SupplierBills",
                keyColumn: "SupplierBillID",
                keyValue: 5,
                column: "BillDate",
                value: new DateTime(2025, 5, 25, 21, 44, 4, 272, DateTimeKind.Local).AddTicks(7995));

            migrationBuilder.UpdateData(
                table: "SupplierBills",
                keyColumn: "SupplierBillID",
                keyValue: 6,
                column: "BillDate",
                value: new DateTime(2025, 5, 24, 21, 44, 4, 272, DateTimeKind.Local).AddTicks(8015));

            migrationBuilder.UpdateData(
                table: "SupplierBills",
                keyColumn: "SupplierBillID",
                keyValue: 7,
                column: "BillDate",
                value: new DateTime(2025, 5, 23, 21, 44, 4, 272, DateTimeKind.Local).AddTicks(8029));

            migrationBuilder.UpdateData(
                table: "SupplierBills",
                keyColumn: "SupplierBillID",
                keyValue: 8,
                column: "BillDate",
                value: new DateTime(2025, 5, 22, 21, 44, 4, 272, DateTimeKind.Local).AddTicks(8042));

            migrationBuilder.UpdateData(
                table: "SupplierBills",
                keyColumn: "SupplierBillID",
                keyValue: 9,
                column: "BillDate",
                value: new DateTime(2025, 5, 21, 21, 44, 4, 272, DateTimeKind.Local).AddTicks(8051));

            migrationBuilder.UpdateData(
                table: "SupplierBills",
                keyColumn: "SupplierBillID",
                keyValue: 10,
                column: "BillDate",
                value: new DateTime(2025, 5, 20, 21, 44, 4, 272, DateTimeKind.Local).AddTicks(8065));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Debt",
                table: "Customers");

            migrationBuilder.UpdateData(
                table: "CustomerBills",
                keyColumn: "CustomerBillID",
                keyValue: 1,
                column: "BillDate",
                value: new DateTime(2025, 5, 27, 22, 58, 1, 721, DateTimeKind.Local).AddTicks(2602));

            migrationBuilder.UpdateData(
                table: "CustomerBills",
                keyColumn: "CustomerBillID",
                keyValue: 2,
                column: "BillDate",
                value: new DateTime(2025, 5, 26, 22, 58, 1, 721, DateTimeKind.Local).AddTicks(2632));

            migrationBuilder.UpdateData(
                table: "CustomerBills",
                keyColumn: "CustomerBillID",
                keyValue: 3,
                column: "BillDate",
                value: new DateTime(2025, 5, 25, 22, 58, 1, 721, DateTimeKind.Local).AddTicks(2648));

            migrationBuilder.UpdateData(
                table: "CustomerBills",
                keyColumn: "CustomerBillID",
                keyValue: 4,
                column: "BillDate",
                value: new DateTime(2025, 5, 24, 22, 58, 1, 721, DateTimeKind.Local).AddTicks(2663));

            migrationBuilder.UpdateData(
                table: "CustomerBills",
                keyColumn: "CustomerBillID",
                keyValue: 5,
                column: "BillDate",
                value: new DateTime(2025, 5, 23, 22, 58, 1, 721, DateTimeKind.Local).AddTicks(2677));

            migrationBuilder.UpdateData(
                table: "CustomerBills",
                keyColumn: "CustomerBillID",
                keyValue: 6,
                column: "BillDate",
                value: new DateTime(2025, 5, 22, 22, 58, 1, 721, DateTimeKind.Local).AddTicks(2697));

            migrationBuilder.UpdateData(
                table: "CustomerBills",
                keyColumn: "CustomerBillID",
                keyValue: 7,
                column: "BillDate",
                value: new DateTime(2025, 5, 21, 22, 58, 1, 721, DateTimeKind.Local).AddTicks(2712));

            migrationBuilder.UpdateData(
                table: "CustomerBills",
                keyColumn: "CustomerBillID",
                keyValue: 8,
                column: "BillDate",
                value: new DateTime(2025, 5, 20, 22, 58, 1, 721, DateTimeKind.Local).AddTicks(2726));

            migrationBuilder.UpdateData(
                table: "CustomerBills",
                keyColumn: "CustomerBillID",
                keyValue: 9,
                column: "BillDate",
                value: new DateTime(2025, 5, 19, 22, 58, 1, 721, DateTimeKind.Local).AddTicks(2740));

            migrationBuilder.UpdateData(
                table: "CustomerBills",
                keyColumn: "CustomerBillID",
                keyValue: 10,
                column: "BillDate",
                value: new DateTime(2025, 5, 18, 22, 58, 1, 721, DateTimeKind.Local).AddTicks(2760));

            migrationBuilder.UpdateData(
                table: "SupplierBills",
                keyColumn: "SupplierBillID",
                keyValue: 1,
                column: "BillDate",
                value: new DateTime(2025, 5, 27, 22, 58, 1, 721, DateTimeKind.Local).AddTicks(2037));

            migrationBuilder.UpdateData(
                table: "SupplierBills",
                keyColumn: "SupplierBillID",
                keyValue: 2,
                column: "BillDate",
                value: new DateTime(2025, 5, 26, 22, 58, 1, 721, DateTimeKind.Local).AddTicks(2165));

            migrationBuilder.UpdateData(
                table: "SupplierBills",
                keyColumn: "SupplierBillID",
                keyValue: 3,
                column: "BillDate",
                value: new DateTime(2025, 5, 25, 22, 58, 1, 721, DateTimeKind.Local).AddTicks(2180));

            migrationBuilder.UpdateData(
                table: "SupplierBills",
                keyColumn: "SupplierBillID",
                keyValue: 4,
                column: "BillDate",
                value: new DateTime(2025, 5, 24, 22, 58, 1, 721, DateTimeKind.Local).AddTicks(2193));

            migrationBuilder.UpdateData(
                table: "SupplierBills",
                keyColumn: "SupplierBillID",
                keyValue: 5,
                column: "BillDate",
                value: new DateTime(2025, 5, 23, 22, 58, 1, 721, DateTimeKind.Local).AddTicks(2202));

            migrationBuilder.UpdateData(
                table: "SupplierBills",
                keyColumn: "SupplierBillID",
                keyValue: 6,
                column: "BillDate",
                value: new DateTime(2025, 5, 22, 22, 58, 1, 721, DateTimeKind.Local).AddTicks(2372));

            migrationBuilder.UpdateData(
                table: "SupplierBills",
                keyColumn: "SupplierBillID",
                keyValue: 7,
                column: "BillDate",
                value: new DateTime(2025, 5, 21, 22, 58, 1, 721, DateTimeKind.Local).AddTicks(2393));

            migrationBuilder.UpdateData(
                table: "SupplierBills",
                keyColumn: "SupplierBillID",
                keyValue: 8,
                column: "BillDate",
                value: new DateTime(2025, 5, 20, 22, 58, 1, 721, DateTimeKind.Local).AddTicks(2410));

            migrationBuilder.UpdateData(
                table: "SupplierBills",
                keyColumn: "SupplierBillID",
                keyValue: 9,
                column: "BillDate",
                value: new DateTime(2025, 5, 19, 22, 58, 1, 721, DateTimeKind.Local).AddTicks(2421));

            migrationBuilder.UpdateData(
                table: "SupplierBills",
                keyColumn: "SupplierBillID",
                keyValue: 10,
                column: "BillDate",
                value: new DateTime(2025, 5, 18, 22, 58, 1, 721, DateTimeKind.Local).AddTicks(2441));
        }
    }
}
