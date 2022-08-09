using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SBUhamkari.Migrations
{
    public partial class init3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CoAnnouncements_Projects_Projectid",
                table: "CoAnnouncements");

            migrationBuilder.DropForeignKey(
                name: "FK_SavedProject_Projects_Projectid",
                table: "SavedProject");

            migrationBuilder.DropForeignKey(
                name: "FK_SavedProject_Users_Userid",
                table: "SavedProject");

            migrationBuilder.DropIndex(
                name: "IX_CoAnnouncements_Projectid",
                table: "CoAnnouncements");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SavedProject",
                table: "SavedProject");

            migrationBuilder.DeleteData(
                table: "EducationInstitutes",
                keyColumn: "id",
                keyValue: new Guid("6076e225-b8e2-4da2-80ed-4147c32cd605"));

            migrationBuilder.DeleteData(
                table: "EducationInstitutes",
                keyColumn: "id",
                keyValue: new Guid("6f4b0c64-bc5d-4d8a-a9cd-1e29bace261e"));

            migrationBuilder.DeleteData(
                table: "EducationInstitutes",
                keyColumn: "id",
                keyValue: new Guid("acf727a7-a55a-4af5-8167-0eb61bc9d916"));

            migrationBuilder.DeleteData(
                table: "EducationInstitutes",
                keyColumn: "id",
                keyValue: new Guid("c1f0c206-d1d3-4bd0-9c9a-5b4e61649fdf"));

            migrationBuilder.DeleteData(
                table: "EducationInstitutes",
                keyColumn: "id",
                keyValue: new Guid("f8004ff8-c898-4fcd-9f32-1d6740d2eafe"));

            migrationBuilder.DeleteData(
                table: "Faculties",
                keyColumn: "id",
                keyValue: new Guid("1eee1ee5-e2d6-44bd-ae5c-72606c6c7ddb"));

            migrationBuilder.DeleteData(
                table: "Faculties",
                keyColumn: "id",
                keyValue: new Guid("380a5ee6-8701-4203-ad7b-e9651d88e63c"));

            migrationBuilder.DeleteData(
                table: "Faculties",
                keyColumn: "id",
                keyValue: new Guid("7e1fe968-e3c7-4e51-8360-7bfbc72cc555"));

            migrationBuilder.DeleteData(
                table: "Faculties",
                keyColumn: "id",
                keyValue: new Guid("d1208c45-9f94-468f-a881-0c7bc8b52701"));

            migrationBuilder.DeleteData(
                table: "Faculties",
                keyColumn: "id",
                keyValue: new Guid("f27ddd1d-03b1-44d4-bb9e-3f9375b25206"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "id",
                keyValue: new Guid("79e8d250-cd9d-45f2-b0b9-efedb4942e81"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "id",
                keyValue: new Guid("985518f0-3d57-417b-98ec-bf5b9e22d8f8"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "id",
                keyValue: new Guid("fdcf3bfc-7468-4a54-b9bf-6cbd3b649396"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "id",
                keyValue: new Guid("ffda95ea-8f3d-4fc2-904b-22be34e6bd94"));

            migrationBuilder.DeleteData(
                table: "WorkFields",
                keyColumn: "id",
                keyValue: new Guid("1bac87f0-89d8-49d3-8a1f-edd7100a19f3"));

            migrationBuilder.DeleteData(
                table: "WorkFields",
                keyColumn: "id",
                keyValue: new Guid("22b09c11-4191-42cf-bea0-1dffb5c1f754"));

            migrationBuilder.DeleteData(
                table: "WorkFields",
                keyColumn: "id",
                keyValue: new Guid("3a042889-093e-490e-b471-16dab03a0040"));

            migrationBuilder.DeleteData(
                table: "WorkFields",
                keyColumn: "id",
                keyValue: new Guid("3bbc344d-5003-423b-91f1-fbcd6d22ff61"));

            migrationBuilder.DeleteData(
                table: "WorkFields",
                keyColumn: "id",
                keyValue: new Guid("850b5e1e-096d-49bf-aed3-a8e86c32470a"));

            migrationBuilder.DeleteData(
                table: "WorkFields",
                keyColumn: "id",
                keyValue: new Guid("a9f948c9-f793-428d-982c-ccf479df720f"));

            migrationBuilder.DeleteData(
                table: "WorkFields",
                keyColumn: "id",
                keyValue: new Guid("c9e5bab2-778a-47a3-865e-dbfd9d250f95"));

            migrationBuilder.DeleteData(
                table: "WorkFields",
                keyColumn: "id",
                keyValue: new Guid("dd2a1d73-e4fa-4639-b87f-0674cce6ab00"));

            migrationBuilder.DropColumn(
                name: "Projectid",
                table: "CoAnnouncements");

            migrationBuilder.RenameTable(
                name: "SavedProject",
                newName: "SavedProjects");

            migrationBuilder.RenameIndex(
                name: "IX_SavedProject_Userid",
                table: "SavedProjects",
                newName: "IX_SavedProjects_Userid");

            migrationBuilder.RenameIndex(
                name: "IX_SavedProject_Projectid",
                table: "SavedProjects",
                newName: "IX_SavedProjects_Projectid");

            migrationBuilder.AlterColumn<int>(
                name: "Degree",
                table: "EducationRecords",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_SavedProjects",
                table: "SavedProjects",
                column: "id");

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

            migrationBuilder.AddForeignKey(
                name: "FK_SavedProjects_Projects_Projectid",
                table: "SavedProjects",
                column: "Projectid",
                principalTable: "Projects",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SavedProjects_Users_Userid",
                table: "SavedProjects",
                column: "Userid",
                principalTable: "Users",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SavedProjects_Projects_Projectid",
                table: "SavedProjects");

            migrationBuilder.DropForeignKey(
                name: "FK_SavedProjects_Users_Userid",
                table: "SavedProjects");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SavedProjects",
                table: "SavedProjects");

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

            migrationBuilder.RenameTable(
                name: "SavedProjects",
                newName: "SavedProject");

            migrationBuilder.RenameIndex(
                name: "IX_SavedProjects_Userid",
                table: "SavedProject",
                newName: "IX_SavedProject_Userid");

            migrationBuilder.RenameIndex(
                name: "IX_SavedProjects_Projectid",
                table: "SavedProject",
                newName: "IX_SavedProject_Projectid");

            migrationBuilder.AlterColumn<int>(
                name: "Degree",
                table: "EducationRecords",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<Guid>(
                name: "Projectid",
                table: "CoAnnouncements",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_SavedProject",
                table: "SavedProject",
                column: "id");

            migrationBuilder.InsertData(
                table: "EducationInstitutes",
                columns: new[] { "id", "CreateTime", "DeleteTime", "Name" },
                values: new object[,]
                {
                    { new Guid("6076e225-b8e2-4da2-80ed-4147c32cd605"), new DateTime(2022, 7, 31, 20, 31, 38, 387, DateTimeKind.Local).AddTicks(7480), null, "دانشگاه علم و صنعت" },
                    { new Guid("6f4b0c64-bc5d-4d8a-a9cd-1e29bace261e"), new DateTime(2022, 7, 31, 20, 31, 38, 387, DateTimeKind.Local).AddTicks(7450), null, "دانشگاه تهران" },
                    { new Guid("acf727a7-a55a-4af5-8167-0eb61bc9d916"), new DateTime(2022, 7, 31, 20, 31, 38, 387, DateTimeKind.Local).AddTicks(7475), null, "دانشگاه صنعتی امیرکبیر" },
                    { new Guid("c1f0c206-d1d3-4bd0-9c9a-5b4e61649fdf"), new DateTime(2022, 7, 31, 20, 31, 38, 387, DateTimeKind.Local).AddTicks(7398), null, "دانشگاه شهید بهشتی" },
                    { new Guid("f8004ff8-c898-4fcd-9f32-1d6740d2eafe"), new DateTime(2022, 7, 31, 20, 31, 38, 387, DateTimeKind.Local).AddTicks(7483), null, "دانشگاه صنعتی صنعتی شریف" }
                });

            migrationBuilder.InsertData(
                table: "Faculties",
                columns: new[] { "id", "CreateTime", "DeleteTime", "Name" },
                values: new object[,]
                {
                    { new Guid("1eee1ee5-e2d6-44bd-ae5c-72606c6c7ddb"), new DateTime(2022, 7, 31, 20, 31, 38, 387, DateTimeKind.Local).AddTicks(7610), null, "دانشکده رواشناسی و علوم تربیتی" },
                    { new Guid("380a5ee6-8701-4203-ad7b-e9651d88e63c"), new DateTime(2022, 7, 31, 20, 31, 38, 387, DateTimeKind.Local).AddTicks(7614), null, "دانشکده معماری" },
                    { new Guid("7e1fe968-e3c7-4e51-8360-7bfbc72cc555"), new DateTime(2022, 7, 31, 20, 31, 38, 387, DateTimeKind.Local).AddTicks(7605), null, "دانشکده حقوق" },
                    { new Guid("d1208c45-9f94-468f-a881-0c7bc8b52701"), new DateTime(2022, 7, 31, 20, 31, 38, 387, DateTimeKind.Local).AddTicks(7618), null, "دانشکده علوم پایه" },
                    { new Guid("f27ddd1d-03b1-44d4-bb9e-3f9375b25206"), new DateTime(2022, 7, 31, 20, 31, 38, 387, DateTimeKind.Local).AddTicks(7594), null, "دانشکده برق و کامپیوتر" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "id", "CreateTime", "DeleteTime", "Name" },
                values: new object[,]
                {
                    { new Guid("79e8d250-cd9d-45f2-b0b9-efedb4942e81"), new DateTime(2022, 7, 31, 20, 31, 38, 387, DateTimeKind.Local).AddTicks(7680), null, "Student" },
                    { new Guid("985518f0-3d57-417b-98ec-bf5b9e22d8f8"), new DateTime(2022, 7, 31, 20, 31, 38, 387, DateTimeKind.Local).AddTicks(7688), null, "Company" },
                    { new Guid("fdcf3bfc-7468-4a54-b9bf-6cbd3b649396"), new DateTime(2022, 7, 31, 20, 31, 38, 387, DateTimeKind.Local).AddTicks(7671), null, "Admin" },
                    { new Guid("ffda95ea-8f3d-4fc2-904b-22be34e6bd94"), new DateTime(2022, 7, 31, 20, 31, 38, 387, DateTimeKind.Local).AddTicks(7684), null, "Professor" }
                });

            migrationBuilder.InsertData(
                table: "WorkFields",
                columns: new[] { "id", "CreateTime", "DeleteTime", "Name" },
                values: new object[,]
                {
                    { new Guid("1bac87f0-89d8-49d3-8a1f-edd7100a19f3"), new DateTime(2022, 7, 31, 20, 31, 38, 387, DateTimeKind.Local).AddTicks(7759), null, "هوش مصنوعی" },
                    { new Guid("22b09c11-4191-42cf-bea0-1dffb5c1f754"), new DateTime(2022, 7, 31, 20, 31, 38, 387, DateTimeKind.Local).AddTicks(7753), null, "شبکه" },
                    { new Guid("3a042889-093e-490e-b471-16dab03a0040"), new DateTime(2022, 7, 31, 20, 31, 38, 387, DateTimeKind.Local).AddTicks(7763), null, "شبکه‌های پیچیده" },
                    { new Guid("3bbc344d-5003-423b-91f1-fbcd6d22ff61"), new DateTime(2022, 7, 31, 20, 31, 38, 387, DateTimeKind.Local).AddTicks(7738), null, "نرم افزار" },
                    { new Guid("850b5e1e-096d-49bf-aed3-a8e86c32470a"), new DateTime(2022, 7, 31, 20, 31, 38, 387, DateTimeKind.Local).AddTicks(7745), null, "علوم داده" },
                    { new Guid("a9f948c9-f793-428d-982c-ccf479df720f"), new DateTime(2022, 7, 31, 20, 31, 38, 387, DateTimeKind.Local).AddTicks(7742), null, "سخت افزار" },
                    { new Guid("c9e5bab2-778a-47a3-865e-dbfd9d250f95"), new DateTime(2022, 7, 31, 20, 31, 38, 387, DateTimeKind.Local).AddTicks(7728), null, "هوش مصنوعی" },
                    { new Guid("dd2a1d73-e4fa-4639-b87f-0674cce6ab00"), new DateTime(2022, 7, 31, 20, 31, 38, 387, DateTimeKind.Local).AddTicks(7767), null, "فناوری اطلاعات" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CoAnnouncements_Projectid",
                table: "CoAnnouncements",
                column: "Projectid");

            migrationBuilder.AddForeignKey(
                name: "FK_CoAnnouncements_Projects_Projectid",
                table: "CoAnnouncements",
                column: "Projectid",
                principalTable: "Projects",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_SavedProject_Projects_Projectid",
                table: "SavedProject",
                column: "Projectid",
                principalTable: "Projects",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SavedProject_Users_Userid",
                table: "SavedProject",
                column: "Userid",
                principalTable: "Users",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
