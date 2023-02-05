using System;
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
                    { "staff", "16d8a01a-8d7d-4c20-8776-12be8d7cc006", "Staff", "STAFF" },
                    { "customer", "b7bc1d6a-db36-4e58-b2fc-5187e37dbff0", "Customer", "CUSTOMER" },
                    { "admin", "9cc90019-eaba-43ae-9dd6-2eb56795dab9", "Admin", "ADMIN" },
                    { "pharmacist", "6ef0efd9-2ef2-4bc3-8c54-0a645d1d64cd", "Pharmacist", "PHARMACIST" },
                    { "packer", "36d305aa-13ab-41f1-96fc-40705f912522", "Packer", "PACKER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "Password", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Role", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "3781efa7-66dc-47f0-860f-e506d04102s1", 0, "TPharmacy", "9d9f06ce-b19c-49e5-b049-0c52d7b4a81a", "june@gmail.com", true, true, null, "June", "JUNE@GMAIL.COM", "JUNE@GMAIL.COM", "June1234*", "AQAAAAEAACcQAAAAEHXSUiNL775Tm+0Ahr6ncNFtAboCOI0uAs6A5ybOZix+wASqS3DpGWZK8cU0rgFVeA==", "9273 8983", true, "Staff", "f5329ad9-d62f-4cdf-b303-fdc9c40876d3", false, "june@gmail.com" },
                    { "3781efa7-66dc-47f0-860f-e506d04102s2", 0, "TPharmacy", "0fad1027-ef30-4774-a243-d82df969fc22", "woon@gmail.com", true, true, null, "Woon", "WOON@GMAIL.COM", "WOON@GMAIL.COM", "June1234*", "AQAAAAEAACcQAAAAEI3ssRmhG8Xs3Qj5vI1RbOHMmNWk4E861bAt+4XeUPhrjj1Ry2KXsWuVWoOKDJWjuQ==", "9287 2324", true, "Staff", "ba2521d4-0848-44da-8aae-52a74a52a59d", false, "woon@gmail.com" },
                    { "3781efa7-66dc-47f0-860f-e506d04102s3", 0, "TPharmacy", "f80e7a38-cfd1-4ba2-8b17-579c4fe5365a", "kate@gmail.com", true, true, null, "Kate", "KATE@GMAIL.COM", "KATE@GMAIL.COM", "June1234*", "AQAAAAEAACcQAAAAEK7akgYM4vbJWSaVL+xgcv1xoY7PQccb04Ff5IK9r7wV+V+/yC7mggpMLk4Bz6JpWw==", "6329 9823", true, "Staff", "0035edeb-9ab0-4904-b133-7f0bbb3dee55", false, "kate@gmail.com" },
                    { "3781efa7-66dc-47f0-860f-e506d04102c1", 0, "Tampines Ave 1", "4b6aaf3b-abd5-4cb0-9b86-3d60519c932a", "james@gmail.com", true, true, null, "James", "JAMES@GMAIL.COM", "JAMES@GMAIL.COM", "June1234*", "AQAAAAEAACcQAAAAEOsUBbfl0uxDVnV4CDD6VmQMbP/26l3N/ByGxZlgIaTQPKSVpodPwXDZCa0RH/jRLw==", "8211 7319", true, "Customer", "3df96688-eb82-431a-8fe7-881f2b66f17e", false, "james@gmail.com" },
                    { "3781efa7-66dc-47f0-860f-e506d04102c2", 0, "Bedok Ave 1", "c01647f6-0f9b-499e-bfc9-cd92feebdf5e", "alice@gmail.com", true, true, null, "Alice", "ALICE@GMAIL.COM", "ALICE@GMAIL.COM", "June1234*", "AQAAAAEAACcQAAAAEEYOj0c8MBDraUshO1Kc9nYmnRr4wmLEWryqHe2G7BViVgk+bgQyaKR48mKaYYHgUw==", "8329 7433", true, "Customer", "64584af3-61c0-41a4-bbe4-43c1eb8819c0", false, "alice@gmail.com" },
                    { "3781efa7-66dc-47f0-860f-e506d04102c3", 0, "Jurong Ave 1", "387a5d62-741a-43ed-8ad9-cd50228ef493", "sheila@gmail.com", true, true, null, "Sheila", "SHEILA@GMAIL.COM", "SHEILA@GMAIL.COM", "June1234*", "AQAAAAEAACcQAAAAELIFTT5sTHtMer8MvGAJUnCnihRw69Sw8ZdfZG+pwCYSi5xo7ivgcuCwvwBNKRx5JQ==", "9436 7238", true, "Customer", "5600790a-b9b2-4b85-8390-2787b9d1ecf1", false, "sheila@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "ID", "CreatedBy", "CusAddress", "CusEmail", "CusName", "CusNumber", "CusPassword", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[,]
                {
                    { 3, "System", "Jurong Ave 1", "sheila@gmail.com", "Sheila", "87511773", "June1234*", new DateTime(2023, 2, 6, 1, 0, 13, 412, DateTimeKind.Local).AddTicks(426), new DateTime(2023, 2, 6, 1, 0, 13, 412, DateTimeKind.Local).AddTicks(427), "System" },
                    { 1, "System", "Tampines Ave 1", "james@gmail.com", "James", "87439653", "June1234*", new DateTime(2023, 2, 6, 1, 0, 13, 412, DateTimeKind.Local).AddTicks(409), new DateTime(2023, 2, 6, 1, 0, 13, 412, DateTimeKind.Local).AddTicks(421), "System" },
                    { 2, "System", "Bedok Ave 1", "alice@gmail.com", "Alice", "96512845", "June1234*", new DateTime(2023, 2, 6, 1, 0, 13, 412, DateTimeKind.Local).AddTicks(424), new DateTime(2023, 2, 6, 1, 0, 13, 412, DateTimeKind.Local).AddTicks(425), "System" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ID", "CreatedBy", "DateCreated", "DateUpdated", "ProdBrand", "ProdCategory", "ProdDesc", "ProdName", "ProdPrice", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2023, 2, 6, 1, 0, 13, 409, DateTimeKind.Local).AddTicks(3556), new DateTime(2023, 2, 6, 1, 0, 13, 410, DateTimeKind.Local).AddTicks(4222), "Blackmores", "Supplement", "BLACKMORES Bio Vitamin C 1000mg 120 Tablets", "Vitamin C", 35.00m, "System" },
                    { 2, "System", new DateTime(2023, 2, 6, 1, 0, 13, 410, DateTimeKind.Local).AddTicks(4835), new DateTime(2023, 2, 6, 1, 0, 13, 410, DateTimeKind.Local).AddTicks(4839), "Swisse", "Supplement", "Swisse Omega 3 Fish Oil 1500mg 100 Tablets", "Omega 3 Fish Oil", 58.00m, "System" },
                    { 3, "System", new DateTime(2023, 2, 6, 1, 0, 13, 410, DateTimeKind.Local).AddTicks(4841), new DateTime(2023, 2, 6, 1, 0, 13, 410, DateTimeKind.Local).AddTicks(4842), "Wastons", "Supplement", "Wastons Calcium 500mg 150 Tablets", "Calcium", 45.00m, "System" },
                    { 4, "System", new DateTime(2023, 2, 6, 1, 0, 13, 410, DateTimeKind.Local).AddTicks(4844), new DateTime(2023, 2, 6, 1, 0, 13, 410, DateTimeKind.Local).AddTicks(4845), "Telfast", "Prescriptions", "Telfast Panadol 10mg", "Panadol", 20.00m, "System" },
                    { 5, "System", new DateTime(2023, 2, 6, 1, 0, 13, 410, DateTimeKind.Local).AddTicks(4847), new DateTime(2023, 2, 6, 1, 0, 13, 410, DateTimeKind.Local).AddTicks(4848), "Cellucor", "Sports", "Cellucor Whey Protein Powder 5LBS", "Whey Protein Powder", 60.00m, "System" },
                    { 6, "System", new DateTime(2023, 2, 6, 1, 0, 13, 410, DateTimeKind.Local).AddTicks(4850), new DateTime(2023, 2, 6, 1, 0, 13, 410, DateTimeKind.Local).AddTicks(4851), "Solaray", "Baby", "Solaray Kids Multi Vitamins & Minerals Gummies 120S", "Kids Multi Vitamins & Minerals Gummies", 30.00m, "System" }
                });

            migrationBuilder.InsertData(
                table: "Staffs",
                columns: new[] { "ID", "CreatedBy", "DateCreated", "DateUpdated", "StafEmail", "StafName", "StafPassword", "StafRole", "UpdatedBy" },
                values: new object[,]
                {
                    { 2, "June", new DateTime(2023, 2, 6, 1, 0, 13, 411, DateTimeKind.Local).AddTicks(6493), new DateTime(2023, 2, 6, 1, 0, 13, 411, DateTimeKind.Local).AddTicks(6494), "woon@gmail.com", "Woon", "June1234*", 1, "System" },
                    { 1, "June", new DateTime(2023, 2, 6, 1, 0, 13, 411, DateTimeKind.Local).AddTicks(6475), new DateTime(2023, 2, 6, 1, 0, 13, 411, DateTimeKind.Local).AddTicks(6490), "june@gmail.com", "June", "June1234*", 0, "System" },
                    { 3, "June", new DateTime(2023, 2, 6, 1, 0, 13, 411, DateTimeKind.Local).AddTicks(6496), new DateTime(2023, 2, 6, 1, 0, 13, 411, DateTimeKind.Local).AddTicks(6497), "kate@gmail.com", "Kate", "June1234*", 2, "System" }
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
                    { 1, new DateTime(2023, 2, 6, 1, 0, 13, 412, DateTimeKind.Local).AddTicks(6878), "Flu Consultation", 60, 35.50m, "Completed", "Woon", 1, new DateTime(2023, 2, 6, 1, 0, 13, 412, DateTimeKind.Local).AddTicks(7767), new DateTime(2023, 2, 6, 1, 0, 13, 412, DateTimeKind.Local).AddTicks(7772), 2, "System" },
                    { 2, new DateTime(2023, 2, 6, 1, 0, 13, 412, DateTimeKind.Local).AddTicks(7775), "Eczema Consultation", 45, 30.50m, "Pending", "Woon", 3, new DateTime(2023, 2, 6, 1, 0, 13, 412, DateTimeKind.Local).AddTicks(7776), new DateTime(2023, 2, 6, 1, 0, 13, 412, DateTimeKind.Local).AddTicks(7777), 2, "System" }
                });

            migrationBuilder.InsertData(
                table: "Prescriptions",
                columns: new[] { "ID", "ConsultationID", "CreatedBy", "DateCreated", "DateUpdated", "PresQty", "ProductID", "UpdatedBy" },
                values: new object[] { 1, 1, "System", new DateTime(2023, 2, 6, 1, 0, 13, 412, DateTimeKind.Local).AddTicks(3063), new DateTime(2023, 2, 6, 1, 0, 13, 412, DateTimeKind.Local).AddTicks(3070), 1, 4, "System" });

            migrationBuilder.InsertData(
                table: "Prescriptions",
                columns: new[] { "ID", "ConsultationID", "CreatedBy", "DateCreated", "DateUpdated", "PresQty", "ProductID", "UpdatedBy" },
                values: new object[] { 2, 2, "System", new DateTime(2023, 2, 6, 1, 0, 13, 412, DateTimeKind.Local).AddTicks(3073), new DateTime(2023, 2, 6, 1, 0, 13, 412, DateTimeKind.Local).AddTicks(3074), 2, 4, "System" });

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
