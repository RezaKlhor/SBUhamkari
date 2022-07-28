using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SBUhamkari.Migrations
{
    public partial class init9 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<Guid>(
                name: "Roleid",
                table: "Users",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeleteTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.id);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Users_Roleid",
                table: "Users",
                column: "Roleid");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Roles_Roleid",
                table: "Users",
                column: "Roleid",
                principalTable: "Roles",
                principalColumn: "id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Roles_Roleid",
                table: "Users");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropIndex(
                name: "IX_Users_Roleid",
                table: "Users");

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

            migrationBuilder.DropColumn(
                name: "Roleid",
                table: "Users");

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
    }
}
