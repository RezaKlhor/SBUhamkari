using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SBUhamkari.Migrations
{
    public partial class init5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Users_Companyid",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_Companyid",
                table: "Users");

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

            migrationBuilder.DropColumn(
                name: "Companyid",
                table: "Users");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<Guid>(
                name: "Companyid",
                table: "Users",
                type: "uniqueidentifier",
                nullable: true);

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

            migrationBuilder.CreateIndex(
                name: "IX_Users_Companyid",
                table: "Users",
                column: "Companyid");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Users_Companyid",
                table: "Users",
                column: "Companyid",
                principalTable: "Users",
                principalColumn: "id");
        }
    }
}
