using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TPharmacy.Server.Migrations
{
    public partial class initialdb : Migration
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
                    { "staff", "0191b26f-ed15-446f-8ab8-153883d7183b", "Staff", "STAFF" },
                    { "customer", "0c77c220-d6b4-4809-8607-ea360e2da374", "Customer", "CUSTOMER" },
                    { "admin", "9d114635-a657-4d06-9fdd-86ab266f3223", "Admin", "ADMIN" },
                    { "pharmacist", "705affed-c9d1-4f5e-a344-a57db7ab72d1", "Pharmacist", "PHARMACIST" },
                    { "packer", "baa54c05-1da0-46fa-8690-80d3ce2d556e", "Packer", "PACKER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "Password", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "3781efa7-66dc-47f0-860f-e506d04102c2", 0, "Bedok Ave 1", "3c570ebf-7979-466a-a81f-cf387bc7edc9", "alice@gmail.com", true, "Alice", "Customer", true, null, "ALICE@GMAIL.COM", "ALICE@GMAIL.COM", "Alice1234*", "AQAAAAEAACcQAAAAEBLVFwmPFI/mQqSzdpRbesWzJ8RYFc2liqFfcoDdyCtKFovt8OGdrlPNaq9jddUxbA==", "8329 7433", true, "a71b40d5-8d59-4674-9e98-a6063b6d709a", false, "alice@gmail.com" },
                    { "3781efa7-66dc-47f0-860f-e506d04102c1", 0, "Tampines Ave 1", "6fddb340-570e-4c8b-80ec-b6b1326f0e52", "james@gmail.com", true, "James", "Customer", true, null, "JAMES@GMAIL.COM", "JAMES@GMAIL.COM", "James1234*", "AQAAAAEAACcQAAAAEOl3DeyMdls1ldCME82/ZSflU0WNdwN6vwu8D67eVoib0co3aUpLvi5/mSIbIM8x4g==", "8211 7319", true, "ab433508-f111-407c-bc51-f8c2ff93b4f6", false, "james@gmail.com" },
                    { "3781efa7-66dc-47f0-860f-e506d04102c3", 0, "Jurong Ave 1", "d3bb59ea-ee0c-466d-b8d9-2caf848038a2", "grey@gmail.com", true, "Grey", "Customer", true, null, "GREY@GMAIL.COM", "GREY@GMAIL.COM", "Grey1234*", "AQAAAAEAACcQAAAAEDNZw4UCoKdeejZ+rxVX2Csk3ggHycxvly3yL/TVXXfonEa9nlexB+KMiubNbXCh/Q==", "9436 7238", true, "69059b90-b46c-42c2-b502-1ecb72a71e40", false, "grey@gmail.com" },
                    { "3781efa7-66dc-47f0-860f-e506d04102s2", 0, "TPharmacy", "0164d16c-779e-4bf3-87e0-0977b0526330", "woon@gmail.com", true, "Woon", "Staff", true, null, "WOON@GMAIL.COM", "WOON@GMAIL.COM", "P@ssword1", "AQAAAAEAACcQAAAAENd0tjQajjCDCV0KNPYIeWZegRx2lh0jScJyBcuVAzUMREdzLYf8QVVGEaR5kZTF4w==", "9287 2324", true, "a675f033-056f-4c0f-a3ac-59fc905ba81c", false, "woon@gmail.com" },
                    { "3781efa7-66dc-47f0-860f-e506d04102s1", 0, "TPharmacy", "b7acd781-eb3d-41df-a9f6-59166226e0fc", "june@gmail.com", true, "June", "Staff", true, null, "JUNE@GMAIL.COM", "JUNE@GMAIL.COM", "June1234*", "AQAAAAEAACcQAAAAECwwmD7VXYlQMZ7oA7p7+AwYCTqqqGWkjXyqPigEdWq5yUW8Vwjk46PPmla/BgUbsA==", "9273 8983", true, "73b5f7e0-efb2-4daf-ace9-2c39fff2967e", false, "june@gmail.com" },
                    { "3781efa7-66dc-47f0-860f-e506d04102s3", 0, "TPharmacy", "94b2b4ae-a1ee-4209-811c-6421fbfa86d4", "kate@gmail.com", true, "Kate", "Staff", true, null, "KATE@GMAIL.COM", "KATE@GMAIL.COM", "Kate1234*", "AQAAAAEAACcQAAAAEJ41CkrfJs/fOD/Ai21/X9nFMaEIMZn9WI/fI3vi+MAnwVARAoHdEjtHZNyrjR4tVg==", "6329 9823", true, "4cd2c392-b82f-4f31-a3d6-f4187ace24d9", false, "kate@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "ID", "CreatedBy", "CusAddress", "CusEmail", "CusName", "CusPassword", "CusPoints", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", "Tampines Ave 1", "james@gmail.com", "James", "James1234*", 100, new DateTime(2023, 1, 7, 21, 33, 33, 425, DateTimeKind.Local).AddTicks(347), new DateTime(2023, 1, 7, 21, 33, 33, 425, DateTimeKind.Local).AddTicks(350), "System" },
                    { 2, "System", "Bedok Ave 1", "alice@gmail.com", "Alice", "Alice1234*", 50, new DateTime(2023, 1, 7, 21, 33, 33, 425, DateTimeKind.Local).AddTicks(354), new DateTime(2023, 1, 7, 21, 33, 33, 425, DateTimeKind.Local).AddTicks(355), "System" },
                    { 3, "System", "Jurong Ave 1", "grey@gmail.com", "Grey", "Grey1234*", 89, new DateTime(2023, 1, 7, 21, 33, 33, 425, DateTimeKind.Local).AddTicks(357), new DateTime(2023, 1, 7, 21, 33, 33, 425, DateTimeKind.Local).AddTicks(358), "System" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ID", "CreatedBy", "DateCreated", "DateUpdated", "ProdBrand", "ProdCategory", "ProdDesc", "ProdName", "ProdPrice", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2023, 1, 7, 21, 33, 33, 422, DateTimeKind.Local).AddTicks(9958), new DateTime(2023, 1, 7, 21, 33, 33, 423, DateTimeKind.Local).AddTicks(6382), "Blackmores", "Supplement", "1000mg Vitamin C 120 Tablets", "Vitamin C", 35.00m, "System" },
                    { 2, "System", new DateTime(2023, 1, 7, 21, 33, 33, 423, DateTimeKind.Local).AddTicks(6898), new DateTime(2023, 1, 7, 21, 33, 33, 423, DateTimeKind.Local).AddTicks(6900), "Swisse", "Supplement", "1500mg 100 Tablets", "Omega 3 Fish Oil", 58.00m, "System" },
                    { 3, "System", new DateTime(2023, 1, 7, 21, 33, 33, 423, DateTimeKind.Local).AddTicks(6903), new DateTime(2023, 1, 7, 21, 33, 33, 423, DateTimeKind.Local).AddTicks(6904), "Wastons", "Supplement", "500mg 150 Tablets", "Calcium", 45.00m, "System" },
                    { 4, "System", new DateTime(2023, 1, 7, 21, 33, 33, 423, DateTimeKind.Local).AddTicks(6906), new DateTime(2023, 1, 7, 21, 33, 33, 423, DateTimeKind.Local).AddTicks(6907), "Telfast", "Prescriptions", "10mg", "Panadol", 20.00m, "System" }
                });

            migrationBuilder.InsertData(
                table: "Staffs",
                columns: new[] { "ID", "CreatedBy", "DateCreated", "DateUpdated", "StafEmail", "StafName", "StafPassword", "StafRole", "UpdatedBy" },
                values: new object[,]
                {
                    { 2, "June", new DateTime(2023, 1, 7, 21, 33, 33, 424, DateTimeKind.Local).AddTicks(7380), new DateTime(2023, 1, 7, 21, 33, 33, 424, DateTimeKind.Local).AddTicks(7381), "woon@gmail.com", "Woon", "Woon1234*", "Pharmacist", "System" },
                    { 1, "June", new DateTime(2023, 1, 7, 21, 33, 33, 424, DateTimeKind.Local).AddTicks(7366), new DateTime(2023, 1, 7, 21, 33, 33, 424, DateTimeKind.Local).AddTicks(7377), "june@gmail.com", "June", "June1234*", "Admin", "System" },
                    { 3, "June", new DateTime(2023, 1, 7, 21, 33, 33, 424, DateTimeKind.Local).AddTicks(7383), new DateTime(2023, 1, 7, 21, 33, 33, 424, DateTimeKind.Local).AddTicks(7384), "kate@gmail.com", "Kate", "Kate1234*", "Packer", "System" }
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
                    { 1, new DateTime(2023, 1, 7, 21, 33, 33, 426, DateTimeKind.Local).AddTicks(3177), "Flu Consultation", new DateTime(2023, 1, 7, 22, 42, 33, 426, DateTimeKind.Local).AddTicks(3406), 35.50m, new DateTime(2023, 1, 7, 21, 33, 33, 426, DateTimeKind.Local).AddTicks(3309), "Woon", 1, null, new DateTime(2023, 1, 7, 21, 33, 33, 426, DateTimeKind.Local).AddTicks(3844), new DateTime(2023, 1, 7, 21, 33, 33, 426, DateTimeKind.Local).AddTicks(3846), 1, "System" },
                    { 2, new DateTime(2023, 1, 7, 21, 33, 33, 426, DateTimeKind.Local).AddTicks(3849), "Eczema Consultation", new DateTime(2023, 1, 7, 22, 33, 33, 426, DateTimeKind.Local).AddTicks(3851), 30.50m, new DateTime(2023, 1, 7, 21, 33, 33, 426, DateTimeKind.Local).AddTicks(3850), "Woon", 3, null, new DateTime(2023, 1, 7, 21, 33, 33, 426, DateTimeKind.Local).AddTicks(3855), new DateTime(2023, 1, 7, 21, 33, 33, 426, DateTimeKind.Local).AddTicks(3856), 1, "System" }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "ID", "CreatedBy", "CusID", "CustomerID", "DateCreated", "DateUpdated", "OrderDateTime", "OrderPrice", "StaffID", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", 1, null, new DateTime(2023, 1, 7, 21, 33, 33, 425, DateTimeKind.Local).AddTicks(3317), new DateTime(2023, 1, 7, 21, 33, 33, 425, DateTimeKind.Local).AddTicks(3318), new DateTime(2023, 1, 7, 21, 33, 33, 425, DateTimeKind.Local).AddTicks(3040), 128.00m, 3, "Kate" },
                    { 2, "System", 2, null, new DateTime(2023, 1, 7, 21, 33, 33, 425, DateTimeKind.Local).AddTicks(3323), new DateTime(2023, 1, 7, 21, 33, 33, 425, DateTimeKind.Local).AddTicks(3324), new DateTime(2023, 1, 7, 21, 33, 33, 425, DateTimeKind.Local).AddTicks(3321), 90.00m, 3, "Kate" }
                });

            migrationBuilder.InsertData(
                table: "Prescriptions",
                columns: new[] { "ID", "ConID", "ConsultationID", "CreatedBy", "DateCreated", "DateUpdated", "PresQty", "ProductID", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, 1, null, "System", new DateTime(2023, 1, 7, 21, 33, 33, 426, DateTimeKind.Local).AddTicks(71), new DateTime(2023, 1, 7, 21, 33, 33, 426, DateTimeKind.Local).AddTicks(74), 1, 4, "System" },
                    { 2, 2, null, "System", new DateTime(2023, 1, 7, 21, 33, 33, 426, DateTimeKind.Local).AddTicks(76), new DateTime(2023, 1, 7, 21, 33, 33, 426, DateTimeKind.Local).AddTicks(77), 2, 4, "System" }
                });

            migrationBuilder.InsertData(
                table: "OrderItems",
                columns: new[] { "ID", "CreatedBy", "DateCreated", "DateUpdated", "OrderID", "OrderItemQtny", "ProductID", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2023, 1, 7, 21, 33, 33, 425, DateTimeKind.Local).AddTicks(5630), new DateTime(2023, 1, 7, 21, 33, 33, 425, DateTimeKind.Local).AddTicks(5634), 1, 2, 1, "Kate" },
                    { 2, "System", new DateTime(2023, 1, 7, 21, 33, 33, 425, DateTimeKind.Local).AddTicks(5636), new DateTime(2023, 1, 7, 21, 33, 33, 425, DateTimeKind.Local).AddTicks(5637), 1, 1, 2, "Kate" },
                    { 3, "System", new DateTime(2023, 1, 7, 21, 33, 33, 425, DateTimeKind.Local).AddTicks(5639), new DateTime(2023, 1, 7, 21, 33, 33, 425, DateTimeKind.Local).AddTicks(5640), 2, 1, 3, "Kate" }
                });

            migrationBuilder.InsertData(
                table: "Payments",
                columns: new[] { "ID", "CreatedBy", "DateCreated", "DateUpdated", "OrderID", "PayCardInfo", "PayFee", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2023, 1, 7, 21, 33, 33, 425, DateTimeKind.Local).AddTicks(8128), new DateTime(2023, 1, 7, 21, 33, 33, 425, DateTimeKind.Local).AddTicks(8132), 1, "7855-3798-2344-9853", 5.00m, "System" },
                    { 2, "System", new DateTime(2023, 1, 7, 21, 33, 33, 425, DateTimeKind.Local).AddTicks(8135), new DateTime(2023, 1, 7, 21, 33, 33, 425, DateTimeKind.Local).AddTicks(8135), 2, "3244-2355-3459-9767", 15.00m, "System" }
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
