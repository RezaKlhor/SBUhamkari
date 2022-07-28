using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SBUhamkari.Migrations
{
    public partial class init22 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "EducationInstitutes",
                keyColumn: "id",
                keyValue: new Guid("c0393ec9-0017-4be6-a555-7b950d373f62"));

            migrationBuilder.DeleteData(
                table: "EducationInstitutes",
                keyColumn: "id",
                keyValue: new Guid("c0a92c6b-73ad-4af7-95af-b6fcb4856954"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "id",
                keyValue: new Guid("3ddb50b0-1efe-46ab-8c6e-009ac90effc7"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "id",
                keyValue: new Guid("b2ea2d4c-26c4-47f7-bac4-db3b17d270b7"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "id",
                keyValue: new Guid("b65f157d-0bc7-40b3-8705-69cba080d551"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "id",
                keyValue: new Guid("fbcd3639-48af-4a09-bfa0-d763e10d5f55"));

            migrationBuilder.InsertData(
                table: "EducationInstitutes",
                columns: new[] { "id", "CreateTime", "DeleteTime", "Name" },
                values: new object[,]
                {
                    { new Guid("14318a28-cdc6-42ad-b79b-7d66354f7c20"), new DateTime(2022, 7, 29, 2, 48, 40, 166, DateTimeKind.Local).AddTicks(221), null, "PNU" },
                    { new Guid("1c045765-f599-4e9e-8675-c35850e7bd7e"), new DateTime(2022, 7, 29, 2, 48, 40, 166, DateTimeKind.Local).AddTicks(163), null, "SBU" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "id", "CreateTime", "DeleteTime", "Name" },
                values: new object[,]
                {
                    { new Guid("299eb75d-d8c5-4b31-a92c-5bb3760f8b6b"), new DateTime(2022, 7, 29, 2, 48, 40, 166, DateTimeKind.Local).AddTicks(312), null, "Student" },
                    { new Guid("a2f679aa-9e3c-42b6-919a-4b08e455d714"), new DateTime(2022, 7, 29, 2, 48, 40, 166, DateTimeKind.Local).AddTicks(317), null, "Professor" },
                    { new Guid("ca605958-d455-453a-8647-94bfdb604dca"), new DateTime(2022, 7, 29, 2, 48, 40, 166, DateTimeKind.Local).AddTicks(278), null, "Admin" },
                    { new Guid("df959137-65ce-4387-a057-2e60d986cbac"), new DateTime(2022, 7, 29, 2, 48, 40, 166, DateTimeKind.Local).AddTicks(323), null, "Company" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Users_CompanyIDnumber",
                table: "Users",
                column: "CompanyIDnumber",
                unique: true,
                filter: "[CompanyIDnumber] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Users_CompanyIDnumber",
                table: "Users");

            migrationBuilder.DeleteData(
                table: "EducationInstitutes",
                keyColumn: "id",
                keyValue: new Guid("14318a28-cdc6-42ad-b79b-7d66354f7c20"));

            migrationBuilder.DeleteData(
                table: "EducationInstitutes",
                keyColumn: "id",
                keyValue: new Guid("1c045765-f599-4e9e-8675-c35850e7bd7e"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "id",
                keyValue: new Guid("299eb75d-d8c5-4b31-a92c-5bb3760f8b6b"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "id",
                keyValue: new Guid("a2f679aa-9e3c-42b6-919a-4b08e455d714"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "id",
                keyValue: new Guid("ca605958-d455-453a-8647-94bfdb604dca"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "id",
                keyValue: new Guid("df959137-65ce-4387-a057-2e60d986cbac"));

            migrationBuilder.InsertData(
                table: "EducationInstitutes",
                columns: new[] { "id", "CreateTime", "DeleteTime", "Name" },
                values: new object[,]
                {
                    { new Guid("c0393ec9-0017-4be6-a555-7b950d373f62"), new DateTime(2022, 7, 29, 2, 40, 52, 471, DateTimeKind.Local).AddTicks(7352), null, "SBU" },
                    { new Guid("c0a92c6b-73ad-4af7-95af-b6fcb4856954"), new DateTime(2022, 7, 29, 2, 40, 52, 471, DateTimeKind.Local).AddTicks(7418), null, "PNU" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "id", "CreateTime", "DeleteTime", "Name" },
                values: new object[,]
                {
                    { new Guid("3ddb50b0-1efe-46ab-8c6e-009ac90effc7"), new DateTime(2022, 7, 29, 2, 40, 52, 471, DateTimeKind.Local).AddTicks(7495), null, "teacher" },
                    { new Guid("b2ea2d4c-26c4-47f7-bac4-db3b17d270b7"), new DateTime(2022, 7, 29, 2, 40, 52, 471, DateTimeKind.Local).AddTicks(7481), null, "Admin" },
                    { new Guid("b65f157d-0bc7-40b3-8705-69cba080d551"), new DateTime(2022, 7, 29, 2, 40, 52, 471, DateTimeKind.Local).AddTicks(7490), null, "Student" },
                    { new Guid("fbcd3639-48af-4a09-bfa0-d763e10d5f55"), new DateTime(2022, 7, 29, 2, 40, 52, 471, DateTimeKind.Local).AddTicks(7535), null, "Company" }
                });
        }
    }
}
