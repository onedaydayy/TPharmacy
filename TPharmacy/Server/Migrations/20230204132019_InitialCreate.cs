using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TPharmacy.Server.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "admin",
                column: "ConcurrencyStamp",
                value: "125d3f56-5987-4e5b-a8cc-88783201315b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "customer",
                column: "ConcurrencyStamp",
                value: "abe3c478-7d29-44cd-999b-d20455973371");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "packer",
                column: "ConcurrencyStamp",
                value: "65a5a975-037a-40eb-b091-9f6ee7d72479");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "pharmacist",
                column: "ConcurrencyStamp",
                value: "05270925-a92e-4b0f-8db3-6306af92ad0b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "staff",
                column: "ConcurrencyStamp",
                value: "05f0f5f4-3d73-4888-923f-77f172ac8a59");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102c1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c0b8a9fa-a347-4db2-b83f-0a210fe2fb52", "AQAAAAEAACcQAAAAELM/LJAbxYw1GhtS5ozRLYRD6xMTN5w1Qx7hxCdw7wois4SbDO26/FxsjcV94EfxqQ==", "9a54e5a7-87ad-43c5-8ae2-09ebcf005c5f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102c2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "646b8c3a-9f3a-40a8-ba91-333e7f939d9f", "AQAAAAEAACcQAAAAECTNbRVjJBY8ZA1d9qHVaQHaYX/3hdVCnQHNvM6oMH49QxnPZo1rWF8Jcx8MZXMZMQ==", "4d98b456-e883-4756-ba26-ced989b368a5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102c3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4a2bab3e-19da-45bb-adc4-3decc65915dc", "AQAAAAEAACcQAAAAEMdWylh2Bzxf4bzxZvhv75x9/ccKCmpTYkvdJPz86KYIandpooSA5tfOODVVS/RJrA==", "ce2786fd-e532-4df7-8769-d7e6e7991058" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102s1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "57e93427-1b6c-4af0-8515-15c3590b075e", "AQAAAAEAACcQAAAAEOMZQ0Myqx+dRCam2gI1reXLk0ZSAa8ufQK8NSFC9qpQumfJ1A3Y5J+orRMjZxFUOg==", "1680ed53-6dba-481f-8385-bd9813115326" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102s2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cdb686de-b531-4fea-879e-3804bbae9815", "AQAAAAEAACcQAAAAECrjPZE7oKC1BxGBGOlJeNCUhbMiqdquZRBMilO32jWjYR1Mb8mr8oHYlZsA4VhyNw==", "6873b0d9-5acf-422f-9e6c-f477cd63fdc9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102s3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6e2c9ab1-dca2-40c1-929f-448b686837e9", "AQAAAAEAACcQAAAAEEq2oi6hYiJnWNGYuwohxMLaUjOo1cFZPsQSfHxcQcBmHFAy1cbZkcrEX7c2QR2SJw==", "402e0391-5e9c-4e7f-860b-7f4854beda4b" });

            migrationBuilder.UpdateData(
                table: "Consultations",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "ConDate", "ConEndTime", "ConStartTime", "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 2, 4, 21, 20, 17, 992, DateTimeKind.Local).AddTicks(8629), new DateTime(2023, 2, 4, 22, 29, 17, 992, DateTimeKind.Local).AddTicks(9977), new DateTime(2023, 2, 4, 21, 20, 17, 992, DateTimeKind.Local).AddTicks(9025), new DateTime(2023, 2, 4, 21, 20, 17, 993, DateTimeKind.Local).AddTicks(1648), new DateTime(2023, 2, 4, 21, 20, 17, 993, DateTimeKind.Local).AddTicks(1655) });

            migrationBuilder.UpdateData(
                table: "Consultations",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "ConDate", "ConEndTime", "ConStartTime", "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 2, 4, 21, 20, 17, 993, DateTimeKind.Local).AddTicks(1660), new DateTime(2023, 2, 4, 22, 20, 17, 993, DateTimeKind.Local).AddTicks(1664), new DateTime(2023, 2, 4, 21, 20, 17, 993, DateTimeKind.Local).AddTicks(1662), new DateTime(2023, 2, 4, 21, 20, 17, 993, DateTimeKind.Local).AddTicks(1674), new DateTime(2023, 2, 4, 21, 20, 17, 993, DateTimeKind.Local).AddTicks(1676) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 2, 4, 21, 20, 17, 990, DateTimeKind.Local).AddTicks(5801), new DateTime(2023, 2, 4, 21, 20, 17, 990, DateTimeKind.Local).AddTicks(5817) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 2, 4, 21, 20, 17, 990, DateTimeKind.Local).AddTicks(5823), new DateTime(2023, 2, 4, 21, 20, 17, 990, DateTimeKind.Local).AddTicks(5824) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 2, 4, 21, 20, 17, 990, DateTimeKind.Local).AddTicks(5827), new DateTime(2023, 2, 4, 21, 20, 17, 990, DateTimeKind.Local).AddTicks(5828) });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 2, 4, 21, 20, 17, 991, DateTimeKind.Local).AddTicks(5265), new DateTime(2023, 2, 4, 21, 20, 17, 991, DateTimeKind.Local).AddTicks(5280) });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 2, 4, 21, 20, 17, 991, DateTimeKind.Local).AddTicks(5288), new DateTime(2023, 2, 4, 21, 20, 17, 991, DateTimeKind.Local).AddTicks(5292) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 2, 4, 21, 20, 17, 985, DateTimeKind.Local).AddTicks(492), new DateTime(2023, 2, 4, 21, 20, 17, 986, DateTimeKind.Local).AddTicks(8509) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 2, 4, 21, 20, 17, 987, DateTimeKind.Local).AddTicks(1078), new DateTime(2023, 2, 4, 21, 20, 17, 987, DateTimeKind.Local).AddTicks(1088) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 2, 4, 21, 20, 17, 987, DateTimeKind.Local).AddTicks(1093), new DateTime(2023, 2, 4, 21, 20, 17, 987, DateTimeKind.Local).AddTicks(1095) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 2, 4, 21, 20, 17, 987, DateTimeKind.Local).AddTicks(1100), new DateTime(2023, 2, 4, 21, 20, 17, 987, DateTimeKind.Local).AddTicks(1102) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 2, 4, 21, 20, 17, 987, DateTimeKind.Local).AddTicks(1105), new DateTime(2023, 2, 4, 21, 20, 17, 987, DateTimeKind.Local).AddTicks(1107) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 2, 4, 21, 20, 17, 987, DateTimeKind.Local).AddTicks(1111), new DateTime(2023, 2, 4, 21, 20, 17, 987, DateTimeKind.Local).AddTicks(1113) });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 2, 4, 21, 20, 17, 989, DateTimeKind.Local).AddTicks(6473), new DateTime(2023, 2, 4, 21, 20, 17, 989, DateTimeKind.Local).AddTicks(6499) });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 2, 4, 21, 20, 17, 989, DateTimeKind.Local).AddTicks(6505), new DateTime(2023, 2, 4, 21, 20, 17, 989, DateTimeKind.Local).AddTicks(6507) });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 2, 4, 21, 20, 17, 989, DateTimeKind.Local).AddTicks(6510), new DateTime(2023, 2, 4, 21, 20, 17, 989, DateTimeKind.Local).AddTicks(6511) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "admin",
                column: "ConcurrencyStamp",
                value: "ea6442b6-ee05-4fae-9e7e-c8e748d250b1");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "customer",
                column: "ConcurrencyStamp",
                value: "5f99df66-8bf9-4237-8d58-040f3a026189");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "packer",
                column: "ConcurrencyStamp",
                value: "56c9e86b-f3e0-42d8-8178-1236fa34b1f8");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "pharmacist",
                column: "ConcurrencyStamp",
                value: "e6e40750-f124-4bc7-a0cb-2dd82d12e1f1");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "staff",
                column: "ConcurrencyStamp",
                value: "35502cfc-e891-4828-b9d9-024c2b4c65de");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102c1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fc1a1dd3-e0a8-414f-8704-a11bb35bf083", "AQAAAAEAACcQAAAAENLEg+rimT0CSyV3stiNP8zpJFgKcj1cg+789cMXbRwHelIbY6L5V00/JQXs+iVm6g==", "2574fa54-6d8b-4ccd-a522-101ed4191ef0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102c2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "43f57748-382a-4e8c-b6d3-c9df3d38ade6", "AQAAAAEAACcQAAAAEGUAVUp8xy8ZG8G2TroiFp5Cyj1yyvFeQcmOhhoe9SpaJiqciVOJet2+rPfyk0RdPg==", "563d9b7d-952e-4232-8310-82f34108238c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102c3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1b70931d-9fe8-4e64-a901-47c4c206ab4c", "AQAAAAEAACcQAAAAEDppuOxvfiAuQTwWLCA1sLmWCVsidFw/CsMsIA6PHxzA/2DNOU5gwz7f39Hg7MvBCg==", "9b9bc020-fea4-4b3c-9f49-d8a0d46a0a9a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102s1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d07a0a3d-9319-4655-a62d-5f50976f6cd3", "AQAAAAEAACcQAAAAEPQd9HJK3iWQXmNnaLaH7BYIiMD2UGEBGcziB00fMPNvVXzwLjUoo0dn4nLykDZTpQ==", "88a7f02d-7b41-422c-a0d0-847783001344" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102s2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fba1efa4-3737-44c8-9386-ac840131a563", "AQAAAAEAACcQAAAAEDWEK+CrZ9iPcwRJWRPbDXxBW4kSHHVtfMlvtb5AKniSyuCsyokEeC+Plw3s3fxXiA==", "9384e1bc-f0e6-419b-be9a-130c787819c3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102s3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "066df273-504e-44b6-87cb-cccd6bc89019", "AQAAAAEAACcQAAAAEBwW2qeoZYeGmnnt7/fgwpFwbx8WEwClXubUjKW0xVuXFqGJzVqhtpl5Or0PT3jx3Q==", "8778ceed-2144-40c8-9ca8-1453610a5565" });

            migrationBuilder.UpdateData(
                table: "Consultations",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "ConDate", "ConEndTime", "ConStartTime", "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 2, 3, 18, 25, 55, 136, DateTimeKind.Local).AddTicks(2516), new DateTime(2023, 2, 3, 19, 34, 55, 136, DateTimeKind.Local).AddTicks(3180), new DateTime(2023, 2, 3, 18, 25, 55, 136, DateTimeKind.Local).AddTicks(2672), new DateTime(2023, 2, 3, 18, 25, 55, 136, DateTimeKind.Local).AddTicks(3938), new DateTime(2023, 2, 3, 18, 25, 55, 136, DateTimeKind.Local).AddTicks(3942) });

            migrationBuilder.UpdateData(
                table: "Consultations",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "ConDate", "ConEndTime", "ConStartTime", "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 2, 3, 18, 25, 55, 136, DateTimeKind.Local).AddTicks(3946), new DateTime(2023, 2, 3, 19, 25, 55, 136, DateTimeKind.Local).AddTicks(3948), new DateTime(2023, 2, 3, 18, 25, 55, 136, DateTimeKind.Local).AddTicks(3947), new DateTime(2023, 2, 3, 18, 25, 55, 136, DateTimeKind.Local).AddTicks(3955), new DateTime(2023, 2, 3, 18, 25, 55, 136, DateTimeKind.Local).AddTicks(3956) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 2, 3, 18, 25, 55, 135, DateTimeKind.Local).AddTicks(5463), new DateTime(2023, 2, 3, 18, 25, 55, 135, DateTimeKind.Local).AddTicks(5471) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 2, 3, 18, 25, 55, 135, DateTimeKind.Local).AddTicks(5474), new DateTime(2023, 2, 3, 18, 25, 55, 135, DateTimeKind.Local).AddTicks(5475) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 2, 3, 18, 25, 55, 135, DateTimeKind.Local).AddTicks(5477), new DateTime(2023, 2, 3, 18, 25, 55, 135, DateTimeKind.Local).AddTicks(5478) });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 2, 3, 18, 25, 55, 135, DateTimeKind.Local).AddTicks(8553), new DateTime(2023, 2, 3, 18, 25, 55, 135, DateTimeKind.Local).AddTicks(8559) });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 2, 3, 18, 25, 55, 135, DateTimeKind.Local).AddTicks(8563), new DateTime(2023, 2, 3, 18, 25, 55, 135, DateTimeKind.Local).AddTicks(8564) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 2, 3, 18, 25, 55, 132, DateTimeKind.Local).AddTicks(9894), new DateTime(2023, 2, 3, 18, 25, 55, 133, DateTimeKind.Local).AddTicks(8501) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 2, 3, 18, 25, 55, 133, DateTimeKind.Local).AddTicks(9033), new DateTime(2023, 2, 3, 18, 25, 55, 133, DateTimeKind.Local).AddTicks(9036) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 2, 3, 18, 25, 55, 133, DateTimeKind.Local).AddTicks(9038), new DateTime(2023, 2, 3, 18, 25, 55, 133, DateTimeKind.Local).AddTicks(9039) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 2, 3, 18, 25, 55, 133, DateTimeKind.Local).AddTicks(9045), new DateTime(2023, 2, 3, 18, 25, 55, 133, DateTimeKind.Local).AddTicks(9046) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 2, 3, 18, 25, 55, 133, DateTimeKind.Local).AddTicks(9048), new DateTime(2023, 2, 3, 18, 25, 55, 133, DateTimeKind.Local).AddTicks(9049) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 2, 3, 18, 25, 55, 133, DateTimeKind.Local).AddTicks(9051), new DateTime(2023, 2, 3, 18, 25, 55, 133, DateTimeKind.Local).AddTicks(9052) });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 2, 3, 18, 25, 55, 135, DateTimeKind.Local).AddTicks(1991), new DateTime(2023, 2, 3, 18, 25, 55, 135, DateTimeKind.Local).AddTicks(2013) });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 2, 3, 18, 25, 55, 135, DateTimeKind.Local).AddTicks(2016), new DateTime(2023, 2, 3, 18, 25, 55, 135, DateTimeKind.Local).AddTicks(2017) });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 2, 3, 18, 25, 55, 135, DateTimeKind.Local).AddTicks(2018), new DateTime(2023, 2, 3, 18, 25, 55, 135, DateTimeKind.Local).AddTicks(2019) });
        }
    }
}
