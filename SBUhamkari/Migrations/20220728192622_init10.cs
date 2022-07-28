using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SBUhamkari.Migrations
{
    public partial class init10 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "EducationInstitutes",
                keyColumn: "id",
                keyValue: new Guid("2ff3126b-0f23-418a-9247-90234066b197"));

            migrationBuilder.DeleteData(
                table: "EducationInstitutes",
                keyColumn: "id",
                keyValue: new Guid("98325204-3865-4038-838c-35ff67d0ad51"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "id",
                keyValue: new Guid("d5fa8e73-b372-4b4f-8a55-e0d635965ba4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "id",
                keyValue: new Guid("93c798fe-053a-4f1a-af3c-42d9617a5ba4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "id",
                keyValue: new Guid("1e3bc656-e89e-40ad-856b-e00b129dec4b"));

            migrationBuilder.DeleteData(
                table: "WorkFields",
                keyColumn: "id",
                keyValue: new Guid("3b133e33-1343-4fee-8f20-fe6bf047d00b"));

            migrationBuilder.DeleteData(
                table: "WorkFields",
                keyColumn: "id",
                keyValue: new Guid("6730cbe5-19e5-4e36-bbd8-c0983ad4de8c"));

            migrationBuilder.DeleteData(
                table: "WorkFields",
                keyColumn: "id",
                keyValue: new Guid("6bfb351f-3127-4d21-9b5c-209d4cac58e9"));

            migrationBuilder.DeleteData(
                table: "WorkFields",
                keyColumn: "id",
                keyValue: new Guid("908a1a43-c354-46cb-a598-3f2dea35b1cc"));

            migrationBuilder.InsertData(
                table: "EducationInstitutes",
                columns: new[] { "id", "CreateTime", "DeleteTime", "Name" },
                values: new object[,]
                {
                    { new Guid("71281c25-7197-471d-ba16-cc350091a55a"), new DateTime(2022, 7, 28, 23, 56, 21, 132, DateTimeKind.Local).AddTicks(5388), null, "PNU" },
                    { new Guid("dec05e9e-7e29-4f04-9f38-37716f9a1a84"), new DateTime(2022, 7, 28, 23, 56, 21, 132, DateTimeKind.Local).AddTicks(5320), null, "SBU" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "id", "Avatar", "CompanyIDnumber", "CompanyName", "Companyid", "CreateTime", "DeleteTime", "Discriminator", "Facultyid", "Password", "Roleid", "Username" },
                values: new object[] { new Guid("2a89570e-7c0c-42ef-b5e1-da5909c7e4fe"), null, 2222222222L, "مرکز رشد دانشکده کامپیوتر", null, new DateTime(2022, 7, 28, 23, 56, 21, 132, DateTimeKind.Local).AddTicks(5757), null, "Company", null, "as6d4", null, "CSEroshd" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "id", "Avatar", "BirthDate", "CV", "Companyid", "CreateTime", "DeleteTime", "Discriminator", "Facultyid", "Firstname", "Lastname", "NationalIdNum", "Password", "PersonnelID", "Roleid", "Username", "gender" },
                values: new object[] { new Guid("c5fc2e06-f57f-49b9-8a16-362af4bf0e1b"), null, new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2022, 7, 28, 23, 56, 21, 132, DateTimeKind.Local).AddTicks(5808), null, "Professor", null, "Mojtaba", "Vahidi", 1535132133L, "51324342", 235133212L, null, "Dr.vahidi", 0 });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "id", "Avatar", "BirthDate", "CV", "Companyid", "CreateTime", "DeleteTime", "Discriminator", "Facultyid", "Firstname", "Lastname", "NationalIdNum", "Password", "Roleid", "StudentID", "Username", "gender" },
                values: new object[] { new Guid("ce58a55c-81a5-48c4-9c1a-a4c26f9f9b0c"), null, new DateTime(1999, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2022, 7, 28, 23, 56, 21, 132, DateTimeKind.Local).AddTicks(5509), null, "Student", null, "Reza", "Kalhori", 3242115120L, "324reza", null, 96243057L, "RezaKlhor", 0 });

            migrationBuilder.InsertData(
                table: "WorkFields",
                columns: new[] { "id", "CreateTime", "DeleteTime", "Name" },
                values: new object[,]
                {
                    { new Guid("0ca221ab-a251-4f22-abad-5c9244ae76c0"), new DateTime(2022, 7, 28, 23, 56, 21, 132, DateTimeKind.Local).AddTicks(5931), null, "Network" },
                    { new Guid("533c18b0-7409-43c1-aa5d-86ec21dfd47b"), new DateTime(2022, 7, 28, 23, 56, 21, 132, DateTimeKind.Local).AddTicks(5900), null, "Software" },
                    { new Guid("5f92b8c4-a65c-49d9-880f-c15d0324b3a4"), new DateTime(2022, 7, 28, 23, 56, 21, 132, DateTimeKind.Local).AddTicks(5879), null, "AI" },
                    { new Guid("659ee72b-10de-4c8c-9424-b2cc1f3a0816"), new DateTime(2022, 7, 28, 23, 56, 21, 132, DateTimeKind.Local).AddTicks(5926), null, "Hardware" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "EducationInstitutes",
                keyColumn: "id",
                keyValue: new Guid("71281c25-7197-471d-ba16-cc350091a55a"));

            migrationBuilder.DeleteData(
                table: "EducationInstitutes",
                keyColumn: "id",
                keyValue: new Guid("dec05e9e-7e29-4f04-9f38-37716f9a1a84"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "id",
                keyValue: new Guid("2a89570e-7c0c-42ef-b5e1-da5909c7e4fe"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "id",
                keyValue: new Guid("c5fc2e06-f57f-49b9-8a16-362af4bf0e1b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "id",
                keyValue: new Guid("ce58a55c-81a5-48c4-9c1a-a4c26f9f9b0c"));

            migrationBuilder.DeleteData(
                table: "WorkFields",
                keyColumn: "id",
                keyValue: new Guid("0ca221ab-a251-4f22-abad-5c9244ae76c0"));

            migrationBuilder.DeleteData(
                table: "WorkFields",
                keyColumn: "id",
                keyValue: new Guid("533c18b0-7409-43c1-aa5d-86ec21dfd47b"));

            migrationBuilder.DeleteData(
                table: "WorkFields",
                keyColumn: "id",
                keyValue: new Guid("5f92b8c4-a65c-49d9-880f-c15d0324b3a4"));

            migrationBuilder.DeleteData(
                table: "WorkFields",
                keyColumn: "id",
                keyValue: new Guid("659ee72b-10de-4c8c-9424-b2cc1f3a0816"));

            migrationBuilder.InsertData(
                table: "EducationInstitutes",
                columns: new[] { "id", "CreateTime", "DeleteTime", "Name" },
                values: new object[,]
                {
                    { new Guid("2ff3126b-0f23-418a-9247-90234066b197"), new DateTime(2022, 7, 28, 23, 52, 2, 956, DateTimeKind.Local).AddTicks(6644), null, "PNU" },
                    { new Guid("98325204-3865-4038-838c-35ff67d0ad51"), new DateTime(2022, 7, 28, 23, 52, 2, 956, DateTimeKind.Local).AddTicks(6560), null, "SBU" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "id", "Avatar", "CompanyIDnumber", "CompanyName", "Companyid", "CreateTime", "DeleteTime", "Discriminator", "Facultyid", "Password", "Roleid", "Username" },
                values: new object[] { new Guid("d5fa8e73-b372-4b4f-8a55-e0d635965ba4"), null, 2222222222L, "مرکز رشد دانشکده کامپیوتر", null, new DateTime(2022, 7, 28, 23, 52, 2, 956, DateTimeKind.Local).AddTicks(7392), null, "Company", null, "as6d4", null, "CSEroshd" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "id", "Avatar", "BirthDate", "CV", "Companyid", "CreateTime", "DeleteTime", "Discriminator", "Facultyid", "Firstname", "Lastname", "NationalIdNum", "Password", "PersonnelID", "Roleid", "Username", "gender" },
                values: new object[] { new Guid("93c798fe-053a-4f1a-af3c-42d9617a5ba4"), null, new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2022, 7, 28, 23, 52, 2, 956, DateTimeKind.Local).AddTicks(7501), null, "Professor", null, "Mojtaba", "Vahidi", 1535132133L, "51324342", 235133212L, null, "Dr.vahidi", 0 });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "id", "Avatar", "BirthDate", "CV", "Companyid", "CreateTime", "DeleteTime", "Discriminator", "Facultyid", "Firstname", "Lastname", "NationalIdNum", "Password", "Roleid", "StudentID", "Username", "gender" },
                values: new object[] { new Guid("1e3bc656-e89e-40ad-856b-e00b129dec4b"), null, new DateTime(1999, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2022, 7, 28, 23, 52, 2, 956, DateTimeKind.Local).AddTicks(6786), null, "Student", null, "Reza", "Kalhori", 3242115120L, "324reza", null, 96243057L, "RezaKlhor", 0 });

            migrationBuilder.InsertData(
                table: "WorkFields",
                columns: new[] { "id", "CreateTime", "DeleteTime", "Name" },
                values: new object[,]
                {
                    { new Guid("3b133e33-1343-4fee-8f20-fe6bf047d00b"), new DateTime(2022, 7, 28, 23, 52, 2, 956, DateTimeKind.Local).AddTicks(7614), null, "Software" },
                    { new Guid("6730cbe5-19e5-4e36-bbd8-c0983ad4de8c"), new DateTime(2022, 7, 28, 23, 52, 2, 956, DateTimeKind.Local).AddTicks(7624), null, "Network" },
                    { new Guid("6bfb351f-3127-4d21-9b5c-209d4cac58e9"), new DateTime(2022, 7, 28, 23, 52, 2, 956, DateTimeKind.Local).AddTicks(7619), null, "Hardware" },
                    { new Guid("908a1a43-c354-46cb-a598-3f2dea35b1cc"), new DateTime(2022, 7, 28, 23, 52, 2, 956, DateTimeKind.Local).AddTicks(7591), null, "AI" }
                });
        }
    }
}
