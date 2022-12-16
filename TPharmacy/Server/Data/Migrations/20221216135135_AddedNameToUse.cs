using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TPharmacy.Server.Data.Migrations
{
    public partial class AddedNameToUse : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Consultations",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "ConDate", "ConEndTime", "ConStartTime", "DataUpdated", "DateCreated" },
                values: new object[] { new DateTime(2022, 12, 16, 21, 51, 35, 93, DateTimeKind.Local).AddTicks(7292), new DateTime(2022, 12, 16, 23, 0, 35, 93, DateTimeKind.Local).AddTicks(7500), new DateTime(2022, 12, 16, 21, 51, 35, 93, DateTimeKind.Local).AddTicks(7413), new DateTime(2022, 12, 16, 21, 51, 35, 93, DateTimeKind.Local).AddTicks(7911), new DateTime(2022, 12, 16, 21, 51, 35, 93, DateTimeKind.Local).AddTicks(7910) });

            migrationBuilder.UpdateData(
                table: "Consultations",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "ConDate", "ConEndTime", "ConStartTime", "DataUpdated", "DateCreated" },
                values: new object[] { new DateTime(2022, 12, 16, 21, 51, 35, 93, DateTimeKind.Local).AddTicks(7914), new DateTime(2022, 12, 16, 22, 51, 35, 93, DateTimeKind.Local).AddTicks(7916), new DateTime(2022, 12, 16, 21, 51, 35, 93, DateTimeKind.Local).AddTicks(7915), new DateTime(2022, 12, 16, 21, 51, 35, 93, DateTimeKind.Local).AddTicks(7920), new DateTime(2022, 12, 16, 21, 51, 35, 93, DateTimeKind.Local).AddTicks(7920) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DataUpdated", "DateCreated" },
                values: new object[] { new DateTime(2022, 12, 16, 21, 51, 35, 92, DateTimeKind.Local).AddTicks(5918), new DateTime(2022, 12, 16, 21, 51, 35, 92, DateTimeKind.Local).AddTicks(5914) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DataUpdated", "DateCreated" },
                values: new object[] { new DateTime(2022, 12, 16, 21, 51, 35, 92, DateTimeKind.Local).AddTicks(5922), new DateTime(2022, 12, 16, 21, 51, 35, 92, DateTimeKind.Local).AddTicks(5921) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "DataUpdated", "DateCreated" },
                values: new object[] { new DateTime(2022, 12, 16, 21, 51, 35, 92, DateTimeKind.Local).AddTicks(5925), new DateTime(2022, 12, 16, 21, 51, 35, 92, DateTimeKind.Local).AddTicks(5924) });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DataUpdated", "DateCreated" },
                values: new object[] { new DateTime(2022, 12, 16, 21, 51, 35, 93, DateTimeKind.Local).AddTicks(674), new DateTime(2022, 12, 16, 21, 51, 35, 93, DateTimeKind.Local).AddTicks(670) });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DataUpdated", "DateCreated" },
                values: new object[] { new DateTime(2022, 12, 16, 21, 51, 35, 93, DateTimeKind.Local).AddTicks(677), new DateTime(2022, 12, 16, 21, 51, 35, 93, DateTimeKind.Local).AddTicks(676) });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "DataUpdated", "DateCreated" },
                values: new object[] { new DateTime(2022, 12, 16, 21, 51, 35, 93, DateTimeKind.Local).AddTicks(680), new DateTime(2022, 12, 16, 21, 51, 35, 93, DateTimeKind.Local).AddTicks(679) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DataUpdated", "DateCreated", "OrderDateTime" },
                values: new object[] { new DateTime(2022, 12, 16, 21, 51, 35, 92, DateTimeKind.Local).AddTicks(8519), new DateTime(2022, 12, 16, 21, 51, 35, 92, DateTimeKind.Local).AddTicks(8517), new DateTime(2022, 12, 16, 21, 51, 35, 92, DateTimeKind.Local).AddTicks(8267) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DataUpdated", "DateCreated", "OrderDateTime" },
                values: new object[] { new DateTime(2022, 12, 16, 21, 51, 35, 92, DateTimeKind.Local).AddTicks(8524), new DateTime(2022, 12, 16, 21, 51, 35, 92, DateTimeKind.Local).AddTicks(8523), new DateTime(2022, 12, 16, 21, 51, 35, 92, DateTimeKind.Local).AddTicks(8522) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DataUpdated", "DateCreated" },
                values: new object[] { new DateTime(2022, 12, 16, 21, 51, 35, 93, DateTimeKind.Local).AddTicks(2845), new DateTime(2022, 12, 16, 21, 51, 35, 93, DateTimeKind.Local).AddTicks(2841) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DataUpdated", "DateCreated" },
                values: new object[] { new DateTime(2022, 12, 16, 21, 51, 35, 93, DateTimeKind.Local).AddTicks(2848), new DateTime(2022, 12, 16, 21, 51, 35, 93, DateTimeKind.Local).AddTicks(2847) });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DataUpdated", "DateCreated" },
                values: new object[] { new DateTime(2022, 12, 16, 21, 51, 35, 93, DateTimeKind.Local).AddTicks(4615), new DateTime(2022, 12, 16, 21, 51, 35, 93, DateTimeKind.Local).AddTicks(4612) });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DataUpdated", "DateCreated" },
                values: new object[] { new DateTime(2022, 12, 16, 21, 51, 35, 93, DateTimeKind.Local).AddTicks(4618), new DateTime(2022, 12, 16, 21, 51, 35, 93, DateTimeKind.Local).AddTicks(4617) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DataUpdated", "DateCreated" },
                values: new object[] { new DateTime(2022, 12, 16, 21, 51, 35, 91, DateTimeKind.Local).AddTicks(2203), new DateTime(2022, 12, 16, 21, 51, 35, 90, DateTimeKind.Local).AddTicks(5157) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DataUpdated", "DateCreated" },
                values: new object[] { new DateTime(2022, 12, 16, 21, 51, 35, 91, DateTimeKind.Local).AddTicks(2712), new DateTime(2022, 12, 16, 21, 51, 35, 91, DateTimeKind.Local).AddTicks(2710) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "DataUpdated", "DateCreated" },
                values: new object[] { new DateTime(2022, 12, 16, 21, 51, 35, 91, DateTimeKind.Local).AddTicks(2715), new DateTime(2022, 12, 16, 21, 51, 35, 91, DateTimeKind.Local).AddTicks(2715) });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DataUpdated", "DateCreated" },
                values: new object[] { new DateTime(2022, 12, 16, 21, 51, 35, 92, DateTimeKind.Local).AddTicks(2985), new DateTime(2022, 12, 16, 21, 51, 35, 92, DateTimeKind.Local).AddTicks(2974) });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DataUpdated", "DateCreated" },
                values: new object[] { new DateTime(2022, 12, 16, 21, 51, 35, 92, DateTimeKind.Local).AddTicks(2990), new DateTime(2022, 12, 16, 21, 51, 35, 92, DateTimeKind.Local).AddTicks(2989) });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "DataUpdated", "DateCreated" },
                values: new object[] { new DateTime(2022, 12, 16, 21, 51, 35, 92, DateTimeKind.Local).AddTicks(2992), new DateTime(2022, 12, 16, 21, 51, 35, 92, DateTimeKind.Local).AddTicks(2991) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "Consultations",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "ConDate", "ConEndTime", "ConStartTime", "DataUpdated", "DateCreated" },
                values: new object[] { new DateTime(2022, 12, 16, 21, 45, 15, 704, DateTimeKind.Local).AddTicks(5647), new DateTime(2022, 12, 16, 22, 54, 15, 704, DateTimeKind.Local).AddTicks(5851), new DateTime(2022, 12, 16, 21, 45, 15, 704, DateTimeKind.Local).AddTicks(5762), new DateTime(2022, 12, 16, 21, 45, 15, 704, DateTimeKind.Local).AddTicks(6247), new DateTime(2022, 12, 16, 21, 45, 15, 704, DateTimeKind.Local).AddTicks(6246) });

            migrationBuilder.UpdateData(
                table: "Consultations",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "ConDate", "ConEndTime", "ConStartTime", "DataUpdated", "DateCreated" },
                values: new object[] { new DateTime(2022, 12, 16, 21, 45, 15, 704, DateTimeKind.Local).AddTicks(6250), new DateTime(2022, 12, 16, 22, 45, 15, 704, DateTimeKind.Local).AddTicks(6251), new DateTime(2022, 12, 16, 21, 45, 15, 704, DateTimeKind.Local).AddTicks(6251), new DateTime(2022, 12, 16, 21, 45, 15, 704, DateTimeKind.Local).AddTicks(6256), new DateTime(2022, 12, 16, 21, 45, 15, 704, DateTimeKind.Local).AddTicks(6255) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DataUpdated", "DateCreated" },
                values: new object[] { new DateTime(2022, 12, 16, 21, 45, 15, 703, DateTimeKind.Local).AddTicks(4105), new DateTime(2022, 12, 16, 21, 45, 15, 703, DateTimeKind.Local).AddTicks(4102) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DataUpdated", "DateCreated" },
                values: new object[] { new DateTime(2022, 12, 16, 21, 45, 15, 703, DateTimeKind.Local).AddTicks(4109), new DateTime(2022, 12, 16, 21, 45, 15, 703, DateTimeKind.Local).AddTicks(4108) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "DataUpdated", "DateCreated" },
                values: new object[] { new DateTime(2022, 12, 16, 21, 45, 15, 703, DateTimeKind.Local).AddTicks(4111), new DateTime(2022, 12, 16, 21, 45, 15, 703, DateTimeKind.Local).AddTicks(4111) });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DataUpdated", "DateCreated" },
                values: new object[] { new DateTime(2022, 12, 16, 21, 45, 15, 703, DateTimeKind.Local).AddTicks(8698), new DateTime(2022, 12, 16, 21, 45, 15, 703, DateTimeKind.Local).AddTicks(8695) });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DataUpdated", "DateCreated" },
                values: new object[] { new DateTime(2022, 12, 16, 21, 45, 15, 703, DateTimeKind.Local).AddTicks(8701), new DateTime(2022, 12, 16, 21, 45, 15, 703, DateTimeKind.Local).AddTicks(8700) });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "DataUpdated", "DateCreated" },
                values: new object[] { new DateTime(2022, 12, 16, 21, 45, 15, 703, DateTimeKind.Local).AddTicks(8704), new DateTime(2022, 12, 16, 21, 45, 15, 703, DateTimeKind.Local).AddTicks(8703) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DataUpdated", "DateCreated", "OrderDateTime" },
                values: new object[] { new DateTime(2022, 12, 16, 21, 45, 15, 703, DateTimeKind.Local).AddTicks(6596), new DateTime(2022, 12, 16, 21, 45, 15, 703, DateTimeKind.Local).AddTicks(6594), new DateTime(2022, 12, 16, 21, 45, 15, 703, DateTimeKind.Local).AddTicks(6344) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DataUpdated", "DateCreated", "OrderDateTime" },
                values: new object[] { new DateTime(2022, 12, 16, 21, 45, 15, 703, DateTimeKind.Local).AddTicks(6600), new DateTime(2022, 12, 16, 21, 45, 15, 703, DateTimeKind.Local).AddTicks(6599), new DateTime(2022, 12, 16, 21, 45, 15, 703, DateTimeKind.Local).AddTicks(6598) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DataUpdated", "DateCreated" },
                values: new object[] { new DateTime(2022, 12, 16, 21, 45, 15, 704, DateTimeKind.Local).AddTicks(1129), new DateTime(2022, 12, 16, 21, 45, 15, 704, DateTimeKind.Local).AddTicks(1125) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DataUpdated", "DateCreated" },
                values: new object[] { new DateTime(2022, 12, 16, 21, 45, 15, 704, DateTimeKind.Local).AddTicks(1132), new DateTime(2022, 12, 16, 21, 45, 15, 704, DateTimeKind.Local).AddTicks(1131) });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DataUpdated", "DateCreated" },
                values: new object[] { new DateTime(2022, 12, 16, 21, 45, 15, 704, DateTimeKind.Local).AddTicks(2965), new DateTime(2022, 12, 16, 21, 45, 15, 704, DateTimeKind.Local).AddTicks(2963) });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DataUpdated", "DateCreated" },
                values: new object[] { new DateTime(2022, 12, 16, 21, 45, 15, 704, DateTimeKind.Local).AddTicks(2968), new DateTime(2022, 12, 16, 21, 45, 15, 704, DateTimeKind.Local).AddTicks(2968) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DataUpdated", "DateCreated" },
                values: new object[] { new DateTime(2022, 12, 16, 21, 45, 15, 702, DateTimeKind.Local).AddTicks(897), new DateTime(2022, 12, 16, 21, 45, 15, 701, DateTimeKind.Local).AddTicks(5014) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DataUpdated", "DateCreated" },
                values: new object[] { new DateTime(2022, 12, 16, 21, 45, 15, 702, DateTimeKind.Local).AddTicks(1329), new DateTime(2022, 12, 16, 21, 45, 15, 702, DateTimeKind.Local).AddTicks(1327) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "DataUpdated", "DateCreated" },
                values: new object[] { new DateTime(2022, 12, 16, 21, 45, 15, 702, DateTimeKind.Local).AddTicks(1333), new DateTime(2022, 12, 16, 21, 45, 15, 702, DateTimeKind.Local).AddTicks(1332) });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DataUpdated", "DateCreated" },
                values: new object[] { new DateTime(2022, 12, 16, 21, 45, 15, 703, DateTimeKind.Local).AddTicks(1283), new DateTime(2022, 12, 16, 21, 45, 15, 703, DateTimeKind.Local).AddTicks(1275) });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DataUpdated", "DateCreated" },
                values: new object[] { new DateTime(2022, 12, 16, 21, 45, 15, 703, DateTimeKind.Local).AddTicks(1287), new DateTime(2022, 12, 16, 21, 45, 15, 703, DateTimeKind.Local).AddTicks(1286) });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "DataUpdated", "DateCreated" },
                values: new object[] { new DateTime(2022, 12, 16, 21, 45, 15, 703, DateTimeKind.Local).AddTicks(1290), new DateTime(2022, 12, 16, 21, 45, 15, 703, DateTimeKind.Local).AddTicks(1289) });
        }
    }
}
