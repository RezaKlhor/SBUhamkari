using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SBUhamkari.Migrations
{
    public partial class InitialCre3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "EducationInstitutes",
                keyColumn: "id",
                keyValue: new Guid("b46c81d0-7f2a-4ceb-90df-5e0d1db9b80d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "id",
                keyValue: new Guid("6c1a730d-1889-4dcf-86ee-42eea79e6cb5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "id",
                keyValue: new Guid("5284988a-2aac-4109-b385-e6b3728fe7fb"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "id",
                keyValue: new Guid("3718b60d-8986-427e-b963-8b347abc8a90"));

            migrationBuilder.DeleteData(
                table: "WorkFields",
                keyColumn: "id",
                keyValue: new Guid("047cf9e8-c42f-48d4-aa9c-3ebea2823ef5"));

            migrationBuilder.DeleteData(
                table: "WorkFields",
                keyColumn: "id",
                keyValue: new Guid("39ab3ea0-98e7-4936-9347-93d38cbfc1c9"));

            migrationBuilder.DeleteData(
                table: "WorkFields",
                keyColumn: "id",
                keyValue: new Guid("5169b695-6f78-47bc-a958-2588500ed345"));

            migrationBuilder.DeleteData(
                table: "WorkFields",
                keyColumn: "id",
                keyValue: new Guid("7d3e9ca1-0df7-4584-9e56-0afbb0e4a66b"));

            migrationBuilder.CreateTable(
                name: "ProjectNews",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Tittle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Projectid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeleteTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectNews", x => x.id);
                    table.ForeignKey(
                        name: "FK_ProjectNews_Projects_Projectid",
                        column: x => x.Projectid,
                        principalTable: "Projects",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_ProjectNews_Projectid",
                table: "ProjectNews",
                column: "Projectid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProjectNews");

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

            migrationBuilder.InsertData(
                table: "EducationInstitutes",
                columns: new[] { "id", "CreateTime", "DeleteTime", "Name" },
                values: new object[] { new Guid("b46c81d0-7f2a-4ceb-90df-5e0d1db9b80d"), new DateTime(2022, 7, 22, 14, 8, 18, 4, DateTimeKind.Local).AddTicks(420), null, "SBU" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "id", "Avatar", "CompanyIDnumber", "CompanyName", "Companyid", "CreateTime", "DeleteTime", "Discriminator", "Facultyid", "Password", "Username" },
                values: new object[] { new Guid("6c1a730d-1889-4dcf-86ee-42eea79e6cb5"), null, 2222222222L, "مرکز رشد دانشکده کامپیوتر", null, new DateTime(2022, 7, 22, 14, 8, 18, 4, DateTimeKind.Local).AddTicks(735), null, "Company", null, "as6d4", "CSEroshd" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "id", "Avatar", "BirthDate", "CV", "Companyid", "CreateTime", "DeleteTime", "Discriminator", "Facultyid", "Firstname", "Lastname", "NationalIdNum", "Password", "PersonnelID", "Username", "gender" },
                values: new object[] { new Guid("5284988a-2aac-4109-b385-e6b3728fe7fb"), null, new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2022, 7, 22, 14, 8, 18, 4, DateTimeKind.Local).AddTicks(778), null, "Professor", null, "Mojtaba", "Vahidi", 1535132133L, "51324342", 235133212L, "Dr.vahidi", 0 });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "id", "Avatar", "BirthDate", "CV", "Companyid", "CreateTime", "DeleteTime", "Discriminator", "Facultyid", "Firstname", "Lastname", "NationalIdNum", "Password", "StudentID", "Username", "gender" },
                values: new object[] { new Guid("3718b60d-8986-427e-b963-8b347abc8a90"), null, new DateTime(1999, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2022, 7, 22, 14, 8, 18, 4, DateTimeKind.Local).AddTicks(573), null, "Student", null, "Reza", "Kalhori", 3242115120L, "324reza", 96243057L, "RezaKlhor", 0 });

            migrationBuilder.InsertData(
                table: "WorkFields",
                columns: new[] { "id", "CreateTime", "DeleteTime", "Name" },
                values: new object[,]
                {
                    { new Guid("047cf9e8-c42f-48d4-aa9c-3ebea2823ef5"), new DateTime(2022, 7, 22, 14, 8, 18, 4, DateTimeKind.Local).AddTicks(895), null, "Software" },
                    { new Guid("39ab3ea0-98e7-4936-9347-93d38cbfc1c9"), new DateTime(2022, 7, 22, 14, 8, 18, 4, DateTimeKind.Local).AddTicks(899), null, "Hardware" },
                    { new Guid("5169b695-6f78-47bc-a958-2588500ed345"), new DateTime(2022, 7, 22, 14, 8, 18, 4, DateTimeKind.Local).AddTicks(925), null, "Network" },
                    { new Guid("7d3e9ca1-0df7-4584-9e56-0afbb0e4a66b"), new DateTime(2022, 7, 22, 14, 8, 18, 4, DateTimeKind.Local).AddTicks(884), null, "AI" }
                });
        }
    }
}
