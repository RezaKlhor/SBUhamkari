using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SBUhamkari.Migrations
{
    public partial class initialcre7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ProjectWorkField",
                table: "ProjectWorkField");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PersonWorkField",
                table: "PersonWorkField");

            migrationBuilder.DeleteData(
                table: "EducationInstitutes",
                keyColumn: "id",
                keyValue: new Guid("b3c1a0d0-87e8-4519-84e9-ef286cb60136"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "id",
                keyValue: new Guid("ea9083c3-2abb-43b9-b29f-83de7b75be86"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "id",
                keyValue: new Guid("12734467-a1ee-440c-a4e9-811d75d2d20c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "id",
                keyValue: new Guid("bcbc0008-48aa-414c-a529-e90aefff2e49"));

            migrationBuilder.DeleteData(
                table: "WorkFields",
                keyColumn: "id",
                keyValue: new Guid("224e1cbf-41aa-484a-a3a2-ec7d5266214e"));

            migrationBuilder.DeleteData(
                table: "WorkFields",
                keyColumn: "id",
                keyValue: new Guid("805d7d2a-cbad-4a28-b94c-a4bbb03a0f15"));

            migrationBuilder.DeleteData(
                table: "WorkFields",
                keyColumn: "id",
                keyValue: new Guid("a902c126-8ad2-454a-934d-58b6e789b53d"));

            migrationBuilder.DeleteData(
                table: "WorkFields",
                keyColumn: "id",
                keyValue: new Guid("ae0117ee-1b3b-40fc-a7cc-6c7d95782ead"));

            migrationBuilder.AddColumn<Guid>(
                name: "id",
                table: "ProjectWorkField",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateTime",
                table: "ProjectWorkField",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DeleteTime",
                table: "ProjectWorkField",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "id",
                table: "PersonWorkField",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateTime",
                table: "PersonWorkField",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DeleteTime",
                table: "PersonWorkField",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProjectWorkField",
                table: "ProjectWorkField",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PersonWorkField",
                table: "PersonWorkField",
                column: "id");

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

            migrationBuilder.CreateIndex(
                name: "IX_ProjectWorkField_ProjectID",
                table: "ProjectWorkField",
                column: "ProjectID");

            migrationBuilder.CreateIndex(
                name: "IX_PersonWorkField_PersonID",
                table: "PersonWorkField",
                column: "PersonID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ProjectWorkField",
                table: "ProjectWorkField");

            migrationBuilder.DropIndex(
                name: "IX_ProjectWorkField_ProjectID",
                table: "ProjectWorkField");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PersonWorkField",
                table: "PersonWorkField");

            migrationBuilder.DropIndex(
                name: "IX_PersonWorkField_PersonID",
                table: "PersonWorkField");

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

            migrationBuilder.DropColumn(
                name: "id",
                table: "ProjectWorkField");

            migrationBuilder.DropColumn(
                name: "CreateTime",
                table: "ProjectWorkField");

            migrationBuilder.DropColumn(
                name: "DeleteTime",
                table: "ProjectWorkField");

            migrationBuilder.DropColumn(
                name: "id",
                table: "PersonWorkField");

            migrationBuilder.DropColumn(
                name: "CreateTime",
                table: "PersonWorkField");

            migrationBuilder.DropColumn(
                name: "DeleteTime",
                table: "PersonWorkField");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProjectWorkField",
                table: "ProjectWorkField",
                columns: new[] { "ProjectID", "WorkfieldID" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_PersonWorkField",
                table: "PersonWorkField",
                columns: new[] { "PersonID", "WorkfieldID" });

            migrationBuilder.InsertData(
                table: "EducationInstitutes",
                columns: new[] { "id", "CreateTime", "DeleteTime", "Name" },
                values: new object[] { new Guid("b3c1a0d0-87e8-4519-84e9-ef286cb60136"), new DateTime(2022, 7, 27, 17, 4, 6, 942, DateTimeKind.Local).AddTicks(8116), null, "SBU" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "id", "Avatar", "CompanyIDnumber", "CompanyName", "Companyid", "CreateTime", "DeleteTime", "Discriminator", "Facultyid", "Password", "Username" },
                values: new object[] { new Guid("ea9083c3-2abb-43b9-b29f-83de7b75be86"), null, 2222222222L, "مرکز رشد دانشکده کامپیوتر", null, new DateTime(2022, 7, 27, 17, 4, 6, 942, DateTimeKind.Local).AddTicks(8448), null, "Company", null, "as6d4", "CSEroshd" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "id", "Avatar", "BirthDate", "CV", "Companyid", "CreateTime", "DeleteTime", "Discriminator", "Facultyid", "Firstname", "Lastname", "NationalIdNum", "Password", "PersonnelID", "Username", "gender" },
                values: new object[] { new Guid("12734467-a1ee-440c-a4e9-811d75d2d20c"), null, new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2022, 7, 27, 17, 4, 6, 942, DateTimeKind.Local).AddTicks(8568), null, "Professor", null, "Mojtaba", "Vahidi", 1535132133L, "51324342", 235133212L, "Dr.vahidi", 0 });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "id", "Avatar", "BirthDate", "CV", "Companyid", "CreateTime", "DeleteTime", "Discriminator", "Facultyid", "Firstname", "Lastname", "NationalIdNum", "Password", "StudentID", "Username", "gender" },
                values: new object[] { new Guid("bcbc0008-48aa-414c-a529-e90aefff2e49"), null, new DateTime(1999, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2022, 7, 27, 17, 4, 6, 942, DateTimeKind.Local).AddTicks(8250), null, "Student", null, "Reza", "Kalhori", 3242115120L, "324reza", 96243057L, "RezaKlhor", 0 });

            migrationBuilder.InsertData(
                table: "WorkFields",
                columns: new[] { "id", "CreateTime", "DeleteTime", "Name" },
                values: new object[,]
                {
                    { new Guid("224e1cbf-41aa-484a-a3a2-ec7d5266214e"), new DateTime(2022, 7, 27, 17, 4, 6, 942, DateTimeKind.Local).AddTicks(8624), null, "AI" },
                    { new Guid("805d7d2a-cbad-4a28-b94c-a4bbb03a0f15"), new DateTime(2022, 7, 27, 17, 4, 6, 942, DateTimeKind.Local).AddTicks(8638), null, "Hardware" },
                    { new Guid("a902c126-8ad2-454a-934d-58b6e789b53d"), new DateTime(2022, 7, 27, 17, 4, 6, 942, DateTimeKind.Local).AddTicks(8642), null, "Network" },
                    { new Guid("ae0117ee-1b3b-40fc-a7cc-6c7d95782ead"), new DateTime(2022, 7, 27, 17, 4, 6, 942, DateTimeKind.Local).AddTicks(8634), null, "Software" }
                });
        }
    }
}
