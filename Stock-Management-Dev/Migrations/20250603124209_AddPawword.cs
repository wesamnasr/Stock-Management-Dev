using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Stock_Management_Dev.Migrations
{
    /// <inheritdoc />
    public partial class AddPawword : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Passwords",
                columns: table => new
                {
                    PasswordID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OldPassword = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    NewPassword = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Passwords", x => x.PasswordID);
                });

            migrationBuilder.UpdateData(
                table: "CustomerBills",
                keyColumn: "CustomerBillID",
                keyValue: 1,
                column: "BillDate",
                value: new DateTime(2025, 6, 2, 15, 42, 1, 438, DateTimeKind.Local).AddTicks(1677));

            migrationBuilder.UpdateData(
                table: "CustomerBills",
                keyColumn: "CustomerBillID",
                keyValue: 2,
                column: "BillDate",
                value: new DateTime(2025, 6, 1, 15, 42, 1, 438, DateTimeKind.Local).AddTicks(7235));

            migrationBuilder.UpdateData(
                table: "CustomerBills",
                keyColumn: "CustomerBillID",
                keyValue: 3,
                column: "BillDate",
                value: new DateTime(2025, 5, 31, 15, 42, 1, 438, DateTimeKind.Local).AddTicks(7282));

            migrationBuilder.UpdateData(
                table: "CustomerBills",
                keyColumn: "CustomerBillID",
                keyValue: 4,
                column: "BillDate",
                value: new DateTime(2025, 5, 30, 15, 42, 1, 438, DateTimeKind.Local).AddTicks(7327));

            migrationBuilder.UpdateData(
                table: "CustomerBills",
                keyColumn: "CustomerBillID",
                keyValue: 5,
                column: "BillDate",
                value: new DateTime(2025, 5, 29, 15, 42, 1, 438, DateTimeKind.Local).AddTicks(7364));

            migrationBuilder.UpdateData(
                table: "CustomerBills",
                keyColumn: "CustomerBillID",
                keyValue: 6,
                column: "BillDate",
                value: new DateTime(2025, 5, 28, 15, 42, 1, 438, DateTimeKind.Local).AddTicks(7429));

            migrationBuilder.UpdateData(
                table: "CustomerBills",
                keyColumn: "CustomerBillID",
                keyValue: 7,
                column: "BillDate",
                value: new DateTime(2025, 5, 27, 15, 42, 1, 438, DateTimeKind.Local).AddTicks(7466));

            migrationBuilder.UpdateData(
                table: "CustomerBills",
                keyColumn: "CustomerBillID",
                keyValue: 8,
                column: "BillDate",
                value: new DateTime(2025, 5, 26, 15, 42, 1, 438, DateTimeKind.Local).AddTicks(7500));

            migrationBuilder.UpdateData(
                table: "CustomerBills",
                keyColumn: "CustomerBillID",
                keyValue: 9,
                column: "BillDate",
                value: new DateTime(2025, 5, 25, 15, 42, 1, 438, DateTimeKind.Local).AddTicks(7595));

            migrationBuilder.UpdateData(
                table: "CustomerBills",
                keyColumn: "CustomerBillID",
                keyValue: 10,
                column: "BillDate",
                value: new DateTime(2025, 5, 24, 15, 42, 1, 438, DateTimeKind.Local).AddTicks(7652));

            migrationBuilder.InsertData(
                table: "Passwords",
                columns: new[] { "PasswordID", "CreatedAt", "NewPassword", "OldPassword" },
                values: new object[] { 1, new DateTime(2025, 6, 3, 15, 42, 1, 443, DateTimeKind.Local).AddTicks(9103), "123", "123" });

            migrationBuilder.UpdateData(
                table: "SupplierBills",
                keyColumn: "SupplierBillID",
                keyValue: 1,
                column: "BillDate",
                value: new DateTime(2025, 6, 2, 15, 42, 1, 419, DateTimeKind.Local).AddTicks(1119));

            migrationBuilder.UpdateData(
                table: "SupplierBills",
                keyColumn: "SupplierBillID",
                keyValue: 2,
                column: "BillDate",
                value: new DateTime(2025, 6, 1, 15, 42, 1, 435, DateTimeKind.Local).AddTicks(9304));

            migrationBuilder.UpdateData(
                table: "SupplierBills",
                keyColumn: "SupplierBillID",
                keyValue: 3,
                column: "BillDate",
                value: new DateTime(2025, 5, 31, 15, 42, 1, 435, DateTimeKind.Local).AddTicks(9502));

            migrationBuilder.UpdateData(
                table: "SupplierBills",
                keyColumn: "SupplierBillID",
                keyValue: 4,
                column: "BillDate",
                value: new DateTime(2025, 5, 30, 15, 42, 1, 435, DateTimeKind.Local).AddTicks(9540));

            migrationBuilder.UpdateData(
                table: "SupplierBills",
                keyColumn: "SupplierBillID",
                keyValue: 5,
                column: "BillDate",
                value: new DateTime(2025, 5, 29, 15, 42, 1, 435, DateTimeKind.Local).AddTicks(9565));

            migrationBuilder.UpdateData(
                table: "SupplierBills",
                keyColumn: "SupplierBillID",
                keyValue: 6,
                column: "BillDate",
                value: new DateTime(2025, 5, 28, 15, 42, 1, 435, DateTimeKind.Local).AddTicks(9617));

            migrationBuilder.UpdateData(
                table: "SupplierBills",
                keyColumn: "SupplierBillID",
                keyValue: 7,
                column: "BillDate",
                value: new DateTime(2025, 5, 27, 15, 42, 1, 435, DateTimeKind.Local).AddTicks(9643));

            migrationBuilder.UpdateData(
                table: "SupplierBills",
                keyColumn: "SupplierBillID",
                keyValue: 8,
                column: "BillDate",
                value: new DateTime(2025, 5, 26, 15, 42, 1, 435, DateTimeKind.Local).AddTicks(9669));

            migrationBuilder.UpdateData(
                table: "SupplierBills",
                keyColumn: "SupplierBillID",
                keyValue: 9,
                column: "BillDate",
                value: new DateTime(2025, 5, 25, 15, 42, 1, 435, DateTimeKind.Local).AddTicks(9695));

            migrationBuilder.UpdateData(
                table: "SupplierBills",
                keyColumn: "SupplierBillID",
                keyValue: 10,
                column: "BillDate",
                value: new DateTime(2025, 5, 24, 15, 42, 1, 435, DateTimeKind.Local).AddTicks(9731));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Passwords");

            migrationBuilder.UpdateData(
                table: "CustomerBills",
                keyColumn: "CustomerBillID",
                keyValue: 1,
                column: "BillDate",
                value: new DateTime(2025, 5, 30, 17, 24, 25, 313, DateTimeKind.Local).AddTicks(7024));

            migrationBuilder.UpdateData(
                table: "CustomerBills",
                keyColumn: "CustomerBillID",
                keyValue: 2,
                column: "BillDate",
                value: new DateTime(2025, 5, 29, 17, 24, 25, 313, DateTimeKind.Local).AddTicks(8167));

            migrationBuilder.UpdateData(
                table: "CustomerBills",
                keyColumn: "CustomerBillID",
                keyValue: 3,
                column: "BillDate",
                value: new DateTime(2025, 5, 28, 17, 24, 25, 313, DateTimeKind.Local).AddTicks(8176));

            migrationBuilder.UpdateData(
                table: "CustomerBills",
                keyColumn: "CustomerBillID",
                keyValue: 4,
                column: "BillDate",
                value: new DateTime(2025, 5, 27, 17, 24, 25, 313, DateTimeKind.Local).AddTicks(8181));

            migrationBuilder.UpdateData(
                table: "CustomerBills",
                keyColumn: "CustomerBillID",
                keyValue: 5,
                column: "BillDate",
                value: new DateTime(2025, 5, 26, 17, 24, 25, 313, DateTimeKind.Local).AddTicks(8187));

            migrationBuilder.UpdateData(
                table: "CustomerBills",
                keyColumn: "CustomerBillID",
                keyValue: 6,
                column: "BillDate",
                value: new DateTime(2025, 5, 25, 17, 24, 25, 313, DateTimeKind.Local).AddTicks(8199));

            migrationBuilder.UpdateData(
                table: "CustomerBills",
                keyColumn: "CustomerBillID",
                keyValue: 7,
                column: "BillDate",
                value: new DateTime(2025, 5, 24, 17, 24, 25, 313, DateTimeKind.Local).AddTicks(8204));

            migrationBuilder.UpdateData(
                table: "CustomerBills",
                keyColumn: "CustomerBillID",
                keyValue: 8,
                column: "BillDate",
                value: new DateTime(2025, 5, 23, 17, 24, 25, 313, DateTimeKind.Local).AddTicks(8210));

            migrationBuilder.UpdateData(
                table: "CustomerBills",
                keyColumn: "CustomerBillID",
                keyValue: 9,
                column: "BillDate",
                value: new DateTime(2025, 5, 22, 17, 24, 25, 313, DateTimeKind.Local).AddTicks(8215));

            migrationBuilder.UpdateData(
                table: "CustomerBills",
                keyColumn: "CustomerBillID",
                keyValue: 10,
                column: "BillDate",
                value: new DateTime(2025, 5, 21, 17, 24, 25, 313, DateTimeKind.Local).AddTicks(8223));

            migrationBuilder.UpdateData(
                table: "SupplierBills",
                keyColumn: "SupplierBillID",
                keyValue: 1,
                column: "BillDate",
                value: new DateTime(2025, 5, 30, 17, 24, 25, 309, DateTimeKind.Local).AddTicks(2616));

            migrationBuilder.UpdateData(
                table: "SupplierBills",
                keyColumn: "SupplierBillID",
                keyValue: 2,
                column: "BillDate",
                value: new DateTime(2025, 5, 29, 17, 24, 25, 313, DateTimeKind.Local).AddTicks(2095));

            migrationBuilder.UpdateData(
                table: "SupplierBills",
                keyColumn: "SupplierBillID",
                keyValue: 3,
                column: "BillDate",
                value: new DateTime(2025, 5, 28, 17, 24, 25, 313, DateTimeKind.Local).AddTicks(2156));

            migrationBuilder.UpdateData(
                table: "SupplierBills",
                keyColumn: "SupplierBillID",
                keyValue: 4,
                column: "BillDate",
                value: new DateTime(2025, 5, 27, 17, 24, 25, 313, DateTimeKind.Local).AddTicks(2162));

            migrationBuilder.UpdateData(
                table: "SupplierBills",
                keyColumn: "SupplierBillID",
                keyValue: 5,
                column: "BillDate",
                value: new DateTime(2025, 5, 26, 17, 24, 25, 313, DateTimeKind.Local).AddTicks(2166));

            migrationBuilder.UpdateData(
                table: "SupplierBills",
                keyColumn: "SupplierBillID",
                keyValue: 6,
                column: "BillDate",
                value: new DateTime(2025, 5, 25, 17, 24, 25, 313, DateTimeKind.Local).AddTicks(2178));

            migrationBuilder.UpdateData(
                table: "SupplierBills",
                keyColumn: "SupplierBillID",
                keyValue: 7,
                column: "BillDate",
                value: new DateTime(2025, 5, 24, 17, 24, 25, 313, DateTimeKind.Local).AddTicks(2183));

            migrationBuilder.UpdateData(
                table: "SupplierBills",
                keyColumn: "SupplierBillID",
                keyValue: 8,
                column: "BillDate",
                value: new DateTime(2025, 5, 23, 17, 24, 25, 313, DateTimeKind.Local).AddTicks(2187));

            migrationBuilder.UpdateData(
                table: "SupplierBills",
                keyColumn: "SupplierBillID",
                keyValue: 9,
                column: "BillDate",
                value: new DateTime(2025, 5, 22, 17, 24, 25, 313, DateTimeKind.Local).AddTicks(2191));

            migrationBuilder.UpdateData(
                table: "SupplierBills",
                keyColumn: "SupplierBillID",
                keyValue: 10,
                column: "BillDate",
                value: new DateTime(2025, 5, 21, 17, 24, 25, 313, DateTimeKind.Local).AddTicks(2196));
        }
    }
}
