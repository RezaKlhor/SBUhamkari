using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SBUhamkari.Migrations
{
    public partial class addmanytomany : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PersonWorkField_Users_WorkfieldID",
                table: "PersonWorkField");

            migrationBuilder.DropForeignKey(
                name: "FK_PersonWorkField_WorkFields_PersonID",
                table: "PersonWorkField");

            migrationBuilder.DropForeignKey(
                name: "FK_ProjectParticapation_Projects_Projectid",
                table: "ProjectParticapation");

            migrationBuilder.DropForeignKey(
                name: "FK_ProjectParticapation_Users_Userid",
                table: "ProjectParticapation");

            migrationBuilder.DropForeignKey(
                name: "FK_ProjectWorkField_Projects_WorkfieldID",
                table: "ProjectWorkField");

            migrationBuilder.DropForeignKey(
                name: "FK_ProjectWorkField_WorkFields_ProjectID",
                table: "ProjectWorkField");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProjectWorkField",
                table: "ProjectWorkField");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProjectParticapation",
                table: "ProjectParticapation");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PersonWorkField",
                table: "PersonWorkField");

            migrationBuilder.DeleteData(
                table: "EducationInstitutes",
                keyColumn: "id",
                keyValue: new Guid("14318a28-cdc6-42ad-b79b-7d66354f7c20"));

            migrationBuilder.DeleteData(
                table: "EducationInstitutes",
                keyColumn: "id",
                keyValue: new Guid("1c045765-f599-4e9e-8675-c35850e7bd7e"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "id",
                keyValue: new Guid("299eb75d-d8c5-4b31-a92c-5bb3760f8b6b"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "id",
                keyValue: new Guid("a2f679aa-9e3c-42b6-919a-4b08e455d714"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "id",
                keyValue: new Guid("ca605958-d455-453a-8647-94bfdb604dca"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "id",
                keyValue: new Guid("df959137-65ce-4387-a057-2e60d986cbac"));

            migrationBuilder.RenameTable(
                name: "ProjectWorkField",
                newName: "ProjectWorkFields");

            migrationBuilder.RenameTable(
                name: "ProjectParticapation",
                newName: "ProjectParticapations");

            migrationBuilder.RenameTable(
                name: "PersonWorkField",
                newName: "PersonWorkFields");

            migrationBuilder.RenameIndex(
                name: "IX_ProjectWorkField_WorkfieldID",
                table: "ProjectWorkFields",
                newName: "IX_ProjectWorkFields_WorkfieldID");

            migrationBuilder.RenameIndex(
                name: "IX_ProjectWorkField_ProjectID",
                table: "ProjectWorkFields",
                newName: "IX_ProjectWorkFields_ProjectID");

            migrationBuilder.RenameIndex(
                name: "IX_ProjectParticapation_Userid",
                table: "ProjectParticapations",
                newName: "IX_ProjectParticapations_Userid");

            migrationBuilder.RenameIndex(
                name: "IX_ProjectParticapation_Projectid",
                table: "ProjectParticapations",
                newName: "IX_ProjectParticapations_Projectid");

            migrationBuilder.RenameIndex(
                name: "IX_PersonWorkField_WorkfieldID",
                table: "PersonWorkFields",
                newName: "IX_PersonWorkFields_WorkfieldID");

            migrationBuilder.RenameIndex(
                name: "IX_PersonWorkField_PersonID",
                table: "PersonWorkFields",
                newName: "IX_PersonWorkFields_PersonID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProjectWorkFields",
                table: "ProjectWorkFields",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProjectParticapations",
                table: "ProjectParticapations",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PersonWorkFields",
                table: "PersonWorkFields",
                column: "id");

            migrationBuilder.InsertData(
                table: "EducationInstitutes",
                columns: new[] { "id", "CreateTime", "DeleteTime", "Name" },
                values: new object[,]
                {
                    { new Guid("00d1dd62-3db1-4d8a-b2ba-d079f8ac6d72"), new DateTime(2022, 7, 29, 12, 11, 4, 226, DateTimeKind.Local).AddTicks(8565), null, "PNU" },
                    { new Guid("75756cf5-1c6e-4529-a007-0f85c99a5b13"), new DateTime(2022, 7, 29, 12, 11, 4, 226, DateTimeKind.Local).AddTicks(8510), null, "SBU" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "id", "CreateTime", "DeleteTime", "Name" },
                values: new object[,]
                {
                    { new Guid("06658cd5-d4ba-4555-a9b5-b82f78c80a04"), new DateTime(2022, 7, 29, 12, 11, 4, 226, DateTimeKind.Local).AddTicks(8642), null, "Company" },
                    { new Guid("1abb5c89-497a-4121-aeb6-db393e75bae3"), new DateTime(2022, 7, 29, 12, 11, 4, 226, DateTimeKind.Local).AddTicks(8621), null, "Admin" },
                    { new Guid("36143fd4-3d8e-47ee-a24e-793cca9c6e52"), new DateTime(2022, 7, 29, 12, 11, 4, 226, DateTimeKind.Local).AddTicks(8633), null, "Student" },
                    { new Guid("d605640d-74bf-443f-82a0-0c8c8771779e"), new DateTime(2022, 7, 29, 12, 11, 4, 226, DateTimeKind.Local).AddTicks(8638), null, "Professor" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_PersonWorkFields_Users_WorkfieldID",
                table: "PersonWorkFields",
                column: "WorkfieldID",
                principalTable: "Users",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PersonWorkFields_WorkFields_PersonID",
                table: "PersonWorkFields",
                column: "PersonID",
                principalTable: "WorkFields",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProjectParticapations_Projects_Projectid",
                table: "ProjectParticapations",
                column: "Projectid",
                principalTable: "Projects",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProjectParticapations_Users_Userid",
                table: "ProjectParticapations",
                column: "Userid",
                principalTable: "Users",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProjectWorkFields_Projects_WorkfieldID",
                table: "ProjectWorkFields",
                column: "WorkfieldID",
                principalTable: "Projects",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProjectWorkFields_WorkFields_ProjectID",
                table: "ProjectWorkFields",
                column: "ProjectID",
                principalTable: "WorkFields",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PersonWorkFields_Users_WorkfieldID",
                table: "PersonWorkFields");

            migrationBuilder.DropForeignKey(
                name: "FK_PersonWorkFields_WorkFields_PersonID",
                table: "PersonWorkFields");

            migrationBuilder.DropForeignKey(
                name: "FK_ProjectParticapations_Projects_Projectid",
                table: "ProjectParticapations");

            migrationBuilder.DropForeignKey(
                name: "FK_ProjectParticapations_Users_Userid",
                table: "ProjectParticapations");

            migrationBuilder.DropForeignKey(
                name: "FK_ProjectWorkFields_Projects_WorkfieldID",
                table: "ProjectWorkFields");

            migrationBuilder.DropForeignKey(
                name: "FK_ProjectWorkFields_WorkFields_ProjectID",
                table: "ProjectWorkFields");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProjectWorkFields",
                table: "ProjectWorkFields");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProjectParticapations",
                table: "ProjectParticapations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PersonWorkFields",
                table: "PersonWorkFields");

            migrationBuilder.DeleteData(
                table: "EducationInstitutes",
                keyColumn: "id",
                keyValue: new Guid("00d1dd62-3db1-4d8a-b2ba-d079f8ac6d72"));

            migrationBuilder.DeleteData(
                table: "EducationInstitutes",
                keyColumn: "id",
                keyValue: new Guid("75756cf5-1c6e-4529-a007-0f85c99a5b13"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "id",
                keyValue: new Guid("06658cd5-d4ba-4555-a9b5-b82f78c80a04"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "id",
                keyValue: new Guid("1abb5c89-497a-4121-aeb6-db393e75bae3"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "id",
                keyValue: new Guid("36143fd4-3d8e-47ee-a24e-793cca9c6e52"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "id",
                keyValue: new Guid("d605640d-74bf-443f-82a0-0c8c8771779e"));

            migrationBuilder.RenameTable(
                name: "ProjectWorkFields",
                newName: "ProjectWorkField");

            migrationBuilder.RenameTable(
                name: "ProjectParticapations",
                newName: "ProjectParticapation");

            migrationBuilder.RenameTable(
                name: "PersonWorkFields",
                newName: "PersonWorkField");

            migrationBuilder.RenameIndex(
                name: "IX_ProjectWorkFields_WorkfieldID",
                table: "ProjectWorkField",
                newName: "IX_ProjectWorkField_WorkfieldID");

            migrationBuilder.RenameIndex(
                name: "IX_ProjectWorkFields_ProjectID",
                table: "ProjectWorkField",
                newName: "IX_ProjectWorkField_ProjectID");

            migrationBuilder.RenameIndex(
                name: "IX_ProjectParticapations_Userid",
                table: "ProjectParticapation",
                newName: "IX_ProjectParticapation_Userid");

            migrationBuilder.RenameIndex(
                name: "IX_ProjectParticapations_Projectid",
                table: "ProjectParticapation",
                newName: "IX_ProjectParticapation_Projectid");

            migrationBuilder.RenameIndex(
                name: "IX_PersonWorkFields_WorkfieldID",
                table: "PersonWorkField",
                newName: "IX_PersonWorkField_WorkfieldID");

            migrationBuilder.RenameIndex(
                name: "IX_PersonWorkFields_PersonID",
                table: "PersonWorkField",
                newName: "IX_PersonWorkField_PersonID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProjectWorkField",
                table: "ProjectWorkField",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProjectParticapation",
                table: "ProjectParticapation",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PersonWorkField",
                table: "PersonWorkField",
                column: "id");

            migrationBuilder.InsertData(
                table: "EducationInstitutes",
                columns: new[] { "id", "CreateTime", "DeleteTime", "Name" },
                values: new object[,]
                {
                    { new Guid("14318a28-cdc6-42ad-b79b-7d66354f7c20"), new DateTime(2022, 7, 29, 2, 48, 40, 166, DateTimeKind.Local).AddTicks(221), null, "PNU" },
                    { new Guid("1c045765-f599-4e9e-8675-c35850e7bd7e"), new DateTime(2022, 7, 29, 2, 48, 40, 166, DateTimeKind.Local).AddTicks(163), null, "SBU" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "id", "CreateTime", "DeleteTime", "Name" },
                values: new object[,]
                {
                    { new Guid("299eb75d-d8c5-4b31-a92c-5bb3760f8b6b"), new DateTime(2022, 7, 29, 2, 48, 40, 166, DateTimeKind.Local).AddTicks(312), null, "Student" },
                    { new Guid("a2f679aa-9e3c-42b6-919a-4b08e455d714"), new DateTime(2022, 7, 29, 2, 48, 40, 166, DateTimeKind.Local).AddTicks(317), null, "Professor" },
                    { new Guid("ca605958-d455-453a-8647-94bfdb604dca"), new DateTime(2022, 7, 29, 2, 48, 40, 166, DateTimeKind.Local).AddTicks(278), null, "Admin" },
                    { new Guid("df959137-65ce-4387-a057-2e60d986cbac"), new DateTime(2022, 7, 29, 2, 48, 40, 166, DateTimeKind.Local).AddTicks(323), null, "Company" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_PersonWorkField_Users_WorkfieldID",
                table: "PersonWorkField",
                column: "WorkfieldID",
                principalTable: "Users",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PersonWorkField_WorkFields_PersonID",
                table: "PersonWorkField",
                column: "PersonID",
                principalTable: "WorkFields",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProjectParticapation_Projects_Projectid",
                table: "ProjectParticapation",
                column: "Projectid",
                principalTable: "Projects",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProjectParticapation_Users_Userid",
                table: "ProjectParticapation",
                column: "Userid",
                principalTable: "Users",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProjectWorkField_Projects_WorkfieldID",
                table: "ProjectWorkField",
                column: "WorkfieldID",
                principalTable: "Projects",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProjectWorkField_WorkFields_ProjectID",
                table: "ProjectWorkField",
                column: "ProjectID",
                principalTable: "WorkFields",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
