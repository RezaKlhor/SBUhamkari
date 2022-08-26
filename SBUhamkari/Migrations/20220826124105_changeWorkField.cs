using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SBUhamkari.Migrations
{
    public partial class changeWorkField : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PersonWorkFields_WorkFields_PersonID",
                table: "PersonWorkFields");

            migrationBuilder.DeleteData(
                table: "EducationInstitute",
                keyColumn: "id",
                keyValue: new Guid("291e50bc-7ef1-4db1-999f-c8eb8a728963"));

            migrationBuilder.DeleteData(
                table: "EducationInstitute",
                keyColumn: "id",
                keyValue: new Guid("889bdc0f-e8f1-4400-8bdf-6402030088fb"));

            migrationBuilder.DeleteData(
                table: "EducationInstitute",
                keyColumn: "id",
                keyValue: new Guid("938d7de5-634b-4d11-9907-9b39380b8cb3"));

            migrationBuilder.DeleteData(
                table: "EducationInstitute",
                keyColumn: "id",
                keyValue: new Guid("dc95d067-8f71-49dd-bc34-864e9a1f21d9"));

            migrationBuilder.DeleteData(
                table: "EducationInstitute",
                keyColumn: "id",
                keyValue: new Guid("f50c7f59-d866-4ed4-b0af-d969fe19408e"));

            migrationBuilder.DeleteData(
                table: "Faculties",
                keyColumn: "id",
                keyValue: new Guid("5455ef33-9fd0-4ef5-97df-85b5fd3796db"));

            migrationBuilder.DeleteData(
                table: "Faculties",
                keyColumn: "id",
                keyValue: new Guid("784692a4-b40f-4bbb-a69e-4e3a8ea4314d"));

            migrationBuilder.DeleteData(
                table: "Faculties",
                keyColumn: "id",
                keyValue: new Guid("d0f35fe2-bf46-4032-a19b-85052cd76a93"));

            migrationBuilder.DeleteData(
                table: "Faculties",
                keyColumn: "id",
                keyValue: new Guid("f48a5c70-7773-49f2-b51b-3e4399bf3f32"));

            migrationBuilder.DeleteData(
                table: "Faculties",
                keyColumn: "id",
                keyValue: new Guid("f6c975bd-e308-408c-9c58-71999343be52"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "id",
                keyValue: new Guid("1143f51e-e82f-41e8-9998-19157f37ca38"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "id",
                keyValue: new Guid("6802192b-d21e-4944-9809-1f3cd69d8cfa"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "id",
                keyValue: new Guid("ccc55750-2906-4f60-8f41-19de73cd66bc"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "id",
                keyValue: new Guid("e2366539-dcde-4200-a495-d402b3cf67c3"));

            migrationBuilder.DeleteData(
                table: "WorkFields",
                keyColumn: "id",
                keyValue: new Guid("2ddce829-2f42-4d59-8c40-278e1cd8d44a"));

            migrationBuilder.DeleteData(
                table: "WorkFields",
                keyColumn: "id",
                keyValue: new Guid("38a0b10e-584a-48c1-816c-e8032bf283fb"));

            migrationBuilder.DeleteData(
                table: "WorkFields",
                keyColumn: "id",
                keyValue: new Guid("436daa26-52fd-4400-9a13-05e29a4132eb"));

            migrationBuilder.DeleteData(
                table: "WorkFields",
                keyColumn: "id",
                keyValue: new Guid("47d7e208-db3d-4c0a-a956-269a21368fe9"));

            migrationBuilder.DeleteData(
                table: "WorkFields",
                keyColumn: "id",
                keyValue: new Guid("8a7c9a08-8d1d-42a8-bc4f-32bc386fe7dc"));

            migrationBuilder.DeleteData(
                table: "WorkFields",
                keyColumn: "id",
                keyValue: new Guid("a92ef48a-93cd-4bc9-ad56-24562457a35e"));

            migrationBuilder.DeleteData(
                table: "WorkFields",
                keyColumn: "id",
                keyValue: new Guid("ca77894f-53b2-4804-b6e8-7f9b77eb4f6d"));

            migrationBuilder.DeleteData(
                table: "WorkFields",
                keyColumn: "id",
                keyValue: new Guid("fc3146fa-836d-42ae-92f7-745bcbfb310d"));

            migrationBuilder.RenameColumn(
                name: "PersonID",
                table: "PersonWorkFields",
                newName: "WorkFieldid");

            migrationBuilder.RenameIndex(
                name: "IX_PersonWorkFields_PersonID",
                table: "PersonWorkFields",
                newName: "IX_PersonWorkFields_WorkFieldid");

            migrationBuilder.InsertData(
                table: "EducationInstitute",
                columns: new[] { "id", "CreateTime", "DeleteTime", "Name" },
                values: new object[,]
                {
                    { new Guid("2cee242c-70b8-42e2-a262-07301f97a2ea"), new DateTime(2022, 8, 26, 17, 11, 4, 394, DateTimeKind.Local).AddTicks(6730), null, "دانشگاه علم و صنعت" },
                    { new Guid("74a7ee8d-4055-4897-9264-080a18982e88"), new DateTime(2022, 8, 26, 17, 11, 4, 394, DateTimeKind.Local).AddTicks(6719), null, "دانشگاه تهران" },
                    { new Guid("a288ad31-1c8b-4a0e-985e-d53458b8fb81"), new DateTime(2022, 8, 26, 17, 11, 4, 394, DateTimeKind.Local).AddTicks(6636), null, "دانشگاه شهید بهشتی" },
                    { new Guid("b2551d46-fdbb-4de4-9b6b-36d4547dc66a"), new DateTime(2022, 8, 26, 17, 11, 4, 394, DateTimeKind.Local).AddTicks(6725), null, "دانشگاه صنعتی امیرکبیر" },
                    { new Guid("b4348168-24e4-4b46-9d1f-17c7fb9983ef"), new DateTime(2022, 8, 26, 17, 11, 4, 394, DateTimeKind.Local).AddTicks(6759), null, "دانشگاه صنعتی صنعتی شریف" }
                });

            migrationBuilder.InsertData(
                table: "Faculties",
                columns: new[] { "id", "CreateTime", "DeleteTime", "Name" },
                values: new object[,]
                {
                    { new Guid("0e429495-9b22-4090-a1fb-4080e451ef0b"), new DateTime(2022, 8, 26, 17, 11, 4, 394, DateTimeKind.Local).AddTicks(6945), null, "دانشکده رواشناسی و علوم تربیتی" },
                    { new Guid("75da6db9-2fa3-4a49-9809-4d3ae7f5f813"), new DateTime(2022, 8, 26, 17, 11, 4, 394, DateTimeKind.Local).AddTicks(6919), null, "دانشکده برق و کامپیوتر" },
                    { new Guid("7a568534-fba3-4b92-a526-740386637c25"), new DateTime(2022, 8, 26, 17, 11, 4, 394, DateTimeKind.Local).AddTicks(6956), null, "دانشکده علوم پایه" },
                    { new Guid("ba1b1d88-7697-494c-96f6-7ec77f3da95b"), new DateTime(2022, 8, 26, 17, 11, 4, 394, DateTimeKind.Local).AddTicks(6950), null, "دانشکده معماری" },
                    { new Guid("d6ecaffa-4bae-42b7-aec6-518f95e904f6"), new DateTime(2022, 8, 26, 17, 11, 4, 394, DateTimeKind.Local).AddTicks(6940), null, "دانشکده حقوق" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "id", "CreateTime", "DeleteTime", "Name" },
                values: new object[,]
                {
                    { new Guid("1fc39bc6-7fb8-4437-a33d-3f0d4ce3a0ef"), new DateTime(2022, 8, 26, 17, 11, 4, 394, DateTimeKind.Local).AddTicks(7036), null, "Admin" },
                    { new Guid("4c2f7994-bebf-43e1-ab43-b1be004feeeb"), new DateTime(2022, 8, 26, 17, 11, 4, 394, DateTimeKind.Local).AddTicks(7060), null, "Professor" },
                    { new Guid("640a0b77-4f0a-46dc-a7fb-1bdeb2ff33ba"), new DateTime(2022, 8, 26, 17, 11, 4, 394, DateTimeKind.Local).AddTicks(7049), null, "Student" },
                    { new Guid("afb28722-ff87-47ad-a1f9-49d82dd3f708"), new DateTime(2022, 8, 26, 17, 11, 4, 394, DateTimeKind.Local).AddTicks(7065), null, "Company" }
                });

            migrationBuilder.InsertData(
                table: "WorkFields",
                columns: new[] { "id", "CreateTime", "DeleteTime", "Name" },
                values: new object[,]
                {
                    { new Guid("26fd9400-34eb-48e4-a948-28f3ad3c4f5d"), new DateTime(2022, 8, 26, 17, 11, 4, 394, DateTimeKind.Local).AddTicks(7244), null, "شبکه‌های پیچیده" },
                    { new Guid("33ad2226-8583-427a-80ca-4855043ff0cf"), new DateTime(2022, 8, 26, 17, 11, 4, 394, DateTimeKind.Local).AddTicks(7249), null, "فناوری اطلاعات" },
                    { new Guid("6fb7fd26-e228-433b-bae4-32f83a016b1f"), new DateTime(2022, 8, 26, 17, 11, 4, 394, DateTimeKind.Local).AddTicks(7122), null, "هوش مصنوعی" },
                    { new Guid("78746c65-1b89-4a71-bd9d-f0dd9345dfe4"), new DateTime(2022, 8, 26, 17, 11, 4, 394, DateTimeKind.Local).AddTicks(7227), null, "شبکه" },
                    { new Guid("b73e3a43-a8ae-4741-b114-d72fd31fe160"), new DateTime(2022, 8, 26, 17, 11, 4, 394, DateTimeKind.Local).AddTicks(7234), null, "هوش مصنوعی" },
                    { new Guid("dc01227f-d243-4af0-a7df-ac9de70b435e"), new DateTime(2022, 8, 26, 17, 11, 4, 394, DateTimeKind.Local).AddTicks(7218), null, "سخت افزار" },
                    { new Guid("ec7c8941-d496-4ee2-b6e3-ca5d172c8bd8"), new DateTime(2022, 8, 26, 17, 11, 4, 394, DateTimeKind.Local).AddTicks(7222), null, "علوم داده" },
                    { new Guid("f030ec0e-6fbc-4d5c-a988-a5859a85c1f1"), new DateTime(2022, 8, 26, 17, 11, 4, 394, DateTimeKind.Local).AddTicks(7212), null, "نرم افزار" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_PersonWorkFields_WorkFields_WorkFieldid",
                table: "PersonWorkFields",
                column: "WorkFieldid",
                principalTable: "WorkFields",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PersonWorkFields_WorkFields_WorkFieldid",
                table: "PersonWorkFields");

            migrationBuilder.DeleteData(
                table: "EducationInstitute",
                keyColumn: "id",
                keyValue: new Guid("2cee242c-70b8-42e2-a262-07301f97a2ea"));

            migrationBuilder.DeleteData(
                table: "EducationInstitute",
                keyColumn: "id",
                keyValue: new Guid("74a7ee8d-4055-4897-9264-080a18982e88"));

            migrationBuilder.DeleteData(
                table: "EducationInstitute",
                keyColumn: "id",
                keyValue: new Guid("a288ad31-1c8b-4a0e-985e-d53458b8fb81"));

            migrationBuilder.DeleteData(
                table: "EducationInstitute",
                keyColumn: "id",
                keyValue: new Guid("b2551d46-fdbb-4de4-9b6b-36d4547dc66a"));

            migrationBuilder.DeleteData(
                table: "EducationInstitute",
                keyColumn: "id",
                keyValue: new Guid("b4348168-24e4-4b46-9d1f-17c7fb9983ef"));

            migrationBuilder.DeleteData(
                table: "Faculties",
                keyColumn: "id",
                keyValue: new Guid("0e429495-9b22-4090-a1fb-4080e451ef0b"));

            migrationBuilder.DeleteData(
                table: "Faculties",
                keyColumn: "id",
                keyValue: new Guid("75da6db9-2fa3-4a49-9809-4d3ae7f5f813"));

            migrationBuilder.DeleteData(
                table: "Faculties",
                keyColumn: "id",
                keyValue: new Guid("7a568534-fba3-4b92-a526-740386637c25"));

            migrationBuilder.DeleteData(
                table: "Faculties",
                keyColumn: "id",
                keyValue: new Guid("ba1b1d88-7697-494c-96f6-7ec77f3da95b"));

            migrationBuilder.DeleteData(
                table: "Faculties",
                keyColumn: "id",
                keyValue: new Guid("d6ecaffa-4bae-42b7-aec6-518f95e904f6"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "id",
                keyValue: new Guid("1fc39bc6-7fb8-4437-a33d-3f0d4ce3a0ef"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "id",
                keyValue: new Guid("4c2f7994-bebf-43e1-ab43-b1be004feeeb"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "id",
                keyValue: new Guid("640a0b77-4f0a-46dc-a7fb-1bdeb2ff33ba"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "id",
                keyValue: new Guid("afb28722-ff87-47ad-a1f9-49d82dd3f708"));

            migrationBuilder.DeleteData(
                table: "WorkFields",
                keyColumn: "id",
                keyValue: new Guid("26fd9400-34eb-48e4-a948-28f3ad3c4f5d"));

            migrationBuilder.DeleteData(
                table: "WorkFields",
                keyColumn: "id",
                keyValue: new Guid("33ad2226-8583-427a-80ca-4855043ff0cf"));

            migrationBuilder.DeleteData(
                table: "WorkFields",
                keyColumn: "id",
                keyValue: new Guid("6fb7fd26-e228-433b-bae4-32f83a016b1f"));

            migrationBuilder.DeleteData(
                table: "WorkFields",
                keyColumn: "id",
                keyValue: new Guid("78746c65-1b89-4a71-bd9d-f0dd9345dfe4"));

            migrationBuilder.DeleteData(
                table: "WorkFields",
                keyColumn: "id",
                keyValue: new Guid("b73e3a43-a8ae-4741-b114-d72fd31fe160"));

            migrationBuilder.DeleteData(
                table: "WorkFields",
                keyColumn: "id",
                keyValue: new Guid("dc01227f-d243-4af0-a7df-ac9de70b435e"));

            migrationBuilder.DeleteData(
                table: "WorkFields",
                keyColumn: "id",
                keyValue: new Guid("ec7c8941-d496-4ee2-b6e3-ca5d172c8bd8"));

            migrationBuilder.DeleteData(
                table: "WorkFields",
                keyColumn: "id",
                keyValue: new Guid("f030ec0e-6fbc-4d5c-a988-a5859a85c1f1"));

            migrationBuilder.RenameColumn(
                name: "WorkFieldid",
                table: "PersonWorkFields",
                newName: "PersonID");

            migrationBuilder.RenameIndex(
                name: "IX_PersonWorkFields_WorkFieldid",
                table: "PersonWorkFields",
                newName: "IX_PersonWorkFields_PersonID");

            migrationBuilder.InsertData(
                table: "EducationInstitute",
                columns: new[] { "id", "CreateTime", "DeleteTime", "Name" },
                values: new object[,]
                {
                    { new Guid("291e50bc-7ef1-4db1-999f-c8eb8a728963"), new DateTime(2022, 8, 22, 23, 22, 17, 253, DateTimeKind.Local).AddTicks(8761), null, "دانشگاه صنعتی امیرکبیر" },
                    { new Guid("889bdc0f-e8f1-4400-8bdf-6402030088fb"), new DateTime(2022, 8, 22, 23, 22, 17, 253, DateTimeKind.Local).AddTicks(8755), null, "دانشگاه تهران" },
                    { new Guid("938d7de5-634b-4d11-9907-9b39380b8cb3"), new DateTime(2022, 8, 22, 23, 22, 17, 253, DateTimeKind.Local).AddTicks(8682), null, "دانشگاه شهید بهشتی" },
                    { new Guid("dc95d067-8f71-49dd-bc34-864e9a1f21d9"), new DateTime(2022, 8, 22, 23, 22, 17, 253, DateTimeKind.Local).AddTicks(8769), null, "دانشگاه صنعتی صنعتی شریف" },
                    { new Guid("f50c7f59-d866-4ed4-b0af-d969fe19408e"), new DateTime(2022, 8, 22, 23, 22, 17, 253, DateTimeKind.Local).AddTicks(8765), null, "دانشگاه علم و صنعت" }
                });

            migrationBuilder.InsertData(
                table: "Faculties",
                columns: new[] { "id", "CreateTime", "DeleteTime", "Name" },
                values: new object[,]
                {
                    { new Guid("5455ef33-9fd0-4ef5-97df-85b5fd3796db"), new DateTime(2022, 8, 22, 23, 22, 17, 253, DateTimeKind.Local).AddTicks(8915), null, "دانشکده رواشناسی و علوم تربیتی" },
                    { new Guid("784692a4-b40f-4bbb-a69e-4e3a8ea4314d"), new DateTime(2022, 8, 22, 23, 22, 17, 253, DateTimeKind.Local).AddTicks(8910), null, "دانشکده حقوق" },
                    { new Guid("d0f35fe2-bf46-4032-a19b-85052cd76a93"), new DateTime(2022, 8, 22, 23, 22, 17, 253, DateTimeKind.Local).AddTicks(8929), null, "دانشکده علوم پایه" },
                    { new Guid("f48a5c70-7773-49f2-b51b-3e4399bf3f32"), new DateTime(2022, 8, 22, 23, 22, 17, 253, DateTimeKind.Local).AddTicks(8924), null, "دانشکده معماری" },
                    { new Guid("f6c975bd-e308-408c-9c58-71999343be52"), new DateTime(2022, 8, 22, 23, 22, 17, 253, DateTimeKind.Local).AddTicks(8890), null, "دانشکده برق و کامپیوتر" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "id", "CreateTime", "DeleteTime", "Name" },
                values: new object[,]
                {
                    { new Guid("1143f51e-e82f-41e8-9998-19157f37ca38"), new DateTime(2022, 8, 22, 23, 22, 17, 253, DateTimeKind.Local).AddTicks(9023), null, "Company" },
                    { new Guid("6802192b-d21e-4944-9809-1f3cd69d8cfa"), new DateTime(2022, 8, 22, 23, 22, 17, 253, DateTimeKind.Local).AddTicks(9015), null, "Student" },
                    { new Guid("ccc55750-2906-4f60-8f41-19de73cd66bc"), new DateTime(2022, 8, 22, 23, 22, 17, 253, DateTimeKind.Local).AddTicks(9019), null, "Professor" },
                    { new Guid("e2366539-dcde-4200-a495-d402b3cf67c3"), new DateTime(2022, 8, 22, 23, 22, 17, 253, DateTimeKind.Local).AddTicks(9004), null, "Admin" }
                });

            migrationBuilder.InsertData(
                table: "WorkFields",
                columns: new[] { "id", "CreateTime", "DeleteTime", "Name" },
                values: new object[,]
                {
                    { new Guid("2ddce829-2f42-4d59-8c40-278e1cd8d44a"), new DateTime(2022, 8, 22, 23, 22, 17, 253, DateTimeKind.Local).AddTicks(9073), null, "هوش مصنوعی" },
                    { new Guid("38a0b10e-584a-48c1-816c-e8032bf283fb"), new DateTime(2022, 8, 22, 23, 22, 17, 253, DateTimeKind.Local).AddTicks(9145), null, "فناوری اطلاعات" },
                    { new Guid("436daa26-52fd-4400-9a13-05e29a4132eb"), new DateTime(2022, 8, 22, 23, 22, 17, 253, DateTimeKind.Local).AddTicks(9126), null, "علوم داده" },
                    { new Guid("47d7e208-db3d-4c0a-a956-269a21368fe9"), new DateTime(2022, 8, 22, 23, 22, 17, 253, DateTimeKind.Local).AddTicks(9122), null, "سخت افزار" },
                    { new Guid("8a7c9a08-8d1d-42a8-bc4f-32bc386fe7dc"), new DateTime(2022, 8, 22, 23, 22, 17, 253, DateTimeKind.Local).AddTicks(9137), null, "هوش مصنوعی" },
                    { new Guid("a92ef48a-93cd-4bc9-ad56-24562457a35e"), new DateTime(2022, 8, 22, 23, 22, 17, 253, DateTimeKind.Local).AddTicks(9130), null, "شبکه" },
                    { new Guid("ca77894f-53b2-4804-b6e8-7f9b77eb4f6d"), new DateTime(2022, 8, 22, 23, 22, 17, 253, DateTimeKind.Local).AddTicks(9112), null, "نرم افزار" },
                    { new Guid("fc3146fa-836d-42ae-92f7-745bcbfb310d"), new DateTime(2022, 8, 22, 23, 22, 17, 253, DateTimeKind.Local).AddTicks(9141), null, "شبکه‌های پیچیده" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_PersonWorkFields_WorkFields_PersonID",
                table: "PersonWorkFields",
                column: "PersonID",
                principalTable: "WorkFields",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
