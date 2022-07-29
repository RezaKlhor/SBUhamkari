using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SBUhamkari.Migrations
{
    public partial class addmanytoman : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "EducationInstitutes",
                keyColumn: "id",
                keyValue: new Guid("00d1dd62-3db1-4d8a-b2ba-d079f8ac6d72"));

            migrationBuilder.DeleteData(
                table: "EducationInstitutes",
                keyColumn: "id",
                keyValue: new Guid("75756cf5-1c6e-4529-a007-0f85c99a5b13"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "id",
                keyValue: new Guid("06658cd5-d4ba-4555-a9b5-b82f78c80a04"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "id",
                keyValue: new Guid("1abb5c89-497a-4121-aeb6-db393e75bae3"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "id",
                keyValue: new Guid("36143fd4-3d8e-47ee-a24e-793cca9c6e52"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "id",
                keyValue: new Guid("d605640d-74bf-443f-82a0-0c8c8771779e"));

            migrationBuilder.InsertData(
                table: "EducationInstitutes",
                columns: new[] { "id", "CreateTime", "DeleteTime", "Name" },
                values: new object[,]
                {
                    { new Guid("03b58f46-67e5-4c69-afd3-30f91ee88d5d"), new DateTime(2022, 7, 29, 12, 17, 3, 263, DateTimeKind.Local).AddTicks(8300), null, "PNU" },
                    { new Guid("f8eeb179-8a8a-4c49-8ccd-a18b8a2a1525"), new DateTime(2022, 7, 29, 12, 17, 3, 263, DateTimeKind.Local).AddTicks(8248), null, "SBU" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "id", "CreateTime", "DeleteTime", "Name" },
                values: new object[,]
                {
                    { new Guid("19499498-e498-44a9-b549-6ff1fe92f933"), new DateTime(2022, 7, 29, 12, 17, 3, 263, DateTimeKind.Local).AddTicks(8376), null, "Professor" },
                    { new Guid("39098579-ea42-47ae-a347-330593a20136"), new DateTime(2022, 7, 29, 12, 17, 3, 263, DateTimeKind.Local).AddTicks(8361), null, "Admin" },
                    { new Guid("773e6b8b-252d-4e4d-b0f3-3548bef43472"), new DateTime(2022, 7, 29, 12, 17, 3, 263, DateTimeKind.Local).AddTicks(8402), null, "Company" },
                    { new Guid("93a2984c-b007-41d0-901d-a931de077720"), new DateTime(2022, 7, 29, 12, 17, 3, 263, DateTimeKind.Local).AddTicks(8371), null, "Student" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "EducationInstitutes",
                keyColumn: "id",
                keyValue: new Guid("03b58f46-67e5-4c69-afd3-30f91ee88d5d"));

            migrationBuilder.DeleteData(
                table: "EducationInstitutes",
                keyColumn: "id",
                keyValue: new Guid("f8eeb179-8a8a-4c49-8ccd-a18b8a2a1525"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "id",
                keyValue: new Guid("19499498-e498-44a9-b549-6ff1fe92f933"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "id",
                keyValue: new Guid("39098579-ea42-47ae-a347-330593a20136"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "id",
                keyValue: new Guid("773e6b8b-252d-4e4d-b0f3-3548bef43472"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "id",
                keyValue: new Guid("93a2984c-b007-41d0-901d-a931de077720"));

            migrationBuilder.InsertData(
                table: "EducationInstitutes",
                columns: new[] { "id", "CreateTime", "DeleteTime", "Name" },
                values: new object[,]
                {
                    { new Guid("00d1dd62-3db1-4d8a-b2ba-d079f8ac6d72"), new DateTime(2022, 7, 29, 12, 11, 4, 226, DateTimeKind.Local).AddTicks(8565), null, "PNU" },
                    { new Guid("75756cf5-1c6e-4529-a007-0f85c99a5b13"), new DateTime(2022, 7, 29, 12, 11, 4, 226, DateTimeKind.Local).AddTicks(8510), null, "SBU" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "id", "CreateTime", "DeleteTime", "Name" },
                values: new object[,]
                {
                    { new Guid("06658cd5-d4ba-4555-a9b5-b82f78c80a04"), new DateTime(2022, 7, 29, 12, 11, 4, 226, DateTimeKind.Local).AddTicks(8642), null, "Company" },
                    { new Guid("1abb5c89-497a-4121-aeb6-db393e75bae3"), new DateTime(2022, 7, 29, 12, 11, 4, 226, DateTimeKind.Local).AddTicks(8621), null, "Admin" },
                    { new Guid("36143fd4-3d8e-47ee-a24e-793cca9c6e52"), new DateTime(2022, 7, 29, 12, 11, 4, 226, DateTimeKind.Local).AddTicks(8633), null, "Student" },
                    { new Guid("d605640d-74bf-443f-82a0-0c8c8771779e"), new DateTime(2022, 7, 29, 12, 11, 4, 226, DateTimeKind.Local).AddTicks(8638), null, "Professor" }
                });
        }
    }
}
