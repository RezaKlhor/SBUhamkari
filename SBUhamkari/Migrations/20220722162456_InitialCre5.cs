using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SBUhamkari.Migrations
{
    public partial class InitialCre5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.RenameColumn(
                name: "UserID",
                table: "Followings",
                newName: "Followerid");

            migrationBuilder.InsertData(
                table: "EducationInstitutes",
                columns: new[] { "id", "CreateTime", "DeleteTime", "Name" },
                values: new object[] { new Guid("59a29edd-36be-4958-aa79-2a97560ece2c"), new DateTime(2022, 7, 22, 20, 54, 55, 282, DateTimeKind.Local).AddTicks(592), null, "SBU" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "id", "Avatar", "CompanyIDnumber", "CompanyName", "Companyid", "CreateTime", "DeleteTime", "Discriminator", "Facultyid", "Password", "Username" },
                values: new object[] { new Guid("cb7e5905-a9ae-4e58-a2ae-d3d35345e0c1"), null, 2222222222L, "مرکز رشد دانشکده کامپیوتر", null, new DateTime(2022, 7, 22, 20, 54, 55, 282, DateTimeKind.Local).AddTicks(977), null, "Company", null, "as6d4", "CSEroshd" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "id", "Avatar", "BirthDate", "CV", "Companyid", "CreateTime", "DeleteTime", "Discriminator", "Facultyid", "Firstname", "Lastname", "NationalIdNum", "Password", "PersonnelID", "Username", "gender" },
                values: new object[] { new Guid("1b585e04-9c3f-4431-8266-ece7eef44495"), null, new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2022, 7, 22, 20, 54, 55, 282, DateTimeKind.Local).AddTicks(1049), null, "Professor", null, "Mojtaba", "Vahidi", 1535132133L, "51324342", 235133212L, "Dr.vahidi", 0 });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "id", "Avatar", "BirthDate", "CV", "Companyid", "CreateTime", "DeleteTime", "Discriminator", "Facultyid", "Firstname", "Lastname", "NationalIdNum", "Password", "StudentID", "Username", "gender" },
                values: new object[] { new Guid("4a7129cb-8fdf-4ae3-b45e-84cb1c31c203"), null, new DateTime(1999, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2022, 7, 22, 20, 54, 55, 282, DateTimeKind.Local).AddTicks(707), null, "Student", null, "Reza", "Kalhori", 3242115120L, "324reza", 96243057L, "RezaKlhor", 0 });

            migrationBuilder.InsertData(
                table: "WorkFields",
                columns: new[] { "id", "CreateTime", "DeleteTime", "Name" },
                values: new object[,]
                {
                    { new Guid("38825dad-10b4-405c-97c0-52258becc1ce"), new DateTime(2022, 7, 22, 20, 54, 55, 282, DateTimeKind.Local).AddTicks(1119), null, "Network" },
                    { new Guid("40c8866b-db3a-4f02-97a6-bd91ccdd5d54"), new DateTime(2022, 7, 22, 20, 54, 55, 282, DateTimeKind.Local).AddTicks(1100), null, "AI" },
                    { new Guid("a057ea1b-0680-473c-9ec8-6f1ed913e272"), new DateTime(2022, 7, 22, 20, 54, 55, 282, DateTimeKind.Local).AddTicks(1110), null, "Software" },
                    { new Guid("f90d0ab5-f702-48d8-9773-e28782ea22b2"), new DateTime(2022, 7, 22, 20, 54, 55, 282, DateTimeKind.Local).AddTicks(1115), null, "Hardware" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Followings_Followerid",
                table: "Followings",
                column: "Followerid");

            migrationBuilder.AddForeignKey(
                name: "FK_Followings_Users_Followerid",
                table: "Followings",
                column: "Followerid",
                principalTable: "Users",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Followings_Users_Followerid",
                table: "Followings");

            migrationBuilder.DropIndex(
                name: "IX_Followings_Followerid",
                table: "Followings");

            migrationBuilder.DeleteData(
                table: "EducationInstitutes",
                keyColumn: "id",
                keyValue: new Guid("59a29edd-36be-4958-aa79-2a97560ece2c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "id",
                keyValue: new Guid("cb7e5905-a9ae-4e58-a2ae-d3d35345e0c1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "id",
                keyValue: new Guid("1b585e04-9c3f-4431-8266-ece7eef44495"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "id",
                keyValue: new Guid("4a7129cb-8fdf-4ae3-b45e-84cb1c31c203"));

            migrationBuilder.DeleteData(
                table: "WorkFields",
                keyColumn: "id",
                keyValue: new Guid("38825dad-10b4-405c-97c0-52258becc1ce"));

            migrationBuilder.DeleteData(
                table: "WorkFields",
                keyColumn: "id",
                keyValue: new Guid("40c8866b-db3a-4f02-97a6-bd91ccdd5d54"));

            migrationBuilder.DeleteData(
                table: "WorkFields",
                keyColumn: "id",
                keyValue: new Guid("a057ea1b-0680-473c-9ec8-6f1ed913e272"));

            migrationBuilder.DeleteData(
                table: "WorkFields",
                keyColumn: "id",
                keyValue: new Guid("f90d0ab5-f702-48d8-9773-e28782ea22b2"));

            migrationBuilder.RenameColumn(
                name: "Followerid",
                table: "Followings",
                newName: "UserID");

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
    }
}
