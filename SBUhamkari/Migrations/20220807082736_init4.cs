using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SBUhamkari.Migrations
{
    public partial class init4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "EducationInstitutes",
                keyColumn: "id",
                keyValue: new Guid("118b717a-42a5-4a1a-9f48-2ad40b71f5be"));

            migrationBuilder.DeleteData(
                table: "EducationInstitutes",
                keyColumn: "id",
                keyValue: new Guid("3650f6ef-cfd1-4834-8b5a-f53e3f0cae28"));

            migrationBuilder.DeleteData(
                table: "EducationInstitutes",
                keyColumn: "id",
                keyValue: new Guid("991c75c4-c100-4b2b-b7a5-0b644d87ee0b"));

            migrationBuilder.DeleteData(
                table: "EducationInstitutes",
                keyColumn: "id",
                keyValue: new Guid("a3c5ef3b-beae-4e8c-bd27-a4440bef1f0d"));

            migrationBuilder.DeleteData(
                table: "EducationInstitutes",
                keyColumn: "id",
                keyValue: new Guid("b582382e-6f51-4ab5-b67e-64e34dceca38"));

            migrationBuilder.DeleteData(
                table: "Faculties",
                keyColumn: "id",
                keyValue: new Guid("07fab028-4cf9-411b-91ce-7dc1ad93afbd"));

            migrationBuilder.DeleteData(
                table: "Faculties",
                keyColumn: "id",
                keyValue: new Guid("5d84bd45-8741-4632-bc48-0fcf8f1a132c"));

            migrationBuilder.DeleteData(
                table: "Faculties",
                keyColumn: "id",
                keyValue: new Guid("bd118161-aa02-411d-a2ec-d1cce9866852"));

            migrationBuilder.DeleteData(
                table: "Faculties",
                keyColumn: "id",
                keyValue: new Guid("df2a7737-1f56-4282-858b-036b7f816034"));

            migrationBuilder.DeleteData(
                table: "Faculties",
                keyColumn: "id",
                keyValue: new Guid("f9e0adfa-80a7-4159-a7f4-174eec8ed66c"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "id",
                keyValue: new Guid("044e2c4d-2d71-4138-98da-da4be350fb81"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "id",
                keyValue: new Guid("b4f9a034-8646-44f0-8dfa-416ec71d1398"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "id",
                keyValue: new Guid("ebf49f59-f9c4-4031-8b8b-879d8bba366b"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "id",
                keyValue: new Guid("eef6c6bf-9f31-4e30-999e-cc8d8846d1d4"));

            migrationBuilder.DeleteData(
                table: "WorkFields",
                keyColumn: "id",
                keyValue: new Guid("134c324e-3cf3-4819-afdb-7ad21ba4cd19"));

            migrationBuilder.DeleteData(
                table: "WorkFields",
                keyColumn: "id",
                keyValue: new Guid("682f39e3-6115-4af8-9b9a-ed62fb4ab254"));

            migrationBuilder.DeleteData(
                table: "WorkFields",
                keyColumn: "id",
                keyValue: new Guid("99c185ab-ea03-45ff-9244-1fb3d265108b"));

            migrationBuilder.DeleteData(
                table: "WorkFields",
                keyColumn: "id",
                keyValue: new Guid("a684c8f6-9764-4fe3-82f3-10015c245901"));

            migrationBuilder.DeleteData(
                table: "WorkFields",
                keyColumn: "id",
                keyValue: new Guid("c0895311-ecd0-4cfb-ae27-7682c6844cc5"));

            migrationBuilder.DeleteData(
                table: "WorkFields",
                keyColumn: "id",
                keyValue: new Guid("db8a8eba-25e8-484f-b655-c3892677ebbc"));

            migrationBuilder.DeleteData(
                table: "WorkFields",
                keyColumn: "id",
                keyValue: new Guid("dfdcd872-87f0-4348-bbf2-b56f555aabef"));

            migrationBuilder.DeleteData(
                table: "WorkFields",
                keyColumn: "id",
                keyValue: new Guid("e0802432-1829-40ef-b5fb-b50da231dd48"));

            migrationBuilder.InsertData(
                table: "EducationInstitutes",
                columns: new[] { "id", "CreateTime", "DeleteTime", "Name" },
                values: new object[,]
                {
                    { new Guid("1546c36e-a9c4-497c-a0bd-e14297b30c7c"), new DateTime(2022, 8, 7, 12, 57, 35, 758, DateTimeKind.Local).AddTicks(6766), null, "دانشگاه شهید بهشتی" },
                    { new Guid("38ec6373-848f-4837-9ec1-70d58da37345"), new DateTime(2022, 8, 7, 12, 57, 35, 758, DateTimeKind.Local).AddTicks(6824), null, "دانشگاه تهران" },
                    { new Guid("afb116d2-be7e-4a2d-b72d-7e6e1641b2e7"), new DateTime(2022, 8, 7, 12, 57, 35, 758, DateTimeKind.Local).AddTicks(6906), null, "دانشگاه صنعتی صنعتی شریف" },
                    { new Guid("eacebe86-af89-4a48-997d-57e8ce08300a"), new DateTime(2022, 8, 7, 12, 57, 35, 758, DateTimeKind.Local).AddTicks(6830), null, "دانشگاه صنعتی امیرکبیر" },
                    { new Guid("f2c08d38-7aa9-4ace-b515-f75a8e51b93b"), new DateTime(2022, 8, 7, 12, 57, 35, 758, DateTimeKind.Local).AddTicks(6834), null, "دانشگاه علم و صنعت" }
                });

            migrationBuilder.InsertData(
                table: "Faculties",
                columns: new[] { "id", "CreateTime", "DeleteTime", "Name" },
                values: new object[,]
                {
                    { new Guid("0281430f-303f-4d5e-95a7-d77a17d28dec"), new DateTime(2022, 8, 7, 12, 57, 35, 758, DateTimeKind.Local).AddTicks(7038), null, "دانشکده برق و کامپیوتر" },
                    { new Guid("2ebbd035-073b-40c2-8a3f-5e9c700ffe31"), new DateTime(2022, 8, 7, 12, 57, 35, 758, DateTimeKind.Local).AddTicks(7088), null, "دانشکده علوم پایه" },
                    { new Guid("3685fe87-b4a1-450c-b852-e592448a3abe"), new DateTime(2022, 8, 7, 12, 57, 35, 758, DateTimeKind.Local).AddTicks(7084), null, "دانشکده معماری" },
                    { new Guid("9ab9d2bd-ac0d-42e9-82e7-d81c858e85bf"), new DateTime(2022, 8, 7, 12, 57, 35, 758, DateTimeKind.Local).AddTicks(7075), null, "دانشکده حقوق" },
                    { new Guid("d49f5ee0-f3f5-410d-a222-4d9055b68fb5"), new DateTime(2022, 8, 7, 12, 57, 35, 758, DateTimeKind.Local).AddTicks(7080), null, "دانشکده رواشناسی و علوم تربیتی" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "id", "CreateTime", "DeleteTime", "Name" },
                values: new object[,]
                {
                    { new Guid("18c4d169-5492-4ef3-8eea-c7ce948551b8"), new DateTime(2022, 8, 7, 12, 57, 35, 758, DateTimeKind.Local).AddTicks(7166), null, "Company" },
                    { new Guid("854bc195-cd52-42ae-a15e-eeea01250be9"), new DateTime(2022, 8, 7, 12, 57, 35, 758, DateTimeKind.Local).AddTicks(7162), null, "Professor" },
                    { new Guid("bf126f7d-1dc2-436c-9988-15a27b6eb67e"), new DateTime(2022, 8, 7, 12, 57, 35, 758, DateTimeKind.Local).AddTicks(7147), null, "Admin" },
                    { new Guid("e0026ef5-1c3d-4640-809b-1304bec775df"), new DateTime(2022, 8, 7, 12, 57, 35, 758, DateTimeKind.Local).AddTicks(7158), null, "Student" }
                });

            migrationBuilder.InsertData(
                table: "WorkFields",
                columns: new[] { "id", "CreateTime", "DeleteTime", "Name" },
                values: new object[,]
                {
                    { new Guid("11abe1c3-807b-49bb-8587-6a79ed6e57ba"), new DateTime(2022, 8, 7, 12, 57, 35, 758, DateTimeKind.Local).AddTicks(7254), null, "فناوری اطلاعات" },
                    { new Guid("353d070b-732b-4cb8-9748-d58c37db5a98"), new DateTime(2022, 8, 7, 12, 57, 35, 758, DateTimeKind.Local).AddTicks(7218), null, "هوش مصنوعی" },
                    { new Guid("4298a2ca-d957-4062-bcd5-dd30ee0d55ab"), new DateTime(2022, 8, 7, 12, 57, 35, 758, DateTimeKind.Local).AddTicks(7240), null, "شبکه" },
                    { new Guid("70261bda-ac5c-4f15-915e-3ca51de8530d"), new DateTime(2022, 8, 7, 12, 57, 35, 758, DateTimeKind.Local).AddTicks(7250), null, "شبکه‌های پیچیده" },
                    { new Guid("79c81975-3041-47b7-8016-bdceddd80390"), new DateTime(2022, 8, 7, 12, 57, 35, 758, DateTimeKind.Local).AddTicks(7228), null, "نرم افزار" },
                    { new Guid("9509b1d3-fd97-4d17-940c-3400b000106e"), new DateTime(2022, 8, 7, 12, 57, 35, 758, DateTimeKind.Local).AddTicks(7236), null, "علوم داده" },
                    { new Guid("b8e1bde9-1f9f-4599-861d-929e7cae03a2"), new DateTime(2022, 8, 7, 12, 57, 35, 758, DateTimeKind.Local).AddTicks(7246), null, "هوش مصنوعی" },
                    { new Guid("f9a85f1b-5017-4993-9921-4ac290135fe9"), new DateTime(2022, 8, 7, 12, 57, 35, 758, DateTimeKind.Local).AddTicks(7232), null, "سخت افزار" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "EducationInstitutes",
                keyColumn: "id",
                keyValue: new Guid("1546c36e-a9c4-497c-a0bd-e14297b30c7c"));

            migrationBuilder.DeleteData(
                table: "EducationInstitutes",
                keyColumn: "id",
                keyValue: new Guid("38ec6373-848f-4837-9ec1-70d58da37345"));

            migrationBuilder.DeleteData(
                table: "EducationInstitutes",
                keyColumn: "id",
                keyValue: new Guid("afb116d2-be7e-4a2d-b72d-7e6e1641b2e7"));

            migrationBuilder.DeleteData(
                table: "EducationInstitutes",
                keyColumn: "id",
                keyValue: new Guid("eacebe86-af89-4a48-997d-57e8ce08300a"));

            migrationBuilder.DeleteData(
                table: "EducationInstitutes",
                keyColumn: "id",
                keyValue: new Guid("f2c08d38-7aa9-4ace-b515-f75a8e51b93b"));

            migrationBuilder.DeleteData(
                table: "Faculties",
                keyColumn: "id",
                keyValue: new Guid("0281430f-303f-4d5e-95a7-d77a17d28dec"));

            migrationBuilder.DeleteData(
                table: "Faculties",
                keyColumn: "id",
                keyValue: new Guid("2ebbd035-073b-40c2-8a3f-5e9c700ffe31"));

            migrationBuilder.DeleteData(
                table: "Faculties",
                keyColumn: "id",
                keyValue: new Guid("3685fe87-b4a1-450c-b852-e592448a3abe"));

            migrationBuilder.DeleteData(
                table: "Faculties",
                keyColumn: "id",
                keyValue: new Guid("9ab9d2bd-ac0d-42e9-82e7-d81c858e85bf"));

            migrationBuilder.DeleteData(
                table: "Faculties",
                keyColumn: "id",
                keyValue: new Guid("d49f5ee0-f3f5-410d-a222-4d9055b68fb5"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "id",
                keyValue: new Guid("18c4d169-5492-4ef3-8eea-c7ce948551b8"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "id",
                keyValue: new Guid("854bc195-cd52-42ae-a15e-eeea01250be9"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "id",
                keyValue: new Guid("bf126f7d-1dc2-436c-9988-15a27b6eb67e"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "id",
                keyValue: new Guid("e0026ef5-1c3d-4640-809b-1304bec775df"));

            migrationBuilder.DeleteData(
                table: "WorkFields",
                keyColumn: "id",
                keyValue: new Guid("11abe1c3-807b-49bb-8587-6a79ed6e57ba"));

            migrationBuilder.DeleteData(
                table: "WorkFields",
                keyColumn: "id",
                keyValue: new Guid("353d070b-732b-4cb8-9748-d58c37db5a98"));

            migrationBuilder.DeleteData(
                table: "WorkFields",
                keyColumn: "id",
                keyValue: new Guid("4298a2ca-d957-4062-bcd5-dd30ee0d55ab"));

            migrationBuilder.DeleteData(
                table: "WorkFields",
                keyColumn: "id",
                keyValue: new Guid("70261bda-ac5c-4f15-915e-3ca51de8530d"));

            migrationBuilder.DeleteData(
                table: "WorkFields",
                keyColumn: "id",
                keyValue: new Guid("79c81975-3041-47b7-8016-bdceddd80390"));

            migrationBuilder.DeleteData(
                table: "WorkFields",
                keyColumn: "id",
                keyValue: new Guid("9509b1d3-fd97-4d17-940c-3400b000106e"));

            migrationBuilder.DeleteData(
                table: "WorkFields",
                keyColumn: "id",
                keyValue: new Guid("b8e1bde9-1f9f-4599-861d-929e7cae03a2"));

            migrationBuilder.DeleteData(
                table: "WorkFields",
                keyColumn: "id",
                keyValue: new Guid("f9a85f1b-5017-4993-9921-4ac290135fe9"));

            migrationBuilder.InsertData(
                table: "EducationInstitutes",
                columns: new[] { "id", "CreateTime", "DeleteTime", "Name" },
                values: new object[,]
                {
                    { new Guid("118b717a-42a5-4a1a-9f48-2ad40b71f5be"), new DateTime(2022, 8, 7, 12, 36, 18, 651, DateTimeKind.Local).AddTicks(3213), null, "دانشگاه صنعتی صنعتی شریف" },
                    { new Guid("3650f6ef-cfd1-4834-8b5a-f53e3f0cae28"), new DateTime(2022, 8, 7, 12, 36, 18, 651, DateTimeKind.Local).AddTicks(3204), null, "دانشگاه علم و صنعت" },
                    { new Guid("991c75c4-c100-4b2b-b7a5-0b644d87ee0b"), new DateTime(2022, 8, 7, 12, 36, 18, 651, DateTimeKind.Local).AddTicks(3194), null, "دانشگاه صنعتی امیرکبیر" },
                    { new Guid("a3c5ef3b-beae-4e8c-bd27-a4440bef1f0d"), new DateTime(2022, 8, 7, 12, 36, 18, 651, DateTimeKind.Local).AddTicks(3093), null, "دانشگاه شهید بهشتی" },
                    { new Guid("b582382e-6f51-4ab5-b67e-64e34dceca38"), new DateTime(2022, 8, 7, 12, 36, 18, 651, DateTimeKind.Local).AddTicks(3181), null, "دانشگاه تهران" }
                });

            migrationBuilder.InsertData(
                table: "Faculties",
                columns: new[] { "id", "CreateTime", "DeleteTime", "Name" },
                values: new object[,]
                {
                    { new Guid("07fab028-4cf9-411b-91ce-7dc1ad93afbd"), new DateTime(2022, 8, 7, 12, 36, 18, 651, DateTimeKind.Local).AddTicks(3463), null, "دانشکده رواشناسی و علوم تربیتی" },
                    { new Guid("5d84bd45-8741-4632-bc48-0fcf8f1a132c"), new DateTime(2022, 8, 7, 12, 36, 18, 651, DateTimeKind.Local).AddTicks(3453), null, "دانشکده حقوق" },
                    { new Guid("bd118161-aa02-411d-a2ec-d1cce9866852"), new DateTime(2022, 8, 7, 12, 36, 18, 651, DateTimeKind.Local).AddTicks(3471), null, "دانشکده معماری" },
                    { new Guid("df2a7737-1f56-4282-858b-036b7f816034"), new DateTime(2022, 8, 7, 12, 36, 18, 651, DateTimeKind.Local).AddTicks(3403), null, "دانشکده برق و کامپیوتر" },
                    { new Guid("f9e0adfa-80a7-4159-a7f4-174eec8ed66c"), new DateTime(2022, 8, 7, 12, 36, 18, 651, DateTimeKind.Local).AddTicks(3479), null, "دانشکده علوم پایه" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "id", "CreateTime", "DeleteTime", "Name" },
                values: new object[,]
                {
                    { new Guid("044e2c4d-2d71-4138-98da-da4be350fb81"), new DateTime(2022, 8, 7, 12, 36, 18, 651, DateTimeKind.Local).AddTicks(3742), null, "Student" },
                    { new Guid("b4f9a034-8646-44f0-8dfa-416ec71d1398"), new DateTime(2022, 8, 7, 12, 36, 18, 651, DateTimeKind.Local).AddTicks(3615), null, "Admin" },
                    { new Guid("ebf49f59-f9c4-4031-8b8b-879d8bba366b"), new DateTime(2022, 8, 7, 12, 36, 18, 651, DateTimeKind.Local).AddTicks(3758), null, "Professor" },
                    { new Guid("eef6c6bf-9f31-4e30-999e-cc8d8846d1d4"), new DateTime(2022, 8, 7, 12, 36, 18, 651, DateTimeKind.Local).AddTicks(3779), null, "Company" }
                });

            migrationBuilder.InsertData(
                table: "WorkFields",
                columns: new[] { "id", "CreateTime", "DeleteTime", "Name" },
                values: new object[,]
                {
                    { new Guid("134c324e-3cf3-4819-afdb-7ad21ba4cd19"), new DateTime(2022, 8, 7, 12, 36, 18, 651, DateTimeKind.Local).AddTicks(4019), null, "هوش مصنوعی" },
                    { new Guid("682f39e3-6115-4af8-9b9a-ed62fb4ab254"), new DateTime(2022, 8, 7, 12, 36, 18, 651, DateTimeKind.Local).AddTicks(4028), null, "شبکه‌های پیچیده" },
                    { new Guid("99c185ab-ea03-45ff-9244-1fb3d265108b"), new DateTime(2022, 8, 7, 12, 36, 18, 651, DateTimeKind.Local).AddTicks(3983), null, "سخت افزار" },
                    { new Guid("a684c8f6-9764-4fe3-82f3-10015c245901"), new DateTime(2022, 8, 7, 12, 36, 18, 651, DateTimeKind.Local).AddTicks(4046), null, "فناوری اطلاعات" },
                    { new Guid("c0895311-ecd0-4cfb-ae27-7682c6844cc5"), new DateTime(2022, 8, 7, 12, 36, 18, 651, DateTimeKind.Local).AddTicks(3973), null, "نرم افزار" },
                    { new Guid("db8a8eba-25e8-484f-b655-c3892677ebbc"), new DateTime(2022, 8, 7, 12, 36, 18, 651, DateTimeKind.Local).AddTicks(4001), null, "شبکه" },
                    { new Guid("dfdcd872-87f0-4348-bbf2-b56f555aabef"), new DateTime(2022, 8, 7, 12, 36, 18, 651, DateTimeKind.Local).AddTicks(3902), null, "هوش مصنوعی" },
                    { new Guid("e0802432-1829-40ef-b5fb-b50da231dd48"), new DateTime(2022, 8, 7, 12, 36, 18, 651, DateTimeKind.Local).AddTicks(3992), null, "علوم داده" }
                });
        }
    }
}
