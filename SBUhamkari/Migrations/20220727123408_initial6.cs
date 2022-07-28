using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SBUhamkari.Migrations
{
    public partial class initial6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProjectUser");

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

            migrationBuilder.CreateTable(
                name: "ProjectParticapation",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Userid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Projectid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeleteTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectParticapation", x => x.id);
                    table.ForeignKey(
                        name: "FK_ProjectParticapation_Projects_Projectid",
                        column: x => x.Projectid,
                        principalTable: "Projects",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProjectParticapation_Users_Userid",
                        column: x => x.Userid,
                        principalTable: "Users",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_ProjectParticapation_Projectid",
                table: "ProjectParticapation",
                column: "Projectid");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectParticapation_Userid",
                table: "ProjectParticapation",
                column: "Userid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProjectParticapation");

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

            migrationBuilder.CreateTable(
                name: "ProjectUser",
                columns: table => new
                {
                    ProjectParticipantsid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    projectsid = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectUser", x => new { x.ProjectParticipantsid, x.projectsid });
                    table.ForeignKey(
                        name: "FK_ProjectUser_Projects_projectsid",
                        column: x => x.projectsid,
                        principalTable: "Projects",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProjectUser_Users_ProjectParticipantsid",
                        column: x => x.ProjectParticipantsid,
                        principalTable: "Users",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

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
                name: "IX_ProjectUser_projectsid",
                table: "ProjectUser",
                column: "projectsid");
        }
    }
}
