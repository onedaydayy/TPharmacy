﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TPharmacy.Server.Migrations
{
    public partial class NewApplicationDB : Migration
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
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    CusName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CusEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CusNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CusAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CusPassword = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    ProdBrand = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProdName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ProdDesc = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ProdPrice = table.Column<decimal>(type: "decimal(7,2)", nullable: false),
                    ProdImg = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    StafName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    StafEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StafPassword = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    StafRole = table.Column<int>(type: "int", nullable: false),
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
                    StaffID = table.Column<int>(type: "int", nullable: true),
                    ConDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ConDuration = table.Column<int>(type: "int", nullable: false),
                    ConFee = table.Column<decimal>(type: "decimal(7,2)", nullable: false),
                    ConDesc = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ConStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderStatus = table.Column<int>(type: "int", nullable: false),
                    CustomerID = table.Column<int>(type: "int", nullable: false),
                    StaffID = table.Column<int>(type: "int", nullable: false),
                    OrderDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    OrderFee = table.Column<decimal>(type: "decimal(7,2)", nullable: false),
                    OrderTotal = table.Column<decimal>(type: "decimal(7,2)", nullable: false),
                    OrderItemTotal = table.Column<decimal>(type: "decimal(7,2)", nullable: false),
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
                        onDelete: ReferentialAction.Cascade);
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
                    ConsultationID = table.Column<int>(type: "int", nullable: false),
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
                        onDelete: ReferentialAction.Cascade);
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
                    OrderItemTotal = table.Column<decimal>(type: "decimal(7,2)", nullable: false),
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
                    { "staff", "41810928-dda7-4c5e-b71b-22592513f905", "Staff", "STAFF" },
                    { "customer", "a52bb95c-5f51-49dc-8fb8-f0ed61e75078", "Customer", "CUSTOMER" },
                    { "admin", "aa6acf63-e9c4-45ac-a5f6-768bfcc2352a", "Admin", "ADMIN" },
                    { "pharmacist", "f6b3c9a4-8ad9-4ff2-8fbc-34d1cad79a38", "Pharmacist", "PHARMACIST" },
                    { "packer", "953e5c21-5949-4c38-9133-bec66e3b8bcc", "Packer", "PACKER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "Password", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Role", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "3781efa7-66dc-47f0-860f-e506d04102s1", 0, "TPharmacy", "b1be23b9-5d53-44d7-a8d0-9a31da94a2d6", "june@gmail.com", true, true, null, "June", "JUNE@GMAIL.COM", "JUNE@GMAIL.COM", "June1234*", "AQAAAAEAACcQAAAAEDlPBg2F0AvR2J8QMlSsOruAa++esC0bsR5NP1gqqzFkl6FYpng5BVJdNqXMxOiMdg==", "9273 8983", true, "Staff", "40be27a8-ebbc-441e-881a-1344913db6b7", false, "june@gmail.com" },
                    { "3781efa7-66dc-47f0-860f-e506d04102s2", 0, "TPharmacy", "98d5d82a-adb6-42ca-940f-e5681c6b340f", "woon@gmail.com", true, true, null, "Woon", "WOON@GMAIL.COM", "WOON@GMAIL.COM", "June1234*", "AQAAAAEAACcQAAAAEMvG3laj6LV3prxXLHpnor6Y9oNVKlSLV2/Bf0IAo+W5DtB1mo/EaNhqe6wXdKcW8Q==", "9287 2324", true, "Staff", "5f397f57-5855-4cd9-a6db-a7d7a79dcd7e", false, "woon@gmail.com" },
                    { "3781efa7-66dc-47f0-860f-e506d04102s3", 0, "TPharmacy", "7e085361-b443-43ad-8bfc-1ab9b81af9b8", "kate@gmail.com", true, true, null, "Kate", "KATE@GMAIL.COM", "KATE@GMAIL.COM", "June1234*", "AQAAAAEAACcQAAAAEBjwtwgrir2Ac9XZ0W+EwTuG+EEkm3s8nt/TayLb7np3mENqR7M+a0ETMwaMjVw1EQ==", "6329 9823", true, "Staff", "5effe969-2040-4902-a9ea-10a682697e44", false, "kate@gmail.com" },
                    { "3781efa7-66dc-47f0-860f-e506d04102c1", 0, "Tampines Ave 1", "a6c26f0e-b8f4-4478-8881-ed207b9bd3f4", "james@gmail.com", true, true, null, "James", "JAMES@GMAIL.COM", "JAMES@GMAIL.COM", "June1234*", "AQAAAAEAACcQAAAAEMtIH+6u1X+B//lv6+U1qdIPbNvbGzzVY6A9b5/USdcdMRMMnCR8Wd8LtD2CevdNUQ==", "8211 7319", true, "Customer", "23df0627-e5cb-43b5-939f-f6bd50d823c9", false, "james@gmail.com" },
                    { "3781efa7-66dc-47f0-860f-e506d04102c2", 0, "Bedok Ave 1", "e3eaf0eb-c4fa-4018-bfd6-a2b634ec4240", "alice@gmail.com", true, true, null, "Alice", "ALICE@GMAIL.COM", "ALICE@GMAIL.COM", "June1234*", "AQAAAAEAACcQAAAAEJmifeE6Vtv4ktDQh6kVsv27BoOCCgt5ifGSAUNC767yTTGG5i/hcVEtMEOKs5IrYw==", "8329 7433", true, "Customer", "e64f7a7e-da48-49f2-996f-717c2f6c4d5e", false, "alice@gmail.com" },
                    { "3781efa7-66dc-47f0-860f-e506d04102c3", 0, "Jurong Ave 1", "1726baea-f358-46d1-aec9-ebc80e2710e9", "sheila@gmail.com", true, true, null, "Sheila", "SHEILA@GMAIL.COM", "SHEILA@GMAIL.COM", "June1234*", "AQAAAAEAACcQAAAAEMVZIzcswk63sU2RCtaT0LS/6Th2XGUfHnxwwhD+iCLjGwpD6mJQTcxVFvGsEsJTCg==", "9436 7238", true, "Customer", "a347258c-8302-4fe3-a3bc-7dd4a17af285", false, "sheila@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "ID", "CreatedBy", "CusAddress", "CusEmail", "CusName", "CusNumber", "CusPassword", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[,]
                {
                    { 3, "System", "Jurong Ave 1", "sheila@gmail.com", "Sheila", "87511773", "June1234*", new DateTime(2023, 2, 10, 22, 19, 4, 832, DateTimeKind.Local).AddTicks(794), new DateTime(2023, 2, 10, 22, 19, 4, 832, DateTimeKind.Local).AddTicks(795), "System" },
                    { 2, "System", "Bedok Ave 1", "alice@gmail.com", "Alice", "96512845", "June1234*", new DateTime(2023, 2, 10, 22, 19, 4, 832, DateTimeKind.Local).AddTicks(791), new DateTime(2023, 2, 10, 22, 19, 4, 832, DateTimeKind.Local).AddTicks(792), "System" },
                    { 1, "System", "Tampines Ave 1", "james@gmail.com", "James", "87439653", "June1234*", new DateTime(2023, 2, 10, 22, 19, 4, 832, DateTimeKind.Local).AddTicks(767), new DateTime(2023, 2, 10, 22, 19, 4, 832, DateTimeKind.Local).AddTicks(785), "System" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ID", "CreatedBy", "DateCreated", "DateUpdated", "ProdBrand", "ProdCategory", "ProdDesc", "ProdImg", "ProdName", "ProdPrice", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2023, 2, 10, 22, 19, 4, 828, DateTimeKind.Local).AddTicks(6992), new DateTime(2023, 2, 10, 22, 19, 4, 829, DateTimeKind.Local).AddTicks(6969), "Blackmores", "Supplement", "BLACKMORES Bio Vitamin C 1000mg 120 Tablets", "Vitamin C .jpeg", "Vitamin C", 35.00m, "System" },
                    { 2, "System", new DateTime(2023, 2, 10, 22, 19, 4, 829, DateTimeKind.Local).AddTicks(8125), new DateTime(2023, 2, 10, 22, 19, 4, 829, DateTimeKind.Local).AddTicks(8131), "Swisse", "Supplement", "Swisse Omega 3 Fish Oil 1500mg 100 Tablets", "Omega 3 Fish Oil .jpeg", "Omega 3 Fish Oil", 58.00m, "System" },
                    { 3, "System", new DateTime(2023, 2, 10, 22, 19, 4, 829, DateTimeKind.Local).AddTicks(8134), new DateTime(2023, 2, 10, 22, 19, 4, 829, DateTimeKind.Local).AddTicks(8135), "Wastons", "Supplement", "Wastons Calcium 500mg 150 Tablets", "Calcium .jpeg", "Calcium", 45.00m, "System" },
                    { 4, "System", new DateTime(2023, 2, 10, 22, 19, 4, 829, DateTimeKind.Local).AddTicks(8137), new DateTime(2023, 2, 10, 22, 19, 4, 829, DateTimeKind.Local).AddTicks(8138), "Telfast", "Prescriptions", "Telfast Panadol 10mg", "Panadol .jpeg", "Panadol", 20.00m, "System" },
                    { 5, "System", new DateTime(2023, 2, 10, 22, 19, 4, 829, DateTimeKind.Local).AddTicks(8142), new DateTime(2023, 2, 10, 22, 19, 4, 829, DateTimeKind.Local).AddTicks(8143), "Cellucor", "Sports", "Cellucor Whey Protein Powder 5LBS", "Whey Protein Powder .jpeg", "Whey Protein Powder", 60.00m, "System" },
                    { 6, "System", new DateTime(2023, 2, 10, 22, 19, 4, 829, DateTimeKind.Local).AddTicks(8146), new DateTime(2023, 2, 10, 22, 19, 4, 829, DateTimeKind.Local).AddTicks(8147), "Solaray", "Baby", "Solaray Kids Multi Vitamins & Minerals Gummies 120S", "Kids Multi Vitamins & Minerals Gummies .jpeg", "Kids Multi Vitamins & Minerals Gummies", 30.00m, "System" },
                    { 7, "System", new DateTime(2023, 2, 10, 22, 19, 4, 829, DateTimeKind.Local).AddTicks(8151), new DateTime(2023, 2, 10, 22, 19, 4, 829, DateTimeKind.Local).AddTicks(8152), "Claritin", "Prescriptions", "CLARITYN - Non - drowsy 24H Allergy Relief Tablets 10's", "Clarityn .jpeg", "Clarityn", 25.00m, "System" },
                    { 8, "System", new DateTime(2023, 2, 10, 22, 19, 4, 829, DateTimeKind.Local).AddTicks(8159), new DateTime(2023, 2, 10, 22, 19, 4, 829, DateTimeKind.Local).AddTicks(8160), "Strepsils", "Prescriptions", "Lozenges Soothing Relief for Sore Throat Soothing Honey & Lemon 24s", "Strepsils Lozenges .jpeg", "Soothing Relief Lozenges", 20.00m, "System" }
                });

            migrationBuilder.InsertData(
                table: "Staffs",
                columns: new[] { "ID", "CreatedBy", "DateCreated", "DateUpdated", "StafEmail", "StafName", "StafPassword", "StafRole", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "June", new DateTime(2023, 2, 10, 22, 19, 4, 831, DateTimeKind.Local).AddTicks(5178), new DateTime(2023, 2, 10, 22, 19, 4, 831, DateTimeKind.Local).AddTicks(5202), "june@gmail.com", "June", "June1234*", 0, "System" },
                    { 2, "June", new DateTime(2023, 2, 10, 22, 19, 4, 831, DateTimeKind.Local).AddTicks(5208), new DateTime(2023, 2, 10, 22, 19, 4, 831, DateTimeKind.Local).AddTicks(5209), "woon@gmail.com", "Woon", "June1234*", 1, "System" },
                    { 3, "June", new DateTime(2023, 2, 10, 22, 19, 4, 831, DateTimeKind.Local).AddTicks(5211), new DateTime(2023, 2, 10, 22, 19, 4, 831, DateTimeKind.Local).AddTicks(5213), "kate@gmail.com", "Kate", "June1234*", 2, "System" }
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
                columns: new[] { "ID", "ConDate", "ConDesc", "ConDuration", "ConFee", "ConStatus", "CreatedBy", "CustomerID", "DateCreated", "DateUpdated", "StaffID", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 2, 10, 22, 19, 4, 833, DateTimeKind.Local).AddTicks(1287), "Flu Consultation", 60, 35.50m, "Completed", "Woon", 1, new DateTime(2023, 2, 10, 22, 19, 4, 833, DateTimeKind.Local).AddTicks(2671), new DateTime(2023, 2, 10, 22, 19, 4, 833, DateTimeKind.Local).AddTicks(2683), 2, "System" },
                    { 2, new DateTime(2023, 2, 10, 22, 19, 4, 833, DateTimeKind.Local).AddTicks(2691), "Eczema Consultation", 45, 30.50m, "Pending", "Woon", 3, new DateTime(2023, 2, 10, 22, 19, 4, 833, DateTimeKind.Local).AddTicks(2694), new DateTime(2023, 2, 10, 22, 19, 4, 833, DateTimeKind.Local).AddTicks(2695), 2, "System" }
                });

            migrationBuilder.InsertData(
                table: "Prescriptions",
                columns: new[] { "ID", "ConsultationID", "CreatedBy", "DateCreated", "DateUpdated", "PresQty", "ProductID", "UpdatedBy" },
                values: new object[] { 1, 1, "System", new DateTime(2023, 2, 10, 22, 19, 4, 832, DateTimeKind.Local).AddTicks(5114), new DateTime(2023, 2, 10, 22, 19, 4, 832, DateTimeKind.Local).AddTicks(5136), 1, 4, "System" });

            migrationBuilder.InsertData(
                table: "Prescriptions",
                columns: new[] { "ID", "ConsultationID", "CreatedBy", "DateCreated", "DateUpdated", "PresQty", "ProductID", "UpdatedBy" },
                values: new object[] { 2, 2, "System", new DateTime(2023, 2, 10, 22, 19, 4, 832, DateTimeKind.Local).AddTicks(5140), new DateTime(2023, 2, 10, 22, 19, 4, 832, DateTimeKind.Local).AddTicks(5141), 2, 4, "System" });

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
