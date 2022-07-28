using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SBUhamkari.Migrations
{
    public partial class init19 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "EducationInstitutes",
                keyColumn: "id",
                keyValue: new Guid("0996bd5f-4ea5-4f15-8b28-56a4de2305f2"));

            migrationBuilder.DeleteData(
                table: "EducationInstitutes",
                keyColumn: "id",
                keyValue: new Guid("d4b2f6fd-5eae-4de0-935d-593fd1aad955"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "id",
                keyValue: new Guid("11c46ad6-de26-40dd-bfd0-6167616d2bb2"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "id",
                keyValue: new Guid("2ba5d976-2404-4537-a190-fa2ded8f4621"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "id",
                keyValue: new Guid("3b217189-8e6c-4e25-9cb5-766d5654062b"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "id",
                keyValue: new Guid("50134c68-4ca6-49ea-8171-f6dd1187de0f"));

            migrationBuilder.DeleteData(
                table: "WorkFields",
                keyColumn: "id",
                keyValue: new Guid("2abcf5fc-7b59-40cb-aff6-2c850f5a2653"));

            migrationBuilder.DeleteData(
                table: "WorkFields",
                keyColumn: "id",
                keyValue: new Guid("2d92fece-d45e-4d56-a347-6059653cba9d"));

            migrationBuilder.DeleteData(
                table: "WorkFields",
                keyColumn: "id",
                keyValue: new Guid("afeb9131-f0e3-425d-995e-48b734cd943c"));

            migrationBuilder.DeleteData(
                table: "WorkFields",
                keyColumn: "id",
                keyValue: new Guid("c639c78d-e2a2-40c6-82fd-6ee30a893440"));

            migrationBuilder.AlterColumn<string>(
                name: "Username",
                table: "Users",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                table: "EducationInstitutes",
                columns: new[] { "id", "CreateTime", "DeleteTime", "Name" },
                values: new object[,]
                {
                    { new Guid("05444025-83e0-4cb2-b458-b55bc50eac11"), new DateTime(2022, 7, 29, 2, 16, 16, 28, DateTimeKind.Local).AddTicks(1807), null, "PNU" },
                    { new Guid("6902dbda-13e2-4ed4-83d4-cf1058fecb84"), new DateTime(2022, 7, 29, 2, 16, 16, 28, DateTimeKind.Local).AddTicks(1730), null, "SBU" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "id", "CreateTime", "DeleteTime", "Name" },
                values: new object[,]
                {
                    { new Guid("2b73a823-5b08-4a35-848b-c21abcb806b7"), new DateTime(2022, 7, 29, 2, 16, 16, 28, DateTimeKind.Local).AddTicks(1877), null, "Admin" },
                    { new Guid("3129ee82-8693-40b9-9227-ab7cf830775c"), new DateTime(2022, 7, 29, 2, 16, 16, 28, DateTimeKind.Local).AddTicks(1894), null, "teacher" },
                    { new Guid("77b3b07c-3038-4de0-8905-933d4675c456"), new DateTime(2022, 7, 29, 2, 16, 16, 28, DateTimeKind.Local).AddTicks(1889), null, "Student" },
                    { new Guid("b82fc0bf-89d9-40d8-9886-793e6d52bbad"), new DateTime(2022, 7, 29, 2, 16, 16, 28, DateTimeKind.Local).AddTicks(1907), null, "Company" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Users_NationalIdNum",
                table: "Users",
                column: "NationalIdNum");

            migrationBuilder.CreateIndex(
                name: "IX_Users_Username",
                table: "Users",
                column: "Username");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Users_NationalIdNum",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_Username",
                table: "Users");

            migrationBuilder.DeleteData(
                table: "EducationInstitutes",
                keyColumn: "id",
                keyValue: new Guid("05444025-83e0-4cb2-b458-b55bc50eac11"));

            migrationBuilder.DeleteData(
                table: "EducationInstitutes",
                keyColumn: "id",
                keyValue: new Guid("6902dbda-13e2-4ed4-83d4-cf1058fecb84"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "id",
                keyValue: new Guid("2b73a823-5b08-4a35-848b-c21abcb806b7"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "id",
                keyValue: new Guid("3129ee82-8693-40b9-9227-ab7cf830775c"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "id",
                keyValue: new Guid("77b3b07c-3038-4de0-8905-933d4675c456"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "id",
                keyValue: new Guid("b82fc0bf-89d9-40d8-9886-793e6d52bbad"));

            migrationBuilder.AlterColumn<string>(
                name: "Username",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.InsertData(
                table: "EducationInstitutes",
                columns: new[] { "id", "CreateTime", "DeleteTime", "Name" },
                values: new object[,]
                {
                    { new Guid("0996bd5f-4ea5-4f15-8b28-56a4de2305f2"), new DateTime(2022, 7, 29, 0, 8, 28, 634, DateTimeKind.Local).AddTicks(5707), null, "SBU" },
                    { new Guid("d4b2f6fd-5eae-4de0-935d-593fd1aad955"), new DateTime(2022, 7, 29, 0, 8, 28, 634, DateTimeKind.Local).AddTicks(5763), null, "PNU" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "id", "CreateTime", "DeleteTime", "Name" },
                values: new object[,]
                {
                    { new Guid("11c46ad6-de26-40dd-bfd0-6167616d2bb2"), new DateTime(2022, 7, 29, 0, 8, 28, 634, DateTimeKind.Local).AddTicks(5828), null, "teacher" },
                    { new Guid("2ba5d976-2404-4537-a190-fa2ded8f4621"), new DateTime(2022, 7, 29, 0, 8, 28, 634, DateTimeKind.Local).AddTicks(5852), null, "Company" },
                    { new Guid("3b217189-8e6c-4e25-9cb5-766d5654062b"), new DateTime(2022, 7, 29, 0, 8, 28, 634, DateTimeKind.Local).AddTicks(5823), null, "Student" },
                    { new Guid("50134c68-4ca6-49ea-8171-f6dd1187de0f"), new DateTime(2022, 7, 29, 0, 8, 28, 634, DateTimeKind.Local).AddTicks(5813), null, "Admin" }
                });

            migrationBuilder.InsertData(
                table: "WorkFields",
                columns: new[] { "id", "CreateTime", "DeleteTime", "Name" },
                values: new object[,]
                {
                    { new Guid("2abcf5fc-7b59-40cb-aff6-2c850f5a2653"), new DateTime(2022, 7, 29, 0, 8, 28, 634, DateTimeKind.Local).AddTicks(5912), null, "Network" },
                    { new Guid("2d92fece-d45e-4d56-a347-6059653cba9d"), new DateTime(2022, 7, 29, 0, 8, 28, 634, DateTimeKind.Local).AddTicks(5908), null, "Hardware" },
                    { new Guid("afeb9131-f0e3-425d-995e-48b734cd943c"), new DateTime(2022, 7, 29, 0, 8, 28, 634, DateTimeKind.Local).AddTicks(5904), null, "Software" },
                    { new Guid("c639c78d-e2a2-40c6-82fd-6ee30a893440"), new DateTime(2022, 7, 29, 0, 8, 28, 634, DateTimeKind.Local).AddTicks(5894), null, "AI" }
                });
        }
    }
}
