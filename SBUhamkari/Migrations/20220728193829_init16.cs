using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SBUhamkari.Migrations
{
    public partial class init16 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Roles_Roleid",
                table: "Users");

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

            migrationBuilder.AlterColumn<Guid>(
                name: "Roleid",
                table: "Users",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

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

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Roles_Roleid",
                table: "Users",
                column: "Roleid",
                principalTable: "Roles",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Roles_Roleid",
                table: "Users");

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

            migrationBuilder.AlterColumn<Guid>(
                name: "Roleid",
                table: "Users",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Roles_Roleid",
                table: "Users",
                column: "Roleid",
                principalTable: "Roles",
                principalColumn: "id");
        }
    }
}
