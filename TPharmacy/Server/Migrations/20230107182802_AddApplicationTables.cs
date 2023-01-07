using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TPharmacy.Server.Migrations
{
    public partial class AddApplicationTables : Migration
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
                    OrderQtny = table.Column<int>(type: "int", nullable: false),
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
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "67c9e85c-865b-4642-95fd-9aa7440c330a", "Administrator", "ADMINISTRATOR" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", "59cd0ba7-d503-43d3-9aa5-fffa92f0c8d0", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "Password", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "TPharmacy", "f3d8e08d-9019-4bd8-916b-207a7f210fd6", "admin@localhost.com", true, "Admin", "Admin", true, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "P@ssword1", "AQAAAAEAACcQAAAAEKxTDFEXi2zU+LXKMf0mmzQbkDaBZnqfYMj0khrzBKDk0rNcDcUc3SATuL9zpJiBoA==", "6721 9632", true, "1f6bce65-d9b5-4c93-a0f7-73fc4ec4ba3b", false, "admin@localhost.com" },
                    { "3781efa7-66dc-47f0-860f-e506d04102e5", 0, "TPharmacy", "4dfe987b-6dd1-4fa4-ac5f-090c57f72d75", "june@gmail.com", true, "June", "Admin", true, null, "JUNE@GMAIL.COM", "JUNE@GMAIL.COM", "June1234*", "AQAAAAEAACcQAAAAEDVZmRmBU6yrgEA0+2J4Sga7gMUhd/OZC3DwxAjuhZFpGwOtnMLt3JDxlePM/kd5eg==", "9273 8983", true, "3a37f940-ac57-4335-9f44-ec18db881efb", false, "june@gmail.com" },
                    { "3781efa7-66dc-47f0-860f-e506d04102c4", 0, "1 Youngberg Terrace", "5cbf2f34-175d-4d81-b011-0f7011cab78c", "sheila@gmail.com", true, "Sheila", "User", true, null, "SHEILA@GMAIL.COM", "SHEILA@GMAIL.COM", "Sheila1234*", "AQAAAAEAACcQAAAAENOE54EW/1KNa+Q8J21FjcDDqnRldPBXzZata/7uaE9wuoc7C+lOfEFXZQ2ZS3Vytg==", "8211 7319", true, "e2e9ac07-94a7-4935-8f91-6a770f081d43", false, "sheila@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "ID", "CreatedBy", "CusAddress", "CusEmail", "CusName", "CusPassword", "CusPoints", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[,]
                {
                    { 3, "System", "Tai Seng St 81", "grey@gmail.com", "Grey", "Grey1234*", 89, new DateTime(2023, 1, 8, 2, 28, 1, 860, DateTimeKind.Local).AddTicks(1553), new DateTime(2023, 1, 8, 2, 28, 1, 860, DateTimeKind.Local).AddTicks(1554), "System" },
                    { 4, "System", "1 Youngberg Terrace", "sheila@gmail.com", "Sheila", "Sheila1234*", 200, new DateTime(2023, 1, 8, 2, 28, 1, 860, DateTimeKind.Local).AddTicks(1556), new DateTime(2023, 1, 8, 2, 28, 1, 860, DateTimeKind.Local).AddTicks(1557), "System" },
                    { 1, "System", "Tampines Ave 1", "james@gmail.com", "James", "James1234*", 100, new DateTime(2023, 1, 8, 2, 28, 1, 860, DateTimeKind.Local).AddTicks(1525), new DateTime(2023, 1, 8, 2, 28, 1, 860, DateTimeKind.Local).AddTicks(1546), "System" },
                    { 2, "System", "Bedok Ave 1", "alice@gmail.com", "Alice", "Alice1234*", 50, new DateTime(2023, 1, 8, 2, 28, 1, 860, DateTimeKind.Local).AddTicks(1550), new DateTime(2023, 1, 8, 2, 28, 1, 860, DateTimeKind.Local).AddTicks(1551), "System" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ID", "CreatedBy", "DateCreated", "DateUpdated", "ProdBrand", "ProdCategory", "ProdDesc", "ProdName", "ProdPrice", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2023, 1, 8, 2, 28, 1, 857, DateTimeKind.Local).AddTicks(1408), new DateTime(2023, 1, 8, 2, 28, 1, 858, DateTimeKind.Local).AddTicks(1911), "Blackmores", "Supplements", "BLACKMORES Bio Vitamin C 1000mg 120 Tablets", "Vitamin C", 35.00m, "System" },
                    { 2, "System", new DateTime(2023, 1, 8, 2, 28, 1, 858, DateTimeKind.Local).AddTicks(2542), new DateTime(2023, 1, 8, 2, 28, 1, 858, DateTimeKind.Local).AddTicks(2545), "Swisse", "Supplements", "Swisse Omega 3 Fish Oil 1500mg 100 Tablets", "Omega 3 Fish Oil", 58.00m, "System" },
                    { 3, "System", new DateTime(2023, 1, 8, 2, 28, 1, 858, DateTimeKind.Local).AddTicks(2547), new DateTime(2023, 1, 8, 2, 28, 1, 858, DateTimeKind.Local).AddTicks(2548), "Wastons", "Supplements", "Wastons Calcium 500mg 150 Tablets", "Calcium", 45.00m, "System" },
                    { 4, "System", new DateTime(2023, 1, 8, 2, 28, 1, 858, DateTimeKind.Local).AddTicks(2601), new DateTime(2023, 1, 8, 2, 28, 1, 858, DateTimeKind.Local).AddTicks(2602), "Telfast", "Prescriptions", "Telfast Panadol 10mg", "Panadol", 20.00m, "System" },
                    { 5, "System", new DateTime(2023, 1, 8, 2, 28, 1, 858, DateTimeKind.Local).AddTicks(2604), new DateTime(2023, 1, 8, 2, 28, 1, 858, DateTimeKind.Local).AddTicks(2605), "Cellucor", "Sports", "Cellucor Whey Protein Powder 5LBS", "Whey Protein Powder", 60.00m, "System" },
                    { 6, "System", new DateTime(2023, 1, 8, 2, 28, 1, 858, DateTimeKind.Local).AddTicks(2607), new DateTime(2023, 1, 8, 2, 28, 1, 858, DateTimeKind.Local).AddTicks(2608), "Solaray", "Baby", "Solaray Kids Multi Vitamins & Minerals Gummies 120S", "Kids Multi Vitamins & Minerals Gummies", 30.00m, "System" }
                });

            migrationBuilder.InsertData(
                table: "Staffs",
                columns: new[] { "ID", "CreatedBy", "DateCreated", "DateUpdated", "StafEmail", "StafName", "StafPassword", "StafRole", "UpdatedBy" },
                values: new object[,]
                {
                    { 2, "June", new DateTime(2023, 1, 8, 2, 28, 1, 859, DateTimeKind.Local).AddTicks(5968), new DateTime(2023, 1, 8, 2, 28, 1, 859, DateTimeKind.Local).AddTicks(5970), "june@gmail.com", "June", "June1234*", "Admin", "System" },
                    { 1, "June", new DateTime(2023, 1, 8, 2, 28, 1, 859, DateTimeKind.Local).AddTicks(5942), new DateTime(2023, 1, 8, 2, 28, 1, 859, DateTimeKind.Local).AddTicks(5965), "woon@gmail.com", "Woon", "Woon1234*", "Pharmacist", "System" },
                    { 3, "June", new DateTime(2023, 1, 8, 2, 28, 1, 859, DateTimeKind.Local).AddTicks(5971), new DateTime(2023, 1, 8, 2, 28, 1, 859, DateTimeKind.Local).AddTicks(5972), "kate@gmail.com", "Kate", "Kate1234*", "Packer", "System" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" },
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e5" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", "3781efa7-66dc-47f0-860f-e506d04102c4" }
                });

            migrationBuilder.InsertData(
                table: "Consultations",
                columns: new[] { "ID", "ConDate", "ConDesc", "ConEndTime", "ConFee", "ConStartTime", "CreatedBy", "CusID", "CustomerID", "DateCreated", "DateUpdated", "StaffID", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 1, 8, 2, 28, 1, 862, DateTimeKind.Local).AddTicks(2298), "Flu Consultation", new DateTime(2023, 1, 8, 3, 37, 1, 862, DateTimeKind.Local).AddTicks(2644), 35.50m, new DateTime(2023, 1, 8, 2, 28, 1, 862, DateTimeKind.Local).AddTicks(2485), "Woon", 1, null, new DateTime(2023, 1, 8, 2, 28, 1, 862, DateTimeKind.Local).AddTicks(3307), new DateTime(2023, 1, 8, 2, 28, 1, 862, DateTimeKind.Local).AddTicks(3311), 1, "System" },
                    { 2, new DateTime(2023, 1, 8, 2, 28, 1, 862, DateTimeKind.Local).AddTicks(3314), "Eczema Consultation", new DateTime(2023, 1, 8, 3, 28, 1, 862, DateTimeKind.Local).AddTicks(3316), 30.50m, new DateTime(2023, 1, 8, 2, 28, 1, 862, DateTimeKind.Local).AddTicks(3315), "Woon", 3, null, new DateTime(2023, 1, 8, 2, 28, 1, 862, DateTimeKind.Local).AddTicks(3323), new DateTime(2023, 1, 8, 2, 28, 1, 862, DateTimeKind.Local).AddTicks(3324), 1, "System" }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "ID", "CreatedBy", "CusID", "CustomerID", "DateCreated", "DateUpdated", "OrderDateTime", "OrderPrice", "StaffID", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", 1, null, new DateTime(2023, 1, 8, 2, 28, 1, 860, DateTimeKind.Local).AddTicks(8127), new DateTime(2023, 1, 8, 2, 28, 1, 860, DateTimeKind.Local).AddTicks(8131), new DateTime(2023, 1, 8, 2, 28, 1, 860, DateTimeKind.Local).AddTicks(7646), 128.00m, 3, "Kate" },
                    { 2, "System", 2, null, new DateTime(2023, 1, 8, 2, 28, 1, 860, DateTimeKind.Local).AddTicks(8142), new DateTime(2023, 1, 8, 2, 28, 1, 860, DateTimeKind.Local).AddTicks(8144), new DateTime(2023, 1, 8, 2, 28, 1, 860, DateTimeKind.Local).AddTicks(8141), 90.00m, 3, "Kate" }
                });

            migrationBuilder.InsertData(
                table: "Prescriptions",
                columns: new[] { "ID", "ConID", "ConsultationID", "CreatedBy", "DateCreated", "DateUpdated", "PresQty", "ProductID", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, 1, null, "System", new DateTime(2023, 1, 8, 2, 28, 1, 861, DateTimeKind.Local).AddTicks(8536), new DateTime(2023, 1, 8, 2, 28, 1, 861, DateTimeKind.Local).AddTicks(8542), 1, 4, "System" },
                    { 2, 2, null, "System", new DateTime(2023, 1, 8, 2, 28, 1, 861, DateTimeKind.Local).AddTicks(8545), new DateTime(2023, 1, 8, 2, 28, 1, 861, DateTimeKind.Local).AddTicks(8546), 2, 4, "System" }
                });

            migrationBuilder.InsertData(
                table: "OrderItems",
                columns: new[] { "ID", "CreatedBy", "DateCreated", "DateUpdated", "OrderID", "OrderQtny", "ProductID", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2023, 1, 8, 2, 28, 1, 861, DateTimeKind.Local).AddTicks(2479), new DateTime(2023, 1, 8, 2, 28, 1, 861, DateTimeKind.Local).AddTicks(2494), 1, 2, 1, "Kate" },
                    { 2, "System", new DateTime(2023, 1, 8, 2, 28, 1, 861, DateTimeKind.Local).AddTicks(2497), new DateTime(2023, 1, 8, 2, 28, 1, 861, DateTimeKind.Local).AddTicks(2498), 1, 1, 2, "Kate" },
                    { 3, "System", new DateTime(2023, 1, 8, 2, 28, 1, 861, DateTimeKind.Local).AddTicks(2500), new DateTime(2023, 1, 8, 2, 28, 1, 861, DateTimeKind.Local).AddTicks(2501), 2, 1, 3, "Kate" }
                });

            migrationBuilder.InsertData(
                table: "Payments",
                columns: new[] { "ID", "CreatedBy", "DateCreated", "DateUpdated", "OrderID", "PayCardInfo", "PayFee", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2023, 1, 8, 2, 28, 1, 861, DateTimeKind.Local).AddTicks(5939), new DateTime(2023, 1, 8, 2, 28, 1, 861, DateTimeKind.Local).AddTicks(5946), 1, "7855-3798-2344-9853", 128.00m, "System" },
                    { 2, "System", new DateTime(2023, 1, 8, 2, 28, 1, 861, DateTimeKind.Local).AddTicks(5949), new DateTime(2023, 1, 8, 2, 28, 1, 861, DateTimeKind.Local).AddTicks(5950), 2, "3244-2355-3459-9767", 103.00m, "System" }
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
