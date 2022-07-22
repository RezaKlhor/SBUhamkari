using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SBUhamkari.Migrations
{
    public partial class InitialCre2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "EducationInstitutes",
                keyColumn: "id",
                keyValue: new Guid("92f2070b-defe-4477-b381-5b52f686e408"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "id",
                keyValue: new Guid("65eefde7-1b06-44dd-b9eb-7c7dda9f6e09"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "id",
                keyValue: new Guid("37c5427f-bf18-4835-b80b-d68649fe0f06"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "id",
                keyValue: new Guid("101bbe1a-79b1-46ce-8877-5de93e666675"));

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "EducationInstitutes",
                columns: new[] { "id", "CreateTime", "DeleteTime", "Name" },
                values: new object[] { new Guid("92f2070b-defe-4477-b381-5b52f686e408"), new DateTime(2022, 7, 22, 13, 58, 8, 19, DateTimeKind.Local).AddTicks(1854), null, "SBU" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "id", "Avatar", "CompanyIDnumber", "CompanyName", "Companyid", "CreateTime", "DeleteTime", "Discriminator", "Facultyid", "Password", "Username" },
                values: new object[] { new Guid("65eefde7-1b06-44dd-b9eb-7c7dda9f6e09"), null, 2222222222L, "مرکز رشد دانشکده کامپیوتر", null, new DateTime(2022, 7, 22, 13, 58, 8, 19, DateTimeKind.Local).AddTicks(2282), null, "Company", null, "as6d4", "CSEroshd" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "id", "Avatar", "BirthDate", "CV", "Companyid", "CreateTime", "DeleteTime", "Discriminator", "Facultyid", "Firstname", "Lastname", "NationalIdNum", "Password", "PersonnelID", "Username", "gender" },
                values: new object[] { new Guid("37c5427f-bf18-4835-b80b-d68649fe0f06"), null, new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2022, 7, 22, 13, 58, 8, 19, DateTimeKind.Local).AddTicks(2328), null, "Professor", null, "Mojtaba", "Vahidi", 1535132133L, "51324342", 235133212L, "Dr.vahidi", 0 });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "id", "Avatar", "BirthDate", "CV", "Companyid", "CreateTime", "DeleteTime", "Discriminator", "Facultyid", "Firstname", "Lastname", "NationalIdNum", "Password", "StudentID", "Username", "gender" },
                values: new object[] { new Guid("101bbe1a-79b1-46ce-8877-5de93e666675"), null, new DateTime(1999, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2022, 7, 22, 13, 58, 8, 19, DateTimeKind.Local).AddTicks(2042), null, "Student", null, "Reza", "Kalhori", 3242115120L, "324reza", 96243057L, "RezaKlhor", 0 });
        }
    }
}
