﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TPharmacy.Server.Migrations
{
    public partial class NewApplicationTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CusName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CusEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CusNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CusAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CusPassword = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CusPoints = table.Column<int>(type: "int", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "DeviceCodes",
                columns: table => new
                {
                    UserCode = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    DeviceCode = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    SubjectId = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    SessionId = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ClientId = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Expiration = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Data = table.Column<string>(type: "nvarchar(max)", maxLength: 50000, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeviceCodes", x => x.UserCode);
                });

            migrationBuilder.CreateTable(
                name: "PersistedGrants",
                columns: table => new
                {
                    Key = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Type = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    SubjectId = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    SessionId = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ClientId = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Expiration = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ConsumedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Data = table.Column<string>(type: "nvarchar(max)", maxLength: 50000, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersistedGrants", x => x.Key);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProdBrand = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProdName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProdDesc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProdPrice = table.Column<decimal>(type: "decimal(7,2)", nullable: false),
                    ProdCategory = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Staffs",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StafName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StafEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StafPassword = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StafRole = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Staffs", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Consultations",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerID = table.Column<int>(type: "int", nullable: true),
                    CusID = table.Column<int>(type: "int", nullable: false),
                    StaffID = table.Column<int>(type: "int", nullable: false),
                    ConDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ConStartTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ConEndTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ConFee = table.Column<decimal>(type: "decimal(7,2)", nullable: false),
                    ConDesc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Consultations", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Consultations_Customers_CustomerID",
                        column: x => x.CustomerID,
                        principalTable: "Customers",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Consultations_Staffs_StaffID",
                        column: x => x.StaffID,
                        principalTable: "Staffs",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CusID = table.Column<int>(type: "int", nullable: false),
                    CustomerID = table.Column<int>(type: "int", nullable: true),
                    StaffID = table.Column<int>(type: "int", nullable: false),
                    OrderDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    OrderPrice = table.Column<decimal>(type: "decimal(7,2)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Orders_Customers_CustomerID",
                        column: x => x.CustomerID,
                        principalTable: "Customers",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Orders_Staffs_StaffID",
                        column: x => x.StaffID,
                        principalTable: "Staffs",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Prescriptions",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ConsultationID = table.Column<int>(type: "int", nullable: true),
                    ConID = table.Column<int>(type: "int", nullable: false),
                    ProductID = table.Column<int>(type: "int", nullable: false),
                    PresQty = table.Column<int>(type: "int", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prescriptions", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Prescriptions_Consultations_ConsultationID",
                        column: x => x.ConsultationID,
                        principalTable: "Consultations",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Prescriptions_Products_ProductID",
                        column: x => x.ProductID,
                        principalTable: "Products",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderItems",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderID = table.Column<int>(type: "int", nullable: false),
                    ProductID = table.Column<int>(type: "int", nullable: false),
                    OrderItemQtny = table.Column<int>(type: "int", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderItems", x => x.ID);
                    table.ForeignKey(
                        name: "FK_OrderItems_Orders_OrderID",
                        column: x => x.OrderID,
                        principalTable: "Orders",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderItems_Products_ProductID",
                        column: x => x.ProductID,
                        principalTable: "Products",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Payments",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderID = table.Column<int>(type: "int", nullable: false),
                    PayFee = table.Column<decimal>(type: "decimal(7,2)", nullable: false),
                    PayCardInfo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payments", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Payments_Orders_OrderID",
                        column: x => x.OrderID,
                        principalTable: "Orders",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "staff", "884d0cce-2a27-4663-9468-7e92bcdd5708", "Staff", "STAFF" },
                    { "customer", "42b0f3bf-8b05-4726-b1b7-3189d5dcc079", "Customer", "CUSTOMER" },
                    { "admin", "a69a1279-060d-40d9-9ea2-0be4c4fb2a97", "Admin", "ADMIN" },
                    { "pharmacist", "801b7526-3b7d-4a8a-b091-c0bba715971f", "Pharmacist", "PHARMACIST" },
                    { "packer", "bcfbef1c-be9e-4216-a463-f9b867788600", "Packer", "PACKER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "Password", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "3781efa7-66dc-47f0-860f-e506d04102s1", 0, "TPharmacy", "5dcfc940-f1b4-4b73-9e43-b1ced35b7a4b", "june@gmail.com", true, "June", "Staff", true, null, "JUNE@GMAIL.COM", "JUNE@GMAIL.COM", "June1234*", "AQAAAAEAACcQAAAAEMZJ/08hKeaP+FUBiknas4GDYb+8Ny5LBoDIMhvkveTEcthCtuXaAvh8i7CYogiV1w==", "9273 8983", true, "3fed860f-f310-447d-beae-76d99f8e5d8d", false, "june@gmail.com" },
                    { "3781efa7-66dc-47f0-860f-e506d04102s2", 0, "TPharmacy", "33f9c604-4792-4f3b-8078-c65dce68960f", "woon@gmail.com", true, "Woon", "Staff", true, null, "WOON@GMAIL.COM", "WOON@GMAIL.COM", "P@ssword1", "AQAAAAEAACcQAAAAENNcMYxG4uYpJOkR9FkYHIlOf6vpJNoEm91AEJlEhjfHp+W+31/WN455CmgHnN4EaA==", "9287 2324", true, "72a4dbca-2c06-49dd-bb76-8bc428b95759", false, "woon@gmail.com" },
                    { "3781efa7-66dc-47f0-860f-e506d04102s3", 0, "TPharmacy", "1d33f327-ea4b-4313-aafe-a29955f52563", "kate@gmail.com", true, "Kate", "Staff", true, null, "KATE@GMAIL.COM", "KATE@GMAIL.COM", "Kate1234*", "AQAAAAEAACcQAAAAED+ywOhQThkAn3qaQDCLQ90ne/kbEIERX9fnRCizGuBLj/ILiOYtb3MI1umd5QyEfQ==", "6329 9823", true, "ebe9db90-27e4-4d29-8580-94bea7368882", false, "kate@gmail.com" },
                    { "3781efa7-66dc-47f0-860f-e506d04102c1", 0, "Tampines Ave 1", "2caa2406-be40-4732-8ab2-cf404974ac7e", "james@gmail.com", true, "James", "Customer", true, null, "JAMES@GMAIL.COM", "JAMES@GMAIL.COM", "James1234*", "AQAAAAEAACcQAAAAEFqJJigLdJMvs9z13J1huG6P6C0HEkdd9rG/DYMnDb5JLZzdfkWGHNbKCJypGA6aiw==", "8211 7319", true, "a205250d-fad5-43b1-8266-9054c9e1b5a3", false, "james@gmail.com" },
                    { "3781efa7-66dc-47f0-860f-e506d04102c2", 0, "Bedok Ave 1", "1decd4ed-aba9-4fb9-9cd3-9fb0e325b625", "alice@gmail.com", true, "Alice", "Customer", true, null, "ALICE@GMAIL.COM", "ALICE@GMAIL.COM", "Alice1234*", "AQAAAAEAACcQAAAAEOXlNQMR/Qk+Yc2njnkLZfd2mdd1qvl6LzwD3MYltBQFk6eU85nLYgLHz4mGIfMHXQ==", "8329 7433", true, "acbf444d-1869-4ea1-8cfb-639efabd01cf", false, "alice@gmail.com" },
                    { "3781efa7-66dc-47f0-860f-e506d04102c3", 0, "Jurong Ave 1", "7ce9fdd7-77f9-45e3-bbee-35f353f24230", "sheila@gmail.com", true, "Sheila", "Customer", true, null, "SHEILA@GMAIL.COM", "SHEILA@GMAIL.COM", "Sheila1234*", "AQAAAAEAACcQAAAAEAPH5rA/yYgi/POJLVbQ+jH8j6h5II2+Q3q+/lwLkHWgr5zeFrlArY9muZmmupFugQ==", "9436 7238", true, "13917bbd-32ad-4606-acd6-43b13834e0fc", false, "sheila@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "ID", "CreatedBy", "CusAddress", "CusEmail", "CusName", "CusNumber", "CusPassword", "CusPoints", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[,]
                {
                    { 3, "System", "Jurong Ave 1", "sheila@gmail.com", "Sheila", "87511773", "Sheila1234*", 89, new DateTime(2023, 1, 17, 11, 16, 43, 73, DateTimeKind.Local).AddTicks(6419), new DateTime(2023, 1, 17, 11, 16, 43, 73, DateTimeKind.Local).AddTicks(6420), "System" },
                    { 1, "System", "Tampines Ave 1", "james@gmail.com", "James", "87439653", "James1234*", 100, new DateTime(2023, 1, 17, 11, 16, 43, 73, DateTimeKind.Local).AddTicks(6406), new DateTime(2023, 1, 17, 11, 16, 43, 73, DateTimeKind.Local).AddTicks(6413), "System" },
                    { 2, "System", "Bedok Ave 1", "alice@gmail.com", "Alice", "96512845", "Alice1234*", 50, new DateTime(2023, 1, 17, 11, 16, 43, 73, DateTimeKind.Local).AddTicks(6416), new DateTime(2023, 1, 17, 11, 16, 43, 73, DateTimeKind.Local).AddTicks(6417), "System" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ID", "CreatedBy", "DateCreated", "DateUpdated", "ProdBrand", "ProdCategory", "ProdDesc", "ProdName", "ProdPrice", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2023, 1, 17, 11, 16, 43, 71, DateTimeKind.Local).AddTicks(2856), new DateTime(2023, 1, 17, 11, 16, 43, 72, DateTimeKind.Local).AddTicks(677), "Blackmores", "Supplement", "BLACKMORES Bio Vitamin C 1000mg 120 Tablets", "Vitamin C", 35.00m, "System" },
                    { 2, "System", new DateTime(2023, 1, 17, 11, 16, 43, 72, DateTimeKind.Local).AddTicks(1228), new DateTime(2023, 1, 17, 11, 16, 43, 72, DateTimeKind.Local).AddTicks(1231), "Swisse", "Supplement", "Swisse Omega 3 Fish Oil 1500mg 100 Tablets", "Omega 3 Fish Oil", 58.00m, "System" },
                    { 3, "System", new DateTime(2023, 1, 17, 11, 16, 43, 72, DateTimeKind.Local).AddTicks(1233), new DateTime(2023, 1, 17, 11, 16, 43, 72, DateTimeKind.Local).AddTicks(1234), "Wastons", "Supplement", "Wastons Calcium 500mg 150 Tablets", "Calcium", 45.00m, "System" },
                    { 4, "System", new DateTime(2023, 1, 17, 11, 16, 43, 72, DateTimeKind.Local).AddTicks(1236), new DateTime(2023, 1, 17, 11, 16, 43, 72, DateTimeKind.Local).AddTicks(1237), "Telfast", "Prescriptions", "Telfast Panadol 10mg", "Panadol", 20.00m, "System" },
                    { 5, "System", new DateTime(2023, 1, 17, 11, 16, 43, 72, DateTimeKind.Local).AddTicks(1239), new DateTime(2023, 1, 17, 11, 16, 43, 72, DateTimeKind.Local).AddTicks(1240), "Cellucor", "Sports", "Cellucor Whey Protein Powder 5LBS", "Whey Protein Powder", 60.00m, "System" },
                    { 6, "System", new DateTime(2023, 1, 17, 11, 16, 43, 72, DateTimeKind.Local).AddTicks(1242), new DateTime(2023, 1, 17, 11, 16, 43, 72, DateTimeKind.Local).AddTicks(1243), "Solaray", "Baby", "Solaray Kids Multi Vitamins & Minerals Gummies 120S", "Kids Multi Vitamins & Minerals Gummies", 30.00m, "System" }
                });

            migrationBuilder.InsertData(
                table: "Staffs",
                columns: new[] { "ID", "CreatedBy", "DateCreated", "DateUpdated", "StafEmail", "StafName", "StafPassword", "StafRole", "UpdatedBy" },
                values: new object[,]
                {
                    { 2, "June", new DateTime(2023, 1, 17, 11, 16, 43, 73, DateTimeKind.Local).AddTicks(2562), new DateTime(2023, 1, 17, 11, 16, 43, 73, DateTimeKind.Local).AddTicks(2563), "woon@gmail.com", "Woon", "Woon1234*", "Pharmacist", "System" },
                    { 1, "June", new DateTime(2023, 1, 17, 11, 16, 43, 73, DateTimeKind.Local).AddTicks(2550), new DateTime(2023, 1, 17, 11, 16, 43, 73, DateTimeKind.Local).AddTicks(2559), "june@gmail.com", "June", "June1234*", "Admin", "System" },
                    { 3, "June", new DateTime(2023, 1, 17, 11, 16, 43, 73, DateTimeKind.Local).AddTicks(2564), new DateTime(2023, 1, 17, 11, 16, 43, 73, DateTimeKind.Local).AddTicks(2565), "kate@gmail.com", "Kate", "Kate1234*", "Packer", "System" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "staff", "3781efa7-66dc-47f0-860f-e506d04102s1" },
                    { "admin", "3781efa7-66dc-47f0-860f-e506d04102s1" },
                    { "staff", "3781efa7-66dc-47f0-860f-e506d04102s2" },
                    { "pharmacist", "3781efa7-66dc-47f0-860f-e506d04102s2" },
                    { "staff", "3781efa7-66dc-47f0-860f-e506d04102s3" },
                    { "packer", "3781efa7-66dc-47f0-860f-e506d04102s3" },
                    { "customer", "3781efa7-66dc-47f0-860f-e506d04102c1" },
                    { "customer", "3781efa7-66dc-47f0-860f-e506d04102c2" },
                    { "customer", "3781efa7-66dc-47f0-860f-e506d04102c3" }
                });

            migrationBuilder.InsertData(
                table: "Consultations",
                columns: new[] { "ID", "ConDate", "ConDesc", "ConEndTime", "ConFee", "ConStartTime", "CreatedBy", "CusID", "CustomerID", "DateCreated", "DateUpdated", "StaffID", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 1, 17, 11, 16, 43, 75, DateTimeKind.Local).AddTicks(1635), "Flu Consultation", new DateTime(2023, 1, 17, 12, 25, 43, 75, DateTimeKind.Local).AddTicks(1969), 35.50m, new DateTime(2023, 1, 17, 11, 16, 43, 75, DateTimeKind.Local).AddTicks(1814), "Woon", 1, null, new DateTime(2023, 1, 17, 11, 16, 43, 75, DateTimeKind.Local).AddTicks(2568), new DateTime(2023, 1, 17, 11, 16, 43, 75, DateTimeKind.Local).AddTicks(2572), 1, "System" },
                    { 2, new DateTime(2023, 1, 17, 11, 16, 43, 75, DateTimeKind.Local).AddTicks(2575), "Eczema Consultation", new DateTime(2023, 1, 17, 12, 16, 43, 75, DateTimeKind.Local).AddTicks(2577), 30.50m, new DateTime(2023, 1, 17, 11, 16, 43, 75, DateTimeKind.Local).AddTicks(2576), "Woon", 3, null, new DateTime(2023, 1, 17, 11, 16, 43, 75, DateTimeKind.Local).AddTicks(2582), new DateTime(2023, 1, 17, 11, 16, 43, 75, DateTimeKind.Local).AddTicks(2583), 1, "System" }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "ID", "CreatedBy", "CusID", "CustomerID", "DateCreated", "DateUpdated", "OrderDateTime", "OrderPrice", "StaffID", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", 1, null, new DateTime(2023, 1, 17, 11, 16, 43, 73, DateTimeKind.Local).AddTicks(9764), new DateTime(2023, 1, 17, 11, 16, 43, 73, DateTimeKind.Local).AddTicks(9767), new DateTime(2023, 1, 17, 11, 16, 43, 73, DateTimeKind.Local).AddTicks(9374), 128.00m, 3, "Kate" },
                    { 2, "System", 2, null, new DateTime(2023, 1, 17, 11, 16, 43, 73, DateTimeKind.Local).AddTicks(9772), new DateTime(2023, 1, 17, 11, 16, 43, 73, DateTimeKind.Local).AddTicks(9773), new DateTime(2023, 1, 17, 11, 16, 43, 73, DateTimeKind.Local).AddTicks(9771), 90.00m, 3, "Kate" }
                });

            migrationBuilder.InsertData(
                table: "Prescriptions",
                columns: new[] { "ID", "ConID", "ConsultationID", "CreatedBy", "DateCreated", "DateUpdated", "PresQty", "ProductID", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, 1, null, "System", new DateTime(2023, 1, 17, 11, 16, 43, 74, DateTimeKind.Local).AddTicks(8102), new DateTime(2023, 1, 17, 11, 16, 43, 74, DateTimeKind.Local).AddTicks(8108), 1, 4, "System" },
                    { 2, 2, null, "System", new DateTime(2023, 1, 17, 11, 16, 43, 74, DateTimeKind.Local).AddTicks(8110), new DateTime(2023, 1, 17, 11, 16, 43, 74, DateTimeKind.Local).AddTicks(8111), 2, 4, "System" }
                });

            migrationBuilder.InsertData(
                table: "OrderItems",
                columns: new[] { "ID", "CreatedBy", "DateCreated", "DateUpdated", "OrderID", "OrderItemQtny", "ProductID", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2023, 1, 17, 11, 16, 43, 74, DateTimeKind.Local).AddTicks(2552), new DateTime(2023, 1, 17, 11, 16, 43, 74, DateTimeKind.Local).AddTicks(2557), 1, 2, 1, "Kate" },
                    { 2, "System", new DateTime(2023, 1, 17, 11, 16, 43, 74, DateTimeKind.Local).AddTicks(2560), new DateTime(2023, 1, 17, 11, 16, 43, 74, DateTimeKind.Local).AddTicks(2561), 1, 1, 2, "Kate" },
                    { 3, "System", new DateTime(2023, 1, 17, 11, 16, 43, 74, DateTimeKind.Local).AddTicks(2563), new DateTime(2023, 1, 17, 11, 16, 43, 74, DateTimeKind.Local).AddTicks(2564), 2, 1, 3, "Kate" }
                });

            migrationBuilder.InsertData(
                table: "Payments",
                columns: new[] { "ID", "CreatedBy", "DateCreated", "DateUpdated", "OrderID", "PayCardInfo", "PayFee", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2023, 1, 17, 11, 16, 43, 74, DateTimeKind.Local).AddTicks(5656), new DateTime(2023, 1, 17, 11, 16, 43, 74, DateTimeKind.Local).AddTicks(5662), 1, "7855-3798-2344-9853", 5.00m, "System" },
                    { 2, "System", new DateTime(2023, 1, 17, 11, 16, 43, 74, DateTimeKind.Local).AddTicks(5664), new DateTime(2023, 1, 17, 11, 16, 43, 74, DateTimeKind.Local).AddTicks(5665), 2, "3244-2355-3459-9767", 15.00m, "System" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Consultations_CustomerID",
                table: "Consultations",
                column: "CustomerID");

            migrationBuilder.CreateIndex(
                name: "IX_Consultations_StaffID",
                table: "Consultations",
                column: "StaffID");

            migrationBuilder.CreateIndex(
                name: "IX_DeviceCodes_DeviceCode",
                table: "DeviceCodes",
                column: "DeviceCode",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_DeviceCodes_Expiration",
                table: "DeviceCodes",
                column: "Expiration");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_OrderID",
                table: "OrderItems",
                column: "OrderID");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_ProductID",
                table: "OrderItems",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_CustomerID",
                table: "Orders",
                column: "CustomerID");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_StaffID",
                table: "Orders",
                column: "StaffID");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_OrderID",
                table: "Payments",
                column: "OrderID");

            migrationBuilder.CreateIndex(
                name: "IX_PersistedGrants_Expiration",
                table: "PersistedGrants",
                column: "Expiration");

            migrationBuilder.CreateIndex(
                name: "IX_PersistedGrants_SubjectId_ClientId_Type",
                table: "PersistedGrants",
                columns: new[] { "SubjectId", "ClientId", "Type" });

            migrationBuilder.CreateIndex(
                name: "IX_PersistedGrants_SubjectId_SessionId_Type",
                table: "PersistedGrants",
                columns: new[] { "SubjectId", "SessionId", "Type" });

            migrationBuilder.CreateIndex(
                name: "IX_Prescriptions_ConsultationID",
                table: "Prescriptions",
                column: "ConsultationID");

            migrationBuilder.CreateIndex(
                name: "IX_Prescriptions_ProductID",
                table: "Prescriptions",
                column: "ProductID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "DeviceCodes");

            migrationBuilder.DropTable(
                name: "OrderItems");

            migrationBuilder.DropTable(
                name: "Payments");

            migrationBuilder.DropTable(
                name: "PersistedGrants");

            migrationBuilder.DropTable(
                name: "Prescriptions");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Consultations");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Staffs");
        }
    }
}
