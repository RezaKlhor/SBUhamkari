using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SBUhamkari.Migrations
{
    public partial class init8 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "EducationInstitutes",
                keyColumn: "id",
                keyValue: new Guid("b3804a49-7d6b-4a44-bfdc-4a848eb0c438"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "id",
                keyValue: new Guid("980bfb4a-d858-4c31-8011-8d16303372e7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "id",
                keyValue: new Guid("11e6c0a1-a088-4175-bf88-3aaa563dccb9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "id",
                keyValue: new Guid("6ed481e5-1640-4584-b162-a38adb9057cc"));

            migrationBuilder.DeleteData(
                table: "WorkFields",
                keyColumn: "id",
                keyValue: new Guid("2d94a1ef-6372-47b6-b0e2-a5f92324e2e3"));

            migrationBuilder.DeleteData(
                table: "WorkFields",
                keyColumn: "id",
                keyValue: new Guid("57da3ff8-388b-419f-8d7f-10bcfe36d3d2"));

            migrationBuilder.DeleteData(
                table: "WorkFields",
                keyColumn: "id",
                keyValue: new Guid("5bcd4200-657c-434d-b6d2-75849ffac2ef"));

            migrationBuilder.DeleteData(
                table: "WorkFields",
                keyColumn: "id",
                keyValue: new Guid("79597811-8380-4e70-977f-9c21fad5e5c8"));

            migrationBuilder.InsertData(
                table: "EducationInstitutes",
                columns: new[] { "id", "CreateTime", "DeleteTime", "Name" },
                values: new object[,]
                {
                    { new Guid("0ede3ac2-3fee-46ee-8f9b-f4d8092caa63"), new DateTime(2022, 7, 28, 23, 49, 53, 471, DateTimeKind.Local).AddTicks(137), null, "PNU" },
                    { new Guid("918e60f3-b30a-4c00-ba2f-14cdb2441324"), new DateTime(2022, 7, 28, 23, 49, 53, 471, DateTimeKind.Local).AddTicks(72), null, "SBU" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "id", "Avatar", "CompanyIDnumber", "CompanyName", "Companyid", "CreateTime", "DeleteTime", "Discriminator", "Facultyid", "Password", "Username" },
                values: new object[] { new Guid("5e7d46a1-a203-4516-82a3-5b38da393449"), null, 2222222222L, "مرکز رشد دانشکده کامپیوتر", null, new DateTime(2022, 7, 28, 23, 49, 53, 471, DateTimeKind.Local).AddTicks(648), null, "Company", null, "as6d4", "CSEroshd" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "id", "Avatar", "BirthDate", "CV", "Companyid", "CreateTime", "DeleteTime", "Discriminator", "Facultyid", "Firstname", "Lastname", "NationalIdNum", "Password", "PersonnelID", "Username", "gender" },
                values: new object[] { new Guid("c81b768b-d720-4d0c-a0f4-0114e34ca9fe"), null, new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2022, 7, 28, 23, 49, 53, 471, DateTimeKind.Local).AddTicks(769), null, "Professor", null, "Mojtaba", "Vahidi", 1535132133L, "51324342", 235133212L, "Dr.vahidi", 0 });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "id", "Avatar", "BirthDate", "CV", "Companyid", "CreateTime", "DeleteTime", "Discriminator", "Facultyid", "Firstname", "Lastname", "NationalIdNum", "Password", "StudentID", "Username", "gender" },
                values: new object[] { new Guid("374c0658-4c0a-4c0b-8e36-62d2cfbda03b"), null, new DateTime(1999, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2022, 7, 28, 23, 49, 53, 471, DateTimeKind.Local).AddTicks(245), null, "Student", null, "Reza", "Kalhori", 3242115120L, "324reza", 96243057L, "RezaKlhor", 0 });

            migrationBuilder.InsertData(
                table: "WorkFields",
                columns: new[] { "id", "CreateTime", "DeleteTime", "Name" },
                values: new object[,]
                {
                    { new Guid("4a1836d0-9c56-4078-a86e-14a63c55c9c6"), new DateTime(2022, 7, 28, 23, 49, 53, 471, DateTimeKind.Local).AddTicks(871), null, "AI" },
                    { new Guid("59568836-1985-4cbd-a35a-487314d56335"), new DateTime(2022, 7, 28, 23, 49, 53, 471, DateTimeKind.Local).AddTicks(912), null, "Network" },
                    { new Guid("62265ea3-adff-416f-a4aa-81e9a3db4030"), new DateTime(2022, 7, 28, 23, 49, 53, 471, DateTimeKind.Local).AddTicks(894), null, "Software" },
                    { new Guid("ee7a0151-c88b-429d-a99f-ae07adc55688"), new DateTime(2022, 7, 28, 23, 49, 53, 471, DateTimeKind.Local).AddTicks(904), null, "Hardware" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "EducationInstitutes",
                keyColumn: "id",
                keyValue: new Guid("0ede3ac2-3fee-46ee-8f9b-f4d8092caa63"));

            migrationBuilder.DeleteData(
                table: "EducationInstitutes",
                keyColumn: "id",
                keyValue: new Guid("918e60f3-b30a-4c00-ba2f-14cdb2441324"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "id",
                keyValue: new Guid("5e7d46a1-a203-4516-82a3-5b38da393449"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "id",
                keyValue: new Guid("c81b768b-d720-4d0c-a0f4-0114e34ca9fe"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "id",
                keyValue: new Guid("374c0658-4c0a-4c0b-8e36-62d2cfbda03b"));

            migrationBuilder.DeleteData(
                table: "WorkFields",
                keyColumn: "id",
                keyValue: new Guid("4a1836d0-9c56-4078-a86e-14a63c55c9c6"));

            migrationBuilder.DeleteData(
                table: "WorkFields",
                keyColumn: "id",
                keyValue: new Guid("59568836-1985-4cbd-a35a-487314d56335"));

            migrationBuilder.DeleteData(
                table: "WorkFields",
                keyColumn: "id",
                keyValue: new Guid("62265ea3-adff-416f-a4aa-81e9a3db4030"));

            migrationBuilder.DeleteData(
                table: "WorkFields",
                keyColumn: "id",
                keyValue: new Guid("ee7a0151-c88b-429d-a99f-ae07adc55688"));

            migrationBuilder.InsertData(
                table: "EducationInstitutes",
                columns: new[] { "id", "CreateTime", "DeleteTime", "Name" },
                values: new object[] { new Guid("b3804a49-7d6b-4a44-bfdc-4a848eb0c438"), new DateTime(2022, 7, 28, 14, 13, 11, 728, DateTimeKind.Local).AddTicks(4973), null, "SBU" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "id", "Avatar", "CompanyIDnumber", "CompanyName", "Companyid", "CreateTime", "DeleteTime", "Discriminator", "Facultyid", "Password", "Username" },
                values: new object[] { new Guid("980bfb4a-d858-4c31-8011-8d16303372e7"), null, 2222222222L, "مرکز رشد دانشکده کامپیوتر", null, new DateTime(2022, 7, 28, 14, 13, 11, 728, DateTimeKind.Local).AddTicks(5467), null, "Company", null, "as6d4", "CSEroshd" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "id", "Avatar", "BirthDate", "CV", "Companyid", "CreateTime", "DeleteTime", "Discriminator", "Facultyid", "Firstname", "Lastname", "NationalIdNum", "Password", "PersonnelID", "Username", "gender" },
                values: new object[] { new Guid("11e6c0a1-a088-4175-bf88-3aaa563dccb9"), null, new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2022, 7, 28, 14, 13, 11, 728, DateTimeKind.Local).AddTicks(5518), null, "Professor", null, "Mojtaba", "Vahidi", 1535132133L, "51324342", 235133212L, "Dr.vahidi", 0 });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "id", "Avatar", "BirthDate", "CV", "Companyid", "CreateTime", "DeleteTime", "Discriminator", "Facultyid", "Firstname", "Lastname", "NationalIdNum", "Password", "StudentID", "Username", "gender" },
                values: new object[] { new Guid("6ed481e5-1640-4584-b162-a38adb9057cc"), null, new DateTime(1999, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2022, 7, 28, 14, 13, 11, 728, DateTimeKind.Local).AddTicks(5106), null, "Student", null, "Reza", "Kalhori", 3242115120L, "324reza", 96243057L, "RezaKlhor", 0 });

            migrationBuilder.InsertData(
                table: "WorkFields",
                columns: new[] { "id", "CreateTime", "DeleteTime", "Name" },
                values: new object[,]
                {
                    { new Guid("2d94a1ef-6372-47b6-b0e2-a5f92324e2e3"), new DateTime(2022, 7, 28, 14, 13, 11, 728, DateTimeKind.Local).AddTicks(5635), null, "Network" },
                    { new Guid("57da3ff8-388b-419f-8d7f-10bcfe36d3d2"), new DateTime(2022, 7, 28, 14, 13, 11, 728, DateTimeKind.Local).AddTicks(5567), null, "AI" },
                    { new Guid("5bcd4200-657c-434d-b6d2-75849ffac2ef"), new DateTime(2022, 7, 28, 14, 13, 11, 728, DateTimeKind.Local).AddTicks(5608), null, "Hardware" },
                    { new Guid("79597811-8380-4e70-977f-9c21fad5e5c8"), new DateTime(2022, 7, 28, 14, 13, 11, 728, DateTimeKind.Local).AddTicks(5593), null, "Software" }
                });
        }
    }
}
