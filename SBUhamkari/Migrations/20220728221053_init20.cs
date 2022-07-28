using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SBUhamkari.Migrations
{
    public partial class init20 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateIndex(
                name: "IX_Users_NationalIdNum",
                table: "Users",
                column: "NationalIdNum",
                unique: true,
                filter: "[NationalIdNum] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Users_Username",
                table: "Users",
                column: "Username",
                unique: true);
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
    }
}
