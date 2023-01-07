using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace TPharmacy.Server.Data.Migrations
{
    public partial class AddSeedingData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "ID", "CreatedBy", "CusAddress", "CusEmail", "CusName", "CusPassword", "CusPoints", "DataUpdated", "DateCreated", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", "Tampines Ave 1", "james@gmail.com", "James", "James1234*", 100, new DateTime(2022, 12, 16, 21, 45, 15, 703, DateTimeKind.Local).AddTicks(4105), new DateTime(2022, 12, 16, 21, 45, 15, 703, DateTimeKind.Local).AddTicks(4102), "System" },
                    { 2, "System", "Bedok Ave 1", "alice@gmail.com", "Alice", "Alice1234*", 50, new DateTime(2022, 12, 16, 21, 45, 15, 703, DateTimeKind.Local).AddTicks(4109), new DateTime(2022, 12, 16, 21, 45, 15, 703, DateTimeKind.Local).AddTicks(4108), "System" },
                    { 3, "System", "Temasek Polytechnic", "grey@gmail.com", "Grey", "Grey1234*", 89, new DateTime(2022, 12, 16, 21, 45, 15, 703, DateTimeKind.Local).AddTicks(4111), new DateTime(2022, 12, 16, 21, 45, 15, 703, DateTimeKind.Local).AddTicks(4111), "System" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ID", "CreatedBy", "DataUpdated", "DateCreated", "ProdBrand", "ProdDesc", "ProdName", "ProdPrice", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2022, 12, 16, 21, 45, 15, 702, DateTimeKind.Local).AddTicks(897), new DateTime(2022, 12, 16, 21, 45, 15, 701, DateTimeKind.Local).AddTicks(5014), "Blackmores", "BLACKMORES Bio 1000mg Vitamin C 120 Tablets", "Vitamin C", 35.00m, "System" },
                    { 2, "System", new DateTime(2022, 12, 16, 21, 45, 15, 702, DateTimeKind.Local).AddTicks(1329), new DateTime(2022, 12, 16, 21, 45, 15, 702, DateTimeKind.Local).AddTicks(1327), "Swisse", "Omega 3 Fish Oil 1500mg 100 Tablets", "Omega 3 Fish Oil", 58.00m, "System" },
                    { 3, "System", new DateTime(2022, 12, 16, 21, 45, 15, 702, DateTimeKind.Local).AddTicks(1333), new DateTime(2022, 12, 16, 21, 45, 15, 702, DateTimeKind.Local).AddTicks(1332), "Wastons", "Calcium 500mg 150 Tablets", "Calcium", 45.00m, "System" }
                });

            migrationBuilder.InsertData(
                table: "Staffs",
                columns: new[] { "ID", "CreatedBy", "DataUpdated", "DateCreated", "StafEmail", "StafName", "StafPassword", "StafRole", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "June", new DateTime(2022, 12, 16, 21, 45, 15, 703, DateTimeKind.Local).AddTicks(1283), new DateTime(2022, 12, 16, 21, 45, 15, 703, DateTimeKind.Local).AddTicks(1275), "woon@gmail.com", "Woon", "Woon1234*", "Pharmacist", "System" },
                    { 2, "June", new DateTime(2022, 12, 16, 21, 45, 15, 703, DateTimeKind.Local).AddTicks(1287), new DateTime(2022, 12, 16, 21, 45, 15, 703, DateTimeKind.Local).AddTicks(1286), "june@gmail.com", "June", "June1234*", "Admin", "System" },
                    { 3, "June", new DateTime(2022, 12, 16, 21, 45, 15, 703, DateTimeKind.Local).AddTicks(1290), new DateTime(2022, 12, 16, 21, 45, 15, 703, DateTimeKind.Local).AddTicks(1289), "kate@gmail.com", "Kate", "Kate1234*", "Packer", "System" }
                });

            migrationBuilder.InsertData(
                table: "Consultations",
                columns: new[] { "ID", "ConDate", "ConDesc", "ConEndTime", "ConFee", "ConStartTime", "CreatedBy", "CusID", "CustomerID", "DataUpdated", "DateCreated", "StaffID", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 12, 16, 21, 45, 15, 704, DateTimeKind.Local).AddTicks(5647), "Flu Consultation", new DateTime(2022, 12, 16, 22, 54, 15, 704, DateTimeKind.Local).AddTicks(5851), 35.50m, new DateTime(2022, 12, 16, 21, 45, 15, 704, DateTimeKind.Local).AddTicks(5762), "Woon", 1, null, new DateTime(2022, 12, 16, 21, 45, 15, 704, DateTimeKind.Local).AddTicks(6247), new DateTime(2022, 12, 16, 21, 45, 15, 704, DateTimeKind.Local).AddTicks(6246), 1, "System" },
                    { 2, new DateTime(2022, 12, 16, 21, 45, 15, 704, DateTimeKind.Local).AddTicks(6250), "Eczema Consultation", new DateTime(2022, 12, 16, 22, 45, 15, 704, DateTimeKind.Local).AddTicks(6251), 30.50m, new DateTime(2022, 12, 16, 21, 45, 15, 704, DateTimeKind.Local).AddTicks(6251), "Woon", 3, null, new DateTime(2022, 12, 16, 21, 45, 15, 704, DateTimeKind.Local).AddTicks(6256), new DateTime(2022, 12, 16, 21, 45, 15, 704, DateTimeKind.Local).AddTicks(6255), 1, "System" }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "ID", "CreatedBy", "CusID", "CustomerID", "DataUpdated", "DateCreated", "OrderDateTime", "OrderPrice", "StaffID", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", 1, null, new DateTime(2022, 12, 16, 21, 45, 15, 703, DateTimeKind.Local).AddTicks(6596), new DateTime(2022, 12, 16, 21, 45, 15, 703, DateTimeKind.Local).AddTicks(6594), new DateTime(2022, 12, 16, 21, 45, 15, 703, DateTimeKind.Local).AddTicks(6344), 128.00m, 3, "Kate" },
                    { 2, "System", 2, null, new DateTime(2022, 12, 16, 21, 45, 15, 703, DateTimeKind.Local).AddTicks(6600), new DateTime(2022, 12, 16, 21, 45, 15, 703, DateTimeKind.Local).AddTicks(6599), new DateTime(2022, 12, 16, 21, 45, 15, 703, DateTimeKind.Local).AddTicks(6598), 90.00m, 3, "Kate" }
                });

            migrationBuilder.InsertData(
                table: "Prescriptions",
                columns: new[] { "ID", "ConID", "ConsultationID", "CreatedBy", "DataUpdated", "DateCreated", "PresQty", "ProductID", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, 1, null, "System", new DateTime(2022, 12, 16, 21, 45, 15, 704, DateTimeKind.Local).AddTicks(2965), new DateTime(2022, 12, 16, 21, 45, 15, 704, DateTimeKind.Local).AddTicks(2963), 1, 1, "System" },
                    { 2, 2, null, "System", new DateTime(2022, 12, 16, 21, 45, 15, 704, DateTimeKind.Local).AddTicks(2968), new DateTime(2022, 12, 16, 21, 45, 15, 704, DateTimeKind.Local).AddTicks(2968), 2, 3, "System" }
                });

            migrationBuilder.InsertData(
                table: "OrderItems",
                columns: new[] { "ID", "CreatedBy", "DataUpdated", "DateCreated", "OrderID", "OrderQtny", "ProductID", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2022, 12, 16, 21, 45, 15, 703, DateTimeKind.Local).AddTicks(8698), new DateTime(2022, 12, 16, 21, 45, 15, 703, DateTimeKind.Local).AddTicks(8695), 1, 2, 1, "Kate" },
                    { 2, "System", new DateTime(2022, 12, 16, 21, 45, 15, 703, DateTimeKind.Local).AddTicks(8701), new DateTime(2022, 12, 16, 21, 45, 15, 703, DateTimeKind.Local).AddTicks(8700), 1, 1, 2, "Kate" },
                    { 3, "System", new DateTime(2022, 12, 16, 21, 45, 15, 703, DateTimeKind.Local).AddTicks(8704), new DateTime(2022, 12, 16, 21, 45, 15, 703, DateTimeKind.Local).AddTicks(8703), 2, 1, 3, "Kate" }
                });

            migrationBuilder.InsertData(
                table: "Payments",
                columns: new[] { "ID", "CreatedBy", "DataUpdated", "DateCreated", "OrderID", "PayCardInfo", "PayFee", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2022, 12, 16, 21, 45, 15, 704, DateTimeKind.Local).AddTicks(1129), new DateTime(2022, 12, 16, 21, 45, 15, 704, DateTimeKind.Local).AddTicks(1125), 1, "7855-3798-2344-9853", 128.00m, "System" },
                    { 2, "System", new DateTime(2022, 12, 16, 21, 45, 15, 704, DateTimeKind.Local).AddTicks(1132), new DateTime(2022, 12, 16, 21, 45, 15, 704, DateTimeKind.Local).AddTicks(1131), 2, "3244-2355-3459-9767", 103.00m, "System" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Consultations",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Consultations",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Staffs",
                keyColumn: "ID",
                keyValue: 3);
        }
    }
}
