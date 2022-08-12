using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SBUhamkari.Migrations
{
    public partial class init6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "EducationInstitutes",
                keyColumn: "id",
                keyValue: new Guid("58a24725-7ff1-4900-9732-290007d37681"));

            migrationBuilder.DeleteData(
                table: "EducationInstitutes",
                keyColumn: "id",
                keyValue: new Guid("79d364e0-ca71-4935-8b08-0bc132823391"));

            migrationBuilder.DeleteData(
                table: "EducationInstitutes",
                keyColumn: "id",
                keyValue: new Guid("ce1e06d4-130a-4405-8a72-83f0bed826a0"));

            migrationBuilder.DeleteData(
                table: "EducationInstitutes",
                keyColumn: "id",
                keyValue: new Guid("e18d7c03-bfdb-4559-99ea-856c46200f3a"));

            migrationBuilder.DeleteData(
                table: "EducationInstitutes",
                keyColumn: "id",
                keyValue: new Guid("f7dee8fc-8dab-4f24-a453-cb7e19628dd6"));

            migrationBuilder.DeleteData(
                table: "Faculties",
                keyColumn: "id",
                keyValue: new Guid("03ce8471-99ec-41d6-9949-b6f75e526f24"));

            migrationBuilder.DeleteData(
                table: "Faculties",
                keyColumn: "id",
                keyValue: new Guid("2df38086-5885-4d08-92a8-f394594213b5"));

            migrationBuilder.DeleteData(
                table: "Faculties",
                keyColumn: "id",
                keyValue: new Guid("504bc4dc-c746-4436-a0c9-1d229a8dc3c4"));

            migrationBuilder.DeleteData(
                table: "Faculties",
                keyColumn: "id",
                keyValue: new Guid("5850ef36-d6f6-4f04-9083-5a5e779a7a92"));

            migrationBuilder.DeleteData(
                table: "Faculties",
                keyColumn: "id",
                keyValue: new Guid("aa8abc60-0da8-4b08-8cc9-1c32ac43f436"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "id",
                keyValue: new Guid("18180193-b337-499a-b868-55867f0a3dee"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "id",
                keyValue: new Guid("1925d612-dc71-49e9-939a-8592fdd63879"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "id",
                keyValue: new Guid("63d5b0ee-8e4f-448e-91df-1152113cf3a2"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "id",
                keyValue: new Guid("9f41fe0c-6609-4394-83c5-e5d77117c964"));

            migrationBuilder.DeleteData(
                table: "WorkFields",
                keyColumn: "id",
                keyValue: new Guid("06af5ebd-9521-4399-9d63-2d3ea180a682"));

            migrationBuilder.DeleteData(
                table: "WorkFields",
                keyColumn: "id",
                keyValue: new Guid("17150b37-e99e-4dab-8d0e-db449191445c"));

            migrationBuilder.DeleteData(
                table: "WorkFields",
                keyColumn: "id",
                keyValue: new Guid("20e23a77-6be6-412a-9d0f-efabd5e155c0"));

            migrationBuilder.DeleteData(
                table: "WorkFields",
                keyColumn: "id",
                keyValue: new Guid("2ba71767-697c-4943-8527-771afa20f595"));

            migrationBuilder.DeleteData(
                table: "WorkFields",
                keyColumn: "id",
                keyValue: new Guid("2eeed719-8b45-4330-a4a2-447f9632217d"));

            migrationBuilder.DeleteData(
                table: "WorkFields",
                keyColumn: "id",
                keyValue: new Guid("a94985aa-feee-4834-8ed8-5cd93cc43a87"));

            migrationBuilder.DeleteData(
                table: "WorkFields",
                keyColumn: "id",
                keyValue: new Guid("cf6f73b0-bf67-40a7-9004-d294e47bd72b"));

            migrationBuilder.DeleteData(
                table: "WorkFields",
                keyColumn: "id",
                keyValue: new Guid("d44cd5db-dbd7-42ae-b315-41d38143f780"));

            migrationBuilder.InsertData(
                table: "EducationInstitutes",
                columns: new[] { "id", "CreateTime", "DeleteTime", "Name" },
                values: new object[,]
                {
                    { new Guid("516a4f42-4236-4786-9987-47f937addad5"), new DateTime(2022, 8, 12, 16, 0, 33, 341, DateTimeKind.Local).AddTicks(6184), null, "دانشگاه تهران" },
                    { new Guid("8ed765ad-19a0-46f9-85a8-77b5e4de9ace"), new DateTime(2022, 8, 12, 16, 0, 33, 341, DateTimeKind.Local).AddTicks(6198), null, "دانشگاه صنعتی صنعتی شریف" },
                    { new Guid("95d1da22-6f35-4ab7-857a-c8d7691a0788"), new DateTime(2022, 8, 12, 16, 0, 33, 341, DateTimeKind.Local).AddTicks(6107), null, "دانشگاه شهید بهشتی" },
                    { new Guid("d325866c-ec73-439e-8d66-c1f49ea6f47a"), new DateTime(2022, 8, 12, 16, 0, 33, 341, DateTimeKind.Local).AddTicks(6194), null, "دانشگاه علم و صنعت" },
                    { new Guid("e69aa315-8c19-4dc0-add1-8cf3700a2f96"), new DateTime(2022, 8, 12, 16, 0, 33, 341, DateTimeKind.Local).AddTicks(6189), null, "دانشگاه صنعتی امیرکبیر" }
                });

            migrationBuilder.InsertData(
                table: "Faculties",
                columns: new[] { "id", "CreateTime", "DeleteTime", "Name" },
                values: new object[,]
                {
                    { new Guid("2f312dc7-ebeb-44d5-9945-676216e1e2ba"), new DateTime(2022, 8, 12, 16, 0, 33, 341, DateTimeKind.Local).AddTicks(6340), null, "دانشکده رواشناسی و علوم تربیتی" },
                    { new Guid("43d4753c-9d86-4902-a793-4ca73e097f8e"), new DateTime(2022, 8, 12, 16, 0, 33, 341, DateTimeKind.Local).AddTicks(6348), null, "دانشکده علوم پایه" },
                    { new Guid("53cdfb5c-30ee-4724-9ff4-1757fddb1a41"), new DateTime(2022, 8, 12, 16, 0, 33, 341, DateTimeKind.Local).AddTicks(6334), null, "دانشکده حقوق" },
                    { new Guid("c76004c6-c43b-4fe1-b9fb-54ba43bd60fa"), new DateTime(2022, 8, 12, 16, 0, 33, 341, DateTimeKind.Local).AddTicks(6310), null, "دانشکده برق و کامپیوتر" },
                    { new Guid("d08af042-b10d-4fdf-9102-4c0c0128894c"), new DateTime(2022, 8, 12, 16, 0, 33, 341, DateTimeKind.Local).AddTicks(6344), null, "دانشکده معماری" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "id", "CreateTime", "DeleteTime", "Name" },
                values: new object[,]
                {
                    { new Guid("37740af8-0ab1-410c-8b6e-afc51586d1b0"), new DateTime(2022, 8, 12, 16, 0, 33, 341, DateTimeKind.Local).AddTicks(6440), null, "Student" },
                    { new Guid("ab0ade69-d6bd-4289-8b8e-b642a01a7a3c"), new DateTime(2022, 8, 12, 16, 0, 33, 341, DateTimeKind.Local).AddTicks(6427), null, "Admin" },
                    { new Guid("ca338388-3291-408c-ac7c-f685645ee768"), new DateTime(2022, 8, 12, 16, 0, 33, 341, DateTimeKind.Local).AddTicks(6445), null, "Professor" },
                    { new Guid("ffee0957-787f-437b-998e-d4748243b924"), new DateTime(2022, 8, 12, 16, 0, 33, 341, DateTimeKind.Local).AddTicks(6455), null, "Company" }
                });

            migrationBuilder.InsertData(
                table: "WorkFields",
                columns: new[] { "id", "CreateTime", "DeleteTime", "Name" },
                values: new object[,]
                {
                    { new Guid("00a450fd-9d57-446e-a661-2e77aa5f2cf9"), new DateTime(2022, 8, 12, 16, 0, 33, 341, DateTimeKind.Local).AddTicks(6559), null, "سخت افزار" },
                    { new Guid("20a3d17e-5e6e-4e73-bc67-157b10c3b9d4"), new DateTime(2022, 8, 12, 16, 0, 33, 341, DateTimeKind.Local).AddTicks(6691), null, "هوش مصنوعی" },
                    { new Guid("3907e308-fa0c-4d66-a08f-515d9ab79b56"), new DateTime(2022, 8, 12, 16, 0, 33, 341, DateTimeKind.Local).AddTicks(6554), null, "نرم افزار" },
                    { new Guid("8422f4e8-9047-4412-9f58-6fc7d01d10c9"), new DateTime(2022, 8, 12, 16, 0, 33, 341, DateTimeKind.Local).AddTicks(6683), null, "شبکه" },
                    { new Guid("8a969146-87a9-4c9f-8ef8-1958db4a0ac3"), new DateTime(2022, 8, 12, 16, 0, 33, 341, DateTimeKind.Local).AddTicks(6511), null, "هوش مصنوعی" },
                    { new Guid("94f6e85b-6ade-4d42-83d3-5299651d4846"), new DateTime(2022, 8, 12, 16, 0, 33, 341, DateTimeKind.Local).AddTicks(6696), null, "شبکه‌های پیچیده" },
                    { new Guid("9ecb6dbd-8faf-4260-a07c-8eb875d693b4"), new DateTime(2022, 8, 12, 16, 0, 33, 341, DateTimeKind.Local).AddTicks(6676), null, "علوم داده" },
                    { new Guid("bab036dc-5f9e-4734-81ec-b469e1fba53f"), new DateTime(2022, 8, 12, 16, 0, 33, 341, DateTimeKind.Local).AddTicks(6706), null, "فناوری اطلاعات" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Users_StudentID",
                table: "Users",
                column: "StudentID",
                unique: true,
                filter: "[StudentID] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Users_StudentID",
                table: "Users");

            migrationBuilder.DeleteData(
                table: "EducationInstitutes",
                keyColumn: "id",
                keyValue: new Guid("516a4f42-4236-4786-9987-47f937addad5"));

            migrationBuilder.DeleteData(
                table: "EducationInstitutes",
                keyColumn: "id",
                keyValue: new Guid("8ed765ad-19a0-46f9-85a8-77b5e4de9ace"));

            migrationBuilder.DeleteData(
                table: "EducationInstitutes",
                keyColumn: "id",
                keyValue: new Guid("95d1da22-6f35-4ab7-857a-c8d7691a0788"));

            migrationBuilder.DeleteData(
                table: "EducationInstitutes",
                keyColumn: "id",
                keyValue: new Guid("d325866c-ec73-439e-8d66-c1f49ea6f47a"));

            migrationBuilder.DeleteData(
                table: "EducationInstitutes",
                keyColumn: "id",
                keyValue: new Guid("e69aa315-8c19-4dc0-add1-8cf3700a2f96"));

            migrationBuilder.DeleteData(
                table: "Faculties",
                keyColumn: "id",
                keyValue: new Guid("2f312dc7-ebeb-44d5-9945-676216e1e2ba"));

            migrationBuilder.DeleteData(
                table: "Faculties",
                keyColumn: "id",
                keyValue: new Guid("43d4753c-9d86-4902-a793-4ca73e097f8e"));

            migrationBuilder.DeleteData(
                table: "Faculties",
                keyColumn: "id",
                keyValue: new Guid("53cdfb5c-30ee-4724-9ff4-1757fddb1a41"));

            migrationBuilder.DeleteData(
                table: "Faculties",
                keyColumn: "id",
                keyValue: new Guid("c76004c6-c43b-4fe1-b9fb-54ba43bd60fa"));

            migrationBuilder.DeleteData(
                table: "Faculties",
                keyColumn: "id",
                keyValue: new Guid("d08af042-b10d-4fdf-9102-4c0c0128894c"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "id",
                keyValue: new Guid("37740af8-0ab1-410c-8b6e-afc51586d1b0"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "id",
                keyValue: new Guid("ab0ade69-d6bd-4289-8b8e-b642a01a7a3c"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "id",
                keyValue: new Guid("ca338388-3291-408c-ac7c-f685645ee768"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "id",
                keyValue: new Guid("ffee0957-787f-437b-998e-d4748243b924"));

            migrationBuilder.DeleteData(
                table: "WorkFields",
                keyColumn: "id",
                keyValue: new Guid("00a450fd-9d57-446e-a661-2e77aa5f2cf9"));

            migrationBuilder.DeleteData(
                table: "WorkFields",
                keyColumn: "id",
                keyValue: new Guid("20a3d17e-5e6e-4e73-bc67-157b10c3b9d4"));

            migrationBuilder.DeleteData(
                table: "WorkFields",
                keyColumn: "id",
                keyValue: new Guid("3907e308-fa0c-4d66-a08f-515d9ab79b56"));

            migrationBuilder.DeleteData(
                table: "WorkFields",
                keyColumn: "id",
                keyValue: new Guid("8422f4e8-9047-4412-9f58-6fc7d01d10c9"));

            migrationBuilder.DeleteData(
                table: "WorkFields",
                keyColumn: "id",
                keyValue: new Guid("8a969146-87a9-4c9f-8ef8-1958db4a0ac3"));

            migrationBuilder.DeleteData(
                table: "WorkFields",
                keyColumn: "id",
                keyValue: new Guid("94f6e85b-6ade-4d42-83d3-5299651d4846"));

            migrationBuilder.DeleteData(
                table: "WorkFields",
                keyColumn: "id",
                keyValue: new Guid("9ecb6dbd-8faf-4260-a07c-8eb875d693b4"));

            migrationBuilder.DeleteData(
                table: "WorkFields",
                keyColumn: "id",
                keyValue: new Guid("bab036dc-5f9e-4734-81ec-b469e1fba53f"));

            migrationBuilder.InsertData(
                table: "EducationInstitutes",
                columns: new[] { "id", "CreateTime", "DeleteTime", "Name" },
                values: new object[,]
                {
                    { new Guid("58a24725-7ff1-4900-9732-290007d37681"), new DateTime(2022, 8, 9, 11, 2, 23, 772, DateTimeKind.Local).AddTicks(8305), null, "دانشگاه صنعتی صنعتی شریف" },
                    { new Guid("79d364e0-ca71-4935-8b08-0bc132823391"), new DateTime(2022, 8, 9, 11, 2, 23, 772, DateTimeKind.Local).AddTicks(8255), null, "دانشگاه صنعتی امیرکبیر" },
                    { new Guid("ce1e06d4-130a-4405-8a72-83f0bed826a0"), new DateTime(2022, 8, 9, 11, 2, 23, 772, DateTimeKind.Local).AddTicks(8267), null, "دانشگاه علم و صنعت" },
                    { new Guid("e18d7c03-bfdb-4559-99ea-856c46200f3a"), new DateTime(2022, 8, 9, 11, 2, 23, 772, DateTimeKind.Local).AddTicks(8161), null, "دانشگاه شهید بهشتی" },
                    { new Guid("f7dee8fc-8dab-4f24-a453-cb7e19628dd6"), new DateTime(2022, 8, 9, 11, 2, 23, 772, DateTimeKind.Local).AddTicks(8242), null, "دانشگاه تهران" }
                });

            migrationBuilder.InsertData(
                table: "Faculties",
                columns: new[] { "id", "CreateTime", "DeleteTime", "Name" },
                values: new object[,]
                {
                    { new Guid("03ce8471-99ec-41d6-9949-b6f75e526f24"), new DateTime(2022, 8, 9, 11, 2, 23, 772, DateTimeKind.Local).AddTicks(8556), null, "دانشکده حقوق" },
                    { new Guid("2df38086-5885-4d08-92a8-f394594213b5"), new DateTime(2022, 8, 9, 11, 2, 23, 772, DateTimeKind.Local).AddTicks(8568), null, "دانشکده رواشناسی و علوم تربیتی" },
                    { new Guid("504bc4dc-c746-4436-a0c9-1d229a8dc3c4"), new DateTime(2022, 8, 9, 11, 2, 23, 772, DateTimeKind.Local).AddTicks(8591), null, "دانشکده علوم پایه" },
                    { new Guid("5850ef36-d6f6-4f04-9083-5a5e779a7a92"), new DateTime(2022, 8, 9, 11, 2, 23, 772, DateTimeKind.Local).AddTicks(8518), null, "دانشکده برق و کامپیوتر" },
                    { new Guid("aa8abc60-0da8-4b08-8cc9-1c32ac43f436"), new DateTime(2022, 8, 9, 11, 2, 23, 772, DateTimeKind.Local).AddTicks(8580), null, "دانشکده معماری" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "id", "CreateTime", "DeleteTime", "Name" },
                values: new object[,]
                {
                    { new Guid("18180193-b337-499a-b868-55867f0a3dee"), new DateTime(2022, 8, 9, 11, 2, 23, 772, DateTimeKind.Local).AddTicks(8797), null, "Professor" },
                    { new Guid("1925d612-dc71-49e9-939a-8592fdd63879"), new DateTime(2022, 8, 9, 11, 2, 23, 772, DateTimeKind.Local).AddTicks(8750), null, "Admin" },
                    { new Guid("63d5b0ee-8e4f-448e-91df-1152113cf3a2"), new DateTime(2022, 8, 9, 11, 2, 23, 772, DateTimeKind.Local).AddTicks(8774), null, "Student" },
                    { new Guid("9f41fe0c-6609-4394-83c5-e5d77117c964"), new DateTime(2022, 8, 9, 11, 2, 23, 772, DateTimeKind.Local).AddTicks(8810), null, "Company" }
                });

            migrationBuilder.InsertData(
                table: "WorkFields",
                columns: new[] { "id", "CreateTime", "DeleteTime", "Name" },
                values: new object[,]
                {
                    { new Guid("06af5ebd-9521-4399-9d63-2d3ea180a682"), new DateTime(2022, 8, 9, 11, 2, 23, 772, DateTimeKind.Local).AddTicks(9011), null, "هوش مصنوعی" },
                    { new Guid("17150b37-e99e-4dab-8d0e-db449191445c"), new DateTime(2022, 8, 9, 11, 2, 23, 772, DateTimeKind.Local).AddTicks(9044), null, "فناوری اطلاعات" },
                    { new Guid("20e23a77-6be6-412a-9d0f-efabd5e155c0"), new DateTime(2022, 8, 9, 11, 2, 23, 772, DateTimeKind.Local).AddTicks(8995), null, "شبکه" },
                    { new Guid("2ba71767-697c-4943-8527-771afa20f595"), new DateTime(2022, 8, 9, 11, 2, 23, 772, DateTimeKind.Local).AddTicks(8901), null, "هوش مصنوعی" },
                    { new Guid("2eeed719-8b45-4330-a4a2-447f9632217d"), new DateTime(2022, 8, 9, 11, 2, 23, 772, DateTimeKind.Local).AddTicks(9032), null, "شبکه‌های پیچیده" },
                    { new Guid("a94985aa-feee-4834-8ed8-5cd93cc43a87"), new DateTime(2022, 8, 9, 11, 2, 23, 772, DateTimeKind.Local).AddTicks(8980), null, "علوم داده" },
                    { new Guid("cf6f73b0-bf67-40a7-9004-d294e47bd72b"), new DateTime(2022, 8, 9, 11, 2, 23, 772, DateTimeKind.Local).AddTicks(8969), null, "سخت افزار" },
                    { new Guid("d44cd5db-dbd7-42ae-b315-41d38143f780"), new DateTime(2022, 8, 9, 11, 2, 23, 772, DateTimeKind.Local).AddTicks(8957), null, "نرم افزار" }
                });
        }
    }
}
