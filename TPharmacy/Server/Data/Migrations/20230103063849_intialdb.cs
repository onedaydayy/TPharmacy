using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TPharmacy.Server.Data.Migrations
{
    public partial class intialdb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DataUpdated",
                table: "Staffs",
                newName: "DateUpdated");

            migrationBuilder.RenameColumn(
                name: "DataUpdated",
                table: "Products",
                newName: "DateUpdated");

            migrationBuilder.RenameColumn(
                name: "DataUpdated",
                table: "Prescriptions",
                newName: "DateUpdated");

            migrationBuilder.RenameColumn(
                name: "DataUpdated",
                table: "Payments",
                newName: "DateUpdated");

            migrationBuilder.RenameColumn(
                name: "DataUpdated",
                table: "Orders",
                newName: "DateUpdated");

            migrationBuilder.RenameColumn(
                name: "DataUpdated",
                table: "OrderItems",
                newName: "DateUpdated");

            migrationBuilder.RenameColumn(
                name: "DataUpdated",
                table: "Customers",
                newName: "DateUpdated");

            migrationBuilder.RenameColumn(
                name: "DataUpdated",
                table: "Consultations",
                newName: "DateUpdated");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba",
                column: "ConcurrencyStamp",
                value: "163ddf8d-f007-4d7b-832e-caa13f9810b9");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb",
                column: "ConcurrencyStamp",
                value: "4040f897-9a16-4beb-8ce3-58767a32e259");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102c4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8fda6028-2afd-4cc9-8171-ea74678f74fd", "AQAAAAEAACcQAAAAEEG1smhh66HhAbnJB0bPM0/LC0g86MqNkXByZxm7ARPmoa0etGHxEImyWQ02HrG36w==", "f4359931-8940-49d9-8849-d46ef692f900" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e02c666d-dda3-4f7d-b846-252e5377de7a", "AQAAAAEAACcQAAAAEIu5Tg9iXWOeikr0o5W4EkXvA6mkGpGI5Y04mZtAo/hy3wEGJdfDnHZQ00xJykiA0A==", "640a07c5-b069-4ada-acaa-b5fe708567e0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "63a5cee0-7c6c-4d21-9444-5b512ae5ecdc", "AQAAAAEAACcQAAAAEFomUM5U4wILi7dZ3HZ8DIhLn9Nss+CHVlfbcKfk9B/lhm2LjwAd9ATgdjd0YhoKeA==", "2f793376-a775-4bda-af3f-34eca336e010" });

            migrationBuilder.UpdateData(
                table: "Consultations",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "ConDate", "ConEndTime", "ConStartTime", "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 3, 14, 38, 49, 304, DateTimeKind.Local).AddTicks(6093), new DateTime(2023, 1, 3, 15, 47, 49, 304, DateTimeKind.Local).AddTicks(6324), new DateTime(2023, 1, 3, 14, 38, 49, 304, DateTimeKind.Local).AddTicks(6227), new DateTime(2023, 1, 3, 14, 38, 49, 304, DateTimeKind.Local).AddTicks(6742), new DateTime(2023, 1, 3, 14, 38, 49, 304, DateTimeKind.Local).AddTicks(6743) });

            migrationBuilder.UpdateData(
                table: "Consultations",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "ConDate", "ConEndTime", "ConStartTime", "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 3, 14, 38, 49, 304, DateTimeKind.Local).AddTicks(6746), new DateTime(2023, 1, 3, 15, 38, 49, 304, DateTimeKind.Local).AddTicks(6747), new DateTime(2023, 1, 3, 14, 38, 49, 304, DateTimeKind.Local).AddTicks(6747), new DateTime(2023, 1, 3, 14, 38, 49, 304, DateTimeKind.Local).AddTicks(6752), new DateTime(2023, 1, 3, 14, 38, 49, 304, DateTimeKind.Local).AddTicks(6752) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 3, 14, 38, 49, 303, DateTimeKind.Local).AddTicks(1768), new DateTime(2023, 1, 3, 14, 38, 49, 303, DateTimeKind.Local).AddTicks(1775) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 3, 14, 38, 49, 303, DateTimeKind.Local).AddTicks(1778), new DateTime(2023, 1, 3, 14, 38, 49, 303, DateTimeKind.Local).AddTicks(1779) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 3, 14, 38, 49, 303, DateTimeKind.Local).AddTicks(1781), new DateTime(2023, 1, 3, 14, 38, 49, 303, DateTimeKind.Local).AddTicks(1782) });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 3, 14, 38, 49, 303, DateTimeKind.Local).AddTicks(8303), new DateTime(2023, 1, 3, 14, 38, 49, 303, DateTimeKind.Local).AddTicks(8309) });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 3, 14, 38, 49, 303, DateTimeKind.Local).AddTicks(8311), new DateTime(2023, 1, 3, 14, 38, 49, 303, DateTimeKind.Local).AddTicks(8312) });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 3, 14, 38, 49, 303, DateTimeKind.Local).AddTicks(8314), new DateTime(2023, 1, 3, 14, 38, 49, 303, DateTimeKind.Local).AddTicks(8315) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated", "OrderDateTime" },
                values: new object[] { new DateTime(2023, 1, 3, 14, 38, 49, 303, DateTimeKind.Local).AddTicks(5408), new DateTime(2023, 1, 3, 14, 38, 49, 303, DateTimeKind.Local).AddTicks(5409), new DateTime(2023, 1, 3, 14, 38, 49, 303, DateTimeKind.Local).AddTicks(5091) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated", "OrderDateTime" },
                values: new object[] { new DateTime(2023, 1, 3, 14, 38, 49, 303, DateTimeKind.Local).AddTicks(5414), new DateTime(2023, 1, 3, 14, 38, 49, 303, DateTimeKind.Local).AddTicks(5415), new DateTime(2023, 1, 3, 14, 38, 49, 303, DateTimeKind.Local).AddTicks(5413) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 3, 14, 38, 49, 304, DateTimeKind.Local).AddTicks(830), new DateTime(2023, 1, 3, 14, 38, 49, 304, DateTimeKind.Local).AddTicks(833) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 3, 14, 38, 49, 304, DateTimeKind.Local).AddTicks(836), new DateTime(2023, 1, 3, 14, 38, 49, 304, DateTimeKind.Local).AddTicks(836) });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 3, 14, 38, 49, 304, DateTimeKind.Local).AddTicks(2744), new DateTime(2023, 1, 3, 14, 38, 49, 304, DateTimeKind.Local).AddTicks(2747) });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 3, 14, 38, 49, 304, DateTimeKind.Local).AddTicks(2749), new DateTime(2023, 1, 3, 14, 38, 49, 304, DateTimeKind.Local).AddTicks(2750) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 3, 14, 38, 49, 300, DateTimeKind.Local).AddTicks(9432), new DateTime(2023, 1, 3, 14, 38, 49, 301, DateTimeKind.Local).AddTicks(5824) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 3, 14, 38, 49, 301, DateTimeKind.Local).AddTicks(6357), new DateTime(2023, 1, 3, 14, 38, 49, 301, DateTimeKind.Local).AddTicks(6359) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 3, 14, 38, 49, 301, DateTimeKind.Local).AddTicks(6362), new DateTime(2023, 1, 3, 14, 38, 49, 301, DateTimeKind.Local).AddTicks(6363) });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 3, 14, 38, 49, 302, DateTimeKind.Local).AddTicks(6547), new DateTime(2023, 1, 3, 14, 38, 49, 302, DateTimeKind.Local).AddTicks(6556) });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 3, 14, 38, 49, 302, DateTimeKind.Local).AddTicks(6559), new DateTime(2023, 1, 3, 14, 38, 49, 302, DateTimeKind.Local).AddTicks(6560) });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 3, 14, 38, 49, 302, DateTimeKind.Local).AddTicks(6562), new DateTime(2023, 1, 3, 14, 38, 49, 302, DateTimeKind.Local).AddTicks(6563) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DateUpdated",
                table: "Staffs",
                newName: "DataUpdated");

            migrationBuilder.RenameColumn(
                name: "DateUpdated",
                table: "Products",
                newName: "DataUpdated");

            migrationBuilder.RenameColumn(
                name: "DateUpdated",
                table: "Prescriptions",
                newName: "DataUpdated");

            migrationBuilder.RenameColumn(
                name: "DateUpdated",
                table: "Payments",
                newName: "DataUpdated");

            migrationBuilder.RenameColumn(
                name: "DateUpdated",
                table: "Orders",
                newName: "DataUpdated");

            migrationBuilder.RenameColumn(
                name: "DateUpdated",
                table: "OrderItems",
                newName: "DataUpdated");

            migrationBuilder.RenameColumn(
                name: "DateUpdated",
                table: "Customers",
                newName: "DataUpdated");

            migrationBuilder.RenameColumn(
                name: "DateUpdated",
                table: "Consultations",
                newName: "DataUpdated");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba",
                column: "ConcurrencyStamp",
                value: "06b6ace8-5dab-4b76-862a-a439ab49fc71");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb",
                column: "ConcurrencyStamp",
                value: "469d09db-0254-45e4-bac9-b1caed30ce36");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102c4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ffa20d44-c2e8-43b3-8b3a-28ba69c3c1c9", "AQAAAAEAACcQAAAAEGVNBdeAz/6dQXEkt9vJcv/JRVQ2NN4p5oQhTvnGDjRn/xoRSYbnDF7L60xyDaqx0A==", "1bee6e7f-2513-4352-a5dd-fd3e75cd5973" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6a7e4eac-3989-4c6e-a59d-c8360136be80", "AQAAAAEAACcQAAAAEH7T02jwE9h6PPSb9OE4U400fWcPolq2x3pKEnEJm5gJtimtXY8TWVc6J+xRkv6IHQ==", "3b780b3a-d335-4827-aa0e-882cb45a3a5e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dff3c749-a30c-4dd8-a98c-cc0147e36b8f", "AQAAAAEAACcQAAAAEEZHYKmXF3HvVYNCuN0R95ipAAH7sZEMgc5vs4xsrGaU11xPDaL4Tqo6kDffGaBTKw==", "43b9dbfc-db2b-4cbf-8aa9-b1216db9de42" });

            migrationBuilder.UpdateData(
                table: "Consultations",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "ConDate", "ConEndTime", "ConStartTime", "DataUpdated", "DateCreated" },
                values: new object[] { new DateTime(2022, 12, 18, 23, 5, 25, 710, DateTimeKind.Local).AddTicks(1715), new DateTime(2022, 12, 19, 0, 14, 25, 710, DateTimeKind.Local).AddTicks(1922), new DateTime(2022, 12, 18, 23, 5, 25, 710, DateTimeKind.Local).AddTicks(1832), new DateTime(2022, 12, 18, 23, 5, 25, 710, DateTimeKind.Local).AddTicks(2333), new DateTime(2022, 12, 18, 23, 5, 25, 710, DateTimeKind.Local).AddTicks(2332) });

            migrationBuilder.UpdateData(
                table: "Consultations",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "ConDate", "ConEndTime", "ConStartTime", "DataUpdated", "DateCreated" },
                values: new object[] { new DateTime(2022, 12, 18, 23, 5, 25, 710, DateTimeKind.Local).AddTicks(2335), new DateTime(2022, 12, 19, 0, 5, 25, 710, DateTimeKind.Local).AddTicks(2337), new DateTime(2022, 12, 18, 23, 5, 25, 710, DateTimeKind.Local).AddTicks(2336), new DateTime(2022, 12, 18, 23, 5, 25, 710, DateTimeKind.Local).AddTicks(2341), new DateTime(2022, 12, 18, 23, 5, 25, 710, DateTimeKind.Local).AddTicks(2340) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DataUpdated", "DateCreated" },
                values: new object[] { new DateTime(2022, 12, 18, 23, 5, 25, 708, DateTimeKind.Local).AddTicks(9909), new DateTime(2022, 12, 18, 23, 5, 25, 708, DateTimeKind.Local).AddTicks(9906) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DataUpdated", "DateCreated" },
                values: new object[] { new DateTime(2022, 12, 18, 23, 5, 25, 708, DateTimeKind.Local).AddTicks(9913), new DateTime(2022, 12, 18, 23, 5, 25, 708, DateTimeKind.Local).AddTicks(9912) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "DataUpdated", "DateCreated" },
                values: new object[] { new DateTime(2022, 12, 18, 23, 5, 25, 708, DateTimeKind.Local).AddTicks(9915), new DateTime(2022, 12, 18, 23, 5, 25, 708, DateTimeKind.Local).AddTicks(9915) });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DataUpdated", "DateCreated" },
                values: new object[] { new DateTime(2022, 12, 18, 23, 5, 25, 709, DateTimeKind.Local).AddTicks(4705), new DateTime(2022, 12, 18, 23, 5, 25, 709, DateTimeKind.Local).AddTicks(4702) });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DataUpdated", "DateCreated" },
                values: new object[] { new DateTime(2022, 12, 18, 23, 5, 25, 709, DateTimeKind.Local).AddTicks(4708), new DateTime(2022, 12, 18, 23, 5, 25, 709, DateTimeKind.Local).AddTicks(4707) });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "DataUpdated", "DateCreated" },
                values: new object[] { new DateTime(2022, 12, 18, 23, 5, 25, 709, DateTimeKind.Local).AddTicks(4710), new DateTime(2022, 12, 18, 23, 5, 25, 709, DateTimeKind.Local).AddTicks(4709) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DataUpdated", "DateCreated", "OrderDateTime" },
                values: new object[] { new DateTime(2022, 12, 18, 23, 5, 25, 709, DateTimeKind.Local).AddTicks(2639), new DateTime(2022, 12, 18, 23, 5, 25, 709, DateTimeKind.Local).AddTicks(2638), new DateTime(2022, 12, 18, 23, 5, 25, 709, DateTimeKind.Local).AddTicks(2377) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DataUpdated", "DateCreated", "OrderDateTime" },
                values: new object[] { new DateTime(2022, 12, 18, 23, 5, 25, 709, DateTimeKind.Local).AddTicks(2644), new DateTime(2022, 12, 18, 23, 5, 25, 709, DateTimeKind.Local).AddTicks(2643), new DateTime(2022, 12, 18, 23, 5, 25, 709, DateTimeKind.Local).AddTicks(2642) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DataUpdated", "DateCreated" },
                values: new object[] { new DateTime(2022, 12, 18, 23, 5, 25, 709, DateTimeKind.Local).AddTicks(7026), new DateTime(2022, 12, 18, 23, 5, 25, 709, DateTimeKind.Local).AddTicks(7023) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DataUpdated", "DateCreated" },
                values: new object[] { new DateTime(2022, 12, 18, 23, 5, 25, 709, DateTimeKind.Local).AddTicks(7029), new DateTime(2022, 12, 18, 23, 5, 25, 709, DateTimeKind.Local).AddTicks(7029) });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DataUpdated", "DateCreated" },
                values: new object[] { new DateTime(2022, 12, 18, 23, 5, 25, 709, DateTimeKind.Local).AddTicks(8800), new DateTime(2022, 12, 18, 23, 5, 25, 709, DateTimeKind.Local).AddTicks(8797) });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DataUpdated", "DateCreated" },
                values: new object[] { new DateTime(2022, 12, 18, 23, 5, 25, 709, DateTimeKind.Local).AddTicks(8803), new DateTime(2022, 12, 18, 23, 5, 25, 709, DateTimeKind.Local).AddTicks(8802) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DataUpdated", "DateCreated" },
                values: new object[] { new DateTime(2022, 12, 18, 23, 5, 25, 707, DateTimeKind.Local).AddTicks(6532), new DateTime(2022, 12, 18, 23, 5, 25, 707, DateTimeKind.Local).AddTicks(289) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DataUpdated", "DateCreated" },
                values: new object[] { new DateTime(2022, 12, 18, 23, 5, 25, 707, DateTimeKind.Local).AddTicks(7037), new DateTime(2022, 12, 18, 23, 5, 25, 707, DateTimeKind.Local).AddTicks(7033) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "DataUpdated", "DateCreated" },
                values: new object[] { new DateTime(2022, 12, 18, 23, 5, 25, 707, DateTimeKind.Local).AddTicks(7040), new DateTime(2022, 12, 18, 23, 5, 25, 707, DateTimeKind.Local).AddTicks(7039) });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DataUpdated", "DateCreated" },
                values: new object[] { new DateTime(2022, 12, 18, 23, 5, 25, 708, DateTimeKind.Local).AddTicks(7150), new DateTime(2022, 12, 18, 23, 5, 25, 708, DateTimeKind.Local).AddTicks(7139) });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DataUpdated", "DateCreated" },
                values: new object[] { new DateTime(2022, 12, 18, 23, 5, 25, 708, DateTimeKind.Local).AddTicks(7154), new DateTime(2022, 12, 18, 23, 5, 25, 708, DateTimeKind.Local).AddTicks(7153) });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "DataUpdated", "DateCreated" },
                values: new object[] { new DateTime(2022, 12, 18, 23, 5, 25, 708, DateTimeKind.Local).AddTicks(7156), new DateTime(2022, 12, 18, 23, 5, 25, 708, DateTimeKind.Local).AddTicks(7155) });
        }
    }
}
