using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TPharmacy.Server.Data.Migrations
{
    public partial class ModifiedSeedingDataTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "403a8062-6472-4234-b2ac-c651cdcca513", "Administrator", "ADMINISTRATOR" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", "4a6f6f91-8561-4c16-92b7-7f9dde0d9523", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "c32c70e2-eeab-4a0a-be60-b3b3663edd24", "admin@localhost.com", false, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN", "AQAAAAEAACcQAAAAEFachoZsDIRafU5dZduoejMlGucHfnwO5JlVxYm4olVRuK55osgYBtGNgHnLCRKGBg==", null, false, "fdbbf15d-1774-48a8-b367-88f392f423dc", false, "Admin" },
                    { "3781efa7-66dc-47f0-860f-e506d04102e5", 0, "ce414245-203d-4159-9a8b-8758390e319b", "june@gmail.com", false, "Admin", "User", false, null, "JUNE@GMAIL.COM", "JUNE", "AQAAAAEAACcQAAAAEIYsDNfSm9HOQHN2jMpb8o3j1KIokC80F2IZvTmaKSQ2W/Eap0zvwazIv1VjdupRXA==", null, false, "70a10d3d-ec55-4ca5-ba9f-f2865cfaa4a2", false, "June" },
                    { "3781efa7-66dc-47f0-860f-e506d04102c4", 0, "2c99ffe4-bb5a-4983-8ef1-bffeca9e9e14", "james@gmail.com", false, "Customer", "User", false, null, "JAMES@GMAIL.COM", "CUSTOMER", "AQAAAAEAACcQAAAAEDYzuaMavkfEYLBreSqTJSBambKJd+dEOAvNcuWlI2986FtUtihw7v7G1g+9bvXSxA==", null, false, "ba2d8d61-eb9c-40ea-953f-70f9a4787e64", false, "Customer" }
                });

            migrationBuilder.UpdateData(
                table: "Consultations",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "ConDate", "ConEndTime", "ConStartTime", "DataUpdated", "DateCreated" },
                values: new object[] { new DateTime(2022, 12, 18, 14, 2, 21, 230, DateTimeKind.Local).AddTicks(6858), new DateTime(2022, 12, 18, 15, 11, 21, 230, DateTimeKind.Local).AddTicks(8247), new DateTime(2022, 12, 18, 14, 2, 21, 230, DateTimeKind.Local).AddTicks(7435), new DateTime(2022, 12, 18, 14, 2, 21, 231, DateTimeKind.Local).AddTicks(1010), new DateTime(2022, 12, 18, 14, 2, 21, 231, DateTimeKind.Local).AddTicks(996) });

            migrationBuilder.UpdateData(
                table: "Consultations",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "ConDate", "ConEndTime", "ConStartTime", "DataUpdated", "DateCreated" },
                values: new object[] { new DateTime(2022, 12, 18, 14, 2, 21, 231, DateTimeKind.Local).AddTicks(1021), new DateTime(2022, 12, 18, 15, 2, 21, 231, DateTimeKind.Local).AddTicks(1025), new DateTime(2022, 12, 18, 14, 2, 21, 231, DateTimeKind.Local).AddTicks(1023), new DateTime(2022, 12, 18, 14, 2, 21, 231, DateTimeKind.Local).AddTicks(1047), new DateTime(2022, 12, 18, 14, 2, 21, 231, DateTimeKind.Local).AddTicks(1045) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DataUpdated", "DateCreated" },
                values: new object[] { new DateTime(2022, 12, 18, 14, 2, 21, 227, DateTimeKind.Local).AddTicks(9763), new DateTime(2022, 12, 18, 14, 2, 21, 227, DateTimeKind.Local).AddTicks(9754) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DataUpdated", "DateCreated" },
                values: new object[] { new DateTime(2022, 12, 18, 14, 2, 21, 227, DateTimeKind.Local).AddTicks(9770), new DateTime(2022, 12, 18, 14, 2, 21, 227, DateTimeKind.Local).AddTicks(9769) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "DataUpdated", "DateCreated" },
                values: new object[] { new DateTime(2022, 12, 18, 14, 2, 21, 227, DateTimeKind.Local).AddTicks(9775), new DateTime(2022, 12, 18, 14, 2, 21, 227, DateTimeKind.Local).AddTicks(9773) });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DataUpdated", "DateCreated" },
                values: new object[] { new DateTime(2022, 12, 18, 14, 2, 21, 229, DateTimeKind.Local).AddTicks(464), new DateTime(2022, 12, 18, 14, 2, 21, 229, DateTimeKind.Local).AddTicks(454) });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DataUpdated", "DateCreated" },
                values: new object[] { new DateTime(2022, 12, 18, 14, 2, 21, 229, DateTimeKind.Local).AddTicks(471), new DateTime(2022, 12, 18, 14, 2, 21, 229, DateTimeKind.Local).AddTicks(469) });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "DataUpdated", "DateCreated" },
                values: new object[] { new DateTime(2022, 12, 18, 14, 2, 21, 229, DateTimeKind.Local).AddTicks(475), new DateTime(2022, 12, 18, 14, 2, 21, 229, DateTimeKind.Local).AddTicks(474) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DataUpdated", "DateCreated", "OrderDateTime" },
                values: new object[] { new DateTime(2022, 12, 18, 14, 2, 21, 228, DateTimeKind.Local).AddTicks(5384), new DateTime(2022, 12, 18, 14, 2, 21, 228, DateTimeKind.Local).AddTicks(5379), new DateTime(2022, 12, 18, 14, 2, 21, 228, DateTimeKind.Local).AddTicks(4765) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DataUpdated", "DateCreated", "OrderDateTime" },
                values: new object[] { new DateTime(2022, 12, 18, 14, 2, 21, 228, DateTimeKind.Local).AddTicks(5394), new DateTime(2022, 12, 18, 14, 2, 21, 228, DateTimeKind.Local).AddTicks(5392), new DateTime(2022, 12, 18, 14, 2, 21, 228, DateTimeKind.Local).AddTicks(5390) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DataUpdated", "DateCreated" },
                values: new object[] { new DateTime(2022, 12, 18, 14, 2, 21, 229, DateTimeKind.Local).AddTicks(5458), new DateTime(2022, 12, 18, 14, 2, 21, 229, DateTimeKind.Local).AddTicks(5447) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DataUpdated", "DateCreated" },
                values: new object[] { new DateTime(2022, 12, 18, 14, 2, 21, 229, DateTimeKind.Local).AddTicks(5466), new DateTime(2022, 12, 18, 14, 2, 21, 229, DateTimeKind.Local).AddTicks(5464) });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DataUpdated", "DateCreated" },
                values: new object[] { new DateTime(2022, 12, 18, 14, 2, 21, 229, DateTimeKind.Local).AddTicks(9601), new DateTime(2022, 12, 18, 14, 2, 21, 229, DateTimeKind.Local).AddTicks(9592) });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DataUpdated", "DateCreated" },
                values: new object[] { new DateTime(2022, 12, 18, 14, 2, 21, 229, DateTimeKind.Local).AddTicks(9608), new DateTime(2022, 12, 18, 14, 2, 21, 229, DateTimeKind.Local).AddTicks(9606) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DataUpdated", "DateCreated" },
                values: new object[] { new DateTime(2022, 12, 18, 14, 2, 21, 225, DateTimeKind.Local).AddTicks(5200), new DateTime(2022, 12, 18, 14, 2, 21, 224, DateTimeKind.Local).AddTicks(3695) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DataUpdated", "DateCreated" },
                values: new object[] { new DateTime(2022, 12, 18, 14, 2, 21, 225, DateTimeKind.Local).AddTicks(6123), new DateTime(2022, 12, 18, 14, 2, 21, 225, DateTimeKind.Local).AddTicks(6118) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "DataUpdated", "DateCreated" },
                values: new object[] { new DateTime(2022, 12, 18, 14, 2, 21, 225, DateTimeKind.Local).AddTicks(6128), new DateTime(2022, 12, 18, 14, 2, 21, 225, DateTimeKind.Local).AddTicks(6127) });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DataUpdated", "DateCreated" },
                values: new object[] { new DateTime(2022, 12, 18, 14, 2, 21, 227, DateTimeKind.Local).AddTicks(3838), new DateTime(2022, 12, 18, 14, 2, 21, 227, DateTimeKind.Local).AddTicks(3821) });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DataUpdated", "DateCreated" },
                values: new object[] { new DateTime(2022, 12, 18, 14, 2, 21, 227, DateTimeKind.Local).AddTicks(3845), new DateTime(2022, 12, 18, 14, 2, 21, 227, DateTimeKind.Local).AddTicks(3844) });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "DataUpdated", "DateCreated" },
                values: new object[] { new DateTime(2022, 12, 18, 14, 2, 21, 227, DateTimeKind.Local).AddTicks(3850), new DateTime(2022, 12, 18, 14, 2, 21, 227, DateTimeKind.Local).AddTicks(3848) });

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
    }
}
