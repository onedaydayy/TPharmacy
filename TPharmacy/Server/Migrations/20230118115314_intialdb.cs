using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TPharmacy.Server.Migrations
{
    public partial class intialdb : Migration
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
                    OrderFee = table.Column<decimal>(type: "decimal(7,2)", nullable: false),
                    OrderTotal = table.Column<decimal>(type: "decimal(7,2)", nullable: false),
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
                    { "staff", "7783a0de-e3ce-4988-bf7f-fd6ca44c63ba", "Staff", "STAFF" },
                    { "customer", "aaba996e-2180-46db-a617-69a361faf32b", "Customer", "CUSTOMER" },
                    { "admin", "372029ef-f001-4fdf-a366-5b4e8675227f", "Admin", "ADMIN" },
                    { "pharmacist", "c480d5bb-cd49-4e64-ba11-650b9720bcea", "Pharmacist", "PHARMACIST" },
                    { "packer", "21732e9e-a419-47ad-bbcd-be8fd16a4fe5", "Packer", "PACKER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "Password", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "3781efa7-66dc-47f0-860f-e506d04102s1", 0, "TPharmacy", "154cb6dd-6321-4c62-b678-f34776c0e5d3", "june@gmail.com", true, "June", "Staff", true, null, "JUNE@GMAIL.COM", "JUNE@GMAIL.COM", "June1234*", "AQAAAAEAACcQAAAAED7ydYgTyk8+g9VPL+o72rLZn9zfX3z/tK2cxaNV49+uLod1lt1JUKIh8OxK6c6BcQ==", "9273 8983", true, "7c09fd63-8795-40c5-bc7b-c4b6c6e7d290", false, "june@gmail.com" },
                    { "3781efa7-66dc-47f0-860f-e506d04102s2", 0, "TPharmacy", "3a083f86-a952-4ee6-bbcb-7459aac7bc5c", "woon@gmail.com", true, "Woon", "Staff", true, null, "WOON@GMAIL.COM", "WOON@GMAIL.COM", "P@ssword1", "AQAAAAEAACcQAAAAEHpB12znv5ndYh8dZo69so6swiOd4khjgWd7jqaFY8gz6bQmLzyv47D0m88OH/op5w==", "9287 2324", true, "76091b2a-0845-4f32-87fb-2c22e004fcea", false, "woon@gmail.com" },
                    { "3781efa7-66dc-47f0-860f-e506d04102s3", 0, "TPharmacy", "82f1c9ba-a63e-497b-9a01-66bfb67cdead", "kate@gmail.com", true, "Kate", "Staff", true, null, "KATE@GMAIL.COM", "KATE@GMAIL.COM", "Kate1234*", "AQAAAAEAACcQAAAAEBTXZxuMuOHleGF7JcdHSzSmgsCok3Q9OR4IgJ9oP0yInZzt0Taizm/P5vbD4RHavA==", "6329 9823", true, "5718a762-244e-4fd5-a6ce-42e2ca9e0401", false, "kate@gmail.com" },
                    { "3781efa7-66dc-47f0-860f-e506d04102c1", 0, "Tampines Ave 1", "54819653-d6ac-484d-ac96-85bb0e223823", "james@gmail.com", true, "James", "Customer", true, null, "JAMES@GMAIL.COM", "JAMES@GMAIL.COM", "James1234*", "AQAAAAEAACcQAAAAELbbuA3i7JK6ZICjp1wVJAwgLYqYN9v/ivIT5Yxo1tJ5kt6+kDi7l1tw544vOQUvEA==", "8211 7319", true, "3ce0d6d0-d88e-4d42-817b-75711af188be", false, "james@gmail.com" },
                    { "3781efa7-66dc-47f0-860f-e506d04102c2", 0, "Bedok Ave 1", "4f4c1350-09c1-4c95-aff2-5a7d38f37a2a", "alice@gmail.com", true, "Alice", "Customer", true, null, "ALICE@GMAIL.COM", "ALICE@GMAIL.COM", "Alice1234*", "AQAAAAEAACcQAAAAENSYFOLzOGDQuu0MnzJPiT0LHPVa75dMKbtSpTI3Kqzg91uNo5gd6732rGPUve4Kxw==", "8329 7433", true, "917f801f-9bc2-41b7-a8eb-3e942610711f", false, "alice@gmail.com" },
                    { "3781efa7-66dc-47f0-860f-e506d04102c3", 0, "Jurong Ave 1", "7b6a9864-1771-4640-b5f8-c6b9f220bbfc", "sheila@gmail.com", true, "Sheila", "Customer", true, null, "SHEILA@GMAIL.COM", "SHEILA@GMAIL.COM", "Sheila1234*", "AQAAAAEAACcQAAAAEC4IZkPTYXD1tLW55WiszS8yhwPdq1xspyr948vz9egUF+ADCY7B25naeLLdxHYDXw==", "9436 7238", true, "c355bc5f-ef62-4c65-89a3-eb012dd26ca5", false, "sheila@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "ID", "CreatedBy", "CusAddress", "CusEmail", "CusName", "CusNumber", "CusPassword", "CusPoints", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[,]
                {
                    { 3, "System", "Jurong Ave 1", "sheila@gmail.com", "Sheila", "87511773", "Sheila1234*", 89, new DateTime(2023, 1, 18, 19, 53, 14, 393, DateTimeKind.Local).AddTicks(7054), new DateTime(2023, 1, 18, 19, 53, 14, 393, DateTimeKind.Local).AddTicks(7055), "System" },
                    { 1, "System", "Tampines Ave 1", "james@gmail.com", "James", "87439653", "James1234*", 100, new DateTime(2023, 1, 18, 19, 53, 14, 393, DateTimeKind.Local).AddTicks(7041), new DateTime(2023, 1, 18, 19, 53, 14, 393, DateTimeKind.Local).AddTicks(7046), "System" },
                    { 2, "System", "Bedok Ave 1", "alice@gmail.com", "Alice", "96512845", "Alice1234*", 50, new DateTime(2023, 1, 18, 19, 53, 14, 393, DateTimeKind.Local).AddTicks(7050), new DateTime(2023, 1, 18, 19, 53, 14, 393, DateTimeKind.Local).AddTicks(7051), "System" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ID", "CreatedBy", "DateCreated", "DateUpdated", "ProdBrand", "ProdCategory", "ProdDesc", "ProdName", "ProdPrice", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2023, 1, 18, 19, 53, 14, 391, DateTimeKind.Local).AddTicks(2366), new DateTime(2023, 1, 18, 19, 53, 14, 391, DateTimeKind.Local).AddTicks(9816), "Blackmores", "Supplement", "BLACKMORES Bio Vitamin C 1000mg 120 Tablets", "Vitamin C", 35.00m, "System" },
                    { 2, "System", new DateTime(2023, 1, 18, 19, 53, 14, 392, DateTimeKind.Local).AddTicks(395), new DateTime(2023, 1, 18, 19, 53, 14, 392, DateTimeKind.Local).AddTicks(398), "Swisse", "Supplement", "Swisse Omega 3 Fish Oil 1500mg 100 Tablets", "Omega 3 Fish Oil", 58.00m, "System" },
                    { 3, "System", new DateTime(2023, 1, 18, 19, 53, 14, 392, DateTimeKind.Local).AddTicks(402), new DateTime(2023, 1, 18, 19, 53, 14, 392, DateTimeKind.Local).AddTicks(403), "Wastons", "Supplement", "Wastons Calcium 500mg 150 Tablets", "Calcium", 45.00m, "System" },
                    { 4, "System", new DateTime(2023, 1, 18, 19, 53, 14, 392, DateTimeKind.Local).AddTicks(406), new DateTime(2023, 1, 18, 19, 53, 14, 392, DateTimeKind.Local).AddTicks(407), "Telfast", "Prescriptions", "Telfast Panadol 10mg", "Panadol", 20.00m, "System" },
                    { 5, "System", new DateTime(2023, 1, 18, 19, 53, 14, 392, DateTimeKind.Local).AddTicks(409), new DateTime(2023, 1, 18, 19, 53, 14, 392, DateTimeKind.Local).AddTicks(410), "Cellucor", "Sports", "Cellucor Whey Protein Powder 5LBS", "Whey Protein Powder", 60.00m, "System" },
                    { 6, "System", new DateTime(2023, 1, 18, 19, 53, 14, 392, DateTimeKind.Local).AddTicks(412), new DateTime(2023, 1, 18, 19, 53, 14, 392, DateTimeKind.Local).AddTicks(413), "Solaray", "Baby", "Solaray Kids Multi Vitamins & Minerals Gummies 120S", "Kids Multi Vitamins & Minerals Gummies", 30.00m, "System" }
                });

            migrationBuilder.InsertData(
                table: "Staffs",
                columns: new[] { "ID", "CreatedBy", "DateCreated", "DateUpdated", "StafEmail", "StafName", "StafPassword", "StafRole", "UpdatedBy" },
                values: new object[,]
                {
                    { 2, "June", new DateTime(2023, 1, 18, 19, 53, 14, 393, DateTimeKind.Local).AddTicks(3314), new DateTime(2023, 1, 18, 19, 53, 14, 393, DateTimeKind.Local).AddTicks(3315), "woon@gmail.com", "Woon", "Woon1234*", "Pharmacist", "System" },
                    { 1, "June", new DateTime(2023, 1, 18, 19, 53, 14, 393, DateTimeKind.Local).AddTicks(3299), new DateTime(2023, 1, 18, 19, 53, 14, 393, DateTimeKind.Local).AddTicks(3310), "june@gmail.com", "June", "June1234*", "Admin", "System" },
                    { 3, "June", new DateTime(2023, 1, 18, 19, 53, 14, 393, DateTimeKind.Local).AddTicks(3318), new DateTime(2023, 1, 18, 19, 53, 14, 393, DateTimeKind.Local).AddTicks(3319), "kate@gmail.com", "Kate", "Kate1234*", "Packer", "System" }
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
                    { 1, new DateTime(2023, 1, 18, 19, 53, 14, 395, DateTimeKind.Local).AddTicks(3555), "Flu Consultation", new DateTime(2023, 1, 18, 21, 2, 14, 395, DateTimeKind.Local).AddTicks(3815), 35.50m, new DateTime(2023, 1, 18, 19, 53, 14, 395, DateTimeKind.Local).AddTicks(3702), "Woon", 1, null, new DateTime(2023, 1, 18, 19, 53, 14, 395, DateTimeKind.Local).AddTicks(4439), new DateTime(2023, 1, 18, 19, 53, 14, 395, DateTimeKind.Local).AddTicks(4441), 1, "System" },
                    { 2, new DateTime(2023, 1, 18, 19, 53, 14, 395, DateTimeKind.Local).AddTicks(4444), "Eczema Consultation", new DateTime(2023, 1, 18, 20, 53, 14, 395, DateTimeKind.Local).AddTicks(4447), 30.50m, new DateTime(2023, 1, 18, 19, 53, 14, 395, DateTimeKind.Local).AddTicks(4445), "Woon", 3, null, new DateTime(2023, 1, 18, 19, 53, 14, 395, DateTimeKind.Local).AddTicks(4451), new DateTime(2023, 1, 18, 19, 53, 14, 395, DateTimeKind.Local).AddTicks(4452), 1, "System" }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "ID", "CreatedBy", "CusID", "CustomerID", "DateCreated", "DateUpdated", "OrderDateTime", "OrderFee", "OrderTotal", "StaffID", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", 1, null, new DateTime(2023, 1, 18, 19, 53, 14, 394, DateTimeKind.Local).AddTicks(952), new DateTime(2023, 1, 18, 19, 53, 14, 394, DateTimeKind.Local).AddTicks(953), new DateTime(2023, 1, 18, 19, 53, 14, 394, DateTimeKind.Local).AddTicks(460), 0.00m, 128.00m, 3, "Kate" },
                    { 2, "System", 3, null, new DateTime(2023, 1, 18, 19, 53, 14, 394, DateTimeKind.Local).AddTicks(1022), new DateTime(2023, 1, 18, 19, 53, 14, 394, DateTimeKind.Local).AddTicks(1023), new DateTime(2023, 1, 18, 19, 53, 14, 394, DateTimeKind.Local).AddTicks(1020), 10.00m, 100.00m, 3, "Kate" }
                });

            migrationBuilder.InsertData(
                table: "Prescriptions",
                columns: new[] { "ID", "ConID", "ConsultationID", "CreatedBy", "DateCreated", "DateUpdated", "PresQty", "ProductID", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, 1, null, "System", new DateTime(2023, 1, 18, 19, 53, 14, 395, DateTimeKind.Local).AddTicks(5), new DateTime(2023, 1, 18, 19, 53, 14, 395, DateTimeKind.Local).AddTicks(8), 1, 4, "System" },
                    { 2, 2, null, "System", new DateTime(2023, 1, 18, 19, 53, 14, 395, DateTimeKind.Local).AddTicks(13), new DateTime(2023, 1, 18, 19, 53, 14, 395, DateTimeKind.Local).AddTicks(14), 2, 4, "System" }
                });

            migrationBuilder.InsertData(
                table: "OrderItems",
                columns: new[] { "ID", "CreatedBy", "DateCreated", "DateUpdated", "OrderID", "OrderItemQtny", "OrderItemTotal", "ProductID", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2023, 1, 18, 19, 53, 14, 394, DateTimeKind.Local).AddTicks(4931), new DateTime(2023, 1, 18, 19, 53, 14, 394, DateTimeKind.Local).AddTicks(4935), 1, 2, 70.00m, 1, "Kate" },
                    { 2, "System", new DateTime(2023, 1, 18, 19, 53, 14, 394, DateTimeKind.Local).AddTicks(4939), new DateTime(2023, 1, 18, 19, 53, 14, 394, DateTimeKind.Local).AddTicks(4940), 1, 1, 58.00m, 2, "Kate" },
                    { 3, "System", new DateTime(2023, 1, 18, 19, 53, 14, 394, DateTimeKind.Local).AddTicks(4943), new DateTime(2023, 1, 18, 19, 53, 14, 394, DateTimeKind.Local).AddTicks(4944), 2, 2, 90.00m, 3, "Kate" }
                });

            migrationBuilder.InsertData(
                table: "Payments",
                columns: new[] { "ID", "CreatedBy", "DateCreated", "DateUpdated", "OrderID", "PayCardInfo", "PayFee", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2023, 1, 18, 19, 53, 14, 394, DateTimeKind.Local).AddTicks(7802), new DateTime(2023, 1, 18, 19, 53, 14, 394, DateTimeKind.Local).AddTicks(7805), 1, "7855-3798-2344-9853", 5.00m, "System" },
                    { 2, "System", new DateTime(2023, 1, 18, 19, 53, 14, 394, DateTimeKind.Local).AddTicks(7809), new DateTime(2023, 1, 18, 19, 53, 14, 394, DateTimeKind.Local).AddTicks(7810), 2, "3244-2355-3459-9767", 15.00m, "System" }
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
