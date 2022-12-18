using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TPharmacy.Server.Data.Migrations
{
    public partial class AddedUserInfo_User_Role_User : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

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

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "06b6ace8-5dab-4b76-862a-a439ab49fc71", "Administrator", "ADMINISTRATOR" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", "469d09db-0254-45e4-bac9-b1caed30ce36", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "Password", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "TPharmacy", "6a7e4eac-3989-4c6e-a59d-c8360136be80", "admin@localhost.com", true, "Admin", "User", true, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "P@ssword1", "AQAAAAEAACcQAAAAEH7T02jwE9h6PPSb9OE4U400fWcPolq2x3pKEnEJm5gJtimtXY8TWVc6J+xRkv6IHQ==", "0000", true, "3b780b3a-d335-4827-aa0e-882cb45a3a5e", false, "admin@localhost.com" },
                    { "3781efa7-66dc-47f0-860f-e506d04102e5", 0, "TPharmacy", "dff3c749-a30c-4dd8-a98c-cc0147e36b8f", "june@gmail.com", true, "Admin", "User", true, null, "JUNE@GMAIL.COM", "JUNE@GMAIL.COM", "June1234*", "AQAAAAEAACcQAAAAEEZHYKmXF3HvVYNCuN0R95ipAAH7sZEMgc5vs4xsrGaU11xPDaL4Tqo6kDffGaBTKw==", "0000", true, "43b9dbfc-db2b-4cbf-8aa9-b1216db9de42", false, "june@gmail.com" },
                    { "3781efa7-66dc-47f0-860f-e506d04102c4", 0, "Tampines Ave 1", "ffa20d44-c2e8-43b3-8b3a-28ba69c3c1c9", "james@gmail.com", true, "Customer", "User", true, null, "JAMES@GMAIL.COM", "JAMES@GMAIL.COM", "James1234*", "AQAAAAEAACcQAAAAEGVNBdeAz/6dQXEkt9vJcv/JRVQ2NN4p5oQhTvnGDjRn/xoRSYbnDF7L60xyDaqx0A==", "1111", true, "1bee6e7f-2513-4352-a5dd-fd3e75cd5973", false, "james@gmail.com" }
                });

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

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e5" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "bd2bcf0c-20db-474f-8407-5a6b159518bb", "3781efa7-66dc-47f0-860f-e506d04102c4" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "bd2bcf0c-20db-474f-8407-5a6b159518bb", "3781efa7-66dc-47f0-860f-e506d04102c4" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e5" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102c4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e5");

            migrationBuilder.DropColumn(
                name: "Address",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Password",
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
