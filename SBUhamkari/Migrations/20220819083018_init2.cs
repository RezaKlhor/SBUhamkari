using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SBUhamkari.Migrations
{
    public partial class init2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "EducationInstitutes",
                keyColumn: "id",
                keyValue: new Guid("3704af32-771e-4f3e-8ceb-945051acc04c"));

            migrationBuilder.DeleteData(
                table: "EducationInstitutes",
                keyColumn: "id",
                keyValue: new Guid("3775d682-118b-4af1-8460-af92c362a1fa"));

            migrationBuilder.DeleteData(
                table: "EducationInstitutes",
                keyColumn: "id",
                keyValue: new Guid("996d684a-adb7-49c6-af2b-5aefced9d8fe"));

            migrationBuilder.DeleteData(
                table: "EducationInstitutes",
                keyColumn: "id",
                keyValue: new Guid("afd71194-7960-42b8-b8bd-f3a8da659045"));

            migrationBuilder.DeleteData(
                table: "EducationInstitutes",
                keyColumn: "id",
                keyValue: new Guid("b74abef7-fe30-419b-9326-49437d848c95"));

            migrationBuilder.DeleteData(
                table: "Faculties",
                keyColumn: "id",
                keyValue: new Guid("12e5dafa-e36f-488f-817a-7d57f4a50923"));

            migrationBuilder.DeleteData(
                table: "Faculties",
                keyColumn: "id",
                keyValue: new Guid("1b9070d5-9f62-496f-940a-d1a0e389f6c7"));

            migrationBuilder.DeleteData(
                table: "Faculties",
                keyColumn: "id",
                keyValue: new Guid("24ea6d16-9dd9-417f-af45-1503f307b053"));

            migrationBuilder.DeleteData(
                table: "Faculties",
                keyColumn: "id",
                keyValue: new Guid("598e0b26-195f-4dac-80d7-49f7ebb3505e"));

            migrationBuilder.DeleteData(
                table: "Faculties",
                keyColumn: "id",
                keyValue: new Guid("cbbc4f09-c4e6-48bb-bdfa-9e06f7db714c"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "id",
                keyValue: new Guid("0665dccc-4bcc-4e39-82f7-267f4351c335"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "id",
                keyValue: new Guid("25352780-90bc-465d-b553-8d1297d8d542"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "id",
                keyValue: new Guid("3e01eab9-f4af-4633-bd14-9a5b0e1d4a11"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "id",
                keyValue: new Guid("a75d09d8-87ce-4cb0-8e35-fe0c46ce5082"));

            migrationBuilder.DeleteData(
                table: "WorkFields",
                keyColumn: "id",
                keyValue: new Guid("04ec3066-9ae6-4358-8248-056c15a6ff4a"));

            migrationBuilder.DeleteData(
                table: "WorkFields",
                keyColumn: "id",
                keyValue: new Guid("1991447e-45c1-4485-958f-0942197878ce"));

            migrationBuilder.DeleteData(
                table: "WorkFields",
                keyColumn: "id",
                keyValue: new Guid("2820cce5-ec38-4d5d-91c5-45e3325052bf"));

            migrationBuilder.DeleteData(
                table: "WorkFields",
                keyColumn: "id",
                keyValue: new Guid("65a19480-af21-4b3e-9c99-8a65f9c5fbd8"));

            migrationBuilder.DeleteData(
                table: "WorkFields",
                keyColumn: "id",
                keyValue: new Guid("996e0d44-04b2-441e-beb0-7713fbf26d4a"));

            migrationBuilder.DeleteData(
                table: "WorkFields",
                keyColumn: "id",
                keyValue: new Guid("a2248217-ad07-4163-8ce2-a3dc1a3532c5"));

            migrationBuilder.DeleteData(
                table: "WorkFields",
                keyColumn: "id",
                keyValue: new Guid("a6d24e89-dd08-4890-bf76-671c9472b979"));

            migrationBuilder.DeleteData(
                table: "WorkFields",
                keyColumn: "id",
                keyValue: new Guid("ff4d0570-3cbf-4061-b382-a358f5b9be1b"));

            migrationBuilder.AlterColumn<string>(
                name: "CompanyIDnumber",
                table: "Users",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldMaxLength: 10,
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "EducationInstitutes",
                columns: new[] { "id", "CreateTime", "DeleteTime", "Name" },
                values: new object[,]
                {
                    { new Guid("52ce4066-d31b-4d30-8f37-ddd8ca3bf98c"), new DateTime(2022, 8, 19, 13, 0, 17, 36, DateTimeKind.Local).AddTicks(4425), null, "دانشگاه شهید بهشتی" },
                    { new Guid("818834d9-23b7-477b-97e1-2a1ff9788e58"), new DateTime(2022, 8, 19, 13, 0, 17, 36, DateTimeKind.Local).AddTicks(4532), null, "دانشگاه صنعتی امیرکبیر" },
                    { new Guid("87a17bc2-1dc3-4b5d-8cf0-28668ce006b5"), new DateTime(2022, 8, 19, 13, 0, 17, 36, DateTimeKind.Local).AddTicks(4550), null, "دانشگاه صنعتی صنعتی شریف" },
                    { new Guid("da8f4e68-5f04-4182-b1ac-a763bfdc1c51"), new DateTime(2022, 8, 19, 13, 0, 17, 36, DateTimeKind.Local).AddTicks(4520), null, "دانشگاه تهران" },
                    { new Guid("eaa0ae02-fe5c-4506-bc9d-e78d010ec37c"), new DateTime(2022, 8, 19, 13, 0, 17, 36, DateTimeKind.Local).AddTicks(4541), null, "دانشگاه علم و صنعت" }
                });

            migrationBuilder.InsertData(
                table: "Faculties",
                columns: new[] { "id", "CreateTime", "DeleteTime", "Name" },
                values: new object[,]
                {
                    { new Guid("38909d71-d414-4c71-a978-06bac57d2c0b"), new DateTime(2022, 8, 19, 13, 0, 17, 36, DateTimeKind.Local).AddTicks(4804), null, "دانشکده معماری" },
                    { new Guid("3f898554-86eb-4dfd-a8a2-af7252da82ad"), new DateTime(2022, 8, 19, 13, 0, 17, 36, DateTimeKind.Local).AddTicks(4785), null, "دانشکده حقوق" },
                    { new Guid("517c645c-1b7a-47a4-b378-c502cabbfa77"), new DateTime(2022, 8, 19, 13, 0, 17, 36, DateTimeKind.Local).AddTicks(4813), null, "دانشکده علوم پایه" },
                    { new Guid("7f178235-6c59-4698-b532-90fc05e83377"), new DateTime(2022, 8, 19, 13, 0, 17, 36, DateTimeKind.Local).AddTicks(4796), null, "دانشکده رواشناسی و علوم تربیتی" },
                    { new Guid("fcc4cefc-ded5-4b06-8e13-1a096e411387"), new DateTime(2022, 8, 19, 13, 0, 17, 36, DateTimeKind.Local).AddTicks(4741), null, "دانشکده برق و کامپیوتر" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "id", "CreateTime", "DeleteTime", "Name" },
                values: new object[,]
                {
                    { new Guid("5f0bdb02-a5ae-4eac-91d9-bfabc3bf51ec"), new DateTime(2022, 8, 19, 13, 0, 17, 36, DateTimeKind.Local).AddTicks(5159), null, "Student" },
                    { new Guid("cd908276-ad81-480c-be4e-5cab53b47e52"), new DateTime(2022, 8, 19, 13, 0, 17, 36, DateTimeKind.Local).AddTicks(5170), null, "Professor" },
                    { new Guid("cda3a357-e8b5-482f-b866-ab89c57924c2"), new DateTime(2022, 8, 19, 13, 0, 17, 36, DateTimeKind.Local).AddTicks(5194), null, "Company" },
                    { new Guid("fe067fab-0836-4383-975c-a0435a3204ac"), new DateTime(2022, 8, 19, 13, 0, 17, 36, DateTimeKind.Local).AddTicks(5127), null, "Admin" }
                });

            migrationBuilder.InsertData(
                table: "WorkFields",
                columns: new[] { "id", "CreateTime", "DeleteTime", "Name" },
                values: new object[,]
                {
                    { new Guid("1bd01eeb-a153-4e50-8e1d-1012ac0367b2"), new DateTime(2022, 8, 19, 13, 0, 17, 36, DateTimeKind.Local).AddTicks(5410), null, "علوم داده" },
                    { new Guid("35ed1382-324b-43dc-94c7-d1138f53b441"), new DateTime(2022, 8, 19, 13, 0, 17, 36, DateTimeKind.Local).AddTicks(5389), null, "نرم افزار" },
                    { new Guid("374812af-d2c2-44e9-8e46-29cb54d08e18"), new DateTime(2022, 8, 19, 13, 0, 17, 36, DateTimeKind.Local).AddTicks(5442), null, "شبکه‌های پیچیده" },
                    { new Guid("676c1440-c0a9-447a-9c89-dc530d614f63"), new DateTime(2022, 8, 19, 13, 0, 17, 36, DateTimeKind.Local).AddTicks(5401), null, "سخت افزار" },
                    { new Guid("a02ae718-4581-4fe0-8fec-d58280288f69"), new DateTime(2022, 8, 19, 13, 0, 17, 36, DateTimeKind.Local).AddTicks(5434), null, "هوش مصنوعی" },
                    { new Guid("dcca56cf-7bf6-4375-b425-bb596fc4fb01"), new DateTime(2022, 8, 19, 13, 0, 17, 36, DateTimeKind.Local).AddTicks(5463), null, "فناوری اطلاعات" },
                    { new Guid("faf1cc68-cb5c-4868-ae53-ba9d4f3c07a4"), new DateTime(2022, 8, 19, 13, 0, 17, 36, DateTimeKind.Local).AddTicks(5418), null, "شبکه" },
                    { new Guid("fc71ce27-a641-4eda-b633-91c6f381dc29"), new DateTime(2022, 8, 19, 13, 0, 17, 36, DateTimeKind.Local).AddTicks(5320), null, "هوش مصنوعی" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "EducationInstitutes",
                keyColumn: "id",
                keyValue: new Guid("52ce4066-d31b-4d30-8f37-ddd8ca3bf98c"));

            migrationBuilder.DeleteData(
                table: "EducationInstitutes",
                keyColumn: "id",
                keyValue: new Guid("818834d9-23b7-477b-97e1-2a1ff9788e58"));

            migrationBuilder.DeleteData(
                table: "EducationInstitutes",
                keyColumn: "id",
                keyValue: new Guid("87a17bc2-1dc3-4b5d-8cf0-28668ce006b5"));

            migrationBuilder.DeleteData(
                table: "EducationInstitutes",
                keyColumn: "id",
                keyValue: new Guid("da8f4e68-5f04-4182-b1ac-a763bfdc1c51"));

            migrationBuilder.DeleteData(
                table: "EducationInstitutes",
                keyColumn: "id",
                keyValue: new Guid("eaa0ae02-fe5c-4506-bc9d-e78d010ec37c"));

            migrationBuilder.DeleteData(
                table: "Faculties",
                keyColumn: "id",
                keyValue: new Guid("38909d71-d414-4c71-a978-06bac57d2c0b"));

            migrationBuilder.DeleteData(
                table: "Faculties",
                keyColumn: "id",
                keyValue: new Guid("3f898554-86eb-4dfd-a8a2-af7252da82ad"));

            migrationBuilder.DeleteData(
                table: "Faculties",
                keyColumn: "id",
                keyValue: new Guid("517c645c-1b7a-47a4-b378-c502cabbfa77"));

            migrationBuilder.DeleteData(
                table: "Faculties",
                keyColumn: "id",
                keyValue: new Guid("7f178235-6c59-4698-b532-90fc05e83377"));

            migrationBuilder.DeleteData(
                table: "Faculties",
                keyColumn: "id",
                keyValue: new Guid("fcc4cefc-ded5-4b06-8e13-1a096e411387"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "id",
                keyValue: new Guid("5f0bdb02-a5ae-4eac-91d9-bfabc3bf51ec"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "id",
                keyValue: new Guid("cd908276-ad81-480c-be4e-5cab53b47e52"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "id",
                keyValue: new Guid("cda3a357-e8b5-482f-b866-ab89c57924c2"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "id",
                keyValue: new Guid("fe067fab-0836-4383-975c-a0435a3204ac"));

            migrationBuilder.DeleteData(
                table: "WorkFields",
                keyColumn: "id",
                keyValue: new Guid("1bd01eeb-a153-4e50-8e1d-1012ac0367b2"));

            migrationBuilder.DeleteData(
                table: "WorkFields",
                keyColumn: "id",
                keyValue: new Guid("35ed1382-324b-43dc-94c7-d1138f53b441"));

            migrationBuilder.DeleteData(
                table: "WorkFields",
                keyColumn: "id",
                keyValue: new Guid("374812af-d2c2-44e9-8e46-29cb54d08e18"));

            migrationBuilder.DeleteData(
                table: "WorkFields",
                keyColumn: "id",
                keyValue: new Guid("676c1440-c0a9-447a-9c89-dc530d614f63"));

            migrationBuilder.DeleteData(
                table: "WorkFields",
                keyColumn: "id",
                keyValue: new Guid("a02ae718-4581-4fe0-8fec-d58280288f69"));

            migrationBuilder.DeleteData(
                table: "WorkFields",
                keyColumn: "id",
                keyValue: new Guid("dcca56cf-7bf6-4375-b425-bb596fc4fb01"));

            migrationBuilder.DeleteData(
                table: "WorkFields",
                keyColumn: "id",
                keyValue: new Guid("faf1cc68-cb5c-4868-ae53-ba9d4f3c07a4"));

            migrationBuilder.DeleteData(
                table: "WorkFields",
                keyColumn: "id",
                keyValue: new Guid("fc71ce27-a641-4eda-b633-91c6f381dc29"));

            migrationBuilder.AlterColumn<long>(
                name: "CompanyIDnumber",
                table: "Users",
                type: "bigint",
                maxLength: 10,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "EducationInstitutes",
                columns: new[] { "id", "CreateTime", "DeleteTime", "Name" },
                values: new object[,]
                {
                    { new Guid("3704af32-771e-4f3e-8ceb-945051acc04c"), new DateTime(2022, 8, 18, 0, 35, 58, 877, DateTimeKind.Local).AddTicks(3857), null, "دانشگاه تهران" },
                    { new Guid("3775d682-118b-4af1-8460-af92c362a1fa"), new DateTime(2022, 8, 18, 0, 35, 58, 877, DateTimeKind.Local).AddTicks(3863), null, "دانشگاه صنعتی امیرکبیر" },
                    { new Guid("996d684a-adb7-49c6-af2b-5aefced9d8fe"), new DateTime(2022, 8, 18, 0, 35, 58, 877, DateTimeKind.Local).AddTicks(3899), null, "دانشگاه صنعتی صنعتی شریف" },
                    { new Guid("afd71194-7960-42b8-b8bd-f3a8da659045"), new DateTime(2022, 8, 18, 0, 35, 58, 877, DateTimeKind.Local).AddTicks(3773), null, "دانشگاه شهید بهشتی" },
                    { new Guid("b74abef7-fe30-419b-9326-49437d848c95"), new DateTime(2022, 8, 18, 0, 35, 58, 877, DateTimeKind.Local).AddTicks(3868), null, "دانشگاه علم و صنعت" }
                });

            migrationBuilder.InsertData(
                table: "Faculties",
                columns: new[] { "id", "CreateTime", "DeleteTime", "Name" },
                values: new object[,]
                {
                    { new Guid("12e5dafa-e36f-488f-817a-7d57f4a50923"), new DateTime(2022, 8, 18, 0, 35, 58, 877, DateTimeKind.Local).AddTicks(4043), null, "دانشکده رواشناسی و علوم تربیتی" },
                    { new Guid("1b9070d5-9f62-496f-940a-d1a0e389f6c7"), new DateTime(2022, 8, 18, 0, 35, 58, 877, DateTimeKind.Local).AddTicks(4008), null, "دانشکده برق و کامپیوتر" },
                    { new Guid("24ea6d16-9dd9-417f-af45-1503f307b053"), new DateTime(2022, 8, 18, 0, 35, 58, 877, DateTimeKind.Local).AddTicks(4052), null, "دانشکده علوم پایه" },
                    { new Guid("598e0b26-195f-4dac-80d7-49f7ebb3505e"), new DateTime(2022, 8, 18, 0, 35, 58, 877, DateTimeKind.Local).AddTicks(4038), null, "دانشکده حقوق" },
                    { new Guid("cbbc4f09-c4e6-48bb-bdfa-9e06f7db714c"), new DateTime(2022, 8, 18, 0, 35, 58, 877, DateTimeKind.Local).AddTicks(4048), null, "دانشکده معماری" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "id", "CreateTime", "DeleteTime", "Name" },
                values: new object[,]
                {
                    { new Guid("0665dccc-4bcc-4e39-82f7-267f4351c335"), new DateTime(2022, 8, 18, 0, 35, 58, 877, DateTimeKind.Local).AddTicks(4157), null, "Professor" },
                    { new Guid("25352780-90bc-465d-b553-8d1297d8d542"), new DateTime(2022, 8, 18, 0, 35, 58, 877, DateTimeKind.Local).AddTicks(4145), null, "Student" },
                    { new Guid("3e01eab9-f4af-4633-bd14-9a5b0e1d4a11"), new DateTime(2022, 8, 18, 0, 35, 58, 877, DateTimeKind.Local).AddTicks(4130), null, "Admin" },
                    { new Guid("a75d09d8-87ce-4cb0-8e35-fe0c46ce5082"), new DateTime(2022, 8, 18, 0, 35, 58, 877, DateTimeKind.Local).AddTicks(4162), null, "Company" }
                });

            migrationBuilder.InsertData(
                table: "WorkFields",
                columns: new[] { "id", "CreateTime", "DeleteTime", "Name" },
                values: new object[,]
                {
                    { new Guid("04ec3066-9ae6-4358-8248-056c15a6ff4a"), new DateTime(2022, 8, 18, 0, 35, 58, 877, DateTimeKind.Local).AddTicks(4298), null, "شبکه" },
                    { new Guid("1991447e-45c1-4485-958f-0942197878ce"), new DateTime(2022, 8, 18, 0, 35, 58, 877, DateTimeKind.Local).AddTicks(4289), null, "سخت افزار" },
                    { new Guid("2820cce5-ec38-4d5d-91c5-45e3325052bf"), new DateTime(2022, 8, 18, 0, 35, 58, 877, DateTimeKind.Local).AddTicks(4321), null, "فناوری اطلاعات" },
                    { new Guid("65a19480-af21-4b3e-9c99-8a65f9c5fbd8"), new DateTime(2022, 8, 18, 0, 35, 58, 877, DateTimeKind.Local).AddTicks(4284), null, "نرم افزار" },
                    { new Guid("996e0d44-04b2-441e-beb0-7713fbf26d4a"), new DateTime(2022, 8, 18, 0, 35, 58, 877, DateTimeKind.Local).AddTicks(4231), null, "هوش مصنوعی" },
                    { new Guid("a2248217-ad07-4163-8ce2-a3dc1a3532c5"), new DateTime(2022, 8, 18, 0, 35, 58, 877, DateTimeKind.Local).AddTicks(4305), null, "هوش مصنوعی" },
                    { new Guid("a6d24e89-dd08-4890-bf76-671c9472b979"), new DateTime(2022, 8, 18, 0, 35, 58, 877, DateTimeKind.Local).AddTicks(4293), null, "علوم داده" },
                    { new Guid("ff4d0570-3cbf-4061-b382-a358f5b9be1b"), new DateTime(2022, 8, 18, 0, 35, 58, 877, DateTimeKind.Local).AddTicks(4316), null, "شبکه‌های پیچیده" }
                });
        }
    }
}
