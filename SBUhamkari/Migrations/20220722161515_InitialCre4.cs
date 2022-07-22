using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SBUhamkari.Migrations
{
    public partial class InitialCre4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "EducationInstitutes",
                keyColumn: "id",
                keyValue: new Guid("4fac6e46-1a55-4b11-9e18-1f70d0efc4cc"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "id",
                keyValue: new Guid("0893f3c5-ca13-469f-8c61-19ed43240773"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "id",
                keyValue: new Guid("a3bb3345-a29a-419d-be25-4a18aad70b55"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "id",
                keyValue: new Guid("e3d4dd4f-6892-4174-bdca-e14696d6d3ad"));

            migrationBuilder.DeleteData(
                table: "WorkFields",
                keyColumn: "id",
                keyValue: new Guid("133b18f4-e603-469f-8d69-74d3db5dfe59"));

            migrationBuilder.DeleteData(
                table: "WorkFields",
                keyColumn: "id",
                keyValue: new Guid("63f44b53-068f-4c68-bfbc-4c71bba31354"));

            migrationBuilder.DeleteData(
                table: "WorkFields",
                keyColumn: "id",
                keyValue: new Guid("dac549ce-9493-4636-bccb-9a4e92d2bfd2"));

            migrationBuilder.DeleteData(
                table: "WorkFields",
                keyColumn: "id",
                keyValue: new Guid("e611dc63-67b2-48e7-8f66-c9122c69a5c4"));

            migrationBuilder.AddColumn<Guid>(
                name: "Userid",
                table: "Users",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.InsertData(
                table: "EducationInstitutes",
                columns: new[] { "id", "CreateTime", "DeleteTime", "Name" },
                values: new object[] { new Guid("6f39496e-ae55-4b82-8494-004a09f5a9bb"), new DateTime(2022, 7, 22, 20, 45, 14, 291, DateTimeKind.Local).AddTicks(482), null, "SBU" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "id", "Avatar", "CompanyIDnumber", "CompanyName", "Companyid", "CreateTime", "DeleteTime", "Discriminator", "Facultyid", "Password", "Userid", "Username" },
                values: new object[] { new Guid("ff4fb0fc-4fbc-427d-bd4e-806aed6bef1c"), null, 2222222222L, "مرکز رشد دانشکده کامپیوتر", null, new DateTime(2022, 7, 22, 20, 45, 14, 291, DateTimeKind.Local).AddTicks(1260), null, "Company", null, "as6d4", null, "CSEroshd" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "id", "Avatar", "BirthDate", "CV", "Companyid", "CreateTime", "DeleteTime", "Discriminator", "Facultyid", "Firstname", "Lastname", "NationalIdNum", "Password", "PersonnelID", "Userid", "Username", "gender" },
                values: new object[] { new Guid("9460efe3-095b-41fc-9d89-a3afc0b102d3"), null, new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2022, 7, 22, 20, 45, 14, 291, DateTimeKind.Local).AddTicks(1329), null, "Professor", null, "Mojtaba", "Vahidi", 1535132133L, "51324342", 235133212L, null, "Dr.vahidi", 0 });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "id", "Avatar", "BirthDate", "CV", "Companyid", "CreateTime", "DeleteTime", "Discriminator", "Facultyid", "Firstname", "Lastname", "NationalIdNum", "Password", "StudentID", "Userid", "Username", "gender" },
                values: new object[] { new Guid("6b502220-391b-44ba-9812-e0d769690300"), null, new DateTime(1999, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2022, 7, 22, 20, 45, 14, 291, DateTimeKind.Local).AddTicks(626), null, "Student", null, "Reza", "Kalhori", 3242115120L, "324reza", 96243057L, null, "RezaKlhor", 0 });

            migrationBuilder.InsertData(
                table: "WorkFields",
                columns: new[] { "id", "CreateTime", "DeleteTime", "Name" },
                values: new object[,]
                {
                    { new Guid("376499c9-82d8-4ee0-9f1a-e11e96f1f7d8"), new DateTime(2022, 7, 22, 20, 45, 14, 291, DateTimeKind.Local).AddTicks(1454), null, "Hardware" },
                    { new Guid("61d287b8-4464-4927-82f8-e2d8fc7f1595"), new DateTime(2022, 7, 22, 20, 45, 14, 291, DateTimeKind.Local).AddTicks(1459), null, "Network" },
                    { new Guid("9fdd1329-b43e-44d7-b31e-7575ce6d9a7c"), new DateTime(2022, 7, 22, 20, 45, 14, 291, DateTimeKind.Local).AddTicks(1441), null, "Software" },
                    { new Guid("a902d1ff-1200-4a78-a0b8-5155d2651f90"), new DateTime(2022, 7, 22, 20, 45, 14, 291, DateTimeKind.Local).AddTicks(1392), null, "AI" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Users_Userid",
                table: "Users",
                column: "Userid");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Users_Userid",
                table: "Users",
                column: "Userid",
                principalTable: "Users",
                principalColumn: "id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Users_Userid",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_Userid",
                table: "Users");

            migrationBuilder.DeleteData(
                table: "EducationInstitutes",
                keyColumn: "id",
                keyValue: new Guid("6f39496e-ae55-4b82-8494-004a09f5a9bb"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "id",
                keyValue: new Guid("ff4fb0fc-4fbc-427d-bd4e-806aed6bef1c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "id",
                keyValue: new Guid("9460efe3-095b-41fc-9d89-a3afc0b102d3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "id",
                keyValue: new Guid("6b502220-391b-44ba-9812-e0d769690300"));

            migrationBuilder.DeleteData(
                table: "WorkFields",
                keyColumn: "id",
                keyValue: new Guid("376499c9-82d8-4ee0-9f1a-e11e96f1f7d8"));

            migrationBuilder.DeleteData(
                table: "WorkFields",
                keyColumn: "id",
                keyValue: new Guid("61d287b8-4464-4927-82f8-e2d8fc7f1595"));

            migrationBuilder.DeleteData(
                table: "WorkFields",
                keyColumn: "id",
                keyValue: new Guid("9fdd1329-b43e-44d7-b31e-7575ce6d9a7c"));

            migrationBuilder.DeleteData(
                table: "WorkFields",
                keyColumn: "id",
                keyValue: new Guid("a902d1ff-1200-4a78-a0b8-5155d2651f90"));

            migrationBuilder.DropColumn(
                name: "Userid",
                table: "Users");

            migrationBuilder.InsertData(
                table: "EducationInstitutes",
                columns: new[] { "id", "CreateTime", "DeleteTime", "Name" },
                values: new object[] { new Guid("4fac6e46-1a55-4b11-9e18-1f70d0efc4cc"), new DateTime(2022, 7, 22, 20, 42, 23, 880, DateTimeKind.Local).AddTicks(6167), null, "SBU" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "id", "Avatar", "CompanyIDnumber", "CompanyName", "Companyid", "CreateTime", "DeleteTime", "Discriminator", "Facultyid", "Password", "Username" },
                values: new object[] { new Guid("0893f3c5-ca13-469f-8c61-19ed43240773"), null, 2222222222L, "مرکز رشد دانشکده کامپیوتر", null, new DateTime(2022, 7, 22, 20, 42, 23, 880, DateTimeKind.Local).AddTicks(6766), null, "Company", null, "as6d4", "CSEroshd" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "id", "Avatar", "BirthDate", "CV", "Companyid", "CreateTime", "DeleteTime", "Discriminator", "Facultyid", "Firstname", "Lastname", "NationalIdNum", "Password", "PersonnelID", "Username", "gender" },
                values: new object[] { new Guid("a3bb3345-a29a-419d-be25-4a18aad70b55"), null, new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2022, 7, 22, 20, 42, 23, 880, DateTimeKind.Local).AddTicks(6869), null, "Professor", null, "Mojtaba", "Vahidi", 1535132133L, "51324342", 235133212L, "Dr.vahidi", 0 });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "id", "Avatar", "BirthDate", "CV", "Companyid", "CreateTime", "DeleteTime", "Discriminator", "Facultyid", "Firstname", "Lastname", "NationalIdNum", "Password", "StudentID", "Username", "gender" },
                values: new object[] { new Guid("e3d4dd4f-6892-4174-bdca-e14696d6d3ad"), null, new DateTime(1999, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2022, 7, 22, 20, 42, 23, 880, DateTimeKind.Local).AddTicks(6372), null, "Student", null, "Reza", "Kalhori", 3242115120L, "324reza", 96243057L, "RezaKlhor", 0 });

            migrationBuilder.InsertData(
                table: "WorkFields",
                columns: new[] { "id", "CreateTime", "DeleteTime", "Name" },
                values: new object[,]
                {
                    { new Guid("133b18f4-e603-469f-8d69-74d3db5dfe59"), new DateTime(2022, 7, 22, 20, 42, 23, 880, DateTimeKind.Local).AddTicks(7086), null, "AI" },
                    { new Guid("63f44b53-068f-4c68-bfbc-4c71bba31354"), new DateTime(2022, 7, 22, 20, 42, 23, 880, DateTimeKind.Local).AddTicks(7203), null, "Network" },
                    { new Guid("dac549ce-9493-4636-bccb-9a4e92d2bfd2"), new DateTime(2022, 7, 22, 20, 42, 23, 880, DateTimeKind.Local).AddTicks(7143), null, "Software" },
                    { new Guid("e611dc63-67b2-48e7-8f66-c9122c69a5c4"), new DateTime(2022, 7, 22, 20, 42, 23, 880, DateTimeKind.Local).AddTicks(7191), null, "Hardware" }
                });
        }
    }
}
